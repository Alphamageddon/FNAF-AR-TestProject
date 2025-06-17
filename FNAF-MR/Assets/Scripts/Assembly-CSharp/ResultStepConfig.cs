using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class ResultStepConfig
{
	public enum StartMode
	{
		Immediate = 0,
		DelayFromPreviousStart = 1,
		DelayFromAllComplete = 2
	}

	public enum Condition
	{
		AlwaysExecute = 0,
		IsNewBestStreak = 1,
		IsNotNewBestStreak = 2,
		HasAtLeastOneReward = 3,
		HasAtLeastTwoRewards = 4,
		HasAtLeastThreeRewards = 5,
		StartingStreakZero = 6,
		StartingStreakAtLeastOne = 7,
		HasAtLeastFourRewards = 8,
		HasAtLeastFiveRewards = 9,
		HasAtLeastSixRewards = 10,
		AdsAllowed = 11,
		AdsNotAllowed = 12,
		HasAtLeastOneCrateReward = 13,
		ShouldDownloadAssetBundles = 14
	}

	public enum Type
	{
		Enable = 0,
		Disable = 1,
		WaitForTap = 2,
		NumberChanger = 3,
		AudioOnly = 4,
		AssetDownload = 5,
		OpenCrate = 6
	}

	[Header("Startup")]
	public Condition executionCondition;

	public StartMode startMode;

	public float delay;

	[Header("Execution - General")]
	public Type executionType;

	public string audioEventName;

	[Header("Execution - Game Object (Enable/Disable)")]
	public GameObject gameObject;

	[Header("Execution - Wait for Tap")]
	public Button button;

	public bool willTimeout;

	public float timeoutTime;

	[Header("Execution - Number Changer")]
	public NumberChanger numberChanger;

	[Header("Execution - Asset Bundles")]
	[HideInInspector]
	public EventExposer masterEventExposer;

	[HideInInspector]
	public GameAssetManagementDomain gameAssetManagementDomain;
}
