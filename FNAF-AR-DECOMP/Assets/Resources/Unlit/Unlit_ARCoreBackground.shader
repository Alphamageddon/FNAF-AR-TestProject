Shader "Unlit/ARCoreBackground"
{
  Properties
  {
    _MainTex ("Texture", 2D) = "white" {}
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
      #define conv_mxt3x3_0(mat4x4) float3(mat4x4[0].x,mat4x4[1].x,mat4x4[2].x)
      #define conv_mxt3x3_1(mat4x4) float3(mat4x4[0].y,mat4x4[1].y,mat4x4[2].y)
      #define conv_mxt3x3_2(mat4x4) float3(mat4x4[0].z,mat4x4[1].z,mat4x4[2].z)
      
      
      //uniform float4x4 unity_ObjectToWorld;
      //uniform float4x4 unity_WorldToObject;
      //uniform float4x4 unity_MatrixVP;
      //uniform float4x4 unity_MatrixV;
      //uniform float4x4 unity_MatrixInvV;
      //uniform float4x4 UNITY_MATRIX_P;
      uniform float4x4 _UnityDisplayTransform;
      uniform sampler2D _MainTex;
      struct appdata_t
      {
          float4 vertex :POSITION;
          float4 texcoord :TEXCOORD0;
      };
      
      struct OUT_Data_Vert
      {
          float4 vertex :SV_POSITION;
      };
      
      struct v2f
      {
      };
      
      struct OUT_Data_Frag
      {
          float4 color :SV_Target0;
          float4 _glesFragColor :glesFragColor;
      };
      
      float3x3 transpose(float3x3 mtx)
      {
          float3 c0 = conv_mxt3x3_0(mtx);
          float3 c1 = conv_mxt3x3_1(mtx);
          float3 c2 = conv_mxt3x3_2(mtx);
          return float3x3(float3(c0.x, c1.x, c2.x), float3(c0.y, c1.y, c2.y), float3(c0.z, c1.z, c2.z));
      }
      
      float4x4 transpose(float4x4 mtx)
      {
          float4 c0 = conv_mxt4x4_0(mtx);
          float4 c1 = conv_mxt4x4_1(mtx);
          float4 c2 = conv_mxt4x4_2(mtx);
          float4 c3 = conv_mxt4x4_3(mtx);
          return float4x4(float4(c0.x, c1.x, c2.x, c3.x), float4(c0.y, c1.y, c2.y, c3.y), float4(c0.z, c1.z, c2.z, c3.z), float4(c0.w, c1.w, c2.w, c3.w));
      }
      
      #define CODE_BLOCK_VERTEX
      OUT_Data_Vert vert(appdata_t in_v)
      {
          OUT_Data_Vert out_v;
          #ifdef SHADER_API_GLES3
          float flippedV = (1 - in_v.texcoord.y);
          out_v.textureCoord.x = (((conv_mxt4x4_0(_UnityDisplayTransform).x * in_v.texcoord.x) + (conv_mxt4x4_1(_UnityDisplayTransform).x * flippedV)) + conv_mxt4x4_2(_UnityDisplayTransform).x);
          out_v.textureCoord.y = (((conv_mxt4x4_0(_UnityDisplayTransform).y * in_v.texcoord.x) + (conv_mxt4x4_1(_UnityDisplayTransform).y * flippedV)) + conv_mxt4x4_2(_UnityDisplayTransform).y);
          out_v.vertex = mul(mul(unity_MatrixVP, unity_ObjectToWorld), in_v.vertex);
          #endif
          return out_v;
      }
      
      #define CODE_BLOCK_FRAGMENT
      OUT_Data_Frag frag(v2f in_f)
      {
          OUT_Data_Frag out_f;
          #ifdef SHADER_API_GLES3
          out_f._glesFragColor = float4(tex2D(_MainTex, in_f.textureCoord).xyz, 1);
          #endif
          return out_f;
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack Off
}
