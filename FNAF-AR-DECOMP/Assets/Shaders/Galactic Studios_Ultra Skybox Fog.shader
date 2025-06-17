Shader "Galactic Studios/Ultra Skybox Fog"
{
  Properties
  {
    _Tint ("Tint Colour", Color) = (0.5,0.5,0.5,0.5)
    [Gamma] _Exposure ("Exposure", Range(0, 8)) = 1
    _Rotation ("Rotation", Range(0, 360)) = 0
    [NoScaleOffset] _Tex ("Cubemap   (HDR)", Cube) = "grey" {}
    _FogCol ("Fog Colour", Color) = (0.5,0.5,0.5,0.5)
    _FogStart ("Fog Begin", Range(0, 1)) = 0
    _FogEnd ("Fog End", Range(0, 1)) = 0.4
    _FogIntens ("Fog Density", Range(0, 1)) = 1
    _MieIntens ("Mie Intensity", Range(0, 2)) = 0
    _MieTint ("Mie Tint", Color) = (0.5,0.5,0.5,0.5)
    _MieSize ("Mie Size", Range(0, 1)) = 0.8
    _SunDir ("Sun Direction", Range(0, 360)) = 0
    [Toggle] _FogBottom ("Apply Fog To The Bottom Of The Sky?", float) = 0
  }
  SubShader
  {
    Tags
    { 
      "PreviewType" = "Skybox"
      "QUEUE" = "Background"
      "RenderType" = "Background"
    }
    Pass // ind: 1, name: 
    {
      Tags
      { 
        "PreviewType" = "Skybox"
        "QUEUE" = "Background"
        "RenderType" = "Background"
      }
      ZWrite Off
      Cull Off
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
      //uniform float4x4 unity_ObjectToWorld;
      //uniform float4x4 unity_MatrixVP;
      uniform float _Rotation;
      uniform float4 _Tex_HDR;
      uniform float4 _Tint;
      uniform float _Exposure;
      uniform float4 _FogCol;
      uniform float _FogStart;
      uniform float _FogEnd;
      uniform float _FogIntens;
      uniform float _MieIntens;
      uniform float _SunDir;
      uniform float4 _MieTint;
      uniform float _FogBottom;
      uniform float _MieSize;
      uniform samplerCUBE _Tex;
      struct appdata_t
      {
          float4 vertex :POSITION0;
      };
      
      struct OUT_Data_Vert
      {
          float3 texcoord :TEXCOORD0;
          float4 vertex :SV_POSITION;
      };
      
      struct v2f
      {
          float3 texcoord :TEXCOORD0;
      };
      
      struct OUT_Data_Frag
      {
          float4 color :SV_Target0;
      };
      
      float4 u_xlat0;
      float4 u_xlat1;
      float3 u_xlat2;
      float u_xlat3;
      OUT_Data_Vert vert(appdata_t in_v)
      {
          OUT_Data_Vert out_v;
          u_xlat0.x = (_Rotation * 0.0174532942);
          u_xlat1.x = cos(u_xlat0.x);
          u_xlat0.x = sin(u_xlat0.x);
          u_xlat2.x = (-u_xlat0.x);
          u_xlat2.y = u_xlat1.x;
          u_xlat2.z = u_xlat0.x;
          u_xlat0.x = dot(u_xlat2.zy, in_v.vertex.xz);
          u_xlat3 = dot(u_xlat2.yx, in_v.vertex.xz);
          u_xlat1 = (in_v.vertex.yyyy * conv_mxt4x4_1(unity_ObjectToWorld));
          u_xlat1 = ((conv_mxt4x4_0(unity_ObjectToWorld) * float4(u_xlat3, u_xlat3, u_xlat3, u_xlat3)) + u_xlat1);
          u_xlat0 = ((conv_mxt4x4_2(unity_ObjectToWorld) * u_xlat0.xxxx) + u_xlat1);
          u_xlat0 = (u_xlat0 + conv_mxt4x4_3(unity_ObjectToWorld));
          out_v.vertex = mul(unity_MatrixVP, u_xlat0);
          out_v.texcoord.xyz = in_v.vertex.xyz;
          return out_v;
      }
      
      #define CODE_BLOCK_FRAGMENT
      float3 u_xlat0_d;
      float2 u_xlat1_d;
      float4 u_xlat16_1;
      float3 u_xlat16_2;
      float u_xlat3_d;
      float u_xlat16_3;
      float u_xlat9;
      int u_xlatb9;
      float u_xlat16_11;
      OUT_Data_Frag frag(v2f in_f)
      {
          OUT_Data_Frag out_f;
          u_xlat0_d.x = (_SunDir * 0.0174532942);
          u_xlat1_d.x = cos(u_xlat0_d.x);
          u_xlat0_d.x = sin(u_xlat0_d.x);
          u_xlat1_d.y = u_xlat0_d.x;
          u_xlat0_d.x = dot(u_xlat1_d.xy, in_f.texcoord.xz);
          #ifdef UNITY_ADRENO_ES3
          u_xlat0_d.x = min(max(u_xlat0_d.x, 0), 1);
          #else
          u_xlat0_d.x = clamp(u_xlat0_d.x, 0, 1);
          #endif
          u_xlat16_2.x = ((-_MieSize) + 1);
          u_xlat0_d.x = (u_xlat0_d.x + (-u_xlat16_2.x));
          u_xlat16_3 = ((-u_xlat16_2.x) + 1);
          u_xlat16_3 = (float(1) / u_xlat16_3);
          u_xlat0_d.x = (u_xlat16_3 * u_xlat0_d.x);
          #ifdef UNITY_ADRENO_ES3
          u_xlat0_d.x = min(max(u_xlat0_d.x, 0), 1);
          #else
          u_xlat0_d.x = clamp(u_xlat0_d.x, 0, 1);
          #endif
          u_xlat3_d = ((u_xlat0_d.x * (-2)) + 3);
          u_xlat0_d.x = (u_xlat0_d.x * u_xlat0_d.x);
          u_xlat0_d.x = (u_xlat0_d.x * u_xlat3_d);
          u_xlat0_d.x = (u_xlat0_d.x * _MieIntens);
          u_xlat0_d.xyz = (u_xlat0_d.xxx * _MieTint.xyz);
          u_xlat0_d.xyz = ((u_xlat0_d.xyz * float3(4.5947938, 4.5947938, 4.5947938)) + float3(1, 1, 1));
          u_xlat16_1 = texCUBE(_Tex, in_f.texcoord.xyz);
          u_xlat16_2.x = (u_xlat16_1.w + (-1));
          u_xlat16_2.x = ((_Tex_HDR.w * u_xlat16_2.x) + 1);
          u_xlat16_2.x = log2(u_xlat16_2.x);
          u_xlat16_2.x = (u_xlat16_2.x * _Tex_HDR.y);
          u_xlat16_2.x = exp2(u_xlat16_2.x);
          u_xlat16_2.x = (u_xlat16_2.x * _Tex_HDR.x);
          u_xlat16_2.xyz = (u_xlat16_1.xyz * u_xlat16_2.xxx);
          u_xlat16_2.xyz = (u_xlat16_2.xyz * _Tint.xyz);
          u_xlat16_2.xyz = (u_xlat16_2.xyz * float3(4.5947938, 4.5947938, 4.5947938));
          u_xlat0_d.xyz = ((_FogCol.xyz * u_xlat0_d.xyz) + (-u_xlat16_2.xyz));
          #ifdef UNITY_ADRENO_ES3
          u_xlatb9 = (_FogBottom==0);
          #else
          u_xlatb9 = (_FogBottom==0);
          #endif
          u_xlat9 = (u_xlatb9)?(abs(in_f.texcoord.y)):(in_f.texcoord.y);
          u_xlat9 = (((-_FogStart) * 2) + u_xlat9);
          u_xlat16_11 = (_FogStart + _FogStart);
          u_xlat16_1.x = ((_FogEnd * 2) + (-u_xlat16_11));
          u_xlat16_1.x = (float(1) / u_xlat16_1.x);
          u_xlat9 = (u_xlat9 * u_xlat16_1.x);
          #ifdef UNITY_ADRENO_ES3
          u_xlat9 = min(max(u_xlat9, 0), 1);
          #else
          u_xlat9 = clamp(u_xlat9, 0, 1);
          #endif
          u_xlat1_d.x = ((u_xlat9 * (-2)) + 3);
          u_xlat9 = (u_xlat9 * u_xlat9);
          u_xlat9 = (((-u_xlat1_d.x) * u_xlat9) + 1);
          u_xlat9 = (u_xlat9 * _FogIntens);
          #ifdef UNITY_ADRENO_ES3
          u_xlat9 = min(max(u_xlat9, 0), 1);
          #else
          u_xlat9 = clamp(u_xlat9, 0, 1);
          #endif
          u_xlat0_d.xyz = ((float3(u_xlat9, u_xlat9, u_xlat9) * u_xlat0_d.xyz) + u_xlat16_2.xyz);
          out_f.color.xyz = (u_xlat0_d.xyz * float3(_Exposure, _Exposure, _Exposure));
          out_f.color.w = 1;
          return out_f;
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack Off
}
