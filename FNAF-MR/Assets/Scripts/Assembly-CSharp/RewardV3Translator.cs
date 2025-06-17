using System;
using System.Collections.Generic;
using UnityEngine;

public class RewardV3Translator : IDisposable
{
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public ItemUIDescription newItem;

		internal void _003CGetEssenceOnLossCellDescriptions_003Eb__0(Localization localization)
		{
			newItem.displayName = localization.GetLocalizedString("ui_results_display_remnant", newItem.displayName);
		}

		internal void _003CGetEssenceOnLossCellDescriptions_003Eb__1(Sprite sprite)
		{
			newItem.sprite = sprite;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public ItemUIDescription newItem;

		internal void _003CGetEssenceOnWinDescriptions_003Eb__0(Localization localization)
		{
			newItem.displayName = localization.GetLocalizedString("ui_results_display_remnant", newItem.displayName);
		}

		internal void _003CGetEssenceOnWinDescriptions_003Eb__1(Sprite sprite)
		{
			newItem.sprite = sprite;
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public ItemUIDescription newItem;

		internal void _003CGetPartsCellDescriptions_003Eb__0(Localization localization)
		{
			newItem.displayName = localization.GetLocalizedString("ui_results_display_parts", newItem.displayName);
		}

		internal void _003CGetPartsCellDescriptions_003Eb__1(Sprite sprite)
		{
			newItem.sprite = sprite;
		}
	}

	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public ItemUIDescription newItem;

		internal void _003CGetPlushSuitCellDescriptions_003Eb__0(Localization localization)
		{
			if (newItem.displayName == null)
			{
				newItem.displayName = localization.GetLocalizedString("ui_results_display_plush", newItem.displayName);
			}
			else
			{
				newItem.displayName = localization.GetLocalizedString(newItem.displayName, newItem.displayName);
			}
		}

		internal void _003CGetPlushSuitCellDescriptions_003Eb__1(Sprite sprite)
		{
			newItem.sprite = sprite;
		}
	}

	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public ItemUIDescription newItem;

		internal void _003CGetCPUCellDescriptions_003Eb__0(Localization localization)
		{
			if (newItem.displayName == null)
			{
				newItem.displayName = localization.GetLocalizedString("ui_results_display_cpu", newItem.displayName);
			}
			else
			{
				newItem.displayName = localization.GetLocalizedString(newItem.displayName, newItem.displayName);
			}
		}

		internal void _003CGetCPUCellDescriptions_003Eb__1(Sprite sprite)
		{
			newItem.sprite = sprite;
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public ItemUIDescription newItem;

		internal void _003CGetModCellDescriptions_003Eb__0(Localization localization)
		{
			if (newItem.displayName == null)
			{
				newItem.displayName = localization.GetLocalizedString("ui_results_display_mod", newItem.displayName);
			}
			else
			{
				newItem.displayName = localization.GetLocalizedString(newItem.displayName, newItem.displayName);
			}
		}

		internal void _003CGetModCellDescriptions_003Eb__1(Sprite sprite)
		{
			newItem.sprite = sprite;
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public ItemUIDescription newItem;

		internal void _003CGetCoinDescriptions_003Eb__0(Localization localization)
		{
			newItem.displayName = localization.GetLocalizedString("ui_results_display_coins", newItem.displayName);
		}

		internal void _003CGetCoinDescriptions_003Eb__1(Sprite sprite)
		{
			newItem.sprite = sprite;
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public ItemUIDescription itemUiDescription;

		internal void _003CGetEndoskeletonSlotRewardDescription_003Eb__0(Localization localization)
		{
			itemUiDescription.displayName = localization.GetLocalizedString("ui_results_display_endoskeleton_unlocked", "ui_results_display_endoskeleton_unlocked");
		}

		internal void _003CGetEndoskeletonSlotRewardDescription_003Eb__1(Sprite sprite)
		{
			itemUiDescription.sprite = sprite;
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public ItemUIDescription itemUiDescription;

		internal void _003CGetModSlotRewardDescription_003Eb__0(Localization localization)
		{
			itemUiDescription.displayName = localization.GetLocalizedString("ui_results_display_mod_slot", "ui_results_display_mod_slot");
		}

		internal void _003CGetModSlotRewardDescription_003Eb__1(Sprite sprite)
		{
			itemUiDescription.sprite = sprite;
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public ItemUIDescription itemUiDescription;

		internal void _003CGetPartsRewardDescription_003Eb__0(Localization localization)
		{
			itemUiDescription.displayName = localization.GetLocalizedString("ui_results_display_parts", itemUiDescription.displayName);
		}

		internal void _003CGetPartsRewardDescription_003Eb__1(Sprite sprite)
		{
			itemUiDescription.sprite = sprite;
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public ItemUIDescription newItem;

		internal void _003CGetDeviceItemDescription_003Eb__0(Localization localization)
		{
			if (newItem.displayName == null)
			{
				newItem.displayName = localization.GetLocalizedString("ui_results_display_devices", newItem.displayName);
			}
			else
			{
				newItem.displayName = localization.GetLocalizedString(newItem.displayName, newItem.displayName);
			}
		}
	}

	private IconLookup _iconLookup;

	private readonly ItemDefinitions _itemDefinitions;

	public RewardV3Translator(MasterDomain masterDomain)
	{
		masterDomain.GameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(IconCacheReady);
		_itemDefinitions = masterDomain.ItemDefinitionDomain.ItemDefinitions;
	}

	private void IconCacheReady(IconLookup iconLookup)
	{
		_iconLookup = iconLookup;
	}

	public List<ItemUIDescription> GetEssenceOnLossCellDescriptions(RewardDataV3 rewardDataV3)
	{
		List<ItemUIDescription> list = new List<ItemUIDescription>();
		if (rewardDataV3.essenceOnLoss == 0)
		{
			return list;
		}
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
		ItemUIDescription itemUIDescription = new ItemUIDescription();
		itemUIDescription.rewardCategory = RewardCategory.essence;
		itemUIDescription.sprite = null;
		itemUIDescription.typeName = "REMNANT";
		itemUIDescription.displayName = "REMNANT";
		itemUIDescription.number = -rewardDataV3.essenceOnLoss;
		_003C_003Ec__DisplayClass7_.newItem = itemUIDescription;
		list.Add(itemUIDescription);
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(_003C_003Ec__DisplayClass7_._003CGetEssenceOnLossCellDescriptions_003Eb__0);
		_iconLookup.GetIcon(IconGroup.Reward, _itemDefinitions.GetRewardsDataByCategory(RewardCategory.essence).rewardIconName, _003C_003Ec__DisplayClass7_._003CGetEssenceOnLossCellDescriptions_003Eb__1);
		return list;
	}

	public List<ItemUIDescription> GetEssenceOnWinDescriptions(RewardDataV3 rewardDataV3)
	{
		List<ItemUIDescription> list = new List<ItemUIDescription>();
		foreach (RewardItem currencyReward in rewardDataV3.currencyRewardList)
		{
			if (currencyReward.item == "ESSENCE")
			{
				_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				ItemUIDescription itemUIDescription = new ItemUIDescription();
				itemUIDescription.rewardCategory = RewardCategory.essence;
				itemUIDescription.sprite = null;
				itemUIDescription.typeName = "ESSENCE";
				itemUIDescription.displayName = "ESSENCE";
				itemUIDescription.number = currencyReward.amount;
				_003C_003Ec__DisplayClass8_.newItem = itemUIDescription;
				list.Add(itemUIDescription);
				LocalizationDomain.Instance.Localization.GetInterfaceAsync(_003C_003Ec__DisplayClass8_._003CGetEssenceOnWinDescriptions_003Eb__0);
				_iconLookup.GetIcon(IconGroup.Reward, _itemDefinitions.GetRewardsDataByCategory(RewardCategory.essence).rewardIconName, _003C_003Ec__DisplayClass8_._003CGetEssenceOnWinDescriptions_003Eb__1);
				return list;
			}
		}
		return list;
	}

	public List<ItemUIDescription> GetPartsCellDescriptions(RewardDataV3 rewardDataV3)
	{
		List<ItemUIDescription> list = new List<ItemUIDescription>();
		foreach (RewardItem currencyReward in rewardDataV3.currencyRewardList)
		{
			if (currencyReward.item == "PARTS")
			{
				_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
				ItemUIDescription itemUIDescription = new ItemUIDescription();
				itemUIDescription.rewardCategory = RewardCategory.parts;
				itemUIDescription.sprite = null;
				itemUIDescription.typeName = "PARTS";
				itemUIDescription.displayName = "PARTS";
				itemUIDescription.number = currencyReward.amount;
				_003C_003Ec__DisplayClass9_.newItem = itemUIDescription;
				list.Add(itemUIDescription);
				LocalizationDomain.Instance.Localization.GetInterfaceAsync(_003C_003Ec__DisplayClass9_._003CGetPartsCellDescriptions_003Eb__0);
				GetSpriteForRewardCategory(RewardCategory.parts, _003C_003Ec__DisplayClass9_._003CGetPartsCellDescriptions_003Eb__1);
				return list;
			}
		}
		return list;
	}

	public List<ItemUIDescription> GetPlushSuitCellDescriptions(RewardDataV3 rewardDataV3)
	{
		List<ItemUIDescription> list = new List<ItemUIDescription>();
		if (rewardDataV3.animatronicRewardTable == null)
		{
			return list;
		}
		foreach (string key in rewardDataV3.animatronicRewardTable.Keys)
		{
			foreach (RewardItem item in rewardDataV3.animatronicRewardTable[key])
			{
				if (item.item == "PlushSuit")
				{
					_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
					ItemUIDescription itemUIDescription = new ItemUIDescription();
					itemUIDescription.rewardCategory = RewardCategory.plush;
					itemUIDescription.sprite = null;
					itemUIDescription.typeName = "PLUSH SUIT";
					itemUIDescription.displayName = _itemDefinitions.GetPlushSuitById(key).AnimatronicName;
					itemUIDescription.number = item.amount;
					_003C_003Ec__DisplayClass10_.newItem = itemUIDescription;
					list.Add(itemUIDescription);
					LocalizationDomain.Instance.Localization.GetInterfaceAsync(_003C_003Ec__DisplayClass10_._003CGetPlushSuitCellDescriptions_003Eb__0);
					_iconLookup.GetIcon(IconGroup.PlushSuit, _itemDefinitions.GetPlushSuitById(key).PlushSuitIconName, _003C_003Ec__DisplayClass10_._003CGetPlushSuitCellDescriptions_003Eb__1);
				}
			}
		}
		return list;
	}

	public List<ItemUIDescription> GetCPUCellDescriptions(RewardDataV3 rewardDataV3)
	{
		List<ItemUIDescription> list = new List<ItemUIDescription>();
		foreach (RewardItem cpuReward in rewardDataV3.cpuRewardList)
		{
			_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
			ItemUIDescription itemUIDescription = new ItemUIDescription();
			itemUIDescription.rewardCategory = RewardCategory.cpu;
			itemUIDescription.sprite = null;
			itemUIDescription.typeName = "CPU";
			itemUIDescription.displayName = _itemDefinitions.GetCPUById(cpuReward.item).AnimatronicName;
			itemUIDescription.number = cpuReward.amount;
			_003C_003Ec__DisplayClass11_.newItem = itemUIDescription;
			list.Add(itemUIDescription);
			LocalizationDomain.Instance.Localization.GetInterfaceAsync(_003C_003Ec__DisplayClass11_._003CGetCPUCellDescriptions_003Eb__0);
			_iconLookup.GetIcon(IconGroup.Cpu, _itemDefinitions.GetCPUById(cpuReward.item).CpuIconName, _003C_003Ec__DisplayClass11_._003CGetCPUCellDescriptions_003Eb__1);
		}
		return list;
	}

	public List<ItemUIDescription> GetModCellDescriptions(RewardDataV3 rewardDataV3)
	{
		List<ItemUIDescription> list = new List<ItemUIDescription>();
		foreach (RewardItem modReward in rewardDataV3.modRewardList)
		{
			_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
			ItemUIDescription itemUIDescription = new ItemUIDescription();
			itemUIDescription.rewardCategory = RewardCategory.mod;
			itemUIDescription.sprite = null;
			itemUIDescription.typeName = "MOD";
			itemUIDescription.number = modReward.amount;
			_003C_003Ec__DisplayClass12_.newItem = itemUIDescription;
			list.Add(itemUIDescription);
			LocalizationDomain.Instance.Localization.GetInterfaceAsync(_003C_003Ec__DisplayClass12_._003CGetModCellDescriptions_003Eb__0);
		}
		return list;
	}

	public List<ItemUIDescription> GetCoinDescriptions(RewardDataV3 rewardDataV3)
	{
		List<ItemUIDescription> list = new List<ItemUIDescription>();
		foreach (RewardItem currencyReward in rewardDataV3.currencyRewardList)
		{
			if (currencyReward.item == "FAZ_TOKENS")
			{
				_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
				ItemUIDescription itemUIDescription = new ItemUIDescription();
				itemUIDescription.rewardCategory = RewardCategory.coin;
				itemUIDescription.sprite = null;
				itemUIDescription.typeName = "COINS";
				itemUIDescription.displayName = "COINS";
				itemUIDescription.number = currencyReward.amount;
				_003C_003Ec__DisplayClass13_.newItem = itemUIDescription;
				list.Add(itemUIDescription);
				LocalizationDomain.Instance.Localization.GetInterfaceAsync(_003C_003Ec__DisplayClass13_._003CGetCoinDescriptions_003Eb__0);
				GetSpriteForRewardCategory(RewardCategory.coin, _003C_003Ec__DisplayClass13_._003CGetCoinDescriptions_003Eb__1);
				return list;
			}
		}
		return list;
	}

	public ItemUIDescription GetEndoskeletonSlotRewardDescription()
	{
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
		ItemUIDescription itemUIDescription = new ItemUIDescription();
		itemUIDescription.rewardCategory = RewardCategory.endoskeletonSlot;
		itemUIDescription.typeName = "NEW ENDOSKELETON";
		_003C_003Ec__DisplayClass14_.itemUiDescription = itemUIDescription;
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(_003C_003Ec__DisplayClass14_._003CGetEndoskeletonSlotRewardDescription_003Eb__0);
		GetSpriteForRewardCategory(RewardCategory.endoskeletonSlot, _003C_003Ec__DisplayClass14_._003CGetEndoskeletonSlotRewardDescription_003Eb__1);
		return _003C_003Ec__DisplayClass14_.itemUiDescription;
	}

	public ItemUIDescription GetModSlotRewardDescription()
	{
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
		ItemUIDescription itemUIDescription = new ItemUIDescription();
		itemUIDescription.rewardCategory = RewardCategory.modSlot;
		itemUIDescription.typeName = "MOD SLOT";
		_003C_003Ec__DisplayClass15_.itemUiDescription = itemUIDescription;
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(_003C_003Ec__DisplayClass15_._003CGetModSlotRewardDescription_003Eb__0);
		GetSpriteForRewardCategory(RewardCategory.modSlot, _003C_003Ec__DisplayClass15_._003CGetModSlotRewardDescription_003Eb__1);
		return _003C_003Ec__DisplayClass15_.itemUiDescription;
	}

	public ItemUIDescription GetPartsRewardDescription(int numParts)
	{
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
		ItemUIDescription itemUIDescription = new ItemUIDescription();
		itemUIDescription.rewardCategory = RewardCategory.parts;
		itemUIDescription.typeName = "PARTS";
		itemUIDescription.displayName = "PARTS";
		itemUIDescription.number = numParts;
		_003C_003Ec__DisplayClass16_.itemUiDescription = itemUIDescription;
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(_003C_003Ec__DisplayClass16_._003CGetPartsRewardDescription_003Eb__0);
		GetSpriteForRewardCategory(RewardCategory.parts, _003C_003Ec__DisplayClass16_._003CGetPartsRewardDescription_003Eb__1);
		return _003C_003Ec__DisplayClass16_.itemUiDescription;
	}

	public List<ItemUIDescription> GetDeviceItemDescription(Dictionary<string, int> deviceRewards)
	{
		List<ItemUIDescription> result = new List<ItemUIDescription>();
		if (deviceRewards == null)
		{
			return result;
		}
		_ = deviceRewards.Count;
		return result;
	}

	public List<ItemUIDescription> GetAllWinRewardDescriptions(RewardDataV3 rewardDataV3)
	{
		List<ItemUIDescription> list = new List<ItemUIDescription>();
		list.AddRange(GetPartsCellDescriptions(rewardDataV3));
		list.AddRange(GetEssenceOnWinDescriptions(rewardDataV3));
		list.AddRange(GetCPUCellDescriptions(rewardDataV3));
		list.AddRange(GetModCellDescriptions(rewardDataV3));
		list.AddRange(GetPlushSuitCellDescriptions(rewardDataV3));
		list.AddRange(GetCoinDescriptions(rewardDataV3));
		return list;
	}

	private void GetSpriteForRewardCategory(RewardCategory category, Action<Sprite> iconCallback)
	{
		RewardsData rewardsDataByCategory = _itemDefinitions.GetRewardsDataByCategory(category);
		_iconLookup.GetIcon(IconGroup.Reward, rewardsDataByCategory.rewardIconName, iconCallback);
	}

	private void OnDestroy()
	{
		_iconLookup = null;
	}

	public void Dispose()
	{
		_iconLookup = null;
	}
}
