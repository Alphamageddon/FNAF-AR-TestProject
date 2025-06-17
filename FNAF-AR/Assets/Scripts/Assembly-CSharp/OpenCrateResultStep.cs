using UnityEngine;

public class OpenCrateResultStep : BaseResultStep
{
	private readonly LootDomain _lootDomain;

	private bool _hasBeenClicked;

	private readonly SimpleTimer _expireTimer;

	public OpenCrateResultStep(ResultStepConfig config)
		: base(config)
	{
		_expireTimer = new SimpleTimer();
		_lootDomain = MasterDomain.GetDomain().LootDomain;
	}

	public override bool IsComplete()
	{
		TryToExpire();
		if (base.HasStarted)
		{
			return _hasBeenClicked;
		}
		return false;
	}

	protected override void StartStep()
	{
		_hasBeenClicked = false;
		_expireTimer.StartTimer(Config.timeoutTime);
		Debug.Log("CALLED SHOW CACHED LOOT REWAAAAARDS!!");
		_lootDomain.LootRewardsManager.ShowCachedLootRewards(OnDismiss);
	}

	private void OnDismiss()
	{
		if (Config.button != null)
		{
			Config.button.onClick.Invoke();
		}
		_hasBeenClicked = true;
	}

	private void OnOptionalButtonTapped()
	{
	}

	private void TryToExpire()
	{
		if (_expireTimer.Started && _expireTimer.IsExpired())
		{
			_ = _expireTimer;
			OnDismiss();
		}
	}
}
