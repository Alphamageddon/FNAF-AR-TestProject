public class AnimatronicState
{
	public readonly bool IsLegacyAnimatronic;

	private bool _enraged;

	public AnimatronicState(AnimatronicConfigData configData)
	{
		IsLegacyAnimatronic = configData.Attack == 0;
		_enraged = false;
	}

	public void SetEnrageState(bool enraged)
	{
		_enraged = enraged;
	}
}
