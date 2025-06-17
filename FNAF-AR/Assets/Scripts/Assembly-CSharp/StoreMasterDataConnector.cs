using System;

public class StoreMasterDataConnector
{
	private StoreContainer _storeContainer;

	private Action OnDataLoaded;

	public bool HasStoreDataLoaded { get; set; }

	public bool HasStoreSectionDataLoaded { get; set; }

	public bool HasSubscriptionItemDataLoaded { get; set; }

	public bool HasCarouselItemDataLoaded { get; set; }

	private void add_OnDataLoaded(Action value)
	{
		OnDataLoaded = (Action)Delegate.Combine(OnDataLoaded, value);
	}

	private void remove_OnDataLoaded(Action value)
	{
		OnDataLoaded = (Action)Delegate.Remove(OnDataLoaded, value);
	}

	public StoreMasterDataConnector(MasterDataDomain masterDataDomain, StoreContainer storeContainer, Action callback)
	{
		_storeContainer = storeContainer;
		masterDataDomain.GetAccessToData.GetStoreDataAsync(SetStoreData);
		masterDataDomain.GetAccessToData.GetStoreSectionDataAsync(SetStoreSectionData);
		add_OnDataLoaded(callback);
	}

	private void SetStoreSectionData(STORESECTIONS_DATA.Root storeSectionData)
	{
		_storeContainer.LoadStoreSectionDataFromServer(storeSectionData);
		HasStoreSectionDataLoaded = true;
	}

	private void SetStoreData(STORE_DATA.Root storeData)
	{
		_storeContainer.LoadStoreDataFromServer(storeData);
		HasStoreDataLoaded = true;
		TryCompleteDataLoad();
	}

	private void TryCompleteDataLoad()
	{
		if (HasStoreDataLoaded && OnDataLoaded != null)
		{
			OnDataLoaded();
		}
	}
}
