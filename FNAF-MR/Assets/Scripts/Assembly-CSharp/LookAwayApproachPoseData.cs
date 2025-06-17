public class LookAwayApproachPoseData
{
	public readonly int StartPoseCount;

	public readonly int InChairPoseCount;

	public readonly int OnFloorPoseCount;

	public readonly int BehindDoorLeftPoseCount;

	public readonly int BehindDoorRightPoseCount;

	public readonly int BehindRubblePoseCount;

	public readonly int FinalPoseCount;

	public LookAwayApproachPoseData(PLUSHSUIT_DATA.LookAwayApproachPose rawSettings)
	{
		StartPoseCount = rawSettings.StartPoseCount;
		InChairPoseCount = rawSettings.InChairPoseCount;
		OnFloorPoseCount = rawSettings.OnFloorPoseCount;
		BehindDoorLeftPoseCount = rawSettings.BehindDoorLeftPoseCount;
		BehindDoorRightPoseCount = rawSettings.BehindDoorRightPoseCount;
		BehindRubblePoseCount = rawSettings.BehindRubblePoseCount;
		FinalPoseCount = rawSettings.FinalPoseCount;
	}
}
