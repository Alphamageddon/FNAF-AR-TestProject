using System.Collections.Generic;

public class StoreDisplayData
{
	public string shortCode;

	public StoreData storeData;

	public string Price;

	public Currency.CurrencyType currency;

	public int Cost;

	public List<StoreItem> Items;

	public int NumPurchased;

	public StoreContainer.StorefrontData storefrontData;

	public StoreDisplayData(StoreData data, StoreContainer.VirtualGoodData good)
	{
		shortCode = good.ShortCode;
		storeData = data;
		Items = data.Items;
		SetGood(good);
	}

	public void SetGood(StoreContainer.VirtualGoodData good)
	{
		if (good != null)
		{
			storefrontData = good.storefrontData;
			if (string.IsNullOrEmpty(good.Currency))
			{
				currency = Currency.CurrencyType.RealMoney;
			}
			else
			{
				currency = Currency.GetTypeForString(good.Currency);
			}
			Cost = good.Cost;
			Price = Cost.ToString();
		}
	}

	public void SetPrice(string price)
	{
		Price = price;
	}
}
