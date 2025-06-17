using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Nephasto/Video Glitches/Video Glitch Lens distortion")]
	public sealed class VideoGlitchLensDistortion : VideoGlitchBase
	{
		[SerializeField]
		private Vector2 center = Vector2.zero;

		[SerializeField]
		private float size = 0.7f;

		[SerializeField]
		private float dispersion = 0.7f;

		[SerializeField]
		private float vignette = 0.2f;

		[SerializeField]
		private Vector3 radialDistortion = RadialDistortionDefault;

		public static Vector3 RadialDistortionDefault = new Vector3(1.2f, 1f, -3.2f);

		private static readonly int variableCenter = Shader.PropertyToID("_Center");

		private static readonly int variableSize = Shader.PropertyToID("_Size");

		private static readonly int variableDispersion = Shader.PropertyToID("_Dispersion");

		private static readonly int variableVignette = Shader.PropertyToID("_Vignette");

		private static readonly int variableRadialDistortion = Shader.PropertyToID("_RadialDistortion");

		[RangeVector2(-0.5f, 0.5f, 0f)]
		public Vector2 Center
		{
			get
			{
				return center;
			}
			set
			{
				center = Vector2.ClampMagnitude(value, 0.5f);
			}
		}

		[RangeFloat(0f, 1f, 0.7f)]
		public float Size
		{
			get
			{
				return size;
			}
			set
			{
				size = Mathf.Max(0f, value);
			}
		}

		[RangeFloat(0f, 1f, 0.3f)]
		public float Dispersion
		{
			get
			{
				return dispersion;
			}
			set
			{
				dispersion = Mathf.Max(0f, value);
			}
		}

		[RangeFloat(0f, 1f, 0.2f)]
		public float Vignette
		{
			get
			{
				return vignette;
			}
			set
			{
				vignette = Mathf.Max(0f, value);
			}
		}

		[RangeVector3(1.2f, 1f, -3.2f)]
		public Vector3 RadialDistorion
		{
			get
			{
				return radialDistortion;
			}
			set
			{
				radialDistortion = value;
			}
		}

		public override string ToString()
		{
			return "Lens distortion simulation.";
		}

		public override void ResetDefaultValues()
		{
			center = Vector2.zero;
			size = 0.7f;
			dispersion = 0.3f;
			vignette = 0.2f;
			radialDistortion = RadialDistortionDefault;
			base.ResetDefaultValues();
		}

		public override void RandomValues()
		{
			center = Random.insideUnitCircle * 0.2f;
			size = Random.Range(0.5f, 0.7f);
			dispersion = Random.Range(0.2f, 0.4f);
			vignette = Random.Range(0.1f, 0.4f);
			radialDistortion = RadialDistortionDefault * Random.Range(0.9f, 1.1f);
		}

		protected override void SendValuesToShader()
		{
			material.SetVector(variableCenter, center);
			material.SetFloat(variableSize, 0.7f - size);
			material.SetFloat(variableDispersion, dispersion * 0.1f);
			material.SetFloat(variableVignette, vignette + 0.01f);
			material.SetVector(variableRadialDistortion, radialDistortion);
		}
	}
}
