using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LootItemCellDisplay : IxItemCellDisplay<LootRewardEntry>
{
	private TextMeshProUGUI _itemName;

	private TextMeshProUGUI _itemDescription;

	private Image _itemIcon;

	protected override void PopulateComponents()
	{
		Type[] onlyCacheTypes = new Type[2]
		{
			typeof(TextMeshProUGUI),
			typeof(Image)
		};
		_components.CacheComponents(_root, onlyCacheTypes);
		_itemName = _components.TryGetComponent<TextMeshProUGUI>("ItemCellNameLabel");
		_itemDescription = _components.TryGetComponent<TextMeshProUGUI>("ItemCellDescLabel");
		_itemIcon = _components.TryGetComponent<Image>("ItemImage");
	}

	public override void UpdateData()
	{
		MasterDomain.GetDomain().GameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(UpdateDatab__4_0);
	}

	private void UpdateDatab__4_0(IconLookup lookup)
	{
		Debug.Log("getting item " + _dataItem.LootItem.Item + " and lookup is null? - " + (lookup == null));
		MasterDomain.GetDomain().ItemDefinitionDomain.ItemDefinitions.GetDisplayDataForRewardData(_dataItem, lookup, UpdateDatab__4_1);
	}

	private void UpdateDatab__4_1(LootDisplayData displayData)
	{
		_itemIcon.overrideSprite = displayData.DisplayIcon;
		_itemName.text = displayData.DisplayName;
		_itemDescription.text = displayData.DisplayQuantity.ToString();
	}
}
