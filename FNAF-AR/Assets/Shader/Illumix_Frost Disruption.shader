Shader "Illumix/Frost Disruption" {
	Properties {
		_Cutoff ("Mask Clip Value", Float) = 0.5
		_ColorTint ("Color Tint", Vector) = (0,0,0,0)
		_MainTex ("MainTex", 2D) = "white" {}
		_Pattern ("Pattern", 2D) = "white" {}
		_OpacityGuide ("OpacityGuide", 2D) = "white" {}
		_NoisePattern ("NoisePattern", 2D) = "white" {}
		_Grow ("Grow", Range(0, 1)) = 0
		_Distortion ("Distortion", Range(0, 1)) = 0
		_Brightness ("Brightness", Range(0, 1)) = 0
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] __dirty ("", Float) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
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
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixMVP, float4(input.pos, 1.0		float2 texcoord : TEXCOORD0;
				float3 texcoord1 : TEXCOORD1;
				float3 texcoord2 : TEXCOORD2;
				float4 texcoord3 : TEXCOORD3;
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
			sampler2D unity_NHxRoughness;
			
			// Keywords: 
			v2f vert(appdata_full v)
			{
