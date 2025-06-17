using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class StoreInfo : PlayFabBaseModel
	{
		public CatalogAlternateId AlternateId;

		public string Id;
	}
}
