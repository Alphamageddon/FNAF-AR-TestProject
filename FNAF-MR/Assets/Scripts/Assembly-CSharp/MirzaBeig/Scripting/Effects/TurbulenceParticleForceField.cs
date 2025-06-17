using UnityEngine;

namespace MirzaBeig.Scripting.Effects
{
	[AddComponentMenu("Effects/Particle Force Fields/Turbulence Particle Force Field")]
	public class TurbulenceParticleForceField : ParticleForceField
	{
		public enum NoiseType
		{
			PseudoPerlin = 0,
			Perlin = 1,
			Simplex = 2,
			OctavePerlin = 3,
			OctaveSimplex = 4
		}

		[Header("ForceField Controls")]
		[Tooltip("Noise texture mutation speed.")]
		public float scrollSpeed = 1f;

		[Range(0f, 8f)]
		[Tooltip("Noise texture detail amplifier.")]
		public float frequency = 1f;

		public NoiseType noiseType = NoiseType.Perlin;

		[Header("Octave Variant-Only Controls")]
		[Range(1f, 8f)]
		[Tooltip("Overlapping noise iterations. 1 = no additional iterations.")]
		public int octaves = 1;

		[Range(0f, 4f)]
		[Tooltip("Frequency scale per-octave. Can be used to change the overlap every iteration.")]
		public float octaveMultiplier = 0.5f;

		[Range(0f, 1f)]
		[Tooltip("Amplitude scale per-octave. Can be used to change the overlap every iteration.")]
		public float octaveScale = 2f;

		private float time;

		private float randomX;

		private float randomY;

		private float randomZ;

		private float offsetX;

		private float offsetY;

		private float offsetZ;

		protected override void Awake()
		{
			base.Awake();
		}

		protected override void Start()
		{
			base.Start();
			randomX = Random.Range(-32f, 32f);
			randomY = Random.Range(-32f, 32f);
			randomZ = Random.Range(-32f, 32f);
		}

		protected override void Update()
		{
			time = Time.time;
			base.Update();
		}

		protected override void LateUpdate()
		{
			offsetX = time * scrollSpeed + randomX;
			offsetY = time * scrollSpeed + randomY;
			offsetZ = time * scrollSpeed + randomZ;
			base.LateUpdate();
		}

		protected override Vector3 GetForce()
		{
			float num = parameters.particlePosition.x + offsetX;
			float num2 = parameters.particlePosition.y + offsetX;
			float num3 = parameters.particlePosition.z + offsetX;
			float num4 = parameters.particlePosition.x + offsetY;
			float num5 = parameters.particlePosition.y + offsetY;
			float num6 = parameters.particlePosition.z + offsetY;
			float num7 = parameters.particlePosition.x + offsetZ;
			float num8 = parameters.particlePosition.y + offsetZ;
			float num9 = parameters.particlePosition.z + offsetZ;
			Vector3 result = default(Vector3);
			switch (noiseType)
			{
			case NoiseType.PseudoPerlin:
			{
				float t = Mathf.PerlinNoise(num * frequency, num5 * frequency);
				float t2 = Mathf.PerlinNoise(num * frequency, num6 * frequency);
				float t3 = Mathf.PerlinNoise(num * frequency, num4 * frequency);
				t = Mathf.Lerp(-1f, 1f, t);
				t2 = Mathf.Lerp(-1f, 1f, t2);
				t3 = Mathf.Lerp(-1f, 1f, t3);
				Vector3 vector = Vector3.right * t;
				Vector3 vector2 = Vector3.up * t2;
				Vector3 vector3 = Vector3.forward * t3;
				return vector + vector2 + vector3;
			}
			default:
				result.x = Noise2.perlin(num * frequency, num2 * frequency, num3 * frequency);
				result.y = Noise2.perlin(num4 * frequency, num5 * frequency, num6 * frequency);
				result.z = Noise2.perlin(num7 * frequency, num8 * frequency, num9 * frequency);
				return result;
			case NoiseType.Simplex:
				result.x = Noise2.simplex(num * frequency, num2 * frequency, num3 * frequency);
				result.y = Noise2.simplex(num4 * frequency, num5 * frequency, num6 * frequency);
				result.z = Noise2.simplex(num7 * frequency, num8 * frequency, num9 * frequency);
				break;
			case NoiseType.OctavePerlin:
				result.x = Noise2.octavePerlin(num, num2, num3, frequency, octaves, octaveMultiplier, octaveScale);
				result.y = Noise2.octavePerlin(num4, num5, num6, frequency, octaves, octaveMultiplier, octaveScale);
				result.z = Noise2.octavePerlin(num7, num8, num9, frequency, octaves, octaveMultiplier, octaveScale);
				break;
			case NoiseType.OctaveSimplex:
				result.x = Noise2.octaveSimplex(num, num2, num3, frequency, octaves, octaveMultiplier, octaveScale);
				result.y = Noise2.octaveSimplex(num4, num5, num6, frequency, octaves, octaveMultiplier, octaveScale);
				result.z = Noise2.octaveSimplex(num7, num8, num9, frequency, octaves, octaveMultiplier, octaveScale);
				break;
			}
			return result;
		}

		protected override void OnDrawGizmosSelected()
		{
			if (base.enabled)
			{
				base.OnDrawGizmosSelected();
			}
		}
	}
}
