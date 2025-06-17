using System;
using System.Collections.Generic;
using UnityEngine;

namespace MirzaBeig.Scripting.Effects
{
	[RequireComponent(typeof(ParticleSystem))]
	[AddComponentMenu("Effects/Particle Plexus")]
	public class ParticlePlexus : MonoBehaviour
	{
		public float maxDistance = 1f;

		public int maxConnections = 5;

		public int maxLineRenderers = 100;

		[Space]
		[Range(0f, 1f)]
		public float widthFromParticle = 0.125f;

		[Space]
		[Range(0f, 1f)]
		public float colourFromParticle = 1f;

		[Range(0f, 1f)]
		public float alphaFromParticle = 1f;

		[Space]
		public AnimationCurve alphaOverNormalizedDistance = AnimationCurve.Linear(0f, 1f, 1f, 1f);

		private ParticleSystem particleSystem;

		private ParticleSystem.Particle[] particles;

		private Vector3[] particlePositions;

		private Color[] particleColours;

		private float[] particleSizes;

		private ParticleSystem.MainModule particleSystemMainModule;

		[Space]
		public LineRenderer lineRendererTemplate;

		private List<LineRenderer> lineRenderers = new List<LineRenderer>();

		private Transform _transform;

		[Header("Triangle Mesh Settings")]
		public MeshFilter trianglesMeshFilter;

		private Mesh trianglesMesh;

		private List<int[]> allConnectedParticles = new List<int[]>();

		[Space]
		[Range(0f, 1f)]
		public float maxDistanceTriangleBias = 1f;

		[Space]
		public bool trianglesDistanceCheck;

		[Space]
		[Range(0f, 1f)]
		public float triangleColourFromParticle = 1f;

		[Range(0f, 1f)]
		public float triangleAlphaFromParticle = 1f;

		[Header("General Performance Settings")]
		[Range(0f, 1f)]
		public float delay;

		private float timer;

		public bool alwaysUpdate;

		private bool visible;

		private void Start()
		{
			particleSystem = GetComponent<ParticleSystem>();
			particleSystemMainModule = particleSystem.main;
			_transform = base.transform;
			if ((bool)trianglesMeshFilter)
			{
				trianglesMesh = new Mesh();
				trianglesMeshFilter.mesh = trianglesMesh;
			}
		}

		private void OnDisable()
		{
			for (int i = 0; i < lineRenderers.Count; i++)
			{
				lineRenderers[i].enabled = false;
			}
		}

		private void OnBecameVisible()
		{
			visible = true;
		}

		private void OnBecameInvisible()
		{
			visible = false;
		}

		private void LateUpdate()
		{
			if ((bool)trianglesMeshFilter)
			{
				switch (particleSystemMainModule.simulationSpace)
				{
				case ParticleSystemSimulationSpace.World:
					trianglesMeshFilter.transform.position = Vector3.zero;
					break;
				case ParticleSystemSimulationSpace.Local:
					trianglesMeshFilter.transform.position = base.transform.position;
					trianglesMeshFilter.transform.rotation = base.transform.rotation;
					break;
				case ParticleSystemSimulationSpace.Custom:
					trianglesMeshFilter.transform.position = particleSystemMainModule.customSimulationSpace.position;
					trianglesMeshFilter.transform.rotation = particleSystemMainModule.customSimulationSpace.rotation;
					break;
				}
			}
			else if ((bool)trianglesMesh)
			{
				trianglesMesh.Clear();
			}
			int num = lineRenderers.Count;
			if (num > maxLineRenderers)
			{
				for (int i = maxLineRenderers; i < num; i++)
				{
					UnityEngine.Object.Destroy(lineRenderers[i].gameObject);
				}
				lineRenderers.RemoveRange(maxLineRenderers, num - maxLineRenderers);
				num -= num - maxLineRenderers;
			}
			if (!alwaysUpdate && !visible)
			{
				return;
			}
			int maxParticles = particleSystemMainModule.maxParticles;
			if (particles == null || particles.Length < maxParticles)
			{
				particles = new ParticleSystem.Particle[maxParticles];
				particlePositions = new Vector3[maxParticles];
				particleColours = new Color[maxParticles];
				particleSizes = new float[maxParticles];
			}
			float deltaTime = Time.deltaTime;
			timer += deltaTime;
			if (!(timer >= delay))
			{
				return;
			}
			timer = 0f;
			int num2 = 0;
			allConnectedParticles.Clear();
			if (maxConnections > 0 && maxLineRenderers > 0)
			{
				particleSystem.GetParticles(particles);
				int particleCount = particleSystem.particleCount;
				float num3 = maxDistance * maxDistance;
				ParticleSystemSimulationSpace simulationSpace = particleSystemMainModule.simulationSpace;
				ParticleSystemScalingMode scalingMode = particleSystemMainModule.scalingMode;
				Transform customSimulationSpace = particleSystemMainModule.customSimulationSpace;
				Color startColor = lineRendererTemplate.startColor;
				Color endColor = lineRendererTemplate.endColor;
				float a = lineRendererTemplate.startWidth * lineRendererTemplate.widthMultiplier;
				float a2 = lineRendererTemplate.endWidth * lineRendererTemplate.widthMultiplier;
				for (int j = 0; j < particleCount; j++)
				{
					particlePositions[j] = particles[j].position;
					particleColours[j] = particles[j].GetCurrentColor(particleSystem);
					particleSizes[j] = particles[j].GetCurrentSize(particleSystem);
				}
				Vector3 vector = default(Vector3);
				if (simulationSpace == ParticleSystemSimulationSpace.World)
				{
					for (int k = 0; k < particleCount; k++)
					{
						if (num2 == maxLineRenderers)
						{
							break;
						}
						Color b = particleColours[k];
						Color startColor2 = Color.LerpUnclamped(startColor, b, colourFromParticle);
						float num4 = (startColor2.a = Mathf.LerpUnclamped(startColor.a, b.a, alphaFromParticle));
						float startWidth = Mathf.LerpUnclamped(a, particleSizes[k], widthFromParticle);
						int num5 = 0;
						int[] array = new int[maxConnections + 1];
						for (int l = k + 1; l < particleCount; l++)
						{
							vector.x = particlePositions[k].x - particlePositions[l].x;
							vector.y = particlePositions[k].y - particlePositions[l].y;
							vector.z = particlePositions[k].z - particlePositions[l].z;
							float num6 = vector.x * vector.x + vector.y * vector.y + vector.z * vector.z;
							if (num6 <= num3)
							{
								LineRenderer item;
								if (num2 == num)
								{
									item = UnityEngine.Object.Instantiate(lineRendererTemplate, _transform, worldPositionStays: false);
									lineRenderers.Add(item);
									num++;
								}
								item = lineRenderers[num2];
								item.enabled = true;
								item.SetPosition(0, particlePositions[k]);
								item.SetPosition(1, particlePositions[l]);
								float num7 = alphaOverNormalizedDistance.Evaluate(num6 / num3);
								startColor2.a = num4 * num7;
								item.startColor = startColor2;
								b = particleColours[l];
								Color endColor2 = Color.LerpUnclamped(endColor, b, colourFromParticle);
								endColor2.a = Mathf.LerpUnclamped(endColor.a, b.a, alphaFromParticle);
								item.endColor = endColor2;
								item.startWidth = startWidth;
								item.endWidth = Mathf.LerpUnclamped(a2, particleSizes[l], widthFromParticle);
								num2++;
								num5++;
								array[num5] = l;
								if (num5 == maxConnections || num2 == maxLineRenderers)
								{
									break;
								}
							}
						}
						if (num5 >= 2)
						{
							array[0] = k;
							allConnectedParticles.Add(array);
						}
					}
				}
				else
				{
					Vector3 zero = Vector3.zero;
					Quaternion identity = Quaternion.identity;
					Vector3 one = Vector3.one;
					Transform transform = _transform;
					switch (simulationSpace)
					{
					case ParticleSystemSimulationSpace.Local:
						zero = transform.position;
						identity = transform.rotation;
						one = transform.localScale;
						break;
					case ParticleSystemSimulationSpace.Custom:
						transform = customSimulationSpace;
						zero = transform.position;
						identity = transform.rotation;
						one = transform.localScale;
						break;
					default:
						throw new NotSupportedException($"Unsupported scaling mode '{simulationSpace}'.");
					}
					Vector3 vector2 = Vector3.zero;
					Vector3 vector3 = Vector3.zero;
					for (int m = 0; m < particleCount; m++)
					{
						if (num2 == maxLineRenderers)
						{
							break;
						}
						if (simulationSpace == ParticleSystemSimulationSpace.Local || simulationSpace == ParticleSystemSimulationSpace.Custom)
						{
							switch (scalingMode)
							{
							case ParticleSystemScalingMode.Hierarchy:
								vector2 = transform.TransformPoint(particlePositions[m]);
								break;
							case ParticleSystemScalingMode.Local:
								vector2.x = particlePositions[m].x * one.x;
								vector2.y = particlePositions[m].y * one.y;
								vector2.z = particlePositions[m].z * one.z;
								vector2 = identity * vector2;
								vector2.x += zero.x;
								vector2.y += zero.y;
								vector2.z += zero.z;
								break;
							case ParticleSystemScalingMode.Shape:
								vector2 = identity * particlePositions[m];
								vector2.x += zero.x;
								vector2.y += zero.y;
								vector2.z += zero.z;
								break;
							default:
								throw new NotSupportedException($"Unsupported scaling mode '{scalingMode}'.");
							}
						}
						Color b2 = particleColours[m];
						Color startColor3 = Color.LerpUnclamped(startColor, b2, colourFromParticle);
						float num8 = (startColor3.a = Mathf.LerpUnclamped(startColor.a, b2.a, alphaFromParticle));
						float startWidth2 = Mathf.LerpUnclamped(a, particleSizes[m], widthFromParticle);
						int num9 = 0;
						int[] array2 = new int[maxConnections + 1];
						for (int n = m + 1; n < particleCount; n++)
						{
							if (simulationSpace == ParticleSystemSimulationSpace.Local || simulationSpace == ParticleSystemSimulationSpace.Custom)
							{
								switch (scalingMode)
								{
								case ParticleSystemScalingMode.Hierarchy:
									vector3 = transform.TransformPoint(particlePositions[n]);
									break;
								case ParticleSystemScalingMode.Local:
									vector3.x = particlePositions[n].x * one.x;
									vector3.y = particlePositions[n].y * one.y;
									vector3.z = particlePositions[n].z * one.z;
									vector3 = identity * vector3;
									vector3.x += zero.x;
									vector3.y += zero.y;
									vector3.z += zero.z;
									break;
								case ParticleSystemScalingMode.Shape:
									vector3 = identity * particlePositions[n];
									vector3.x += zero.x;
									vector3.y += zero.y;
									vector3.z += zero.z;
									break;
								default:
									throw new NotSupportedException($"Unsupported scaling mode '{scalingMode}'.");
								}
							}
							vector.x = particlePositions[m].x - particlePositions[n].x;
							vector.y = particlePositions[m].y - particlePositions[n].y;
							vector.z = particlePositions[m].z - particlePositions[n].z;
							float num10 = vector.x * vector.x + vector.y * vector.y + vector.z * vector.z;
							if (num10 <= num3)
							{
								LineRenderer item2;
								if (num2 == num)
								{
									item2 = UnityEngine.Object.Instantiate(lineRendererTemplate, _transform, worldPositionStays: false);
									lineRenderers.Add(item2);
									num++;
								}
								item2 = lineRenderers[num2];
								item2.enabled = true;
								item2.SetPosition(0, vector2);
								item2.SetPosition(1, vector3);
								float num11 = alphaOverNormalizedDistance.Evaluate(num10 / num3);
								startColor3.a = num8 * num11;
								item2.startColor = startColor3;
								b2 = particleColours[n];
								Color endColor3 = Color.LerpUnclamped(endColor, b2, colourFromParticle);
								endColor3.a = Mathf.LerpUnclamped(endColor.a, b2.a, alphaFromParticle) * num11;
								item2.endColor = endColor3;
								item2.startWidth = startWidth2;
								item2.endWidth = Mathf.LerpUnclamped(a2, particleSizes[n], widthFromParticle);
								num2++;
								num9++;
								array2[num9] = n;
								if (num9 == maxConnections || num2 == maxLineRenderers)
								{
									break;
								}
							}
						}
						if (num9 >= 2)
						{
							array2[0] = m;
							allConnectedParticles.Add(array2);
						}
					}
				}
			}
			for (int num12 = num2; num12 < num; num12++)
			{
				if (lineRenderers[num12].enabled)
				{
					lineRenderers[num12].enabled = false;
				}
			}
			if (!trianglesMeshFilter)
			{
				return;
			}
			int num13 = allConnectedParticles.Count * 3;
			Vector3[] array3 = new Vector3[num13];
			int[] array4 = new int[num13];
			Vector2[] array5 = new Vector2[num13];
			Color[] array6 = new Color[num13];
			float num14 = maxDistance * maxDistance * maxDistanceTriangleBias;
			Vector3 vector6 = default(Vector3);
			for (int num15 = 0; num15 < allConnectedParticles.Count; num15++)
			{
				int[] array7 = allConnectedParticles[num15];
				float num16 = 0f;
				if (trianglesDistanceCheck)
				{
					Vector3 vector4 = particlePositions[array7[1]];
					Vector3 vector5 = particlePositions[array7[2]];
					vector6.x = vector4.x - vector5.x;
					vector6.y = vector4.y - vector5.y;
					vector6.z = vector4.z - vector5.z;
					num16 = vector6.x * vector6.x + vector6.y * vector6.y + vector6.z * vector6.z;
				}
				if (num16 < num14)
				{
					int num17 = num15 * 3;
					array3[num17] = particlePositions[array7[0]];
					array3[num17 + 1] = particlePositions[array7[1]];
					array3[num17 + 2] = particlePositions[array7[2]];
					array5[num17] = new Vector2(0f, 0f);
					array5[num17 + 1] = new Vector2(0f, 1f);
					array5[num17 + 2] = new Vector2(1f, 1f);
					array4[num17] = num17;
					array4[num17 + 1] = num17 + 1;
					array4[num17 + 2] = num17 + 2;
					array6[num17] = particleColours[array7[0]];
					array6[num17 + 1] = particleColours[array7[1]];
					array6[num17 + 2] = particleColours[array7[2]];
					array6[num17] = Color.LerpUnclamped(Color.white, particleColours[array7[0]], triangleColourFromParticle);
					array6[num17 + 1] = Color.LerpUnclamped(Color.white, particleColours[array7[1]], triangleColourFromParticle);
					array6[num17 + 2] = Color.LerpUnclamped(Color.white, particleColours[array7[2]], triangleColourFromParticle);
					array6[num17].a = Mathf.LerpUnclamped(1f, particleColours[array7[0]].a, triangleAlphaFromParticle);
					array6[num17 + 1].a = Mathf.LerpUnclamped(1f, particleColours[array7[1]].a, triangleAlphaFromParticle);
					array6[num17 + 2].a = Mathf.LerpUnclamped(1f, particleColours[array7[2]].a, triangleAlphaFromParticle);
				}
			}
			trianglesMesh.Clear();
			trianglesMesh.vertices = array3;
			trianglesMesh.uv = array5;
			trianglesMesh.triangles = array4;
			trianglesMesh.colors = array6;
		}
	}
}
