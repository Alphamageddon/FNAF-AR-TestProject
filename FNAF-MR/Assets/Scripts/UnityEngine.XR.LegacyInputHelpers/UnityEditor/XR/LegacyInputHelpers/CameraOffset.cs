using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

namespace UnityEditor.XR.LegacyInputHelpers
{
	[AddComponentMenu("XR/Camera Offset")]
	public class CameraOffset : MonoBehaviour
	{
		private const float k_DefaultCameraYOffset = 1.36144f;

		[SerializeField]
		[Tooltip("GameObject to move to desired height off the floor (defaults to this object if none provided).")]
		private GameObject m_CameraFloorOffsetObject;

		[SerializeField]
		[Tooltip("What the user wants the tracking origin mode to be")]
		private UserRequestedTrackingMode m_RequestedTrackingMode;

		[SerializeField]
		[Tooltip("Sets the type of tracking origin to use for this Rig. Tracking origins identify where 0,0,0 is in the world of tracking.")]
		private TrackingOriginModeFlags m_TrackingOriginMode;

		[SerializeField]
		[Tooltip("Set if the XR experience is Room Scale or Stationary.")]
		private TrackingSpaceType m_TrackingSpace;

		[SerializeField]
		[Tooltip("Camera Height to be used when in Device tracking space.")]
		private float m_CameraYOffset = 1.36144f;

		private bool m_CameraInitialized;

		private bool m_CameraInitializing;

		private static List<XRInputSubsystem> s_InputSubsystems = new List<XRInputSubsystem>();

		public GameObject cameraFloorOffsetObject
		{
			get
			{
				return m_CameraFloorOffsetObject;
			}
			set
			{
				m_CameraFloorOffsetObject = value;
				UpdateTrackingOrigin(m_TrackingOriginMode);
			}
		}

		public UserRequestedTrackingMode requestedTrackingMode
		{
			get
			{
				return m_RequestedTrackingMode;
			}
			set
			{
				m_RequestedTrackingMode = value;
				TryInitializeCamera();
			}
		}

		public TrackingOriginModeFlags TrackingOriginMode
		{
			get
			{
				return m_TrackingOriginMode;
			}
			set
			{
				m_TrackingOriginMode = value;
				TryInitializeCamera();
			}
		}

		[Obsolete("CameraOffset.trackingSpace is obsolete.  Please use CameraOffset.trackingOriginMode.")]
		public TrackingSpaceType trackingSpace
		{
			get
			{
				return m_TrackingSpace;
			}
			set
			{
				m_TrackingSpace = value;
				TryInitializeCamera();
			}
		}

		public float cameraYOffset
		{
			get
			{
				return m_CameraYOffset;
			}
			set
			{
				m_CameraYOffset = value;
				UpdateTrackingOrigin(m_TrackingOriginMode);
			}
		}

		private void UpgradeTrackingSpaceToTrackingOriginMode()
		{
			if (m_TrackingOriginMode == TrackingOriginModeFlags.Unknown && m_TrackingSpace <= TrackingSpaceType.RoomScale)
			{
				switch (m_TrackingSpace)
				{
				case TrackingSpaceType.RoomScale:
					m_TrackingOriginMode = TrackingOriginModeFlags.Floor;
					break;
				case TrackingSpaceType.Stationary:
					m_TrackingOriginMode = TrackingOriginModeFlags.Device;
					break;
				}
				m_TrackingSpace = (TrackingSpaceType)3;
			}
		}

		private void Awake()
		{
			if (!m_CameraFloorOffsetObject)
			{
				Debug.LogWarning("No camera container specified for XR Rig, using attached GameObject");
				m_CameraFloorOffsetObject = base.gameObject;
			}
		}

		private void Start()
		{
			TryInitializeCamera();
		}

		private void OnValidate()
		{
			UpgradeTrackingSpaceToTrackingOriginMode();
			TryInitializeCamera();
		}

		private void TryInitializeCamera()
		{
			m_CameraInitialized = SetupCamera();
			if (!m_CameraInitialized & !m_CameraInitializing)
			{
				StartCoroutine(RepeatInitializeCamera());
			}
		}

		private IEnumerator RepeatInitializeCamera()
		{
			m_CameraInitializing = true;
			yield return null;
			while (!m_CameraInitialized)
			{
				m_CameraInitialized = SetupCamera();
				yield return null;
			}
			m_CameraInitializing = false;
		}

		private bool SetupCamera()
		{
			SubsystemManager.GetInstances(s_InputSubsystems);
			bool flag = true;
			if (s_InputSubsystems.Count != 0)
			{
				for (int i = 0; i < s_InputSubsystems.Count; i++)
				{
					bool flag2 = SetupCamera(s_InputSubsystems[i]);
					if (flag2)
					{
						s_InputSubsystems[i].trackingOriginUpdated -= OnTrackingOriginUpdated;
						s_InputSubsystems[i].trackingOriginUpdated += OnTrackingOriginUpdated;
					}
					flag = flag && flag2;
				}
			}
			else if (m_RequestedTrackingMode == UserRequestedTrackingMode.Floor)
			{
				SetupCameraLegacy(TrackingSpaceType.RoomScale);
			}
			else
			{
				SetupCameraLegacy(TrackingSpaceType.Stationary);
			}
			return flag;
		}

		private bool SetupCamera(XRInputSubsystem subsystem)
		{
			if (subsystem == null)
			{
				return false;
			}
			bool flag = false;
			TrackingOriginModeFlags trackingOriginMode = subsystem.GetTrackingOriginMode();
			TrackingOriginModeFlags supportedTrackingOriginModes = subsystem.GetSupportedTrackingOriginModes();
			TrackingOriginModeFlags trackingOriginModeFlags = TrackingOriginModeFlags.Unknown;
			if (m_RequestedTrackingMode == UserRequestedTrackingMode.Default)
			{
				trackingOriginModeFlags = trackingOriginMode;
			}
			else if (m_RequestedTrackingMode == UserRequestedTrackingMode.Device)
			{
				trackingOriginModeFlags = TrackingOriginModeFlags.Device;
			}
			else if (m_RequestedTrackingMode == UserRequestedTrackingMode.Floor)
			{
				trackingOriginModeFlags = TrackingOriginModeFlags.Floor;
			}
			else
			{
				Debug.LogWarning("Unknown Requested Tracking Mode");
			}
			switch (trackingOriginModeFlags)
			{
			case TrackingOriginModeFlags.Floor:
				if ((supportedTrackingOriginModes & TrackingOriginModeFlags.Floor) == 0)
				{
					Debug.LogWarning("CameraOffset.SetupCamera: Attempting to set the tracking space to Floor, but that is not supported by the SDK.");
				}
				else
				{
					flag = subsystem.TrySetTrackingOriginMode(trackingOriginModeFlags);
				}
				break;
			case TrackingOriginModeFlags.Device:
				if ((supportedTrackingOriginModes & TrackingOriginModeFlags.Device) == 0)
				{
					Debug.LogWarning("CameraOffset.SetupCamera: Attempting to set the tracking space to Device, but that is not supported by the SDK.");
				}
				else
				{
					flag = subsystem.TrySetTrackingOriginMode(trackingOriginModeFlags) && subsystem.TryRecenter();
				}
				break;
			}
			if (flag)
			{
				UpdateTrackingOrigin(subsystem.GetTrackingOriginMode());
			}
			return flag;
		}

		private void UpdateTrackingOrigin(TrackingOriginModeFlags trackingOriginModeFlags)
		{
			m_TrackingOriginMode = trackingOriginModeFlags;
			if (m_CameraFloorOffsetObject != null)
			{
				m_CameraFloorOffsetObject.transform.localPosition = new Vector3(m_CameraFloorOffsetObject.transform.localPosition.x, (m_TrackingOriginMode == TrackingOriginModeFlags.Device) ? cameraYOffset : 0f, m_CameraFloorOffsetObject.transform.localPosition.z);
			}
		}

		private void OnTrackingOriginUpdated(XRInputSubsystem subsystem)
		{
			UpdateTrackingOrigin(subsystem.GetTrackingOriginMode());
		}

		private void OnDestroy()
		{
			SubsystemManager.GetInstances(s_InputSubsystems);
			foreach (XRInputSubsystem s_InputSubsystem in s_InputSubsystems)
			{
				s_InputSubsystem.trackingOriginUpdated -= OnTrackingOriginUpdated;
			}
		}

		private void SetupCameraLegacy(TrackingSpaceType trackingSpace)
		{
			float y = m_CameraYOffset;
			XRDevice.SetTrackingSpaceType(trackingSpace);
			switch (trackingSpace)
			{
			case TrackingSpaceType.Stationary:
				InputTracking.Recenter();
				break;
			case TrackingSpaceType.RoomScale:
				y = 0f;
				break;
			}
			m_TrackingSpace = trackingSpace;
			if ((bool)m_CameraFloorOffsetObject)
			{
				m_CameraFloorOffsetObject.transform.localPosition = new Vector3(m_CameraFloorOffsetObject.transform.localPosition.x, y, m_CameraFloorOffsetObject.transform.localPosition.z);
			}
		}
	}
}
