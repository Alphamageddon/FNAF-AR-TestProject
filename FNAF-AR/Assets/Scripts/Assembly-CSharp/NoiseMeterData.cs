public class NoiseMeterData
{
	public readonly PlayerNoiseMeterData PlayerNoiseMeter;

	public readonly AnimatronicNoiseMeterData AnimatronicNoiseMeter;

	public NoiseMeterData(ATTACK_DATA.NoiseMeterSettings rawSettings)
	{
		if (rawSettings.PlayerNoiseMeter != null)
		{
			PlayerNoiseMeter = new PlayerNoiseMeterData(rawSettings.PlayerNoiseMeter);
		}
		if (rawSettings.AnimatronicNoiseMeter != null)
		{
			AnimatronicNoiseMeter = new AnimatronicNoiseMeterData(rawSettings.AnimatronicNoiseMeter);
		}
	}
}
