using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StoreCell : MonoBehaviour, ICellInterface<StoreCellData>
{
	[SerializeField]
	private TextMeshProUGUI TitleText;

	[SerializeField]
	private Image ItemIcon;

	[SerializeField]
	private TextMeshProUGUI NumItemText;

	[SerializeField]
	private Button BuyButton;

	[SerializeField]
	private TextMeshProUGUI PriceText;

	[SerializeField]
	private GameObject FazTokensIcon;

	[SerializeField]
	private GameObject PartsIcon;

	[SerializeField]
	private GameObject EventCurrencyIcon;

	[SerializeField]
	private Image EventCurrencyImage;

	[SerializeField]
	private GameObject BadgeParent;

	[SerializeField]
	private Image BadgeImage;

	[SerializeField]
	private TextMeshProUGUI BadgeText;

	[SerializeField]
	private TimerDisplay SaleTimer;

	[SerializeField]
	private GameObject SaleTimerContainer;

	private StoreDomain _storeDomain;

	private StoreCellData _storeCellData;

	private IconLookup _iconLookup;

	private Localization _localization;

	public Action<StoreCell> CellDisabled;

	public StoreDisplayData Data => _storeCellData.displayData;

	private void ProcessCurrencyDisplay()
	{
		if (!(NumItemText == null) && StoreSectionMapper.GetTypeForString(_storeCellData.displayData.storeData.StoreSection) == StoreSectionMapper.StoreSectionType.FazCoins)
		{
			StoreItem fazCoinsFromItems = GetFazCoinsFromItems(_storeCellData.displayData.storeData.Items);
			if (fazCoinsFromItems != null)
			{
				NumItemText.text = "x" + fazCoinsFromItems.Quantity;
				NumItemText.gameObject.SetActive(value: true);
			}
		}
	}

	private StoreItem GetFazCoinsFromItems(List<StoreItem> items)
	{
		foreach (StoreItem item in items)
		{
			if (StoreSectionMapper.GetTypeForString(item.Type) == StoreSectionMapper.StoreSectionType.FazCoins)
			{
				return item;
			}
		}
		return null;
	}

	private void OnCellClicked()
	{
		if (_storeCellData != null)
		{
			_storeCellData.OnClickedDelegate(this);
		}
	}

	private void IconCacheReady(IconLookup iconLookup)
	{
		_iconLookup = iconLookup;
		if (!(EventCurrencyIcon == null))
		{
			InitializeEventCurrencyIcon();
		}
	}

	private void InitializeEventCurrencyIcon()
	{
	}

	public void SetData(StoreCellData data)
	{
		_storeCellData = data;
		UpdateDisplay();
	}

	public void SetSprite(Sprite sprite)
	{
		ItemIcon.overrideSprite = sprite;
	}

	private void UpdateDisplay()
	{
		TitleText.text = _localization.GetLocalizedString(_storeCellData.displayData.storeData.Name, _storeCellData.displayData.storeData.NameRef);
		PriceText.text = _storeCellData.displayData.Cost.ToString();
		if (!string.IsNullOrWhiteSpace(_storeCellData.displayData.storeData.ButtonLocOverride) && PriceText != null)
		{
			PriceText.text = _localization.GetLocalizedString(_storeCellData.displayData.storeData.ButtonLocOverride, _storeCellData.displayData.storeData.ButtonLocOverride);
		}
		UpdateBadge(_storeCellData.displayData);
		string.IsNullOrEmpty(_storeCellData.displayData.storeData.ActionType);
		if (FazTokensIcon != null)
		{
			FazTokensIcon.SetActive(_storeCellData.displayData.currency == Currency.CurrencyType.HardCurrency);
		}
		if (PartsIcon != null)
		{
			PartsIcon.SetActive(_storeCellData.displayData.currency == Currency.CurrencyType.Parts);
		}
		if (EventCurrencyIcon != null)
		{
			EventCurrencyIcon.SetActive(_storeCellData.displayData.currency == Currency.CurrencyType.EventCurrency);
		}
		ProcessCurrencyDisplay();
	}

	private void ActivateSaleTimer()
	{
		_iconLookup.GetIcon(IconGroup.Store, _storeCellData.displayData.storefrontData.BadgeArtRef, ActivateSaleTimerb__29_0);
	}

	private void UpdateBadge(StoreDisplayData data)
	{
		if (IsOnSale() && SaleTimerContainer != null)
		{
			ActivateSaleTimer();
			return;
		}
		if (!string.IsNullOrEmpty(data.storeData.BadgeArtRef) && BadgeImage != null && BadgeParent != null)
		{
			_iconLookup.GetIcon(IconGroup.Store, data.storeData.BadgeArtRef, UpdateBadgeb__30_0);
		}
		if (!string.IsNullOrEmpty(data.storeData.BadgeLocRef) && BadgeText != null)
		{
			BadgeText.text = _localization.GetLocalizedString(data.storeData.BadgeLocRef, data.storeData.BadgeLocRef);
		}
	}

	private bool IsOnSale()
	{
		if (_storeCellData.displayData.storefrontData == null)
		{
			return false;
		}
		if (_storeCellData.displayData.storefrontData.Type == "Sale" && _storeCellData.displayData.storefrontData != null)
		{
			return _storeCellData.displayData.storefrontData.EndTime > 0.0;
		}
		return false;
	}

	public void Disable()
	{
		base.gameObject.SetActive(value: false);
		if (CellDisabled != null)
		{
			CellDisabled(this);
		}
	}

	public string GetAudioEventName()
	{
		if (_storeCellData.displayData.storeData.Name == "Roll of Faz-Coins")
		{
			return "UIStoreFazCoinRollTapped";
		}
		if (_storeCellData.displayData.storeData.Name == "Stack of Faz-Coins")
		{
			return "UIStoreFazCoinStackTapped";
		}
		if (_storeCellData.displayData.storeData.Name == "Cup of Faz-Coins")
		{
			return "UIStoreFazCoinCupTapped";
		}
		if (_storeCellData.displayData.storeData.Name == "Tub of Faz-Coins")
		{
			return "UIStoreFazCoinTubTapped";
		}
		if (_storeCellData.displayData.storeData.Name == "Sack of Faz-Coins")
		{
			return "UIStoreFazCoinSackTapped";
		}
		if (!(_storeCellData.displayData.storeData.Name == "Truck of Faz-Coins"))
		{
			return "UIStoreNonFazCoinTapped";
		}
		return "UIStoreFazCoinTruckTapped";
	}

	public RectTransform GetCellTransform()
	{
		return GetComponent<RectTransform>();
	}

	private void Awake()
	{
		BuyButton.onClick.AddListener(OnCellClicked);
		IconCacheReady(MasterDomain.GetDomain().GameAssetManagementDomain.IconLookupAccess);
		Awakeb__35_0(LocalizationDomain.Instance.Localization);
	}

	private void OnDestroy()
	{
		BuyButton.onClick.RemoveAllListeners();
	}

	private void InitializeEventCurrencyIconb__25_0(Sprite sprite)
	{
		EventCurrencyImage.sprite = sprite;
	}

	private void ActivateSaleTimerb__29_0(Sprite sprite)
	{
		BadgeImage.overrideSprite = sprite;
		BadgeText.gameObject.SetActive(value: false);
		SaleTimerContainer.SetActive(value: true);
		SaleTimer.EndTime = (long)_storeCellData.displayData.storefrontData.EndTime;
	}

	private void UpdateBadgeb__30_0(Sprite sprite)
	{
		BadgeImage.overrideSprite = sprite;
		BadgeParent.SetActive(sprite != null);
	}

	private void Awakeb__35_0(Localization localization)
	{
		_localization = localization;
	}
}
