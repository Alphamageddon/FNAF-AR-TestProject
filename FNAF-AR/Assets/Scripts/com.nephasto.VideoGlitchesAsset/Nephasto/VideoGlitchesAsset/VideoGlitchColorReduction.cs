using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Nephasto/Video Glitches/Video Glitch Color reduction")]
	public sealed class VideoGlitchColorReduction : VideoGlitchBase
	{
		public enum Ditherings
		{
			Bayer4x4 = 0,
			Bayer8x8 = 1,
			Noise = 2,
			AnimNoise = 3
		}

		[SerializeField]
		private Ditherings dithering;

		[SerializeField]
		private int paletteSize = 8;

		[SerializeField]
		private int pixelation = 2;

		private Texture2D ditheringTexture;

		private static readonly int variablePaletteSpace = Shader.PropertyToID("_PaletteSpace");

		private static readonly int variablePixelation = Shader.PropertyToID("_Pixelation");

		private static readonly int variableDitheringTexture = Shader.PropertyToID("_DitheringTex");

		private const string keywordBayer4x4 = "DITHERING_BAYER4x4";

		private const string keywordBayer8x8 = "DITHERING_BAYER8x8";

		private const string keywordNoise = "DITHERING_NOISE";

		[Enum(typeof(Ditherings))]
		public Ditherings Dithering
		{
			get
			{
				return dithering;
			}
			set
			{
				dithering = value;
			}
		}

		[RangeInt(0, 256, 8)]
		public int PaletteSize
		{
			get
			{
				return paletteSize;
			}
			set
			{
				paletteSize = ((value >= 0) ? value : 0);
			}
		}

		[RangeInt(1, 25, 2)]
		public int Pixelation
		{
			get
			{
				return pixelation;
			}
			set
			{
				pixelation = ((value < 1) ? 1 : value);
			}
		}

		public override string ToString()
		{
			return "Palette quantization and dithering.";
		}

		protected override void LoadCustomResources()
		{
			ditheringTexture = LoadTextureFromResources("Textures/Bayer4x4");
		}

		public override void ResetDefaultValues()
		{
			dithering = Ditherings.Bayer4x4;
			paletteSize = 8;
			pixelation = 2;
			base.ResetDefaultValues();
		}

		public override void RandomValues()
		{
			dithering = ((!(Random.Range(0f, 1f) > 0.5f)) ? Ditherings.Bayer8x8 : Ditherings.Bayer4x4);
			paletteSize = RandomRange(paletteSize, 6, 12);
			pixelation = RandomRange(pixelation, 2, 4);
		}

		protected override void SendValuesToShader()
		{
			switch (dithering)
			{
			case Ditherings.Bayer4x4:
				material.EnableKeyword("DITHERING_BAYER4x4");
				material.SetTexture(variableDitheringTexture, ditheringTexture);
				break;
			case Ditherings.Bayer8x8:
				material.EnableKeyword("DITHERING_BAYER8x8");
				break;
			case Ditherings.Noise:
				material.EnableKeyword("DITHERING_NOISE");
				break;
			}
			material.SetFloat(variablePixelation, (float)pixelation * 1f);
			material.SetFloat(variablePaletteSpace, (paletteSize > 0) ? (1f / (float)paletteSize) : 0f);
		}
	}
}
