using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class PayoutDetails : PlayFabBaseModel
	{
		public string AccountSellerId;

		public string TaxCode;

		public string Uaid;
	}
}
