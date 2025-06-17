using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class PurchaseData.Builder
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly GetSocialSdk.Core.Analytics.PurchaseData _purchaseData;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal PurchaseData.Builder()
    {
        this._purchaseData = new GetSocialSdk.Core.Analytics.PurchaseData();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GetSocialSdk.Core.Analytics.PurchaseData.Builder WithProductId(string productId)
    {
        this._purchaseData._productId = productId;
        return (Builder)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GetSocialSdk.Core.Analytics.PurchaseData.Builder WithProductTitle(string productTitle)
    {
        this._purchaseData._productTitle = productTitle;
        return (Builder)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GetSocialSdk.Core.Analytics.PurchaseData.Builder WithProductType(GetSocialSdk.Core.Analytics.PurchaseData.ProductType productType)
    {
        this._purchaseData._productType = productType;
        return (Builder)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GetSocialSdk.Core.Analytics.PurchaseData.Builder WithPrice(float price)
    {
        this._purchaseData._price = price;
        return (Builder)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GetSocialSdk.Core.Analytics.PurchaseData.Builder WithPriceCurrency(string priceCurrency)
    {
        this._purchaseData._priceCurrency = priceCurrency;
        return (Builder)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GetSocialSdk.Core.Analytics.PurchaseData.Builder WithPurchaseDate(System.DateTime purchaseDate)
    {
        this._purchaseData._purchaseDate = purchaseDate;
        return (Builder)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GetSocialSdk.Core.Analytics.PurchaseData.Builder WithPurchaseId(string purchaseId)
    {
        this._purchaseData._purchaseId = purchaseId;
        return (Builder)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GetSocialSdk.Core.Analytics.PurchaseData Build()
    {
        return (GetSocialSdk.Core.Analytics.PurchaseData)this._purchaseData;
    }

}
