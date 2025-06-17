public class ShockerSettings
{
	public float NoBatteryDuration;

	public float ResetBufferTime;

	public readonly bool ContinuousShocker;

	public readonly float ShockerCooldownSeconds;

	public float MissDuration
	{
		get
		{
			if (ContinuousShocker)
			{
				return 0f;
			}
			return 0.4f;
		}
	}

	public float HitDuration
	{
		get
		{
			if (ContinuousShocker)
			{
				return 0f;
			}
			return 0.8f;
		}
	}

	public ShockerSettings(float shockerCooldownSeconds, bool continuousShocker)
	{
		NoBatteryDuration = 0.07f;
		ResetBufferTime = 0f;
		ShockerCooldownSeconds = shockerCooldownSeconds;
		ContinuousShocker = continuousShocker;
	}
}
