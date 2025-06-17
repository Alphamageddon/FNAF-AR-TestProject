using UnityEngine;

public abstract class BaseGlimpseActivator
{
	protected readonly GlimpseData Config;

	protected readonly float CloakTime;

	protected bool GlimpseActive;

	protected readonly GlimpseEffect GlimpseEffect;

	protected readonly SimpleTimer Cooldown;

	protected float MaxGlimpseTime
	{
		get
		{
			if (Config.CloakDelayTime == null)
			{
				return CloakTime;
			}
			return CloakTime + Config.CloakDelayTime.Max;
		}
	}

	public virtual void Reset(Blackboard blackboard)
	{
		GlimpseActive = false;
		GlimpseEffect.EndGlimpse(blackboard);
		Cooldown.Reset();
	}

	public abstract void Update(Blackboard blackboard, float remainingAvailableTime);

	protected float GetRandomDistance()
	{
		return Random.Range(Config.Distance.Min, Config.Distance.Max);
	}

	protected float GetRandomCloakDelayTime()
	{
		if (Config.CloakDelayTime != null)
		{
			return Random.Range(Config.CloakDelayTime.Min, Config.CloakDelayTime.Max);
		}
		return 0f;
	}

	protected float GetRandomExpireTime()
	{
		return Random.Range(Config.ExpireTime.Min, Config.ExpireTime.Max);
	}

	protected void StartCooldown()
	{
		Cooldown.StartTimer(Random.Range(Config.Cooldown.Min, Config.Cooldown.Max));
	}

	protected void UpdateActiveGlimpseEffect(Blackboard blackboard)
	{
		if (GlimpseActive)
		{
			if (GlimpseEffect.IsFinished())
			{
				GlimpseActive = false;
			}
			else
			{
				GlimpseEffect.Update(blackboard);
			}
		}
	}

	protected BaseGlimpseActivator(GlimpseData config, CloakSettings cloakConfig)
	{
		GlimpseEffect = new GlimpseEffect();
		Cooldown = new SimpleTimer();
		Config = config;
		CloakTime = cloakConfig.CloakTime;
	}
}
