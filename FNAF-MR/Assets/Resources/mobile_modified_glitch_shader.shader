Shader "Custom/Mobile Modified Glitch Shader" {
	Properties {
		_MainTex ("Main Texture", 2D) = "white" {}
		_ResHorizontal ("Horizontal Resolution", Float) = 640
		_ResVertical ("Vertical Resolution", Float) = 480
		_Timer ("Time", Float) = 1
		_ShearStrength ("Shear Strength", Float) = 0
		_ScanlineGlitchEnabled ("Scanline Glitch", Float) = 1
		_InvertScreen ("Invert Screen", Float) = 0
		_InvertGrayScreen ("Invert Gray Screen", Float) = 0
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
				output.pos = mul(unity_MatrixMVP, float4(input.pos, 1.0));
				return output;
			}

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;

			r Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			
			// Keywords: 
			v2f vert(appdata_full v)
			{
