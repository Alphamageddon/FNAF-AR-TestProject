public class FootstepsData
{
	public readonly FootstepConfigData Walk;

	public readonly FootstepConfigData Run;

	public FootstepsData(ATTACK_DATA.Footsteps rawSettings)
	{
		Walk = new FootstepConfigData(rawSettings.Walk);
		Run = new FootstepConfigData(rawSettings.Run);
	}
}
