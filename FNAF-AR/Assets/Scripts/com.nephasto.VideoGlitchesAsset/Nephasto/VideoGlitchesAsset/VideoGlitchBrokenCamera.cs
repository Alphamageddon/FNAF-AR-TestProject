using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Nephasto/Video Glitches/Video Glitch Broken Camera")]
	public sealed class VideoGlitchBrokenCamera : VideoGlitchBase
	{
		[SerializeField]
		private float malfunction = 0.9f;

		[SerializeField]
		private float noise = 0.5f;

		[SerializeField]
		private float distortionIntensity = 0.3f;

		[SerializeField]
		private float distortionSpeed = 0.1f;

		private static readonly int variableMalfunction = Shader.PropertyToID("_Malfunction");

		private static readonly int variableNoise = Shader.PropertyToID("_Noise");

		private static readonly int variableDistortionIntensity = Shader.PropertyToID("_DistortionIntensity");

		private static readonly int variableDistortionSpeed = Shader.PropertyToID("_DistortionSpeed");

		[RangeFloat(0f, 1f, 0.9f)]
		public float Malfunction
		{
			get
			{
				return malfunction;
			}
			set
			{
				malfunction = Mathf.Clamp01(value);
			}
		}

		[RangeFloat(0f, 1f, 0.5f)]
		public float Noise
		{
			get
			{
				return noise;
			}
			set
			{
				noise = ((value < 0f) ? 0f : value);
			}
		}

		[RangeFloat(0f, 1f, 0.3f)]
		public float DistortionIntensity
		{
			get
			{
				return distortionIntensity;
			}
			set
			{
				distortionIntensity = ((value < 0f) ? 0f : value);
			}
		}

		[RangeFloat(0f, 1f, 0.1f)]
		public float DistortionSpeed
		{
			get
			{
				return distortionSpeed;
			}
			set
			{
				distortionSpeed = ((value < 0f) ? 0f : value);
			}
		}

		public override string ToString()
		{
			return "Broken camera.";
		}

		public override void ResetDefaultValues()
		{
			malfunction = 0.9f;
			noise = 0.5f;
			distortionIntensity = 0.3f;
			distortionSpeed = 0.1f;
			base.ResetDefaultValues();
		}

		public override void RandomValues()
		{
			malfunction = Random.Range(0.5f, 0.75f);
			noise = Random.Range(0.25f, 0.75f);
			distortionIntensity = Random.Range(0.1f, 0.4f);
			distortionSpeed = Random.Range(0f, 1f);
		}

		protected override void SendValuesToShader()
		{
			material.SetFloat(variableMalfunction, malfunction * 2f - 1f);
			material.SetFloat(variableNoise, noise * 0.025f);
			material.SetFloat(variableDistortionIntensity, distortionIntensity * 0.1f);
			material.SetFloat(variableDistortionSpeed, distortionSpeed * 0.1f);
		}
	}
}
