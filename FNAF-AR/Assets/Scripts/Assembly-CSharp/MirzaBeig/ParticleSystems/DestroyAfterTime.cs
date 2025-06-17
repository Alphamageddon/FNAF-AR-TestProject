using UnityEngine;

namespace MirzaBeig.ParticleSystems
{
	public class DestroyAfterTime : MonoBehaviour
	{
		public float time = 2f;

		private void Start()
		{
			Object.Destroy(base.gameObject, time);
		}
	}
}
