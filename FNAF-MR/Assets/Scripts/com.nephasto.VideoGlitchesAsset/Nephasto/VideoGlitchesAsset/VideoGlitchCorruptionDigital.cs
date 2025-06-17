using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Nephasto/Video Glitches/Video Glitch Corruption Digital")]
	public sealed class VideoGlitchCorruptionDigital : VideoGlitchBase
	{
		[SerializeField]
		private float speed = 1f;

		[SerializeField]
		private float intensity = 0.6f;

		[SerializeField]
		private float posterize = 0.25f;

		[SerializeField]
		private int tileSize = 128;

		private static readonly int variableSpeed = Shader.PropertyToID("_Speed");

		private static readonly int variableIntensity = Shader.PropertyToID("_Intensity");

		private static readonly int variableTileSize = Shader.PropertyToID("_TileSize");

		private static readonly int variablePosterize = Shader.PropertyToID("_Posterize");

		[RangeFloat(0f, 10f, 1f)]
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

		[RangeFloat(0f, 1f, 0.6f)]
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

		[RangeFloat(0f, 1f, 0.5f)]
		public float Posterize
		{
			get
			{
				return posterize;
			}
			set
			{
				posterize = Mathf.Clamp01(value);
			}
		}

		[RangeInt(1, 256, 128)]
		public int TileSize
		{
			get
			{
				return tileSize;
			}
			set
			{
				tileSize = ((value < 1) ? 1 : value);
			}
		}

		public override string ToString()
		{
			return "Digital signal corruption.";
		}

		public override void ResetDefaultValues()
		{
			speed = 1f;
			intensity = 0.6f;
			tileSize = 128;
			posterize = 0.25f;
			base.ResetDefaultValues();
		}

		public override void RandomValues()
		{
			speed = Random.Range(0.1f, 1f);
			intensity = Random.Range(0.1f, 0.6f);
			tileSize = RandomRange(tileSize, 32, 128);
			posterize = Random.Range(0.1f, 0.5f);
		}

		protected override void SendValuesToShader()
		{
			material.SetFloat(variableSpeed, speed);
			material.SetFloat(variableIntensity, intensity);
			material.SetFloat(variableTileSize, tileSize);
			material.SetFloat(variablePosterize, 1f - posterize);
		}
	}
}
