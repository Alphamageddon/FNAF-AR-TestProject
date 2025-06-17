using System.Collections.Generic;
using UnityEngine.XR;

namespace UnityEngine.SpatialTracking
{
	public static class PoseDataSource
	{
		internal static List<XRNodeState> nodeStates = new List<XRNodeState>();

		internal static PoseDataFlags GetNodePoseData(XRNode node, out Pose resultPose)
		{
			PoseDataFlags poseDataFlags = PoseDataFlags.NoData;
			InputTracking.GetNodeStates(nodeStates);
			foreach (XRNodeState nodeState in nodeStates)
			{
				if (nodeState.nodeType == node)
				{
					if (nodeState.TryGetPosition(out resultPose.position))
					{
						poseDataFlags |= PoseDataFlags.Position;
					}
					if (nodeState.TryGetRotation(out resultPose.rotation))
					{
						poseDataFlags |= PoseDataFlags.Rotation;
					}
					return poseDataFlags;
				}
			}
			resultPose = Pose.identity;
			return poseDataFlags;
		}

		public static bool TryGetDataFromSource(TrackedPoseDriver.TrackedPose poseSource, out Pose resultPose)
		{
			return GetDataFromSource(poseSource, out resultPose) == (PoseDataFlags.Position | PoseDataFlags.Rotation);
		}

		public static PoseDataFlags GetDataFromSource(TrackedPoseDriver.TrackedPose poseSource, out Pose resultPose)
		{
			switch (poseSource)
			{
			case TrackedPoseDriver.TrackedPose.RemotePose:
			{
				PoseDataFlags nodePoseData = GetNodePoseData(XRNode.RightHand, out resultPose);
				if (nodePoseData == PoseDataFlags.NoData)
				{
					return GetNodePoseData(XRNode.LeftHand, out resultPose);
				}
				return nodePoseData;
			}
			case TrackedPoseDriver.TrackedPose.LeftEye:
				return GetNodePoseData(XRNode.LeftEye, out resultPose);
			case TrackedPoseDriver.TrackedPose.RightEye:
				return GetNodePoseData(XRNode.RightEye, out resultPose);
			case TrackedPoseDriver.TrackedPose.Head:
				return GetNodePoseData(XRNode.Head, out resultPose);
			case TrackedPoseDriver.TrackedPose.Center:
				return GetNodePoseData(XRNode.CenterEye, out resultPose);
			case TrackedPoseDriver.TrackedPose.LeftPose:
				return GetNodePoseData(XRNode.LeftHand, out resultPose);
			case TrackedPoseDriver.TrackedPose.RightPose:
				return GetNodePoseData(XRNode.RightHand, out resultPose);
			case TrackedPoseDriver.TrackedPose.ColorCamera:
				return GetNodePoseData(XRNode.CenterEye, out resultPose);
			default:
				Debug.LogWarningFormat("Unable to retrieve pose data for poseSource: {0}", poseSource.ToString());
				resultPose = Pose.identity;
				return PoseDataFlags.NoData;
			}
		}
	}
}
