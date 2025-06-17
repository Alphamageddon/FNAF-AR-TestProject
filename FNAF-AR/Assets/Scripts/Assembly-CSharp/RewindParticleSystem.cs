using UnityEngine;

public class RewindParticleSystem : MonoBehaviour
{
	private ParticleSystem[] particleSystems;

	private float[] startTimes;

	private float[] simulationTimes;

	public float startTime = 2f;

	public float simulationSpeedScale = 1f;

	public bool useFixedDeltaTime = true;

	private bool gameObjectDeactivated;

	private void OnEnable()
	{
		bool flag = particleSystems == null;
		if (flag)
		{
			particleSystems = GetComponentsInChildren<ParticleSystem>(includeInactive: false);
			startTimes = new float[particleSystems.Length];
			simulationTimes = new float[particleSystems.Length];
		}
		for (int num = particleSystems.Length - 1; num >= 0; num--)
		{
			simulationTimes[num] = 0f;
			if (flag || gameObjectDeactivated)
			{
				startTimes[num] = startTime;
				particleSystems[num].Simulate(startTimes[num], withChildren: false, restart: false, useFixedDeltaTime);
			}
			else
			{
				startTimes[num] = particleSystems[num].time;
			}
		}
	}

	private void OnDisable()
	{
		particleSystems[0].Play(withChildren: true);
		gameObjectDeactivated = !base.gameObject.activeInHierarchy;
	}

	private void Update()
	{
		particleSystems[0].Stop(withChildren: true, ParticleSystemStopBehavior.StopEmittingAndClear);
		for (int num = particleSystems.Length - 1; num >= 0; num--)
		{
			bool useAutoRandomSeed = particleSystems[num].useAutoRandomSeed;
			particleSystems[num].useAutoRandomSeed = false;
			particleSystems[num].Play(withChildren: false);
			float num2 = (particleSystems[num].main.useUnscaledTime ? Time.unscaledDeltaTime : Time.deltaTime);
			simulationTimes[num] -= num2 * particleSystems[num].main.simulationSpeed * simulationSpeedScale;
			float num3 = startTimes[num] + simulationTimes[num];
			particleSystems[num].Simulate(num3, withChildren: false, restart: false, useFixedDeltaTime);
			particleSystems[num].useAutoRandomSeed = useAutoRandomSeed;
			if (num3 < 0f)
			{
				particleSystems[num].Play(withChildren: false);
				particleSystems[num].Stop(withChildren: false, ParticleSystemStopBehavior.StopEmittingAndClear);
			}
		}
	}
}
