using UnityEngine;

namespace MirzaBeig.ParticleSystems
{
	public class ParticleSystems : MonoBehaviour
	{
		public ParticleSystem[] particleSystems { get; set; }

		protected virtual void Awake()
		{
			particleSystems = GetComponentsInChildren<ParticleSystem>();
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		public void Reset()
		{
			for (int i = 0; i < particleSystems.Length; i++)
			{
				particleSystems[i].time = 0f;
			}
		}

		public void Play()
		{
			for (int i = 0; i < particleSystems.Length; i++)
			{
				particleSystems[i].Play(withChildren: false);
			}
		}

		public void Pause()
		{
			for (int i = 0; i < particleSystems.Length; i++)
			{
				particleSystems[i].Pause(withChildren: false);
			}
		}

		public void Stop()
		{
			for (int i = 0; i < particleSystems.Length; i++)
			{
				particleSystems[i].Stop(withChildren: false);
			}
		}

		public void Clear()
		{
			for (int i = 0; i < particleSystems.Length; i++)
			{
				particleSystems[i].Clear(withChildren: false);
			}
		}

		public void SetLoop(bool loop)
		{
			for (int i = 0; i < particleSystems.Length; i++)
			{
				ParticleSystem.MainModule main = particleSystems[i].main;
				main.loop = loop;
			}
		}

		public void SetPlaybackSpeed(float speed)
		{
			for (int i = 0; i < particleSystems.Length; i++)
			{
				ParticleSystem.MainModule main = particleSystems[i].main;
				main.simulationSpeed = speed;
			}
		}

		public void Simulate(float time, bool reset = false)
		{
			for (int i = 0; i < particleSystems.Length; i++)
			{
				particleSystems[i].Simulate(time, withChildren: false, reset);
			}
		}

		public bool IsAlive()
		{
			for (int i = 0; i < particleSystems.Length; i++)
			{
				if ((bool)particleSystems[i] && particleSystems[i].IsAlive())
				{
					return true;
				}
			}
			return false;
		}

		public bool IsPlaying(bool checkAll = false)
		{
			if (particleSystems.Length == 0)
			{
				return false;
			}
			if (!checkAll)
			{
				return particleSystems[0].isPlaying;
			}
			for (int i = 0; i < 0; i++)
			{
				if (!particleSystems[i].isPlaying)
				{
					return false;
				}
			}
			return true;
		}

		public int GetParticleCount()
		{
			int num = 0;
			for (int i = 0; i < particleSystems.Length; i++)
			{
				if ((bool)particleSystems[i])
				{
					num += particleSystems[i].particleCount;
				}
			}
			return num;
		}
	}
}
