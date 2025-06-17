public class FootstepConfigData
{
	public readonly float EffectDelay;

	public readonly CameraShakeData CameraShake;

	public FootstepConfigData(ATTACK_DATA.Walk rawSettings)
	{
		EffectDelay = rawSettings.EffectDelay;
		CameraShake = new CameraShakeData(rawSettings.CameraShake);
	}

	public FootstepConfigData(ATTACK_DATA.Run rawSettings)
	{
		EffectDelay = rawSettings.EffectDelay;
		CameraShake = new CameraShakeData(rawSettings.CameraShake);
	}
}
