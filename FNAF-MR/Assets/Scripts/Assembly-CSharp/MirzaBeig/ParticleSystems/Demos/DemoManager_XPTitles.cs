using System;
using UnityEngine;
using UnityEngine.UI;

namespace MirzaBeig.ParticleSystems.Demos
{
	[Serializable]
	public class DemoManager_XPTitles : MonoBehaviour
	{
		private LoopingParticleSystemsManager list;

		public Text particleCountText;

		public Text currentParticleSystemText;

		private Rotator cameraRotator;

		private void Awake()
		{
			(list = GetComponent<LoopingParticleSystemsManager>()).Init();
		}

		private void Start()
		{
			cameraRotator = Camera.main.GetComponentInParent<Rotator>();
			updateCurrentParticleSystemNameText();
		}

		public void ToggleRotation()
		{
			cameraRotator.enabled = !cameraRotator.enabled;
		}

		public void ResetRotation()
		{
			cameraRotator.transform.eulerAngles = Vector3.zero;
		}

		private void Update()
		{
			if (Input.GetAxis("Mouse ScrollWheel") < 0f)
			{
				Next();
			}
			else if (Input.GetAxis("Mouse ScrollWheel") > 0f)
			{
				previous();
			}
		}

		private void LateUpdate()
		{
			if ((bool)particleCountText)
			{
				particleCountText.text = "PARTICLE COUNT: ";
				particleCountText.text += list.GetParticleCount();
			}
		}

		public void Next()
		{
			list.Next();
			updateCurrentParticleSystemNameText();
		}

		public void previous()
		{
			list.Previous();
			updateCurrentParticleSystemNameText();
		}

		private void updateCurrentParticleSystemNameText()
		{
			if ((bool)currentParticleSystemText)
			{
				currentParticleSystemText.text = list.GetCurrentPrefabName(shorten: true);
			}
		}
	}
}
