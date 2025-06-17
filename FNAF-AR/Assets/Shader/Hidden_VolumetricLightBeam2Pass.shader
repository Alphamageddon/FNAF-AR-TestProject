Shader "Hidden/VolumetricLightBeam2Pass" {
	Properties {
		_ConeSlopeCosSin ("Cone Slope Cos Sin", Vector) = (0,0,0,0)
		_ConeRadius ("Cone Radius", Vector) = (0,0,0,0)
		_ConeApexOffsetZ ("Cone Apex Offset Z", Float) = 0
		[HDR] _ColorFlat ("Color", Vector) = (1,1,1,1)
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
		_NoiseParam ("Noise Param", Vector) = (0,0,0,)
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
			GpuProgramID 10164
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float3 texcoord : TEXCOORD0;
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
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			
			// Keywords: 
			v2f vert(appdata_full v)
			{
