using System;
using System.Collections.Generic;
using UnityEngine;

public class EventExposer
{
	private Action<FastForwardCompleteArgs> EntityFastForwardComplete;

	private Action<Container.EntityAddedRemovedArgs> EntityAddedEvent;

	private Action<Container.EntityAddedRemovedArgs> EntityRemovedEvent;

	private Action<Container.EntitiesClearedArgs> EntitiesClearedEvent;

	private Action<IEnumerable<MapEntitySynchronizeableState>> MapEntitiesReceivedFromServer;

	private Action<IEnumerable<MapEntity>> MapEntitiesModelsUpdated;

	private Action NewAnimatronicSpawned;

	private Action<Dictionary<string, int>> PlayerCurrencyRefreshed;

	private Action<RewardData> RewardsReceived;

	private Action<PlayerInventory> InventoryUpdated;

	private Action<bool> PurchaseRequestAudioInvoked;

	private Action<StreakData> StreakDataUpdated;

	private Action<Dictionary<string, int>> PlayerGoodsUpdated;

	private Action<List<Vector2>, List<Vector2>> GestureTouchEvent;

	private Action GestureResetEvent;

	private Action<List<StoreContainer.StorefrontData>> VirtualGoodsDataReceived;

	private Action<ModInventory> ModInventoryUpdated;

	private Action<WorkshopData> WorkshopDataV2Updated;

	private Action<CPUInventory> CPUInventoryUpdated;

	private Action<GenericDialogData> GenericDialogRequestReceived;

	private Action<StoreDisplayData> StoreDialogRequestReceived;

	private Action<LootRewardDisplayData> LootRewardProcessed;

	private Action<LootRewardDisplayData> LootRewardDisplayRequestReceived;

	private Action<ExitAttackSequenceDialogData> ExitAttackSequenceReceived;

	private Action<EntityDisplayData> EntityWanderingAnimatronicDisplayRequestReceived;

	private Action<EntityDisplayData> EntitySpecialDeliveryDisplayRequestReceived;

	private Action<MapEntity> AnimatronicEncounterStarted;

	private Action<MapEntity> OrtonEncounterMapEntityChosen;

	private Action<MapEntity, bool> MapEntityInteractionFinished;

	private Action BuyMoreCoinsDialogRequest;

	private Action<MapEntity> MapEntityScanned;

	private Action StoreOpened;

	private Action StoreClosed;

	private Action<bool> HandleApplicationFocus;

	private Action<GenericDialogData> NetworkDialogRequestReceived;

	private Action NetworkDialogRequestRemoved;

	private Action RewardDialogOpened;

	private Action RewardDialogClosed;

	private Action RecallButtonTapped;

	private Action<Vector2> TouchDetected;

	private Action<List<WorkshopSlotData>> WorkshopSlotDataUpdated;

	private Action<WorkshopSlotData, WorkshopEntry.Status, WorkshopEntry.Status> WorkshopButtonStateOverriden;

	private Action AnimatronicCreationRequestStarted;

	private Action AnimatronicCreationRequestComplete;

	private Action<float> UnityFrameUpdate;

	private Action<List<AnimatronicEntity>> MapEntityHasSpawnedAnimatronics;

	private Action WorkshopCpuChanged;

	private Action<SlotDisplayButtonType> WorkshopModifyTabOpened;

	private Action<SlotDisplayButtonType> WorkshopModifyTabClosed;

	private Action WorkshopRepairSuccess;

	private Action<ExtraBatteryStateChange> ExtraBatteryStateChanged;

	private FlashlightState.StateChanged FlashlightStateChanged;

	private Action FlashlightTriedToActivate;

	private Action FlashlightCooldownComplete;

	private Action<ShockerActivation> ShockerActivated;

	private Action ShockerCooldownComplete;

	private Action MaskForcedOff;

	private MaskState.StateChanged MaskStateChanged;

	private AttackDisruption.StateChanged AttackDisruptionStateChanged;

	private AttackSurge.StateChanged AttackSurgeStateChanged;

	private Action<Encounter> StartAttackEncounter;

	private Action<EncounterType> AttackEncounterStarted;

	private Action<string> EncounterAnimatronicInitialized;

	private Action<EncounterResult> AttackSequenceReadyForUi;

	private Action AttackEncounterEnded;

	private Action AttackSequenceEnded;

	private Action<StaticSettings> StaticSettingsUpdated;

	private Action RewardsFlowCompleted;

	private Action<PlayerProfile> PlayerProfileUpdated;

	private Action PlayerAvatarUpdated;

	private Action<UserNameSetError> DisplayNameObscenityFound;

	private Action<List<PlayerFriendsEntry>> FriendListUpdated;

	private Action<GameDisplayData> GameDisplayChange;

	private Action PrepareForSceneUnload;

	private Action<AsyncOperation> SceneLoading;

	private Action<GameDisplayData.DisplayType> SceneLoaded;

	private Action<GameDisplayData.DisplayType> UICanvasDidAppear;

	private Action<GameDisplayData.DisplayType> UICanvasClosed;

	private Action<GameDisplayData.DisplayType> UIChangeRequest;

	private Action<string> PersonalFriendCodeUpdated;

	private Action<FriendCodeResponseHandler.FriendLookupResponse> FriendCodeLookedUp;

	private Action<bool> GeneratePlayStreamEventReceived;

	private Action<List<string>> PlayerAvatarUnlockedListReceived;

	private Action<long> PlayerStoreDataUpdated;

	private Action<AssemblyButtonPressedPayload> WorkshopModifyAssemblyButtonPressed;

	private Action AllOrtonBundlesDownloaded;

	private Action StopDisruptionButtonPressed;

	private Action<TrophyInventory> TrophyInventoryUpdated;

	private Action<TrophyData> TrophyChanged;

	private Action<IntroScreen.IntroScreenDialogData> EntityIntroDisplayRequestReceived;

	private Action<ScavengingEntity> AnimatronicScavengingEncounterStarted;

	private Action<ScavengingEntity> OrtonScavengingEncounterMapEntityChosen;

	private Action<ScavengingEncounter> StartAttackScavengingEncounter;

	private Action<EncounterType> AttackScavengingEncounterStarted;

	private Action AttackScavengingEncounterEnded;

	private Action<string> ScavengingEncounterAnimatronicInitialized;

	private Action<IEnumerable<ScavengingEntitySynchronizeableState>> ScavengingEntitiesReceivedFromServer;

	private Action<IEnumerable<ScavengingEntity>> ScavengingEntitiesModelsUpdated;

	public void add_GestureTouchEvent(Action<List<Vector2>, List<Vector2>> value)
	{
		GestureTouchEvent = (Action<List<Vector2>, List<Vector2>>)Delegate.Combine(GestureTouchEvent, value);
	}

	public void remove_GestureTouchEvent(Action<List<Vector2>, List<Vector2>> value)
	{
		GestureTouchEvent = (Action<List<Vector2>, List<Vector2>>)Delegate.Remove(GestureTouchEvent, value);
	}

	public void add_GestureResetEvent(Action value)
	{
		GestureResetEvent = (Action)Delegate.Combine(GestureResetEvent, value);
	}

	public void remove_GestureResetEvent(Action value)
	{
		GestureResetEvent = (Action)Delegate.Remove(GestureResetEvent, value);
	}

	public void OnGestureTouchEvent(List<Vector2> prev, List<Vector2> curr)
	{
		if (GestureTouchEvent != null)
		{
			GestureTouchEvent(prev, curr);
		}
	}

	public void add_EntityFastForwardComplete(Action<FastForwardCompleteArgs> value)
	{
		EntityFastForwardComplete = (Action<FastForwardCompleteArgs>)Delegate.Combine(EntityFastForwardComplete, value);
	}

	public void remove_EntityFastForwardComplete(Action<FastForwardCompleteArgs> value)
	{
		EntityFastForwardComplete = (Action<FastForwardCompleteArgs>)Delegate.Remove(EntityFastForwardComplete, value);
	}

	public void add_EntityAddedEvent(Action<Container.EntityAddedRemovedArgs> value)
	{
		EntityAddedEvent = (Action<Container.EntityAddedRemovedArgs>)Delegate.Combine(EntityAddedEvent, value);
	}

	public void remove_EntityAddedEvent(Action<Container.EntityAddedRemovedArgs> value)
	{
		EntityAddedEvent = (Action<Container.EntityAddedRemovedArgs>)Delegate.Remove(EntityAddedEvent, value);
	}

	public void add_EntityRemovedEvent(Action<Container.EntityAddedRemovedArgs> value)
	{
		EntityRemovedEvent = (Action<Container.EntityAddedRemovedArgs>)Delegate.Combine(EntityRemovedEvent, value);
	}

	public void remove_EntityRemovedEvent(Action<Container.EntityAddedRemovedArgs> value)
	{
		EntityRemovedEvent = (Action<Container.EntityAddedRemovedArgs>)Delegate.Remove(EntityRemovedEvent, value);
	}

	public void add_EntitiesClearedEvent(Action<Container.EntitiesClearedArgs> value)
	{
		EntitiesClearedEvent = (Action<Container.EntitiesClearedArgs>)Delegate.Combine(EntitiesClearedEvent, value);
	}

	public void remove_EntitiesClearedEvent(Action<Container.EntitiesClearedArgs> value)
	{
		EntitiesClearedEvent = (Action<Container.EntitiesClearedArgs>)Delegate.Remove(EntitiesClearedEvent, value);
	}

	public void OnEntityFastForwardComplete(FastForwardCompleteArgs args)
	{
		if (EntityFastForwardComplete != null)
		{
			EntityFastForwardComplete(args);
		}
	}

	public void OnEntityAddedEvent(Container.EntityAddedRemovedArgs e)
	{
		if (EntityAddedEvent == null)
		{
			Debug.LogError("ENTITY ADDED EVENT FOR EVENT EXPOSER IS NULL!");
		}
		else
		{
			EntityAddedEvent(e);
		}
	}

	public void OnEntityRemovedEvent(Container.EntityAddedRemovedArgs e)
	{
		if (EntityRemovedEvent != null)
		{
			EntityRemovedEvent(e);
		}
	}

	public void OnEntitiesClearedEvent(Container.EntitiesClearedArgs e)
	{
		if (EntitiesClearedEvent != null)
		{
			EntitiesClearedEvent(e);
		}
	}

	public void add_NewAnimatronicSpawned(Action value)
	{
		NewAnimatronicSpawned = (Action)Delegate.Combine(NewAnimatronicSpawned, value);
	}

	public void remove_NewAnimatronicSpawned(Action value)
	{
		NewAnimatronicSpawned = (Action)Delegate.Remove(NewAnimatronicSpawned, value);
	}

	public void OnNewAnimatronicSpawned()
	{
		if (NewAnimatronicSpawned != null)
		{
			NewAnimatronicSpawned();
		}
	}

	public void add_AnimatronicEncounterStarted(Action<MapEntity> value)
	{
		AnimatronicEncounterStarted = (Action<MapEntity>)Delegate.Combine(AnimatronicEncounterStarted, value);
	}

	public void remove_AnimatronicEncounterStarted(Action<MapEntity> value)
	{
		AnimatronicEncounterStarted = (Action<MapEntity>)Delegate.Remove(AnimatronicEncounterStarted, value);
	}

	public void OnAnimatronicEncounterStarted(MapEntity entity)
	{
		if (AnimatronicEncounterStarted == null)
		{
			Debug.Log("AnimatronicEncounterStarted is NULL.");
		}
		else
		{
			AnimatronicEncounterStarted(entity);
		}
	}

	public void add_MapEntityHasSpawnedAnimatronics(Action<List<AnimatronicEntity>> value)
	{
		MapEntityHasSpawnedAnimatronics = (Action<List<AnimatronicEntity>>)Delegate.Combine(MapEntityHasSpawnedAnimatronics, value);
	}

	public void remove_MapEntityHasSpawnedAnimatronics(Action<List<AnimatronicEntity>> value)
	{
		MapEntityHasSpawnedAnimatronics = (Action<List<AnimatronicEntity>>)Delegate.Remove(MapEntityHasSpawnedAnimatronics, value);
	}

	public void OnMapEntityHasSpawnedAnimatronics(List<AnimatronicEntity> entities)
	{
		if (MapEntityHasSpawnedAnimatronics != null)
		{
			MapEntityHasSpawnedAnimatronics(entities);
		}
	}

	public void add_ShockerActivated(Action<ShockerActivation> value)
	{
		ShockerActivated = (Action<ShockerActivation>)Delegate.Combine(ShockerActivated, value);
	}

	public void remove_ShockerActivated(Action<ShockerActivation> value)
	{
		ShockerActivated = (Action<ShockerActivation>)Delegate.Remove(ShockerActivated, value);
	}

	public void add_ShockerCooldownComplete(Action value)
	{
		ShockerCooldownComplete = (Action)Delegate.Combine(ShockerCooldownComplete, value);
	}

	public void remove_ShockerCooldownComplete(Action value)
	{
		ShockerCooldownComplete = (Action)Delegate.Remove(ShockerCooldownComplete, value);
	}

	public void OnShockerActivated(ShockerActivation shockerActivation)
	{
		if (ShockerActivated != null)
		{
			ShockerActivated(shockerActivation);
		}
	}

	public void OnShockerCooldownComplete()
	{
		if (ShockerCooldownComplete != null)
		{
			ShockerCooldownComplete();
		}
	}

	public void add_AttackDisruptionStateChanged(AttackDisruption.StateChanged value)
	{
		AttackDisruptionStateChanged = (AttackDisruption.StateChanged)Delegate.Combine(AttackDisruptionStateChanged, value);
	}

	public void remove_AttackDisruptionStateChanged(AttackDisruption.StateChanged value)
	{
		AttackDisruptionStateChanged = (AttackDisruption.StateChanged)Delegate.Remove(AttackDisruptionStateChanged, value);
	}

	public void OnAttackDisruptionStateChanged(bool isDisruptionActive, DisruptionStyle style)
	{
		if (AttackDisruptionStateChanged != null)
		{
			AttackDisruptionStateChanged(isDisruptionActive, style);
		}
	}

	public void add_StartAttackEncounter(Action<Encounter> value)
	{
		StartAttackEncounter = (Action<Encounter>)Delegate.Combine(StartAttackEncounter, value);
	}

	public void remove_StartAttackEncounter(Action<Encounter> value)
	{
		StartAttackEncounter = (Action<Encounter>)Delegate.Remove(StartAttackEncounter, value);
	}

	public void add_AttackEncounterStarted(Action<EncounterType> value)
	{
		AttackEncounterStarted = (Action<EncounterType>)Delegate.Combine(AttackEncounterStarted, value);
	}

	public void remove_AttackEncounterStarted(Action<EncounterType> value)
	{
		AttackEncounterStarted = (Action<EncounterType>)Delegate.Remove(AttackEncounterStarted, value);
	}

	public void add_EncounterAnimatronicInitialized(Action<string> value)
	{
		EncounterAnimatronicInitialized = (Action<string>)Delegate.Combine(EncounterAnimatronicInitialized, value);
	}

	public void remove_EncounterAnimatronicInitialized(Action<string> value)
	{
		EncounterAnimatronicInitialized = (Action<string>)Delegate.Remove(EncounterAnimatronicInitialized, value);
	}

	public void add_AttackSequenceReadyForUi(Action<EncounterResult> value)
	{
		AttackSequenceReadyForUi = (Action<EncounterResult>)Delegate.Combine(AttackSequenceReadyForUi, value);
	}

	public void remove_AttackSequenceReadyForUi(Action<EncounterResult> value)
	{
		AttackSequenceReadyForUi = (Action<EncounterResult>)Delegate.Remove(AttackSequenceReadyForUi, value);
	}

	public void add_AttackEncounterEnded(Action value)
	{
		AttackEncounterEnded = (Action)Delegate.Combine(AttackEncounterEnded, value);
	}

	public void remove_AttackEncounterEnded(Action value)
	{
		AttackEncounterEnded = (Action)Delegate.Remove(AttackEncounterEnded, value);
	}

	public void add_AttackSequenceEnded(Action value)
	{
		AttackSequenceEnded = (Action)Delegate.Combine(AttackSequenceEnded, value);
	}

	public void remove_AttackSequenceEnded(Action value)
	{
		AttackSequenceEnded = (Action)Delegate.Remove(AttackSequenceEnded, value);
	}

	public void add_StaticSettingsUpdated(Action<StaticSettings> value)
	{
		StaticSettingsUpdated = (Action<StaticSettings>)Delegate.Combine(StaticSettingsUpdated, value);
	}

	public void remove_StaticSettingsUpdated(Action<StaticSettings> value)
	{
		StaticSettingsUpdated = (Action<StaticSettings>)Delegate.Remove(StaticSettingsUpdated, value);
	}

	public void OnStartAttackEncounter(Encounter encounter)
	{
		if (StartAttackEncounter != null)
		{
			StartAttackEncounter(encounter);
		}
	}

	public void OnAttackEncounterStarted(EncounterType type)
	{
		if (AttackEncounterStarted != null)
		{
			AttackEncounterStarted(type);
		}
	}

	public void OnEncounterAnimatronicInitialized(string cpuId)
	{
		if (EncounterAnimatronicInitialized != null)
		{
			EncounterAnimatronicInitialized(cpuId);
		}
	}

	public void OnAttackSequenceReadyForUi(EncounterResult result)
	{
		if (AttackSequenceReadyForUi != null)
		{
			AttackSequenceReadyForUi(result);
		}
	}

	public void OnAttackSequenceEnded()
	{
		if (AttackSequenceEnded != null)
		{
			AttackSequenceEnded();
		}
	}

	public void OnAttackEncounterEnded()
	{
		if (AttackEncounterEnded != null)
		{
			AttackEncounterEnded();
		}
	}

	public void OnStaticSettingsUpdated(StaticSettings staticSettings)
	{
		if (StaticSettingsUpdated != null)
		{
			StaticSettingsUpdated(staticSettings);
		}
	}

	public void add_GameDisplayChange(Action<GameDisplayData> value)
	{
		GameDisplayChange = (Action<GameDisplayData>)Delegate.Combine(GameDisplayChange, value);
	}

	public void remove_GameDisplayChange(Action<GameDisplayData> value)
	{
		GameDisplayChange = (Action<GameDisplayData>)Delegate.Remove(GameDisplayChange, value);
	}

	public void add_PrepareForSceneUnload(Action value)
	{
		PrepareForSceneUnload = (Action)Delegate.Combine(PrepareForSceneUnload, value);
	}

	public void remove_PrepareForSceneUnload(Action value)
	{
		PrepareForSceneUnload = (Action)Delegate.Remove(PrepareForSceneUnload, value);
	}

	public void OnGameDisplayChange(GameDisplayData e)
	{
		if (GameDisplayChange != null)
		{
			GameDisplayChange(e);
		}
	}

	public void OnPrepareForSceneUnload()
	{
		if (PrepareForSceneUnload != null)
		{
			PrepareForSceneUnload();
		}
	}

	public void add_UICanvasDidAppear(Action<GameDisplayData.DisplayType> value)
	{
		UICanvasDidAppear = (Action<GameDisplayData.DisplayType>)Delegate.Combine(UICanvasDidAppear, value);
	}

	public void remove_UICanvasDidAppear(Action<GameDisplayData.DisplayType> value)
	{
		UICanvasDidAppear = (Action<GameDisplayData.DisplayType>)Delegate.Remove(UICanvasDidAppear, value);
	}

	public void add_UICanvasClosed(Action<GameDisplayData.DisplayType> value)
	{
		UICanvasClosed = (Action<GameDisplayData.DisplayType>)Delegate.Combine(UICanvasClosed, value);
	}

	public void remove_UICanvasClosed(Action<GameDisplayData.DisplayType> value)
	{
		UICanvasClosed = (Action<GameDisplayData.DisplayType>)Delegate.Remove(UICanvasClosed, value);
	}

	public void add_UIChangeRequest(Action<GameDisplayData.DisplayType> value)
	{
		UIChangeRequest = (Action<GameDisplayData.DisplayType>)Delegate.Combine(UIChangeRequest, value);
	}

	public void remove_UIChangeRequest(Action<GameDisplayData.DisplayType> value)
	{
		UIChangeRequest = (Action<GameDisplayData.DisplayType>)Delegate.Remove(UIChangeRequest, value);
	}

	public void OnUICanvasDidAppear(GameDisplayData.DisplayType displayType)
	{
		if (UICanvasDidAppear != null)
		{
			UICanvasDidAppear(displayType);
		}
	}

	public void OnUIChangeRequest(GameDisplayData.DisplayType obj)
	{
		if (UIChangeRequest != null)
		{
			UIChangeRequest(obj);
		}
	}

	public void OnUICanvasClosed(GameDisplayData.DisplayType displayType)
	{
		if (UICanvasClosed != null)
		{
			UICanvasClosed(displayType);
		}
	}

	public void add_RewardsFlowCompleted(Action value)
	{
		RewardsFlowCompleted = (Action)Delegate.Combine(RewardsFlowCompleted, value);
	}

	public void remove_RewardsFlowCompleted(Action value)
	{
		RewardsFlowCompleted = (Action)Delegate.Remove(RewardsFlowCompleted, value);
	}

	public void OnRewardsFlowCompleted()
	{
		if (RewardsFlowCompleted != null)
		{
			RewardsFlowCompleted();
		}
	}

	public void add_HandleApplicationFocus(Action<bool> value)
	{
		HandleApplicationFocus = (Action<bool>)Delegate.Combine(HandleApplicationFocus, value);
	}

	public void remove_HandleApplicationFocus(Action<bool> value)
	{
		HandleApplicationFocus = (Action<bool>)Delegate.Remove(HandleApplicationFocus, value);
	}

	public void OnApplicationFocus(bool focus)
	{
		if (HandleApplicationFocus != null)
		{
			HandleApplicationFocus(focus);
		}
	}

	public void add_UnityFrameUpdate(Action<float> value)
	{
		UnityFrameUpdate = (Action<float>)Delegate.Combine(UnityFrameUpdate, value);
	}

	public void remove_UnityFrameUpdate(Action<float> value)
	{
		UnityFrameUpdate = (Action<float>)Delegate.Remove(UnityFrameUpdate, value);
	}

	public void OnUnityFrameUpdate(float dt)
	{
		if (UnityFrameUpdate != null)
		{
			UnityFrameUpdate(dt);
		}
	}

	public void add_FlashlightStateChanged(FlashlightState.StateChanged value)
	{
		FlashlightStateChanged = (FlashlightState.StateChanged)Delegate.Combine(FlashlightStateChanged, value);
	}

	public void remove_FlashlightStateChanged(FlashlightState.StateChanged value)
	{
		FlashlightStateChanged = (FlashlightState.StateChanged)Delegate.Remove(FlashlightStateChanged, value);
	}

	public void add_FlashlightTriedToActivate(Action value)
	{
		FlashlightTriedToActivate = (Action)Delegate.Combine(FlashlightTriedToActivate, value);
	}

	public void remove_FlashlightTriedToActivate(Action value)
	{
		FlashlightTriedToActivate = (Action)Delegate.Remove(FlashlightTriedToActivate, value);
	}

	public void add_FlashlightCooldownComplete(Action value)
	{
		FlashlightCooldownComplete = (Action)Delegate.Combine(FlashlightCooldownComplete, value);
	}

	public void remove_FlashlightCooldownComplete(Action value)
	{
		FlashlightCooldownComplete = (Action)Delegate.Remove(FlashlightCooldownComplete, value);
	}

	public void OnFlashlightStateChanged(bool isFlashlightOn, bool shouldPlayAudio)
	{
		if (FlashlightStateChanged != null)
		{
			FlashlightStateChanged(isFlashlightOn, shouldPlayAudio);
		}
	}

	public void OnFlashlightTriedToActivate()
	{
		if (FlashlightTriedToActivate != null)
		{
			FlashlightTriedToActivate();
		}
	}

	public void OnFlashlightCooldownComplete()
	{
		if (FlashlightCooldownComplete != null)
		{
			FlashlightCooldownComplete();
		}
	}

	public void add_AllOrtonBundlesDownloaded(Action value)
	{
		AllOrtonBundlesDownloaded = (Action)Delegate.Combine(AllOrtonBundlesDownloaded, value);
	}

	public void remove_AllOrtonBundlesDownloaded(Action value)
	{
		AllOrtonBundlesDownloaded = (Action)Delegate.Remove(AllOrtonBundlesDownloaded, value);
	}

	public void OnAllOrtonBundlesDownloaded()
	{
		if (AllOrtonBundlesDownloaded != null)
		{
			AllOrtonBundlesDownloaded();
		}
	}

	public void add_WorkshopDataV2Updated(Action<WorkshopData> value)
	{
		WorkshopDataV2Updated = (Action<WorkshopData>)Delegate.Combine(WorkshopDataV2Updated, value);
	}

	public void remove_WorkshopDataV2Updated(Action<WorkshopData> value)
	{
		WorkshopDataV2Updated = (Action<WorkshopData>)Delegate.Remove(WorkshopDataV2Updated, value);
	}

	public void OnWorkshopDataV2Updated(WorkshopData data)
	{
		if (WorkshopDataV2Updated != null)
		{
			Debug.LogError("INVOKED ON WORKSHOPDATA v2 UPDATED");
			WorkshopDataV2Updated(data);
		}
	}

	public void add_WorkshopSlotDataUpdated(Action<List<WorkshopSlotData>> value)
	{
		WorkshopSlotDataUpdated = (Action<List<WorkshopSlotData>>)Delegate.Combine(WorkshopSlotDataUpdated, value);
	}

	public void remove_WorkshopSlotDataUpdated(Action<List<WorkshopSlotData>> value)
	{
		WorkshopSlotDataUpdated = (Action<List<WorkshopSlotData>>)Delegate.Remove(WorkshopSlotDataUpdated, value);
	}

	public void OnWorkshopSlotDataUpdated(List<WorkshopSlotData> datas)
	{
		if (WorkshopSlotDataUpdated != null)
		{
			WorkshopSlotDataUpdated(datas);
		}
	}

	public void add_WorkshopCpuChanged(Action value)
	{
		WorkshopCpuChanged = (Action)Delegate.Combine(WorkshopCpuChanged, value);
	}

	public void remove_WorkshopCpuChanged(Action value)
	{
		WorkshopCpuChanged = (Action)Delegate.Remove(WorkshopCpuChanged, value);
	}

	public void add_WorkshopModifyTabOpened(Action<SlotDisplayButtonType> value)
	{
		WorkshopModifyTabOpened = (Action<SlotDisplayButtonType>)Delegate.Combine(WorkshopModifyTabOpened, value);
	}

	public void remove_WorkshopModifyTabOpened(Action<SlotDisplayButtonType> value)
	{
		WorkshopModifyTabOpened = (Action<SlotDisplayButtonType>)Delegate.Remove(WorkshopModifyTabOpened, value);
	}

	public void add_WorkshopModifyTabClosed(Action<SlotDisplayButtonType> value)
	{
		WorkshopModifyTabClosed = (Action<SlotDisplayButtonType>)Delegate.Combine(WorkshopModifyTabClosed, value);
	}

	public void remove_WorkshopModifyTabClosed(Action<SlotDisplayButtonType> value)
	{
		WorkshopModifyTabClosed = (Action<SlotDisplayButtonType>)Delegate.Remove(WorkshopModifyTabClosed, value);
	}

	public void add_WorkshopRepairSuccess(Action value)
	{
		WorkshopRepairSuccess = (Action)Delegate.Combine(WorkshopRepairSuccess, value);
	}

	public void remove_WorkshopRepairSuccess(Action value)
	{
		WorkshopRepairSuccess = (Action)Delegate.Remove(WorkshopRepairSuccess, value);
	}

	public void OnWorkshopCpuChanged()
	{
		if (WorkshopCpuChanged != null)
		{
			WorkshopCpuChanged();
		}
	}

	public void OnWorkshopModifyTabOpened(SlotDisplayButtonType tab)
	{
		if (WorkshopModifyTabOpened != null)
		{
			WorkshopModifyTabOpened(tab);
		}
	}

	public void OnWorkshopModifyTabClosed(SlotDisplayButtonType tab)
	{
		if (WorkshopModifyTabClosed != null)
		{
			WorkshopModifyTabClosed(tab);
		}
	}

	public void OnWorkshopRepairSuccess()
	{
		if (WorkshopRepairSuccess != null)
		{
			WorkshopRepairSuccess();
		}
	}

	public void add_StopDisruptionButtonPressed(Action value)
	{
		StopDisruptionButtonPressed = (Action)Delegate.Combine(StopDisruptionButtonPressed, value);
	}

	public void remove_StopDisruptionButtonPressed(Action value)
	{
		StopDisruptionButtonPressed = (Action)Delegate.Remove(StopDisruptionButtonPressed, value);
	}

	public void OnStopDisruptionButtonPressed()
	{
		if (StopDisruptionButtonPressed != null)
		{
			StopDisruptionButtonPressed();
		}
	}

	public void add_WorkshopButtonStateOverriden(Action<WorkshopSlotData, WorkshopEntry.Status, WorkshopEntry.Status> value)
	{
		WorkshopButtonStateOverriden = (Action<WorkshopSlotData, WorkshopEntry.Status, WorkshopEntry.Status>)Delegate.Combine(WorkshopButtonStateOverriden, value);
	}

	public void remove_WorkshopButtonStateOverriden(Action<WorkshopSlotData, WorkshopEntry.Status, WorkshopEntry.Status> value)
	{
		WorkshopButtonStateOverriden = (Action<WorkshopSlotData, WorkshopEntry.Status, WorkshopEntry.Status>)Delegate.Remove(WorkshopButtonStateOverriden, value);
	}

	public void OnWorkshopButtonStateOverride(WorkshopSlotData workshopEntry, WorkshopEntry.Status oldStatus, WorkshopEntry.Status newStatus)
	{
		if (WorkshopButtonStateOverriden != null)
		{
			WorkshopButtonStateOverriden(workshopEntry, oldStatus, newStatus);
		}
	}

	public void add_RecallButtonTapped(Action value)
	{
		RecallButtonTapped = (Action)Delegate.Combine(RecallButtonTapped, value);
	}

	public void remove_RecallButtonTapped(Action value)
	{
		RecallButtonTapped = (Action)Delegate.Remove(RecallButtonTapped, value);
	}

	public void OnRecallButtonTapped()
	{
		if (RecallButtonTapped != null)
		{
			RecallButtonTapped();
		}
	}

	public void add_GenericDialogRequestReceived(Action<GenericDialogData> value)
	{
		GenericDialogRequestReceived = (Action<GenericDialogData>)Delegate.Combine(GenericDialogRequestReceived, value);
	}

	public void remove_GenericDialogRequestReceived(Action<GenericDialogData> value)
	{
		GenericDialogRequestReceived = (Action<GenericDialogData>)Delegate.Remove(GenericDialogRequestReceived, value);
	}

	public void GenericDialogRequest(GenericDialogData genericDialogData)
	{
		if (GenericDialogRequestReceived != null)
		{
			GenericDialogRequestReceived(genericDialogData);
		}
	}

	public void add_FriendListUpdated(Action<List<PlayerFriendsEntry>> value)
	{
		FriendListUpdated = (Action<List<PlayerFriendsEntry>>)Delegate.Combine(FriendListUpdated, value);
	}

	public void remove_FriendListUpdated(Action<List<PlayerFriendsEntry>> value)
	{
		FriendListUpdated = (Action<List<PlayerFriendsEntry>>)Delegate.Remove(FriendListUpdated, value);
	}

	public void OnFriendListUpdated(List<PlayerFriendsEntry> data)
	{
		if (FriendListUpdated != null)
		{
			FriendListUpdated(data);
		}
	}

	public void add_WorkshopModifyAssemblyButtonPressed(Action<AssemblyButtonPressedPayload> value)
	{
		WorkshopModifyAssemblyButtonPressed = (Action<AssemblyButtonPressedPayload>)Delegate.Combine(WorkshopModifyAssemblyButtonPressed, value);
	}

	public void remove_WorkshopModifyAssemblyButtonPressed(Action<AssemblyButtonPressedPayload> value)
	{
		WorkshopModifyAssemblyButtonPressed = (Action<AssemblyButtonPressedPayload>)Delegate.Remove(WorkshopModifyAssemblyButtonPressed, value);
	}

	public void OnWorkshopModifyAssemblyButtonPressed(AssemblyButtonPressedPayload payload)
	{
		if (WorkshopModifyAssemblyButtonPressed != null)
		{
			WorkshopModifyAssemblyButtonPressed(payload);
		}
	}

	public void add_MaskForcedOff(Action value)
	{
		MaskForcedOff = (Action)Delegate.Combine(MaskForcedOff, value);
	}

	public void remove_MaskForcedOff(Action value)
	{
		MaskForcedOff = (Action)Delegate.Remove(MaskForcedOff, value);
	}

	public void add_MaskStateChanged(MaskState.StateChanged value)
	{
		MaskStateChanged = (MaskState.StateChanged)Delegate.Combine(MaskStateChanged, value);
	}

	public void remove_MaskStateChanged(MaskState.StateChanged value)
	{
		MaskStateChanged = (MaskState.StateChanged)Delegate.Remove(MaskStateChanged, value);
	}

	public void OnMaskForcedOff()
	{
		if (MaskForcedOff != null)
		{
			MaskForcedOff();
		}
	}

	public void OnMaskStateChanged(bool isMaskGoingOn, bool isMaskTransitionBeginning)
	{
		if (MaskStateChanged != null)
		{
			MaskStateChanged(isMaskGoingOn, isMaskTransitionBeginning);
		}
	}

	public void add_AnimatronicCreationRequestStarted(Action value)
	{
		AnimatronicCreationRequestStarted = (Action)Delegate.Combine(AnimatronicCreationRequestStarted, value);
	}

	public void remove_AnimatronicCreationRequestStarted(Action value)
	{
		AnimatronicCreationRequestStarted = (Action)Delegate.Remove(AnimatronicCreationRequestStarted, value);
	}

	public void OnAnimatronicCreationRequestStarted()
	{
		if (AnimatronicCreationRequestStarted != null)
		{
			AnimatronicCreationRequestStarted();
		}
	}

	public void add_TouchDetected(Action<Vector2> value)
	{
		TouchDetected = (Action<Vector2>)Delegate.Combine(TouchDetected, value);
	}

	public void remove_TouchDetected(Action<Vector2> value)
	{
		TouchDetected = (Action<Vector2>)Delegate.Remove(TouchDetected, value);
	}

	public void OnTouchDetected(Vector2 position)
	{
		if (TouchDetected != null)
		{
			TouchDetected(position);
		}
	}

	public void add_ExtraBatteryStateChanged(Action<ExtraBatteryStateChange> value)
	{
		ExtraBatteryStateChanged = (Action<ExtraBatteryStateChange>)Delegate.Combine(ExtraBatteryStateChanged, value);
	}

	public void remove_ExtraBatteryStateChanged(Action<ExtraBatteryStateChange> value)
	{
		ExtraBatteryStateChanged = (Action<ExtraBatteryStateChange>)Delegate.Combine(ExtraBatteryStateChanged, value);
	}

	public void OnExtraBatteryStateChanged(ExtraBatteryStateChange extraBatteryStateChange)
	{
		if (ExtraBatteryStateChanged != null)
		{
			ExtraBatteryStateChanged(extraBatteryStateChange);
		}
	}

	public void add_AttackSurgeStateChanged(AttackSurge.StateChanged value)
	{
		AttackSurgeStateChanged = (AttackSurge.StateChanged)Delegate.Combine(AttackSurgeStateChanged, value);
	}

	public void remove_AttackSurgeStateChanged(AttackSurge.StateChanged value)
	{
		AttackSurgeStateChanged = (AttackSurge.StateChanged)Delegate.Remove(AttackSurgeStateChanged, value);
	}

	public void OnAttackSurgeStateChanged(bool isSurgeActive, SurgeData surgeSettings)
	{
		if (AttackSurgeStateChanged != null)
		{
			AttackSurgeStateChanged(isSurgeActive, surgeSettings);
		}
	}

	public void add_RewardsReceived(Action<RewardData> value)
	{
		RewardsReceived = (Action<RewardData>)Delegate.Combine(RewardsReceived, value);
	}

	public void remove_RewardsReceived(Action<RewardData> value)
	{
		RewardsReceived = (Action<RewardData>)Delegate.Remove(RewardsReceived, value);
	}

	public void OnRewardsReceived(RewardData e)
	{
		if (RewardsReceived != null)
		{
			RewardsReceived(e);
		}
	}

	public void add_LootRewardProcessed(Action<LootRewardDisplayData> value)
	{
		LootRewardProcessed = (Action<LootRewardDisplayData>)Delegate.Combine(LootRewardProcessed, value);
	}

	public void remove_LootRewardProcessed(Action<LootRewardDisplayData> value)
	{
		LootRewardProcessed = (Action<LootRewardDisplayData>)Delegate.Remove(LootRewardProcessed, value);
	}

	public void add_LootRewardDisplayRequestReceived(Action<LootRewardDisplayData> value)
	{
		LootRewardDisplayRequestReceived = (Action<LootRewardDisplayData>)Delegate.Combine(LootRewardDisplayRequestReceived, value);
	}

	public void remove_LootRewardDisplayRequestReceived(Action<LootRewardDisplayData> value)
	{
		LootRewardDisplayRequestReceived = (Action<LootRewardDisplayData>)Delegate.Remove(LootRewardDisplayRequestReceived, value);
	}

	public void OnLootRewardProcessed(LootRewardDisplayData data)
	{
		if (LootRewardProcessed != null)
		{
			LootRewardProcessed(data);
		}
	}

	public void OnLootRewardDisplayRequestReceived(LootRewardDisplayData data)
	{
		if (LootRewardDisplayRequestReceived != null)
		{
			LootRewardDisplayRequestReceived(data);
		}
	}

	public void add_NetworkDialogRequestReceived(Action<GenericDialogData> value)
	{
		NetworkDialogRequestReceived = (Action<GenericDialogData>)Delegate.Combine(NetworkDialogRequestReceived, value);
	}

	public void remove_NetworkDialogRequestReceived(Action<GenericDialogData> value)
	{
		NetworkDialogRequestReceived = (Action<GenericDialogData>)Delegate.Remove(NetworkDialogRequestReceived, value);
	}

	public void add_NetworkDialogRequestRemoved(Action value)
	{
		NetworkDialogRequestRemoved = (Action)Delegate.Combine(NetworkDialogRequestRemoved, value);
	}

	public void remove_NetworkDialogRequestRemoved(Action value)
	{
		NetworkDialogRequestRemoved = (Action)Delegate.Remove(NetworkDialogRequestRemoved, value);
	}

	public void OnNetworkDialogRequestReceived(GenericDialogData data)
	{
		if (NetworkDialogRequestReceived != null)
		{
			NetworkDialogRequestReceived(data);
		}
	}

	public void OnNetworkDialogRequestRemoved()
	{
		if (NetworkDialogRequestRemoved != null)
		{
			NetworkDialogRequestRemoved();
		}
	}

	public void add_AnimatronicCreationRequestComplete(Action value)
	{
		AnimatronicCreationRequestComplete = (Action)Delegate.Combine(AnimatronicCreationRequestComplete, value);
	}

	public void remove_AnimatronicCreationRequestComplete(Action value)
	{
		AnimatronicCreationRequestComplete = (Action)Delegate.Remove(AnimatronicCreationRequestComplete, value);
	}

	public void OnAnimatronicCreationRequestCompleted()
	{
		if (AnimatronicCreationRequestComplete != null)
		{
			AnimatronicCreationRequestComplete();
		}
	}

	public void add_PlayerCurrencyRefreshed(Action<Dictionary<string, int>> value)
	{
		PlayerCurrencyRefreshed = (Action<Dictionary<string, int>>)Delegate.Combine(PlayerCurrencyRefreshed, value);
	}

	public void remove_PlayerCurrencyRefreshed(Action<Dictionary<string, int>> value)
	{
		PlayerCurrencyRefreshed = (Action<Dictionary<string, int>>)Delegate.Remove(PlayerCurrencyRefreshed, value);
	}

	public void OnPlayerCurrencyRefreshed(Dictionary<string, int> e)
	{
		if (PlayerCurrencyRefreshed != null)
		{
			PlayerCurrencyRefreshed(e);
		}
	}

	public void add_CPUInventoryUpdated(Action<CPUInventory> value)
	{
		CPUInventoryUpdated = (Action<CPUInventory>)Delegate.Combine(CPUInventoryUpdated, value);
	}

	public void remove_CPUInventoryUpdated(Action<CPUInventory> value)
	{
		CPUInventoryUpdated = (Action<CPUInventory>)Delegate.Remove(CPUInventoryUpdated, value);
	}

	public void OnCPUInventoryUpdated(CPUInventory data)
	{
		if (CPUInventoryUpdated != null)
		{
			CPUInventoryUpdated(data);
		}
	}

	public void add_SceneLoading(Action<AsyncOperation> value)
	{
		SceneLoading = (Action<AsyncOperation>)Delegate.Combine(SceneLoading, value);
	}

	public void remove_SceneLoading(Action<AsyncOperation> value)
	{
		SceneLoading = (Action<AsyncOperation>)Delegate.Remove(SceneLoading, value);
	}

	public void OnLoadScene(AsyncOperation operation)
	{
		if (SceneLoading != null)
		{
			SceneLoading(operation);
		}
	}

	public void add_MapEntitiesReceivedFromServer(Action<IEnumerable<MapEntitySynchronizeableState>> value)
	{
		MapEntitiesReceivedFromServer = (Action<IEnumerable<MapEntitySynchronizeableState>>)Delegate.Combine(MapEntitiesReceivedFromServer, value);
	}

	public void remove_MapEntitiesReceivedFromServer(Action<IEnumerable<MapEntitySynchronizeableState>> value)
	{
		MapEntitiesReceivedFromServer = (Action<IEnumerable<MapEntitySynchronizeableState>>)Delegate.Remove(MapEntitiesReceivedFromServer, value);
	}

	public void OnMapEntitiesReceivedFromServer(IEnumerable<MapEntitySynchronizeableState> e)
	{
		Debug.Log("GOT MAP ENTITIES FROM SERVER! IT WORKS!");
		foreach (MapEntitySynchronizeableState item in e)
		{
			Debug.Log("SUIT - " + item.parts["PlushSuit"]);
			Debug.Log("CPU - " + item.parts["Cpu"]);
		}
		if (MapEntitiesReceivedFromServer != null)
		{
			MapEntitiesReceivedFromServer(e);
		}
	}

	public void add_OrtonEncounterMapEntityChosen(Action<MapEntity> value)
	{
		OrtonEncounterMapEntityChosen = (Action<MapEntity>)Delegate.Combine(OrtonEncounterMapEntityChosen, value);
	}

	public void remove_OrtonEncounterMapEntityChosen(Action<MapEntity> value)
	{
		OrtonEncounterMapEntityChosen = (Action<MapEntity>)Delegate.Remove(OrtonEncounterMapEntityChosen, value);
	}

	public void OnOrtonEncounterMapEntityChosen(MapEntity entity)
	{
		if (OrtonEncounterMapEntityChosen != null)
		{
			OrtonEncounterMapEntityChosen(entity);
		}
	}

	public void add_MapEntityInteractionFinished(Action<MapEntity, bool> value)
	{
		MapEntityInteractionFinished = (Action<MapEntity, bool>)Delegate.Combine(MapEntityInteractionFinished, value);
	}

	public void remove_MapEntityInteractionFinished(Action<MapEntity, bool> value)
	{
		MapEntityInteractionFinished = (Action<MapEntity, bool>)Delegate.Remove(MapEntityInteractionFinished, value);
	}

	public void OnMapEntityInteractionFinished(MapEntity entity, bool giveRewards)
	{
		if (MapEntityInteractionFinished != null)
		{
			MapEntityInteractionFinished(entity, giveRewards);
		}
	}

	public void add_MapEntityScanned(Action<MapEntity> value)
	{
		MapEntityScanned = (Action<MapEntity>)Delegate.Combine(MapEntityScanned, value);
	}

	public void remove_MapEntityScanned(Action<MapEntity> value)
	{
		MapEntityScanned = (Action<MapEntity>)Delegate.Remove(MapEntityScanned, value);
	}

	public void OnMapEntityScanned(MapEntity entity)
	{
		if (MapEntityScanned != null)
		{
			MapEntityScanned(entity);
		}
	}

	public void add_MapEntitiesModelsUpdated(Action<IEnumerable<MapEntity>> value)
	{
		MapEntitiesModelsUpdated = (Action<IEnumerable<MapEntity>>)Delegate.Combine(MapEntitiesModelsUpdated, value);
	}

	public void remove_MapEntitiesModelsUpdated(Action<IEnumerable<MapEntity>> value)
	{
		MapEntitiesModelsUpdated = (Action<IEnumerable<MapEntity>>)Delegate.Remove(MapEntitiesModelsUpdated, value);
	}

	public void OnMapEntitiesModelsUpdated(IEnumerable<MapEntity> e)
	{
		if (MapEntitiesModelsUpdated != null)
		{
			MapEntitiesModelsUpdated(e);
		}
	}

	public void add_EntityWanderingAnimatronicDisplayRequestReceived(Action<EntityDisplayData> value)
	{
		EntityWanderingAnimatronicDisplayRequestReceived = (Action<EntityDisplayData>)Delegate.Combine(EntityWanderingAnimatronicDisplayRequestReceived, value);
	}

	public void remove_EntityWanderingAnimatronicDisplayRequestReceived(Action<EntityDisplayData> value)
	{
		EntityWanderingAnimatronicDisplayRequestReceived = (Action<EntityDisplayData>)Delegate.Remove(EntityWanderingAnimatronicDisplayRequestReceived, value);
	}

	public void OnEntityWanderingAnimatronicDisplayRequestReceived(EntityDisplayData data)
	{
		if (EntityWanderingAnimatronicDisplayRequestReceived != null)
		{
			EntityWanderingAnimatronicDisplayRequestReceived(data);
		}
	}

	public void add_EntitySpecialDeliveryDisplayRequestReceived(Action<EntityDisplayData> value)
	{
		EntitySpecialDeliveryDisplayRequestReceived = (Action<EntityDisplayData>)Delegate.Combine(EntitySpecialDeliveryDisplayRequestReceived, value);
	}

	public void remove_EntitySpecialDeliveryDisplayRequestReceived(Action<EntityDisplayData> value)
	{
		EntitySpecialDeliveryDisplayRequestReceived = (Action<EntityDisplayData>)Delegate.Remove(EntitySpecialDeliveryDisplayRequestReceived, value);
	}

	public void OnEntitySpecialDeliveryDisplayRequestReceived(EntityDisplayData data)
	{
		if (EntitySpecialDeliveryDisplayRequestReceived != null)
		{
			EntitySpecialDeliveryDisplayRequestReceived(data);
		}
	}

	public void add_StreakDataUpdated(Action<StreakData> value)
	{
		StreakDataUpdated = (Action<StreakData>)Delegate.Combine(StreakDataUpdated, value);
	}

	public void remove_StreakDataUpdated(Action<StreakData> value)
	{
		StreakDataUpdated = (Action<StreakData>)Delegate.Remove(StreakDataUpdated, value);
	}

	public void OnStreakDataUpdated(StreakData data)
	{
		if (StreakDataUpdated != null)
		{
			StreakDataUpdated(data);
		}
	}

	public void add_InventoryUpdated(Action<PlayerInventory> value)
	{
		InventoryUpdated = (Action<PlayerInventory>)Delegate.Combine(InventoryUpdated, value);
	}

	public void remove_InventoryUpdated(Action<PlayerInventory> value)
	{
		InventoryUpdated = (Action<PlayerInventory>)Delegate.Remove(InventoryUpdated, value);
	}

	public void OnInventoryUpdated(PlayerInventory e)
	{
		if (InventoryUpdated != null)
		{
			InventoryUpdated(e);
		}
	}

	public void add_SceneLoaded(Action<GameDisplayData.DisplayType> value)
	{
		SceneLoaded = (Action<GameDisplayData.DisplayType>)Delegate.Combine(SceneLoaded, value);
	}

	public void remove_SceneLoaded(Action<GameDisplayData.DisplayType> value)
	{
		SceneLoaded = (Action<GameDisplayData.DisplayType>)Delegate.Remove(SceneLoaded, value);
	}

	public void OnSceneLoaded(GameDisplayData.DisplayType type)
	{
		if (SceneLoaded != null)
		{
			SceneLoaded(type);
		}
	}

	public void add_VirtualGoodsDataReceived(Action<List<StoreContainer.StorefrontData>> value)
	{
		VirtualGoodsDataReceived = (Action<List<StoreContainer.StorefrontData>>)Delegate.Combine(VirtualGoodsDataReceived, value);
	}

	public void remove_VirtualGoodsDataReceived(Action<List<StoreContainer.StorefrontData>> value)
	{
		VirtualGoodsDataReceived = (Action<List<StoreContainer.StorefrontData>>)Delegate.Remove(VirtualGoodsDataReceived, value);
	}

	public void OnVirtualGoodsDataReceived(List<StoreContainer.StorefrontData> response)
	{
		if (VirtualGoodsDataReceived != null)
		{
			VirtualGoodsDataReceived(response);
		}
	}

	public void add_PlayerGoodsUpdated(Action<Dictionary<string, int>> value)
	{
		PlayerGoodsUpdated = (Action<Dictionary<string, int>>)Delegate.Combine(PlayerGoodsUpdated, value);
	}

	public void remove_PlayerGoodsUpdated(Action<Dictionary<string, int>> value)
	{
		PlayerGoodsUpdated = (Action<Dictionary<string, int>>)Delegate.Remove(PlayerGoodsUpdated, value);
	}

	public void OnPlayerGoodsUpdated(Dictionary<string, int> ownedGoods)
	{
		if (PlayerGoodsUpdated != null)
		{
			PlayerGoodsUpdated(ownedGoods);
		}
	}

	public void add_PlayerStoreDataUpdated(Action<long> value)
	{
		PlayerStoreDataUpdated = (Action<long>)Delegate.Combine(PlayerStoreDataUpdated, value);
	}

	public void remove_PlayerStoreDataUpdated(Action<long> value)
	{
		PlayerStoreDataUpdated = (Action<long>)Delegate.Remove(PlayerStoreDataUpdated, value);
	}

	public void OnPlayerStoreDataUpdated(long timestamp)
	{
		if (PlayerStoreDataUpdated != null)
		{
			PlayerStoreDataUpdated(timestamp);
		}
	}

	public void add_StoreDialogRequestReceived(Action<StoreDisplayData> value)
	{
		StoreDialogRequestReceived = (Action<StoreDisplayData>)Delegate.Combine(StoreDialogRequestReceived, value);
	}

	public void remove_StoreDialogRequestReceived(Action<StoreDisplayData> value)
	{
		StoreDialogRequestReceived = (Action<StoreDisplayData>)Delegate.Remove(StoreDialogRequestReceived, value);
	}

	public void OnStoreDialogRequest(StoreDisplayData storeDisplayData)
	{
		if (StoreDialogRequestReceived != null)
		{
			StoreDialogRequestReceived(storeDisplayData);
		}
	}

	public void add_PurchaseRequestAudioInvoked(Action<bool> value)
	{
		PurchaseRequestAudioInvoked = (Action<bool>)Delegate.Combine(PurchaseRequestAudioInvoked, value);
	}

	public void remove_PurchaseRequestAudioInvoked(Action<bool> value)
	{
		PurchaseRequestAudioInvoked = (Action<bool>)Delegate.Remove(PurchaseRequestAudioInvoked, value);
	}

	public void OnPurchaseRequestAudioInvoked(bool canAfford)
	{
		if (PurchaseRequestAudioInvoked != null)
		{
			PurchaseRequestAudioInvoked(canAfford);
		}
	}

	public void add_BuyMoreCoinsDialogRequest(Action value)
	{
		BuyMoreCoinsDialogRequest = (Action)Delegate.Combine(BuyMoreCoinsDialogRequest, value);
	}

	public void remove_BuyMoreCoinsDialogRequest(Action value)
	{
		BuyMoreCoinsDialogRequest = (Action)Delegate.Remove(BuyMoreCoinsDialogRequest, value);
	}

	public void OnBuyMoreCoinsDialogRequest()
	{
		if (BuyMoreCoinsDialogRequest != null)
		{
			BuyMoreCoinsDialogRequest();
		}
	}

	public void add_ExitAttackSequenceReceived(Action<ExitAttackSequenceDialogData> value)
	{
		ExitAttackSequenceReceived = (Action<ExitAttackSequenceDialogData>)Delegate.Combine(ExitAttackSequenceReceived, value);
	}

	public void remove_ExitAttackSequenceReceived(Action<ExitAttackSequenceDialogData> value)
	{
		ExitAttackSequenceReceived = (Action<ExitAttackSequenceDialogData>)Delegate.Remove(ExitAttackSequenceReceived, value);
	}

	public void OnExitAttackSequenceReceived(ExitAttackSequenceDialogData data)
	{
		if (ExitAttackSequenceReceived != null)
		{
			ExitAttackSequenceReceived(data);
		}
	}

	public void add_TrophyInventoryUpdated(Action<TrophyInventory> value)
	{
		TrophyInventoryUpdated = (Action<TrophyInventory>)Delegate.Combine(TrophyInventoryUpdated, value);
	}

	public void remove_TrophyInventoryUpdated(Action<TrophyInventory> value)
	{
		TrophyInventoryUpdated = (Action<TrophyInventory>)Delegate.Remove(TrophyInventoryUpdated, value);
	}

	public void OnTrophyInventoryUpdated(TrophyInventory data)
	{
		if (TrophyInventoryUpdated != null)
		{
			TrophyInventoryUpdated(data);
		}
	}

	public void add_TrophyChanged(Action<TrophyData> value)
	{
		TrophyChanged = (Action<TrophyData>)Delegate.Combine(TrophyChanged, value);
	}

	public void remove_TrophyChanged(Action<TrophyData> value)
	{
		TrophyChanged = (Action<TrophyData>)Delegate.Remove(TrophyChanged, value);
	}

	public void OnTrophyChanged(TrophyData data)
	{
		if (TrophyChanged != null)
		{
			TrophyChanged(data);
		}
	}

	public void add_PersonalFriendCodeUpdated(Action<string> value)
	{
		PersonalFriendCodeUpdated = (Action<string>)Delegate.Combine(PersonalFriendCodeUpdated, value);
	}

	public void remove_PersonalFriendCodeUpdated(Action<string> value)
	{
		PersonalFriendCodeUpdated = (Action<string>)Delegate.Remove(PersonalFriendCodeUpdated, value);
	}

	public void add_FriendCodeLookedUp(Action<FriendCodeResponseHandler.FriendLookupResponse> value)
	{
		FriendCodeLookedUp = (Action<FriendCodeResponseHandler.FriendLookupResponse>)Delegate.Combine(FriendCodeLookedUp, value);
	}

	public void remove_FriendCodeLookedUp(Action<FriendCodeResponseHandler.FriendLookupResponse> value)
	{
		FriendCodeLookedUp = (Action<FriendCodeResponseHandler.FriendLookupResponse>)Delegate.Remove(FriendCodeLookedUp, value);
	}

	public void OnPersonalFriendCodeUpdated(string friendCode)
	{
		if (PersonalFriendCodeUpdated != null)
		{
			PersonalFriendCodeUpdated(friendCode);
		}
	}

	public void OnFriendCodeLookedUp(FriendCodeResponseHandler.FriendLookupResponse response)
	{
		if (FriendCodeLookedUp != null)
		{
			FriendCodeLookedUp(response);
		}
	}

	public void add_PlayerAvatarUnlockedListReceived(Action<List<string>> value)
	{
		PlayerAvatarUnlockedListReceived = (Action<List<string>>)Delegate.Combine(PlayerAvatarUnlockedListReceived, value);
	}

	public void remove_PlayerAvatarUnlockedListReceived(Action<List<string>> value)
	{
		PlayerAvatarUnlockedListReceived = (Action<List<string>>)Delegate.Remove(PlayerAvatarUnlockedListReceived, value);
	}

	public void OnPlayerAvatarUnlockedListReceived(List<string> obj)
	{
		if (PlayerAvatarUnlockedListReceived != null)
		{
			PlayerAvatarUnlockedListReceived(obj);
		}
	}

	public void add_PlayerProfileUpdated(Action<PlayerProfile> value)
	{
		PlayerProfileUpdated = (Action<PlayerProfile>)Delegate.Combine(PlayerProfileUpdated, value);
	}

	public void remove_PlayerProfileUpdated(Action<PlayerProfile> value)
	{
		PlayerProfileUpdated = (Action<PlayerProfile>)Delegate.Remove(PlayerProfileUpdated, value);
	}

	public void add_PlayerAvatarUpdated(Action value)
	{
		PlayerAvatarUpdated = (Action)Delegate.Combine(PlayerAvatarUpdated, value);
	}

	public void remove_PlayerAvatarUpdated(Action value)
	{
		PlayerAvatarUpdated = (Action)Delegate.Remove(PlayerAvatarUpdated, value);
	}

	public void add_DisplayNameObscenityFound(Action<UserNameSetError> value)
	{
		DisplayNameObscenityFound = (Action<UserNameSetError>)Delegate.Combine(DisplayNameObscenityFound, value);
	}

	public void remove_DisplayNameObscenityFound(Action<UserNameSetError> value)
	{
		DisplayNameObscenityFound = (Action<UserNameSetError>)Delegate.Remove(DisplayNameObscenityFound, value);
	}

	public void OnPlayerProfileUpdated(PlayerProfile data)
	{
		if (PlayerProfileUpdated != null)
		{
			PlayerProfileUpdated(data);
		}
	}

	public void OnPlayerAvatarUpdated()
	{
		if (PlayerAvatarUpdated != null)
		{
			PlayerAvatarUpdated();
		}
	}

	public void OnDisplayNameObscenityFound(UserNameSetError error)
	{
		if (DisplayNameObscenityFound != null)
		{
			DisplayNameObscenityFound(error);
		}
	}

	public void add_GeneratePlayStreamEventReceived(Action<bool> value)
	{
		GeneratePlayStreamEventReceived = (Action<bool>)Delegate.Combine(GeneratePlayStreamEventReceived, value);
	}

	public void remove_GeneratePlayStreamEventReceived(Action<bool> value)
	{
		GeneratePlayStreamEventReceived = (Action<bool>)Delegate.Remove(GeneratePlayStreamEventReceived, value);
	}

	public void OnGeneratePlayStreamEventReceived(bool generatePlayStreamEvent)
	{
		if (GeneratePlayStreamEventReceived != null)
		{
			GeneratePlayStreamEventReceived(generatePlayStreamEvent);
		}
	}

	public void add_EntityIntroDisplayRequestReceived(Action<IntroScreen.IntroScreenDialogData> value)
	{
		EntityIntroDisplayRequestReceived = (Action<IntroScreen.IntroScreenDialogData>)Delegate.Combine(EntityIntroDisplayRequestReceived, value);
	}

	public void remove_EntityIntroDisplayRequestReceived(Action<IntroScreen.IntroScreenDialogData> value)
	{
		EntityIntroDisplayRequestReceived = (Action<IntroScreen.IntroScreenDialogData>)Delegate.Remove(EntityIntroDisplayRequestReceived, value);
	}

	public void OnEntityIntroDisplayRequestReceived(IntroScreen.IntroScreenDialogData data)
	{
		if (EntityIntroDisplayRequestReceived != null)
		{
			EntityIntroDisplayRequestReceived(data);
		}
	}

	public void add_RewardDialogOpened(Action value)
	{
		RewardDialogOpened = (Action)Delegate.Combine(RewardDialogOpened, value);
	}

	public void remove_RewardDialogOpened(Action value)
	{
		RewardDialogOpened = (Action)Delegate.Remove(RewardDialogOpened, value);
	}

	public void add_RewardDialogClosed(Action value)
	{
		RewardDialogClosed = (Action)Delegate.Combine(RewardDialogClosed, value);
	}

	public void remove_RewardDialogClosed(Action value)
	{
		RewardDialogClosed = (Action)Delegate.Remove(RewardDialogClosed, value);
	}

	public void OnRewardDialogOpened()
	{
		if (RewardDialogOpened != null)
		{
			RewardDialogOpened();
		}
	}

	public void OnRewardDialogClosed()
	{
		if (RewardDialogClosed != null)
		{
			RewardDialogClosed();
		}
	}

	public void add_ModInventoryUpdated(Action<ModInventory> value)
	{
		ModInventoryUpdated = (Action<ModInventory>)Delegate.Combine(ModInventoryUpdated, value);
	}

	public void remove_ModInventoryUpdated(Action<ModInventory> value)
	{
		ModInventoryUpdated = (Action<ModInventory>)Delegate.Remove(ModInventoryUpdated, value);
	}

	public void OnModInventoryUpdated(ModInventory data)
	{
		if (ModInventoryUpdated != null)
		{
			ModInventoryUpdated(data);
		}
	}

	public void add_StoreOpened(Action value)
	{
		StoreOpened = (Action)Delegate.Combine(StoreOpened, value);
	}

	public void remove_StoreOpened(Action value)
	{
		StoreOpened = (Action)Delegate.Remove(StoreOpened, value);
	}

	public void add_StoreClosed(Action value)
	{
		StoreClosed = (Action)Delegate.Combine(StoreClosed, value);
	}

	public void remove_StoreClosed(Action value)
	{
		StoreClosed = (Action)Delegate.Remove(StoreClosed, value);
	}

	public void OnStoreOpened()
	{
		if (StoreOpened != null)
		{
			StoreOpened();
		}
	}

	public void OnStoreClosed()
	{
		if (StoreClosed != null)
		{
			StoreClosed();
		}
	}

	public void add_OrtonScavengingEncounterMapEntityChosen(Action<ScavengingEntity> value)
	{
		OrtonScavengingEncounterMapEntityChosen = (Action<ScavengingEntity>)Delegate.Combine(OrtonScavengingEncounterMapEntityChosen, value);
	}

	public void remove_OrtonScavengingEncounterMapEntityChosen(Action<ScavengingEntity> value)
	{
		OrtonScavengingEncounterMapEntityChosen = (Action<ScavengingEntity>)Delegate.Remove(OrtonScavengingEncounterMapEntityChosen, value);
	}

	public void OnOrtonScavengingEncounterMapEntityChosen(ScavengingEntity entity)
	{
		if (OrtonScavengingEncounterMapEntityChosen != null)
		{
			OrtonScavengingEncounterMapEntityChosen(entity);
		}
	}

	public void add_AnimatronicScavengingEncounterStarted(Action<ScavengingEntity> value)
	{
		AnimatronicScavengingEncounterStarted = (Action<ScavengingEntity>)Delegate.Combine(AnimatronicScavengingEncounterStarted, value);
	}

	public void remove_AnimatronicScavengingEncounterStarted(Action<ScavengingEntity> value)
	{
		AnimatronicScavengingEncounterStarted = (Action<ScavengingEntity>)Delegate.Remove(AnimatronicScavengingEncounterStarted, value);
	}

	public void OnAnimatronicScavengingEncounterStarted(ScavengingEntity entity)
	{
		if (AnimatronicScavengingEncounterStarted == null)
		{
			Debug.Log("AnimatronicScavengingEncounterStarted is NULL.");
		}
		else
		{
			AnimatronicScavengingEncounterStarted(entity);
		}
	}

	public void add_StartAttackScavengingEncounter(Action<ScavengingEncounter> value)
	{
		StartAttackScavengingEncounter = (Action<ScavengingEncounter>)Delegate.Combine(StartAttackScavengingEncounter, value);
	}

	public void remove_StartAttackScavengingEncounter(Action<ScavengingEncounter> value)
	{
		StartAttackScavengingEncounter = (Action<ScavengingEncounter>)Delegate.Remove(StartAttackScavengingEncounter, value);
	}

	public void OnStartAttackScavengingEncounter(ScavengingEncounter encounter)
	{
		if (StartAttackScavengingEncounter != null)
		{
			StartAttackScavengingEncounter(encounter);
		}
	}

	public void add_AttackScavengingEncounterStarted(Action<EncounterType> value)
	{
		AttackScavengingEncounterStarted = (Action<EncounterType>)Delegate.Combine(AttackScavengingEncounterStarted, value);
	}

	public void remove_AttackScavengingEncounterStarted(Action<EncounterType> value)
	{
		AttackScavengingEncounterStarted = (Action<EncounterType>)Delegate.Remove(AttackScavengingEncounterStarted, value);
	}

	public void OnAttackScavengingEncounterStarted(EncounterType type)
	{
		if (AttackScavengingEncounterStarted != null)
		{
			AttackScavengingEncounterStarted(type);
		}
	}

	public void add_AttackScavengingEncounterEnded(Action value)
	{
		AttackScavengingEncounterEnded = (Action)Delegate.Combine(AttackScavengingEncounterEnded, value);
	}

	public void remove_AttackScavengingEncounterEnded(Action value)
	{
		AttackScavengingEncounterEnded = (Action)Delegate.Remove(AttackScavengingEncounterEnded, value);
	}

	public void OnAttackScavengingEncounterEnded()
	{
		if (AttackScavengingEncounterEnded != null)
		{
			AttackScavengingEncounterEnded();
		}
	}

	public void add_ScavengingEncounterAnimatronicInitialized(Action<string> value)
	{
		ScavengingEncounterAnimatronicInitialized = (Action<string>)Delegate.Combine(ScavengingEncounterAnimatronicInitialized, value);
	}

	public void remove_ScavengingEncounterAnimatronicInitialized(Action<string> value)
	{
		ScavengingEncounterAnimatronicInitialized = (Action<string>)Delegate.Remove(ScavengingEncounterAnimatronicInitialized, value);
	}

	public void OnScavengingEncounterAnimatronicInitialized(string cpuId)
	{
		if (ScavengingEncounterAnimatronicInitialized != null)
		{
			ScavengingEncounterAnimatronicInitialized(cpuId);
		}
	}

	public void add_ScavengingEntitiesReceivedFromServer(Action<IEnumerable<ScavengingEntitySynchronizeableState>> value)
	{
		ScavengingEntitiesReceivedFromServer = (Action<IEnumerable<ScavengingEntitySynchronizeableState>>)Delegate.Combine(ScavengingEntitiesReceivedFromServer, value);
	}

	public void remove_ScavengingEntitiesReceivedFromServer(Action<IEnumerable<ScavengingEntitySynchronizeableState>> value)
	{
		ScavengingEntitiesReceivedFromServer = (Action<IEnumerable<ScavengingEntitySynchronizeableState>>)Delegate.Remove(ScavengingEntitiesReceivedFromServer, value);
	}

	public void OnScavengingEntitiesReceivedFromServer(IEnumerable<ScavengingEntitySynchronizeableState> e)
	{
		Debug.Log("GOT Scavenging ENTITIES FROM SERVER! IT WORKS!");
		foreach (ScavengingEntitySynchronizeableState item in e)
		{
			Debug.Log("SCAVENGE SUIT - " + item.parts["PlushSuit"]);
			Debug.Log("SCAVENGE CPU - " + item.parts["Cpu"]);
		}
		if (ScavengingEntitiesReceivedFromServer != null)
		{
			ScavengingEntitiesReceivedFromServer(e);
		}
	}

	public void add_ScavengingEntitiesModelsUpdated(Action<IEnumerable<ScavengingEntity>> value)
	{
		ScavengingEntitiesModelsUpdated = (Action<IEnumerable<ScavengingEntity>>)Delegate.Combine(ScavengingEntitiesModelsUpdated, value);
	}

	public void remove_ScavengingEntitiesModelsUpdated(Action<IEnumerable<ScavengingEntity>> value)
	{
		ScavengingEntitiesModelsUpdated = (Action<IEnumerable<ScavengingEntity>>)Delegate.Remove(ScavengingEntitiesModelsUpdated, value);
	}

	public void OnScavengingEntitiesModelsUpdated(IEnumerable<ScavengingEntity> e)
	{
		if (ScavengingEntitiesModelsUpdated != null)
		{
			ScavengingEntitiesModelsUpdated(e);
		}
	}
}
