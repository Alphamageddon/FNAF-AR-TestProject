public class PhantomSettingsData
{
	public readonly bool UseGlobalMovement;

	public readonly bool AndroidOcclusionEnabled;

	public readonly bool AndroidOcclusionBlocksFlashlight;

	public PhantomSettingsData(ATTACK_DATA.PhantomSettings rawSettings)
	{
		UseGlobalMovement = rawSettings.UseGlobalMovement;
		AndroidOcclusionEnabled = rawSettings.AndroidOcclusionEnabled;
		AndroidOcclusionBlocksFlashlight = rawSettings.AndroidOcclusionBlocksFlashlight;
	}
}
