using System;
using System.Collections;
using PaperPlaneTools;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StorePurchaseDialog : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public Action<string> callback;

		internal void _003CFetchLocalization_003Eb__0(Localization localization)
		{
			callback(localization.GetLocalizedString("ui_workshop_dialogs_cancel", "ui_workshop_dialogs_cancel"));
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public string eventCurrencyIcon;

		public StorePurchaseDialog _003C_003E4__this;

		public Action<Sprite> _003C_003E9__1;

		internal void _003CInitializeEventCurrencyIcon_003Eb__0(IconLookup lookup)
		{
			lookup.GetIcon(IconGroup.Store, eventCurrencyIcon, _003CInitializeEventCurrencyIcon_003Eb__1);
		}

		internal void _003CInitializeEventCurrencyIcon_003Eb__1(Sprite sprite)
		{
			_003C_003E4__this._purchaseButtonEventCurrencyIcon.sprite = sprite;
		}
	}

	private const string CANCEL_TEXT = "ui_workshop_dialogs_cancel";

	private const float PURCHASE_TEXT_REFRESH_RATE = 0.5f;

	private const float PURCHASE_TIMEOUT_SECONDS = 60f;

	[SerializeField]
	private Button _purchaseButton;

	[SerializeField]
	private TextMeshProUGUI _purchaseButtonText;

	[SerializeField]
	private Image _purchaseButtonFazTokensIcon;

	[SerializeField]
	private Image _purchaseButtonPartsIcon;

	[SerializeField]
	private Image _purchaseButtonEventCurrencyIcon;

	[SerializeField]
	private Image _icon;

	[SerializeField]
	private GameObject _panelFooter;

	private Alert _alert;

	private StoreDisplayData _data;

	private StoreDomain _storeDomain;

	private EventExposer _eventExposer;

	private Action<StoreDisplayData> _cantAffordCallback;

	private IEnumerator _loadingAnimationCoroutine;

	public void Initialize(StoreDomain storeDomain, EventExposer eventExposer)
	{
		_storeDomain = storeDomain;
		_eventExposer = eventExposer;
		_purchaseButton.onClick.AddListener(OnPurchaseButtonClicked);
	}

	public void SetData(StoreDisplayData data, Action<StoreDisplayData> cantAffordCallback)
	{
		_data = data;
		_cantAffordCallback = cantAffordCallback;
		FetchLocalization(SetupAlert);
	}

	public void SetSprite(Sprite sprite)
	{
		_icon.overrideSprite = sprite;
	}

	private void SetupAlert(string cancelText)
	{
		if (_alert != null)
		{
			StopLoadingAnimationCoroutine();
			_alert.Dismiss();
			_alert = null;
		}
		_alert = new Alert();
		_alert.SetAdapter(base.gameObject.GetComponent<IAlertPlatformAdapter>());
		_alert.SetNegativeButton(cancelText);
		_alert.SetTitle(_data.storeData.Name);
		_alert.SetMessage(_data.storeData.Description);
		SetupPurchaseButton();
		_panelFooter.SetActive(value: true);
		AlertUtilities.ShowAlertWithAndroidBackButtonAction(_alert, SetupAlertb__19_0);
	}

	private void SetupPurchaseButton()
	{
		_purchaseButtonPartsIcon.gameObject.SetActive(_data.currency == Currency.CurrencyType.Parts);
		_purchaseButtonFazTokensIcon.gameObject.SetActive(_data.currency == Currency.CurrencyType.HardCurrency);
		_purchaseButtonEventCurrencyIcon.gameObject.SetActive(_data.currency == Currency.CurrencyType.EventCurrency);
		if (_data.currency == Currency.CurrencyType.EventCurrency)
		{
			InitializeEventCurrencyIcon();
		}
		_purchaseButton.interactable = true;
		_purchaseButtonText.text = _data.Cost.ToString();
	}

	private void FetchLocalization(Action<string> callback)
	{
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
		_003C_003Ec__DisplayClass21_.callback = callback;
		_003C_003Ec__DisplayClass21_._003CFetchLocalization_003Eb__0(LocalizationDomain.Instance.Localization);
	}

	private void InitializeEventCurrencyIcon()
	{
	}

	private void OnDisable()
	{
		StopLoadingAnimationCoroutine();
		if (_alert != null)
		{
			_alert.Dismiss();
		}
		_alert = null;
	}

	private void OnPurchaseButtonClicked()
	{
		if (!_storeDomain.CanAfford(_data))
		{
			if (_cantAffordCallback != null)
			{
				_cantAffordCallback(_data);
			}
			if (_alert != null)
			{
				_alert.Dismiss();
			}
		}
		else
		{
			_loadingAnimationCoroutine = AnimateLoadingMessage();
			StartCoroutine(AnimateLoadingMessage());
			_panelFooter.SetActive(value: false);
			_purchaseButton.interactable = false;
			StoreContainer storeContainer = _storeDomain.StoreContainer;
			storeContainer.OwnedGoodsReceived = (Action)Delegate.Combine(storeContainer.OwnedGoodsReceived, new Action(OnOwnedGoodsReceived));
			StoreDomain storeDomain = _storeDomain;
			storeDomain.PurchaseErrorCallback = (Action<string>)Delegate.Combine(storeDomain.PurchaseErrorCallback, new Action<string>(OnPurchaseError));
			_eventExposer.OnPurchaseRequestAudioInvoked(canAfford: true);
			_storeDomain.InitiatePurchase(_data);
		}
	}

	private void OnOwnedGoodsReceived()
	{
		StoreContainer storeContainer = _storeDomain.StoreContainer;
		storeContainer.OwnedGoodsReceived = (Action)Delegate.Remove(storeContainer.OwnedGoodsReceived, new Action(OnOwnedGoodsReceived));
		StopLoadingAnimationCoroutine();
		if (_alert != null)
		{
			_alert.Dismiss();
		}
	}

	private void OnPurchaseError(string errorMessage)
	{
		StoreDomain storeDomain = _storeDomain;
		storeDomain.PurchaseErrorCallback = (Action<string>)Delegate.Remove(storeDomain.PurchaseErrorCallback, new Action<string>(OnPurchaseError));
		StopLoadingAnimationCoroutine();
		if (_alert != null)
		{
			_alert.Dismiss();
		}
	}

	private void StopLoadingAnimationCoroutine()
	{
		if (_loadingAnimationCoroutine != null)
		{
			StopCoroutine(_loadingAnimationCoroutine);
			_loadingAnimationCoroutine = null;
		}
	}

	private IEnumerator AnimateLoadingMessage()
	{
		_purchaseButtonPartsIcon.gameObject.SetActive(value: false);
		_purchaseButtonFazTokensIcon.gameObject.SetActive(value: false);
		_purchaseButtonEventCurrencyIcon.gameObject.SetActive(value: false);
		_purchaseButtonText.text = ".";
		while (_alert != null)
		{
			yield return new WaitForSeconds(0.5f);
			if (_purchaseButtonText.text == "...")
			{
				_purchaseButtonText.text = ".";
			}
			else
			{
				_purchaseButtonText.text += ".";
			}
		}
	}

	private void SetupAlertb__19_0()
	{
		_alert.Dismiss();
	}
}
