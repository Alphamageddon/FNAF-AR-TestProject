using System;
using System.Collections.Generic;
using PlayFab;
using PlayFab.ClientModels;

public class PlayFabValidatePurchaseReceiptRequest : IValidatePurchaseReceiptRequest
{
	private Action _resultCallback;

	private Action<IllumixErrorData> _errorCallback;

	private readonly Action<ValidateGooglePlayPurchaseRequest, Action<ValidateGooglePlayPurchaseResult>, Action<PlayFabError>, object, Dictionary<string, string>> _validateIosReceipt;

	public PlayFabValidatePurchaseReceiptRequest(Action<ValidateGooglePlayPurchaseRequest, Action<ValidateGooglePlayPurchaseResult>, Action<PlayFabError>, object, Dictionary<string, string>> validateIosReceipt)
	{
		if (validateIosReceipt != null)
		{
			_validateIosReceipt = validateIosReceipt;
		}
		else
		{
			new NullReferenceException("validateIosReceipt");
		}
	}

	public void SetCallbacks(Action result, Action<IllumixErrorData> error)
	{
		_resultCallback = result;
		_errorCallback = error;
	}

	public void ValidatePurchaseReceipt(GooglePlayPurchase purchase)
	{
		ValidateGooglePlayPurchaseRequest arg = new ValidateGooglePlayPurchaseRequest
		{
			CatalogVersion = purchase.catalogVersion,
			CurrencyCode = purchase.currencyCode,
			PurchasePrice = purchase.purchasePrice,
			Signature = purchase.signature,
			ReceiptJson = purchase.receiptJson
		};
		_validateIosReceipt(arg, OnValidateGooglePlayPurchaseSuccess, OnValidateGooglePlayPurchaseFailure, null, null);
	}

	private void OnValidateGooglePlayPurchaseSuccess(ValidateGooglePlayPurchaseResult result)
	{
		_resultCallback();
	}

	private void OnValidateGooglePlayPurchaseFailure(PlayFabError playFabError)
	{
		_errorCallback(DataConverter.GenerateErrorData(playFabError));
	}
}
