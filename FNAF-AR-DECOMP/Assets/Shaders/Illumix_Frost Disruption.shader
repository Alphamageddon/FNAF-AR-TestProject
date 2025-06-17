Shader "Illumix/Frost Disruption"
{
  Properties
  {
    _Cutoff ("Mask Clip Value", float) = 0.5
    _ColorTint ("Color Tint", Color) = (0,0,0,0)
    _MainTex ("MainTex", 2D) = "white" {}
    _Pattern ("Pattern", 2D) = "white" {}
    _OpacityGuide ("Opacity Guide", 2D) = "white" {}
    _NoisePattern ("Noise Pattern", 2D) = "white" {}
    _Grow ("Grow", Range(0, 1)) = 0
    _Distortion ("Distortion", Range(0, 1)) = 0
    _Brightness ("Brightness", Range(0, 1)) = 0
    [HideInInspector] _texcoord ("", 2D) = "white" {}
    [HideInInspector] __dirty ("", float) = 1
  }
  SubShader
  {
    Tags
    { 
      "IsEmissive" = "true"
      "QUEUE" = "Transparent+0"
      "RenderType" = "TransparentCutout"
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
    Pass // ind: 2, name: FORWARD
    {
      Name "FORWARD"
      Tags
      { 
        "IsEmissive" = "true"
        "LIGHTMODE" = "FORWARDBASE"
        "QUEUE" = "Transparent+0"
        "RenderType" = "TransparentCutout"
        "SHADOWSUPPORT" = "true"
      }
      Blend SrcAlpha OneMinusSrcAlpha
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
      //uniform float4 _ProjectionParams;
      //uniform float4x4 unity_ObjectToWorld;
      //uniform float4x4 unity_WorldToObject;
      //uniform float4x4 unity_MatrixVP;
      uniform float4 _texcoord_ST;
      //uniform float4 _Time;
      //uniform float3 _WorldSpaceCameraPos;
      //uniform float4 _WorldSpaceLightPos0;
      //uniform float4 unity_SpecCube0_HDR;
      uniform float4 _LightColor0;
      uniform float4 _ColorTint;
      uniform float4 _MainTex_ST;
      uniform float _Brightness;
      uniform float4 _Pattern_ST;
      uniform float _Distortion;
      uniform float4 _OpacityGuide_ST;
      uniform float _Grow;
      uniform float4 _NoisePattern_ST;
      uniform float _Cutoff;
      uniform sampler2D _MainTex;
      uniform sampler2D _Pattern;
      uniform sampler2D _GrabTexture;
      uniform sampler2D _OpacityGuide;
      uniform sampler2D _NoisePattern;
      uniform sampler2D unity_NHxRoughness;
      //uniform samplerCUBE unity_SpecCube0;
      struct appdata_t
      {
          float4 vertex :POSITION0;
          float3 normal :NORMAL0;
          float4 texcoord :TEXCOORD0;
      };
      
      struct OUT_Data_Vert
      {
          float2 texcoord :TEXCOORD0;
          float3 texcoord1 :TEXCOORD1;
          float3 texcoord2 :TEXCOORD2;
          float4 texcoord3 :TEXCOORD3;
          float4 texcoord6 :TEXCOORD6;
          float4 texcoord7 :TEXCOORD7;
          float4 vertex :SV_POSITION;
      };
      
      struct v2f
      {
          float2 texcoord :TEXCOORD0;
          float3 texcoord1 :TEXCOORD1;
          float3 texcoord2 :TEXCOORD2;
          float4 texcoord3 :TEXCOORD3;
      };
      
      struct OUT_Data_Frag
      {
          float4 color :SV_Target0;
      };
      
      float4 u_xlat0;
      float4 u_xlat1;
      float u_xlat7;
      OUT_Data_Vert vert(appdata_t in_v)
      {
          OUT_Data_Vert out_v;
          u_xlat0 = (in_v.vertex.yyyy * conv_mxt4x4_1(unity_ObjectToWorld));
          u_xlat0 = ((conv_mxt4x4_0(unity_ObjectToWorld) * in_v.vertex.xxxx) + u_xlat0);
          u_xlat0 = ((conv_mxt4x4_2(unity_ObjectToWorld) * in_v.vertex.zzzz) + u_xlat0);
          u_xlat1 = (u_xlat0 + conv_mxt4x4_3(unity_ObjectToWorld));
          out_v.texcoord2.xyz = ((conv_mxt4x4_3(unity_ObjectToWorld).xyz * in_v.vertex.www) + u_xlat0.xyz);
          u_xlat0 = mul(unity_MatrixVP, u_xlat1);
          out_v.vertex = u_xlat0;
          out_v.texcoord.xy = TRANSFORM_TEX(in_v.texcoord.xy, _texcoord);
          u_xlat1.x = dot(in_v.normal.xyz, conv_mxt4x4_0(unity_WorldToObject).xyz);
          u_xlat1.y = dot(in_v.normal.xyz, conv_mxt4x4_1(unity_WorldToObject).xyz);
          u_xlat1.z = dot(in_v.normal.xyz, conv_mxt4x4_2(unity_WorldToObject).xyz);
          out_v.texcoord1.xyz = normalize(u_xlat1.xyz);
          u_xlat0.y = (u_xlat0.y * _ProjectionParams.x);
          u_xlat1.xzw = (u_xlat0.xwy * float3(0.5, 0.5, 0.5));
          out_v.texcoord3.zw = u_xlat0.zw;
          out_v.texcoord3.xy = (u_xlat1.zz + u_xlat1.xw);
          out_v.texcoord6 = float4(0, 0, 0, 0);
          out_v.texcoord7 = float4(0, 0, 0, 0);
          return out_v;
      }
      
      #define CODE_BLOCK_FRAGMENT
      float3 u_xlat0_d;
      float3 u_xlat16_0;
      float4 u_xlat16_1;
      float3 u_xlat16_2;
      float3 u_xlat3;
      float3 u_xlat16_3;
      float3 u_xlat16_4;
      float3 u_xlat16_5;
      float u_xlat6;
      int u_xlatb6;
      float u_xlat9;
      float2 u_xlat12;
      float u_xlat16_12;
      float2 u_xlat15;
      float2 u_xlat16_15;
      float u_xlat18;
      float u_xlat16_20;
      float u_xlat21;
      OUT_Data_Frag frag(v2f in_f)
      {
          OUT_Data_Frag out_f;
          u_xlat0_d.xy = TRANSFORM_TEX(in_f.texcoord.xy, _OpacityGuide);
          u_xlat16_0.x = tex2D(_OpacityGuide, u_xlat0_d.xy).w;
          u_xlat16_0.x = ((-u_xlat16_0.x) + 1);
          u_xlat6 = (u_xlat16_0.x + _Grow);
          u_xlat0_d.x = (u_xlat16_0.x * _Grow);
          u_xlat12.xy = TRANSFORM_TEX(in_f.texcoord.xy, _NoisePattern);
          u_xlat16_12 = tex2D(_NoisePattern, u_xlat12.xy).x;
          u_xlat6 = (u_xlat16_12 + u_xlat6);
          u_xlat6 = (u_xlat6 + (-_Cutoff));
          #ifdef UNITY_ADRENO_ES3
          u_xlatb6 = (u_xlat6<0);
          #else
          u_xlatb6 = (u_xlat6<0);
          #endif
          if(((int(u_xlatb6) * int(4294967295))!=0))
          {
              discard;
          }
          u_xlat6 = (_Grow * 1.29999995);
          u_xlat0_d.x = ((u_xlat0_d.x * 14) + u_xlat6);
          u_xlat0_d.x = (u_xlat0_d.x * u_xlat0_d.x);
          u_xlat0_d.x = (u_xlat0_d.x * u_xlat0_d.x);
          u_xlat0_d.x = (u_xlat0_d.x * u_xlat0_d.x);
          u_xlat0_d.x = (u_xlat16_12 * u_xlat0_d.x);
          #ifdef UNITY_ADRENO_ES3
          u_xlat0_d.x = min(max(u_xlat0_d.x, 0), 1);
          #else
          u_xlat0_d.x = clamp(u_xlat0_d.x, 0, 1);
          #endif
          out_f.color.w = u_xlat0_d.x;
          u_xlat0_d.xyz = ((-in_f.texcoord2.xyz) + _WorldSpaceCameraPos.xyz);
          u_xlat0_d.xyz = normalize(u_xlat0_d.xyz);
          u_xlat16_1.x = dot((-u_xlat0_d.xyz), in_f.texcoord1.xyz);
          u_xlat16_1.x = (u_xlat16_1.x + u_xlat16_1.x);
          u_xlat16_1.xyz = ((in_f.texcoord1.xyz * (-u_xlat16_1.xxx)) + (-u_xlat0_d.xyz));
          u_xlat16_1 = UNITY_SAMPLE_TEXCUBE(unity_SpecCube0, float4(u_xlat16_1.xyz, 6));
          u_xlat16_2.x = (u_xlat16_1.w + (-1));
          u_xlat16_2.x = ((unity_SpecCube0_HDR.w * u_xlat16_2.x) + 1);
          u_xlat16_2.x = log2(u_xlat16_2.x);
          u_xlat16_2.x = (u_xlat16_2.x * unity_SpecCube0_HDR.y);
          u_xlat16_2.x = exp2(u_xlat16_2.x);
          u_xlat16_2.x = (u_xlat16_2.x * unity_SpecCube0_HDR.x);
          u_xlat16_2.xyz = (u_xlat16_1.xyz * u_xlat16_2.xxx);
          u_xlat3.xyz = normalize(in_f.texcoord1.xyz);
          u_xlat18 = dot(u_xlat0_d.xyz, u_xlat3.xyz);
          u_xlat21 = u_xlat18;
          #ifdef UNITY_ADRENO_ES3
          u_xlat21 = min(max(u_xlat21, 0), 1);
          #else
          u_xlat21 = clamp(u_xlat21, 0, 1);
          #endif
          u_xlat18 = (u_xlat18 + u_xlat18);
          u_xlat0_d.xyz = ((u_xlat3.xyz * (-float3(u_xlat18, u_xlat18, u_xlat18))) + u_xlat0_d.xyz);
          u_xlat18 = dot(u_xlat3.xyz, _WorldSpaceLightPos0.xyz);
          #ifdef UNITY_ADRENO_ES3
          u_xlat18 = min(max(u_xlat18, 0), 1);
          #else
          u_xlat18 = clamp(u_xlat18, 0, 1);
          #endif
          u_xlat16_4.xyz = (float3(u_xlat18, u_xlat18, u_xlat18) * _LightColor0.xyz);
          u_xlat0_d.x = dot(u_xlat0_d.xyz, _WorldSpaceLightPos0.xyz);
          u_xlat0_d.x = (u_xlat0_d.x * u_xlat0_d.x);
          u_xlat0_d.x = (u_xlat0_d.x * u_xlat0_d.x);
          u_xlat16_20 = ((-u_xlat21) + 1);
          u_xlat16_12 = (u_xlat16_20 * u_xlat16_20);
          u_xlat16_12 = (u_xlat16_20 * u_xlat16_12);
          u_xlat16_12 = (u_xlat16_20 * u_xlat16_12);
          u_xlat16_20 = ((u_xlat16_12 * 2.23517418E-08) + 0.0399999991);
          u_xlat16_2.xyz = (float3(u_xlat16_20, u_xlat16_20, u_xlat16_20) * u_xlat16_2.xyz);
          u_xlat0_d.y = 1;
          u_xlat0_d.x = tex2D(unity_NHxRoughness, u_xlat0_d.xy).x;
          u_xlat16_20 = (u_xlat0_d.x * 0.639999986);
          u_xlat0_d.xy = TRANSFORM_TEX(in_f.texcoord.xy, _MainTex);
          u_xlat16_0.xyz = tex2D(_MainTex, u_xlat0_d.xy).xyz;
          u_xlat0_d.xyz = (u_xlat16_0.xyz * _ColorTint.xyz);
          u_xlat16_5.xyz = ((u_xlat0_d.xyz * float3(0.959999979, 0.959999979, 0.959999979)) + float3(u_xlat16_20, u_xlat16_20, u_xlat16_20));
          u_xlat16_2.xyz = ((u_xlat16_5.xyz * u_xlat16_4.xyz) + u_xlat16_2.xyz);
          u_xlat18 = (in_f.texcoord3.w + 9.99999996E-12);
          u_xlat3.x = (u_xlat18 * 0.5);
          u_xlat9 = (((-u_xlat18) * 0.5) + in_f.texcoord3.y);
          u_xlat3.y = ((u_xlat9 * _ProjectionParams.x) + u_xlat3.x);
          u_xlat3.x = in_f.texcoord3.x;
          u_xlat3.xy = (u_xlat3.xy / float2(u_xlat18, u_xlat18));
          u_xlat15.xy = TRANSFORM_TEX(in_f.texcoord.xy, _Pattern);
          u_xlat15.xy = ((_Time.yy * float2(0, 0.00499999989)) + u_xlat15.xy);
          u_xlat16_15.xy = tex2D(_Pattern, u_xlat15.xy).xy;
          u_xlat3.xy = ((u_xlat16_15.xy * float2(_Distortion, _Distortion)) + u_xlat3.xy);
          u_xlat16_3.xyz = tex2D(_GrabTexture, u_xlat3.xy).xyz;
          u_xlat0_d.xyz = ((u_xlat0_d.xyz * float3(_Brightness, _Brightness, _Brightness)) + u_xlat16_3.xyz);
          #ifdef UNITY_ADRENO_ES3
          u_xlat0_d.xyz = min(max(u_xlat0_d.xyz, 0), 1);
          #else
          u_xlat0_d.xyz = clamp(u_xlat0_d.xyz, 0, 1);
          #endif
          out_f.color.xyz = (u_xlat0_d.xyz + u_xlat16_2.xyz);
          return out_f;
      }
      
      
      ENDCG
      
    } // end phase
    Pass // ind: 3, name: FORWARD
    {
      Name "FORWARD"
      Tags
      { 
        "IsEmissive" = "true"
        "LIGHTMODE" = "FORWARDADD"
        "QUEUE" = "Transparent+0"
        "RenderType" = "TransparentCutout"
        "SHADOWSUPPORT" = "true"
      }
      ZWrite Off
      Blend One One
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
      uniform float4 _texcoord_ST;
      //uniform float3 _WorldSpaceCameraPos;
      //uniform float4 _WorldSpaceLightPos0;
      uniform float4 _LightColor0;
      uniform float4 _ColorTint;
      uniform float4 _MainTex_ST;
      uniform float4 _OpacityGuide_ST;
      uniform float _Grow;
      uniform float4 _NoisePattern_ST;
      uniform float _Cutoff;
      uniform sampler2D _MainTex;
      uniform sampler2D _OpacityGuide;
      uniform sampler2D _NoisePattern;
      uniform sampler2D _LightTexture0;
      uniform sampler2D unity_NHxRoughness;
      struct appdata_t
      {
          float4 vertex :POSITION0;
          float3 normal :NORMAL0;
          float4 texcoord :TEXCOORD0;
      };
      
      struct OUT_Data_Vert
      {
          float2 texcoord :TEXCOORD0;
          float3 texcoord1 :TEXCOORD1;
          float3 texcoord2 :TEXCOORD2;
          float3 texcoord3 :TEXCOORD3;
          float4 texcoord4 :TEXCOORD4;
          float4 vertex :SV_POSITION;
      };
      
      struct v2f
      {
          float2 texcoord :TEXCOORD0;
          float3 texcoord1 :TEXCOORD1;
          float3 texcoord2 :TEXCOORD2;
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
          out_v.texcoord.xy = TRANSFORM_TEX(in_v.texcoord.xy, _texcoord);
          u_xlat1.x = dot(in_v.normal.xyz, conv_mxt4x4_0(unity_WorldToObject).xyz);
          u_xlat1.y = dot(in_v.normal.xyz, conv_mxt4x4_1(unity_WorldToObject).xyz);
          u_xlat1.z = dot(in_v.normal.xyz, conv_mxt4x4_2(unity_WorldToObject).xyz);
          out_v.texcoord1.xyz = normalize(u_xlat1.xyz);
          out_v.texcoord2.xyz = ((conv_mxt4x4_3(unity_ObjectToWorld).xyz * in_v.vertex.www) + u_xlat0.xyz);
          u_xlat0 = ((conv_mxt4x4_3(unity_ObjectToWorld) * in_v.vertex.wwww) + u_xlat0);
          u_xlat1.xyz = (u_xlat0.yyy * conv_mxt4x4_1(unity_WorldToLight).xyz);
          u_xlat1.xyz = ((conv_mxt4x4_0(unity_WorldToLight).xyz * u_xlat0.xxx) + u_xlat1.xyz);
          u_xlat0.xyz = ((conv_mxt4x4_2(unity_WorldToLight).xyz * u_xlat0.zzz) + u_xlat1.xyz);
          out_v.texcoord3.xyz = ((conv_mxt4x4_3(unity_WorldToLight).xyz * u_xlat0.www) + u_xlat0.xyz);
          out_v.texcoord4 = float4(0, 0, 0, 0);
          return out_v;
      }
      
      #define CODE_BLOCK_FRAGMENT
      float4 u_xlat0_d;
      float4 u_xlat16_0;
      float3 u_xlat1_d;
      float3 u_xlat2_d;
      float3 u_xlat16_3;
      float3 u_xlat16_4;
      float u_xlat5;
      int u_xlatb5;
      float2 u_xlat10_d;
      float u_xlat16_10;
      float u_xlat15;
      OUT_Data_Frag frag(v2f in_f)
      {
          OUT_Data_Frag out_f;
          u_xlat0_d.xy = TRANSFORM_TEX(in_f.texcoord.xy, _OpacityGuide);
          u_xlat16_0.x = tex2D(_OpacityGuide, u_xlat0_d.xy).w;
          u_xlat16_0.x = ((-u_xlat16_0.x) + 1);
          u_xlat5 = (u_xlat16_0.x + _Grow);
          u_xlat0_d.x = (u_xlat16_0.x * _Grow);
          u_xlat10_d.xy = TRANSFORM_TEX(in_f.texcoord.xy, _NoisePattern);
          u_xlat16_10 = tex2D(_NoisePattern, u_xlat10_d.xy).x;
          u_xlat5 = (u_xlat16_10 + u_xlat5);
          u_xlat5 = (u_xlat5 + (-_Cutoff));
          #ifdef UNITY_ADRENO_ES3
          u_xlatb5 = (u_xlat5<0);
          #else
          u_xlatb5 = (u_xlat5<0);
          #endif
          if(((int(u_xlatb5) * int(4294967295))!=0))
          {
              discard;
          }
          u_xlat5 = (_Grow * 1.29999995);
          u_xlat0_d.x = ((u_xlat0_d.x * 14) + u_xlat5);
          u_xlat0_d.x = (u_xlat0_d.x * u_xlat0_d.x);
          u_xlat0_d.x = (u_xlat0_d.x * u_xlat0_d.x);
          u_xlat0_d.x = (u_xlat0_d.x * u_xlat0_d.x);
          u_xlat0_d.x = (u_xlat16_10 * u_xlat0_d.x);
          #ifdef UNITY_ADRENO_ES3
          u_xlat0_d.x = min(max(u_xlat0_d.x, 0), 1);
          #else
          u_xlat0_d.x = clamp(u_xlat0_d.x, 0, 1);
          #endif
          out_f.color.w = u_xlat0_d.x;
          u_xlat0_d.xyz = ((-in_f.texcoord2.xyz) + _WorldSpaceCameraPos.xyz);
          u_xlat0_d.xyz = normalize(u_xlat0_d.xyz);
          u_xlat1_d.xyz = normalize(in_f.texcoord1.xyz);
          u_xlat15 = dot(u_xlat0_d.xyz, u_xlat1_d.xyz);
          u_xlat15 = (u_xlat15 + u_xlat15);
          u_xlat0_d.xyz = ((u_xlat1_d.xyz * (-float3(u_xlat15, u_xlat15, u_xlat15))) + u_xlat0_d.xyz);
          u_xlat2_d.xyz = ((-in_f.texcoord2.xyz) + _WorldSpaceLightPos0.xyz);
          u_xlat2_d.xyz = normalize(u_xlat2_d.xyz);
          u_xlat0_d.x = dot(u_xlat0_d.xyz, u_xlat2_d.xyz);
          u_xlat5 = dot(u_xlat1_d.xyz, u_xlat2_d.xyz);
          #ifdef UNITY_ADRENO_ES3
          u_xlat5 = min(max(u_xlat5, 0), 1);
          #else
          u_xlat5 = clamp(u_xlat5, 0, 1);
          #endif
          u_xlat0_d.x = (u_xlat0_d.x * u_xlat0_d.x);
          u_xlat1_d.x = (u_xlat0_d.x * u_xlat0_d.x);
          u_xlat1_d.y = 1;
          u_xlat0_d.x = tex2D(unity_NHxRoughness, u_xlat1_d.xy).x;
          u_xlat16_3.x = (u_xlat0_d.x * 0.639999986);
          u_xlat0_d.xz = TRANSFORM_TEX(in_f.texcoord.xy, _MainTex);
          u_xlat16_0.xzw = tex2D(_MainTex, u_xlat0_d.xz).xyz;
          u_xlat0_d.xzw = (u_xlat16_0.xzw * _ColorTint.xyz);
          u_xlat16_3.xyz = ((u_xlat0_d.xzw * float3(0.959999979, 0.959999979, 0.959999979)) + u_xlat16_3.xxx);
          u_xlat0_d.xzw = (in_f.texcoord2.yyy * conv_mxt4x4_1(unity_WorldToLight).xyz);
          u_xlat0_d.xzw = ((conv_mxt4x4_0(unity_WorldToLight).xyz * in_f.texcoord2.xxx) + u_xlat0_d.xzw);
          u_xlat0_d.xzw = ((conv_mxt4x4_2(unity_WorldToLight).xyz * in_f.texcoord2.zzz) + u_xlat0_d.xzw);
          u_xlat0_d.xzw = (u_xlat0_d.xzw + conv_mxt4x4_3(unity_WorldToLight).xyz);
          u_xlat0_d.x = dot(u_xlat0_d.xzw, u_xlat0_d.xzw);
          u_xlat0_d.x = tex2D(_LightTexture0, u_xlat0_d.xx).x;
          u_xlat16_4.xyz = (u_xlat0_d.xxx * _LightColor0.xyz);
          u_xlat16_4.xyz = (float3(u_xlat5, u_xlat5, u_xlat5) * u_xlat16_4.xyz);
          out_f.color.xyz = (u_xlat16_3.xyz * u_xlat16_4.xyz);
          return out_f;
      }
      
      
      ENDCG
      
    } // end phase
    Pass // ind: 4, name: DEFERRED
    {
      Name "DEFERRED"
      Tags
      { 
        "IsEmissive" = "true"
        "LIGHTMODE" = "DEFERRED"
        "QUEUE" = "Transparent+0"
        "RenderType" = "TransparentCutout"
      }
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
      //uniform float4 _ProjectionParams;
      //uniform float4x4 unity_ObjectToWorld;
      //uniform float4x4 unity_WorldToObject;
      //uniform float4x4 unity_MatrixVP;
      uniform float4 _texcoord_ST;
      //uniform float4 _Time;
      uniform float4 _ColorTint;
      uniform float4 _MainTex_ST;
      uniform float _Brightness;
      uniform float4 _Pattern_ST;
      uniform float _Distortion;
      uniform float4 _OpacityGuide_ST;
      uniform float _Grow;
      uniform float4 _NoisePattern_ST;
      uniform float _Cutoff;
      uniform sampler2D _MainTex;
      uniform sampler2D _Pattern;
      uniform sampler2D _GrabTexture;
      uniform sampler2D _OpacityGuide;
      uniform sampler2D _NoisePattern;
      struct appdata_t
      {
          float4 vertex :POSITION0;
          float3 normal :NORMAL0;
          float4 texcoord :TEXCOORD0;
      };
      
      struct OUT_Data_Vert
      {
          float2 texcoord :TEXCOORD0;
          float3 texcoord1 :TEXCOORD1;
          float3 texcoord2 :TEXCOORD2;
          float4 texcoord3 :TEXCOORD3;
          float4 texcoord5 :TEXCOORD5;
          float4 vertex :SV_POSITION;
      };
      
      struct v2f
      {
          float2 texcoord :TEXCOORD0;
          float3 texcoord1 :TEXCOORD1;
          float4 texcoord3 :TEXCOORD3;
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
      float u_xlat7;
      OUT_Data_Vert vert(appdata_t in_v)
      {
          OUT_Data_Vert out_v;
          u_xlat0 = (in_v.vertex.yyyy * conv_mxt4x4_1(unity_ObjectToWorld));
          u_xlat0 = ((conv_mxt4x4_0(unity_ObjectToWorld) * in_v.vertex.xxxx) + u_xlat0);
          u_xlat0 = ((conv_mxt4x4_2(unity_ObjectToWorld) * in_v.vertex.zzzz) + u_xlat0);
          u_xlat1 = (u_xlat0 + conv_mxt4x4_3(unity_ObjectToWorld));
          out_v.texcoord2.xyz = ((conv_mxt4x4_3(unity_ObjectToWorld).xyz * in_v.vertex.www) + u_xlat0.xyz);
          u_xlat0 = mul(unity_MatrixVP, u_xlat1);
          out_v.vertex = u_xlat0;
          out_v.texcoord.xy = TRANSFORM_TEX(in_v.texcoord.xy, _texcoord);
          u_xlat1.x = dot(in_v.normal.xyz, conv_mxt4x4_0(unity_WorldToObject).xyz);
          u_xlat1.y = dot(in_v.normal.xyz, conv_mxt4x4_1(unity_WorldToObject).xyz);
          u_xlat1.z = dot(in_v.normal.xyz, conv_mxt4x4_2(unity_WorldToObject).xyz);
          out_v.texcoord1.xyz = normalize(u_xlat1.xyz);
          u_xlat0.y = (u_xlat0.y * _ProjectionParams.x);
          u_xlat1.xzw = (u_xlat0.xwy * float3(0.5, 0.5, 0.5));
          out_v.texcoord3.zw = u_xlat0.zw;
          out_v.texcoord3.xy = (u_xlat1.zz + u_xlat1.xw);
          out_v.texcoord5 = float4(0, 0, 0, 0);
          return out_v;
      }
      
      #define CODE_BLOCK_FRAGMENT
      float3 u_xlat0_d;
      float3 u_xlat16_0;
      int u_xlatb0;
      float4 u_xlat1_d;
      float3 u_xlat16_1;
      float2 u_xlat2;
      float u_xlat16_2;
      float u_xlat3;
      float2 u_xlat5;
      float2 u_xlat16_5;
      float u_xlat6;
      OUT_Data_Frag frag(v2f in_f)
      {
          OUT_Data_Frag out_f;
          u_xlat0_d.xy = TRANSFORM_TEX(in_f.texcoord.xy, _OpacityGuide);
          u_xlat16_0.x = tex2D(_OpacityGuide, u_xlat0_d.xy).w;
          u_xlat0_d.x = ((-u_xlat16_0.x) + _Grow);
          u_xlat2.xy = TRANSFORM_TEX(in_f.texcoord.xy, _NoisePattern);
          u_xlat16_2 = tex2D(_NoisePattern, u_xlat2.xy).x;
          u_xlat0_d.x = (u_xlat0_d.x + u_xlat16_2);
          u_xlat0_d.x = (u_xlat0_d.x + 1);
          u_xlat0_d.x = (u_xlat0_d.x + (-_Cutoff));
          #ifdef UNITY_ADRENO_ES3
          u_xlatb0 = (u_xlat0_d.x<0);
          #else
          u_xlatb0 = (u_xlat0_d.x<0);
          #endif
          if(((int(u_xlatb0) * int(4294967295))!=0))
          {
              discard;
          }
          u_xlat0_d.xy = TRANSFORM_TEX(in_f.texcoord.xy, _MainTex);
          u_xlat16_0.xyz = tex2D(_MainTex, u_xlat0_d.xy).xyz;
          u_xlat0_d.xyz = (u_xlat16_0.xyz * _ColorTint.xyz);
          out_f.color.xyz = (u_xlat0_d.xyz * float3(0.959999979, 0.959999979, 0.959999979));
          out_f.color.w = 1;
          out_f.color1 = float4(0.0399999991, 0.0399999991, 0.0399999991, 0);
          u_xlat1_d.xyz = ((in_f.texcoord1.xyz * float3(0.5, 0.5, 0.5)) + float3(0.5, 0.5, 0.5));
          u_xlat1_d.w = 1;
          out_f.color2 = u_xlat1_d;
          u_xlat6 = (in_f.texcoord3.w + 9.99999996E-12);
          u_xlat1_d.x = (u_xlat6 * 0.5);
          u_xlat3 = (((-u_xlat6) * 0.5) + in_f.texcoord3.y);
          u_xlat1_d.y = ((u_xlat3 * _ProjectionParams.x) + u_xlat1_d.x);
          u_xlat1_d.x = in_f.texcoord3.x;
          u_xlat1_d.xy = (u_xlat1_d.xy / float2(u_xlat6, u_xlat6));
          u_xlat5.xy = TRANSFORM_TEX(in_f.texcoord.xy, _Pattern);
          u_xlat5.xy = ((_Time.yy * float2(0, 0.00499999989)) + u_xlat5.xy);
          u_xlat16_5.xy = tex2D(_Pattern, u_xlat5.xy).xy;
          u_xlat1_d.xy = ((u_xlat16_5.xy * float2(_Distortion, _Distortion)) + u_xlat1_d.xy);
          u_xlat16_1.xyz = tex2D(_GrabTexture, u_xlat1_d.xy).xyz;
          u_xlat0_d.xyz = ((u_xlat0_d.xyz * float3(_Brightness, _Brightness, _Brightness)) + u_xlat16_1.xyz);
          #ifdef UNITY_ADRENO_ES3
          u_xlat0_d.xyz = min(max(u_xlat0_d.xyz, 0), 1);
          #else
          u_xlat0_d.xyz = clamp(u_xlat0_d.xyz, 0, 1);
          #endif
          out_f.color3.xyz = exp2((-u_xlat0_d.xyz));
          out_f.color3.w = 1;
          return out_f;
      }
      
      
      ENDCG
      
    } // end phase
    Pass // ind: 5, name: ShadowCaster
    {
      Name "ShadowCaster"
      Tags
      { 
        "IsEmissive" = "true"
        "LIGHTMODE" = "SHADOWCASTER"
        "QUEUE" = "Transparent+0"
        "RenderType" = "TransparentCutout"
        "SHADOWSUPPORT" = "true"
      }
      Blend SrcAlpha OneMinusSrcAlpha
      // m_ProgramMask = 6
      CGPROGRAM
      #pragma multi_compile SHADOWS_DEPTH UNITY_PASS_SHADOWCASTER
      //#pragma target 4.0
      
      #pragma vertex vert
      #pragma fragment frag
      
      #include "UnityCG.cginc"
      #define conv_mxt4x4_0(mat4x4) float4(mat4x4[0].x,mat4x4[1].x,mat4x4[2].x,mat4x4[3].x)
      #define conv_mxt4x4_1(mat4x4) float4(mat4x4[0].y,mat4x4[1].y,mat4x4[2].y,mat4x4[3].y)
      #define conv_mxt4x4_2(mat4x4) float4(mat4x4[0].z,mat4x4[1].z,mat4x4[2].z,mat4x4[3].z)
      #define conv_mxt4x4_3(mat4x4) float4(mat4x4[0].w,mat4x4[1].w,mat4x4[2].w,mat4x4[3].w)
      
      
      #define CODE_BLOCK_VERTEX
      //uniform float4 _ProjectionParams;
      //uniform float4 _WorldSpaceLightPos0;
      //uniform float4 unity_LightShadowBias;
      //uniform float4x4 unity_ObjectToWorld;
      //uniform float4x4 unity_WorldToObject;
      //uniform float4x4 unity_MatrixVP;
      uniform float4 _OpacityGuide_ST;
      uniform float _Grow;
      uniform float4 _NoisePattern_ST;
      uniform float _Cutoff;
      uniform sampler2D _OpacityGuide;
      uniform sampler2D _NoisePattern;
      uniform sampler3D _DitherMaskLOD;
      struct appdata_t
      {
          float4 vertex :POSITION0;
          float3 normal :NORMAL0;
          float4 texcoord :TEXCOORD0;
      };
      
      struct OUT_Data_Vert
      {
          float2 texcoord1 :TEXCOORD1;
          float3 texcoord2 :TEXCOORD2;
          float4 texcoord3 :TEXCOORD3;
          float4 vertex :SV_POSITION;
      };
      
      struct v2f
      {
          float2 texcoord1 :TEXCOORD1;
      };
      
      struct OUT_Data_Frag
      {
          float4 color :SV_Target0;
      };
      
      float4 u_xlat0;
      float4 u_xlat1;
      float4 u_xlat2;
      float u_xlat3;
      float u_xlat4;
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
          u_xlat1.x = (u_xlat0.z + u_xlat1.x);
          u_xlat4 = max((-u_xlat0.w), u_xlat1.x);
          u_xlat4 = ((-u_xlat1.x) + u_xlat4);
          u_xlat0.z = ((unity_LightShadowBias.y * u_xlat4) + u_xlat1.x);
          out_v.vertex = u_xlat0;
          out_v.texcoord3.zw = u_xlat0.zw;
          out_v.texcoord1.xy = in_v.texcoord.xy;
          u_xlat1.xyz = (in_v.vertex.yyy * conv_mxt4x4_1(unity_ObjectToWorld).xyz);
          u_xlat1.xyz = ((conv_mxt4x4_0(unity_ObjectToWorld).xyz * in_v.vertex.xxx) + u_xlat1.xyz);
          u_xlat1.xyz = ((conv_mxt4x4_2(unity_ObjectToWorld).xyz * in_v.vertex.zzz) + u_xlat1.xyz);
          out_v.texcoord2.xyz = ((conv_mxt4x4_3(unity_ObjectToWorld).xyz * in_v.vertex.www) + u_xlat1.xyz);
          u_xlat3 = (u_xlat0.y * _ProjectionParams.x);
          u_xlat0.xz = (u_xlat0.xw * float2(0.5, 0.5));
          u_xlat0.w = (u_xlat3 * 0.5);
          out_v.texcoord3.xy = (u_xlat0.zz + u_xlat0.xw);
          return out_v;
      }
      
      #define CODE_BLOCK_FRAGMENT
      float2 u_xlat0_d;
      float u_xlat16_0;
      int u_xlatb0;
      float3 u_xlat1_d;
      float u_xlat16_2;
      float u_xlat3_d;
      int u_xlatb3;
      float2 u_xlat6;
      float u_xlat16_6;
      float u_xlat16_7;
      OUT_Data_Frag frag(v2f in_f)
      {
          OUT_Data_Frag out_f;
          float4 hlslcc_FragCoord = float4(gl_FragCoord.xyz, (1 / gl_FragCoord.w));
          u_xlat0_d.xy = TRANSFORM_TEX(in_f.texcoord1.xy, _OpacityGuide);
          u_xlat16_0 = tex2D(_OpacityGuide, u_xlat0_d.xy).w;
          u_xlat16_0 = ((-u_xlat16_0) + 1);
          u_xlat3_d = (u_xlat16_0 + _Grow);
          u_xlat0_d.x = (u_xlat16_0 * _Grow);
          u_xlat6.xy = TRANSFORM_TEX(in_f.texcoord1.xy, _NoisePattern);
          u_xlat16_6 = tex2D(_NoisePattern, u_xlat6.xy).x;
          u_xlat3_d = (u_xlat16_6 + u_xlat3_d);
          u_xlat3_d = (u_xlat3_d + (-_Cutoff));
          #ifdef UNITY_ADRENO_ES3
          u_xlatb3 = (u_xlat3_d<0);
          #else
          u_xlatb3 = (u_xlat3_d<0);
          #endif
          if(((int(u_xlatb3) * int(4294967295))!=0))
          {
              discard;
          }
          u_xlat3_d = (_Grow * 1.29999995);
          u_xlat0_d.x = ((u_xlat0_d.x * 14) + u_xlat3_d);
          u_xlat0_d.x = (u_xlat0_d.x * u_xlat0_d.x);
          u_xlat0_d.x = (u_xlat0_d.x * u_xlat0_d.x);
          u_xlat0_d.x = (u_xlat0_d.x * u_xlat0_d.x);
          u_xlat0_d.x = (u_xlat16_6 * u_xlat0_d.x);
          #ifdef UNITY_ADRENO_ES3
          u_xlat0_d.x = min(max(u_xlat0_d.x, 0), 1);
          #else
          u_xlat0_d.x = clamp(u_xlat0_d.x, 0, 1);
          #endif
          u_xlat16_7 = (u_xlat0_d.x * 0.9375);
          u_xlat1_d.z = u_xlat16_7;
          u_xlat1_d.xy = (hlslcc_FragCoord.xy * float2(0.25, 0.25));
          u_xlat16_0 = tex2D(_DitherMaskLOD, u_xlat1_d.xyz).w;
          u_xlat16_2 = (u_xlat16_0 + (-0.00999999978));
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
