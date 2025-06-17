using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Nephasto/Video Glitches/Video Glitch Color blindness")]
	public sealed class VideoGlitchColorBlindness : VideoGlitchBase
	{
		[SerializeField]
		private ColorVisionDeficiency colorVisionDeficiency;

		[SerializeField]
		private float comparator = 1f;

		private static readonly int variableColorBlindness = Shader.PropertyToID("_ColorBlindness");

		private static readonly int variableComparator = Shader.PropertyToID("_Comparator");

		private static readonly string[] colorVisionDeficiencyDescription = new string[8] { "Protanomaly: red-green vision deficiency, 1% of males, 0.03% of females.", "Deuteranomaly: red-green color blindness, 6% of males, 0.4% of females.", "Tritanomaly: blue-yellow color blindness, 0.01% for males and females.", "Protanopia: reds are greatly reduced, 1% of males, 0.02% of females.", "Deuteranopia: greens are greatly reduced, 1% of males.", "Tritanopia: blues are greatly reduced, 0.003% population.", "Achromatopsia: total color blindness", "Achromatomaly: partial color blindness." };

		public ColorVisionDeficiency Deficiency
		{
			get
			{
				return colorVisionDeficiency;
			}
			set
			{
				colorVisionDeficiency = value;
			}
		}

		public float Comparator
		{
			get
			{
				return comparator;
			}
			set
			{
				comparator = Mathf.Clamp01(value);
			}
		}

		public override string ToString()
		{
			return colorVisionDeficiencyDescription[(int)colorVisionDeficiency];
		}

		public static string GetDescription(ColorVisionDeficiency colorVisionDeficiency)
		{
			return colorVisionDeficiencyDescription[(int)colorVisionDeficiency];
		}

		public override void ResetDefaultValues()
		{
			comparator = 1f;
			base.ResetDefaultValues();
		}

		public override void RandomValues()
		{
		}

		protected override void SendValuesToShader()
		{
			material.SetInt(variableColorBlindness, (int)colorVisionDeficiency);
			material.SetFloat(variableComparator, comparator);
		}
	}
}
