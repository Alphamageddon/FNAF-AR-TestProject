public class ScavengingGlobalState
{
	public readonly SimpleTimer StunnedTimer;

	public readonly SimpleTimer ElectrifiedTimer;

	public ScavengingGlobalState(ScavengingAttackProfile config)
	{
		StunnedTimer = new SimpleTimer();
		ElectrifiedTimer = new SimpleTimer();
	}
}
