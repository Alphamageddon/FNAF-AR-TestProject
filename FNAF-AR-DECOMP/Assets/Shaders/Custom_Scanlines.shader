Shader "Custom/Scanlines"
{
  Properties
  {
    _MainTex ("_Color", 2D) = "white" {}
    _LineWidth ("Line Width", float) = 4
    _Hardness ("Hardness", float) = 0.9
    _Speed ("Displacement Speed", Range(0, 1)) = 0.1
  }
  SubShader
  {
    Tags
    { 
      "IGNOREPROJECTOR" = "true"
      "QUEUE" = "Overlay"
    }
    Pass // ind: 1, name: 
    {
      Tags
      { 
        "IGNOREPROJECTOR" = "true"
        "QUEUE" = "Overlay"
      }
      ZTest Always
      ZWrite Off
      Cull Off
      Fog
      { 
        Mode  Off
      } 
      // m_ProgramMask = 6
      CGPROGRAM
      //#pragma target 4.0
      
      #pragma vertex vert
      #pragma fragment frag
      
      #include "UnityCG.cginc"
      
      
      #define CODE_BLOCK_VERTEX
      //uniform float4 _ProjectionParams;
      //uniform float4x4 unity_ObjectToWorld;
      //uniform float4x4 unity_MatrixVP;
      //uniform float4 _Time;
      //uniform float4 _ScreenParams;
      uniform float _LineWidth;
      uniform float _Hardness;
      uniform float _Speed;
      uniform sampler2D _MainTex;
      struct appdata_t
      {
          float4 vertex :POSITION0;
          float2 texcoord :TEXCOORD0;
      };
      
      struct OUT_Data_Vert
      {
          float2 texcoord :TEXCOORD0;
          float4 texcoord1 :TEXCOORD1;
          float4 vertex :SV_POSITION;
      };
      
      struct v2f
      {
          float2 texcoord :TEXCOORD0;
          float4 texcoord1 :TEXCOORD1;
      };
      
      struct OUT_Data_Frag
      {
          float4 color :SV_Target0;
      };
      
      float4 u_xlat0;
      float4 u_xlat1;
      OUT_Data_Vert vert(appdata_t in_v)
      {
          OUT_Data_Vert out_v;
          u_xlat0 = UnityObjectToClipPos(in_v.vertex);
          out_v.vertex = u_xlat0;
          out_v.texcoord.xy = in_v.texcoord.xy;
          u_xlat0.y = (u_xlat0.y * _ProjectionParams.x);
          u_xlat1.xzw = (u_xlat0.xwy * float3(0.5, 0.5, 0.5));
          out_v.texcoord1.zw = u_xlat0.zw;
          out_v.texcoord1.xy = (u_xlat1.zz + u_xlat1.xw);
          return out_v;
      }
      
      #define CODE_BLOCK_FRAGMENT
      float4 u_xlat0_d;
      int u_xlati0;
      float4 u_xlat1_d;
      float4 u_xlat2;
      float u_xlat3;
      int u_xlati3;
      int u_xlatb3;
      float u_xlat6;
      int u_xlati6;
      OUT_Data_Frag frag(v2f in_f)
      {
          OUT_Data_Frag out_f;
          u_xlat0_d.x = (_Time.y * _Speed);
          u_xlat0_d.x = (u_xlat0_d.x * 1000);
          u_xlat3 = (u_xlat0_d.x * _ScreenParams.y);
          #ifdef UNITY_ADRENO_ES3
          u_xlatb3 = (u_xlat3>=(-u_xlat3));
          #else
          u_xlatb3 = (u_xlat3>=(-u_xlat3));
          #endif
          u_xlat3 = (u_xlatb3)?(_ScreenParams.y):((-_ScreenParams.y));
          u_xlat6 = (float(1) / u_xlat3);
          u_xlat0_d.x = (u_xlat6 * u_xlat0_d.x);
          u_xlat0_d.x = frac(u_xlat0_d.x);
          u_xlat6 = (in_f.texcoord1.y * _ScreenParams.y);
          u_xlat6 = (u_xlat6 / in_f.texcoord1.w);
          u_xlat0_d.x = ((u_xlat3 * u_xlat0_d.x) + u_xlat6);
          u_xlat3 = (_ScreenParams.y * _LineWidth);
          u_xlat3 = (u_xlat3 * 0.00499999989);
          u_xlat3 = floor(u_xlat3);
          u_xlat0_d.x = (u_xlat0_d.x / u_xlat3);
          u_xlati0 = int(u_xlat0_d.x);
          u_xlati3 = int(uint((uint(u_xlati0) & 2147483648)));
          u_xlati0 = max(u_xlati0, (-u_xlati0));
          u_xlati0 = int(uint((uint(u_xlati0) & 1)));
          u_xlati6 = (0 - u_xlati0);
          u_xlati0 = ((u_xlati3!=0))?(u_xlati6):(u_xlati0);
          u_xlat1_d.x = _Hardness;
          u_xlat1_d.w = 1;
          u_xlat2 = tex2D(_MainTex, in_f.texcoord.xy);
          u_xlat1_d = (u_xlat1_d.xxxw * u_xlat2);
          u_xlat0_d = ((int(u_xlati0)!=0))?(u_xlat1_d):(u_xlat2);
          out_f.color = u_xlat0_d;
          return out_f;
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack "Diffuse"
}
