using UnityEngine;

namespace Unity.AI.Navigation
{
	public enum CollectObjects
	{
		[InspectorName("All Game Objects")]
		All = 0,
		[InspectorName("Volume")]
		Volume = 1,
		[InspectorName("Current Object Hierarchy")]
		Children = 2,
		[InspectorName("NavMeshModifier Component Only")]
		MarkedWithModifier = 3
	}
}
