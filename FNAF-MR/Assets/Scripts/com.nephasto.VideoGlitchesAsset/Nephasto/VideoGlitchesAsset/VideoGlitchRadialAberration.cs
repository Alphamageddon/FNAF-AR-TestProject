using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Nephasto/Video Glitches/Video Glitch Radial Aberration")]
	public sealed class VideoGlitchRadialAberration : VideoGlitchBase
	{
		[SerializeField]
		private Vector2 focus = new Vector2(0.5f, 0.5f);

		[SerializeField]
		private int samples = 15;

		[SerializeField]
		private float blur = 0.25f;

		[SerializeField]
		private float falloff = 3f;

		private static readonly int variableFocus = Shader.PropertyToID("_Focus");

		private static readonly int variableSamples = Shader.PropertyToID("_Samples");

		private static readonly int variableBlur = Shader.PropertyToID("_Blur");

		private static readonly int variableFalloff = Shader.PropertyToID("_Falloff");

		[RangeVector2(0f, 1f, 0.5f)]
		public Vector2 Focus
		{
			get
			{
				return focus;
			}
			set
			{
				focus = value;
			}
		}

		[RangeInt(1, 32, 15)]
		public int Samples
		{
			get
			{
				return samples;
			}
			set
			{
				samples = ((value < 1) ? 1 : value);
			}
		}

		[RangeFloat(0f, 1f, 0.25f)]
		public float Blur
		{
			get
			{
				return blur;
			}
			set
			{
				blur = Mathf.Clamp01(value);
			}
		}

		[RangeFloat(0f, 5f, 3f)]
		public float Falloff
		{
			get
			{
				return falloff;
			}
			set
			{
				falloff = Mathf.Clamp(value, 0f, 5f);
			}
		}

		public override string ToString()
		{
			return "Radial color aberration.";
		}

		public override void ResetDefaultValues()
		{
			focus = new Vector2(0.5f, 0.5f);
			samples = 15;
			blur = 0.25f;
			falloff = 3f;
			base.ResetDefaultValues();
		}

		public override void RandomValues()
		{
			focus = new Vector2(0.5f, 0.5f) + Random.insideUnitCircle * 0.1f;
			blur = Random.Range(0.1f, 0.3f);
			falloff = Random.Range(2f, 4f);
		}

		protected override void SendValuesToShader()
		{
			material.SetVector(variableFocus, focus);
			material.SetInt(variableSamples, samples);
			material.SetFloat(variableBlur, blur);
			material.SetFloat(variableFalloff, falloff);
		}
	}
}
