Shader "Custom/Mobile Modified Glitch Shader"
{
  Properties
  {
    _MainTex ("Main Texture", 2D) = "white" {}
    _ResHorizontal ("Horizontal Resolution", float) = 640
    _ResVertical ("Vertical Resolution", float) = 480
    _ScanlineGlitchEnabled ("Scanline Glitch", float) = 1
    _Timer ("Time", float) = 1
    _ShearStrength ("Shear Strength", float) = 0
    _InvertScreen ("Invert Screen", float) = 0
    _InvertGrayScreen ("Invert Gray Screen", float) = 0
  }
  SubShader
  {
    Tags
    { 
    }
    Pass // ind: 1, name: 
    {
      Tags
      { 
      }
      ZTest Always
      ZWrite Off
      Cull Off
      // m_ProgramMask = 6
      CGPROGRAM
      //#pragma target 4.0
      
      #pragma vertex vert
      #pragma fragment frag
      
      #include "UnityCG.cginc"
      
      
      #define CODE_BLOCK_VERTEX
      //uniform float4x4 unity_ObjectToWorld;
      //uniform float4x4 unity_MatrixVP;
      uniform float _ResHorizontal;
      uniform float _ResVertical;
      uniform float _ScanlineGlitchEnabled;
      uniform float _Timer;
      uniform float _ShearStrength;
      uniform float _InvertScreen;
      uniform float _InvertGrayScreen;
      uniform sampler2D _MainTex;
      struct appdata_t
      {
          float4 vertex :POSITION0;
          float2 texcoord :TEXCOORD0;
      };
      
      struct OUT_Data_Vert
      {
          float2 texcoord :TEXCOORD0;
          float4 vertex :SV_POSITION;
      };
      
      struct v2f
      {
          float2 texcoord :TEXCOORD0;
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
          out_v.vertex = UnityObjectToClipPos(in_v.vertex);
          out_v.texcoord.xy = in_v.texcoord.xy;
          return out_v;
      }
      
      #define CODE_BLOCK_FRAGMENT
      float4 u_xlat0_d;
      int u_xlatb0;
      float4 u_xlat16_1;
      float3 u_xlat2;
      float2 u_xlatb2;
      float u_xlat3;
      int u_xlatb3;
      float2 u_xlat6;
      int u_xlatb6;
      float u_xlat9;
      OUT_Data_Frag frag(v2f in_f)
      {
          OUT_Data_Frag out_f;
          u_xlat0_d.y = (_Timer * 200);
          u_xlat6.x = (in_f.texcoord.y * _ResVertical);
          u_xlat16_1.xyz = (u_xlat6.xxx * float3(0.00999999978, 0.0199999996, 0.00499999989));
          u_xlat0_d.x = u_xlat16_1.y;
          u_xlat0_d.x = dot(u_xlat0_d.xy, float2(12.9898005, 78.2330017));
          u_xlat0_d.x = sin(u_xlat0_d.x);
          u_xlat0_d.x = (u_xlat0_d.x * 43758.5469);
          u_xlat2.y = u_xlat16_1.x;
          u_xlat3 = ((_Timer * 2) + u_xlat16_1.z);
          u_xlat3 = sin(u_xlat3);
          #ifdef UNITY_ADRENO_ES3
          u_xlatb3 = (u_xlat3>=0.999899983);
          #else
          u_xlatb3 = (u_xlat3>=0.999899983);
          #endif
          u_xlat3 = (u_xlatb3)?((-18)):((-0));
          u_xlat2.xz = (float2(float2(_Timer, _Timer)) * float2(1.60000002, 400));
          u_xlat6.y = dot(u_xlat2.yz, float2(12.9898005, 78.2330017));
          u_xlat6.x = ((u_xlat6.x * 0.00499999989) + u_xlat2.x);
          u_xlat6.xy = sin(u_xlat6.xy);
          #ifdef UNITY_ADRENO_ES3
          u_xlatb6 = (u_xlat6.x>=0.999499977);
          #else
          u_xlatb6 = (u_xlat6.x>=0.999499977);
          #endif
          u_xlat6.x = (u_xlatb6)?(12):(float(0));
          u_xlat0_d.w = (u_xlat6.y * 43758.5469);
          u_xlat0_d.xw = frac(u_xlat0_d.xw);
          u_xlat16_1.x = ((_ShearStrength * 32) + 2);
          u_xlat9 = (u_xlat0_d.w * u_xlat16_1.x);
          u_xlat0_d.x = (u_xlat0_d.x * u_xlat9);
          u_xlat0_d.x = ((u_xlat0_d.x * 4) + u_xlat6.x);
          u_xlat0_d.x = (u_xlat3 + u_xlat0_d.x);
          u_xlat0_d.x = (u_xlat0_d.x / _ResHorizontal);
          #ifdef UNITY_ADRENO_ES3
          u_xlatb3 = (_ScanlineGlitchEnabled==1);
          #else
          u_xlatb3 = (_ScanlineGlitchEnabled==1);
          #endif
          u_xlat16_1.x = (u_xlatb3)?(u_xlat0_d.x):(0);
          #ifdef UNITY_ADRENO_ES3
          u_xlatb0 = (_ShearStrength!=0);
          #else
          u_xlatb0 = (_ShearStrength!=0);
          #endif
          u_xlat16_1.x = (u_xlatb0)?(u_xlat16_1.x):(0);
          u_xlat0_d.x = (u_xlat16_1.x + in_f.texcoord.x);
          u_xlat0_d.y = in_f.texcoord.y;
          u_xlat0_d.xyz = tex2D(_MainTex, u_xlat0_d.xy).xyz;
          u_xlat16_1.xyz = ((-u_xlat0_d.xyz) + float3(1, 1, 1));
          u_xlatb2.xy = bool4(float4(_InvertScreen, _InvertGrayScreen, _InvertScreen, _InvertScreen) == float4(1, 1, 0, 0)).xy;
          u_xlat16_1.xyw = (u_xlatb2.x)?(u_xlat16_1.xyz):(u_xlat0_d.xyz);
          out_f.color.xyz = (u_xlatb2.y)?(u_xlat16_1.zzz):(u_xlat16_1.xyw);
          out_f.color.w = 1;
          return out_f;
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack Off
}
