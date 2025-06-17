using System;
using System.Collections.Generic;
using UnityEngine;

public class ItemDefinitions
{
	private sealed class DisplayClass
	{
		public static Comparison<PlushSuitData> PlushSuitComparison;

		public static Comparison<List<PlushSuitData>> PlushSuitListComparison;

		internal int SortPlushSuits(PlushSuitData a, PlushSuitData b)
		{
			int skinOrder = a.SkinOrder;
			int skinOrder2 = b.SkinOrder;
			if (skinOrder <= skinOrder2)
			{
				return 0;
			}
			return 1;
		}

		internal int SortPlushSuits(List<PlushSuitData> a, List<PlushSuitData> b)
		{
			int unlockedLevel = a[0].UnlockedLevel;
			int unlockedLevel2 = b[0].UnlockedLevel;
			if (unlockedLevel <= unlockedLevel2)
			{
				return 0;
			}
			return 1;
		}
	}

	private sealed class _003C_003Ec__DisplayClass138_0
	{
		public IconLookup iconLookup;

		public LootDisplayData displayData;

		public Action<LootDisplayData> callback;

		internal void _003CGetDisplayData_003Eb__1()
		{
			_003CGetDisplayData_003Eg__SetDisplayIcon_007C0(iconLookup.DefaultIcon);
		}

		internal void _003CGetDisplayData_003Eg__SetDisplayIcon_007C0(Sprite displayIcon)
		{
			displayData.DisplayIcon = displayIcon;
			Debug.Log("Calling back for display data " + displayData.DisplayName);
			callback(displayData);
		}
	}

	private const string REMNANT_KEY = "ui_results_display_remnant";

	private const string PARTS_KEY = "ui_results_display_parts";

	private const string FAZCOINS_KEY = "ui_results_display_coins";

	private const string REMNANT_FALLBACK = "REMNANT";

	private const string PARTS_FALLBACK = "PARTS";

	private const string FAZCOINS_FALLBACK = "Faz-Coins";

	private const string MOD_SLOT_KEY = "ui_results_display_mod_slot";

	private const string MOD_SLOT_FALLBACK = "MOD SLOT UNLOCKED";

	private const string ENDOSKELETON_SLOT_KEY = "ui_results_display_endoskeleton_unlocked";

	private const string ENDOSKELETON_SLOT_FALLBACK = "NEW ENDOSKELETON UNLOCKED";

	private const string EVENT_CURRENCY_FALLBACK = "Event Currency";

	private const string XP_KEY = "ui_results_display_xp";

	private const string XP_FALLBACK = "XP";

	private const string REMNANT_ICON_KEY = "alpine_ui_reward_remnant";

	private const string PARTS_ICON_KEY = "alpine_ui_reward_parts";

	private const string FAZCOINS_ICON_KEY = "alpine_ui_reward_fazcoin";

	private const string ENDOSKELETON_SLOT_ICON_KEY = "alpine_ui_reward_endo_slot";

	private const string MOD_SLOT_ICON_KEY = "alpine_ui_reward_mod_slot";

	private const string XP_ICON_KEY = "alpine_ui_icon_xp";

	private string _partsString;

	private string _remnantString;

	private string _fazCoinsString;

	private string _endoskeletonSlotString;

	private string _modStringSlot;

	private string _xpString;

	private readonly Dictionary<string, ModData> _modDictionary;

	private readonly Dictionary<string, CPUData> _cpuDictionary;

	private readonly Dictionary<string, AttackProfile> _attackProfileDictionary;

	private readonly Dictionary<string, PlushSuitData> _plushSuitDictionary;

	private readonly List<List<PlushSuitData>> _sortedPlushSuits;

	private readonly Dictionary<RewardCategory, RewardsData> _rewardDictionary;

	private readonly List<int> _modUnlockStreak;

	private readonly List<int> _modUnlockLevel;

	private readonly List<int> _slotUnlockStreak;

	private readonly List<int> _slotUnlockLevel;

	private static readonly AttackProfile NullConfig;

	private readonly Dictionary<string, TrophyData> _trophyDictionary;

	private readonly Dictionary<string, SubEntityData> _subEntityDictionary;

	private readonly Dictionary<string, ScavengingAttackProfile> _scavengingAttackProfileDictionary;

	private readonly Dictionary<string, ScavengingData> _scavengingDataDictionary;

	public Dictionary<string, PlushSuitData> PlushSuitDictionary => _plushSuitDictionary;

	public List<List<PlushSuitData>> SortedPlushSuits => _sortedPlushSuits;

	public Dictionary<string, CPUData> CpuDictionary => _cpuDictionary;

	public Dictionary<string, ProfileAvatarData> ProfileAvatars { get; set; }

	public Dictionary<string, TrophyData> TrophyDictionary => _trophyDictionary;

	public Dictionary<string, SubEntityData> SubEntityDictionary => _subEntityDictionary;

	public ItemDefinitions()
	{
		_modDictionary = new Dictionary<string, ModData>();
		_cpuDictionary = new Dictionary<string, CPUData>();
		_attackProfileDictionary = new Dictionary<string, AttackProfile>();
		_scavengingAttackProfileDictionary = new Dictionary<string, ScavengingAttackProfile>();
		_scavengingDataDictionary = new Dictionary<string, ScavengingData>();
		_plushSuitDictionary = new Dictionary<string, PlushSuitData>();
		_sortedPlushSuits = new List<List<PlushSuitData>>();
		_rewardDictionary = new Dictionary<RewardCategory, RewardsData>();
		_modUnlockStreak = new List<int>();
		_modUnlockLevel = new List<int>();
		_slotUnlockStreak = new List<int>();
		_slotUnlockLevel = new List<int>();
		ProfileAvatars = new Dictionary<string, ProfileAvatarData>();
		_trophyDictionary = new Dictionary<string, TrophyData>();
		_subEntityDictionary = new Dictionary<string, SubEntityData>();
		LocalizationDomain.Instance.LocalizationLoaded = LocalizeStrings;
	}

	private void LocalizeStrings()
	{
		LocalizationDomain instance = LocalizationDomain.Instance;
		_partsString = instance.Localization.GetLocalizedString("ui_results_display_parts", "PARTS");
		_remnantString = instance.Localization.GetLocalizedString("ui_results_display_remnant", "REMNANT");
		_fazCoinsString = instance.Localization.GetLocalizedString("ui_results_display_coins", "Faz-Coins");
		_endoskeletonSlotString = instance.Localization.GetLocalizedString("ui_results_display_endoskeleton_unlocked", "NEW ENDOSKELETON UNLOCKED");
		_modStringSlot = instance.Localization.GetLocalizedString("ui_results_display_mod_slot", "MOD SLOT UNLOCKED");
		_xpString = instance.Localization.GetLocalizedString("ui_results_display_xp", "XP");
	}

	public void LoadCPUsFromServer(CPU_DATA.Root data)
	{
		if (data == null)
		{
			return;
		}
		foreach (CPU_DATA.Entry entry in data.Entries)
		{
			if (entry != null && !string.IsNullOrWhiteSpace(entry.Logical) && !_cpuDictionary.ContainsKey(entry.Logical))
			{
				_cpuDictionary.Add(entry.Logical, new CPUData(entry));
			}
		}
	}

	public CPUData GetCPUById(string id)
	{
		if (_cpuDictionary.ContainsKey(id))
		{
			return _cpuDictionary[id];
		}
		Debug.LogError("Cannot Find CpuId: " + id);
		return null;
	}

	public void LoadPlushSuitsFromServer(PLUSHSUIT_DATA.Root data)
	{
		Debug.LogError("Loading Plushsuits from server");
		if (data == null)
		{
			return;
		}
		foreach (PLUSHSUIT_DATA.Entry entry in data.Entries)
		{
			if (entry != null && !string.IsNullOrWhiteSpace(entry.Logical) && !_plushSuitDictionary.ContainsKey(entry.Logical))
			{
				_plushSuitDictionary.Add(entry.Logical, new PlushSuitData(entry));
			}
		}
		SortPlushSuits();
	}

	private void SortPlushSuits()
	{
		DisplayClass DISPLAYCLASS = new DisplayClass();
		_sortedPlushSuits.Clear();
		foreach (List<PlushSuitData> value in GetAllPlushSuitsBySkinCategory().Values)
		{
			DisplayClass.PlushSuitComparison = (PlushSuitData a, PlushSuitData b) => DISPLAYCLASS.SortPlushSuits(a, b);
			value.Sort(DisplayClass.PlushSuitComparison);
			_sortedPlushSuits.Add(value);
		}
		DisplayClass.PlushSuitListComparison = (List<PlushSuitData> a, List<PlushSuitData> b) => DISPLAYCLASS.SortPlushSuits(a, b);
		_sortedPlushSuits.Sort(DisplayClass.PlushSuitListComparison);
	}

	private Dictionary<string, List<PlushSuitData>> GetAllPlushSuitsBySkinCategory()
	{
		Dictionary<string, List<PlushSuitData>> dictionary = new Dictionary<string, List<PlushSuitData>>();
		foreach (PlushSuitData value in _plushSuitDictionary.Values)
		{
			if (value.SkinCategory != null)
			{
				if (dictionary.ContainsKey(value.SkinCategory))
				{
					dictionary[value.SkinCategory].Add(value);
					continue;
				}
				dictionary.Add(value.SkinCategory, new List<PlushSuitData>());
				dictionary[value.SkinCategory].Add(value);
			}
		}
		return dictionary;
	}

	public PlushSuitData GetPlushSuitById(string id)
	{
		PlushSuitData value = null;
		if (_plushSuitDictionary.ContainsKey(id))
		{
			_plushSuitDictionary.TryGetValue(id, out value);
			return value;
		}
		Debug.LogError("Cannot Find PlushSuitId: " + id);
		return null;
	}

	public string GetBaseCPUForPlushSuitId(string id)
	{
		if (_plushSuitDictionary.ContainsKey(id))
		{
			return _plushSuitDictionary[id].SkinCategory;
		}
		return null;
	}

	public List<string> GetPlushSuitIdsByCategory(string category)
	{
		List<string> list = new List<string>();
		foreach (string key in _plushSuitDictionary.Keys)
		{
			if (_plushSuitDictionary[key].SkinCategory == category)
			{
				list.Add(key);
			}
		}
		return list;
	}

	public void LoadAttackDataFromServer(ATTACK_DATA.Root data)
	{
		if (data == null)
		{
			return;
		}
		foreach (ATTACK_DATA.Entry entry in data.Entries)
		{
			if (entry != null && !string.IsNullOrWhiteSpace(entry.Logical) && !_attackProfileDictionary.ContainsKey(entry.Logical))
			{
				_attackProfileDictionary.Add(entry.Logical, new AttackProfile(entry));
			}
		}
	}

	public AttackProfile GetAttackProfile(string profileId)
	{
		AttackProfile value = null;
		if (_attackProfileDictionary.ContainsKey(profileId))
		{
			_attackProfileDictionary.TryGetValue(profileId, out value);
			return value;
		}
		Debug.LogError("Cannot Find Attackprofile Id: " + profileId);
		return NullConfig;
	}

	public void LoadScavengingAttackDataFromServer(SCAVENGING_ATTACK_DATA.Root data)
	{
		if (data == null)
		{
			return;
		}
		foreach (SCAVENGING_ATTACK_DATA.Entry entry in data.Entries)
		{
			if (entry != null && !string.IsNullOrWhiteSpace(entry.Logical) && !_scavengingAttackProfileDictionary.ContainsKey(entry.Logical))
			{
				_scavengingAttackProfileDictionary.Add(entry.Logical, new ScavengingAttackProfile(entry));
			}
		}
	}

	public ScavengingAttackProfile GetScavengingAttackProfile(string profileId)
	{
		ScavengingAttackProfile value = null;
		if (_scavengingAttackProfileDictionary.ContainsKey(profileId))
		{
			_scavengingAttackProfileDictionary.TryGetValue(profileId, out value);
			return value;
		}
		Debug.LogError("Cannot Find ScavengingAttackProfile Id: " + profileId);
		return null;
	}

	public void GetDisplayDataForRewardData(LootRewardEntry entry, IconLookup iconLookup, Action<LootDisplayData> callback)
	{
		if (entry.LootItem == null)
		{
			Debug.LogError("lootrewardentry item was null..");
			return;
		}
		Debug.Log("getting display data for type " + entry.LootItem.Type);
		GetDisplayData(entry.LootItem.Type, entry.LootItem.Logical, entry.NumToGive, iconLookup, callback);
	}

	private void GetDisplayData(string type, string logical, int quantity, IconLookup iconLookup, Action<LootDisplayData> callback)
	{
		string iconName = " ";
		_003C_003Ec__DisplayClass138_0 _003C_003Ec__DisplayClass138_ = new _003C_003Ec__DisplayClass138_0();
		_003C_003Ec__DisplayClass138_.iconLookup = iconLookup;
		_003C_003Ec__DisplayClass138_.callback = callback;
		_003C_003Ec__DisplayClass138_.displayData = new LootDisplayData();
		_003C_003Ec__DisplayClass138_.displayData.DisplayQuantity = quantity;
		switch (type)
		{
		default:
			if (type != "Parts")
			{
				return;
			}
			_003C_003Ec__DisplayClass138_.displayData.DisplayName = _partsString;
			iconName = "alpine_ui_reward_parts";
			break;
		case "Remnant":
			_003C_003Ec__DisplayClass138_.displayData.DisplayName = _remnantString;
			iconName = "alpine_ui_reward_remnant";
			break;
		case "Mod":
		{
			ModData modById = GetModById(logical);
			_003C_003Ec__DisplayClass138_.displayData.DisplayName = LocalizationDomain.Instance.Localization.GetLocalizedString(modById.Name, modById.Name);
			iconName = modById.ModIconRewardName;
			iconLookup.GetIcon(IconGroup.Mod, iconName, _003C_003Ec__DisplayClass138_._003CGetDisplayData_003Eg__SetDisplayIcon_007C0);
			return;
		}
		case "Device":
			_003C_003Ec__DisplayClass138_.displayData.DisplayName = " ";
			_003C_003Ec__DisplayClass138_._003CGetDisplayData_003Eb__1();
			return;
		case "AvatarIcon":
		{
			ProfileAvatarData profileAvatarData = ProfileAvatars[logical];
			if (profileAvatarData != null)
			{
				_003C_003Ec__DisplayClass138_.displayData.DisplayName = profileAvatarData.DisplayName;
				_003C_003Ec__DisplayClass138_.displayData.DisplayName = LocalizationDomain.Instance.Localization.GetLocalizedString(_003C_003Ec__DisplayClass138_.displayData.DisplayName, _003C_003Ec__DisplayClass138_.displayData.DisplayName);
				iconLookup.GetIconFromAtlas(IconGroup.AvatarAtlases, profileAvatarData.Asset, profileAvatarData.SpriteAtlas, _003C_003Ec__DisplayClass138_._003CGetDisplayData_003Eg__SetDisplayIcon_007C0, _003C_003Ec__DisplayClass138_._003CGetDisplayData_003Eb__1);
			}
			return;
		}
		case "ModSlot":
			_003C_003Ec__DisplayClass138_.displayData.DisplayName = _modStringSlot;
			iconName = "alpine_ui_reward_mod_slot";
			break;
		case "EndoskeletonSlot":
			_003C_003Ec__DisplayClass138_.displayData.DisplayName = _endoskeletonSlotString;
			iconName = "alpine_ui_reward_endo_slot";
			break;
		case "PlushSuitPiece":
			_003C_003Ec__DisplayClass138_.callback(null);
			return;
		case "CPU":
		{
			CPUData cPUById = GetCPUById(logical);
			_003C_003Ec__DisplayClass138_.displayData.DisplayName = cPUById.AnimatronicName;
			if (_003C_003Ec__DisplayClass138_.displayData.DisplayName == null)
			{
				_003C_003Ec__DisplayClass138_.displayData.DisplayName = " ";
			}
			iconName = cPUById.CpuIconName;
			if (iconName == null)
			{
				iconName = " ";
			}
			_003C_003Ec__DisplayClass138_.displayData.DisplayName = LocalizationDomain.Instance.Localization.GetLocalizedString(_003C_003Ec__DisplayClass138_.displayData.DisplayName, _003C_003Ec__DisplayClass138_.displayData.DisplayName);
			iconLookup.GetIcon(IconGroup.Cpu, iconName, _003C_003Ec__DisplayClass138_._003CGetDisplayData_003Eg__SetDisplayIcon_007C0);
			return;
		}
		case "PlushSuit":
		{
			PlushSuitData plushSuitById = GetPlushSuitById(logical);
			_003C_003Ec__DisplayClass138_.displayData.DisplayName = plushSuitById.AnimatronicName;
			if (_003C_003Ec__DisplayClass138_.displayData.DisplayName == null)
			{
				_003C_003Ec__DisplayClass138_.displayData.DisplayName = " ";
			}
			iconName = plushSuitById.PlushSuitIconName;
			if (iconName == null)
			{
				iconName = " ";
			}
			_003C_003Ec__DisplayClass138_.displayData.DisplayName = LocalizationDomain.Instance.Localization.GetLocalizedString(_003C_003Ec__DisplayClass138_.displayData.DisplayName, _003C_003Ec__DisplayClass138_.displayData.DisplayName);
			iconLookup.GetIcon(IconGroup.PlushSuit, iconName, _003C_003Ec__DisplayClass138_._003CGetDisplayData_003Eg__SetDisplayIcon_007C0);
			return;
		}
		case "XP":
			_003C_003Ec__DisplayClass138_.displayData.DisplayName = _xpString;
			iconName = "alpine_ui_icon_xp";
			break;
		case "FazCoins":
			_003C_003Ec__DisplayClass138_.displayData.DisplayName = _fazCoinsString;
			iconName = "alpine_ui_reward_fazcoin";
			break;
		case "Trophy":
		{
			TrophyData trophyById = GetTrophyById(logical);
			_003C_003Ec__DisplayClass138_.displayData.DisplayName = trophyById.TrophyName;
			if (_003C_003Ec__DisplayClass138_.displayData.DisplayName == null)
			{
				_003C_003Ec__DisplayClass138_.displayData.DisplayName = " ";
			}
			iconName = trophyById.IconRef;
			if (iconName == null)
			{
				iconName = " ";
			}
			_003C_003Ec__DisplayClass138_.displayData.DisplayName = LocalizationDomain.Instance.Localization.GetLocalizedString(_003C_003Ec__DisplayClass138_.displayData.DisplayName, _003C_003Ec__DisplayClass138_.displayData.DisplayName);
			iconLookup.GetIcon(IconGroup.Trophy, iconName, _003C_003Ec__DisplayClass138_._003CGetDisplayData_003Eg__SetDisplayIcon_007C0);
			return;
		}
		case "BuffItem":
		case "EventCurrency":
			break;
		}
		_003C_003Ec__DisplayClass138_.displayData.DisplayName = LocalizationDomain.Instance.Localization.GetLocalizedString(_003C_003Ec__DisplayClass138_.displayData.DisplayName, _003C_003Ec__DisplayClass138_.displayData.DisplayName);
		iconLookup.GetIcon(IconGroup.Reward, iconName, _003C_003Ec__DisplayClass138_._003CGetDisplayData_003Eg__SetDisplayIcon_007C0);
	}

	public void LoadAnimatronicLevelDataFromServer()
	{
	}

	public void LoadPlayerLevelDataFromServer()
	{
	}

	public void LoadConfigDataFromServer(CONFIG_DATA.Root configDataEntry)
	{
		RewardsData rewardsData = new RewardsData();
		rewardsData.rewardIconName = configDataEntry.Entries[0].ArtAssets.UI.EssenceRewardIconName;
		_rewardDictionary.Add(RewardCategory.essence, rewardsData);
		RewardsData rewardsData2 = new RewardsData();
		rewardsData2.rewardIconName = configDataEntry.Entries[0].ArtAssets.UI.PartsRewardIconName;
		_rewardDictionary.Add(RewardCategory.parts, rewardsData2);
		RewardsData rewardsData3 = new RewardsData();
		rewardsData3.rewardIconName = configDataEntry.Entries[0].ArtAssets.UI.FazCoinsRewardIconName;
		_rewardDictionary.Add(RewardCategory.coin, rewardsData3);
		RewardsData rewardsData4 = new RewardsData();
		rewardsData4.rewardIconName = configDataEntry.Entries[0].ArtAssets.UI.EndoskeletonSlotRewardIconName;
		_rewardDictionary.Add(RewardCategory.endoskeletonSlot, rewardsData4);
		RewardsData rewardsData5 = new RewardsData();
		rewardsData5.rewardIconName = configDataEntry.Entries[0].ArtAssets.UI.ModSlotRewardIconName;
		_rewardDictionary.Add(RewardCategory.modSlot, rewardsData5);
	}

	public RewardsData GetRewardsDataByCategory(RewardCategory rewardCategory)
	{
		if (_rewardDictionary.ContainsKey(rewardCategory))
		{
			return _rewardDictionary[rewardCategory];
		}
		return null;
	}

	public int GetMaxLevel()
	{
		return 0;
	}

	public List<string> GetAnimatronicsForPlayerLevel(int level)
	{
		return null;
	}

	public double GetStreakBonusFromCurrentStreak(int currentStreak)
	{
		return 0.0;
	}

	public void LoadTrophiesFromServer(TROPHY_DATA.Root data)
	{
		if (data == null)
		{
			return;
		}
		foreach (TROPHY_DATA.Entry entry in data.Entries)
		{
			if (entry != null && !string.IsNullOrWhiteSpace(entry.Logical) && !_trophyDictionary.ContainsKey(entry.Logical))
			{
				_trophyDictionary.Add(entry.Logical, new TrophyData(entry));
			}
		}
	}

	public TrophyData GetTrophyById(string id)
	{
		if (_trophyDictionary.ContainsKey(id))
		{
			return _trophyDictionary[id];
		}
		Debug.LogError("Cannot Find TrophyId: " + id);
		return null;
	}

	public void LoadProfileAvatarData(PROFILE_AVATAR_DATA.Root alertData)
	{
		foreach (PROFILE_AVATAR_DATA.Entry entry in alertData.Entries)
		{
			ProfileAvatarData value = new ProfileAvatarData(entry);
			ProfileAvatars.Add(entry.Logical, value);
		}
	}

	public ProfileAvatarData GetProfileAvatarById(string id)
	{
		if (ProfileAvatars.ContainsKey(id))
		{
			return ProfileAvatars[id];
		}
		return null;
	}

	public void LoadModsFromServer(MODS_DATA.Root data)
	{
		_modDictionary.Clear();
		foreach (MODS_DATA.Entry entry in data.Entries)
		{
			ModData modData = new ModData(entry);
			_modDictionary.Add(modData.Id, modData);
		}
	}

	public ModData GetModById(string id)
	{
		if (_modDictionary.ContainsKey(id))
		{
			return _modDictionary[id];
		}
		return null;
	}

	public Dictionary<string, float> GetModifiersForAttackProfile(EndoskeletonData endoskeleton, int wearAndTear)
	{
		Dictionary<string, float> dictionary = new Dictionary<string, float>();
		foreach (string mod in endoskeleton.mods)
		{
			if (GetModById(endoskeleton.mods[0]) == null)
			{
				continue;
			}
			foreach (ModEffect effect in GetModById(endoskeleton.mods[endoskeleton.mods.IndexOf(mod)]).Effects)
			{
				if (!string.IsNullOrEmpty(effect.Type))
				{
					if (!dictionary.ContainsKey(effect.Type))
					{
						dictionary.Add(effect.Type, 1f);
					}
					dictionary[effect.Type] = dictionary[effect.Type] * effect.Magnitude;
				}
			}
		}
		return dictionary;
	}

	public void LoadSubEntityData(SUB_ENTITY_DATA.Root data)
	{
		if (data == null)
		{
			return;
		}
		foreach (SUB_ENTITY_DATA.Entry entry in data.Entries)
		{
			if (entry != null && !string.IsNullOrWhiteSpace(entry.Logical) && !_subEntityDictionary.ContainsKey(entry.Logical))
			{
				Debug.Log("added " + entry.Logical + " to sub entity dict");
				_subEntityDictionary.Add(entry.Logical, new SubEntityData(entry));
			}
		}
	}

	public SubEntityData GetSubEntityDataById(string id)
	{
		if (_subEntityDictionary.ContainsKey(id))
		{
			return _subEntityDictionary[id];
		}
		Debug.LogError("Cannot Find SubEntityId: " + id);
		Debug.LogError("COULD NOT FIND A SUBENTITY.");
		return null;
	}

	public List<SubEntityData> GetSubEntityDataByMods(List<string> ids)
	{
		List<SubEntityData> list = new List<SubEntityData>();
		foreach (string id in ids)
		{
			if (_subEntityDictionary.ContainsKey(id))
			{
				list.Add(_subEntityDictionary[id]);
			}
			else
			{
				Debug.LogWarning("Cannot Find SubEntityId: " + id);
			}
		}
		if (list.Count <= 0)
		{
			Debug.LogError("COULD NOT FIND A SUBENTITY.");
			return null;
		}
		return list;
	}

	public void LoadScavengingDataFromServer(SCAVENGING_DATA.Root data)
	{
		if (data == null)
		{
			return;
		}
		foreach (SCAVENGING_DATA.Entry entry in data.Entries)
		{
			if (entry != null && !string.IsNullOrWhiteSpace(entry.Logical) && !_scavengingDataDictionary.ContainsKey(entry.Logical))
			{
				_scavengingDataDictionary.Add(entry.Logical, new ScavengingData(entry));
			}
		}
	}

	public ScavengingData GetScavengingLevelById(string id)
	{
		ScavengingData value = null;
		if (_scavengingDataDictionary.ContainsKey(id))
		{
			_scavengingDataDictionary.TryGetValue(id, out value);
			return value;
		}
		Debug.LogError("Cannot Find ScavengingData Id: " + id);
		return null;
	}

	static ItemDefinitions()
	{
		NullConfig = null;
	}
}
