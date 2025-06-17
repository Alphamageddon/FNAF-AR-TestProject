using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Nephasto/Video Glitches/Video Glitch RGB Display")]
	public sealed class VideoGlitchRGBDisplay : VideoGlitchBase
	{
		[SerializeField]
		private int cellSize = 2;

		private static readonly int variableCellSize = Shader.PropertyToID("_CellSize");

		[RangeInt(1, 10, 2)]
		public int Size
		{
			get
			{
				return cellSize;
			}
			set
			{
				cellSize = ((value < 1) ? 1 : value);
			}
		}

		public override string ToString()
		{
			return "RGB pixelated display.";
		}

		public override void ResetDefaultValues()
		{
			cellSize = 2;
			base.ResetDefaultValues();
		}

		public override void RandomValues()
		{
			cellSize = RandomRange(cellSize, 1, 4);
		}

		protected override void SendValuesToShader()
		{
			material.SetInt(variableCellSize, cellSize * 3);
		}
	}
}
