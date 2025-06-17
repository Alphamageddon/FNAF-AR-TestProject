using System;
using PaperPlaneTools;
using UnityEngine;

public class DialogHandler_Shared : MonoBehaviour
{
	[SerializeField]
	[Header("Dialog GameObjects")]
	private GameObject _genericDialog;

	[SerializeField]
	private StorePurchaseDialog _purchaseDialog;

	[SerializeField]
	private Transform _guideArrowCanvas;

	[SerializeField]
	private Transform _guideVisualizerCanvas;

	[SerializeField]
	private Transform _analyticsVisualizerCanvas;

	private GameUIDomain _gameUiDomain;

	private TheGameDomain _theGameDomain;

	private EventExposer _eventExposer;

	private StoreDomain _storeDomain;

	private ItemDefinitions _itemDefinitions;

	private Localization _localization;

	private AudioPlayer _audioPlayer;

	private Alert _genericAlert;

	private Alert _collectRewardAlert;

	public Transform GuideArrowCanvas => _guideArrowCanvas;

	public Transform GuideVisualizerCanvas => _guideVisualizerCanvas;

	public Transform AnalyticsVisualizerCanvas => _analyticsVisualizerCanvas;

	private void LocalizationReady(Localization localization)
	{
		_localization = localization;
	}

	private void GameAudioReady(AudioPlayer audioPlayer)
	{
		_audioPlayer = audioPlayer;
	}

	private void AddSubscriptions()
	{
		_eventExposer.add_GenericDialogRequestReceived(ShowGenericDialog);
		_eventExposer.add_StoreDialogRequestReceived(ShowPurchaseDialog);
		_eventExposer.add_BuyMoreCoinsDialogRequest(ShowGetCoinsDialog);
		if (_storeDomain != null)
		{
			StoreDomain storeDomain = _storeDomain;
			storeDomain.PurchaseErrorCallback = (Action<string>)Delegate.Combine(storeDomain.PurchaseErrorCallback, new Action<string>(ShowStoreErrorDialog));
		}
	}

	private void RemoveSubscriptions()
	{
		_eventExposer.remove_StoreDialogRequestReceived(ShowPurchaseDialog);
		_eventExposer.remove_GenericDialogRequestReceived(ShowGenericDialog);
		_eventExposer.remove_BuyMoreCoinsDialogRequest(ShowGetCoinsDialog);
		if (_storeDomain != null)
		{
			StoreDomain storeDomain = _storeDomain;
			storeDomain.PurchaseErrorCallback = (Action<string>)Delegate.Remove(storeDomain.PurchaseErrorCallback, new Action<string>(ShowStoreErrorDialog));
		}
	}

	private void ShowStoreErrorDialog(string message)
	{
		Debug.LogError(message);
		GenericDialogData genericDialogData = new GenericDialogData();
		genericDialogData.title = _localization.GetLocalizedString("ui_store_transactionnotcompleted_title", "ui_store_transactionnotcompleted_title");
		genericDialogData.message = _localization.GetLocalizedString("ui_store_transactionnotcompleted_message", "ui_store_transactionnotcompleted_message");
		genericDialogData.negativeButtonText = _localization.GetLocalizedString("ui_generic_ok", "ui_generic_ok");
		ShowGenericDialog(genericDialogData);
	}

	private void ShowPurchaseDialog(StoreDisplayData data)
	{
		_purchaseDialog.SetData(data, CantAfford);
		_storeDomain.Icons.GetStoreIcon(data.storeData.DialogArtRef, _purchaseDialog.SetSprite);
	}

	private void ShowGenericDialog(string title, string message, string positiveButtonText, Action positiveButtonAction, string neutralButtonText, Action neutralButtonAction, string negativeButtonText, Action negativeButtonAction)
	{
		Debug.LogError(title + " SHOWGENERIC " + message);
		if (_genericAlert != null)
		{
			if (title != null)
			{
				_genericAlert.SetTitle(title);
			}
			if (message != null)
			{
				_genericAlert.SetMessage(message);
			}
			if (positiveButtonText != null)
			{
				_genericAlert.SetPositiveButton(positiveButtonText, positiveButtonAction);
			}
			else
			{
				_genericAlert.ClearPositiveButton();
			}
			if (neutralButtonText != null)
			{
				_genericAlert.SetNeutralButton(neutralButtonText, neutralButtonAction);
			}
			else
			{
				_genericAlert.ClearNeutralButton();
			}
			if (negativeButtonText != null)
			{
				_genericAlert.SetNegativeButton(negativeButtonText, negativeButtonAction);
			}
			else
			{
				_genericAlert.ClearNegativeButton();
			}
			AlertUtilities.ShowAlertWithAndroidBackButtonAction(_genericAlert, ShowGenericDialogb__29_0);
		}
	}

	private void ShowGetCoinsDialog()
	{
		SendByMoreCoinsDialogRequest("ui_store_notenough_fazcoins", "ui_store_notenough_fazcoins_title", "ui_store_notenough_fazcoins_neg_button", "ui_store_notenough_fazcoins_pos_button");
	}

	private void SendByMoreCoinsDialogRequest(string errorMsgKey, string errorTitleKey, string negButtonTextKey, string posButtonTextKey)
	{
		GenericDialogData genericDialogData = new GenericDialogData();
		genericDialogData.title = _localization.GetLocalizedString(errorTitleKey, errorTitleKey);
		genericDialogData.message = _localization.GetLocalizedString(errorMsgKey, errorMsgKey);
		genericDialogData.negativeButtonText = _localization.GetLocalizedString(negButtonTextKey, negButtonTextKey);
		genericDialogData.positiveButtonText = _localization.GetLocalizedString(posButtonTextKey, posButtonTextKey);
		genericDialogData.positiveButtonAction = SendByMoreCoinsDialogRequestb__31_0;
		ShowGenericDialog(genericDialogData);
	}

	public void ShowGenericDialog(GenericDialogData obj)
	{
		ShowGenericDialog(obj.title, obj.message, obj.positiveButtonText, obj.positiveButtonAction, obj.neutralButtonText, obj.neutralButtonAction, obj.negativeButtonText, obj.negativeButtonAction);
	}

	private void CantAfford(StoreDisplayData displayData)
	{
		_eventExposer.OnPurchaseRequestAudioInvoked(canAfford: false);
		if (displayData.currency == Currency.CurrencyType.EventCurrency)
		{
			ShowEarnEventCurrencyDialog();
		}
		else if (displayData.currency != Currency.CurrencyType.Parts)
		{
			_eventExposer.OnBuyMoreCoinsDialogRequest();
		}
		else
		{
			ShowEarnPartsDialog();
		}
	}

	private void ShowEarnEventCurrencyDialog()
	{
		GenericDialogData genericDialogData = new GenericDialogData();
		genericDialogData.title = _localization.GetLocalizedString("ui_store_notenough_eventcurrency_title", "ui_store_notenough_eventcurrency_title");
		genericDialogData.message = _localization.GetLocalizedString("ui_store_notenough_eventcurrency", "ui_store_notenough_eventcurrency");
		genericDialogData.negativeButtonText = _localization.GetLocalizedString("ui_generic_ok", "ui_generic_ok");
		ShowGenericDialog(genericDialogData);
	}

	private void ShowEarnPartsDialog()
	{
		GenericDialogData genericDialogData = new GenericDialogData();
		genericDialogData.title = _localization.GetLocalizedString("ui_store_notenough_parts_title", "ui_store_notenough_parts_title");
		genericDialogData.message = _localization.GetLocalizedString("ui_store_notenough_parts", "ui_store_notenough_parts");
		genericDialogData.negativeButtonText = _localization.GetLocalizedString("ui_generic_ok", "ui_generic_ok");
		ShowGenericDialog(genericDialogData);
	}

	private void SetupDialogs()
	{
		_genericAlert.SetAdapter(_genericDialog.GetComponent<IAlertPlatformAdapter>());
		_purchaseDialog.Initialize(_storeDomain, _eventExposer);
	}

	private void CleanUpDialogs()
	{
		if (_collectRewardAlert != null)
		{
			_collectRewardAlert.Dismiss();
		}
		_collectRewardAlert = null;
		if (_genericAlert != null)
		{
			_genericAlert.Dismiss();
		}
		_genericAlert = null;
	}

	private void Awake()
	{
		MasterDomain domain = MasterDomain.GetDomain();
		_gameUiDomain = domain.GameUIDomain;
		_eventExposer = domain.eventExposer;
		_theGameDomain = domain.TheGameDomain;
		_storeDomain = domain.StoreDomain;
		_itemDefinitions = domain.ItemDefinitionDomain.ItemDefinitions;
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(LocalizationReady);
		SetupDialogs();
		AddSubscriptions();
	}

	private void OnDestroy()
	{
		CleanUpDialogs();
		RemoveSubscriptions();
	}

	public DialogHandler_Shared()
	{
		_genericAlert = new Alert();
		_collectRewardAlert = new Alert();
	}

	private void ShowGenericDialogb__29_0()
	{
		if (_genericAlert.NegativeButton.Handler != null)
		{
			_genericAlert.NegativeButton.Handler();
		}
		_genericAlert.Dismiss();
	}

	private void SendByMoreCoinsDialogRequestb__31_0()
	{
		_gameUiDomain.GameUIData.storeScrollSection = "FazCoins";
	}
}
