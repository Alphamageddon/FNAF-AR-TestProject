using System;
using UnityEngine;

namespace VLB
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(VolumetricLightBeam))]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion/")]
	public class DynamicOcclusion : MonoBehaviour
	{
		public class HitResult
		{
			public Vector3 point;

			public Vector3 normal;

			public float distance;

			private Collider2D collider2D;

			private Collider collider3D;

			public bool hasCollider
			{
				get
				{
					if (!collider2D)
					{
						return collider3D;
					}
					return true;
				}
			}

			public HitResult(RaycastHit hit3D)
			{
				point = hit3D.point;
				normal = hit3D.normal;
				distance = hit3D.distance;
				collider3D = hit3D.collider;
				collider2D = null;
			}

			public HitResult(RaycastHit2D hit2D)
			{
				point = hit2D.point;
				normal = hit2D.normal;
				distance = hit2D.distance;
				collider2D = hit2D.collider;
				collider3D = null;
			}

			public HitResult()
			{
				point = Vector3.zero;
				normal = Vector3.zero;
				distance = 0f;
				collider2D = null;
				collider3D = null;
			}
		}

		private enum Direction
		{
			Up = 0,
			Right = 1,
			Down = 2,
			Left = 3
		}

		public OccluderDimensions dimensions;

		public LayerMask layerMask = Consts.DynOcclusionLayerMaskDefault;

		public bool considerTriggers;

		public float minOccluderArea;

		public int waitFrameCount = 3;

		public float minSurfaceRatio = 0.5f;

		public float maxSurfaceDot = 0.25f;

		public PlaneAlignment planeAlignment;

		public float planeOffset = 0.1f;

		private VolumetricLightBeam m_Master;

		private int m_FrameCountToWait;

		private float m_RangeMultiplier = 1f;

		private uint m_PrevNonSubHitDirectionId;

		private QueryTriggerInteraction queryTriggerInteraction
		{
			get
			{
				if (!considerTriggers)
				{
					return QueryTriggerInteraction.Ignore;
				}
				return QueryTriggerInteraction.Collide;
			}
		}

		private float raycastMaxDistance => m_Master.fallOffEnd * m_RangeMultiplier * base.transform.lossyScale.z;

		private void OnValidate()
		{
			minOccluderArea = Mathf.Max(minOccluderArea, 0f);
			waitFrameCount = Mathf.Clamp(waitFrameCount, 1, 60);
		}

		private void OnEnable()
		{
			m_Master = GetComponent<VolumetricLightBeam>();
		}

		private void OnDisable()
		{
			SetHitNull();
		}

		private void Start()
		{
			if (Application.isPlaying)
			{
				TriggerZone component = GetComponent<TriggerZone>();
				if ((bool)component)
				{
					m_RangeMultiplier = Mathf.Max(1f, component.rangeMultiplier);
				}
			}
		}

		private void LateUpdate()
		{
			if (m_FrameCountToWait <= 0)
			{
				ProcessRaycasts();
				m_FrameCountToWait = waitFrameCount;
			}
			m_FrameCountToWait--;
		}

		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			float num = angleDiff * 0.5f;
			return Quaternion.Euler(UnityEngine.Random.Range(0f - num, num), UnityEngine.Random.Range(0f - num, num), UnityEngine.Random.Range(0f - num, num)) * direction;
		}

		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			if (dimensions != OccluderDimensions.Occluders2D)
			{
				return GetBestHit3D(rayPos, rayDir);
			}
			return GetBestHit2D(rayPos, rayDir);
		}

		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			RaycastHit[] array = Physics.RaycastAll(rayPos, rayDir, raycastMaxDistance, layerMask.value, queryTriggerInteraction);
			int num = -1;
			float num2 = float.MaxValue;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].collider.bounds.GetMaxArea2D() >= minOccluderArea && array[i].distance < num2)
				{
					num2 = array[i].distance;
					num = i;
				}
			}
			if (num != -1)
			{
				return new HitResult(array[num]);
			}
			return new HitResult();
		}

		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			RaycastHit2D[] array = Physics2D.RaycastAll(new Vector2(rayPos.x, rayPos.y), new Vector2(rayDir.x, rayDir.y), raycastMaxDistance, layerMask.value);
			int num = -1;
			float num2 = float.MaxValue;
			for (int i = 0; i < array.Length; i++)
			{
				if ((considerTriggers || !array[i].collider.isTrigger) && array[i].collider.bounds.GetMaxArea2D() >= minOccluderArea && array[i].distance < num2)
				{
					num2 = array[i].distance;
					num = i;
				}
			}
			if (num != -1)
			{
				return new HitResult(array[num]);
			}
			return new HitResult();
		}

		private Vector3 GetDirection(uint dirInt)
		{
			dirInt %= (uint)Enum.GetValues(typeof(Direction)).Length;
			return dirInt switch
			{
				0u => base.transform.up, 
				1u => base.transform.right, 
				2u => -base.transform.up, 
				3u => -base.transform.right, 
				_ => Vector3.zero, 
			};
		}

		private bool IsHitValid(HitResult hit)
		{
			if (hit.hasCollider)
			{
				return Vector3.Dot(hit.normal, -base.transform.forward) >= maxSurfaceDot;
			}
			return false;
		}

		private void ProcessRaycasts()
		{
			HitResult hitResult = GetBestHit(base.transform.position, base.transform.forward);
			if (IsHitValid(hitResult))
			{
				if (minSurfaceRatio > 0.5f)
				{
					for (uint num = 0u; num < (uint)Enum.GetValues(typeof(Direction)).Length; num++)
					{
						Vector3 direction = GetDirection(num + m_PrevNonSubHitDirectionId);
						Vector3 vector = base.transform.position + direction * m_Master.coneRadiusStart * (minSurfaceRatio * 2f - 1f);
						Vector3 vector2 = base.transform.position + base.transform.forward * m_Master.fallOffEnd + direction * m_Master.coneRadiusEnd * (minSurfaceRatio * 2f - 1f);
						HitResult bestHit = GetBestHit(vector, vector2 - vector);
						if (IsHitValid(bestHit))
						{
							if (bestHit.distance > hitResult.distance)
							{
								hitResult = bestHit;
							}
							continue;
						}
						m_PrevNonSubHitDirectionId = num;
						SetHitNull();
						return;
					}
				}
				SetHit(hitResult);
			}
			else
			{
				SetHitNull();
			}
		}

		private void SetHit(HitResult hit)
		{
			PlaneAlignment planeAlignment = this.planeAlignment;
			if (planeAlignment != PlaneAlignment.Surface && planeAlignment == PlaneAlignment.Beam)
			{
				SetClippingPlane(new Plane(-base.transform.forward, hit.point));
			}
			else
			{
				SetClippingPlane(new Plane(hit.normal, hit.point));
			}
		}

		private void SetHitNull()
		{
			SetClippingPlaneOff();
		}

		private void SetClippingPlane(Plane planeWS)
		{
			planeWS = planeWS.TranslateCustom(planeWS.normal * planeOffset);
			m_Master.SetClippingPlane(planeWS);
		}

		private void SetClippingPlaneOff()
		{
			m_Master.SetClippingPlaneOff();
		}
	}
}
