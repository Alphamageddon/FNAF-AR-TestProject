using System;

public interface IPurchaseItemRequest
{
	void SetCallbacks(Action<PurchaseItemResultData> result, Action<IllumixErrorData> error);

	void SetAuthenticationContext(IllumixAuthenticationContext authContext);

	void PurchaseItem(PurchaseItemParameters purchaseItemParameters);
}
