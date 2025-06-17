using System.Collections.Generic;

namespace UnityEngine.SpatialTracking
{
	internal class TrackedPoseDriverDataDescription
	{
		internal struct PoseData
		{
			public List<string> PoseNames;

			public List<TrackedPoseDriver.TrackedPose> Poses;
		}

		internal static List<PoseData> DeviceData = new List<PoseData>
		{
			new PoseData
			{
				PoseNames = new List<string> { "Left Eye", "Right Eye", "Center Eye - HMD Reference", "Head", "Color Camera" },
				Poses = new List<TrackedPoseDriver.TrackedPose>
				{
					TrackedPoseDriver.TrackedPose.LeftEye,
					TrackedPoseDriver.TrackedPose.RightEye,
					TrackedPoseDriver.TrackedPose.Center,
					TrackedPoseDriver.TrackedPose.Head,
					TrackedPoseDriver.TrackedPose.ColorCamera
				}
			},
			new PoseData
			{
				PoseNames = new List<string> { "Left Controller", "Right Controller" },
				Poses = new List<TrackedPoseDriver.TrackedPose>
				{
					TrackedPoseDriver.TrackedPose.LeftPose,
					TrackedPoseDriver.TrackedPose.RightPose
				}
			},
			new PoseData
			{
				PoseNames = new List<string> { "Device Pose" },
				Poses = new List<TrackedPoseDriver.TrackedPose> { TrackedPoseDriver.TrackedPose.RemotePose }
			}
		};
	}
}
