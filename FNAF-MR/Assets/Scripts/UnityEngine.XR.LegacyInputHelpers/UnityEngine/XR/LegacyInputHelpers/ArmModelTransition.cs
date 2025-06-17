using System;

namespace UnityEngine.XR.LegacyInputHelpers
{
	[Serializable]
	public class ArmModelTransition
	{
		[SerializeField]
		private string m_KeyName;

		[SerializeField]
		private ArmModel m_ArmModel;

		public string transitionKeyName
		{
			get
			{
				return m_KeyName;
			}
			set
			{
				m_KeyName = value;
			}
		}

		public ArmModel armModel
		{
			get
			{
				return m_ArmModel;
			}
			set
			{
				m_ArmModel = value;
			}
		}
	}
}
