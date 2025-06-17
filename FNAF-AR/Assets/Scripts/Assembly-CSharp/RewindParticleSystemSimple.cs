using UnityEngine;

public class RewindParticleSystemSimple : MonoBehaviour
{
	private ParticleSystem[] particleSystems;

	private float simulationTime;

	public float startTime = 2f;

	private float internalStartTime;

	private bool gameObjectDeactivated;

	public float simulationSpeed = 1f;

	public bool useFixedDeltaTime = true;

	public bool rewind = true;

	private void OnEnable()
	{
		bool num = particleSystems == null;
		if (num)
		{
			particleSystems = GetComponentsInChildren<ParticleSystem>(includeInactive: false);
		}
		simulationTime = 0f;
		if (num || gameObjectDeactivated)
		{
			internalStartTime = startTime;
		}
		else
		{
			internalStartTime = particleSystems[0].time;
		}
		for (int num2 = particleSystems.Length - 1; num2 >= 0; num2--)
		{
			particleSystems[num2].Simulate(internalStartTime, withChildren: false, restart: false, useFixedDeltaTime);
		}
	}

	private void OnDisable()
	{
		particleSystems[0].Play(withChildren: true);
		gameObjectDeactivated = !base.gameObject.activeInHierarchy;
	}

	private void Update()
	{
		simulationTime -= Time.deltaTime * simulationSpeed;
		float num = internalStartTime + simulationTime;
		particleSystems[0].Stop(withChildren: true, ParticleSystemStopBehavior.StopEmittingAndClear);
		for (int num2 = particleSystems.Length - 1; num2 >= 0; num2--)
		{
			bool useAutoRandomSeed = particleSystems[num2].useAutoRandomSeed;
			particleSystems[num2].useAutoRandomSeed = false;
			particleSystems[num2].Play(withChildren: false);
			particleSystems[num2].Simulate(num, withChildren: false, restart: false, useFixedDeltaTime);
			particleSystems[num2].useAutoRandomSeed = useAutoRandomSeed;
			if (num < 0f)
			{
				particleSystems[num2].Play();
				particleSystems[num2].Stop(withChildren: false, ParticleSystemStopBehavior.StopEmittingAndClear);
			}
		}
	}
}
