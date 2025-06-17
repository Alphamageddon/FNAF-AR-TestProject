using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Nephasto/Video Glitches/Video Glitch Old Tape")]
	public sealed class VideoGlitchOldTape : VideoGlitchBase
	{
		[SerializeField]
		private float noiseSpeed = 0.25f;

		[SerializeField]
		private float noiseAmplitude = 1f;

		private static readonly int variableNoiseSpeed = Shader.PropertyToID("_NoiseSpeed");

		private static readonly int variableNoiseAmplitude = Shader.PropertyToID("_NoiseAmplitude");

		[RangeFloat(0f, 1f, 0.25f)]
		public float Speed
		{
			get
			{
				return noiseSpeed;
			}
			set
			{
				noiseSpeed = ((value < 0f) ? 0f : value);
			}
		}

		[RangeFloat(1f, 100f, 1f)]
		public float Amplitude
		{
			get
			{
				return noiseAmplitude;
			}
			set
			{
				noiseAmplitude = ((value < 1f) ? 1f : value);
			}
		}

		public override string ToString()
		{
			return "Old video tape.";
		}

		public override void ResetDefaultValues()
		{
			noiseSpeed = 0.25f;
			noiseAmplitude = 1f;
			base.ResetDefaultValues();
		}

		public override void RandomValues()
		{
			noiseSpeed = Random.Range(0.1f, 0.5f);
			noiseAmplitude = Random.Range(1f, 20f);
		}

		protected override void SendValuesToShader()
		{
			material.SetFloat(variableNoiseSpeed, noiseSpeed * 0.0001f);
			material.SetFloat(variableNoiseAmplitude, (101f - noiseAmplitude) * 1000f);
		}
	}
}
