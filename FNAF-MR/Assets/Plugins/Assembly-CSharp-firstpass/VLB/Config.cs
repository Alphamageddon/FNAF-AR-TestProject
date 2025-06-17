using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace VLB
{
	[HelpURL("http://saladgamer.com/vlb-doc/config/")]
	public class Config : ScriptableObject
	{
		public bool geometryOverrideLayer = true;

		public int geometryLayerID = 1;

		public string geometryTag = "Untagged";

		public int geometryRenderQueue = 3000;

		public RenderPipeline renderPipeline;

		[Obsolete("Use 'renderingMode' instead")]
		public bool forceSinglePass;

		public RenderingMode renderingMode;

		[SerializeField]
		[HighlightNull]
		private Shader beamShader1Pass;

		[FormerlySerializedAs("BeamShader")]
		[FormerlySerializedAs("beamShader")]
		[SerializeField]
		[HighlightNull]
		private Shader beamShader2Pass;

		public int sharedMeshSides = 24;

		public int sharedMeshSegments = 5;

		[Range(0.01f, 2f)]
		public float globalNoiseScale = 0.5f;

		public Vector3 globalNoiseVelocity = Consts.NoiseVelocityDefault;

		public string fadeOutCameraTag = "MainCamera";

		[HighlightNull]
		public TextAsset noise3DData;

		public int noise3DSize = 64;

		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[SerializeField]
		private int pluginVersion = -1;

		private Transform m_CachedFadeOutCamera;

		private const string kAssetName = "Config";

		private static Config m_Instance;

		public RenderingMode actualRenderingMode
		{
			get
			{
				_ = renderingMode;
				_ = 2;
				return renderingMode;
			}
		}

		public bool useSinglePassShader => actualRenderingMode != RenderingMode.MultiPass;

		public Shader beamShader
		{
			get
			{
				if (!useSinglePassShader)
				{
					return beamShader2Pass;
				}
				return beamShader1Pass;
			}
		}

		public Vector4 globalNoiseParam => new Vector4(globalNoiseVelocity.x, globalNoiseVelocity.y, globalNoiseVelocity.z, globalNoiseScale);

		public Transform fadeOutCameraTransform
		{
			get
			{
				if (m_CachedFadeOutCamera == null)
				{
					ForceUpdateFadeOutCamera();
				}
				return m_CachedFadeOutCamera;
			}
		}

		public static Config Instance
		{
			get
			{
				if (m_Instance == null)
				{
					ConfigOverride configOverride = Resources.Load<ConfigOverride>("VLBConfigOverride");
					if ((bool)configOverride)
					{
						m_Instance = configOverride;
					}
					else
					{
						m_Instance = Resources.Load<Config>("Config");
					}
				}
				return m_Instance;
			}
		}

		public void ForceUpdateFadeOutCamera()
		{
			GameObject gameObject = GameObject.FindGameObjectWithTag(fadeOutCameraTag);
			if ((bool)gameObject)
			{
				m_CachedFadeOutCamera = gameObject.transform;
			}
		}

		[RuntimeInitializeOnLoadMethod]
		private static void OnStartup()
		{
			Instance.m_CachedFadeOutCamera = null;
			OnRenderPipelineChanged(Instance.renderPipeline);
		}

		public static void OnRenderPipelineChanged(RenderPipeline pipeline)
		{
			bool enabled = BeamGeometry.isCustomRenderPipelineSupported && pipeline == RenderPipeline.SRP_4_0_0_or_higher;
			Utils.SetShaderKeywordEnabled("VLB_SRP_API", enabled);
		}

		public void Reset()
		{
			geometryOverrideLayer = true;
			geometryLayerID = 1;
			geometryTag = "Untagged";
			geometryRenderQueue = 3000;
			beamShader1Pass = Shader.Find("Hidden/VolumetricLightBeam1Pass");
			beamShader2Pass = Shader.Find("Hidden/VolumetricLightBeam2Pass");
			sharedMeshSides = 24;
			sharedMeshSegments = 5;
			globalNoiseScale = 0.5f;
			globalNoiseVelocity = Consts.NoiseVelocityDefault;
			noise3DData = Resources.Load("Noise3D_64x64x64") as TextAsset;
			noise3DSize = 64;
			dustParticlesPrefab = Resources.Load("DustParticles", typeof(ParticleSystem)) as ParticleSystem;
			renderPipeline = RenderPipeline.BuiltIn;
			renderingMode = RenderingMode.MultiPass;
		}

		public ParticleSystem NewVolumetricDustParticles()
		{
			if (!dustParticlesPrefab)
			{
				if (Application.isPlaying)
				{
					Debug.LogError("Failed to instantiate VolumetricDustParticles prefab.");
				}
				return null;
			}
			ParticleSystem particleSystem = UnityEngine.Object.Instantiate(dustParticlesPrefab);
			particleSystem.useAutoRandomSeed = false;
			particleSystem.name = "Dust Particles";
			particleSystem.gameObject.hideFlags = Consts.ProceduralObjectsHideFlags;
			particleSystem.gameObject.SetActive(value: true);
			return particleSystem;
		}

		private void OnEnable()
		{
			HandleBackwardCompatibility(pluginVersion, 1700);
			pluginVersion = 1700;
		}

		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
			if (serializedVersion != newVersion)
			{
				if (serializedVersion < 1600)
				{
					renderingMode = (forceSinglePass ? RenderingMode.SinglePass : RenderingMode.MultiPass);
				}
				Utils.MarkObjectDirty(this);
			}
		}
	}
}
