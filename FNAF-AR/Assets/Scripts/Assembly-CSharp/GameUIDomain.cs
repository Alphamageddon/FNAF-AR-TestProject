using UnityEngine;

public class GameUIDomain
{
	public GameUIData GameUIData;

	public WorkshopStageView WorkshopStage;

	private MasterDomain _masterDomain;

	private readonly float collectionTotalTime;

	public GameDialogHandler GameDialogHandler { get; set; }

	private void GetWorkshopLookupAsync(WorkshopSceneLookupTable workshopSceneLookupTable)
	{
		Debug.Log("GOT WORKSHOP SCENE");
		WorkshopStage = workshopSceneLookupTable.WorkshopStage;
	}

	private void EventExposer_AttackSequenceReadyForUi(EncounterResult obj)
	{
		UpdateEncounterResultData(obj);
	}

	private void AddSubscriptions()
	{
		_masterDomain.eventExposer.add_AttackSequenceReadyForUi(EventExposer_AttackSequenceReadyForUi);
	}

	private void RemoveSubscriptions()
	{
		if (_masterDomain.eventExposer != null)
		{
			_masterDomain.eventExposer.remove_AttackSequenceReadyForUi(EventExposer_AttackSequenceReadyForUi);
		}
	}

	private void Initialize(MonoBehaviour coroutineHost)
	{
		GameDialogHandler = new GameDialogHandler(_masterDomain.DialogDomain, _masterDomain.eventExposer);
		_masterDomain.eventExposer.add_GameDisplayChange(GameDisplayChanged);
		_masterDomain.SceneLookupTableAccess.GetWorkshopSceneLookupTableAsync(GetWorkshopLookupAsync);
		GameUIData = new GameUIData(_masterDomain, coroutineHost);
	}

	private void GameDisplayChanged(GameDisplayData data)
	{
		_masterDomain.SceneLookupTableAccess.GetWorkshopSceneLookupTableAsync(GetWorkshopLookupAsync);
	}

	private void UpdateEncounterResultData(EncounterResult obj)
	{
		RewardDataV3 rewardDataV = _masterDomain.AnimatronicEntityDomain.container.GetEntity(obj.EntityId).rewardDataV3;
		GameUIData.rewardDataModel.SetEncounterResult(obj, rewardDataV);
	}

	public void CollectRewards()
	{
	}

	public void ResetStoreScrollSettings()
	{
		GameUIData.storeScrollSection = "None";
		GameUIData.storeScrollItem = "";
	}

	public GameUIDomain(EventExposer eventExposer)
	{
		collectionTotalTime = 1f;
	}

	public void Setup(MasterDomain masterDomain, MonoBehaviour coroutineHost)
	{
		_masterDomain = masterDomain;
		Initialize(coroutineHost);
		AddSubscriptions();
	}

	public void Update()
	{
	}

	public void Teardown()
	{
		RemoveSubscriptions();
		if (GameUIData.workshopSlotDataModel != null)
		{
			GameUIData.workshopSlotDataModel.OnDestroy();
		}
		if (GameDialogHandler != null)
		{
			GameDialogHandler.TearDown();
		}
		GameDialogHandler = null;
	}
}
