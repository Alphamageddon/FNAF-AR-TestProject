using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ParticleSystemDuration : MonoBehaviour
{
	public ParticleSystem[] particleSystems;

	public float GetDuration()
	{
		List<float> list = new List<float>();
		ParticleSystem[] array = particleSystems;
		foreach (ParticleSystem particle in array)
		{
			list.Add(GetIndividualDuration(particle));
		}
		return list.Max();
	}

	private static float GetIndividualDuration(ParticleSystem particle)
	{
		float num = particle.main.startLifetime.constant;
		_ = particle.emission;
		if (particle.main.duration > num)
		{
			num = particle.main.duration;
		}
		if (!particle.trails.enabled)
		{
			return num;
		}
		if (particle.trails.lifetime.constant > num)
		{
			return particle.trails.lifetime.constant;
		}
		return num;
	}
}
