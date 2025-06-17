public class ScavengingMovement
{
	public readonly float WalkSpeed;

	public readonly float RunSpeed;

	public readonly float ElectrifiedSpeed;

	public ScavengingMovement(SCAVENGING_ATTACK_DATA.Movement settings)
	{
		WalkSpeed = settings.WalkSpeed;
		RunSpeed = settings.RunSpeed;
		ElectrifiedSpeed = settings.ElectrifiedSpeed;
	}
}
