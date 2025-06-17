using System;
using UnityEngine.Experimental.XR.Interaction;

namespace UnityEngine.SpatialTracking
{
	[Serializable]
	[DefaultExecutionOrder(-30000)]
	[AddComponentMenu("XR/Tracked Pose Driver")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.legacyinputhelpers@2.1/manual/index.html")]
	public class TrackedPoseDriver : MonoBehaviour
	{
		public enum DeviceType
		{
			GenericXRDevice = 0,
			GenericXRController = 1,
			GenericXRRemote = 2
		}

		public enum TrackedPose
		{
			LeftEye = 0,
			RightEye = 1,
			Center = 2,
			Head = 3,
			LeftPose = 4,
			RightPose = 5,
			ColorCamera = 6,
			DepthCameraDeprecated = 7,
			FisheyeCameraDeprected = 8,
			DeviceDeprecated = 9,
			RemotePose = 10
		}

		public enum TrackingType
		{
			RotationAndPosition = 0,
			RotationOnly = 1,
			PositionOnly = 2
		}

		public enum UpdateType
		{
			UpdateAndBeforeRender = 0,
			Update = 1,
			BeforeRender = 2
		}

		[SerializeField]
		private DeviceType m_Device;

		[SerializeField]
		private TrackedPose m_PoseSource = TrackedPose.Center;

		[SerializeField]
		private BasePoseProvider m_PoseProviderComponent;

		[SerializeField]
		private TrackingType m_TrackingType;

		[SerializeField]
		private UpdateType m_UpdateType;

		[SerializeField]
		private bool m_UseRelativeTransform;

		protected Pose m_OriginPose;

		public DeviceType deviceType
		{
			get
			{
				return m_Device;
			}
			internal set
			{
				m_Device = value;
			}
		}

		public TrackedPose poseSource
		{
			get
			{
				return m_PoseSource;
			}
			internal set
			{
				m_PoseSource = value;
			}
		}

		public BasePoseProvider poseProviderComponent
		{
			get
			{
				return m_PoseProviderComponent;
			}
			set
			{
				m_PoseProviderComponent = value;
			}
		}

		public TrackingType trackingType
		{
			get
			{
				return m_TrackingType;
			}
			set
			{
				m_TrackingType = value;
			}
		}

		public UpdateType updateType
		{
			get
			{
				return m_UpdateType;
			}
			set
			{
				m_UpdateType = value;
			}
		}

		public bool UseRelativeTransform
		{
			get
			{
				return m_UseRelativeTransform;
			}
			set
			{
				m_UseRelativeTransform = value;
			}
		}

		public Pose originPose
		{
			get
			{
				return m_OriginPose;
			}
			set
			{
				m_OriginPose = value;
			}
		}

		public bool SetPoseSource(DeviceType deviceType, TrackedPose pose)
		{
			if ((int)deviceType < TrackedPoseDriverDataDescription.DeviceData.Count)
			{
				TrackedPoseDriverDataDescription.PoseData poseData = TrackedPoseDriverDataDescription.DeviceData[(int)deviceType];
				for (int i = 0; i < poseData.Poses.Count; i++)
				{
					if (poseData.Poses[i] == pose)
					{
						this.deviceType = deviceType;
						poseSource = pose;
						return true;
					}
				}
			}
			return false;
		}

		private PoseDataFlags GetPoseData(DeviceType device, TrackedPose poseSource, out Pose resultPose)
		{
			if (!(m_PoseProviderComponent != null))
			{
				return PoseDataSource.GetDataFromSource(poseSource, out resultPose);
			}
			return m_PoseProviderComponent.GetPoseFromProvider(out resultPose);
		}

		private void CacheLocalPosition()
		{
			m_OriginPose.position = base.transform.localPosition;
			m_OriginPose.rotation = base.transform.localRotation;
		}

		private void ResetToCachedLocalPosition()
		{
			SetLocalTransform(m_OriginPose.position, m_OriginPose.rotation, PoseDataFlags.Position | PoseDataFlags.Rotation);
		}

		protected virtual void Awake()
		{
			CacheLocalPosition();
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void OnEnable()
		{
			Application.onBeforeRender += OnBeforeRender;
		}

		protected virtual void OnDisable()
		{
			ResetToCachedLocalPosition();
			Application.onBeforeRender -= OnBeforeRender;
		}

		protected virtual void FixedUpdate()
		{
			if (m_UpdateType == UpdateType.Update || m_UpdateType == UpdateType.UpdateAndBeforeRender)
			{
				PerformUpdate();
			}
		}

		protected virtual void Update()
		{
			if (m_UpdateType == UpdateType.Update || m_UpdateType == UpdateType.UpdateAndBeforeRender)
			{
				PerformUpdate();
			}
		}

		[BeforeRenderOrder(-30000)]
		protected virtual void OnBeforeRender()
		{
			if (m_UpdateType == UpdateType.BeforeRender || m_UpdateType == UpdateType.UpdateAndBeforeRender)
			{
				PerformUpdate();
			}
		}

		protected virtual void SetLocalTransform(Vector3 newPosition, Quaternion newRotation, PoseDataFlags poseFlags)
		{
			if ((m_TrackingType == TrackingType.RotationAndPosition || m_TrackingType == TrackingType.RotationOnly) && (poseFlags & PoseDataFlags.Rotation) > PoseDataFlags.NoData)
			{
				base.transform.localRotation = newRotation;
			}
			if ((m_TrackingType == TrackingType.RotationAndPosition || m_TrackingType == TrackingType.PositionOnly) && (poseFlags & PoseDataFlags.Position) > PoseDataFlags.NoData)
			{
				base.transform.localPosition = newPosition;
			}
		}

		protected Pose TransformPoseByOriginIfNeeded(Pose pose)
		{
			if (m_UseRelativeTransform)
			{
				return pose.GetTransformedBy(m_OriginPose);
			}
			return pose;
		}

		private bool HasStereoCamera()
		{
			Camera component = GetComponent<Camera>();
			if (component != null)
			{
				return component.stereoEnabled;
			}
			return false;
		}

		protected virtual void PerformUpdate()
		{
			if (base.enabled)
			{
				Pose resultPose;
				PoseDataFlags poseData = GetPoseData(m_Device, m_PoseSource, out resultPose);
				if (poseData != PoseDataFlags.NoData)
				{
					Pose pose = TransformPoseByOriginIfNeeded(resultPose);
					SetLocalTransform(pose.position, pose.rotation, poseData);
				}
			}
		}
	}
}
