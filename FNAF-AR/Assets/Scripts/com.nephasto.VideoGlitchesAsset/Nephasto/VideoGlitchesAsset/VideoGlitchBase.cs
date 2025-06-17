using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[HelpURL("https://www.nephasto.com/store/video-glitches.html")]
	public abstract class VideoGlitchBase : MonoBehaviour
	{
		[SerializeField]
		private float strength = 1f;

		[SerializeField]
		private EffectModes effectMode;

		[SerializeField]
		private bool enableColorControls;

		[SerializeField]
		private float brightness;

		[SerializeField]
		private float contrast;

		[SerializeField]
		private float gamma = 1f;

		[SerializeField]
		private float hue;

		[SerializeField]
		private float saturation = 1f;

		[SerializeField]
		private LayerMask layer = -1;

		[SerializeField]
		private AnimationCurve distanceCurve = new AnimationCurve(new Keyframe(1f, 0f, 0f, 0f), new Keyframe(0f, 1f, 0f, 0f));

		[SerializeField]
		private RenderDepth renderDepth;

		[SerializeField]
		private float depthThreshold = 0.004f;

		[SerializeField]
		private bool useScaledTime = true;

		[SerializeField]
		private float timeScale = 1f;

		private float customTime;

		private Shader shader;

		protected Material material;

		private Texture2D distanceTexture;

		private static readonly int variableStrength = Shader.PropertyToID("_Strength");

		private static readonly int variableCustomTime = Shader.PropertyToID("_CustomTime");

		private static readonly int variableBrightness = Shader.PropertyToID("_Brightness");

		private static readonly int variableContrast = Shader.PropertyToID("_Contrast");

		private static readonly int variableGamma = Shader.PropertyToID("_Gamma");

		private static readonly int variableHue = Shader.PropertyToID("_Hue");

		private static readonly int variableSaturation = Shader.PropertyToID("_Saturation");

		private static readonly int variableRenderToTexture = Shader.PropertyToID("_RTT");

		private static readonly int variableDepthThreshold = Shader.PropertyToID("_DepthThreshold");

		private static readonly int variableDistanceTexture = Shader.PropertyToID("_DistanceTex");

		private const string keywordModeScreen = "MODE_SCREEN";

		private const string keywordModeLayer = "MODE_LAYER";

		private const string keywordModeDistance = "MODE_DISTANCE";

		private const string keywordColorControls = "COLOR_CONTROLS";

		public const string Documentation = "https://www.nephasto.com/store/video-glitches.html";

		public float Strength
		{
			get
			{
				return strength;
			}
			set
			{
				strength = Mathf.Clamp01(value);
			}
		}

		public EffectModes EffectMode
		{
			get
			{
				return effectMode;
			}
			set
			{
				if (value != effectMode)
				{
					effectMode = value;
					if (effectMode == EffectModes.Screen)
					{
						GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
						DestroyDepthCamera();
					}
					else
					{
						GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
						CreateDepthCamera();
					}
				}
			}
		}

		public LayerMask Layer
		{
			get
			{
				return layer;
			}
			set
			{
				layer = value;
				if (renderDepth != null)
				{
					renderDepth.layer = layer;
				}
			}
		}

		public AnimationCurve DistanceCurve
		{
			get
			{
				return distanceCurve;
			}
			set
			{
				distanceCurve = value;
				UpdateDistanceCurveTexture();
			}
		}

		public bool EnableColorControls
		{
			get
			{
				return enableColorControls;
			}
			set
			{
				enableColorControls = value;
			}
		}

		public float Brightness
		{
			get
			{
				return brightness;
			}
			set
			{
				brightness = Mathf.Clamp(value, -1f, 1f);
			}
		}

		public float Contrast
		{
			get
			{
				return contrast;
			}
			set
			{
				contrast = Mathf.Clamp(value, -1f, 1f);
			}
		}

		public float Gamma
		{
			get
			{
				return gamma;
			}
			set
			{
				gamma = Mathf.Clamp(value, 0.1f, 10f);
			}
		}

		public float Hue
		{
			get
			{
				return hue;
			}
			set
			{
				hue = Mathf.Clamp01(value);
			}
		}

		public float Saturation
		{
			get
			{
				return saturation;
			}
			set
			{
				saturation = Mathf.Clamp(value, 0f, 2f);
			}
		}

		public float DepthThreshold
		{
			get
			{
				return depthThreshold;
			}
			set
			{
				depthThreshold = Mathf.Clamp01(value);
			}
		}

		public bool UseScaledTime
		{
			get
			{
				return useScaledTime;
			}
			set
			{
				useScaledTime = value;
			}
		}

		public float CustomTimeScale
		{
			get
			{
				return timeScale;
			}
			set
			{
				timeScale = ((value >= 0f) ? value : 0f);
			}
		}

		private Material Material
		{
			get
			{
				if (material == null && shader != null)
				{
					string text = GetType().Name;
					material = new Material(shader);
					if (material != null)
					{
						material.name = text;
						material.hideFlags = HideFlags.HideAndDontSave;
					}
					else
					{
						Debug.LogError("[Nephasto.VideoGlitches] '" + text + "' material null. Please contact with 'hello@nephasto.com' and send the log file.");
						base.enabled = false;
					}
				}
				return material;
			}
		}

		public bool IsSupported()
		{
			bool flag = false;
			Shader shader = Resources.Load<Shader>(ShaderPath());
			if (shader != null)
			{
				flag = shader.isSupported && CheckHardwareRequirements();
				Resources.UnloadAsset(shader);
			}
			if (flag && (effectMode == EffectModes.Layer || effectMode == EffectModes.Distance))
			{
				flag = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth);
			}
			return flag;
		}

		public virtual void ResetDefaultValues()
		{
			strength = 1f;
			brightness = 0f;
			contrast = 0f;
			gamma = 1f;
			hue = 0f;
			saturation = 1f;
			depthThreshold = 0.004f;
			useScaledTime = true;
			timeScale = 1f;
		}

		public abstract void RandomValues();

		public override string ToString()
		{
			return "No description.";
		}

		protected virtual string ShaderPath()
		{
			return $"Shaders/{GetType().Name}";
		}

		private void CreateDepthCamera()
		{
			if (renderDepth == null)
			{
				GameObject gameObject = new GameObject("VideoGlitchesDepthCamera", typeof(Camera))
				{
					hideFlags = HideFlags.HideAndDontSave
				};
				gameObject.transform.parent = base.transform;
				gameObject.transform.localPosition = Vector3.zero;
				gameObject.transform.localRotation = Quaternion.identity;
				gameObject.transform.localScale = Vector3.one;
				renderDepth = gameObject.AddComponent<RenderDepth>();
				renderDepth.layer = layer;
			}
		}

		private void DestroyDepthCamera()
		{
			if (renderDepth != null)
			{
				GameObject obj = renderDepth.gameObject;
				renderDepth = null;
				Object.DestroyImmediate(obj);
			}
		}

		protected abstract void SendValuesToShader();

		protected virtual void LoadCustomResources()
		{
		}

		protected Texture2D LoadTextureFromResources(string texturePathFromResources)
		{
			Texture2D texture2D = Resources.Load<Texture2D>(texturePathFromResources);
			if (texture2D == null)
			{
				Debug.LogError("[Nephasto.VideoGlitches] Texture '" + texturePathFromResources + "' not found in 'Nephasto/VideoGlitches/Resources/Textures' folder. Please contact with 'hello@nephasto.com' and send the log file.");
				base.enabled = false;
			}
			return texture2D;
		}

		protected virtual bool CheckHardwareRequirements()
		{
			if ((effectMode == EffectModes.Layer || effectMode == EffectModes.Distance) && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				Debug.LogWarning("[Nephasto.VideoGlitches] Depth textures aren't supported on this device.");
				return false;
			}
			return true;
		}

		protected int RandomRange(int current, int min, int max)
		{
			int num;
			if (min < max)
			{
				do
				{
					num = Random.Range(min, max);
				}
				while (num == current);
			}
			else
			{
				num = Random.Range(min, max);
			}
			return num;
		}

		private void UpdateDistanceCurveTexture()
		{
			if (distanceTexture == null)
			{
				distanceTexture = new Texture2D(1024, 2)
				{
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Clamp,
					anisoLevel = 1
				};
			}
			float num = 1f / (float)distanceTexture.width;
			for (int i = 0; i < distanceTexture.width; i++)
			{
				Color color = Color.white * Mathf.Clamp01(distanceCurve.Evaluate((float)i * num));
				distanceTexture.SetPixel(i, 0, color);
				distanceTexture.SetPixel(i, 1, color);
			}
			distanceTexture.Apply();
		}

		private void Start()
		{
			string text = ShaderPath();
			shader = Resources.Load<Shader>(text);
			if (shader != null)
			{
				if (shader.isSupported && CheckHardwareRequirements())
				{
					LoadCustomResources();
					return;
				}
				Debug.LogError("[Nephasto.VideoGlitches] '" + text + "' shader not supported. Please contact with 'hello@nephasto.com' and send the log file.");
				base.enabled = false;
			}
			else
			{
				Debug.LogError("[Nephasto.VideoGlitches] Shader 'Nephasto/VideoGlitches/Resources/" + text + ".shader' not found. '" + GetType().Name + "' disabled.");
				base.enabled = false;
			}
		}

		private void OnEnable()
		{
			if (effectMode != EffectModes.Screen && renderDepth == null)
			{
				CreateDepthCamera();
			}
			GetComponent<Camera>().depthTextureMode = ((effectMode != EffectModes.Screen) ? DepthTextureMode.Depth : DepthTextureMode.None);
		}

		protected virtual void OnDestroy()
		{
			if (material != null)
			{
				Object.Destroy(material);
			}
		}

		private void Update()
		{
			customTime += (useScaledTime ? Time.deltaTime : Time.unscaledDeltaTime) * timeScale;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (Material != null)
			{
				material.shaderKeywords = null;
				material.SetFloat(variableStrength, strength);
				material.SetVector(variableCustomTime, new Vector4(customTime / 20f, customTime, customTime * 2f, customTime * 3f));
				switch (effectMode)
				{
				case EffectModes.Screen:
					material.EnableKeyword("MODE_SCREEN");
					break;
				case EffectModes.Layer:
					material.EnableKeyword("MODE_LAYER");
					if (renderDepth != null)
					{
						material.SetTexture(variableRenderToTexture, renderDepth.renderTexture);
					}
					material.SetFloat(variableDepthThreshold, depthThreshold);
					break;
				case EffectModes.Distance:
					material.EnableKeyword("MODE_DISTANCE");
					if (distanceTexture == null)
					{
						UpdateDistanceCurveTexture();
					}
					material.SetTexture(variableDistanceTexture, distanceTexture);
					break;
				}
				if (enableColorControls && strength > 0f)
				{
					material.EnableKeyword("COLOR_CONTROLS");
					material.SetFloat(variableBrightness, brightness);
					material.SetFloat(variableContrast, contrast);
					material.SetFloat(variableGamma, 1f / gamma);
					material.SetFloat(variableHue, hue);
					material.SetFloat(variableSaturation, saturation);
				}
				SendValuesToShader();
				Graphics.Blit(source, destination, material);
			}
			else
			{
				Graphics.Blit(source, destination);
			}
		}
	}
}
