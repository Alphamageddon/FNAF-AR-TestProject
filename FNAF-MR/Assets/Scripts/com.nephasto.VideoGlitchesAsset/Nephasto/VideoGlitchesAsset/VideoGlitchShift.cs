using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Nephasto/Video Glitches/Video Glitch Shift")]
	public sealed class VideoGlitchShift : VideoGlitchBase
	{
		[SerializeField]
		private float amplitude = 0.5f;

		[SerializeField]
		private float speed = 0.25f;

		private Texture noiseTex;

		private static readonly int variableNoise = Shader.PropertyToID("_NoiseTex");

		private static readonly int variableAmplitude = Shader.PropertyToID("_Amplitude");

		private static readonly int variableSpeed = Shader.PropertyToID("_Speed");

		[RangeFloat(0f, 1f, 0.5f)]
		public float Amplitude
		{
			get
			{
				return amplitude;
			}
			set
			{
				amplitude = ((value < 0f) ? 0f : value);
			}
		}

		[RangeFloat(0f, 1f, 0.25f)]
		public float Speed
		{
			get
			{
				return speed;
			}
			set
			{
				speed = ((value < 0f) ? 0f : value);
			}
		}

		public override string ToString()
		{
			return "Color channels shift.";
		}

		protected override void LoadCustomResources()
		{
			noiseTex = LoadTextureFromResources("Textures/Noise256");
		}

		public override void ResetDefaultValues()
		{
			amplitude = 0.5f;
			speed = 0.25f;
			base.ResetDefaultValues();
		}

		public override void RandomValues()
		{
			amplitude = Random.Range(0.25f, 0.75f);
			speed = Random.Range(0.1f, 0.3f);
		}

		protected override void SendValuesToShader()
		{
			material.SetFloat(variableAmplitude, amplitude);
			material.SetFloat(variableSpeed, speed * 0.1f);
			material.SetTexture(variableNoise, noiseTex);
		}
	}
}
