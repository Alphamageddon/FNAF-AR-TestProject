using UnityEngine;

public class RewardSequenceStatus
{
	private const int defaultMinTime = 3;

	private float sequenceTime;

	private AudioSourceWatcher audioSourceWatcher;

	private AnimationWatcher animationWatcher;

	private GameObjectClicked gameObjectClick;

	private SimpleTimer simpleTimer;

	public RewardSequenceStatus(GameObject gameObject, float time = -1f)
	{
		sequenceTime = time;
		audioSourceWatcher = new AudioSourceWatcher(gameObject);
		animationWatcher = new AnimationWatcher(gameObject);
		gameObjectClick = new GameObjectClicked(gameObject);
		simpleTimer = new SimpleTimer();
		simpleTimer.StartTimer((sequenceTime < 0f) ? 3f : sequenceTime);
	}

	public bool IsComplete(StatusType statusType)
	{
		switch (statusType)
		{
		case StatusType.audio:
			return audioSourceWatcher.AllAudioSourcesFinished();
		case StatusType.anim:
			return animationWatcher.AllAnimationsComplete();
		case StatusType.click:
			return gameObjectClick.buttonClicked;
		case StatusType.timer:
			if (simpleTimer.Started)
			{
				return simpleTimer.IsExpired();
			}
			return false;
		default:
			return true;
		}
	}

	public bool AllComplete(StatusType[] statusTypes)
	{
		foreach (StatusType statusType in statusTypes)
		{
			if (!IsComplete(statusType))
			{
				return false;
			}
		}
		return true;
	}

	public void ResetClick()
	{
		gameObjectClick.buttonClicked = false;
	}

	public void RestartTimer()
	{
		simpleTimer.StartTimer((sequenceTime < 0f) ? 3f : sequenceTime);
	}
}
