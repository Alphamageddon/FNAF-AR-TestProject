Shader "Shrinkwrap Objects"
{
  Properties
  {
    _Color ("", Color) = (1,1,1,1)
    _MainTex ("", 2D) = "white" {}
    _Glossiness ("", Range(0, 1)) = 0.5
    [Gamma] _Metallic ("", Range(0, 1)) = 0
    _BumpScale ("", float) = 1
    _BumpMap ("", 2D) = "bump" {}
    _OcclusionStrength ("", Range(0, 1)) = 1
    _OcclusionMap ("", 2D) = "white" {}
    _MapScale ("", float) = 1
    _Cutoff ("Alpha Cutoff", Range(0, 1)) = 0.5
  }
  SubShader
  {
    Tags
    { 
      "RenderType" = "TransparentCutout"
    }
    Pass // ind: 1, name: FORWARD
    {
      Name "FORWARD"
      Tags
      { 
        "LIGHTMODE" = "FORWARDBASE"
        "RenderType" = "TransparentCutout"
        "SHADOWSUPPORT" = "true"
      }
      ColorMask RGB
      // m_ProgramMask = 6
      CGPROGRAM
      #pragma multi_compile DIRECTIONAL
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
      //uniform float4x4 unity_WorldToObject;
      //uniform float4x4 unity_MatrixVP;
      //uniform float3 _WorldSpaceCameraPos;
      //uniform float4 _WorldSpaceLightPos0;
      //uniform float4 unity_SpecCube0_HDR;
      uniform float4 _LightColor0;
      uniform float4 _Color;
      uniform float _Glossiness;
      uniform float _Metallic;
      uniform float _MapScale;
      uniform float _Cutoff;
      uniform sampler2D _MainTex;
      uniform sampler2D unity_NHxRoughness;
      //uniform samplerCUBE unity_SpecCube0;
      struct appdata_t
      {
          float4 vertex :POSITION0;
          float3 normal :NORMAL0;
          float4 color :COLOR0;
      };
      
      struct OUT_Data_Vert
      {
          float3 texcoord :TEXCOORD0;
          float3 texcoord1 :TEXCOORD1;
          float4 color :COLOR0;
          float3 texcoord2 :TEXCOORD2;
          float3 texcoord3 :TEXCOORD3;
          float4 texcoord6 :TEXCOORD6;
          float4 texcoord7 :TEXCOORD7;
          float4 vertex :SV_POSITION;
      };
      
      struct v2f
      {
          float3 texcoord :TEXCOORD0;
          float3 texcoord1 :TEXCOORD1;
          float4 color :COLOR0;
          float3 texcoord2 :TEXCOORD2;
          float3 texcoord3 :TEXCOORD3;
      };
      
      struct OUT_Data_Frag
      {
          float4 color :SV_Target0;
      };
      
      float4 u_xlat0;
      float4 u_xlat1;
      float u_xlat6;
      OUT_Data_Vert vert(appdata_t in_v)
      {
          OUT_Data_Vert out_v;
          u_xlat0 = (in_v.vertex.yyyy * conv_mxt4x4_1(unity_ObjectToWorld));
          u_xlat0 = ((conv_mxt4x4_0(unity_ObjectToWorld) * in_v.vertex.xxxx) + u_xlat0);
          u_xlat0 = ((conv_mxt4x4_2(unity_ObjectToWorld) * in_v.vertex.zzzz) + u_xlat0);
          u_xlat1 = (u_xlat0 + conv_mxt4x4_3(unity_ObjectToWorld));
          out_v.texcoord1.xyz = ((conv_mxt4x4_3(unity_ObjectToWorld).xyz * in_v.vertex.www) + u_xlat0.xyz);
          out_v.vertex = mul(unity_MatrixVP, u_xlat1);
          u_xlat0.x = dot(in_v.normal.xyz, conv_mxt4x4_0(unity_WorldToObject).xyz);
          u_xlat0.y = dot(in_v.normal.xyz, conv_mxt4x4_1(unity_WorldToObject).xyz);
          u_xlat0.z = dot(in_v.normal.xyz, conv_mxt4x4_2(unity_WorldToObject).xyz);
          out_v.texcoord.xyz = normalize(u_xlat0.xyz);
          out_v.color = in_v.color;
          out_v.texcoord2.xyz = in_v.vertex.xyz;
          out_v.texcoord3.xyz = in_v.normal.xyz;
          out_v.texcoord6 = float4(0, 0, 0, 0);
          out_v.texcoord7 = float4(0, 0, 0, 0);
          return out_v;
      }
      
      #define CODE_BLOCK_FRAGMENT
      float3 u_xlat0_d;
      float4 u_xlat16_0;
      float4 u_xlat1_d;
      float4 u_xlat16_1;
      float4 u_xlat2;
      float4 u_xlat16_2;
      int u_xlatb2;
      float3 u_xlat16_3;
      float3 u_xlat4;
      float3 u_xlat16_5;
      float3 u_xlat16_6;
      float3 u_xlat7;
      float3 u_xlat16_8;
      float3 u_xlat16_9;
      float u_xlat14;
      float u_xlat30;
      float u_xlat32;
      float u_xlat16_33;
      float u_xlat16_35;
      OUT_Data_Frag frag(v2f in_f)
      {
          OUT_Data_Frag out_f;
          u_xlat0_d.x = dot(abs(in_f.texcoord3.xyz), abs(in_f.texcoord3.xyz));
          u_xlat0_d.x = rsqrt(u_xlat0_d.x);
          u_xlat0_d.xyz = (u_xlat0_d.xxx * abs(in_f.texcoord3.xyz));
          u_xlat30 = dot(u_xlat0_d.xyz, float3(1, 1, 1));
          u_xlat0_d.xyz = (u_xlat0_d.xyz / float3(u_xlat30, u_xlat30, u_xlat30));
          u_xlat1_d = (in_f.texcoord2.yzzx * float4(_MapScale, _MapScale, _MapScale, _MapScale));
          u_xlat16_2 = tex2D(_MainTex, u_xlat1_d.zw);
          u_xlat16_1 = tex2D(_MainTex, u_xlat1_d.xy);
          u_xlat2 = (u_xlat0_d.yyyy * u_xlat16_2);
          u_xlat16_1 = ((u_xlat16_1 * u_xlat0_d.xxxx) + u_xlat2);
          u_xlat0_d.xy = (in_f.texcoord2.xy * float2(_MapScale, _MapScale));
          u_xlat16_2 = tex2D(_MainTex, u_xlat0_d.xy);
          u_xlat16_0 = ((u_xlat16_2 * u_xlat0_d.zzzz) + u_xlat16_1);
          u_xlat16_0 = (u_xlat16_0 * _Color);
          u_xlat16_3.x = ((u_xlat16_0.w * in_f.color.w) + (-_Cutoff));
          #ifdef UNITY_ADRENO_ES3
          u_xlatb2 = (u_xlat16_3.x<0);
          #else
          u_xlatb2 = (u_xlat16_3.x<0);
          #endif
          if(((int(u_xlatb2) * int(4294967295))!=0))
          {
              discard;
          }
          u_xlat2.xyz = ((-in_f.texcoord1.xyz) + _WorldSpaceCameraPos.xyz);
          u_xlat2.xyz = normalize(u_xlat2.xyz);
          u_xlat16_3.x = dot((-u_xlat2.xyz), in_f.texcoord.xyz);
          u_xlat16_3.x = (u_xlat16_3.x + u_xlat16_3.x);
          u_xlat16_3.xyz = ((in_f.texcoord.xyz * (-u_xlat16_3.xxx)) + (-u_xlat2.xyz));
          u_xlat4.z = ((-_Glossiness) + 1);
          u_xlat16_33 = (((-u_xlat4.z) * 0.699999988) + 1.70000005);
          u_xlat16_33 = (u_xlat16_33 * u_xlat4.z);
          u_xlat16_33 = (u_xlat16_33 * 6);
          u_xlat16_1 = UNITY_SAMPLE_TEXCUBE(unity_SpecCube0, float4(u_xlat16_3.xyz, u_xlat16_33));
          u_xlat16_3.x = (u_xlat16_1.w + (-1));
          u_xlat16_3.x = ((unity_SpecCube0_HDR.w * u_xlat16_3.x) + 1);
          u_xlat16_3.x = log2(u_xlat16_3.x);
          u_xlat16_3.x = (u_xlat16_3.x * unity_SpecCube0_HDR.y);
          u_xlat16_3.x = exp2(u_xlat16_3.x);
          u_xlat16_3.x = (u_xlat16_3.x * unity_SpecCube0_HDR.x);
          u_xlat16_3.xyz = (u_xlat16_1.xyz * u_xlat16_3.xxx);
          u_xlat16_5.xyz = ((u_xlat16_0.xyz * in_f.color.xyz) + float3(-0.0399999991, (-0.0399999991), (-0.0399999991)));
          u_xlat16_0 = (u_xlat16_0 * in_f.color);
          u_xlat16_5.xyz = ((float3(float3(_Metallic, _Metallic, _Metallic)) * u_xlat16_5.xyz) + float3(0.0399999991, 0.0399999991, 0.0399999991));
          u_xlat16_33 = (((-_Metallic) * 0.959999979) + 0.959999979);
          u_xlat16_35 = ((-u_xlat16_33) + _Glossiness);
          u_xlat16_35 = (u_xlat16_35 + 1);
          #ifdef UNITY_ADRENO_ES3
          u_xlat16_35 = min(max(u_xlat16_35, 0), 1);
          #else
          u_xlat16_35 = clamp(u_xlat16_35, 0, 1);
          #endif
          u_xlat16_6.xyz = ((-u_xlat16_5.xyz) + float3(u_xlat16_35, u_xlat16_35, u_xlat16_35));
          u_xlat7.xyz = normalize(in_f.texcoord.xyz);
          u_xlat32 = dot(u_xlat2.xyz, u_xlat7.xyz);
          u_xlat14 = u_xlat32;
          #ifdef UNITY_ADRENO_ES3
          u_xlat14 = min(max(u_xlat14, 0), 1);
          #else
          u_xlat14 = clamp(u_xlat14, 0, 1);
          #endif
          u_xlat32 = (u_xlat32 + u_xlat32);
          u_xlat2.xyz = ((u_xlat7.xyz * (-float3(u_xlat32, u_xlat32, u_xlat32))) + u_xlat2.xyz);
          u_xlat32 = dot(u_xlat7.xyz, _WorldSpaceLightPos0.xyz);
          #ifdef UNITY_ADRENO_ES3
          u_xlat32 = min(max(u_xlat32, 0), 1);
          #else
          u_xlat32 = clamp(u_xlat32, 0, 1);
          #endif
          u_xlat16_8.xyz = (float3(u_xlat32, u_xlat32, u_xlat32) * _LightColor0.xyz);
          u_xlat2.x = dot(u_xlat2.xyz, _WorldSpaceLightPos0.xyz);
          u_xlat2.x = (u_xlat2.x * u_xlat2.x);
          u_xlat4.x = (u_xlat2.x * u_xlat2.x);
          u_xlat2.x = tex2D(unity_NHxRoughness, u_xlat4.xz).x;
          u_xlat2.x = (u_xlat2.x * 16);
          u_xlat16_9.xyz = (u_xlat16_5.xyz * u_xlat2.xxx);
          u_xlat16_9.xyz = ((u_xlat16_0.xyz * float3(u_xlat16_33, u_xlat16_33, u_xlat16_33)) + u_xlat16_9.xyz);
          out_f.color.w = u_xlat16_0.w;
          u_xlat16_33 = ((-u_xlat14) + 1);
          u_xlat16_2.x = (u_xlat16_33 * u_xlat16_33);
          u_xlat16_2.x = (u_xlat16_33 * u_xlat16_2.x);
          u_xlat16_2.x = (u_xlat16_33 * u_xlat16_2.x);
          u_xlat16_5.xyz = ((u_xlat16_2.xxx * u_xlat16_6.xyz) + u_xlat16_5.xyz);
          u_xlat16_3.xyz = (u_xlat16_3.xyz * u_xlat16_5.xyz);
          out_f.color.xyz = ((u_xlat16_9.xyz * u_xlat16_8.xyz) + u_xlat16_3.xyz);
          return out_f;
      }
      
      
      ENDCG
      
    } // end phase
    Pass // ind: 2, name: FORWARD
    {
      Name "FORWARD"
      Tags
      { 
        "LIGHTMODE" = "FORWARDADD"
        "RenderType" = "TransparentCutout"
        "SHADOWSUPPORT" = "true"
      }
      ZWrite Off
      Blend One One
      ColorMask RGB
      // m_ProgramMask = 6
      CGPROGRAM
      #pragma multi_compile POINT
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
      //uniform float4x4 unity_WorldToObject;
      //uniform float4x4 unity_MatrixVP;
      uniform float4x4 unity_WorldToLight;
      //uniform float3 _WorldSpaceCameraPos;
      //uniform float4 _WorldSpaceLightPos0;
      uniform float4 _LightColor0;
      uniform float4 _Color;
      uniform float _Glossiness;
      uniform float _Metallic;
      uniform float _MapScale;
      uniform float _Cutoff;
      uniform sampler2D _MainTex;
      uniform sampler2D _LightTexture0;
      uniform sampler2D unity_NHxRoughness;
      struct appdata_t
      {
          float4 vertex :POSITION0;
          float3 normal :NORMAL0;
          float4 color :COLOR0;
      };
      
      struct OUT_Data_Vert
      {
          float3 texcoord :TEXCOORD0;
          float3 texcoord1 :TEXCOORD1;
          float4 color :COLOR0;
          float3 texcoord2 :TEXCOORD2;
          float3 texcoord3 :TEXCOORD3;
          float3 texcoord4 :TEXCOORD4;
          float4 texcoord5 :TEXCOORD5;
          float4 vertex :SV_POSITION;
      };
      
      struct v2f
      {
          float3 texcoord :TEXCOORD0;
          float3 texcoord1 :TEXCOORD1;
          float4 color :COLOR0;
          float3 texcoord2 :TEXCOORD2;
          float3 texcoord3 :TEXCOORD3;
      };
      
      struct OUT_Data_Frag
      {
          float4 color :SV_Target0;
      };
      
      float4 u_xlat0;
      float4 u_xlat1;
      float4 u_xlat2;
      float u_xlat10;
      OUT_Data_Vert vert(appdata_t in_v)
      {
          OUT_Data_Vert out_v;
          u_xlat1 = mul(unity_ObjectToWorld, float4(in_v.vertex.xyz,1.0));
          out_v.vertex = mul(unity_MatrixVP, u_xlat1);
          u_xlat1.x = dot(in_v.normal.xyz, conv_mxt4x4_0(unity_WorldToObject).xyz);
          u_xlat1.y = dot(in_v.normal.xyz, conv_mxt4x4_1(unity_WorldToObject).xyz);
          u_xlat1.z = dot(in_v.normal.xyz, conv_mxt4x4_2(unity_WorldToObject).xyz);
          out_v.texcoord.xyz = normalize(u_xlat1.xyz);
          out_v.texcoord1.xyz = ((conv_mxt4x4_3(unity_ObjectToWorld).xyz * in_v.vertex.www) + u_xlat0.xyz);
          u_xlat0 = ((conv_mxt4x4_3(unity_ObjectToWorld) * in_v.vertex.wwww) + u_xlat0);
          out_v.color = in_v.color;
          out_v.texcoord2.xyz = in_v.vertex.xyz;
          out_v.texcoord3.xyz = in_v.normal.xyz;
          u_xlat1.xyz = (u_xlat0.yyy * conv_mxt4x4_1(unity_WorldToLight).xyz);
          u_xlat1.xyz = ((conv_mxt4x4_0(unity_WorldToLight).xyz * u_xlat0.xxx) + u_xlat1.xyz);
          u_xlat0.xyz = ((conv_mxt4x4_2(unity_WorldToLight).xyz * u_xlat0.zzz) + u_xlat1.xyz);
          out_v.texcoord4.xyz = ((conv_mxt4x4_3(unity_WorldToLight).xyz * u_xlat0.www) + u_xlat0.xyz);
          out_v.texcoord5 = float4(0, 0, 0, 0);
          return out_v;
      }
      
      #define CODE_BLOCK_FRAGMENT
      float3 u_xlat0_d;
      float4 u_xlat16_0;
      float4 u_xlat1_d;
      float4 u_xlat16_1;
      float4 u_xlat2_d;
      float4 u_xlat16_2;
      int u_xlatb2;
      float3 u_xlat16_3;
      float3 u_xlat4;
      float3 u_xlat5;
      float3 u_xlat16_6;
      float u_xlat9;
      float u_xlat21;
      float u_xlat23;
      float u_xlat16_24;
      OUT_Data_Frag frag(v2f in_f)
      {
          OUT_Data_Frag out_f;
          u_xlat0_d.x = dot(abs(in_f.texcoord3.xyz), abs(in_f.texcoord3.xyz));
          u_xlat0_d.x = rsqrt(u_xlat0_d.x);
          u_xlat0_d.xyz = (u_xlat0_d.xxx * abs(in_f.texcoord3.xyz));
          u_xlat21 = dot(u_xlat0_d.xyz, float3(1, 1, 1));
          u_xlat0_d.xyz = (u_xlat0_d.xyz / float3(u_xlat21, u_xlat21, u_xlat21));
          u_xlat1_d = (in_f.texcoord2.yzzx * float4(_MapScale, _MapScale, _MapScale, _MapScale));
          u_xlat16_2 = tex2D(_MainTex, u_xlat1_d.zw);
          u_xlat16_1 = tex2D(_MainTex, u_xlat1_d.xy);
          u_xlat2_d = (u_xlat0_d.yyyy * u_xlat16_2);
          u_xlat16_1 = ((u_xlat16_1 * u_xlat0_d.xxxx) + u_xlat2_d);
          u_xlat0_d.xy = (in_f.texcoord2.xy * float2(_MapScale, _MapScale));
          u_xlat16_2 = tex2D(_MainTex, u_xlat0_d.xy);
          u_xlat16_0 = ((u_xlat16_2 * u_xlat0_d.zzzz) + u_xlat16_1);
          u_xlat16_0 = (u_xlat16_0 * _Color);
          u_xlat16_3.x = ((u_xlat16_0.w * in_f.color.w) + (-_Cutoff));
          #ifdef UNITY_ADRENO_ES3
          u_xlatb2 = (u_xlat16_3.x<0);
          #else
          u_xlatb2 = (u_xlat16_3.x<0);
          #endif
          if(((int(u_xlatb2) * int(4294967295))!=0))
          {
              discard;
          }
          u_xlat16_3.xyz = ((u_xlat16_0.xyz * in_f.color.xyz) + float3(-0.0399999991, (-0.0399999991), (-0.0399999991)));
          u_xlat16_0 = (u_xlat16_0 * in_f.color);
          u_xlat16_3.xyz = ((float3(float3(_Metallic, _Metallic, _Metallic)) * u_xlat16_3.xyz) + float3(0.0399999991, 0.0399999991, 0.0399999991));
          u_xlat2_d.xyz = ((-in_f.texcoord1.xyz) + _WorldSpaceCameraPos.xyz);
          u_xlat2_d.xyz = normalize(u_xlat2_d.xyz);
          u_xlat4.xyz = normalize(in_f.texcoord.xyz);
          u_xlat23 = dot(u_xlat2_d.xyz, u_xlat4.xyz);
          u_xlat23 = (u_xlat23 + u_xlat23);
          u_xlat2_d.xyz = ((u_xlat4.xyz * (-float3(u_xlat23, u_xlat23, u_xlat23))) + u_xlat2_d.xyz);
          u_xlat5.xyz = ((-in_f.texcoord1.xyz) + _WorldSpaceLightPos0.xyz);
          u_xlat5.xyz = normalize(u_xlat5.xyz);
          u_xlat2_d.x = dot(u_xlat2_d.xyz, u_xlat5.xyz);
          u_xlat9 = dot(u_xlat4.xyz, u_xlat5.xyz);
          #ifdef UNITY_ADRENO_ES3
          u_xlat9 = min(max(u_xlat9, 0), 1);
          #else
          u_xlat9 = clamp(u_xlat9, 0, 1);
          #endif
          u_xlat2_d.x = (u_xlat2_d.x * u_xlat2_d.x);
          u_xlat4.x = (u_xlat2_d.x * u_xlat2_d.x);
          u_xlat4.y = ((-_Glossiness) + 1);
          u_xlat2_d.x = tex2D(unity_NHxRoughness, u_xlat4.xy).x;
          u_xlat2_d.x = (u_xlat2_d.x * 16);
          u_xlat16_3.xyz = (u_xlat16_3.xyz * u_xlat2_d.xxx);
          u_xlat16_24 = (((-_Metallic) * 0.959999979) + 0.959999979);
          u_xlat16_3.xyz = ((u_xlat16_0.xyz * float3(u_xlat16_24, u_xlat16_24, u_xlat16_24)) + u_xlat16_3.xyz);
          out_f.color.w = u_xlat16_0.w;
          u_xlat2_d.xzw = (in_f.texcoord1.yyy * conv_mxt4x4_1(unity_WorldToLight).xyz);
          u_xlat2_d.xzw = ((conv_mxt4x4_0(unity_WorldToLight).xyz * in_f.texcoord1.xxx) + u_xlat2_d.xzw);
          u_xlat2_d.xzw = ((conv_mxt4x4_2(unity_WorldToLight).xyz * in_f.texcoord1.zzz) + u_xlat2_d.xzw);
          u_xlat2_d.xzw = (u_xlat2_d.xzw + conv_mxt4x4_3(unity_WorldToLight).xyz);
          u_xlat2_d.x = dot(u_xlat2_d.xzw, u_xlat2_d.xzw);
          u_xlat2_d.x = tex2D(_LightTexture0, u_xlat2_d.xx).x;
          u_xlat16_6.xyz = (u_xlat2_d.xxx * _LightColor0.xyz);
          u_xlat16_6.xyz = (float3(u_xlat9, u_xlat9, u_xlat9) * u_xlat16_6.xyz);
          out_f.color.xyz = (u_xlat16_3.xyz * u_xlat16_6.xyz);
          return out_f;
      }
      
      
      ENDCG
      
    } // end phase
    Pass // ind: 3, name: DEFERRED
    {
      Name "DEFERRED"
      Tags
      { 
        "LIGHTMODE" = "DEFERRED"
        "RenderType" = "TransparentCutout"
      }
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
      //uniform float4x4 unity_WorldToObject;
      //uniform float4x4 unity_MatrixVP;
      uniform float4 _Color;
      uniform float _Glossiness;
      uniform float _Metallic;
      uniform float _MapScale;
      uniform float _Cutoff;
      uniform sampler2D _MainTex;
      struct appdata_t
      {
          float4 vertex :POSITION0;
          float3 normal :NORMAL0;
          float4 color :COLOR0;
      };
      
      struct OUT_Data_Vert
      {
          float3 texcoord :TEXCOORD0;
          float3 texcoord1 :TEXCOORD1;
          float4 color :COLOR0;
          float3 texcoord2 :TEXCOORD2;
          float3 texcoord3 :TEXCOORD3;
          float4 texcoord5 :TEXCOORD5;
          float4 vertex :SV_POSITION;
      };
      
      struct v2f
      {
          float3 texcoord :TEXCOORD0;
          float4 color :COLOR0;
          float3 texcoord2 :TEXCOORD2;
          float3 texcoord3 :TEXCOORD3;
      };
      
      struct OUT_Data_Frag
      {
          float4 color :SV_Target0;
          float4 color1 :SV_Target1;
          float4 color2 :SV_Target2;
          float4 color3 :SV_Target3;
      };
      
      float4 u_xlat0;
      float4 u_xlat1;
      float u_xlat6;
      OUT_Data_Vert vert(appdata_t in_v)
      {
          OUT_Data_Vert out_v;
          u_xlat0 = (in_v.vertex.yyyy * conv_mxt4x4_1(unity_ObjectToWorld));
          u_xlat0 = ((conv_mxt4x4_0(unity_ObjectToWorld) * in_v.vertex.xxxx) + u_xlat0);
          u_xlat0 = ((conv_mxt4x4_2(unity_ObjectToWorld) * in_v.vertex.zzzz) + u_xlat0);
          u_xlat1 = (u_xlat0 + conv_mxt4x4_3(unity_ObjectToWorld));
          out_v.texcoord1.xyz = ((conv_mxt4x4_3(unity_ObjectToWorld).xyz * in_v.vertex.www) + u_xlat0.xyz);
          out_v.vertex = mul(unity_MatrixVP, u_xlat1);
          u_xlat0.x = dot(in_v.normal.xyz, conv_mxt4x4_0(unity_WorldToObject).xyz);
          u_xlat0.y = dot(in_v.normal.xyz, conv_mxt4x4_1(unity_WorldToObject).xyz);
          u_xlat0.z = dot(in_v.normal.xyz, conv_mxt4x4_2(unity_WorldToObject).xyz);
          out_v.texcoord.xyz = normalize(u_xlat0.xyz);
          out_v.color = in_v.color;
          out_v.texcoord2.xyz = in_v.vertex.xyz;
          out_v.texcoord3.xyz = in_v.normal.xyz;
          out_v.texcoord5 = float4(0, 0, 0, 0);
          return out_v;
      }
      
      #define CODE_BLOCK_FRAGMENT
      float4 u_xlat0_d;
      float4 u_xlat16_0;
      float4 u_xlat1_d;
      float4 u_xlat16_1;
      float4 u_xlat2;
      float4 u_xlat16_2;
      int u_xlatb2;
      float3 u_xlat16_3;
      float u_xlat12;
      OUT_Data_Frag frag(v2f in_f)
      {
          OUT_Data_Frag out_f;
          u_xlat0_d.x = dot(abs(in_f.texcoord3.xyz), abs(in_f.texcoord3.xyz));
          u_xlat0_d.x = rsqrt(u_xlat0_d.x);
          u_xlat0_d.xyz = (u_xlat0_d.xxx * abs(in_f.texcoord3.xyz));
          u_xlat12 = dot(u_xlat0_d.xyz, float3(1, 1, 1));
          u_xlat0_d.xyz = (u_xlat0_d.xyz / float3(u_xlat12, u_xlat12, u_xlat12));
          u_xlat1_d = (in_f.texcoord2.yzzx * float4(_MapScale, _MapScale, _MapScale, _MapScale));
          u_xlat16_2 = tex2D(_MainTex, u_xlat1_d.zw);
          u_xlat16_1 = tex2D(_MainTex, u_xlat1_d.xy);
          u_xlat2 = (u_xlat0_d.yyyy * u_xlat16_2);
          u_xlat16_1 = ((u_xlat16_1 * u_xlat0_d.xxxx) + u_xlat2);
          u_xlat0_d.xy = (in_f.texcoord2.xy * float2(_MapScale, _MapScale));
          u_xlat16_2 = tex2D(_MainTex, u_xlat0_d.xy);
          u_xlat16_0 = ((u_xlat16_2 * u_xlat0_d.zzzz) + u_xlat16_1);
          u_xlat16_0 = (u_xlat16_0 * _Color);
          u_xlat16_3.x = ((u_xlat16_0.w * in_f.color.w) + (-_Cutoff));
          #ifdef UNITY_ADRENO_ES3
          u_xlatb2 = (u_xlat16_3.x<0);
          #else
          u_xlatb2 = (u_xlat16_3.x<0);
          #endif
          if(((int(u_xlatb2) * int(4294967295))!=0))
          {
              discard;
          }
          u_xlat16_2.xyz = (u_xlat16_0.xyz * in_f.color.xyz);
          u_xlat16_3.xyz = ((u_xlat16_0.xyz * in_f.color.xyz) + float3(-0.0399999991, (-0.0399999991), (-0.0399999991)));
          out_f.color1.xyz = ((float3(float3(_Metallic, _Metallic, _Metallic)) * u_xlat16_3.xyz) + float3(0.0399999991, 0.0399999991, 0.0399999991));
          u_xlat16_3.x = (((-_Metallic) * 0.959999979) + 0.959999979);
          out_f.color.xyz = (u_xlat16_2.xyz * u_xlat16_3.xxx);
          out_f.color.w = 1;
          out_f.color1.w = _Glossiness;
          u_xlat0_d.xyz = ((in_f.texcoord.xyz * float3(0.5, 0.5, 0.5)) + float3(0.5, 0.5, 0.5));
          u_xlat0_d.w = 1;
          out_f.color2 = u_xlat0_d;
          out_f.color3 = float4(1, 1, 1, 1);
          return out_f;
      }
      
      
      ENDCG
      
    } // end phase
    Pass // ind: 4, name: ShadowCaster
    {
      Name "ShadowCaster"
      Tags
      { 
        "LIGHTMODE" = "SHADOWCASTER"
        "RenderType" = "TransparentCutout"
        "SHADOWSUPPORT" = "true"
      }
      // m_ProgramMask = 6
      CGPROGRAM
      #pragma multi_compile SHADOWS_DEPTH
      //#pragma target 4.0
      
      #pragma vertex vert
      #pragma fragment frag
      
      #include "UnityCG.cginc"
      #define conv_mxt4x4_0(mat4x4) float4(mat4x4[0].x,mat4x4[1].x,mat4x4[2].x,mat4x4[3].x)
      #define conv_mxt4x4_1(mat4x4) float4(mat4x4[0].y,mat4x4[1].y,mat4x4[2].y,mat4x4[3].y)
      #define conv_mxt4x4_2(mat4x4) float4(mat4x4[0].z,mat4x4[1].z,mat4x4[2].z,mat4x4[3].z)
      #define conv_mxt4x4_3(mat4x4) float4(mat4x4[0].w,mat4x4[1].w,mat4x4[2].w,mat4x4[3].w)
      
      
      #define CODE_BLOCK_VERTEX
      //uniform float4 _WorldSpaceLightPos0;
      //uniform float4 unity_LightShadowBias;
      //uniform float4x4 unity_ObjectToWorld;
      //uniform float4x4 unity_WorldToObject;
      //uniform float4x4 unity_MatrixVP;
      uniform float4 _Color;
      uniform float _MapScale;
      uniform float _Cutoff;
      uniform sampler2D _MainTex;
      struct appdata_t
      {
          float4 vertex :POSITION0;
          float3 normal :NORMAL0;
          float4 color :COLOR0;
      };
      
      struct OUT_Data_Vert
      {
          float3 texcoord1 :TEXCOORD1;
          float4 color :COLOR0;
          float3 texcoord2 :TEXCOORD2;
          float3 texcoord3 :TEXCOORD3;
          float4 vertex :SV_POSITION;
      };
      
      struct v2f
      {
          float4 color :COLOR0;
          float3 texcoord2 :TEXCOORD2;
          float3 texcoord3 :TEXCOORD3;
      };
      
      struct OUT_Data_Frag
      {
          float4 color :SV_Target0;
      };
      
      float4 u_xlat0;
      float4 u_xlat1;
      float4 u_xlat2;
      float u_xlat6;
      float u_xlat9;
      int u_xlatb9;
      OUT_Data_Vert vert(appdata_t in_v)
      {
          OUT_Data_Vert out_v;
          u_xlat0.x = dot(in_v.normal.xyz, conv_mxt4x4_0(unity_WorldToObject).xyz);
          u_xlat0.y = dot(in_v.normal.xyz, conv_mxt4x4_1(unity_WorldToObject).xyz);
          u_xlat0.z = dot(in_v.normal.xyz, conv_mxt4x4_2(unity_WorldToObject).xyz);
          u_xlat0.xyz = normalize(u_xlat0.xyz);
          u_xlat1 = mul(unity_ObjectToWorld, in_v.vertex);
          u_xlat2.xyz = (((-u_xlat1.xyz) * _WorldSpaceLightPos0.www) + _WorldSpaceLightPos0.xyz);
          u_xlat2.xyz = normalize(u_xlat2.xyz);
          u_xlat9 = dot(u_xlat0.xyz, u_xlat2.xyz);
          u_xlat9 = (((-u_xlat9) * u_xlat9) + 1);
          u_xlat9 = sqrt(u_xlat9);
          u_xlat9 = (u_xlat9 * unity_LightShadowBias.z);
          u_xlat0.xyz = (((-u_xlat0.xyz) * float3(u_xlat9, u_xlat9, u_xlat9)) + u_xlat1.xyz);
          #ifdef UNITY_ADRENO_ES3
          u_xlatb9 = (unity_LightShadowBias.z!=0);
          #else
          u_xlatb9 = (unity_LightShadowBias.z!=0);
          #endif
          u_xlat0.xyz = (int(u_xlatb9))?(u_xlat0.xyz):(u_xlat1.xyz);
          u_xlat0 = mul(unity_MatrixVP, u_xlat0);
          u_xlat1.x = (unity_LightShadowBias.x / u_xlat0.w);
          #ifdef UNITY_ADRENO_ES3
          u_xlat1.x = min(max(u_xlat1.x, 0), 1);
          #else
          u_xlat1.x = clamp(u_xlat1.x, 0, 1);
          #endif
          u_xlat6 = (u_xlat0.z + u_xlat1.x);
          u_xlat1.x = max((-u_xlat0.w), u_xlat6);
          out_v.vertex.xyw = u_xlat0.xyw;
          u_xlat0.x = ((-u_xlat6) + u_xlat1.x);
          out_v.vertex.z = ((unity_LightShadowBias.y * u_xlat0.x) + u_xlat6);
          u_xlat0.xyz = (in_v.vertex.yyy * conv_mxt4x4_1(unity_ObjectToWorld).xyz);
          u_xlat0.xyz = ((conv_mxt4x4_0(unity_ObjectToWorld).xyz * in_v.vertex.xxx) + u_xlat0.xyz);
          u_xlat0.xyz = ((conv_mxt4x4_2(unity_ObjectToWorld).xyz * in_v.vertex.zzz) + u_xlat0.xyz);
          out_v.texcoord1.xyz = ((conv_mxt4x4_3(unity_ObjectToWorld).xyz * in_v.vertex.www) + u_xlat0.xyz);
          out_v.color = in_v.color;
          out_v.texcoord2.xyz = in_v.vertex.xyz;
          out_v.texcoord3.xyz = in_v.normal.xyz;
          return out_v;
      }
      
      #define CODE_BLOCK_FRAGMENT
      float3 u_xlat0_d;
      float u_xlat16_0;
      int u_xlatb0;
      float4 u_xlat1_d;
      float u_xlat16_1;
      float u_xlat16_2;
      float u_xlat3;
      float u_xlat9_d;
      float u_xlat16_9;
      OUT_Data_Frag frag(v2f in_f)
      {
          OUT_Data_Frag out_f;
          u_xlat0_d.x = dot(abs(in_f.texcoord3.xyz), abs(in_f.texcoord3.xyz));
          u_xlat0_d.x = rsqrt(u_xlat0_d.x);
          u_xlat0_d.xyz = (u_xlat0_d.xxx * abs(in_f.texcoord3.xyz));
          u_xlat9_d = dot(u_xlat0_d.xyz, float3(1, 1, 1));
          u_xlat0_d.xyz = (u_xlat0_d.xyz / float3(u_xlat9_d, u_xlat9_d, u_xlat9_d));
          u_xlat1_d = (in_f.texcoord2.yzzx * float4(_MapScale, _MapScale, _MapScale, _MapScale));
          u_xlat16_9 = tex2D(_MainTex, u_xlat1_d.zw).w;
          u_xlat16_1 = tex2D(_MainTex, u_xlat1_d.xy).w;
          u_xlat3 = (u_xlat0_d.y * u_xlat16_9);
          u_xlat16_2 = ((u_xlat16_1 * u_xlat0_d.x) + u_xlat3);
          u_xlat0_d.xy = (in_f.texcoord2.xy * float2(_MapScale, _MapScale));
          u_xlat16_0 = tex2D(_MainTex, u_xlat0_d.xy).w;
          u_xlat16_2 = ((u_xlat16_0 * u_xlat0_d.z) + u_xlat16_2);
          u_xlat16_2 = (u_xlat16_2 * _Color.w);
          u_xlat16_2 = ((u_xlat16_2 * in_f.color.w) + (-_Cutoff));
          #ifdef UNITY_ADRENO_ES3
          u_xlatb0 = (u_xlat16_2<0);
          #else
          u_xlatb0 = (u_xlat16_2<0);
          #endif
          if(((int(u_xlatb0) * int(4294967295))!=0))
          {
              discard;
          }
          out_f.color = float4(0, 0, 0, 0);
          return out_f;
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack "Diffuse"
}
