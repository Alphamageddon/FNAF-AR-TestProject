Shader "Forsaken/Simple_Animatronic" {
    Properties {
        [Header(Base Textures)]
        _MainTex ("Base Color", 2D) = "white" {}
        _BumpMap ("Normal Map", 2D) = "bump" {}
        _EmissionMap ("Emission Map", 2D) = "black" {}
        _MetallicGlossMap ("Metallic (R) Smoothness (A)", 2D) = "white" {}
        
        [Header(Paint Layer)]
        _PaintTex ("Paint Color", 2D) = "white" {}
        _PaintNormal ("Paint Normal", 2D) = "bump" {}
        _PaintMask ("Paint Mask (A)", 2D) = "white" {}
        _PaintWear ("Paint Wear Amount", Range(0, 1)) = 0.3
        
        [Header(Grunge and Wear)]
        _GrungeTex ("Grunge Map (RGB)", 2D) = "white" {}
        _DirtColor ("Dirt Color", Color) = (0.4, 0.35, 0.3, 1)
        _DirtAmount ("Dirt Amount", Range(0, 1)) = 0.5
        _ScratchAmount ("Scratch Amount", Range(0, 1)) = 0.3
        _WearAmount ("Overall Wear", Range(0, 1)) = 0.5
        
        [Header(Material Properties)]
        _Metallic ("Metallic", Range(0, 1)) = 0.5
        _Smoothness ("Smoothness", Range(0, 1)) = 0.5
        _BumpScale ("Normal Intensity", Range(0, 2)) = 1.0
        
        [Header(Emission)]
        _EmissionColor ("Emission Color", Color) = (0, 0, 0, 1)
        _EmissionPower ("Emission Power", Range(0, 10)) = 1
        [HDR] _GlowColor ("Eye Glow Color", Color) = (1, 0.1, 0, 1)
        _GlowPower ("Eye Glow Power", Range(0, 5)) = 0
        
        [Header(Vertex Animation)]
        _VertexNoise ("Vertex Noise Texture", 2D) = "white" {}
        _VertexAmount ("Twitch Amount", Range(0, 0.02)) = 0
        _VertexSpeed ("Twitch Speed", Range(0, 10)) = 2
        _VertexMask ("Vertex Animation Mask", 2D) = "white" {}
    }
    
    SubShader {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows vertex:vert
        #pragma target 3.0

        sampler2D _MainTex;
        sampler2D _BumpMap;
        sampler2D _EmissionMap;
        sampler2D _MetallicGlossMap;
        sampler2D _PaintTex;
        sampler2D _PaintNormal;
        sampler2D _PaintMask;
        sampler2D _GrungeTex;
        sampler2D _VertexNoise;
        sampler2D _VertexMask;

        struct Input {
            float2 uv_MainTex;
            float2 uv_GrungeTex;
            float2 uv_VertexNoise;
        };

        half _Metallic;
        half _Smoothness;
        half _BumpScale;
        half _PaintWear;
        half _DirtAmount;
        half _ScratchAmount;
        half _WearAmount;
        half _GlowPower;
        half _VertexAmount;
        half _VertexSpeed;
        half _EmissionPower;
        
        fixed4 _DirtColor;
        fixed4 _EmissionColor;
        fixed4 _GlowColor;

        void vert(inout appdata_full v) {
            // Only apply vertex animation if amount is greater than 0
            if (_VertexAmount > 0.001) {
                // Sample the mask to control where animation happens
                float mask = tex2Dlod(_VertexMask, float4(v.texcoord.xy, 0, 0)).r;
                
                // Create localized noise instead of uniform pulsing
                float time = _Time.y * _VertexSpeed;
                float noise1 = sin(time + v.vertex.x * 10) * 0.5 + 0.5;
                float noise2 = sin(time * 1.3 + v.vertex.z * 10) * 0.5 + 0.5;
                float combinedNoise = noise1 * noise2;
                
                // Apply displacement only along the normal, scaled by mask
                float3 displacement = v.normal * combinedNoise * _VertexAmount * mask;
                v.vertex.xyz += displacement;
            }
        }

        void surf(Input IN, inout SurfaceOutputStandard o) {
            // Base textures
            fixed4 baseColor = tex2D(_MainTex, IN.uv_MainTex);
            fixed3 baseNormal = UnpackScaleNormal(tex2D(_BumpMap, IN.uv_MainTex), _BumpScale);
            fixed4 metallicGloss = tex2D(_MetallicGlossMap, IN.uv_MainTex);
            fixed4 emission = tex2D(_EmissionMap, IN.uv_MainTex);
            
            // Paint layer
            fixed4 paintColor = tex2D(_PaintTex, IN.uv_MainTex);
            fixed3 paintNormal = UnpackScaleNormal(tex2D(_PaintNormal, IN.uv_MainTex), _BumpScale);
            fixed paintMask = tex2D(_PaintMask, IN.uv_MainTex).a;
            
            // Grunge textures with different scales
            fixed dirt = tex2D(_GrungeTex, IN.uv_GrungeTex * 4).r;
            fixed scratches = tex2D(_GrungeTex, IN.uv_GrungeTex * 8).g;
            fixed wear = tex2D(_GrungeTex, IN.uv_GrungeTex * 2).b;
            
            // Create wear mask
            float wearMask = lerp(1, wear, _WearAmount);
            float scratchMask = lerp(1, scratches, _ScratchAmount);
            float dirtMask = lerp(1, dirt, _DirtAmount);
            
            // Combine wear effects
            float paintWearMask = paintMask * (1 - _PaintWear * wearMask);
            float combinedWear = wearMask * scratchMask * dirtMask;
            
            // Mix base and paint based on wear
            fixed4 albedo = lerp(baseColor, paintColor, paintWearMask);
            
            // Add dirt on top
            albedo = lerp(albedo, _DirtColor, combinedWear * 0.4);
            
            // Blend normals
            fixed3 normal = lerp(baseNormal, paintNormal, paintWearMask);
            
            // Adjust metallic/smoothness based on wear
            float metallic = lerp(metallicGloss.r, _Metallic, combinedWear * 0.5);
            float smoothness = lerp(metallicGloss.a * _Smoothness, 0.2, combinedWear);
            
            // Emission
            fixed3 finalEmission = emission.rgb * _EmissionColor.rgb * _EmissionPower;
            finalEmission += _GlowColor.rgb * _GlowPower;
            
            // Output
            o.Albedo = albedo.rgb;
            o.Normal = normal;
            o.Metallic = metallic;
            o.Smoothness = smoothness;
            o.Emission = finalEmission;
            o.Alpha = 1;
        }
        ENDCG
    }
    
    FallBack "Standard"
}