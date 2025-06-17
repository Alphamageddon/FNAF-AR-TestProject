using UnityEngine;

namespace MirzaBeig.ParticleSystems.Demos
{
	public class MouseFollow : MonoBehaviour
	{
		public float speed = 8f;

		public float distanceFromCamera = 5f;

		public bool ignoreTimeScale;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
			Vector3 mousePosition = Input.mousePosition;
			mousePosition.z = distanceFromCamera;
			Vector3 b = Camera.main.ScreenToWorldPoint(mousePosition);
			float num = ((!ignoreTimeScale) ? Time.deltaTime : Time.unscaledDeltaTime);
			Vector3 position = Vector3.Lerp(base.transform.position, b, 1f - Mathf.Exp((0f - speed) * num));
			base.transform.position = position;
		}

		private void LateUpdate()
		{
		}
	}
}
