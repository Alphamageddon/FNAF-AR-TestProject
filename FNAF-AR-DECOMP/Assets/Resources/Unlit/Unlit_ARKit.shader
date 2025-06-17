Shader "Unlit/ARKit"
{
  Properties
  {
    _textureY ("TextureY", 2D) = "white" {}
    _textureCbCr ("TextureCbCr", 2D) = "black" {}
  }
  SubShader
  {
    Tags
    { 
      "RenderType" = "Opaque"
    }
    LOD 100
    Pass // ind: 1, name: 
    {
      Tags
      { 
        "RenderType" = "Opaque"
      }
      LOD 100
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
      
      
      #define CODE_BLOCK_VERTEX
      //uniform float4x4 unity_ObjectToWorld;
      //uniform float4x4 unity_MatrixVP;
      uniform float4x4 _UnityDisplayTransform;
      uniform sampler2D _textureY;
      uniform sampler2D _textureCbCr;
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
          u_xlat0.x = dot(conv_mxt4x4_0(_UnityDisplayTransform).xy, in_v.texcoord.xy);
          out_v.texcoord.x = (u_xlat0.x + conv_mxt4x4_0(_UnityDisplayTransform).z);
          u_xlat0.x = dot(conv_mxt4x4_1(_UnityDisplayTransform).xy, in_v.texcoord.xy);
          out_v.texcoord.y = (u_xlat0.x + conv_mxt4x4_1(_UnityDisplayTransform).z);
          return out_v;
      }
      
      #define CODE_BLOCK_FRAGMENT
      float4 u_xlat0_d;
      float4 u_xlat1_d;
      OUT_Data_Frag frag(v2f in_f)
      {
          OUT_Data_Frag out_f;
          u_xlat0_d.w = 1;
          u_xlat1_d.x = tex2D(_textureY, in_f.texcoord.xy).x;
          u_xlat1_d.yz = tex2D(_textureCbCr, in_f.texcoord.xy).xy;
          u_xlat1_d.w = 1;
          u_xlat0_d.x = dot(float3(1, 1.40199995, (-0.700999975)), u_xlat1_d.xzw);
          u_xlat0_d.y = dot(float4(1, (-0.344099998), (-0.714100003), 0.529100001), u_xlat1_d);
          u_xlat0_d.z = dot(float3(1, 1.77199996, (-0.885999978)), u_xlat1_d.xyw);
          out_f.color = u_xlat0_d;
          return out_f;
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack Off
}
