using UnityEngine;

public class PauseState
{
	public readonly PauseData Config;

	public Vector3 SavedPosition;

	public Vector3 SavedForward;

	public readonly SimpleTimer HaywireTimer;

	public readonly SimpleTimer SlashTimer;

	public void Reset()
	{
		SavedPosition = Vector3.zero;
		SavedForward = Vector3.forward;
		HaywireTimer.Reset();
		SlashTimer.Reset();
	}

	public PauseState(PauseData config)
	{
		HaywireTimer = new SimpleTimer();
		SlashTimer = new SimpleTimer();
		Config = config;
	}
}
