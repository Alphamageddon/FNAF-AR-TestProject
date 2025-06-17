using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Nephasto/Video Glitches/Video Glitch Old TV")]
	public sealed class VideoGlitchOldTV : VideoGlitchBase
	{
		[SerializeField]
		private float slowScan = 0.01f;

		[SerializeField]
		private float scanLine = 0.6f;

		[SerializeField]
		private float vignetteSoftness = 0.9f;

		[SerializeField]
		private float vignetteScale = 0.14f;

		[SerializeField]
		private float vignetteTubeScale = 0.7f;

		[SerializeField]
		private float grainOpacity = 5f;

		[SerializeField]
		private float grainSaturation;

		[SerializeField]
		private float scanDistort = 0.03f;

		[SerializeField]
		private float timer = 0.85f;

		[SerializeField]
		private float speed = 2f;

		[SerializeField]
		private float crtDistort = 0.03f;

		[SerializeField]
		private float crtScale = 1.06f;

		[SerializeField]
		private float stripesCount = 0.5f;

		[SerializeField]
		private float stripesOpacity = 1f;

		[SerializeField]
		private float barsCount = 5f;

		[SerializeField]
		private float moireOpacity = 1f;

		[SerializeField]
		private float moireScale = 0.15f;

		[SerializeField]
		private float tvLines = 2.5f;

		[SerializeField]
		private float tvLinesOpacity = 1f;

		[SerializeField]
		private float tvDots = 1f;

		[SerializeField]
		private float tvDotsBlend = 1f;

		private static readonly int variableScanline = Shader.PropertyToID("_Scanline");

		private static readonly int variableSlowscan = Shader.PropertyToID("_Slowscan");

		private static readonly int variableVignetteSoftness = Shader.PropertyToID("_VignetteSoftness");

		private static readonly int variableVignetteScale = Shader.PropertyToID("_VignetteScale");

		private static readonly int variableGrainOpacity = Shader.PropertyToID("_GrainOpacity");

		private static readonly int variableSaturation = Shader.PropertyToID("_SaturationTV");

		private static readonly int variableScanDistort = Shader.PropertyToID("_ScanDistort");

		private static readonly int variableTimer = Shader.PropertyToID("_Timer");

		private static readonly int variableSpeed = Shader.PropertyToID("_Speed");

		private static readonly int variableDistort = Shader.PropertyToID("_Distort");

		private static readonly int variableScale = Shader.PropertyToID("_Scale");

		private static readonly int variableStripesCount = Shader.PropertyToID("_StripesCount");

		private static readonly int variableOpacity = Shader.PropertyToID("_Opacity");

		private static readonly int variableBarsCount = Shader.PropertyToID("_BarsCount");

		private static readonly int variableOpacityMoire = Shader.PropertyToID("_OpacityMoire");

		private static readonly int variableMoireScale = Shader.PropertyToID("_MoireScale");

		private static readonly int variableTVLines = Shader.PropertyToID("_TVLines");

		private static readonly int variableTVLinesOpacity = Shader.PropertyToID("_TVLinesOpacity");

		private static readonly int variableTVTubeVignetteScale = Shader.PropertyToID("_TVTubeVignetteScale");

		private static readonly int variableTVDots = Shader.PropertyToID("_TVDots");

		private static readonly int variableTVDotsBlend = Shader.PropertyToID("_TVDotsBlend");

		[RangeFloat(0f, 1f, 0.01f)]
		public float SlowScan
		{
			get
			{
				return slowScan;
			}
			set
			{
				slowScan = Mathf.Clamp01(value);
			}
		}

		[RangeFloat(0f, 2f, 0.6f)]
		public float ScanLine
		{
			get
			{
				return scanLine;
			}
			set
			{
				scanLine = Mathf.Clamp(value, 0f, 2f);
			}
		}

		[RangeFloat(0f, 1f, 0.9f)]
		public float VignetteSoftness
		{
			get
			{
				return vignetteSoftness;
			}
			set
			{
				vignetteSoftness = Mathf.Clamp01(value);
			}
		}

		[RangeFloat(0f, 1f, 0.14f)]
		public float VignetteScale
		{
			get
			{
				return vignetteScale;
			}
			set
			{
				vignetteScale = Mathf.Clamp01(value);
			}
		}

		[RangeFloat(0.01f, 10f, 0.7f)]
		public float VignetteTubeScale
		{
			get
			{
				return vignetteTubeScale;
			}
			set
			{
				vignetteTubeScale = Mathf.Clamp(value, 0.01f, 10f);
			}
		}

		[RangeFloat(0f, 100f, 5f)]
		public float GrainOpacity
		{
			get
			{
				return grainOpacity;
			}
			set
			{
				grainOpacity = Mathf.Clamp(value, 0f, 100f);
			}
		}

		[RangeFloat(0f, 1f, 0f)]
		public float GrainSaturation
		{
			get
			{
				return grainSaturation;
			}
			set
			{
				grainSaturation = Mathf.Clamp01(value);
			}
		}

		[RangeFloat(0f, 10f, 0.03f)]
		public float ScanDistort
		{
			get
			{
				return scanDistort;
			}
			set
			{
				scanDistort = Mathf.Clamp(value, 0f, 10f);
			}
		}

		[RangeFloat(0f, 5f, 0.85f)]
		public float Timer
		{
			get
			{
				return timer;
			}
			set
			{
				timer = Mathf.Clamp(value, 0f, 5f);
			}
		}

		[RangeFloat(1f, 5f, 2f)]
		public float Speed
		{
			get
			{
				return speed;
			}
			set
			{
				speed = Mathf.Clamp(value, 1f, 5f);
			}
		}

		[RangeFloat(0f, 5f, 0.03f)]
		public float CRTDistort
		{
			get
			{
				return crtDistort;
			}
			set
			{
				crtDistort = Mathf.Clamp(value, 0f, 5f);
			}
		}

		[RangeFloat(1f, 10f, 1.06f)]
		public float CRTScale
		{
			get
			{
				return crtScale;
			}
			set
			{
				crtScale = Mathf.Clamp(value, 1f, 10f);
			}
		}

		[RangeFloat(0f, 1000f, 0.5f)]
		public float StripesCount
		{
			get
			{
				return stripesCount;
			}
			set
			{
				stripesCount = Mathf.Clamp(value, 0f, 1000f);
			}
		}

		[RangeFloat(0f, 10f, 1f)]
		public float StripesOpacity
		{
			get
			{
				return stripesOpacity;
			}
			set
			{
				stripesOpacity = Mathf.Clamp(value, 0f, 10f);
			}
		}

		[RangeFloat(0f, 1000f, 5f)]
		public float BarsCount
		{
			get
			{
				return barsCount;
			}
			set
			{
				barsCount = Mathf.Clamp(value, 0f, 1000f);
			}
		}

		[RangeFloat(0f, 100f, 1f)]
		public float MoireOpacity
		{
			get
			{
				return moireOpacity;
			}
			set
			{
				moireOpacity = Mathf.Clamp(value, 0f, 100f);
			}
		}

		[RangeFloat(0.01f, 100f, 0.15f)]
		public float MoireScale
		{
			get
			{
				return moireScale;
			}
			set
			{
				moireScale = Mathf.Clamp(value, 0.01f, 100f);
			}
		}

		[RangeFloat(0.01f, 10f, 2.5f)]
		public float TVLines
		{
			get
			{
				return tvLines;
			}
			set
			{
				tvLines = Mathf.Clamp(value, 0.01f, 10f);
			}
		}

		[RangeFloat(0f, 10f, 1f)]
		public float TVLinesOpacity
		{
			get
			{
				return tvLinesOpacity;
			}
			set
			{
				tvLinesOpacity = Mathf.Clamp(value, 0f, 10f);
			}
		}

		[RangeFloat(0f, 4f, 1f)]
		public float TVDots
		{
			get
			{
				return tvDots;
			}
			set
			{
				tvDots = Mathf.Clamp(value, 0f, 4f);
			}
		}

		[RangeFloat(0f, 1000f, 1f)]
		public float TVDotsBlend
		{
			get
			{
				return tvDotsBlend;
			}
			set
			{
				tvDotsBlend = Mathf.Clamp(value, 0f, 1000f);
			}
		}

		public override string ToString()
		{
			return "Old broken TV.";
		}

		public override void ResetDefaultValues()
		{
			slowScan = 0.01f;
			scanLine = 0.6f;
			vignetteSoftness = 0.9f;
			vignetteScale = 0.14f;
			grainOpacity = 5f;
			grainSaturation = 0f;
			scanDistort = 0.03f;
			timer = 0.85f;
			speed = 2f;
			crtDistort = 1f;
			crtScale = 1.06f;
			stripesCount = 0.5f;
			stripesOpacity = 1f;
			barsCount = 5f;
			moireOpacity = 1f;
			moireScale = 0.15f;
			tvLines = 2.5f;
			tvLinesOpacity = 1f;
			vignetteTubeScale = 0.7f;
			tvDots = 1f;
			tvDotsBlend = 1f;
			base.ResetDefaultValues();
		}

		public override void RandomValues()
		{
			slowScan = Random.Range(0.01f, 0.05f);
			scanLine = Random.Range(0.5f, 0.7f);
			vignetteSoftness = Random.Range(0.7f, 1f);
			vignetteScale = Random.Range(0.1f, 0.2f);
			grainOpacity = Random.Range(0f, 10f);
			grainSaturation = Random.Range(0f, 0.5f);
			scanDistort = Random.Range(0.01f, 0.05f);
			timer = Random.Range(0.6f, 1f);
			speed = Random.Range(1f, 3f);
			crtDistort = Random.Range(0f, 1f);
			crtScale = Random.Range(1f, 1.1f);
			stripesCount = Random.Range(0.8f, 1f);
			stripesOpacity = Random.Range(0.8f, 1f);
			barsCount = Random.Range(4f, 6f);
			moireOpacity = Random.Range(0.8f, 1.2f);
			moireScale = Random.Range(0.1f, 0.3f);
			tvLines = Random.Range(2f, 4f);
			tvLinesOpacity = Random.Range(0.75f, 1.25f);
			vignetteTubeScale = Random.Range(0.6f, 0.8f);
			tvDots = Random.Range(0.8f, 1.2f);
			tvDotsBlend = Random.Range(0.8f, 1.2f);
		}

		protected override void SendValuesToShader()
		{
			material.SetFloat(variableScanline, scanLine);
			material.SetFloat(variableSlowscan, slowScan);
			material.SetFloat(variableVignetteSoftness, vignetteSoftness);
			material.SetFloat(variableVignetteScale, vignetteScale);
			material.SetFloat(variableGrainOpacity, grainOpacity);
			material.SetFloat(variableSaturation, grainSaturation);
			material.SetFloat(variableScanDistort, scanDistort);
			material.SetFloat(variableTimer, timer);
			material.SetFloat(variableSpeed, speed);
			material.SetFloat(variableDistort, crtDistort);
			material.SetFloat(variableScale, crtScale);
			material.SetFloat(variableStripesCount, stripesCount);
			material.SetFloat(variableOpacity, stripesOpacity);
			material.SetFloat(variableBarsCount, barsCount);
			material.SetFloat(variableOpacityMoire, moireOpacity);
			material.SetFloat(variableMoireScale, moireScale);
			material.SetFloat(variableTVLines, tvLines);
			material.SetFloat(variableTVLinesOpacity, tvLinesOpacity);
			material.SetFloat(variableTVTubeVignetteScale, vignetteTubeScale);
			material.SetFloat(variableTVDots, tvDots);
			material.SetFloat(variableTVDotsBlend, tvDotsBlend);
		}
	}
}
