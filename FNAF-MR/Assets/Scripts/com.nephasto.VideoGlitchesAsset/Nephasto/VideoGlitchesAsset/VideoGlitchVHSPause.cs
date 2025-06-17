using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Nephasto/Video Glitches/Video Glitch VHS Pause")]
	public sealed class VideoGlitchVHSPause : VideoGlitchBase
	{
		[SerializeField]
		private float intensity = 1f;

		[SerializeField]
		private float noise = 0.1f;

		[SerializeField]
		private Color noiseColor = Color.white;

		private static readonly int variableIntensity = Shader.PropertyToID("_Intensity");

		private static readonly int variableColorNoise = Shader.PropertyToID("_ColorNoise");

		private static readonly int variableNoiseColor = Shader.PropertyToID("_NoiseColor");

		[RangeFloat(0f, 1f, 1f)]
		public float Intensity
		{
			get
			{
				return intensity;
			}
			set
			{
				intensity = Mathf.Clamp01(value);
			}
		}

		[RangeFloat(0f, 1f, 0.1f)]
		public float Noise
		{
			get
			{
				return noise;
			}
			set
			{
				noise = Mathf.Clamp01(value);
			}
		}

		public Color Color
		{
			get
			{
				return noiseColor;
			}
			set
			{
				noiseColor = value;
			}
		}

		public override string ToString()
		{
			return "VHS pause noise.";
		}

		public override void ResetDefaultValues()
		{
			intensity = 1f;
			noise = 0.1f;
			noiseColor = Color.white;
			base.ResetDefaultValues();
		}

		public override void RandomValues()
		{
			intensity = Random.Range(0.5f, 1f);
			noise = Random.Range(0f, 1f);
		}

		protected override void SendValuesToShader()
		{
			material.SetFloat(variableIntensity, intensity);
			material.SetFloat(variableColorNoise, noise);
			material.SetColor(variableNoiseColor, noiseColor);
		}
	}
}
