using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Nephasto/Video Glitches/Video Glitch Spectrum Offset")]
	public sealed class VideoGlitchSpectrumOffset : VideoGlitchBase
	{
		[SerializeField]
		private float intensity = 0.1f;

		[SerializeField]
		private int steps = 5;

		private static readonly int variableIntensity = Shader.PropertyToID("_Intensity");

		private static readonly int variableSteps = Shader.PropertyToID("_Steps");

		[RangeFloat(0f, 1f, 0.1f)]
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

		[RangeInt(3, 10, 5)]
		public int Steps
		{
			get
			{
				return steps;
			}
			set
			{
				steps = ((value < 3) ? 3 : value);
			}
		}

		public override string ToString()
		{
			return "Spectrum offset.";
		}

		public override void ResetDefaultValues()
		{
			intensity = 0.1f;
			steps = 5;
			base.ResetDefaultValues();
		}

		public override void RandomValues()
		{
			intensity = Random.Range(0f, 0.2f);
			steps = RandomRange(steps, 3, 8);
		}

		protected override void SendValuesToShader()
		{
			material.SetFloat(variableIntensity, intensity);
			material.SetInt(variableSteps, steps);
		}
	}
}
