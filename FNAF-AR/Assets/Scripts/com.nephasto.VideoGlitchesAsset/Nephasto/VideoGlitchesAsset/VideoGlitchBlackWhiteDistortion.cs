using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Nephasto/Video Glitches/Video Glitch Black and White Distortion")]
	public sealed class VideoGlitchBlackWhiteDistortion : VideoGlitchBase
	{
		[SerializeField]
		private float distortionSteps = 2f;

		[SerializeField]
		private float distortionAmountMinLimit = 340f;

		[SerializeField]
		private float distortionAmountMaxLimit = 360f;

		[SerializeField]
		private float distortionSpeed = 1f;

		[SerializeField]
		private float distortionAmount = 340f;

		private static readonly int variableDistortionSteps = Shader.PropertyToID("_DistortionSteps");

		private static readonly int variableDistortionAmount = Shader.PropertyToID("_DistortionAmount");

		[RangeFloat(1f, 10f, 2f)]
		public float Steps
		{
			get
			{
				return distortionSteps;
			}
			set
			{
				distortionSteps = Mathf.Clamp(value, 1f, 10f);
			}
		}

		[RangeFloat(0f, 360f, 340f)]
		public float MinLimit
		{
			get
			{
				return distortionAmountMinLimit;
			}
			set
			{
				distortionAmountMinLimit = Mathf.Clamp(value, 0f, 360f);
			}
		}

		[RangeFloat(0f, 360f, 360f)]
		public float MaxLimit
		{
			get
			{
				return distortionAmountMaxLimit;
			}
			set
			{
				distortionAmountMaxLimit = Mathf.Clamp(value, 0f, 360f);
			}
		}

		[RangeFloat(0f, 10f, 1f)]
		public float Speed
		{
			get
			{
				return distortionSpeed;
			}
			set
			{
				distortionSpeed = Mathf.Clamp(value, 0f, 10f);
			}
		}

		public override string ToString()
		{
			return "Black and white with analog distortion.";
		}

		public override void ResetDefaultValues()
		{
			distortionSteps = 2f;
			distortionAmountMinLimit = 340f;
			distortionAmountMaxLimit = 360f;
			distortionSpeed = 1f;
			distortionAmount = distortionAmountMinLimit;
			base.ResetDefaultValues();
		}

		public override void RandomValues()
		{
			distortionSteps = Random.Range(1f, 2f);
			distortionAmountMinLimit = Random.Range(0f, 360f);
			distortionAmountMaxLimit = Random.Range(0f, 360f);
			distortionSpeed = Random.Range(0.1f, 1f);
			distortionAmount = distortionAmountMinLimit;
		}

		protected override void SendValuesToShader()
		{
			material.SetFloat(variableDistortionSteps, distortionSteps);
			if (distortionAmount > distortionAmountMaxLimit)
			{
				distortionAmount = distortionAmountMinLimit;
			}
			if (distortionAmount < distortionAmountMinLimit)
			{
				distortionAmount = distortionAmountMaxLimit;
			}
			if (distortionSpeed > 0f)
			{
				distortionAmount += Time.deltaTime * distortionSpeed;
			}
			material.SetFloat(variableDistortionAmount, distortionAmount);
		}
	}
}
