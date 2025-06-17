using System.Collections.Generic;
using UnityEngine.Experimental.XR.Interaction;
using UnityEngine.SpatialTracking;

namespace UnityEngine.XR.LegacyInputHelpers
{
	public class ArmModel : BasePoseProvider
	{
		private Pose m_FinalPose;

		[SerializeField]
		private XRNode m_PoseSource = XRNode.LeftHand;

		[SerializeField]
		private XRNode m_HeadPoseSource = XRNode.CenterEye;

		[SerializeField]
		private Vector3 m_ElbowRestPosition = DEFAULT_ELBOW_REST_POSITION;

		[SerializeField]
		private Vector3 m_WristRestPosition = DEFAULT_WRIST_REST_POSITION;

		[SerializeField]
		private Vector3 m_ControllerRestPosition = DEFAULT_CONTROLLER_REST_POSITION;

		[SerializeField]
		private Vector3 m_ArmExtensionOffset = DEFAULT_ARM_EXTENSION_OFFSET;

		[Range(0f, 1f)]
		[SerializeField]
		private float m_ElbowBendRatio = 0.6f;

		[SerializeField]
		private bool m_IsLockedToNeck = true;

		protected Vector3 m_NeckPosition;

		protected Vector3 m_ElbowPosition;

		protected Quaternion m_ElbowRotation;

		protected Vector3 m_WristPosition;

		protected Quaternion m_WristRotation;

		protected Vector3 m_ControllerPosition;

		protected Quaternion m_ControllerRotation;

		protected Vector3 m_HandedMultiplier;

		protected Vector3 m_TorsoDirection;

		protected Quaternion m_TorsoRotation;

		protected static readonly Vector3 DEFAULT_ELBOW_REST_POSITION = new Vector3(0.195f, -0.5f, 0.005f);

		protected static readonly Vector3 DEFAULT_WRIST_REST_POSITION = new Vector3(0f, 0f, 0.25f);

		protected static readonly Vector3 DEFAULT_CONTROLLER_REST_POSITION = new Vector3(0f, 0f, 0.05f);

		protected static readonly Vector3 DEFAULT_ARM_EXTENSION_OFFSET = new Vector3(-0.13f, 0.14f, 0.08f);

		protected const float DEFAULT_ELBOW_BEND_RATIO = 0.6f;

		protected const float EXTENSION_WEIGHT = 0.4f;

		protected static readonly Vector3 SHOULDER_POSITION = new Vector3(0.17f, -0.2f, -0.03f);

		protected static readonly Vector3 NECK_OFFSET = new Vector3(0f, 0.075f, 0.08f);

		protected const float MIN_EXTENSION_ANGLE = 7f;

		protected const float MAX_EXTENSION_ANGLE = 60f;

		private List<XRNodeState> xrNodeStateListOrientation = new List<XRNodeState>();

		private List<XRNodeState> xrNodeStateListPosition = new List<XRNodeState>();

		private List<XRNodeState> xrNodeStateListAngularAcceleration = new List<XRNodeState>();

		private List<XRNodeState> xrNodeStateListAngularVelocity = new List<XRNodeState>();

		public Pose finalPose
		{
			get
			{
				return m_FinalPose;
			}
			set
			{
				m_FinalPose = value;
			}
		}

		public XRNode poseSource
		{
			get
			{
				return m_PoseSource;
			}
			set
			{
				m_PoseSource = value;
			}
		}

		public XRNode headGameObject
		{
			get
			{
				return m_HeadPoseSource;
			}
			set
			{
				m_HeadPoseSource = value;
			}
		}

		public Vector3 elbowRestPosition
		{
			get
			{
				return m_ElbowRestPosition;
			}
			set
			{
				m_ElbowRestPosition = value;
			}
		}

		public Vector3 wristRestPosition
		{
			get
			{
				return m_WristRestPosition;
			}
			set
			{
				m_WristRestPosition = value;
			}
		}

		public Vector3 controllerRestPosition
		{
			get
			{
				return m_ControllerRestPosition;
			}
			set
			{
				m_ControllerRestPosition = value;
			}
		}

		public Vector3 armExtensionOffset
		{
			get
			{
				return m_ArmExtensionOffset;
			}
			set
			{
				m_ArmExtensionOffset = value;
			}
		}

		public float elbowBendRatio
		{
			get
			{
				return m_ElbowBendRatio;
			}
			set
			{
				m_ElbowBendRatio = value;
			}
		}

		public bool isLockedToNeck
		{
			get
			{
				return m_IsLockedToNeck;
			}
			set
			{
				m_IsLockedToNeck = value;
			}
		}

		public Vector3 neckPosition => m_NeckPosition;

		public Vector3 shoulderPosition => m_NeckPosition + m_TorsoRotation * Vector3.Scale(SHOULDER_POSITION, m_HandedMultiplier);

		public Quaternion shoulderRotation => m_TorsoRotation;

		public Vector3 elbowPosition => m_ElbowPosition;

		public Quaternion elbowRotation => m_ElbowRotation;

		public Vector3 wristPosition => m_WristPosition;

		public Quaternion wristRotation => m_WristRotation;

		public Vector3 controllerPosition => m_ControllerPosition;

		public Quaternion controllerRotation => m_ControllerRotation;

		public override PoseDataFlags GetPoseFromProvider(out Pose output)
		{
			if (OnControllerInputUpdated())
			{
				output = finalPose;
				return PoseDataFlags.Position | PoseDataFlags.Rotation;
			}
			output = Pose.identity;
			return PoseDataFlags.NoData;
		}

		protected virtual void OnEnable()
		{
			UpdateTorsoDirection(forceImmediate: true);
			OnControllerInputUpdated();
		}

		protected virtual void OnDisable()
		{
		}

		public virtual bool OnControllerInputUpdated()
		{
			UpdateHandedness();
			if (UpdateTorsoDirection(forceImmediate: false) && UpdateNeckPosition() && ApplyArmModel())
			{
				return true;
			}
			return false;
		}

		protected virtual void UpdateHandedness()
		{
			m_HandedMultiplier.Set(0f, 1f, 1f);
			if (m_PoseSource == XRNode.RightHand || m_PoseSource == XRNode.TrackingReference)
			{
				m_HandedMultiplier.x = 1f;
			}
			else if (m_PoseSource == XRNode.LeftHand)
			{
				m_HandedMultiplier.x = -1f;
			}
		}

		protected virtual bool UpdateTorsoDirection(bool forceImmediate)
		{
			Vector3 forward = default(Vector3);
			if (TryGetForwardVector(m_HeadPoseSource, out forward))
			{
				forward.y = 0f;
				forward.Normalize();
				Vector3 angularAccel;
				if (forceImmediate)
				{
					m_TorsoDirection = forward;
				}
				else if (TryGetAngularAcceleration(poseSource, out angularAccel))
				{
					float t = Mathf.Clamp((angularAccel.magnitude - 0.2f) / 45f, 0f, 0.1f);
					m_TorsoDirection = Vector3.Slerp(m_TorsoDirection, forward, t);
				}
				m_TorsoRotation = Quaternion.FromToRotation(Vector3.forward, m_TorsoDirection);
				return true;
			}
			return false;
		}

		protected virtual bool UpdateNeckPosition()
		{
			if (m_IsLockedToNeck && TryGetPosition(m_HeadPoseSource, out m_NeckPosition))
			{
				return ApplyInverseNeckModel(m_NeckPosition, out m_NeckPosition);
			}
			m_NeckPosition = Vector3.zero;
			return true;
		}

		protected virtual bool ApplyArmModel()
		{
			SetUntransformedJointPositions();
			if (GetControllerRotation(out var rotation, out var xyRotation, out var xAngle))
			{
				float extensionRatio = CalculateExtensionRatio(xAngle);
				ApplyExtensionOffset(extensionRatio);
				Quaternion lerpRotation = CalculateLerpRotation(xyRotation, extensionRatio);
				CalculateFinalJointRotations(rotation, xyRotation, lerpRotation);
				ApplyRotationToJoints();
				m_FinalPose.position = m_ControllerPosition;
				m_FinalPose.rotation = m_ControllerRotation;
				return true;
			}
			return false;
		}

		protected virtual void SetUntransformedJointPositions()
		{
			m_ElbowPosition = Vector3.Scale(m_ElbowRestPosition, m_HandedMultiplier);
			m_WristPosition = Vector3.Scale(m_WristRestPosition, m_HandedMultiplier);
			m_ControllerPosition = Vector3.Scale(m_ControllerRestPosition, m_HandedMultiplier);
		}

		protected virtual float CalculateExtensionRatio(float xAngle)
		{
			return Mathf.Clamp((xAngle - 7f) / 53f, 0f, 1f);
		}

		protected virtual void ApplyExtensionOffset(float extensionRatio)
		{
			Vector3 vector = Vector3.Scale(m_ArmExtensionOffset, m_HandedMultiplier);
			m_ElbowPosition += vector * extensionRatio;
		}

		protected virtual Quaternion CalculateLerpRotation(Quaternion xyRotation, float extensionRatio)
		{
			float num = Quaternion.Angle(xyRotation, Quaternion.identity);
			float num2 = 1f - Mathf.Pow(num / 180f, 6f);
			float num3 = 1f - m_ElbowBendRatio + m_ElbowBendRatio * extensionRatio * 0.4f;
			num3 *= num2;
			return Quaternion.Lerp(Quaternion.identity, xyRotation, num3);
		}

		protected virtual void CalculateFinalJointRotations(Quaternion controllerOrientation, Quaternion xyRotation, Quaternion lerpRotation)
		{
			m_ElbowRotation = m_TorsoRotation * Quaternion.Inverse(lerpRotation) * xyRotation;
			m_WristRotation = m_ElbowRotation * lerpRotation;
			m_ControllerRotation = m_TorsoRotation * controllerOrientation;
		}

		protected virtual void ApplyRotationToJoints()
		{
			m_ElbowPosition = m_NeckPosition + m_TorsoRotation * m_ElbowPosition;
			m_WristPosition = m_ElbowPosition + m_ElbowRotation * m_WristPosition;
			m_ControllerPosition = m_WristPosition + m_WristRotation * m_ControllerPosition;
		}

		protected virtual bool ApplyInverseNeckModel(Vector3 headPosition, out Vector3 calculatedPosition)
		{
			Quaternion rotation = default(Quaternion);
			if (TryGetRotation(m_HeadPoseSource, out rotation))
			{
				Vector3 vector = rotation * NECK_OFFSET - NECK_OFFSET.y * Vector3.up;
				headPosition -= vector;
				calculatedPosition = headPosition;
				return true;
			}
			calculatedPosition = Vector3.zero;
			return false;
		}

		protected bool TryGetForwardVector(XRNode node, out Vector3 forward)
		{
			Pose pose = default(Pose);
			if (TryGetRotation(node, out pose.rotation) && TryGetPosition(node, out pose.position))
			{
				forward = pose.forward;
				return true;
			}
			forward = Vector3.zero;
			return false;
		}

		protected bool TryGetRotation(XRNode node, out Quaternion rotation)
		{
			InputTracking.GetNodeStates(xrNodeStateListOrientation);
			int count = xrNodeStateListOrientation.Count;
			for (int i = 0; i < count; i++)
			{
				XRNodeState xRNodeState = xrNodeStateListOrientation[i];
				if (xRNodeState.nodeType == node && xRNodeState.TryGetRotation(out rotation))
				{
					return true;
				}
			}
			rotation = Quaternion.identity;
			return false;
		}

		protected bool TryGetPosition(XRNode node, out Vector3 position)
		{
			InputTracking.GetNodeStates(xrNodeStateListPosition);
			int count = xrNodeStateListPosition.Count;
			for (int i = 0; i < count; i++)
			{
				XRNodeState xRNodeState = xrNodeStateListPosition[i];
				if (xRNodeState.nodeType == node && xRNodeState.TryGetPosition(out position))
				{
					return true;
				}
			}
			position = Vector3.zero;
			return false;
		}

		protected bool TryGetAngularAcceleration(XRNode node, out Vector3 angularAccel)
		{
			InputTracking.GetNodeStates(xrNodeStateListAngularAcceleration);
			int count = xrNodeStateListAngularAcceleration.Count;
			for (int i = 0; i < count; i++)
			{
				XRNodeState xRNodeState = xrNodeStateListAngularAcceleration[i];
				if (xRNodeState.nodeType == node && xRNodeState.TryGetAngularAcceleration(out angularAccel))
				{
					return true;
				}
			}
			angularAccel = Vector3.zero;
			return false;
		}

		protected bool TryGetAngularVelocity(XRNode node, out Vector3 angVel)
		{
			InputTracking.GetNodeStates(xrNodeStateListAngularVelocity);
			int count = xrNodeStateListAngularVelocity.Count;
			for (int i = 0; i < count; i++)
			{
				XRNodeState xRNodeState = xrNodeStateListAngularVelocity[i];
				if (xRNodeState.nodeType == node && xRNodeState.TryGetAngularVelocity(out angVel))
				{
					return true;
				}
			}
			angVel = Vector3.zero;
			return false;
		}

		protected bool GetControllerRotation(out Quaternion rotation, out Quaternion xyRotation, out float xAngle)
		{
			if (TryGetRotation(poseSource, out rotation))
			{
				rotation = Quaternion.Inverse(m_TorsoRotation) * rotation;
				Vector3 vector = rotation * Vector3.forward;
				xAngle = 90f - Vector3.Angle(vector, Vector3.up);
				xyRotation = Quaternion.FromToRotation(Vector3.forward, vector);
				return true;
			}
			rotation = Quaternion.identity;
			xyRotation = Quaternion.identity;
			xAngle = 0f;
			return false;
		}
	}
}
