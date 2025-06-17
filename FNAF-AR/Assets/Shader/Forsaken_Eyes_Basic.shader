Shader "Forsaken/Eyes_Basic" {
	Properties {
		[Header(Textures)] _PupilTex ("Pupil Tex", 2D) = "white" {}
		_IrisTex ("Iris Tex", 2D) = "white" {}
		_ColorationTex ("Coloration Tex", 2D) = "white" {}
		_GrungeTex ("Grunge Tex", 2D) = "white" {}
		[Header(Grunge)] _GrungeTiling ("Grunge Tiling", Range(0, 20)) = 0.5
		_GrungeOffset ("Grunge Offset", Range(0, 1)) = 0
		_GrungeDirtBalance ("Grunge Dirt Balance", Range(0, 0.85)) = 0.85
		_GrungeDirtContrast ("Grunge Dirt Contrast", Range(0, 1)) = 0.8
		_GrungeDirtColor ("Grunge Dirt Color", Vector) = (0.03187212,0.02856486,0.02622202,0)
		_GrungeSmearBalance ("Grunge Smear Balance", Range(0, 0.5)) = 0.5
		_GrungeSmearContrast ("Grunge Smear Contrast", Range(0, 1)) = 0.8
		_GrungeSmearColor ("Grunge Smear Color", Vector) = (0,0,0,0)
		_GrungeRoughness ("Grunge Roughness", Range(0, 1)) = 0.5
		_OilRoughness ("Oil Roughness", Range(0, 1)) = 0.9
		[Header(Colors)] _EyeColor ("Eye Color", Vector) = (0,0.427451,0.7411765,1)
		_EyeBallColor ("Eye Ball Color", Vector) = (0.7960785,0.7960785,0.7960785,1)
		_IrisBorderColor ("Iris Border Color", Vector) = (0,0,0,0)
		_PaintedEyeDotsColor ("Painted Eye Dots Color", Vector) = (1,1,1,0)
		_PupilColor ("Pupil Color", Vector) = (0,0,0,0)
		[Header(Glow)] _GlowAmount ("Glow Amount", Range(0, 25)) = 25
		_GlowFlicker ("Glow Flicker", Range(0, 50)) = 0
		[Header(Exterminate)] [Toggle] _ExterminateSwitch ("Exterminate Switch", Range(0, 1)) = 1
		[HDR] _ExterminateColor ("Exterminate Color", Vector) = (1,0,0,1)
		[Header(Floats)] _IrisBalance ("Iris Balance", Range(0, 1)) = 1
		_EyeScale ("Eye Scale", Range(-0.5, 0.5)) = 0
		_RoughnessAmount ("Roughness Amount", Range(0, 1)) = 0.817
		_ColorationRotator ("Coloration Rotator", Range(0, 360)) = 0
		_IrisRotator ("Iris Rotator", Range(0, 360)) = 0
		_PaintedEyeDotsRotator ("Painted Eye Dots Rotator", Range(0, 360)) = 0
		_GrungeRotator ("Grunge Rotator", Range(0, 360)) = 0
		[Header(Toggles)] [Toggle] _ToggleIrisAdvanced ("Toggle Iris Advanced", Range(0, 1)) = 0
		[Toggle] _ToggleGlowingIris ("Toggle Glowing Iris", Range(0, 1)) = 0
		[Toggle] _ToggleGlowingPupil ("Toggle Glowing Pupil", Range(0, 1)) = 1
		[Toggle] _TogglePaintedEyeDots ("Toggle Painted Eye Dots", Range(0, 1)) = 0
		[Toggle] _ToggleOffRoughness ("Toggle Off Roughness", Range(0, 1)) = 0
		[Header(Cloak)] _PlanePosition ("PlanePosition", Vector) = (0,0,0,0)
		_PlaneNormal ("PlaneNormal", Vector) = (0,1,0,0)
		[HDR] _GlowColor ("Glow Color", Vector) = (0.9215686,0.1411765,0.01568628,0)
		_Cutoff ("Mask Clip Value", Float) = 0.5
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] __dirty ("", Float) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_MatrixMVP;

			struct Vertex_Stage_Input
			{
				float3 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output 	float4 position : SV_POSITION0;
				float2 texcoord : TEXCOORD0;
				float3 texcoord1 : TEXCOORD1;
				float3 texcoord2 : TEXCOORD2;
				float4 texcoord5 : TEXCOORD5;
				float4 texcoord6 : TEXCOORD6;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			// $Globals ConstantBuffers for Fragment Shader
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _PupilTex;
			sampler2D _ColorationTex;
			sampler2D _IrisTex;
			sampler2D _GrungeTex;
			
			// Keywords: 
			v2f vert(appdata_full v)
			{
