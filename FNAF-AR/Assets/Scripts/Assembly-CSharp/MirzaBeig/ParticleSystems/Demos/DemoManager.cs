using System;
using UnityEngine;
using UnityEngine.UI;

namespace MirzaBeig.ParticleSystems.Demos
{
	public class DemoManager : MonoBehaviour
	{
		public enum ParticleMode
		{
			looping = 0,
			oneshot = 1
		}

		public enum Level
		{
			none = 0,
			basic = 1
		}

		public Transform cameraRotationTransform;

		public Transform cameraTranslationTransform;

		public Vector3 cameraLookAtPosition = new Vector3(0f, 3f, 0f);

		public MouseFollow mouse;

		private Vector3 targetCameraPosition;

		private Vector3 targetCameraRotation;

		private Vector3 cameraPositionStart;

		private Vector3 cameraRotationStart;

		private Vector2 input;

		private Vector3 cameraRotation;

		public float cameraMoveAmount = 2f;

		public float cameraRotateAmount = 2f;

		public float cameraMoveSpeed = 12f;

		public float cameraRotationSpeed = 12f;

		public Vector2 cameraAngleLimits = new Vector2(-8f, 60f);

		public GameObject[] levels;

		public Level currentLevel = Level.basic;

		public ParticleMode particleMode;

		public bool advancedRendering = true;

		public Toggle loopingParticleModeToggle;

		public Toggle oneshotParticleModeToggle;

		public Toggle advancedRenderingToggle;

		public Toggle mouseParticlesToggle;

		private Toggle[] levelToggles;

		public ToggleGroup levelTogglesContainer;

		private LoopingParticleSystemsManager loopingParticleSystems;

		private OneshotParticleSystemsManager oneshotParticleSystems;

		public GameObject ui;

		public Text particleCountText;

		public Text currentParticleSystemText;

		public Text particleSpawnInstructionText;

		public Slider timeScaleSlider;

		public Text timeScaleSliderValueText;

		public Camera mainCamera;

		public MonoBehaviour[] mainCameraPostEffects;

		private Vector3 cameraPositionSmoothDampVelocity;

		private Vector3 cameraRotationSmoothDampVelocity;

		private void Awake()
		{
			loopingParticleSystems = UnityEngine.Object.FindObjectOfType<LoopingParticleSystemsManager>();
			oneshotParticleSystems = UnityEngine.Object.FindObjectOfType<OneshotParticleSystemsManager>();
			loopingParticleSystems.Init();
			oneshotParticleSystems.Init();
		}

		private void Start()
		{
			cameraPositionStart = cameraTranslationTransform.localPosition;
			cameraRotationStart = cameraRotationTransform.localEulerAngles;
			ResetCameraTransformTargets();
			switch (particleMode)
			{
			case ParticleMode.looping:
				SetToLoopingParticleMode(set: true);
				loopingParticleModeToggle.isOn = true;
				oneshotParticleModeToggle.isOn = false;
				break;
			case ParticleMode.oneshot:
				SetToOneshotParticleMode(set: true);
				loopingParticleModeToggle.isOn = false;
				oneshotParticleModeToggle.isOn = true;
				break;
			default:
				MonoBehaviour.print("Unknown case.");
				break;
			}
			SetAdvancedRendering(advancedRendering);
			advancedRenderingToggle.isOn = advancedRendering;
			levelToggles = levelTogglesContainer.GetComponentsInChildren<Toggle>(includeInactive: true);
			for (int i = 0; i < levels.Length; i++)
			{
				if (i == (int)currentLevel)
				{
					levels[i].SetActive(value: true);
					levelToggles[i].isOn = true;
				}
				else
				{
					levels[i].SetActive(value: false);
					levelToggles[i].isOn = false;
				}
			}
			UpdateCurrentParticleSystemNameText();
			timeScaleSlider.onValueChanged.AddListener(OnTimeScaleSliderValueChanged);
			OnTimeScaleSliderValueChanged(timeScaleSlider.value);
			mouseParticlesToggle.isOn = mouse.gameObject.activeSelf;
		}

		public void OnTimeScaleSliderValueChanged(float value)
		{
			Time.timeScale = value;
			timeScaleSliderValueText.text = value.ToString("0.00");
		}

		public void SetToLoopingParticleMode(bool set)
		{
			if (set)
			{
				oneshotParticleSystems.Clear();
				loopingParticleSystems.gameObject.SetActive(value: true);
				oneshotParticleSystems.gameObject.SetActive(value: false);
				particleSpawnInstructionText.gameObject.SetActive(value: false);
				particleMode = ParticleMode.looping;
				UpdateCurrentParticleSystemNameText();
			}
		}

		public void SetToOneshotParticleMode(bool set)
		{
			if (set)
			{
				loopingParticleSystems.gameObject.SetActive(value: false);
				oneshotParticleSystems.gameObject.SetActive(value: true);
				particleSpawnInstructionText.gameObject.SetActive(value: true);
				particleMode = ParticleMode.oneshot;
				UpdateCurrentParticleSystemNameText();
			}
		}

		public void SetLevel(Level level)
		{
			for (int i = 0; i < levels.Length; i++)
			{
				if (i == (int)level)
				{
					levels[i].SetActive(value: true);
				}
				else
				{
					levels[i].SetActive(value: false);
				}
			}
			currentLevel = level;
		}

		public void SetLevelFromToggle(Toggle toggle)
		{
			if (toggle.isOn)
			{
				SetLevel((Level)Array.IndexOf(levelToggles, toggle));
			}
		}

		public void SetAdvancedRendering(bool value)
		{
			advancedRendering = value;
			mainCamera.allowHDR = value;
			for (int i = 0; i < mainCameraPostEffects.Length; i++)
			{
				if ((bool)mainCameraPostEffects[i])
				{
					mainCameraPostEffects[i].enabled = value;
				}
			}
		}

		public void SetMouseParticlesRendering(bool value)
		{
			mouse.gameObject.SetActive(value);
		}

		public static Vector3 DampVector3(Vector3 from, Vector3 to, float speed, float dt)
		{
			return Vector3.Lerp(from, to, 1f - Mathf.Exp((0f - speed) * dt));
		}

		private void Update()
		{
			input.x = Input.GetAxis("Horizontal");
			input.y = Input.GetAxis("Vertical");
			if (Input.GetKey(KeyCode.LeftShift))
			{
				targetCameraPosition.z += input.y * cameraMoveAmount;
				targetCameraPosition.z = Mathf.Clamp(targetCameraPosition.z, -6.3f, -1f);
			}
			else
			{
				targetCameraRotation.y += input.x * cameraRotateAmount;
				targetCameraRotation.x += input.y * cameraRotateAmount;
				targetCameraRotation.x = Mathf.Clamp(targetCameraRotation.x, cameraAngleLimits.x, cameraAngleLimits.y);
			}
			cameraTranslationTransform.localPosition = Vector3.SmoothDamp(cameraTranslationTransform.localPosition, targetCameraPosition, ref cameraPositionSmoothDampVelocity, 1f / cameraMoveSpeed, float.PositiveInfinity, Time.unscaledDeltaTime);
			cameraRotation = Vector3.SmoothDamp(cameraRotation, targetCameraRotation, ref cameraRotationSmoothDampVelocity, 1f / cameraRotationSpeed, float.PositiveInfinity, Time.unscaledDeltaTime);
			cameraRotationTransform.localEulerAngles = cameraRotation;
			cameraTranslationTransform.LookAt(cameraLookAtPosition);
			if (Input.GetAxis("Mouse ScrollWheel") < 0f)
			{
				Next();
			}
			else if (Input.GetAxis("Mouse ScrollWheel") > 0f)
			{
				Previous();
			}
			if (Input.GetKeyDown(KeyCode.U))
			{
				ui.SetActive(!ui.activeSelf);
			}
			if (Input.GetKeyDown(KeyCode.O))
			{
				if (particleMode == ParticleMode.looping)
				{
					SetToOneshotParticleMode(set: true);
				}
				else
				{
					SetToLoopingParticleMode(set: true);
				}
			}
			if (Input.GetKeyDown(KeyCode.L))
			{
				SetLevel((Level)((int)(currentLevel + 1) % Enum.GetNames(typeof(Level)).Length));
			}
			else
			{
				Input.GetKey(KeyCode.R);
			}
			if (particleMode == ParticleMode.oneshot)
			{
				Vector3 mousePosition = Input.mousePosition;
				if (Input.GetMouseButtonDown(0))
				{
					CameraShake cameraShake = UnityEngine.Object.FindObjectOfType<CameraShake>();
					cameraShake.Add(0.2f, 5f, 0.2f, CameraShakeTarget.Position, CameraShakeAmplitudeCurve.FadeInOut25);
					cameraShake.Add(4f, 5f, 0.5f, CameraShakeTarget.Rotation, CameraShakeAmplitudeCurve.FadeInOut25);
					oneshotParticleSystems.InstantiateParticlePrefab(mousePosition, mouse.distanceFromCamera);
				}
				if (Input.GetMouseButton(1))
				{
					oneshotParticleSystems.InstantiateParticlePrefab(mousePosition, mouse.distanceFromCamera);
				}
			}
			if (Input.GetKeyDown(KeyCode.R))
			{
				ResetCameraTransformTargets();
			}
		}

		private void LateUpdate()
		{
			particleCountText.text = "PARTICLE COUNT: ";
			if (particleMode == ParticleMode.looping)
			{
				particleCountText.text += loopingParticleSystems.GetParticleCount();
			}
			else if (particleMode == ParticleMode.oneshot)
			{
				particleCountText.text += oneshotParticleSystems.GetParticleCount();
			}
		}

		private void ResetCameraTransformTargets()
		{
			targetCameraPosition = cameraPositionStart;
			targetCameraRotation = cameraRotationStart;
		}

		private void UpdateCurrentParticleSystemNameText()
		{
			if (particleMode == ParticleMode.looping)
			{
				currentParticleSystemText.text = loopingParticleSystems.GetCurrentPrefabName(shorten: true);
			}
			else if (particleMode == ParticleMode.oneshot)
			{
				currentParticleSystemText.text = oneshotParticleSystems.GetCurrentPrefabName(shorten: true);
			}
		}

		public void Next()
		{
			if (particleMode == ParticleMode.looping)
			{
				loopingParticleSystems.Next();
			}
			else if (particleMode == ParticleMode.oneshot)
			{
				oneshotParticleSystems.Next();
			}
			UpdateCurrentParticleSystemNameText();
		}

		public void Previous()
		{
			if (particleMode == ParticleMode.looping)
			{
				loopingParticleSystems.Previous();
			}
			else if (particleMode == ParticleMode.oneshot)
			{
				oneshotParticleSystems.Previous();
			}
			UpdateCurrentParticleSystemNameText();
		}
	}
}
