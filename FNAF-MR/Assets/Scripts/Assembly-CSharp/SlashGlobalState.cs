using UnityEngine;

public class SlashGlobalState
{
	public readonly SlashData Config;

	public readonly ActivationState CircleState;

	public readonly ActivationState PauseState;

	public bool FirstActivationRequest;

	public ActivationState ActiveState;

	public int SlashCount;

	public readonly SimpleTimer Cooldown;

	public bool IsMultislashActive;

	public int RemainingActivations;

	public readonly SimpleTimer HiddenTimer;

	public readonly SimpleTimer LocateTimer;

	public bool UseMultislash()
	{
		if (Config.Multislash == null)
		{
			return false;
		}
		return Config.Multislash.Count.Max > 0;
	}

	public void ResetMultislash()
	{
		IsMultislashActive = false;
		RemainingActivations = 0;
	}

	public void ResetTimers()
	{
		HiddenTimer.Reset();
		LocateTimer.Reset();
	}

	public SlashGlobalState(SlashData config)
	{
		Debug.Log("Created global slash state");
		FirstActivationRequest = true;
		Cooldown = new SimpleTimer();
		Config = config;
		HiddenTimer = new SimpleTimer();
		LocateTimer = new SimpleTimer();
		if (config != null)
		{
			if (Config.Circle != null)
			{
				CircleState = new ActivationState(Config.Circle);
			}
			if (Config.Pause != null)
			{
				PauseState = new ActivationState(Config.Pause);
			}
		}
	}
}
