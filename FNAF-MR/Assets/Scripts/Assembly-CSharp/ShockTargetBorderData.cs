public class ShockTargetBorderData
{
	public readonly float XMin;

	public readonly float XMax;

	public readonly float YMin;

	public readonly float YMax;

	public ShockTargetBorderData(PLUSHSUIT_DATA.ShockTargetBorder rawSettings)
	{
		XMin = (float)rawSettings.XMin;
		XMax = (float)rawSettings.XMax;
		YMin = (float)rawSettings.YMin;
		YMax = (float)rawSettings.YMax;
	}
}
