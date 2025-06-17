using System;

public class SubEntityMovement
{
	public readonly SubEntityData.SubEntityMovementType MovementType;

	public readonly bool FollowPlayerForward;

	public readonly RangeData CircleDegreesPerSecond;

	public readonly RangeData CircleDistance;

	public readonly float ApproachStartDistance;

	public readonly float ApproachEndDistance;

	public readonly IntRangeData TeleportPositions;

	public readonly RangeData TeleportCooldown;

	public readonly bool HideIfMaskOff;

	public readonly RangeData StationaryDistance;

	public readonly RangeData StationaryAngleFromCamera;

	public readonly bool UseWorldHeightPosition;

	public SubEntityMovement(SUB_ENTITY_DATA.Movement rawSettings)
	{
		MovementType = (SubEntityData.SubEntityMovementType)Enum.Parse(typeof(SubEntityData.SubEntityMovementType), rawSettings.MovementType);
		FollowPlayerForward = rawSettings.FollowPlayerForward;
		if (rawSettings.CircleDegreesPerSecond != null)
		{
			CircleDegreesPerSecond = new RangeData(rawSettings.CircleDegreesPerSecond.Min, rawSettings.CircleDegreesPerSecond.Max);
		}
		if (rawSettings.CircleDistance != null)
		{
			CircleDistance = new RangeData(rawSettings.CircleDistance.Min, rawSettings.CircleDistance.Max);
		}
		ApproachStartDistance = rawSettings.ApproachStartDistance;
		ApproachEndDistance = rawSettings.ApproachEndDistance;
		if (rawSettings.TeleportPositions != null)
		{
			TeleportPositions = new IntRangeData(rawSettings.TeleportPositions.Min, rawSettings.TeleportPositions.Max);
		}
		if (rawSettings.TeleportCooldown != null)
		{
			TeleportCooldown = new RangeData(rawSettings.TeleportCooldown.Min, rawSettings.TeleportCooldown.Max);
		}
		HideIfMaskOff = rawSettings.HideIfMaskOff;
		if (rawSettings.StationaryDistance != null)
		{
			StationaryDistance = new RangeData(rawSettings.StationaryDistance.Min, rawSettings.StationaryDistance.Max);
		}
		if (rawSettings.StationaryAngleFromCamera != null)
		{
			StationaryAngleFromCamera = new RangeData(rawSettings.StationaryAngleFromCamera.Min, rawSettings.StationaryAngleFromCamera.Max);
		}
		UseWorldHeightPosition = rawSettings.UseWorldHeightPosition;
	}
}
