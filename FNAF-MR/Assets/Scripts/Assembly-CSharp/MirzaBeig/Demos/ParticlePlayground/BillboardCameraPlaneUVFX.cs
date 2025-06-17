using UnityEngine;

namespace MirzaBeig.Demos.ParticlePlayground
{
	public class BillboardCameraPlaneUVFX : MonoBehaviour
	{
		private Transform cameraTransform;

		private void Awake()
		{
		}

		private void Start()
		{
			cameraTransform = Camera.main.transform;
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
			base.transform.forward = -cameraTransform.forward;
		}
	}
}
