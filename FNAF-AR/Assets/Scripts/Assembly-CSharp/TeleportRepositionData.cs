public class TeleportRepositionData
{
	public readonly RangeData AngleFromCamera;

	public readonly RangeData DistanceFromCamera;

	public TeleportRepositionData(ATTACK_DATA.TeleportReposition rawSettings)
	{
		AngleFromCamera = new RangeData(rawSettings.AngleFromCamera.Min, rawSettings.AngleFromCamera.Max);
		DistanceFromCamera = new RangeData(rawSettings.DistanceFromCamera.Min, rawSettings.DistanceFromCamera.Max);
	}

	public TeleportRepositionData(RangeData angleFromCamera, RangeData distanceFromCamera)
	{
		AngleFromCamera = angleFromCamera;
		DistanceFromCamera = distanceFromCamera;
	}
}
