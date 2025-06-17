using System.Collections.Generic;
using UnityEngine;

public class StartupHandler
{
	private ServerDomainBuilder _serverDomainBuilder;

	private StartupParameters _data;

	public void Setup(StartupParameters startupData)
	{
		_data = startupData;
		_data.RegisteredTeardownCallbacks.Clear();
		CreateDomains(startupData.MasterDomainGetter());
	}

	public void Teardown()
	{
		_serverDomainBuilder = null;
		_data = null;
	}

	private void CreateDomains(MasterDomain masterDomain)
	{
		Transform transform = _data.HostMonobehavior.transform;
		SceneLookupTableAccess sceneLookupTableAccess = _data.UnityHooks.SceneLookupTableAccess;
		masterDomain.MasterDataDomain = new MasterDataDomain(masterDomain.eventExposer);
		masterDomain.GameAssetManagementDomain = new GameAssetManagementDomain(masterDomain.eventExposer, masterDomain.MasterDataDomain);
		masterDomain.Animatronic3DDomain = new Animatronic3DDomain(transform);
		masterDomain.AnimatronicEntityDomain = new AnimatronicEntityDomain(masterDomain.eventExposer, masterDomain.MasterDataDomain);
		masterDomain.AttackSequenceDomain = new AttackSequenceDomain(masterDomain.eventExposer, masterDomain.MasterDataDomain);
		masterDomain.CameraEquipmentDomain = new CameraEquipmentDomain();
		masterDomain.DialogDomain = new DialogDomain();
		masterDomain.GameAudioDomain = new GameAudioDomain(transform, masterDomain.eventExposer, sceneLookupTableAccess, masterDomain.MasterDataDomain);
		masterDomain.GameUIDomain = new GameUIDomain(masterDomain.eventExposer);
		masterDomain.LocalizationDomain = new LocalizationDomain();
		masterDomain.ItemDefinitionDomain = new ItemDefinitionDomain(masterDomain.eventExposer, masterDomain.MasterDataDomain);
		masterDomain.PlayerAvatarDomain = new PlayerAvatarDomain();
		masterDomain.MapEntityDomain = new MapEntityDomain(masterDomain.eventExposer, masterDomain.MasterDataDomain);
		masterDomain.ServerDomain = new ServerDomain();
		masterDomain.StoreDomain = new StoreDomain(masterDomain.eventExposer);
		masterDomain.TheGameDomain = new TheGameDomain(masterDomain);
		masterDomain.UpdateHandler = new MasterDomainUpdateHandler();
		masterDomain.WorkshopDomain = new WorkshopDomain(masterDomain.eventExposer);
		masterDomain.LootDomain = new LootDomain(masterDomain.eventExposer, masterDomain.WorkshopDomain, masterDomain.ServerDomain);
		masterDomain.ScavengingEntityDomain = new ScavengingEntityDomain(masterDomain.eventExposer, masterDomain.MasterDataDomain);
	}

	private void SetupDomains(MasterDomain masterDomain)
	{
		masterDomain.GameUIDomain.Setup(masterDomain, _data.HostMonobehavior);
		masterDomain.LocalizationDomain.Setup(_data.UnityHooks.LocalLocalizationKVPs);
		masterDomain.ItemDefinitionDomain.Setup();
		masterDomain.AnimatronicEntityDomain.Setup(_data.UnityHooks.SceneLookupTableAccess, _data.UnityHooks.Configs.AnimatronicEntityConfig, masterDomain.ItemDefinitionDomain, masterDomain.ServerDomain);
		masterDomain.Animatronic3DDomain.Setup(masterDomain.GameAssetManagementDomain, masterDomain.GameAudioDomain);
		masterDomain.TheGameDomain.Setup();
		SetupServerDomain(masterDomain);
		masterDomain.GameAudioDomain.Setup(masterDomain.GameAssetManagementDomain);
		masterDomain.CameraEquipmentDomain.Setup(_data.UnityHooks.SceneLookupTableAccess, masterDomain.eventExposer, masterDomain.MasterDataDomain, masterDomain.ItemDefinitionDomain);
		masterDomain.MasterDataDomain.Setup();
		masterDomain.MasterDataDomain.GetAccessToData.GetLocDataAsync(OnLocalizationReceived);
		masterDomain.AttackSequenceDomain.Setup(_data.UnityHooks.SceneLookupTableAccess, masterDomain.AnimatronicEntityDomain, masterDomain.Animatronic3DDomain, masterDomain.CameraEquipmentDomain, masterDomain.ItemDefinitionDomain, _data.UnityHooks.CameraFx, masterDomain.TheGameDomain.gameDisplayChanger, masterDomain.GameAudioDomain, masterDomain.GameAssetManagementDomain, masterDomain.LootDomain, masterDomain.ServerDomain);
		masterDomain.DialogDomain.Setup(masterDomain.GameAudioDomain);
		masterDomain.LootDomain.Setup(masterDomain.MasterDataDomain);
		masterDomain.MapEntityDomain.Setup(masterDomain.ServerDomain, masterDomain.ItemDefinitionDomain.ItemDefinitions);
		masterDomain.PlayerAvatarDomain.Setup(masterDomain.GameAssetManagementDomain, masterDomain.ItemDefinitionDomain.ItemDefinitions, masterDomain.GameUIDomain);
		masterDomain.StoreDomain.Setup(masterDomain.MasterDataDomain, masterDomain.TheGameDomain.gameDisplayChanger, masterDomain.GameAssetManagementDomain.IconLookupAccess, masterDomain.ItemDefinitionDomain.ItemDefinitions, masterDomain.ServerDomain, masterDomain.TheGameDomain.bank);
		masterDomain.UpdateHandler.Setup(masterDomain);
		masterDomain.WorkshopDomain.Setup(masterDomain.ItemDefinitionDomain);
		masterDomain.ScavengingEntityDomain.Setup(masterDomain.ServerDomain, masterDomain.ItemDefinitionDomain.ItemDefinitions);
	}

	private static void OnLocalizationReceived(LOC_DATA.Root locData)
	{
		Dictionary<string, LocDataEntry> dictionary = new Dictionary<string, LocDataEntry>();
		foreach (LOC_DATA.Entry entry in locData.Entries)
		{
			LocDataEntry value = new LocDataEntry(entry.English, entry.French, entry.Italian, entry.German, entry.Spanish_Spain, entry.Portuguese_Brazil, entry.Russian);
			dictionary.Add(entry.ID, value);
		}
		GameLifecycleProxy.GetMasterDomain().LocalizationDomain.OnLocalizationReceived(dictionary);
	}

	private void SetupServerDomain(MasterDomain masterDomain)
	{
		_serverDomainBuilder = new ServerDomainBuilder(masterDomain);
		_serverDomainBuilder.SetupDomain(masterDomain);
	}

	private void SetupLoadingHandler(MasterDomain masterDomain)
	{
	}

	public void StartupGame()
	{
		Debug.Log("StartupGame called");
		MasterDomain masterDomain = _data.MasterDomainGetter();
		SetupDomains(masterDomain);
		SetupLoadingHandler(masterDomain);
		if (_data.HasToSBeenAcceptedYet)
		{
		}
		_ = masterDomain.eventExposer;
	}

	private void OnLoadingDone()
	{
		_ = _data.MasterDomainGetter().eventExposer;
	}
}
