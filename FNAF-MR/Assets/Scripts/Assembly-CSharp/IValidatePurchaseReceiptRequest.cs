using System;

public interface IValidatePurchaseReceiptRequest
{
	void SetCallbacks(Action result, Action<IllumixErrorData> error);

	void ValidatePurchaseReceipt(GooglePlayPurchase purchase);
}
