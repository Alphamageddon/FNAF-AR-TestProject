public class AnimatronicNoiseMeterData
{
	public readonly float ViewingAngle;

	public readonly float TimeToJumpScare;

	public readonly float TimerDecayPerTick;

	public AnimatronicNoiseMeterData(ATTACK_DATA.AnimatronicNoiseMeter rawSettings)
	{
		ViewingAngle = rawSettings.ViewingAngle;
		TimeToJumpScare = rawSettings.TimeToJumpScare;
		TimerDecayPerTick = rawSettings.TimerDecayPerTick;
	}
}
