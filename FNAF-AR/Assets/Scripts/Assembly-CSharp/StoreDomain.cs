using System;
using PlayFab;
using UnityEngine;

public class StoreDomain
{
	private EventExposer _eventExposer;

	private ServerDomain _serverDomain;

	private StoreMasterDataConnector _masterDataConnector;

	private CurrencyBank _bank;

	private StoreDialogDisplay _storeDialogDisplay;

	private StoreIconFetcher _storeIconFetcher;

	public Action<string> PurchaseErrorCallback;

	public Action IconsLoaded;

	public StoreIconFetcher Icons => _storeIconFetcher;

	public StoreContainer StoreContainer { get; set; }

	public ServerDomain ServerDomain => _serverDomain;

	protected StoreDomain GetPublicInterface => this;

	public StoreDomain(EventExposer exposer)
	{
		_eventExposer = exposer;
		StoreContainer = new StoreContainer();
		_storeDialogDisplay = new StoreDialogDisplay(_eventExposer);
	}

	public void Setup(MasterDataDomain masterDataDomain, GameDisplayChanger gameDisplayChanger, IconLookup lookupAccess, ItemDefinitions itemDefinitions, ServerDomain serverDomain, CurrencyBank bank)
	{
		_serverDomain = serverDomain;
		_bank = bank;
		_masterDataConnector = new StoreMasterDataConnector(masterDataDomain, StoreContainer, null);
		StoreContainer.SetItemDefinitions(itemDefinitions);
		IconCacheReady(lookupAccess);
		SetupCallbacks();
	}

	private void SetupCallbacks()
	{
		if (StoreContainer != null)
		{
			StoreContainer.OwnedGoodsReceived = RequestVirtualGoods;
			_eventExposer.add_VirtualGoodsDataReceived(StoreContainer.UpdateVirtualGoodsCatalogue);
			_eventExposer.add_PlayerGoodsUpdated(StoreContainer.ProcessOwnedGoods);
			_eventExposer.add_PlayerStoreDataUpdated(StoreContainer.PlayerStoreDataUpdated);
		}
		_eventExposer.add_AllOrtonBundlesDownloaded(OnLoadingDone);
	}

	private void OnLoadingDone()
	{
		StoreContainer.StoreLoadError = OnStoreLoadErrorReceived;
	}

	private void IconCacheReady(IconLookup iconLookup)
	{
		_storeIconFetcher = new StoreIconFetcher(iconLookup);
		if (IconsLoaded != null)
		{
			IconsLoaded();
		}
	}

	public void Teardown()
	{
		StoreContainer = null;
		_masterDataConnector = null;
		_eventExposer = null;
	}

	private void GetOwnedGoods()
	{
		_serverDomain.getOwnedGoodsRequester.GetOwnedGoods();
	}

	public void RequestVirtualGoods()
	{
		_serverDomain.virtualGoodsListRequester.RequestVirtualGoods();
	}

	public void InitiatePurchase(StoreDisplayData data)
	{
		if (data.currency == Currency.CurrencyType.RealMoney)
		{
			Debug.LogError("PLAYER TRIED TO SPEND REAL MONEY.. EW??");
			return;
		}
		Debug.Log("purchasing with currency " + data.currency);
		_serverDomain.iapRequester.BuyVirtualGood(data.shortCode, data.storefrontData.Name, Currency.GetCurrencyString(data.currency), data.Cost, OnPurchaseSuccess, OnPurchaseError);
	}

	public bool CanAfford(StoreDisplayData data)
	{
		if (data.currency == Currency.CurrencyType.RealMoney)
		{
			return true;
		}
		if (_bank != null)
		{
			Debug.Log("checking can afford for currency " + data.currency.ToString() + " cost " + data.Cost);
			return _bank.CanAfford(data.currency, data.Cost);
		}
		return false;
	}

	public bool PaymentInFlight(StoreDisplayData data)
	{
		if (data.currency == Currency.CurrencyType.RealMoney)
		{
			return StoreContainer.PaymentInFlight();
		}
		return false;
	}

	public void ShowInFlightDialog()
	{
		_storeDialogDisplay.GenerateInFlightPurchaseDialog();
	}

	public void OnPurchaseSuccess()
	{
		GetOwnedGoods();
		_storeDialogDisplay.GeneratePurchaseSuccessDialog();
	}

	public void OnPurchaseError(string error)
	{
		if (PurchaseErrorCallback != null)
		{
			PurchaseErrorCallback(error);
		}
	}

	public void OnReceiptValidationError(PlayFabError error)
	{
		Debug.LogError("UnityStoreListener PlayFabReceiptFailure - " + ConvertErrorCodeToString(error.Error));
		if (PurchaseErrorCallback != null)
		{
			PurchaseErrorCallback(error.GenerateErrorReport());
		}
	}

	public void OnPurchaseDisabled()
	{
		_storeDialogDisplay.GeneratePurchaseDisabledDialog();
	}

	public void OnStoreLoadErrorReceived()
	{
		_storeDialogDisplay.GenerateStoreLoadErrorDialog();
	}

	private string ConvertErrorCodeToString(PlayFabErrorCode errorCode)
	{
		return errorCode switch
		{
			PlayFabErrorCode.SubscriptionAlreadyTaken => "Subscription Already Taken " + errorCode, 
			PlayFabErrorCode.NoMatchingCatalogItemForReceipt => "No Matching Catalog Item For Receipt " + errorCode, 
			_ => errorCode.ToString(), 
		};
	}
}
