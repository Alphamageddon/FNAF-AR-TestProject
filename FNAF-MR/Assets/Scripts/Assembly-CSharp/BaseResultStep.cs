using UnityEngine;

public abstract class BaseResultStep
{
	public class ConditionalSettings
	{
		public bool IsNewBestStreak;

		public int NumRewards;

		public int StartingStreak;

		public bool AllowAds;

		public int NumRewardCrates;
	}

	public class StartupSettings
	{
		public float LastStepStartTime;

		public float EarliestActiveEndTime;

		public float AllCompleteTime;
	}

	protected readonly ResultStepConfig Config;

	protected bool HasStarted { get; set; }

	protected BaseResultStep(ResultStepConfig config)
	{
		Config = config;
	}

	public abstract bool IsComplete();

	protected abstract void StartStep();

	public bool ShouldSkipStep(ConditionalSettings settings)
	{
		if (settings != null && Config.executionCondition <= ResultStepConfig.Condition.HasAtLeastOneCrateReward)
		{
			switch (Config.executionCondition)
			{
			case ResultStepConfig.Condition.AlwaysExecute:
				return false;
			case ResultStepConfig.Condition.IsNewBestStreak:
				return !settings.IsNewBestStreak;
			case ResultStepConfig.Condition.IsNotNewBestStreak:
				return settings.IsNewBestStreak;
			case ResultStepConfig.Condition.HasAtLeastOneReward:
				return settings.NumRewards < 1;
			case ResultStepConfig.Condition.HasAtLeastTwoRewards:
				return settings.NumRewards < 2;
			case ResultStepConfig.Condition.HasAtLeastThreeRewards:
				return settings.NumRewards < 3;
			case ResultStepConfig.Condition.StartingStreakZero:
				return settings.StartingStreak != 0;
			case ResultStepConfig.Condition.StartingStreakAtLeastOne:
				return settings.StartingStreak < 1;
			case ResultStepConfig.Condition.HasAtLeastFourRewards:
				return settings.NumRewards < 4;
			case ResultStepConfig.Condition.HasAtLeastFiveRewards:
				return settings.NumRewards < 5;
			case ResultStepConfig.Condition.HasAtLeastSixRewards:
				return settings.NumRewards < 6;
			case ResultStepConfig.Condition.AdsAllowed:
				return !settings.AllowAds;
			case ResultStepConfig.Condition.AdsNotAllowed:
				return settings.AllowAds;
			case ResultStepConfig.Condition.HasAtLeastOneCrateReward:
				Debug.Log("CRATES -" + settings.NumRewardCrates);
				return settings.NumRewardCrates < 1;
			default:
				return true;
			}
		}
		return true;
	}

	private bool ShouldSkipDownloadAssetBundles()
	{
		return true;
	}

	public bool ShouldStartStep(StartupSettings settings)
	{
		if (Config.startMode == ResultStepConfig.StartMode.DelayFromAllComplete)
		{
			if (settings.AllCompleteTime >= 0f)
			{
				return Time.time - settings.AllCompleteTime >= Config.delay;
			}
			return false;
		}
		if (Config.startMode != ResultStepConfig.StartMode.DelayFromPreviousStart)
		{
			return true;
		}
		if (settings.LastStepStartTime < 0f)
		{
			return false;
		}
		return Time.time - settings.LastStepStartTime >= Config.delay;
	}

	public void Start(AudioPlayer audioPlayer, string animatronicAudioId)
	{
		HasStarted = true;
		if (audioPlayer != null && !string.IsNullOrWhiteSpace(Config.audioEventName))
		{
			audioPlayer.RaiseGameEventForModeWithOverrideByName(Config.audioEventName, animatronicAudioId, AudioMode.Camera);
		}
		StartStep();
	}
}
