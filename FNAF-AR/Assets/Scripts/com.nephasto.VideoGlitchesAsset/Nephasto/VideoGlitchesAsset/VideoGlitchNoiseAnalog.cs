using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Nephasto/Video Glitches/Video Glitch Noise Analog")]
	public sealed class VideoGlitchNoiseAnalog : VideoGlitchBase
	{
		[SerializeField]
		private float stripesSize = 0.25f;

		[SerializeField]
		private int barsCount = 10;

		[SerializeField]
		private float distortion = 0.25f;

		[SerializeField]
		private float noiseIntensity = 0.2f;

		private static readonly int variableStripesSize = Shader.PropertyToID("_StripesSize");

		private static readonly int variableBarsCount = Shader.PropertyToID("_BarsCount");

		private static readonly int variableDistortion = Shader.PropertyToID("_Distortion");

		private static readonly int variableNoiseIntensity = Shader.PropertyToID("_NoiseIntensity");

		[RangeFloat(0f, 1f, 0.25f)]
		public float StripesSize
		{
			get
			{
				return stripesSize;
			}
			set
			{
				stripesSize = Mathf.Clamp01(value);
			}
		}

		[RangeInt(0, 100, 10)]
		public int BarsCount
		{
			get
			{
				return barsCount;
			}
			set
			{
				barsCount = ((value >= 0) ? value : 0);
			}
		}

		[RangeFloat(0f, 1f, 0.25f)]
		public float Distortion
		{
			get
			{
				return distortion;
			}
			set
			{
				distortion = Mathf.Clamp01(value);
			}
		}

		[RangeFloat(0f, 1f, 0.2f)]
		public float Noise
		{
			get
			{
				return noiseIntensity;
			}
			set
			{
				noiseIntensity = Mathf.Clamp01(value);
			}
		}

		public override string ToString()
		{
			return "Analog noise.";
		}

		public override void ResetDefaultValues()
		{
			stripesSize = 0.25f;
			barsCount = 10;
			distortion = 0.1f;
			noiseIntensity = 0.2f;
			base.ResetDefaultValues();
		}

		public override void RandomValues()
		{
			stripesSize = Random.Range(0.1f, 0.4f);
			barsCount = RandomRange(barsCount, 5, 25);
			distortion = Random.Range(0.1f, 0.5f);
			noiseIntensity = Random.Range(0.1f, 0.5f);
		}

		protected override void SendValuesToShader()
		{
			material.SetFloat(variableStripesSize, stripesSize);
			material.SetFloat(variableBarsCount, (float)barsCount * 1f);
			material.SetFloat(variableDistortion, distortion);
			material.SetFloat(variableNoiseIntensity, noiseIntensity * 0.05f);
		}
	}
}
