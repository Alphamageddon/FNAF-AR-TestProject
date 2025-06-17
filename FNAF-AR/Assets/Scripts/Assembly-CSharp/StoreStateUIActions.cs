using UnityEngine;

public class StoreStateUIActions : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public string errorMsg;

		public string errorTitleKey;

		public StoreStateUIActions _003C_003E4__this;

		internal void _003CShowEarnPartsDialog_003Eb__0(Localization localization)
		{
			GenericDialogData genericDialogData = new GenericDialogData
			{
				title = localization.GetLocalizedString(errorTitleKey, errorTitleKey),
				message = localization.GetLocalizedString(errorMsg, errorMsg),
				negativeButtonText = localization.GetLocalizedString("ui_generic_ok", "ui_generic_ok")
			};
			MasterDomain.GetDomain().eventExposer.GenericDialogRequest(genericDialogData);
		}
	}

	private MasterDomain _masterDomain;

	public void InGamePurchaseRequest(StoreCell cell)
	{
		_masterDomain.StoreDomain.CanAfford(cell.Data);
		EventExposer eventExposer = _masterDomain.eventExposer;
		if (!_masterDomain.StoreDomain.CanAfford(cell.Data))
		{
			eventExposer.OnPurchaseRequestAudioInvoked(canAfford: false);
			if (cell.Data.currency == Currency.CurrencyType.HardCurrency)
			{
				_masterDomain.eventExposer.OnBuyMoreCoinsDialogRequest();
			}
			else
			{
				ShowEarnPartsDialog();
			}
			return;
		}
		eventExposer.OnPurchaseRequestAudioInvoked(canAfford: true);
		_masterDomain.StoreDomain.InitiatePurchase(cell.Data);
		if (!cell.Data.storeData.Repeatable)
		{
			cell.Disable();
		}
	}

	private void ShowEarnPartsDialog()
	{
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass2_.errorMsg = "ui_store_notenough_parts";
		_003C_003Ec__DisplayClass2_.errorTitleKey = "ui_store_notenough_parts_title";
		_003C_003Ec__DisplayClass2_._003CShowEarnPartsDialog_003Eb__0(LocalizationDomain.Instance.Localization);
	}

	public void ShowPurchaseDialog(StoreCell cell)
	{
		_masterDomain.eventExposer.OnStoreDialogRequest(cell.Data);
	}

	private void Awake()
	{
		_masterDomain = MasterDomain.GetDomain();
	}
}
