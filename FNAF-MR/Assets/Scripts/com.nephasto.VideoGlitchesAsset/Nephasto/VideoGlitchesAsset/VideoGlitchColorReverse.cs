using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Nephasto/Video Glitches/Video Glitch Color reverse")]
	public sealed class VideoGlitchColorReverse : VideoGlitchBase
	{
		[SerializeField]
		private float intensity = 10f;

		[SerializeField]
		private Color colorReference = Color.white;

		[SerializeField]
		private float colorStrength = 1f;

		private static readonly int variableIntensity = Shader.PropertyToID("_Intensity");

		private static readonly int variableColorReference = Shader.PropertyToID("_ColorReference");

		private static readonly int variableColorStrength = Shader.PropertyToID("_ColorStrength");

		[RangeFloat(0f, 50f, 10f)]
		public float Intensity
		{
			get
			{
				return intensity;
			}
			set
			{
				intensity = Mathf.Max(0f, value);
			}
		}

		public Color ColorReference
		{
			get
			{
				return colorReference;
			}
			set
			{
				colorReference = value;
			}
		}

		[RangeFloat(0f, 10f, 1f)]
		public float ColorStrength
		{
			get
			{
				return colorStrength;
			}
			set
			{
				colorStrength = Mathf.Max(0f, value);
			}
		}

		public override string ToString()
		{
			return "Color reverse.";
		}

		public override void ResetDefaultValues()
		{
			intensity = 10f;
			colorReference = Color.white;
			colorStrength = 1f;
			base.ResetDefaultValues();
		}

		public override void RandomValues()
		{
			intensity = Random.Range(5f, 15f);
			int index = ((!(Random.Range(0f, 1f) < 0.5f)) ? 1 : 0);
			colorReference = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
			float num = colorReference[index] + 0.5f;
			colorReference[index] = num - Mathf.Floor(num);
			colorStrength = Random.Range(1.75f, 2.25f);
		}

		protected override void SendValuesToShader()
		{
			material.SetFloat(variableIntensity, intensity);
			material.SetColor(variableColorReference, colorReference);
			material.SetFloat(variableColorStrength, ColorStrength);
		}
	}
}
