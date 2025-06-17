Shader "Hidden/VolumetricLightBeam1Pass" {
	Properties {
		_ConeSlopeCosSin ("Cone Slope Cos Sin", Vector) = (0,0,0,0)
		_ConeRadius ("Cone Radius", Vector) = (0,0,0,0)
		_ConeApexOffsetZ ("Cone Apex Offset Z", Float) = 0
		[HDR] _ColorFlat ("Color", Color) = (1,1,1,1)
		_AlphaInside ("Alpha Inside", Range(0, 1)) = 1
		_AlphaOutside ("Alpha Outside", Range(0, 1)) = 1
		_DistanceFadeStart ("Distance Fade Start", Float) = 0
		_DistanceFadeEnd ("Distance Fade End", Float) = 1
		_DistanceCamClipping ("Camera Clipping Distance", Float) = 0.5
		_FadeOutFactor ("FadeOutFactor", Float) = 1
		_AttenuationLerpLinearQuad ("Lerp between attenuation linear and quad", Float) = 0.5
		_DepthBlendDistance ("Depth Blend Distance", Float) = 2
		_FresnelPow ("Fresnel Pow", Range(0, 15)) = 1
		_GlareFrontal ("Glare Frontal", Range(0, 1)) = 0.5
		_GlareBehind ("Glare from Behind", Range(0, 1)) = 0.5
		_DrawCap ("Draw Cap", Float) = 1
		_NoiseLocal ("Noise Local", Vector) = (0,0,0,0)
		_NoiseParam ("Noise Param", Vector) = (0,0,0,0)
		_CameraParams ("Camera Params", Vector) = (0,0,0,0)
		_CameraPosObjectSpace ("Camera Position Object Space", Vector) = (0,0,0,0)
		_ClippingPlaneWS ("Clipping Plane WS", Vector) = (0,0,0,0)
		_BlendSrcFactor ("BlendSrcFactor", Float) = 1
		_BlendDstFactor ("BlendDstFactor", Float) = 1
	}
	SubShader {
		Tags { "DisableBatching" = "true" "IGNOREPROJECTOR" = "true" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
		Pass {
			Tags { "DisableBatching" = "true" "IGNOREPROJECTOR" = "true" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
			Blend Zero Zero, Zero Zero
			ZWrite Off
			Cull Front
			GpuProgramID 26498
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float3 texcoord : TEXCOORD0;
				float texcoord7 : TEXCOORD7;
				float4 texcoord1 : TEXCOORD1;
				float4 texcoord2 : TEXCOORD2;
				float3 texcoord3 : TEXCOORD3;
				float4 texcoord4 : TEXCOORD4;
				float4 texcoord5 : TEXCOORD5;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float4 _ColorFlat;
			float _AlphaInside;
			float _AlphaOutside;
			float2 _ConeRadius;
			float _AttenuationLerpLinearQuad;
			float _DistanceFadeStart;
			float _DistanceFadeEnd;
			float _FadeOutFactor;
			float _GlareFrontal;
			float _DrawCap;
			float4 _CameraParams;
			// $Globals ConstantBuffers for Fragment Shader
			float2 _ConeSlopeCosSin;
			float _ConeApexOffsetZ;
			float _DistanceCamClipping;
			float _FresnelPow;
			float _GlareBehind;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			
			// Keywords: 
			v2f vert(appdata_full v)
			{
                v2f o;
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                float4 tmp3;
                float4 tmp4;
                tmp0.xy = max(_ConeRadius, _ConeRadius);
                tmp1.xy = _ConeRadius / tmp0.yy;
                tmp0.w = tmp1.y - tmp1.x;
                tmp2.z = v.vertex.z * v.vertex.z;
                tmp0.w = tmp2.z * tmp0.w + tmp1.x;
                tmp2.xy = tmp0.ww * v.vertex.xy;
                tmp1 = tmp2.yyyy * cb2[1];
                tmp1 = cb2[0] * tmp2.xxxx + tmp1;
                tmp1 = cb2[2] * tmp2.zzzz + tmp1;
                tmp3 = tmp1 + cb2[3];
                o.texcoord1 = cb2[3] * v.vertex.wwww + tmp1;
                tmp1 = tmp3.yyyy * cb3[18];
                tmp1 = cb3[17] * tmp3.xxxx + tmp1;
                tmp1 = cb3[19] * tmp3.zzzz + tmp1;
                o.position = cb3[20] * tmp3.wwww + tmp1;
                o.texcoord7.x = v.texcoord.y;
                tmp0.z = _DistanceFadeEnd;
                tmp1.xyz = tmp0.xyz * tmp2.xyz;
                o.texcoord.xyz = tmp1.xyz;
                tmp1.xyw = cb2[2].yyy * cb3[10].xyz;
                tmp1.xyw = cb3[9].xyz * cb2[2].xxx + tmp1.xyw;
                tmp1.xyw = cb3[11].xyz * cb2[2].zzz + tmp1.xyw;
                tmp1.xyw = cb3[12].xyz * cb2[2].www + tmp1.xyw;
                tmp3.xyz = cb2[0].yyy * cb3[10].xyz;
                tmp3.xyz = cb3[9].xyz * cb2[0].xxx + tmp3.xyz;
                tmp3.xyz = cb3[11].xyz * cb2[0].zzz + tmp3.xyz;
                tmp3.xyz = cb3[12].xyz * cb2[0].www + tmp3.xyz;
                tmp4.xyz = cb2[1].yyy * cb3[10].xyz;
                tmp4.xyz = cb3[9].xyz * cb2[1].xxx + tmp4.xyz;
                tmp4.xyz = cb3[11].xyz * cb2[1].zzz + tmp4.xyz;
                tmp4.xyz = cb3[12].xyz * cb2[1].www + tmp4.xyz;
                tmp4.xyz = tmp2.yyy * tmp4.xyz;
                tmp3.xyz = tmp3.xyz * tmp2.xxx + tmp4.xyz;
                tmp1.xyw = tmp1.xyw * tmp2.zzz + tmp3.xyz;
                tmp3.xyz = cb2[3].yyy * cb3[10].xyz;
                tmp3.xyz = cb3[9].xyz * cb2[3].xxx + tmp3.xyz;
                tmp3.xyz = cb3[11].xyz * cb2[3].zzz + tmp3.xyz;
                tmp3.xyz = cb3[12].xyz * cb2[3].www + tmp3.xyz;
                o.texcoord2.xyz = tmp1.xyw + tmp3.xyz;
                tmp0.w = _GlareFrontal * _DistanceFadeEnd + 0.001;
                tmp0.w = 1.0 / tmp0.w;
                tmp1.x = max(abs(tmp1.z), 0.001);
                tmp1.y = abs(tmp1.z) - _DistanceFadeStart;
                tmp0.w = saturate(tmp0.w * tmp1.x);
                tmp1.x = tmp0.w * -2.0 + 3.0;
                tmp0.w = tmp0.w * tmp0.w;
                tmp0.w = -tmp1.x * tmp0.w + 1.0;
                tmp0.w = v.texcoord.y * -tmp0.w + tmp0.w;
                tmp1.x = saturate(_CameraParams.w);
                tmp1.z = tmp0.w * tmp1.x;
                tmp0.w = -tmp1.x * tmp0.w + 1.0;
                o.texcoord2.w = v.texcoord.x * tmp0.w + tmp1.z;
                tmp1.xzw = cb1[4].yyy * cb2[5].xyz;
                tmp1.xzw = cb2[4].xyz * cb1[4].xxx + tmp1.xzw;
                tmp1.xzw = cb2[6].xyz * cb1[4].zzz + tmp1.xzw;
                tmp1.xzw = tmp1.xzw + cb2[7].xyz;
                tmp1.xzw = tmp0.xyz * tmp1.xzw;
                tmp0.xyz = tmp2.xyz * tmp0.xyz + -tmp1.xzw;
                o.texcoord3.xyz = tmp1.xzw;
                tmp0.w = _AlphaOutside - _AlphaInside;
                tmp0.w = v.texcoord.y * tmp0.w + _AlphaInside;
                o.texcoord4.w = tmp0.w * _ColorFlat.w;
                o.texcoord4.xyz = _ColorFlat.xyz;
                tmp0.x = dot(tmp0.xyz, tmp0.xyz);
                tmp0.x = rsqrt(tmp0.x);
                tmp0.y = tmp0.x * tmp0.z;
                tmp0.x = -tmp0.z * tmp0.x + _CameraParams.z;
                tmp0.x = cb1[8].w * tmp0.x + tmp0.y;
                tmp0.x = tmp0.x - 1.0;
                tmp0.x = saturate(tmp0.x * -0.5);
                tmp0.y = tmp0.x * -2.0 + 3.0;
                tmp0.x = tmp0.x * tmp0.x;
                tmp0.x = tmp0.x * tmp0.y;
                tmp0.x = min(tmp0.x, 1.0);
                tmp0.y = tmp0.x * -2.0 + 1.0;
                tmp0.x = v.texcoord.y * tmp0.y + tmp0.x;
                tmp0.y = _DistanceFadeEnd - _DistanceFadeStart;
                tmp0.y = saturate(tmp1.y / tmp0.y);
                tmp0.z = tmp0.y - 1.0;
                tmp0.z = tmp0.z * -5.0;
                tmp0.z = min(tmp0.z, 1.0);
                tmp0.w = tmp0.z * -2.0 + 3.0;
                tmp0.z = tmp0.z * tmp0.z;
                tmp0.z = tmp0.z * tmp0.w;
                tmp0.z = min(tmp0.z, 1.0);
                tmp0.w = tmp0.y * tmp0.y;
                tmp0.y = 1.0 - tmp0.y;
                tmp0.w = tmp0.w * 25.0 + 1.0;
                tmp0.w = 1.0 / tmp0.w;
                tmp1.x = tmp0.y * -2.0 + 3.0;
                tmp0.y = tmp0.y * tmp0.y;
                tmp0.y = tmp0.y * tmp1.x;
                tmp0.z = tmp0.w * tmp0.z + -tmp0.y;
                tmp0.y = _AttenuationLerpLinearQuad * tmp0.z + tmp0.y;
                tmp0.z = -v.texcoord.y * v.texcoord.x + 1.0;
                tmp0.y = tmp0.y * tmp0.z;
                tmp0.y = tmp0.y * _FadeOutFactor;
                tmp0.x = tmp0.x * tmp0.y;
                tmp0.y = _DrawCap >= v.texcoord.x;
                tmp0.y = tmp0.y ? 1.0 : 0.0;
                o.texcoord5.w = tmp0.y * tmp0.x;
                o.texcoord5.xyz = float3(1.0, 1.0, 1.0);
                return o;
			}
			// Keywords: 
			fout frag(v2f inp)
			{
                fout o;
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                tmp0.xy = inp.texcoord.xy;
                tmp0.z = inp.texcoord.z + _ConeApexOffsetZ;
                tmp0.w = dot(tmp0.xyz, tmp0.xyz);
                tmp0.w = rsqrt(tmp0.w);
                tmp0.xyz = tmp0.www * tmp0.xyz;
                tmp1.xyz = inp.texcoord.xyz - inp.texcoord3.xyz;
                tmp0.w = dot(tmp1.xyz, tmp1.xyz);
                tmp0.w = rsqrt(tmp0.w);
                tmp2.xyz = tmp0.www * tmp1.xyz;
                tmp1.xyz = -tmp1.xyz * tmp0.www + _CameraParams.xyz;
                tmp1.xyz = cb1[8].www * tmp1.xyz + tmp2.xyz;
                tmp0.w = dot(-tmp1.xyz, tmp0.xyz);
                tmp0.xyz = -tmp0.www * tmp0.xyz + -tmp1.xyz;
                tmp0.w = dot(tmp0.xyz, tmp0.xyz);
                tmp0.w = rsqrt(tmp0.w);
                tmp0.xyz = tmp0.www * tmp0.xyz;
                tmp0.w = dot(inp.texcoord.xy, inp.texcoord.xy);
                tmp0.w = rsqrt(tmp0.w);
                tmp2.xy = tmp0.ww * inp.texcoord.xy;
                tmp2.xy = tmp2.xy * _ConeSlopeCosSin;
                tmp0.w = inp.texcoord7.x * 2.0 + -1.0;
                tmp2.xy = tmp0.ww * tmp2.xy;
                tmp2.z = tmp0.w * -_ConeSlopeCosSin.y;
                tmp0.x = dot(tmp2.xyz, tmp0.xyz);
                tmp0.y = dot(tmp2.xyz, -tmp1.xyz);
                tmp0.y = tmp0.y - tmp0.x;
                tmp0.x = saturate(abs(tmp1.z) * tmp0.y + tmp0.x);
                tmp0.y = tmp0.x * -2.0 + 3.0;
                tmp0.x = tmp0.x * tmp0.x;
                tmp0.x = tmp0.x * tmp0.y;
                tmp0.y = log(tmp0.x);
                tmp0.x = -tmp0.x >= 0.0;
                tmp0.x = tmp0.x ? 0.0 : 1.0;
                tmp0.z = _GlareBehind - _GlareFrontal;
                tmp0.z = inp.texcoord7.x * tmp0.z + _GlareFrontal;
                tmp0.z = 1.0 - tmp0.z;
                tmp0.z = tmp0.z * 1.5;
                tmp0.z = min(tmp0.z, _FresnelPow);
                tmp0.z = tmp0.z - _FresnelPow;
                tmp0.z = abs(tmp1.z) * tmp0.z + _FresnelPow;
                tmp0.y = tmp0.y * tmp0.z;
                tmp0.y = exp(tmp0.y);
                tmp0.z = tmp0.y * tmp0.x;
                tmp0.w = -tmp0.x * tmp0.y + 1.001;
                tmp0.z = inp.texcoord2.w * tmp0.w + tmp0.z;
                tmp0.x = tmp0.x * tmp0.y + -tmp0.z;
                tmp0.x = inp.texcoord7.x * tmp0.x + tmp0.z;
                tmp0.y = abs(inp.texcoord2.z) - cb1[5].y;
                tmp0.y = saturate(tmp0.y / _DistanceCamClipping);
                tmp0.z = tmp0.y * -2.0 + 3.0;
                tmp0.y = tmp0.y * tmp0.y;
                tmp0.y = tmp0.z * tmp0.y + -1.0;
                tmp0.z = max(inp.texcoord2.w, cb1[8].w);
                tmp0.z = 1.0 - tmp0.z;
                tmp0.y = tmp0.z * tmp0.y + 1.0;
                tmp0.y = tmp0.y * inp.texcoord5.w;
                tmp0.x = tmp0.x * tmp0.y;
                o.sv_target.w = tmp0.x * inp.texcoord4.w;
                o.sv_target.xyz = inp.texcoord4.xyz;
                return o;
			}
			ENDCG
		}
	}
}