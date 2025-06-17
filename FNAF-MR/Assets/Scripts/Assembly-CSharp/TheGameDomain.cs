using System.Collections.Generic;
using UnityEngine;

public class TheGameDomain
{
	private MasterDomain _masterDomain;

	private GameDisplayData.DisplayType _startingGameDisplay;

	private TouchDetector _touchDetector;

	public PlayerInventory playerInventory;

	public bool GameActive;

	public Dictionary<GameDisplayData.DisplayType, GameObject> displayKeyValuePairs { get; }

	public Dictionary<GameDisplayData.DisplayType, string> sceneKeyValuePairs { get; }

	public GameDisplayChanger gameDisplayChanger { get; set; }

	public LoginDomain loginDomain { get; set; }

	public CurrencyBank bank { get; set; }

	public Container container => _masterDomain.AnimatronicEntityDomain.container;

	public SkyboxSceneConfig SkyboxConfigs => _masterDomain.SkyboxConfigs;

	public EventExposer eventExposer => _masterDomain.eventExposer;

	public MapEntity ActiveMapEntity { get; set; }

	public ScavengingEntity ActiveScavengingEntity { get; set; }

	private void GetWorkshopLookupTable(WorkshopSceneLookupTable workshopSceneLookupTable)
	{
		displayKeyValuePairs.Add(GameDisplayData.DisplayType.workshop, workshopSceneLookupTable.DisplayParent);
	}

	private void GetCameraLookupTable(CameraSceneLookupTable cameraSceneLookupTable)
	{
		displayKeyValuePairs.Remove(GameDisplayData.DisplayType.camera);
		displayKeyValuePairs.Remove(GameDisplayData.DisplayType.scavengingui);
		displayKeyValuePairs.Add(GameDisplayData.DisplayType.camera, cameraSceneLookupTable.DisplayParent);
		displayKeyValuePairs.Add(GameDisplayData.DisplayType.scavengingui, cameraSceneLookupTable.DisplayParent);
	}

	private void RegisterScenes()
	{
		sceneKeyValuePairs.Add(GameDisplayData.DisplayType.map, "Lobby");
		sceneKeyValuePairs.Add(GameDisplayData.DisplayType.camera, "Encounter");
		sceneKeyValuePairs.Add(GameDisplayData.DisplayType.results, "Results");
		sceneKeyValuePairs.Add(GameDisplayData.DisplayType.scavengingui, "ScavengingUI");
	}

	private void OnOrtonEntityChosen(MapEntity entity)
	{
		ActiveMapEntity = entity;
		gameDisplayChanger.RequestDisplayChange(GameDisplayData.DisplayType.camera);
	}

	private void OnOrtonScavengingEntityChosen(ScavengingEntity entity)
	{
		ActiveScavengingEntity = entity;
		gameDisplayChanger.RequestDisplayChange(GameDisplayData.DisplayType.scavengingui);
	}

	public void OnGameDisplayDidChange()
	{
		eventExposer.OnAnimatronicEncounterStarted(ActiveMapEntity);
	}

	public void OnGameDisplayDidChangeScavenging()
	{
		eventExposer.OnAnimatronicScavengingEncounterStarted(ActiveScavengingEntity);
	}

	private void EventExposer_MapEntityHasSpawnedAnimatronic(List<AnimatronicEntity> entities)
	{
	}

	private void OnPlayerCurrencyRefreshed(Dictionary<string, int> data)
	{
		bank.SetBank(data);
	}

	private void OnAttackEncounterEnded(EncounterResult result)
	{
		_masterDomain.TheGameDomain.gameDisplayChanger.RequestDisplayChange(GameDisplayData.DisplayType.results);
	}

	private void EventExposer_InventoryUpdated(PlayerInventory obj)
	{
		playerInventory = obj;
	}

	private void Initialize()
	{
		GameActive = true;
		gameDisplayChanger = new GameDisplayChanger(this, _masterDomain.SceneLookupTableAccess);
		playerInventory = new PlayerInventory();
		loginDomain = new LoginDomain(_masterDomain.ServerDomain, _masterDomain.eventExposer.OnGeneratePlayStreamEventReceived);
		bank = new CurrencyBank();
		_touchDetector = new TouchDetector(OnTouchDetected);
		loginDomain.Setup(_masterDomain.eventExposer, _masterDomain.ServerDomain, null, null, null);
	}

	private void OnTouchDetected(Vector2 position)
	{
		_masterDomain.eventExposer.OnTouchDetected(position);
	}

	public TheGameDomain(MasterDomain masterDomain)
	{
		_masterDomain = masterDomain;
		displayKeyValuePairs = new Dictionary<GameDisplayData.DisplayType, GameObject>();
		sceneKeyValuePairs = new Dictionary<GameDisplayData.DisplayType, string>();
		Initialize();
	}

	public void Setup()
	{
		if (_masterDomain != null)
		{
			RegisterScenes();
			_masterDomain.SceneLookupTableAccess.GetCameraSceneLookupTableAsync(GetCameraLookupTable);
			gameDisplayChanger.Start();
			_masterDomain.eventExposer.add_PlayerCurrencyRefreshed(OnPlayerCurrencyRefreshed);
			_masterDomain.eventExposer.add_InventoryUpdated(EventExposer_InventoryUpdated);
			_masterDomain.eventExposer.add_MapEntityHasSpawnedAnimatronics(EventExposer_MapEntityHasSpawnedAnimatronic);
			_masterDomain.eventExposer.add_AttackSequenceReadyForUi(OnAttackEncounterEnded);
			_masterDomain.eventExposer.add_OrtonEncounterMapEntityChosen(OnOrtonEntityChosen);
			_masterDomain.eventExposer.add_OrtonScavengingEncounterMapEntityChosen(OnOrtonScavengingEntityChosen);
			_masterDomain.eventExposer.add_GameDisplayChange(GameDisplayChanged);
		}
	}

	private void GameDisplayChanged(GameDisplayData yeah)
	{
		if (yeah.currentDisplay == GameDisplayData.DisplayType.camera || yeah.currentDisplay == GameDisplayData.DisplayType.scavengingui)
		{
			_masterDomain.SceneLookupTableAccess.GetCameraSceneLookupTableAsync(GetCameraLookupTable);
		}
	}

	public void Teardown()
	{
		bank = null;
		playerInventory = null;
		if (_masterDomain.eventExposer != null)
		{
			_masterDomain.eventExposer.remove_PlayerCurrencyRefreshed(OnPlayerCurrencyRefreshed);
			_masterDomain.eventExposer.remove_InventoryUpdated(EventExposer_InventoryUpdated);
			_masterDomain.eventExposer.remove_MapEntityHasSpawnedAnimatronics(EventExposer_MapEntityHasSpawnedAnimatronic);
			_masterDomain.eventExposer.remove_AttackSequenceReadyForUi(OnAttackEncounterEnded);
			_masterDomain.eventExposer.remove_OrtonEncounterMapEntityChosen(OnOrtonEntityChosen);
			_masterDomain.eventExposer.remove_OrtonScavengingEncounterMapEntityChosen(OnOrtonScavengingEntityChosen);
			_masterDomain.eventExposer.remove_GameDisplayChange(GameDisplayChanged);
		}
	}

	public void Update()
	{
		_touchDetector.Update();
	}
}
