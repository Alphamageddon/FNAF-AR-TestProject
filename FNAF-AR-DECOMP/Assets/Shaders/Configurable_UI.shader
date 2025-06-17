Shader "Configurable/UI"
{
  Properties
  {
    [PerRendererData] _MainTex ("Sprite Texture", 2D) = "white" {}
    _Color ("Tint", Color) = (1,1,1,1)
    _Strength ("Strength", float) = 1
    [SimpleToggle] _UseVertexColor ("Vertex color", float) = 1
    [HeaderHelpURL(Rendering, https, github.com supyrb ConfigurableShaders wiki Rendering)] [Enum(None,0,Alpha,1,Red,8,Green,4,Blue,2,RGB,14,RGBA,15)] _ColorMask ("Color Mask", float) = 14
    [Toggle(UNITY_UI_ALPHACLIP)] _UseUIAlphaClip ("Use Alpha Clip", float) = 1
    [HeaderHelpURL(Blending, https, github.com supyrb ConfigurableShaders wiki Blending)] [Enum(UnityEngine.Rendering.BlendMode)] _BlendSrc ("Blend mode Source", float) = 5
    [Enum(UnityEngine.Rendering.BlendMode)] _BlendDst ("Blend mode Destination", float) = 10
    [HeaderHelpURL(Stencil, https, github.com supyrb ConfigurableShaders wiki Stencil)] [EightBit] _Stencil ("Stencil ID", float) = 0
    [Enum(UnityEngine.Rendering.CompareFunction)] _StencilComp ("Stencil Comparison", float) = 0
    [Enum(UnityEngine.Rendering.StencilOp)] _StencilOp ("Stencil Operation", float) = 0
    [Enum(UnityEngine.Rendering.StencilOp)] _StencilFail ("Stencil Fail", float) = 0
    [Enum(UnityEngine.Rendering.StencilOp)] _StencilZFail ("Stencil ZFail", float) = 0
    [EightBit] _ReadMask ("ReadMask", float) = 255
    [EightBit] _WriteMask ("WriteMask", float) = 255
  }
  SubShader
  {
    Tags
    { 
      "CanUseSpriteAtlas" = "true"
      "IGNOREPROJECTOR" = "true"
      "PreviewType" = "Plane"
      "QUEUE" = "Transparent"
      "RenderType" = "Transparent"
    }
    Pass // ind: 1, name: 
    {
      Tags
      { 
        "CanUseSpriteAtlas" = "true"
        "IGNOREPROJECTOR" = "true"
        "PreviewType" = "Plane"
        "QUEUE" = "Transparent"
        "RenderType" = "Transparent"
      }
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
      Blend Zero Zero
      ColorMask 0
      // m_ProgramMask = 6
      CGPROGRAM
      //#pragma target 4.0
      
      #pragma vertex vert
      #pragma fragment frag
      
      #include "UnityCG.cginc"
      
      
      #define CODE_BLOCK_VERTEX
      //uniform float4x4 unity_ObjectToWorld;
      //uniform float4x4 unity_MatrixVP;
      uniform float4 _Color;
      uniform float _UseVertexColor;
      uniform float4 _TextureSampleAdd;
      uniform float4 _ClipRect;
      uniform float _Strength;
      uniform sampler2D _MainTex;
      struct appdata_t
      {
          float4 vertex :POSITION0;
          float4 color :COLOR0;
          float2 texcoord :TEXCOORD0;
      };
      
      struct OUT_Data_Vert
      {
          float4 color :COLOR0;
          float2 texcoord :TEXCOORD0;
          float4 texcoord1 :TEXCOORD1;
          float4 vertex :SV_POSITION;
      };
      
      struct v2f
      {
          float4 color :COLOR0;
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
          out_v.vertex = UnityObjectToClipPos(in_v.vertex);
          u_xlat0 = ((in_v.color * _Color) + (-_Color));
          u_xlat0 = ((float4(_UseVertexColor, _UseVertexColor, _UseVertexColor, _UseVertexColor) * u_xlat0) + _Color);
          out_v.color = u_xlat0;
          out_v.texcoord.xy = in_v.texcoord.xy;
          out_v.texcoord1 = in_v.vertex;
          return out_v;
      }
      
      #define CODE_BLOCK_FRAGMENT
      float4 u_xlat0_d;
      float4 u_xlatb0;
      float4 u_xlat1_d;
      float4 u_xlat16_1;
      OUT_Data_Frag frag(v2f in_f)
      {
          OUT_Data_Frag out_f;
          u_xlatb0.xy = bool4(in_f.texcoord1.xyxx >= _ClipRect.xyxx).xy;
          u_xlatb0.zw = bool4(_ClipRect.zzzw >= in_f.texcoord1.xxxy).zw;
          u_xlat0_d = lerp(float4(0, 0, 0, 0), float4(1, 1, 1, 1), float4(u_xlatb0));
          u_xlat0_d.xy = (u_xlat0_d.zw * u_xlat0_d.xy);
          u_xlat0_d.x = (u_xlat0_d.y * u_xlat0_d.x);
          u_xlat16_1 = tex2D(_MainTex, in_f.texcoord.xy);
          u_xlat16_1 = (u_xlat16_1 + _TextureSampleAdd);
          u_xlat16_1 = (u_xlat16_1 * in_f.color);
          u_xlat1_d = (u_xlat16_1 * float4(_Strength, _Strength, _Strength, _Strength));
          u_xlat1_d.w = (u_xlat0_d.x * u_xlat1_d.w);
          out_f.color = u_xlat1_d;
          return out_f;
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack Off
}
