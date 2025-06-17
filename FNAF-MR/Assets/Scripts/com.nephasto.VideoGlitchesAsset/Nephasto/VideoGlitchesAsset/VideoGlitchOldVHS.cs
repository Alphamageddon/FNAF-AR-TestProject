using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Nephasto/Video Glitches/Video Glitch Old VHS")]
	public sealed class VideoGlitchOldVHS : VideoGlitchBase
	{
		[SerializeField]
		private float waving = 0.5f;

		[SerializeField]
		private float noise = 0.25f;

		[SerializeField]
		private float stripeCount = 8f;

		[SerializeField]
		private float stripeVelocity = 1.2f;

		[SerializeField]
		private float stripeStrength = 1f;

		[SerializeField]
		private float stripeNoise = 0.5f;

		[SerializeField]
		private float switchingNoise = 0.5f;

		[SerializeField]
		private float acBeatWidth = 0.6f;

		[SerializeField]
		private float acBeatVelocity = 0.2f;

		[SerializeField]
		private float bloomPasses = 5f;

		private static readonly int variableWaving = Shader.PropertyToID("_Waving");

		private static readonly int variableNoise = Shader.PropertyToID("_Noise");

		private static readonly int variableStripeCount = Shader.PropertyToID("_StripeCount");

		private static readonly int variableStripeVelocity = Shader.PropertyToID("_StripeVelocity");

		private static readonly int variableStripeStrength = Shader.PropertyToID("_StripeStrength");

		private static readonly int variableStripeNoise = Shader.PropertyToID("_StripeNoise");

		private static readonly int variableSwitchingNoise = Shader.PropertyToID("_SwitchingNoise");

		private static readonly int variableACBeatWidth = Shader.PropertyToID("_ACBeatWidth");

		private static readonly int variableACBeatVelocity = Shader.PropertyToID("_ACBeatVelocity");

		private static readonly int variableBloomPasses = Shader.PropertyToID("_BloomPasses");

		[RangeFloat(0f, 1f, 0.5f)]
		public float Waving
		{
			get
			{
				return waving;
			}
			set
			{
				waving = Mathf.Clamp01(value);
			}
		}

		[RangeFloat(0f, 1f, 0.25f)]
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

		[RangeFloat(0f, 32f, 8f)]
		public float StripeCount
		{
			get
			{
				return stripeCount;
			}
			set
			{
				stripeCount = ((value < 0f) ? 0f : value);
			}
		}

		[RangeFloat(-10f, 10f, 1.2f)]
		public float StripeVelocity
		{
			get
			{
				return stripeVelocity;
			}
			set
			{
				stripeVelocity = Mathf.Clamp(value, -10f, 10f);
			}
		}

		[RangeFloat(0f, 1f, 1f)]
		public float StripeStrength
		{
			get
			{
				return stripeStrength;
			}
			set
			{
				stripeStrength = Mathf.Clamp01(value);
			}
		}

		[RangeFloat(0f, 1f, 0.5f)]
		public float StripeNoise
		{
			get
			{
				return stripeNoise;
			}
			set
			{
				stripeNoise = Mathf.Clamp01(value);
			}
		}

		[RangeFloat(0f, 1f, 0.5f)]
		public float SwitchingNoise
		{
			get
			{
				return switchingNoise;
			}
			set
			{
				switchingNoise = Mathf.Clamp01(value);
			}
		}

		[RangeFloat(0f, 1f, 0.6f)]
		public float ACBeatWidth
		{
			get
			{
				return acBeatWidth;
			}
			set
			{
				acBeatWidth = Mathf.Clamp01(value);
			}
		}

		[RangeFloat(-10f, 10f, 0.2f)]
		public float ACBeatVelocity
		{
			get
			{
				return acBeatVelocity;
			}
			set
			{
				acBeatVelocity = Mathf.Clamp(value, -10f, 10f);
			}
		}

		[RangeFloat(0f, 10f, 5f)]
		public float BloomPasses
		{
			get
			{
				return bloomPasses;
			}
			set
			{
				bloomPasses = Mathf.Clamp(value, 0f, 10f);
			}
		}

		public override string ToString()
		{
			return "Old broken VHS recorder.";
		}

		public override void ResetDefaultValues()
		{
			waving = 0.5f;
			noise = 0.25f;
			stripeCount = 2f;
			stripeVelocity = 1.2f;
			stripeStrength = 1f;
			stripeNoise = 0.5f;
			switchingNoise = 0.5f;
			acBeatWidth = 0.6f;
			acBeatVelocity = 0.2f;
			bloomPasses = 5f;
			base.ResetDefaultValues();
		}

		public override void RandomValues()
		{
			waving = Random.Range(0.25f, 0.75f);
			noise = Random.Range(0f, 0.5f);
			stripeCount = Random.Range(4f, 16f);
			stripeVelocity = Random.Range(-1.2f, 1.2f);
			stripeStrength = Random.Range(0.75f, 1f);
			stripeNoise = Random.Range(0.25f, 0.75f);
			switchingNoise = Random.Range(0.25f, 0.75f);
			acBeatWidth = Random.Range(0.3f, 0.9f);
			acBeatVelocity = Random.Range(-1f, 1f);
			bloomPasses = Random.Range(2f, 8f);
		}

		protected override void SendValuesToShader()
		{
			material.SetFloat(variableWaving, waving);
			material.SetFloat(variableNoise, noise);
			material.SetFloat(variableStripeCount, Mathf.Floor(stripeCount) * 6f);
			material.SetFloat(variableStripeVelocity, stripeVelocity);
			material.SetFloat(variableStripeStrength, stripeStrength * 10f);
			material.SetFloat(variableStripeNoise, stripeNoise * 500f);
			material.SetFloat(variableSwitchingNoise, switchingNoise);
			material.SetFloat(variableACBeatWidth, acBeatWidth);
			material.SetFloat(variableACBeatVelocity, acBeatVelocity);
			material.SetFloat(variableBloomPasses, bloomPasses);
		}
	}
}
