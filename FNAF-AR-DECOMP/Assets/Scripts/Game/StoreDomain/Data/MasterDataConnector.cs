using UnityEngine;

namespace Game.StoreDomain.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MasterDataConnector
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HasStoreDataLoaded>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HasStoreSectionDataLoaded>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Store.Container.StoreContainer _storeContainer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnDataLoaded;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasStoreDataLoaded { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasStoreSectionDataLoaded { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasStoreDataLoaded()
        {
            return (bool)this.<HasStoreDataLoaded>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HasStoreDataLoaded(bool value)
        {
            this.<HasStoreDataLoaded>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasStoreSectionDataLoaded()
        {
            return (bool)this.<HasStoreSectionDataLoaded>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HasStoreSectionDataLoaded(bool value)
        {
            this.<HasStoreSectionDataLoaded>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void add_OnDataLoaded(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnDataLoaded, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataLoaded != 1152921525132985904);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void remove_OnDataLoaded(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnDataLoaded, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataLoaded != 1152921525133122480);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MasterDataConnector(Game.MasterData.MasterDataDomain masterDataDomain, Game.Store.Container.StoreContainer storeContainer, System.Action callback)
        {
            val_1 = new System.Object();
            this._storeContainer = val_1;
            masterDataDomain.GetAccessToData.GetStoreDataAsync(returnStoreDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.STORE_DATA>(object:  this, method:  System.Void Game.StoreDomain.Data.MasterDataConnector::SetStoreData(ProtoData.STORE_DATA storeData)));
            masterDataDomain.GetAccessToData.GetStoreSectionDataAsync(returnStoreSectionDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.STORESECTIONS_DATA>(object:  this, method:  System.Void Game.StoreDomain.Data.MasterDataConnector::SetStoreSectionData(ProtoData.STORESECTIONS_DATA storeSectionData)));
            this.add_OnDataLoaded(value:  callback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetStoreSectionData(ProtoData.STORESECTIONS_DATA storeSectionData)
        {
            this._storeContainer.LoadStoreSectionDataFromServer(data:  storeSectionData);
            this.<HasStoreSectionDataLoaded>k__BackingField = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetStoreData(ProtoData.STORE_DATA storeData)
        {
            this._storeContainer.LoadStoreDataFromServer(data:  storeData);
            this.<HasStoreDataLoaded>k__BackingField = true;
            if(this.OnDataLoaded == null)
            {
                    return;
            }
            
            this.OnDataLoaded.Invoke();
        }
    
    }

}
