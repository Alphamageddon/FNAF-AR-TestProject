Shader "Unlit/ShieldFX"
{
  Properties
  {
    _MainColor ("MainColor", Color) = (1,1,1,1)
    _MainTex ("Texture", 2D) = "white" {}
    _Fresnel ("Fresnel Intensity", Range(0, 200)) = 3
    _FresnelWidth ("Fresnel Width", Range(0, 2)) = 3
    _Distort ("Distort", Range(0, 100)) = 1
    _IntersectionThreshold ("Highlight of intersection threshold", Range(0, 1)) = 0.1
    _ScrollSpeedU ("Scroll U Speed", float) = 2
    _ScrollSpeedV ("Scroll V Speed", float) = 0
  }
  SubShader
  {
    Tags
    { 
      "IGNOREPROJECTOR" = "true"
      "QUEUE" = "Overlay"
      "RenderType" = "Transparent"
    }
    Pass // ind: 1, name: 
    {
      Tags
      { 
      }
      ZClip Off
      ZWrite Off
      Cull Off
      Stencil
      { 
        Ref 0
        ReadMask 0
        WriteMask 0
        Pass Keep
        Fail Keep
        ZFail Keep
        PassFront Keep
        FailFront Keep
        ZFailFront Keep
        PassBack Keep
        FailBack Keep
        ZFailBack Keep
      } 
      // m_ProgramMask = 0
      
    } // end phase
    Pass // ind: 2, name: 
    {
      Tags
      { 
        "IGNOREPROJECTOR" = "true"
        "QUEUE" = "Overlay"
        "RenderType" = "Transparent"
      }
      Cull Off
      Blend SrcAlpha OneMinusSrcAlpha
      // m_ProgramMask = 6
      CGPROGRAM
      //#pragma target 4.0
      
      #pragma vertex vert
      #pragma fragment frag
      
      #include "UnityCG.cginc"
      #define conv_mxt4x4_0(mat4x4) float4(mat4x4[0].x,mat4x4[1].x,mat4x4[2].x,mat4x4[3].x)
      #define conv_mxt4x4_1(mat4x4) float4(mat4x4[0].y,mat4x4[1].y,mat4x4[2].y,mat4x4[3].y)
      #define conv_mxt4x4_2(mat4x4) float4(mat4x4[0].z,mat4x4[1].z,mat4x4[2].z,mat4x4[3].z)
      #define conv_mxt4x4_3(mat4x4) float4(mat4x4[0].w,mat4x4[1].w,mat4x4[2].w,mat4x4[3].w)
      
      
      #define CODE_BLOCK_VERTEX
      //uniform float4 _Time;
      //uniform float3 _WorldSpaceCameraPos;
      //uniform float4 _ProjectionParams;
      //uniform float4x4 unity_ObjectToWorld;
      //uniform float4x4 unity_WorldToObject;
      //uniform float4x4 unity_MatrixV;
      //uniform float4x4 unity_MatrixVP;
      uniform float4 _MainTex_ST;
      uniform float _FresnelWidth;
      uniform float _ScrollSpeedU;
      uniform float _ScrollSpeedV;
      //uniform float4 _ZBufferParams;
      uniform float4 _MainColor;
      uniform float4 _GrabTexture_TexelSize;
      uniform float _Fresnel;
      uniform float _Distort;
      uniform float _IntersectionThreshold;
      uniform sampler2D _CameraDepthTexture;
      uniform sampler2D _MainTex;
      uniform sampler2D _GrabTexture;
      struct appdata_t
      {
          float4 vertex :POSITION0;
          float4 normal :NORMAL0;
          float3 texcoord :TEXCOORD0;
      };
      
      struct OUT_Data_Vert
      {
          float2 texcoord :TEXCOORD0;
          float3 texcoord1 :TEXCOORD1;
          float4 texcoord2 :TEXCOORD2;
          float4 vertex :SV_POSITION;
      };
      
      struct v2f
      {
          float2 texcoord :TEXCOORD0;
          float3 texcoord1 :TEXCOORD1;
          float4 texcoord2 :TEXCOORD2;
      };
      
      struct OUT_Data_Frag
      {
          float4 color :SV_Target0;
      };
      
      float4 u_xlat0;
      float2 u_xlat16_0;
      float4 u_xlat1;
      float4 u_xlat2;
      float u_xlat16_3;
      float u_xlat16_7;
      float u_xlat14;
      OUT_Data_Vert vert(appdata_t in_v)
      {
          OUT_Data_Vert out_v;
          u_xlat16_0.xy = TRANSFORM_TEX(in_v.texcoord.xy, _MainTex);
          u_xlat1.xy = ((_Time.xx * float2(_ScrollSpeedU, _ScrollSpeedV)) + u_xlat16_0.xy);
          out_v.texcoord.xy = u_xlat1.xy;
          u_xlat1 = UnityObjectToClipPos(in_v.vertex);
          out_v.vertex = u_xlat1;
          u_xlat2.xyz = mul(unity_WorldToObject, _WorldSpaceCameraPos.xyz);
          u_xlat2.xyz = (u_xlat2.xyz + (-in_v.vertex.xyz));
          u_xlat2.xyz = normalize(u_xlat2.xyz);
          u_xlat16_3 = dot(in_v.normal.xyz, u_xlat2.xyz);
          #ifdef UNITY_ADRENO_ES3
          u_xlat16_3 = min(max(u_xlat16_3, 0), 1);
          #else
          u_xlat16_3 = clamp(u_xlat16_3, 0, 1);
          #endif
          u_xlat16_3 = ((-u_xlat16_3) + 1);
          u_xlat16_7 = ((-_FresnelWidth) + 1);
          u_xlat16_3 = ((-u_xlat16_7) + u_xlat16_3);
          u_xlat16_7 = ((-u_xlat16_7) + 1);
          u_xlat16_7 = (float(1) / u_xlat16_7);
          u_xlat16_3 = (u_xlat16_7 * u_xlat16_3);
          #ifdef UNITY_ADRENO_ES3
          u_xlat16_3 = min(max(u_xlat16_3, 0), 1);
          #else
          u_xlat16_3 = clamp(u_xlat16_3, 0, 1);
          #endif
          u_xlat16_7 = ((u_xlat16_3 * (-2)) + 3);
          u_xlat16_3 = (u_xlat16_3 * u_xlat16_3);
          u_xlat16_3 = (u_xlat16_3 * u_xlat16_7);
          u_xlat2.xyz = float3((float3(u_xlat16_3, u_xlat16_3, u_xlat16_3) * float3(0.5, 0.5, 0.5)));
          out_v.texcoord1.xyz = u_xlat2.xyz;
          u_xlat2.x = (u_xlat0.y * conv_mxt4x4_1(unity_MatrixV).z);
          u_xlat2.x = ((conv_mxt4x4_0(unity_MatrixV).z * u_xlat0.x) + u_xlat2.x);
          u_xlat2.x = ((conv_mxt4x4_2(unity_MatrixV).z * u_xlat0.z) + u_xlat2.x);
          u_xlat2.x = ((conv_mxt4x4_3(unity_MatrixV).z * u_xlat0.w) + u_xlat2.x);
          u_xlat1.z = (-u_xlat2.x);
          u_xlat2.x = (u_xlat1.y * _ProjectionParams.x);
          u_xlat2.w = (u_xlat2.x * 0.5);
          u_xlat2.xz = (u_xlat1.xw * float2(0.5, 0.5));
          u_xlat1.xy = (u_xlat2.zz + u_xlat2.xw);
          out_v.texcoord2 = u_xlat1;
          return out_v;
      }
      
      #define CODE_BLOCK_FRAGMENT
      float4 u_xlat16_0_d;
      float u_xlat1_d;
      float3 u_xlat16_1;
      float u_xlat10_1;
      float3 u_xlat16_2;
      float3 u_xlat10_3;
      float3 u_xlat16_4;
      float u_xlat16_5;
      float2 u_xlat16_10;
      OUT_Data_Frag frag(v2f in_f)
      {
          OUT_Data_Frag out_f;
          u_xlat16_0_d.xy = (in_f.texcoord2.xy / in_f.texcoord2.ww);
          u_xlat10_1 = tex2D(_CameraDepthTexture, u_xlat16_0_d.xy).x;
          u_xlat1_d = ((_ZBufferParams.z * u_xlat10_1) + _ZBufferParams.w);
          u_xlat1_d = (float(1) / u_xlat1_d);
          u_xlat1_d = (u_xlat1_d + (-in_f.texcoord2.z));
          u_xlat1_d = (abs(u_xlat1_d) / _IntersectionThreshold);
          #ifdef UNITY_ADRENO_ES3
          u_xlat1_d = min(max(u_xlat1_d, 0), 1);
          #else
          u_xlat1_d = clamp(u_xlat1_d, 0, 1);
          #endif
          u_xlat16_0_d.x = (((gl_FrontFacing)?(4294967295):(uint(0))!=uint(0)))?(1):((-1));
          u_xlat16_0_d.x = (u_xlat16_0_d.x * u_xlat1_d);
          u_xlat16_5 = ((-u_xlat1_d) + 1);
          u_xlat16_0_d.xzw = (u_xlat16_0_d.xxx * in_f.texcoord1.xyz);
          u_xlat16_2.x = log2(_Fresnel);
          u_xlat16_2.xyz = (u_xlat16_0_d.xzw * u_xlat16_2.xxx);
          u_xlat16_2.xyz = exp2(u_xlat16_2.xyz);
          u_xlat16_2.xyz = (u_xlat16_2.xyz * _MainColor.xyz);
          u_xlat16_1.xyz = tex2D(_MainTex, in_f.texcoord.xy).xyz;
          u_xlat16_10.xy = ((u_xlat16_1.xy * float2(2, 2)) + float2(-1, (-1)));
          u_xlat16_10.xy = (u_xlat16_10.xy * float2(float2(_Distort, _Distort)));
          u_xlat16_10.xy = ((u_xlat16_10.xy * _GrabTexture_TexelSize.xy) + in_f.texcoord2.xy);
          u_xlat16_10.xy = (u_xlat16_10.xy / in_f.texcoord2.ww);
          u_xlat10_3.xyz = tex2D(_GrabTexture, u_xlat16_10.xy).xyz;
          u_xlat16_4.xyz = ((_MainColor.xyz * _MainColor.www) + float3(1, 1, 1));
          u_xlat16_4.xyz = (u_xlat10_3.xyz * u_xlat16_4.xyz);
          u_xlat16_2.xyz = ((u_xlat16_1.xyz * u_xlat16_2.xyz) + (-u_xlat16_4.xyz));
          u_xlat16_0_d.xzw = ((u_xlat16_0_d.xxx * u_xlat16_2.xyz) + u_xlat16_4.xyz);
          u_xlat1_d = (((gl_FrontFacing)?(4294967295):(uint(0))!=uint(0)))?(0.0299999993):(0.300000012);
          u_xlat16_5 = (u_xlat16_5 * u_xlat1_d);
          u_xlat16_2.xyz = (float3(u_xlat16_5, u_xlat16_5, u_xlat16_5) * _MainColor.xyz);
          out_f.color.xyz = ((u_xlat16_2.xyz * float3(_Fresnel, _Fresnel, _Fresnel)) + u_xlat16_0_d.xzw);
          out_f.color.w = 0.899999976;
          return out_f;
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack Off
}
