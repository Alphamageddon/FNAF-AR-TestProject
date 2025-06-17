using System.Collections.Generic;
using UnityEngine;

namespace Unity.AI.Navigation
{
	[ExecuteAlways]
	[AddComponentMenu("Navigation/NavMeshModifier", 32)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.1/manual/NavMeshModifier.html")]
	public class NavMeshModifier : MonoBehaviour
	{
		[SerializeField]
		private bool m_OverrideArea;

		[SerializeField]
		private int m_Area;

		[SerializeField]
		private bool m_OverrideGenerateLinks;

		[SerializeField]
		private bool m_GenerateLinks;

		[SerializeField]
		private bool m_IgnoreFromBuild;

		[SerializeField]
		private bool m_ApplyToChildren = true;

		[SerializeField]
		private List<int> m_AffectedAgents = new List<int>(new int[1] { -1 });

		private static readonly List<NavMeshModifier> s_NavMeshModifiers = new List<NavMeshModifier>();

		public bool overrideArea
		{
			get
			{
				return m_OverrideArea;
			}
			set
			{
				m_OverrideArea = value;
			}
		}

		public int area
		{
			get
			{
				return m_Area;
			}
			set
			{
				m_Area = value;
			}
		}

		public bool overrideGenerateLinks
		{
			get
			{
				return m_OverrideGenerateLinks;
			}
			set
			{
				m_OverrideGenerateLinks = value;
			}
		}

		public bool generateLinks
		{
			get
			{
				return m_GenerateLinks;
			}
			set
			{
				m_GenerateLinks = value;
			}
		}

		public bool ignoreFromBuild
		{
			get
			{
				return m_IgnoreFromBuild;
			}
			set
			{
				m_IgnoreFromBuild = value;
			}
		}

		public bool applyToChildren
		{
			get
			{
				return m_ApplyToChildren;
			}
			set
			{
				m_ApplyToChildren = value;
			}
		}

		public static List<NavMeshModifier> activeModifiers => s_NavMeshModifiers;

		private void OnEnable()
		{
			if (!s_NavMeshModifiers.Contains(this))
			{
				s_NavMeshModifiers.Add(this);
			}
		}

		private void OnDisable()
		{
			s_NavMeshModifiers.Remove(this);
		}

		public bool AffectsAgentType(int agentTypeID)
		{
			if (m_AffectedAgents.Count == 0)
			{
				return false;
			}
			if (m_AffectedAgents[0] == -1)
			{
				return true;
			}
			return m_AffectedAgents.IndexOf(agentTypeID) != -1;
		}
	}
}
