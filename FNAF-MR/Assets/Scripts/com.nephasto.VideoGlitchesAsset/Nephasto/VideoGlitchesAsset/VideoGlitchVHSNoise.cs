using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Nephasto/Video Glitches/Video Glitch VHS Noise")]
	public sealed class VideoGlitchVHSNoise : VideoGlitchBase
	{
		[SerializeField]
		private float speed = 2f;

		[SerializeField]
		private float intensity = 0.3f;

		[SerializeField]
		private float size = 0.25f;

		[SerializeField]
		private Color color = Color.white;

		private static readonly int variableSpeed = Shader.PropertyToID("_Speed");

		private static readonly int variableIntensity = Shader.PropertyToID("_Intensity");

		private static readonly int variableSize = Shader.PropertyToID("_Size");

		private static readonly int variableColor = Shader.PropertyToID("_Color");

		[RangeFloat(-10f, 10f, 2f)]
		public float Speed
		{
			get
			{
				return speed;
			}
			set
			{
				speed = value;
			}
		}

		[RangeFloat(0f, 1f, 0.3f)]
		public float Intensity
		{
			get
			{
				return intensity;
			}
			set
			{
				intensity = ((value < 0f) ? 0f : value);
			}
		}

		[RangeFloat(0f, 1f, 0.25f)]
		public float Size
		{
			get
			{
				return size;
			}
			set
			{
				size = ((value < 0f) ? 0f : value);
			}
		}

		public Color Color
		{
			get
			{
				return color;
			}
			set
			{
				color = value;
			}
		}

		public override string ToString()
		{
			return "VHS noise.";
		}

		public override void ResetDefaultValues()
		{
			speed = Random.Range(-2f, 2f);
			intensity = Random.Range(0.1f, 0.5f);
			size = Random.Range(0.1f, 0.5f);
			base.ResetDefaultValues();
		}

		public override void RandomValues()
		{
			speed = 2f;
			intensity = 0.3f;
			size = 0.25f;
		}

		protected override void SendValuesToShader()
		{
			material.SetFloat(variableSpeed, speed);
			material.SetFloat(variableIntensity, intensity);
			material.SetFloat(variableSize, size * 1000f);
			material.SetColor(variableColor, color);
		}
	}
}
