using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Nephasto/Video Glitches/Video Glitch CRT display")]
	public sealed class VideoGlitchCRTDisplay : VideoGlitchBase
	{
		[SerializeField]
		private int pixelSize = 3;

		private static readonly int variablePixelSize = Shader.PropertyToID("_PixelSize");

		[RangeInt(1, 10, 3)]
		public int PixelSize
		{
			get
			{
				return pixelSize;
			}
			set
			{
				pixelSize = ((value <= 1) ? 1 : value);
			}
		}

		public override string ToString()
		{
			return "CRT display.";
		}

		public override void ResetDefaultValues()
		{
			pixelSize = 3;
			base.ResetDefaultValues();
		}

		public override void RandomValues()
		{
			pixelSize = RandomRange(pixelSize, 1, 4);
		}

		protected override void SendValuesToShader()
		{
			material.SetFloat(variablePixelSize, pixelSize);
		}
	}
}
