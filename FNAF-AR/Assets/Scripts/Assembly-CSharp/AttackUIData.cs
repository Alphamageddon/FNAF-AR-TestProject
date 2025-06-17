public class AttackUIData
{
	public bool ShowShocker;

	public readonly bool ShowRemnant;

	public readonly bool ShowCollection;

	public readonly bool ShowMask;

	public readonly bool UsePlayerNoiseMeter;

	public readonly bool UseAnimatronicNoiseMeter;

	public readonly bool UseFlashlight;

	public readonly bool UseContinuousShocker;

	public readonly bool UseSwapper;

	public bool ShowBattery;

	public readonly bool ShowBillboard;

	public AttackUIData(ATTACK_DATA.UI rawSettings)
	{
		ShowShocker = rawSettings.UseShocker;
		ShowRemnant = rawSettings.ShowRemnant;
		ShowCollection = rawSettings.ShowCollection;
		ShowMask = rawSettings.UseMask;
		UsePlayerNoiseMeter = rawSettings.UsePlayerNoiseMeter;
		UseAnimatronicNoiseMeter = rawSettings.UseAnimatronicNoiseMeter;
		UseFlashlight = rawSettings.UseFlashlight;
		UseContinuousShocker = rawSettings.UseContinuousShocker;
		UseSwapper = rawSettings.UseSwapper;
		ShowBattery = true;
		ShowBillboard = rawSettings.ShowBillboard;
	}

	public AttackUIData(SCAVENGING_ATTACK_DATA.UI rawSettings)
	{
		ShowShocker = rawSettings.UseShocker;
		ShowRemnant = false;
		ShowCollection = false;
		ShowMask = rawSettings.UseMask;
		UsePlayerNoiseMeter = false;
		UseAnimatronicNoiseMeter = false;
		UseFlashlight = rawSettings.UseFlashlight;
		UseContinuousShocker = false;
		UseSwapper = false;
		ShowBattery = true;
		ShowBillboard = false;
	}

	public AttackUIData(AttackUIData copyProfile)
	{
		ShowShocker = copyProfile.ShowShocker;
		ShowRemnant = copyProfile.ShowRemnant;
		ShowCollection = copyProfile.ShowCollection;
		ShowMask = copyProfile.ShowMask;
		UsePlayerNoiseMeter = copyProfile.UsePlayerNoiseMeter;
		UseAnimatronicNoiseMeter = copyProfile.UseAnimatronicNoiseMeter;
		UseFlashlight = copyProfile.UseFlashlight;
		UseContinuousShocker = copyProfile.UseContinuousShocker;
		UseSwapper = copyProfile.UseSwapper;
		ShowBattery = true;
		ShowBillboard = copyProfile.ShowBillboard;
	}
}
