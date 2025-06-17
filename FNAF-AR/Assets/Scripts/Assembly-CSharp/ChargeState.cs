public class ChargeState
{
	public readonly ChargeData Config;

	public readonly SimpleTimer HaywireTimer;

	public int NumShocksRemaining;

	public bool WillJumpscare;

	public bool StartedDecloak;

	public bool StartedCloak;

	public float JumpscareRange;

	public float DecloakRange;

	public float CloakRange;

	public float BlockExtraBatteryRange;

	public bool CanDeflectCharge;

	public bool WasDeflectionConditionEverFalse;

	public bool DeflectionConditionTrue;

	public bool WillSkipDelayedJumpscare;

	public void Reset()
	{
		HaywireTimer.Reset();
		StartedCloak = false;
		WillJumpscare = false;
		StartedDecloak = false;
		NumShocksRemaining = 0;
		CanDeflectCharge = false;
		WasDeflectionConditionEverFalse = false;
		DeflectionConditionTrue = false;
		WillSkipDelayedJumpscare = false;
		JumpscareRange = 0f;
		DecloakRange = 0f;
		CloakRange = 0f;
		BlockExtraBatteryRange = 0f;
	}

	public ChargeState(ChargeData config)
	{
		HaywireTimer = new SimpleTimer();
		Config = config;
	}
}
