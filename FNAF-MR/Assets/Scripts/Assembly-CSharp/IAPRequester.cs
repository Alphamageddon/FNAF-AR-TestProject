using System;
using PlayFab;
using PlayFab.ClientModels;

public class IAPRequester
{
	private Action _virtualCurrencyTransactionSuccess;

	private LogEventHandler _eventHandler;

	private PurchaseItemRequest _purchaseItemRequest;

	private Action<string> _virtualGoodErrorCallback;

	private const int CLIENT_TO_PLAYFAB_CONVERSION_RATE = 100;

	private readonly IPurchaseItemRequest _illumixPurchaseItemRequest;

	private IValidatePurchaseReceiptRequest _validatePurchaseReceiptRequest;

	private static bool USE_SANDBOX;

	public IAPRequester(LogEventHandler eventHandler, EventExposer exposer, IPurchaseItemRequest purchaseItemRequest, IValidatePurchaseReceiptRequest validatePurchaseReceiptRequest)
	{
		_eventHandler = eventHandler;
		InitializePlayFabPurchaseRequest();
		_illumixPurchaseItemRequest = purchaseItemRequest;
		_illumixPurchaseItemRequest.SetCallbacks(IllumixVirtualCurrencyPurchaseSuccess, IllumixPurchaseFailure);
		_validatePurchaseReceiptRequest = validatePurchaseReceiptRequest;
	}

	private void EventExposer_StoreIdReceived(string storeId)
	{
		_purchaseItemRequest.StoreId = storeId;
	}

	private void InitializePlayFabPurchaseRequest()
	{
		_purchaseItemRequest = new PurchaseItemRequest
		{
			StoreId = ServerDomain.StoreName,
			CatalogVersion = ServerDomain.CatalogName
		};
	}

	public void BuyVirtualGood(string itemId, string storeId, string currency, int cost, Action successCallback, Action<string> errorCallback)
	{
		_virtualCurrencyTransactionSuccess = successCallback;
		_virtualGoodErrorCallback = errorCallback;
		SendIllumixPurchaseRequest(itemId, storeId, currency, cost);
	}

	private void SendIllumixPurchaseRequest(string itemId, string storeId, string currency, int cost)
	{
		StorePurchaseItemRequestInformation(itemId, storeId, currency, cost);
		PurchaseItemParameters purchaseItemParameters = new PurchaseItemParameters
		{
			catalogVersion = _purchaseItemRequest.CatalogVersion,
			itemId = itemId,
			price = cost,
			storeId = storeId,
			virtualCurrency = currency
		};
		_illumixPurchaseItemRequest.SetAuthenticationContext(ServerDomain.IllumixAuthContext);
		_illumixPurchaseItemRequest.PurchaseItem(purchaseItemParameters);
	}

	private void IllumixPurchaseFailure(IllumixErrorData error)
	{
		if (_virtualGoodErrorCallback != null)
		{
			_virtualGoodErrorCallback(error.errorMessage);
		}
	}

	private void IllumixVirtualCurrencyPurchaseSuccess(PurchaseItemResultData result)
	{
		if (_virtualCurrencyTransactionSuccess != null)
		{
			_virtualCurrencyTransactionSuccess();
		}
	}

	private void StorePurchaseItemRequestInformation(string itemId, string storeId, string currency, int cost)
	{
		_purchaseItemRequest.ItemId = itemId;
		_purchaseItemRequest.StoreId = storeId;
		_purchaseItemRequest.VirtualCurrency = currency;
		_purchaseItemRequest.Price = cost;
	}

	public void PlayFabReceiptError(PlayFabError result)
	{
		if (_virtualGoodErrorCallback != null)
		{
			_virtualGoodErrorCallback(result.Error.ToString());
		}
	}

	public void PlayFabVirtualCurrencyPurchaseSuccess(PurchaseItemResult response)
	{
		if (_virtualCurrencyTransactionSuccess != null)
		{
			_virtualCurrencyTransactionSuccess();
		}
	}

	public void PlayFabPurchaseFailure(PlayFabError error)
	{
		if (_virtualGoodErrorCallback != null)
		{
			_virtualGoodErrorCallback(error.Error.ToString());
		}
	}
}
