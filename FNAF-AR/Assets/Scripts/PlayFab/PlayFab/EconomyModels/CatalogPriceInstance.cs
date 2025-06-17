using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class CatalogPriceInstance : PlayFabBaseModel
	{
		public List<CatalogPriceAmount> Amounts;
	}
}
