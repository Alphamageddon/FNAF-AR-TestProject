public class PhantomWalkState
{
	public readonly PhantomWalkData Config;

	public bool HasManifested;

	public float AnimatedSpeed;

	public float JumpscareRange;

	public float BurnTimeAllowed;

	public float BurnTime;

	public bool HasTriggeredCounter;

	public bool WasBurning;

	public void Reset()
	{
		HasManifested = false;
		HasTriggeredCounter = false;
		WasBurning = false;
		BurnTimeAllowed = 0f;
		BurnTime = 0f;
		AnimatedSpeed = 0f;
		JumpscareRange = 0f;
	}

	public PhantomWalkState(PhantomWalkData config)
	{
		Config = config;
	}
}
