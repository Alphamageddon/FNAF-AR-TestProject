using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Nephasto/Video Glitches/Video Glitch Noise Digital")]
	public sealed class VideoGlitchNoiseDigital : VideoGlitchBase
	{
		[SerializeField]
		private float threshold = 0.1f;

		[SerializeField]
		private float maxOffset = 0.1f;

		[SerializeField]
		private float thresholdYUV = 0.5f;

		private static readonly int variableThreshold = Shader.PropertyToID("_Threshold");

		private static readonly int variableMaxOffset = Shader.PropertyToID("_MaxOffset");

		private static readonly int variableThresholdYUV = Shader.PropertyToID("_ThresholdYUV");

		[RangeFloat(0f, 1f, 0.1f)]
		public float Threshold
		{
			get
			{
				return threshold;
			}
			set
			{
				threshold = Mathf.Clamp01(value);
			}
		}

		[RangeFloat(0f, 1f, 0.1f)]
		public float MaxOffset
		{
			get
			{
				return maxOffset;
			}
			set
			{
				maxOffset = Mathf.Clamp01(value);
			}
		}

		[RangeFloat(0f, 1f, 0.5f)]
		public float ThresholdYUV
		{
			get
			{
				return thresholdYUV;
			}
			set
			{
				thresholdYUV = Mathf.Clamp01(value);
			}
		}

		public override string ToString()
		{
			return "Digital noise.";
		}

		public override void ResetDefaultValues()
		{
			threshold = 0.1f;
			maxOffset = 0.1f;
			thresholdYUV = 0.5f;
			base.ResetDefaultValues();
		}

		public override void RandomValues()
		{
			threshold = Random.Range(0.1f, 0.4f);
			maxOffset = Random.Range(0.1f, 0.4f);
			thresholdYUV = Random.Range(0.3f, 0.7f);
		}

		protected override void SendValuesToShader()
		{
			material.SetFloat(variableThreshold, threshold);
			material.SetFloat(variableMaxOffset, maxOffset);
			material.SetFloat(variableThresholdYUV, thresholdYUV);
		}
	}
}
