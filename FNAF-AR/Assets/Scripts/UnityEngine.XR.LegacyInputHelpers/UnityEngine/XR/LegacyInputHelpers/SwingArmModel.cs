namespace UnityEngine.XR.LegacyInputHelpers
{
	public class SwingArmModel : ArmModel
	{
		[Tooltip("Portion of controller rotation applied to the shoulder joint.")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_ShoulderRotationRatio = 0.5f;

		[Tooltip("Portion of controller rotation applied to the elbow joint.")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_ElbowRotationRatio = 0.3f;

		[Tooltip("Portion of controller rotation applied to the wrist joint.")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_WristRotationRatio = 0.2f;

		[SerializeField]
		private Vector2 m_JointShiftAngle = new Vector2(160f, 180f);

		[Tooltip("Exponent applied to the joint shift ratio to control the curve of the shift.")]
		[Range(1f, 20f)]
		[SerializeField]
		private float m_JointShiftExponent = 6f;

		[Tooltip("Portion of controller rotation applied to the shoulder joint when the controller is backwards.")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_ShiftedShoulderRotationRatio = 0.1f;

		[Tooltip("Portion of controller rotation applied to the elbow joint when the controller is backwards.")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_ShiftedElbowRotationRatio = 0.4f;

		[Tooltip("Portion of controller rotation applied to the wrist joint when the controller is backwards.")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_ShiftedWristRotationRatio = 0.5f;

		public float shoulderRotationRatio
		{
			get
			{
				return m_ShoulderRotationRatio;
			}
			set
			{
				m_ShoulderRotationRatio = value;
			}
		}

		public float elbowRotationRatio
		{
			get
			{
				return m_ElbowRotationRatio;
			}
			set
			{
				m_ElbowRotationRatio = value;
			}
		}

		public float wristRotationRatio
		{
			get
			{
				return m_WristRotationRatio;
			}
			set
			{
				m_WristRotationRatio = value;
			}
		}

		public float minJointShiftAngle
		{
			get
			{
				return m_JointShiftAngle.x;
			}
			set
			{
				m_JointShiftAngle.x = value;
			}
		}

		public float maxJointShiftAngle
		{
			get
			{
				return m_JointShiftAngle.y;
			}
			set
			{
				m_JointShiftAngle.y = value;
			}
		}

		public float jointShiftExponent
		{
			get
			{
				return m_JointShiftExponent;
			}
			set
			{
				m_JointShiftExponent = value;
			}
		}

		public float shiftedShoulderRotationRatio
		{
			get
			{
				return m_ShiftedShoulderRotationRatio;
			}
			set
			{
				m_ShiftedShoulderRotationRatio = value;
			}
		}

		public float shiftedElbowRotationRatio
		{
			get
			{
				return m_ShiftedElbowRotationRatio;
			}
			set
			{
				m_ShiftedElbowRotationRatio = value;
			}
		}

		public float shiftedWristRotationRatio
		{
			get
			{
				return m_ShiftedWristRotationRatio;
			}
			set
			{
				m_ShiftedWristRotationRatio = value;
			}
		}

		protected override void CalculateFinalJointRotations(Quaternion controllerOrientation, Quaternion xyRotation, Quaternion lerpRotation)
		{
			float num = Quaternion.Angle(xyRotation, Quaternion.identity);
			float num2 = maxJointShiftAngle - minJointShiftAngle;
			float t = Mathf.Pow(Mathf.Clamp01((num - minJointShiftAngle) / num2), m_JointShiftExponent);
			float t2 = Mathf.Lerp(m_ShoulderRotationRatio, m_ShiftedShoulderRotationRatio, t);
			float t3 = Mathf.Lerp(m_ElbowRotationRatio, m_ShiftedElbowRotationRatio, t);
			float t4 = Mathf.Lerp(m_WristRotationRatio, m_ShiftedWristRotationRatio, t);
			Quaternion quaternion = Quaternion.Lerp(Quaternion.identity, xyRotation, t2);
			Quaternion quaternion2 = Quaternion.Lerp(Quaternion.identity, xyRotation, t3);
			Quaternion quaternion3 = Quaternion.Lerp(Quaternion.identity, xyRotation, t4);
			Quaternion quaternion4 = m_TorsoRotation * quaternion;
			m_ElbowRotation = quaternion4 * quaternion2;
			m_WristRotation = base.elbowRotation * quaternion3;
			m_ControllerRotation = m_TorsoRotation * controllerOrientation;
			m_TorsoRotation = quaternion4;
		}
	}
}
