using System.Collections.Generic;
using UnityEngine.SpatialTracking;

namespace UnityEngine.XR.LegacyInputHelpers
{
	public class TransitionArmModel : ArmModel
	{
		internal struct ArmModelBlendData
		{
			public ArmModel armModel;

			public float currentBlendAmount;
		}

		[SerializeField]
		private ArmModel m_CurrentArmModelComponent;

		[SerializeField]
		public List<ArmModelTransition> m_ArmModelTransitions = new List<ArmModelTransition>();

		private const int MAX_ACTIVE_TRANSITIONS = 10;

		private const float DROP_TRANSITION_THRESHOLD = 0.035f;

		private const float LERP_CLAMP_THRESHOLD = 0.95f;

		private const float MIN_ANGULAR_VELOCITY = 0.2f;

		private const float ANGULAR_VELOCITY_DIVISOR = 45f;

		internal List<ArmModelBlendData> armModelBlendData = new List<ArmModelBlendData>(10);

		private ArmModelBlendData currentBlendingArmModel;

		public ArmModel currentArmModelComponent
		{
			get
			{
				return m_CurrentArmModelComponent;
			}
			set
			{
				m_CurrentArmModelComponent = value;
			}
		}

		public bool Queue(string key)
		{
			foreach (ArmModelTransition armModelTransition in m_ArmModelTransitions)
			{
				if (armModelTransition.transitionKeyName == key)
				{
					Queue(armModelTransition.armModel);
					return true;
				}
			}
			return false;
		}

		public void Queue(ArmModel newArmModel)
		{
			if (!(newArmModel == null))
			{
				if (m_CurrentArmModelComponent == null)
				{
					m_CurrentArmModelComponent = newArmModel;
				}
				RemoveJustStartingTransitions();
				if (armModelBlendData.Count == 10)
				{
					RemoveOldestTransition();
				}
				ArmModelBlendData item = new ArmModelBlendData
				{
					armModel = newArmModel,
					currentBlendAmount = 0f
				};
				armModelBlendData.Add(item);
			}
		}

		private void RemoveJustStartingTransitions()
		{
			for (int i = 0; i < armModelBlendData.Count; i++)
			{
				if (armModelBlendData[i].currentBlendAmount < 0.035f)
				{
					armModelBlendData.RemoveAt(i);
				}
			}
		}

		private void RemoveOldestTransition()
		{
			armModelBlendData.RemoveAt(0);
		}

		public override PoseDataFlags GetPoseFromProvider(out Pose output)
		{
			if (UpdateBlends())
			{
				output = base.finalPose;
				return PoseDataFlags.Position | PoseDataFlags.Rotation;
			}
			output = Pose.identity;
			return PoseDataFlags.NoData;
		}

		private bool UpdateBlends()
		{
			if (currentArmModelComponent == null)
			{
				return false;
			}
			if (m_CurrentArmModelComponent.OnControllerInputUpdated())
			{
				m_NeckPosition = m_CurrentArmModelComponent.neckPosition;
				m_ElbowPosition = m_CurrentArmModelComponent.elbowPosition;
				m_WristPosition = m_CurrentArmModelComponent.wristPosition;
				m_ControllerPosition = m_CurrentArmModelComponent.controllerPosition;
				m_ElbowRotation = m_CurrentArmModelComponent.elbowRotation;
				m_WristRotation = m_CurrentArmModelComponent.wristRotation;
				m_ControllerRotation = m_CurrentArmModelComponent.controllerRotation;
				if (TryGetAngularVelocity(base.poseSource, out var angVel) && armModelBlendData.Count > 0)
				{
					float t = Mathf.Clamp((angVel.magnitude - 0.2f) / 45f, 0f, 0.1f);
					for (int i = 0; i < armModelBlendData.Count; i++)
					{
						ArmModelBlendData value = armModelBlendData[i];
						value.currentBlendAmount = Mathf.Lerp(value.currentBlendAmount, 1f, t);
						if (value.currentBlendAmount > 0.95f)
						{
							value.currentBlendAmount = 1f;
						}
						else
						{
							value.armModel.OnControllerInputUpdated();
							m_NeckPosition = Vector3.Slerp(base.neckPosition, value.armModel.neckPosition, value.currentBlendAmount);
							m_ElbowPosition = Vector3.Slerp(base.elbowPosition, value.armModel.elbowPosition, value.currentBlendAmount);
							m_WristPosition = Vector3.Slerp(base.wristPosition, value.armModel.wristPosition, value.currentBlendAmount);
							m_ControllerPosition = Vector3.Slerp(base.controllerPosition, value.armModel.controllerPosition, value.currentBlendAmount);
							m_ElbowRotation = Quaternion.Slerp(base.elbowRotation, value.armModel.elbowRotation, value.currentBlendAmount);
							m_WristRotation = Quaternion.Slerp(base.wristRotation, value.armModel.wristRotation, value.currentBlendAmount);
							m_ControllerRotation = Quaternion.Slerp(base.controllerRotation, value.armModel.controllerRotation, value.currentBlendAmount);
						}
						armModelBlendData[i] = value;
						if (value.currentBlendAmount >= 1f)
						{
							m_CurrentArmModelComponent = value.armModel;
							armModelBlendData.RemoveRange(0, i + 1);
						}
					}
				}
				else if (armModelBlendData.Count > 0)
				{
					Debug.LogErrorFormat(base.gameObject, "Unable to get angular acceleration for node");
					return false;
				}
				base.finalPose = new Pose(base.controllerPosition, base.controllerRotation);
				return true;
			}
			return false;
		}
	}
}
