public class ScavengingAttackProfile
{
	public readonly string Logical;

	public readonly AttackUIData AttackUIData;

	public readonly IntroScreenSettings IntroScreen;

	public readonly ScavengingMovement Movement;

	public readonly BatteryData Battery;

	public readonly float LoseTime;

	public readonly float SearchLockerChance;

	public readonly float SwapDirectionAfterLosePlayerChance;

	public readonly float ShockedStunTime;

	public readonly float ElectrifiedTime;

	public ScavengingAttackProfile(SCAVENGING_ATTACK_DATA.Entry rawSettings)
	{
		Logical = rawSettings.Logical;
		if (rawSettings.UI != null)
		{
			AttackUIData = new AttackUIData(rawSettings.UI);
		}
		if (rawSettings.IntroScreen != null)
		{
			IntroScreen = new IntroScreenSettings(rawSettings.IntroScreen);
		}
		if (rawSettings.Settings != null)
		{
			if (rawSettings.Settings.Movement != null)
			{
				Movement = new ScavengingMovement(rawSettings.Settings.Movement);
			}
			if (rawSettings.Settings.Battery != null)
			{
				Battery = new BatteryData(rawSettings.Settings.Battery);
			}
			LoseTime = rawSettings.Settings.LoseTime;
			SearchLockerChance = rawSettings.Settings.SearchLockerChance;
			SwapDirectionAfterLosePlayerChance = rawSettings.Settings.SwapDirectionAfterLosePlayerChance;
			ShockedStunTime = rawSettings.Settings.ShockedStunTime;
			ElectrifiedTime = rawSettings.Settings.ElectrifiedTime;
		}
	}
}
