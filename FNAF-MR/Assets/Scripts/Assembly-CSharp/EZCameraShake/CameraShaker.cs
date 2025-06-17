using System.Collections.Generic;
using UnityEngine;

namespace EZCameraShake
{
	[AddComponentMenu("EZ Camera Shake/Camera Shaker")]
	public class CameraShaker : MonoBehaviour
	{
		public static CameraShaker Instance;

		private static Dictionary<string, CameraShaker> instanceList = new Dictionary<string, CameraShaker>();

		public Vector3 DefaultPosInfluence = new Vector3(0.15f, 0.15f, 0.15f);

		public Vector3 DefaultRotInfluence = new Vector3(1f, 1f, 1f);

		public Vector3 RestPositionOffset = new Vector3(0f, 0f, 0f);

		public Vector3 RestRotationOffset = new Vector3(0f, 0f, 0f);

		private Vector3 posAddShake;

		private Vector3 rotAddShake;

		private List<CameraShakeInstance> cameraShakeInstances = new List<CameraShakeInstance>();

		public List<CameraShakeInstance> ShakeInstances => new List<CameraShakeInstance>(cameraShakeInstances);

		private void Awake()
		{
			Instance = this;
			instanceList.Add(base.gameObject.name, this);
		}

		private void Update()
		{
			posAddShake = Vector3.zero;
			rotAddShake = Vector3.zero;
			for (int i = 0; i < cameraShakeInstances.Count && i < cameraShakeInstances.Count; i++)
			{
				CameraShakeInstance cameraShakeInstance = cameraShakeInstances[i];
				if (cameraShakeInstance.CurrentState == CameraShakeState.Inactive && cameraShakeInstance.DeleteOnInactive)
				{
					cameraShakeInstances.RemoveAt(i);
					i--;
				}
				else if (cameraShakeInstance.CurrentState != CameraShakeState.Inactive)
				{
					posAddShake += CameraUtilities.MultiplyVectors(cameraShakeInstance.UpdateShake(), cameraShakeInstance.PositionInfluence);
					rotAddShake += CameraUtilities.MultiplyVectors(cameraShakeInstance.UpdateShake(), cameraShakeInstance.RotationInfluence);
				}
			}
			base.transform.localPosition = posAddShake + RestPositionOffset;
			base.transform.localEulerAngles = rotAddShake + RestRotationOffset;
		}

		public static CameraShaker GetInstance(string name)
		{
			if (instanceList.TryGetValue(name, out var value))
			{
				return value;
			}
			Debug.LogError("CameraShake " + name + " not found!");
			return null;
		}

		public CameraShakeInstance Shake(CameraShakeInstance shake)
		{
			cameraShakeInstances.Add(shake);
			return shake;
		}

		public CameraShakeInstance ShakeOnce(float magnitude, float roughness, float fadeInTime, float fadeOutTime)
		{
			CameraShakeInstance cameraShakeInstance = new CameraShakeInstance(magnitude, roughness, fadeInTime, fadeOutTime);
			cameraShakeInstance.PositionInfluence = DefaultPosInfluence;
			cameraShakeInstance.RotationInfluence = DefaultRotInfluence;
			cameraShakeInstances.Add(cameraShakeInstance);
			return cameraShakeInstance;
		}

		public CameraShakeInstance ShakeOnce(float magnitude, float roughness, float fadeInTime, float fadeOutTime, Vector3 posInfluence, Vector3 rotInfluence)
		{
			CameraShakeInstance cameraShakeInstance = new CameraShakeInstance(magnitude, roughness, fadeInTime, fadeOutTime);
			cameraShakeInstance.PositionInfluence = posInfluence;
			cameraShakeInstance.RotationInfluence = rotInfluence;
			cameraShakeInstances.Add(cameraShakeInstance);
			return cameraShakeInstance;
		}

		public CameraShakeInstance StartShake(float magnitude, float roughness, float fadeInTime)
		{
			CameraShakeInstance cameraShakeInstance = new CameraShakeInstance(magnitude, roughness);
			cameraShakeInstance.PositionInfluence = DefaultPosInfluence;
			cameraShakeInstance.RotationInfluence = DefaultRotInfluence;
			cameraShakeInstance.StartFadeIn(fadeInTime);
			cameraShakeInstances.Add(cameraShakeInstance);
			return cameraShakeInstance;
		}

		public CameraShakeInstance StartShake(float magnitude, float roughness, float fadeInTime, Vector3 posInfluence, Vector3 rotInfluence)
		{
			CameraShakeInstance cameraShakeInstance = new CameraShakeInstance(magnitude, roughness);
			cameraShakeInstance.PositionInfluence = posInfluence;
			cameraShakeInstance.RotationInfluence = rotInfluence;
			cameraShakeInstance.StartFadeIn(fadeInTime);
			cameraShakeInstances.Add(cameraShakeInstance);
			return cameraShakeInstance;
		}

		private void OnDestroy()
		{
			instanceList.Remove(base.gameObject.name);
		}
	}
}
