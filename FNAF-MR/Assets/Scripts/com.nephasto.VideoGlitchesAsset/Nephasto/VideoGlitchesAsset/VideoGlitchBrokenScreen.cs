using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Nephasto/Video Glitches/Video Glitch Broken Screen")]
	public sealed class VideoGlitchBrokenScreen : VideoGlitchBase
	{
		[SerializeField]
		private Vector2 impact = Vector2.zero;

		[SerializeField]
		private int splits = 25;

		[SerializeField]
		private float splitThreshold = 1f;

		[SerializeField]
		private Color splitColor = Color.gray;

		[SerializeField]
		private float distortion = 0.2f;

		private static readonly int variableCenter = Shader.PropertyToID("_Center");

		private static readonly int variableSplits = Shader.PropertyToID("_Splits");

		private static readonly int variableSplitThreshold = Shader.PropertyToID("_SplitThreshold");

		private static readonly int variableSplitColor = Shader.PropertyToID("_SplitColor");

		private static readonly int variableDistortion = Shader.PropertyToID("_Distortion");

		[RangeVector2(-1f, 1f, 0f)]
		public Vector2 Impact
		{
			get
			{
				return impact;
			}
			set
			{
				impact = Vector2.ClampMagnitude(value, 1f);
			}
		}

		[RangeInt(2, 100, 25)]
		public int Splits
		{
			get
			{
				return splits;
			}
			set
			{
				splits = ((value < 2) ? 2 : value);
			}
		}

		[RangeFloat(0f, 1f, 0.75f)]
		public float Threshold
		{
			get
			{
				return splitThreshold;
			}
			set
			{
				splitThreshold = Mathf.Clamp01(value);
			}
		}

		public Color Color
		{
			get
			{
				return splitColor;
			}
			set
			{
				splitColor = value;
			}
		}

		[RangeFloat(0f, 1f, 0.2f)]
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

		public override string ToString()
		{
			return "Broken screen (simulated).";
		}

		public override void ResetDefaultValues()
		{
			impact = Vector2.zero;
			splits = 25;
			splitThreshold = 1f;
			splitColor = Color.gray;
			distortion = 0.2f;
			base.ResetDefaultValues();
		}

		public override void RandomValues()
		{
			impact = Random.insideUnitCircle * 0.25f;
			splits = RandomRange(splits, 10, 50);
			splitThreshold = Random.Range(0.8f, 1f);
			distortion = Random.Range(0.1f, 0.4f);
		}

		protected override void SendValuesToShader()
		{
			material.SetVector(variableCenter, impact);
			material.SetInt(variableSplits, splits);
			material.SetFloat(variableSplitThreshold, splitThreshold);
			material.SetColor(variableSplitColor, splitColor);
			material.SetFloat(variableDistortion, distortion * 0.1f);
		}
	}
}
