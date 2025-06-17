using System.Collections.Generic;
using UnityEngine;

namespace MirzaBeig.ParticleSystems.Demos
{
	public class OneshotParticleSystemsManager : ParticleManager
	{
		public LayerMask mouseRaycastLayerMask = -1;

		private List<ParticleSystem[]> spawnedPrefabs;

		public bool disableSpawn { get; set; }

		protected override void Awake()
		{
			base.Awake();
		}

		protected override void Start()
		{
			base.Start();
			disableSpawn = false;
			spawnedPrefabs = new List<ParticleSystem[]>();
		}

		private void OnEnable()
		{
		}

		public void Clear()
		{
			if (spawnedPrefabs == null)
			{
				return;
			}
			for (int i = 0; i < spawnedPrefabs.Count; i++)
			{
				if ((bool)spawnedPrefabs[i][0])
				{
					Object.Destroy(spawnedPrefabs[i][0].gameObject);
				}
			}
			spawnedPrefabs.Clear();
		}

		protected override void Update()
		{
			base.Update();
		}

		public void InstantiateParticlePrefab(Vector2 mousePosition, float maxDistance)
		{
			if (spawnedPrefabs != null && !disableSpawn)
			{
				Vector3 position = mousePosition;
				position.z = maxDistance;
				Vector3 vector = Camera.main.ScreenToWorldPoint(position);
				Vector3 direction = vector - Camera.main.transform.position;
				Physics.Raycast(Camera.main.transform.position + Camera.main.transform.forward * 0.01f, direction, out var hitInfo, maxDistance);
				Vector3 position2 = ((!hitInfo.collider) ? vector : hitInfo.point);
				ParticleSystem[] array = particlePrefabs[currentParticlePrefabIndex];
				ParticleSystem particleSystem = Object.Instantiate(array[0], position2, array[0].transform.rotation);
				particleSystem.gameObject.SetActive(value: true);
				particleSystem.transform.parent = base.transform;
				spawnedPrefabs.Add(particleSystem.GetComponentsInChildren<ParticleSystem>());
			}
		}

		public void Randomize()
		{
			currentParticlePrefabIndex = Random.Range(0, particlePrefabs.Count);
		}

		public override int GetParticleCount()
		{
			int num = 0;
			if (spawnedPrefabs != null)
			{
				for (int i = 0; i < spawnedPrefabs.Count; i++)
				{
					if ((bool)spawnedPrefabs[i][0])
					{
						for (int j = 0; j < spawnedPrefabs[i].Length; j++)
						{
							num += spawnedPrefabs[i][j].particleCount;
						}
					}
					else
					{
						spawnedPrefabs.RemoveAt(i);
					}
				}
			}
			return num;
		}
	}
}
