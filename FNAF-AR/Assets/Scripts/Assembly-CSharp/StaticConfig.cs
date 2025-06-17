public class StaticConfig
{
	public readonly PhaseStaticSettings InitialPause;

	public readonly PhaseStaticSettings Circle;

	public readonly PhaseStaticSettings Pause;

	public readonly PhaseStaticSettings Charge;

	public readonly PhaseStaticSettings PhantomWalk;

	public readonly PhaseStaticSettings Jumpscare;

	public readonly AdditiveStaticSettings WalkFootsteps;

	public readonly AdditiveStaticSettings RunFootsteps;

	public StaticConfig(STATIC_DATA.Entry entry)
	{
		InitialPause = null;
		if (entry.Circle != null)
		{
			Circle = new PhaseStaticSettings(entry.Circle);
		}
		else
		{
			Circle = null;
		}
		if (entry.Pause != null)
		{
			Pause = new PhaseStaticSettings(entry.Pause);
		}
		else
		{
			Pause = null;
		}
		if (entry.Charge != null)
		{
			Charge = new PhaseStaticSettings(entry.Charge);
		}
		else
		{
			Charge = null;
		}
		PhantomWalk = null;
		Jumpscare = null;
		if (entry.WalkFootsteps != null)
		{
			WalkFootsteps = new AdditiveStaticSettings(entry.WalkFootsteps);
		}
		else
		{
			WalkFootsteps = null;
		}
		if (entry.RunFootsteps != null)
		{
			RunFootsteps = new AdditiveStaticSettings(entry.RunFootsteps);
		}
		else
		{
			RunFootsteps = null;
		}
	}
}
