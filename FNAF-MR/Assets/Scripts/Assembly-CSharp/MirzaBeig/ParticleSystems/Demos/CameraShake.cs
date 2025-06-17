using System;
using System.Collections.Generic;
using UnityEngine;

namespace MirzaBeig.ParticleSystems.Demos
{
	public class CameraShake : MonoBehaviour
	{
		[Serializable]
		public class Shake
		{
			public float amplitude = 1f;

			public float frequency = 1f;

			public float duration;

			[HideInInspector]
			public CameraShakeTarget target;

			private float timeRemaining;

			private Vector2 perlinNoiseX;

			private Vector2 perlinNoiseY;

			private Vector2 perlinNoiseZ;

			[HideInInspector]
			public Vector3 noise;

			public AnimationCurve amplitudeOverLifetimeCurve = new AnimationCurve(new Keyframe(0f, 1f), new Keyframe(1f, 0f));

			public void Init()
			{
				timeRemaining = duration;
				ApplyRandomSeed();
			}

			private void Init(float amplitude, float frequency, float duration, CameraShakeTarget target)
			{
				this.amplitude = amplitude;
				this.frequency = frequency;
				this.duration = duration;
				timeRemaining = duration;
				this.target = target;
				ApplyRandomSeed();
			}

			public void ApplyRandomSeed()
			{
				float num = 32f;
				perlinNoiseX.x = UnityEngine.Random.Range(0f - num, num);
				perlinNoiseX.y = UnityEngine.Random.Range(0f - num, num);
				perlinNoiseY.x = UnityEngine.Random.Range(0f - num, num);
				perlinNoiseY.y = UnityEngine.Random.Range(0f - num, num);
				perlinNoiseZ.x = UnityEngine.Random.Range(0f - num, num);
				perlinNoiseZ.y = UnityEngine.Random.Range(0f - num, num);
			}

			public Shake(float amplitude, float frequency, float duration, CameraShakeTarget target, AnimationCurve amplitudeOverLifetimeCurve)
			{
				Init(amplitude, frequency, duration, target);
				this.amplitudeOverLifetimeCurve = amplitudeOverLifetimeCurve;
			}

			public Shake(float amplitude, float frequency, float duration, CameraShakeTarget target, CameraShakeAmplitudeCurve amplitudeOverLifetimeCurve)
			{
				Init(amplitude, frequency, duration, target);
				switch (amplitudeOverLifetimeCurve)
				{
				case CameraShakeAmplitudeCurve.Constant:
					this.amplitudeOverLifetimeCurve = AnimationCurve.Linear(0f, 1f, 1f, 1f);
					break;
				case CameraShakeAmplitudeCurve.FadeInOut25:
					this.amplitudeOverLifetimeCurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(0.25f, 1f), new Keyframe(1f, 0f));
					break;
				case CameraShakeAmplitudeCurve.FadeInOut50:
					this.amplitudeOverLifetimeCurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(0.5f, 1f), new Keyframe(1f, 0f));
					break;
				case CameraShakeAmplitudeCurve.FadeInOut75:
					this.amplitudeOverLifetimeCurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(0.75f, 1f), new Keyframe(1f, 0f));
					break;
				default:
					throw new Exception("Unknown enum.");
				}
			}

			public bool IsAlive()
			{
				return timeRemaining > 0f;
			}

			public void Update()
			{
				if (!(timeRemaining < 0f))
				{
					Vector2 vector = Time.deltaTime * new Vector2(frequency, frequency);
					perlinNoiseX += vector;
					perlinNoiseY += vector;
					perlinNoiseZ += vector;
					noise.x = Mathf.PerlinNoise(perlinNoiseX.x, perlinNoiseX.y) - 0.5f;
					noise.y = Mathf.PerlinNoise(perlinNoiseY.x, perlinNoiseY.y) - 0.5f;
					noise.z = Mathf.PerlinNoise(perlinNoiseZ.x, perlinNoiseZ.y) - 0.5f;
					float num = amplitudeOverLifetimeCurve.Evaluate(1f - timeRemaining / duration);
					noise *= amplitude * num;
					timeRemaining -= Time.deltaTime;
				}
			}
		}

		public float smoothDampTime = 0.025f;

		private Vector3 smoothDampPositionVelocity;

		private float smoothDampRotationVelocityX;

		private float smoothDampRotationVelocityY;

		private float smoothDampRotationVelocityZ;

		private List<Shake> shakes = new List<Shake>();

		private void Start()
		{
		}

		public void Add(float amplitude, float frequency, float duration, CameraShakeTarget target, AnimationCurve amplitudeOverLifetimeCurve)
		{
			shakes.Add(new Shake(amplitude, frequency, duration, target, amplitudeOverLifetimeCurve));
		}

		public void Add(float amplitude, float frequency, float duration, CameraShakeTarget target, CameraShakeAmplitudeCurve amplitudeOverLifetimeCurve)
		{
			shakes.Add(new Shake(amplitude, frequency, duration, target, amplitudeOverLifetimeCurve));
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.F))
			{
				Add(0.25f, 1f, 2f, CameraShakeTarget.Position, CameraShakeAmplitudeCurve.FadeInOut25);
			}
			if (Input.GetKeyDown(KeyCode.G))
			{
				Add(15f, 1f, 2f, CameraShakeTarget.Rotation, CameraShakeAmplitudeCurve.FadeInOut25);
			}
			Input.GetKey(KeyCode.H);
			Vector3 zero = Vector3.zero;
			Vector3 zero2 = Vector3.zero;
			for (int i = 0; i < shakes.Count; i++)
			{
				shakes[i].Update();
				if (shakes[i].target == CameraShakeTarget.Position)
				{
					zero += shakes[i].noise;
				}
				else
				{
					zero2 += shakes[i].noise;
				}
			}
			shakes.RemoveAll((Shake x) => !x.IsAlive());
			base.transform.localPosition = Vector3.SmoothDamp(base.transform.localPosition, zero, ref smoothDampPositionVelocity, smoothDampTime);
			Vector3 localEulerAngles = base.transform.localEulerAngles;
			localEulerAngles.x = Mathf.SmoothDampAngle(localEulerAngles.x, zero2.x, ref smoothDampRotationVelocityX, smoothDampTime);
			localEulerAngles.y = Mathf.SmoothDampAngle(localEulerAngles.y, zero2.y, ref smoothDampRotationVelocityY, smoothDampTime);
			localEulerAngles.z = Mathf.SmoothDampAngle(localEulerAngles.z, zero2.z, ref smoothDampRotationVelocityZ, smoothDampTime);
			base.transform.localEulerAngles = localEulerAngles;
		}
	}
}
