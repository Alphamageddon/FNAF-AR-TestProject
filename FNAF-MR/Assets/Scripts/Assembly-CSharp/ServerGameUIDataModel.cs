using UnityEngine;

public class ServerGameUIDataModel
{
	private MasterDomain _masterDomain;

	private EncounterResult lastEncounter;

	private int level { get; set; }

	private int experience { get; set; }

	private int currentStreak { get; set; }

	private int bestStreak { get; set; }

	public int modSlotUnlocks
	{
		get
		{
			return 4;
		}
		set
		{
			modSlotUnlocks = value;
		}
	}

	public int workshopSlotsUnlocks { get; set; }

	public int masterDataVersion { get; set; }

	public int assetBundleVersion { get; set; }

	public int episodicAssetVersion { get; set; }

	public bool showUIBars { get; set; }

	public bool AlertsAllowed { get; set; }

	public int maxEmailsToDeletePacketSize { get; set; }

	public int maxEmailsSetReadPacketSize { get; set; }

	public bool dailyChallengesEnabled { get; set; }

	public int wins { get; set; }

	public int encounters { get; set; }

	public bool showUpgradeDialog { get; set; }

	private void EventExposerShowUiBars(bool value)
	{
		showUIBars = value;
	}

	private void OnStreakDataUpdated(StreakData data)
	{
		lastEncounter = null;
		currentStreak = data.currentStreak;
		bestStreak = data.bestStreak;
		wins = data.wins;
		encounters = data.encounters;
		UpdateStreakBasedUnlocks(MasterDomain.GetDomain().ItemDefinitionDomain);
	}

	private void UpdateLevelBasedUnlocks(ItemDefinitionDomain itemDefinitionDomain)
	{
	}

	private void UpdateStreakBasedUnlocks(ItemDefinitionDomain itemDefinitionDomain)
	{
	}

	private void EventExposer_AttackSequenceReadyForUi(EncounterResult result)
	{
		lastEncounter = result;
	}

	private void OnMasterDataVersionReceived(int data)
	{
		masterDataVersion = data;
	}

	private void EventExposer_RewardsFlowCompleted()
	{
		lastEncounter = null;
	}

	private void EventExposer_MaxEmailsToDeletePacketSizeReceived(int num)
	{
		maxEmailsToDeletePacketSize = num;
	}

	private void EventExposer_MaxEmailsSetReadPacketSizeReceived(int num)
	{
		maxEmailsSetReadPacketSize = num;
	}

	private void ConfigDataReady(CONFIG_DATA.Root configDataEntry)
	{
		maxEmailsToDeletePacketSize = Mathf.RoundToInt(configDataEntry.Entries[0].InboxBatchLimits.MaxDelete);
		maxEmailsSetReadPacketSize = Mathf.RoundToInt(configDataEntry.Entries[0].InboxBatchLimits.MaxSetToRead);
		dailyChallengesEnabled = configDataEntry.Entries[0].DailyChallenges.Enable;
	}

	public ServerGameUIDataModel(MasterDomain masterDomain)
	{
		maxEmailsToDeletePacketSize = 10;
		maxEmailsSetReadPacketSize = 10;
		_masterDomain = masterDomain;
		_masterDomain.eventExposer.add_StreakDataUpdated(OnStreakDataUpdated);
		_masterDomain.eventExposer.add_AttackSequenceReadyForUi(EventExposer_AttackSequenceReadyForUi);
		_masterDomain.eventExposer.add_RewardsFlowCompleted(EventExposer_RewardsFlowCompleted);
		_masterDomain.MasterDataDomain.GetAccessToData.GetConfigDataEntryAsync(ConfigDataReady);
	}

	private void OnShowUpdateDialogUpdated(bool obj)
	{
		showUpgradeDialog = obj;
	}

	public int GetServerCurrentStreak()
	{
		return currentStreak;
	}

	public int GetServerBestStreak()
	{
		return bestStreak;
	}
}
