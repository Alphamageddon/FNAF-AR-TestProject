using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class CatalogPrice : PlayFabBaseModel
	{
		public List<CatalogPriceInstance> Prices;

		public List<CatalogPriceInstance> RealPrices;

		public int? Sort;
	}
}
