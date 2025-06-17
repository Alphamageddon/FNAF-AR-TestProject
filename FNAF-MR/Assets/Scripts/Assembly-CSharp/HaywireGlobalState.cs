using UnityEngine;

public class HaywireGlobalState
{
	public readonly HaywireData Config;

	public readonly ActivationState CircleState;

	public readonly ActivationState PauseState;

	public readonly ActivationState ChargeState;

	public bool FirstActivationRequest;

	public ActivationState ActiveState;

	public int HaywireCount;

	public readonly SimpleTimer Cooldown;

	public bool IsMultiwireActive;

	public int RemainingActivations;

	public bool UseMultiwire()
	{
		if (Config.Multiwire == null)
		{
			return false;
		}
		return Config.Multiwire.Count.Max > 0;
	}

	public void ResetMultiwire()
	{
		IsMultiwireActive = false;
		RemainingActivations = 0;
	}

	public HaywireGlobalState(HaywireData config)
	{
		Debug.Log("Created global state");
		FirstActivationRequest = true;
		Cooldown = new SimpleTimer();
		Config = config;
		if (Config.Circle != null)
		{
			CircleState = new ActivationState(Config.Circle);
		}
		if (Config.Pause != null)
		{
			PauseState = new ActivationState(Config.Pause);
		}
		if (Config.Charge != null)
		{
			ChargeState = new ActivationState(Config.Charge);
		}
	}
}
