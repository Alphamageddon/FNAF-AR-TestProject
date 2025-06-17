using System;
using UnityEngine.SpatialTracking;

namespace UnityEngine.Experimental.XR.Interaction
{
	[Serializable]
	public abstract class BasePoseProvider : MonoBehaviour
	{
		public virtual PoseDataFlags GetPoseFromProvider(out Pose output)
		{
			if (TryGetPoseFromProvider(out output))
			{
				return PoseDataFlags.Position | PoseDataFlags.Rotation;
			}
			return PoseDataFlags.NoData;
		}

		[Obsolete("This function is provided for backwards compatibility with the BasePoseProvider found in com.unity.xr.legacyinputhelpers v1.3.X. Please do not implement this function, instead use the new API via GetPoseFromProvider", false)]
		public virtual bool TryGetPoseFromProvider(out Pose output)
		{
			output = Pose.identity;
			return false;
		}
	}
}
