using UnityEngine;

namespace Game.SeasonalEvents
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SeasonalEventDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MasterData.GetAccessToData _getAccessToData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.SeasonalEvents.SeasonalEventMechanics _mechanicsLists;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.SeasonalEvents.Container.SeasonalEventDataContainer _container;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.SeasonalEvents.SeasonalChangeDetector _detector;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SeasonalEventDomain(Game.MasterData.GetAccessToData getAccessToData, Master.EventExposer eventExposer)
        {
            System.Action val_9;
            var val_10;
            val_1 = new System.Object();
            this._getAccessToData = getAccessToData;
            this._eventExposer = val_1;
            this._mechanicsLists = new Game.SeasonalEvents.SeasonalEventMechanics();
            this._container = new Game.SeasonalEvents.Container.SeasonalEventDataContainer(eventExposer:  Master.EventExposer val_1 = eventExposer);
            this._detector = new Game.SeasonalEvents.SeasonalChangeDetector(getAccessToData:  getAccessToData, eventExposer:  val_1);
            val_9 = System.Delegate.Combine(a:  this._container.EventDataLoaded, b:  new System.Action(object:  this, method:  System.Void Game.SeasonalEvents.SeasonalEventDomain::ProcessActiveEvents()));
            val_10 = null;
            if((val_9 != null) && (null != val_10))
            {
                    val_10 = null;
                val_9 = 0;
            }
            
            this._container.EventDataLoaded = val_9;
            this._eventExposer.add_FTUEComplete(value:  new System.Action(object:  this, method:  System.Void Game.SeasonalEvents.SeasonalEventDomain::FTUEComplete()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShouldStartCheckingUpdate()
        {
            if(this._detector != null)
            {
                    return (bool)this._detector.startCheckingUpdate;
            }
            
            return (bool)this._detector.startCheckingUpdate;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool UpcomingUpdateExist()
        {
            if(this._detector != null)
            {
                    return (bool)this._detector.upcomingUpdateExist;
            }
            
            return (bool)this._detector.upcomingUpdateExist;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool WaitingForForceRestart()
        {
            if(this._detector != null)
            {
                    return this._detector.WaitingForForceRestart();
            }
            
            return this._detector.WaitingForForceRestart();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShouldUpdateSeasonalNow()
        {
            if(this._detector != null)
            {
                    return this._detector.ShouldUpdateSeasonalNow();
            }
            
            return this._detector.ShouldUpdateSeasonalNow();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessActiveEvents()
        {
            System.Delegate val_5 = System.Delegate.Remove(source:  this._container.EventDataLoaded, value:  new System.Action(object:  this, method:  System.Void Game.SeasonalEvents.SeasonalEventDomain::ProcessActiveEvents()));
            if(this._container == null)
            {
                goto label_2;
            }
            
            if(val_5 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_5 == null)
            {
                goto label_6;
            }
            
            label_3:
            if(null != null)
            {
                    val_5 = 0;
            }
            
            label_6:
            this._container.EventDataLoaded = val_5;
            this._getAccessToData.GetSeasonalDataAsync(returnSeasonalDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.SEASONAL_DATA>(object:  this, method:  System.Void Game.SeasonalEvents.SeasonalEventDomain::SortEventData(ProtoData.SEASONAL_DATA eventData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SortEventData(ProtoData.SEASONAL_DATA eventData)
        {
            var val_12;
            var val_13;
            this._mechanicsLists.Clear();
            System.Collections.Generic.IEnumerator<T> val_2 = eventData.Entries.GetEnumerator();
            label_22:
            var val_12 = 0;
            val_12 = val_12 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_9;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            T val_6 = val_2.Current;
            if((val_6.Logical == null) || ((this._container._activeEvents.ContainsKey(key:  val_6.Logical)) == false))
            {
                goto label_22;
            }
            
            this.PopulateEntryMechanics(data:  val_6.Mechanics);
            goto label_22;
            label_9:
            val_12 = 0;
            val_13 = 96;
            if(val_2 == null)
            {
                
            }
            else
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_2.Dispose();
            }
            
            this.BroadcastData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FTUEComplete()
        {
            if(this._container._activeEvents.Count == 0)
            {
                    return;
            }
            
            this._detector.ForceRestartAfterDelay(delay:  11f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._mechanicsLists.Clear();
            this._mechanicsLists = 0;
            this._container.Teardown();
            this._container = 0;
            this._eventExposer.remove_FTUEComplete(value:  new System.Action(object:  this, method:  System.Void Game.SeasonalEvents.SeasonalEventDomain::FTUEComplete()));
            this._eventExposer = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PopulateEntryMechanics(ProtoData.SEASONAL_DATA.Types.ENTRY.Types.MECHANICS data)
        {
            System.Collections.Generic.List<System.String> val_11;
            if(data == null)
            {
                    return;
            }
            
            if(data.SequentialRewards != null)
            {
                    val_11 = this._mechanicsLists.SequentialRewardsIds;
                val_11.Add(item:  data.SequentialRewards);
            }
            
            if(data.StoreSale != null)
            {
                    val_11 = this._mechanicsLists.StoreSaleIds;
                val_11.Add(item:  data.StoreSale);
            }
            
            if(data.StoreSkin != null)
            {
                    val_11 = this._mechanicsLists.StoreSkinIds;
                val_11.Add(item:  data.StoreSkin);
            }
            
            if(data.StoreId != null)
            {
                    val_11 = this._mechanicsLists.StoreId;
                val_11.Add(item:  data.StoreId);
            }
            
            if(data.SeasonalAssetsGroup == null)
            {
                    return;
            }
            
            this._mechanicsLists.SeasonalAssetGroups.Add(item:  data.SeasonalAssetsGroup);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BroadcastData()
        {
            this._eventExposer.OnActiveSeasonalEventsUpdated(tag:  2, activeIds:  this._mechanicsLists.SeasonalAssetGroups);
            this._eventExposer.OnActiveSeasonalEventsUpdated(tag:  3, activeIds:  this._mechanicsLists.SequentialRewardsIds);
            this._eventExposer.OnActiveSeasonalEventsUpdated(tag:  4, activeIds:  this._mechanicsLists.StoreSkinIds);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DistributeSequentialRewardData(string sequentialRewardsId)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DistributeStoreSaleData(string storeSaleId)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DistributeStoreSkinData(string storeSaleId)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DistributeCatalog(string storeSaleId)
        {
        
        }
    
    }

}
