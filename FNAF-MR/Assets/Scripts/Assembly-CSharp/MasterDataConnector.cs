using System;

public class MasterDataConnector
{
	private ItemDefinitions _itemDefinitions;

	private MasterDataDomain masterDataDomain;

	private Action OnDataLoaded;

	public bool HaveModsLoaded { get; set; }

	public bool HaveCpusLoaded { get; set; }

	public bool HavePlushSuitsLoaded { get; set; }

	public bool HaveWearAndTearDataLoaded { get; set; }

	public bool HasProgressionDataLoaded { get; set; }

	public bool HaveDevicesLoaded { get; set; }

	public bool HasStoreDataLoaded { get; set; }

	public bool HasPackDataLoaded { get; set; }

	public bool HaveRewardsLoaded { get; set; }

	public bool HasEssenceLoaded { get; set; }

	public bool HaveAttackProfilesLoaded { get; set; }

	public bool HasRemnantDebuffDataLoaded { get; set; }

	public bool HasSequentialRewardsDataLoaded { get; set; }

	public bool HasSeasonDataLoaded { get; set; }

	public bool HasInboxDataLoaded { get; set; }

	public bool HasAlertDataLoaded { get; set; }

	public bool HasProfileAvatarDataLoaded { get; set; }

	public bool HasScavengeAppointmentDataLoaded { get; set; }

	public bool HasPhotoboothFrameDataLoaded { get; set; }

	public bool HasAnimatronicLevelDataLoaded { get; set; }

	public bool HasPlayerLevelDataLoaded { get; set; }

	public bool HasBuffItemsDataLoaded { get; set; }

	public bool HasLoadoutSpriteDataLoaded { get; set; }

	public bool HasXPStreakDataLoaded { get; set; }

	public bool HaveTrophiesLoaded { get; set; }

	public bool HaveSubEntitiesLoaded { get; set; }

	public bool HaveScavengingAttackProfilesLoaded { get; set; }

	public bool HaveScavengingDataLoaded { get; set; }

	private void add_OnDataLoaded(Action value)
	{
		OnDataLoaded = (Action)Delegate.Combine(OnDataLoaded, value);
	}

	private void remove_OnDataLoaded(Action value)
	{
		OnDataLoaded = (Action)Delegate.Remove(OnDataLoaded, value);
	}

	public MasterDataConnector(MasterDataDomain masterDataDomain, ItemDefinitions itemDefinitions)
	{
		_itemDefinitions = itemDefinitions;
		this.masterDataDomain = masterDataDomain;
		if (!ConstantVariables.Instance.MasterDataDownloader.IsDeserialized)
		{
			ConstantVariables.Instance.MasterDataDownloader.add_OnMasterDataDeserialized(Deserialized);
		}
		else
		{
			MasterDataDeserialized();
		}
	}

	private void Deserialized()
	{
		ConstantVariables.Instance.MasterDataDownloader.remove_OnMasterDataDeserialized(Deserialized);
		MasterDataDeserialized();
	}

	public void MasterDataDeserialized()
	{
		masterDataDomain.GetAccessToData.GetModsDataAsync(SetModData);
		masterDataDomain.GetAccessToData.GetCPUDataAsync(SetCPUData);
		masterDataDomain.GetAccessToData.GetPlushSuitDataAsync(SetPlushSuitData);
		masterDataDomain.GetAccessToData.GetConfigDataEntryAsync(SetRewardData);
		masterDataDomain.GetAccessToData.GetAttackDataAsync(SetAttackData);
		masterDataDomain.GetAccessToData.GetProfileAvatarDataAsync(GetProfileAvatarData);
		masterDataDomain.GetAccessToData.GetTrophyDataAsync(SetTrophyData);
		masterDataDomain.GetAccessToData.GetSubEntityDataAsync(SetSubEntityData);
		masterDataDomain.GetAccessToData.GetScavengingAttackDataAsync(SetScavengingAttackData);
		masterDataDomain.GetAccessToData.GetScavengingDataAsync(SetScavengingData);
	}

	private void SetCPUData(CPU_DATA.Root cpuData)
	{
		_itemDefinitions.LoadCPUsFromServer(cpuData);
		HaveCpusLoaded = true;
		if (OnDataLoaded != null)
		{
			OnDataLoaded();
		}
	}

	private void SetPlushSuitData(PLUSHSUIT_DATA.Root plushSuitData)
	{
		_itemDefinitions.LoadPlushSuitsFromServer(plushSuitData);
		HavePlushSuitsLoaded = true;
		if (OnDataLoaded != null)
		{
			OnDataLoaded();
		}
	}

	private void SetAttackData(ATTACK_DATA.Root data)
	{
		_itemDefinitions.LoadAttackDataFromServer(data);
		HaveAttackProfilesLoaded = true;
		if (OnDataLoaded != null)
		{
			OnDataLoaded();
		}
	}

	private void SetRewardData(CONFIG_DATA.Root data)
	{
		_itemDefinitions.LoadConfigDataFromServer(data);
		HaveRewardsLoaded = true;
		if (OnDataLoaded != null)
		{
			OnDataLoaded();
		}
	}

	private void SetTrophyData(TROPHY_DATA.Root trophyData)
	{
		_itemDefinitions.LoadTrophiesFromServer(trophyData);
		HaveTrophiesLoaded = true;
		if (OnDataLoaded != null)
		{
			OnDataLoaded();
		}
	}

	private void GetProfileAvatarData(PROFILE_AVATAR_DATA.Root alertData)
	{
		_itemDefinitions.LoadProfileAvatarData(alertData);
		HasProfileAvatarDataLoaded = true;
		if (OnDataLoaded != null)
		{
			OnDataLoaded();
		}
	}

	private void SetModData(MODS_DATA.Root modData)
	{
		_itemDefinitions.LoadModsFromServer(modData);
		HaveModsLoaded = true;
		if (OnDataLoaded != null)
		{
			OnDataLoaded();
		}
	}

	private void SetSubEntityData(SUB_ENTITY_DATA.Root subEntityData)
	{
		_itemDefinitions.LoadSubEntityData(subEntityData);
		HaveSubEntitiesLoaded = true;
		if (OnDataLoaded != null)
		{
			OnDataLoaded();
		}
	}

	private void SetScavengingAttackData(SCAVENGING_ATTACK_DATA.Root data)
	{
		_itemDefinitions.LoadScavengingAttackDataFromServer(data);
		HaveScavengingAttackProfilesLoaded = true;
		if (OnDataLoaded != null)
		{
			OnDataLoaded();
		}
	}

	private void SetScavengingData(SCAVENGING_DATA.Root data)
	{
		_itemDefinitions.LoadScavengingDataFromServer(data);
		HaveScavengingDataLoaded = true;
		if (OnDataLoaded != null)
		{
			OnDataLoaded();
		}
	}
}
