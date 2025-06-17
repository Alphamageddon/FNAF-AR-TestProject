using System;
using System.Collections.Generic;
using PlayFab;
using PlayFab.ClientModels;

public class PlayFabPurchaseItemRequest : IPurchaseItemRequest
{
	private Action<PurchaseItemResultData> _resultCallback;

	private Action<IllumixErrorData> _errorCallback;

	private IllumixAuthenticationContext _authenticationContext;

	private readonly Action<PurchaseItemRequest, Action<PurchaseItemResult>, Action<PlayFabError>, object, Dictionary<string, string>> _purchaseItemApi;

	public PlayFabPurchaseItemRequest(Action<PurchaseItemRequest, Action<PurchaseItemResult>, Action<PlayFabError>, object, Dictionary<string, string>> purchaseItem)
	{
		if (purchaseItem != null)
		{
			_purchaseItemApi = purchaseItem;
		}
		else
		{
			new NullReferenceException("purchaseItem");
		}
	}

	public void SetCallbacks(Action<PurchaseItemResultData> result, Action<IllumixErrorData> error)
	{
		_resultCallback = result;
		_errorCallback = error;
	}

	public void SetAuthenticationContext(IllumixAuthenticationContext authContext)
	{
		_authenticationContext = authContext;
	}

	public void PurchaseItem(PurchaseItemParameters purchaseItemParameters)
	{
		PurchaseItemRequest arg = new PurchaseItemRequest
		{
			AuthenticationContext = DataConverter.GenerateAuthContext(_authenticationContext),
			CatalogVersion = purchaseItemParameters.catalogVersion,
			ItemId = purchaseItemParameters.itemId,
			Price = purchaseItemParameters.price,
			StoreId = purchaseItemParameters.storeId,
			VirtualCurrency = purchaseItemParameters.virtualCurrency
		};
		_purchaseItemApi(arg, OnPurchaseItemSuccess, OnPurchaseItemError, null, null);
	}

	private void OnPurchaseItemSuccess(PurchaseItemResult result)
	{
		_resultCallback(new PurchaseItemResultData(result));
	}

	private void OnPurchaseItemError(PlayFabError error)
	{
		_errorCallback(DataConverter.GenerateErrorData(error));
	}
}
