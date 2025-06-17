using UnityEngine;

namespace MirzaBeig.ParticleSystems.Demos
{
	public class LoopingParticleSystemsManager : ParticleManager
	{
		protected override void Awake()
		{
			base.Awake();
		}

		protected override void Start()
		{
			base.Start();
			particlePrefabs[currentParticlePrefabIndex][0].gameObject.SetActive(value: true);
		}

		public override void Next()
		{
			particlePrefabs[currentParticlePrefabIndex][0].gameObject.SetActive(value: false);
			base.Next();
			particlePrefabs[currentParticlePrefabIndex][0].gameObject.SetActive(value: true);
		}

		public override void Previous()
		{
			particlePrefabs[currentParticlePrefabIndex][0].gameObject.SetActive(value: false);
			base.Previous();
			particlePrefabs[currentParticlePrefabIndex][0].gameObject.SetActive(value: true);
		}

		protected override void Update()
		{
			base.Update();
		}

		public override int GetParticleCount()
		{
			int num = 0;
			ParticleSystem[] array = particlePrefabs[currentParticlePrefabIndex];
			for (int i = 0; i < array.Length; i++)
			{
				num += array[i].particleCount;
			}
			return num;
		}
	}
}
