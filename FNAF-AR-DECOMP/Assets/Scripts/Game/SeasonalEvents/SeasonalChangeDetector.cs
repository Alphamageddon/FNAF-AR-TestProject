using UnityEngine;

namespace Game.SeasonalEvents
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SeasonalChangeDetector
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool startCheckingUpdate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool upcomingUpdateExist;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.DateTime upcomingUpdateTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.DateTime _lastCheckedTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<System.DateTime> _allDateTimes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _allowedToStart;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _allAssetsDownloaded;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SimpleTimer _forceRestartTimer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SeasonalChangeDetector(Game.MasterData.GetAccessToData getAccessToData, Master.EventExposer eventExposer)
        {
            this._forceRestartTimer = new SimpleTimer();
            val_2 = new System.Object();
            this.startCheckingUpdate = false;
            this.upcomingUpdateExist = false;
            this._eventExposer = val_2;
            getAccessToData.GetSeasonalDataAsync(returnSeasonalDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.SEASONAL_DATA>(object:  this, method:  System.Void Game.SeasonalEvents.SeasonalChangeDetector::FindAllStartEndTime(ProtoData.SEASONAL_DATA eventData)));
            this._eventExposer.add_ShouldStartCheckingSeasonalUpdate(value:  new System.Action(object:  this, method:  System.Void Game.SeasonalEvents.SeasonalChangeDetector::OnStartCheckingSeasonalUpdate()));
            this._eventExposer.add_AssetBundleDownloadSegmentsAllComplete(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Game.SeasonalEvents.SeasonalChangeDetector::OnAssetBundleDownloadSegmentsAllComplete(int failedAssetCount)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._eventExposer.remove_ShouldStartCheckingSeasonalUpdate(value:  new System.Action(object:  this, method:  System.Void Game.SeasonalEvents.SeasonalChangeDetector::OnStartCheckingSeasonalUpdate()));
            this._eventExposer.remove_AssetBundleDownloadSegmentsAllComplete(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Game.SeasonalEvents.SeasonalChangeDetector::OnAssetBundleDownloadSegmentsAllComplete(int failedAssetCount)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ForceRestartAfterDelay(float delay)
        {
            this._forceRestartTimer.StartTimer(time:  delay);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool WaitingForForceRestart()
        {
            SimpleTimer val_4;
            var val_5;
            val_4 = this;
            if(this._forceRestartTimer.Started() != false)
            {
                    val_4 = this._forceRestartTimer;
                val_5 = val_4.IsExpired() ^ 1;
                return (bool)val_5 & 1;
            }
            
            val_5 = 0;
            return (bool)val_5 & 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShouldUpdateSeasonalNow()
        {
            var val_7;
            if(this._forceRestartTimer.Started() != false)
            {
                    if(this._forceRestartTimer.IsExpired() != false)
            {
                    val_7 = 1;
                return (bool)val_7;
            }
            
            }
            
            long val_3 = TheGame.ServerTime.GetCurrentTime();
            System.DateTime val_4 = val_3.UnixTimeInSecondsToUtcDateTime(unixTimeStamp:  val_3);
            val_7 = Game.SeasonalEvents.SeasonalChangeDetector.TimeWithinInterval(startTime:  new System.DateTime() {dateData = this._lastCheckedTime}, endTime:  new System.DateTime() {dateData = val_4.dateData}, checkTime:  new System.DateTime() {dateData = this.upcomingUpdateTime});
            this._lastCheckedTime = val_4;
            return (bool)val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool TimeWithinInterval(System.DateTime startTime, System.DateTime endTime, System.DateTime checkTime)
        {
            if((System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = checkTime.dateData}, t2:  new System.DateTime() {dateData = startTime.dateData})) == false)
            {
                    return false;
            }
            
            return System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = checkTime.dateData}, t2:  new System.DateTime() {dateData = endTime.dateData});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnStartCheckingSeasonalUpdate()
        {
            this._allowedToStart = true;
            if(this._allAssetsDownloaded == false)
            {
                    return;
            }
            
            this.startCheckingUpdate = true;
            this.GetFirstUpcomingSeasonalUpdateTime();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnAssetBundleDownloadSegmentsAllComplete(int failedAssetCount)
        {
            this._allAssetsDownloaded = true;
            if(this._allowedToStart == false)
            {
                    return;
            }
            
            this.startCheckingUpdate = true;
            this.GetFirstUpcomingSeasonalUpdateTime();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryToStartCheckingUpdate()
        {
            if(this._allowedToStart == false)
            {
                    return;
            }
            
            if(this._allAssetsDownloaded == false)
            {
                    return;
            }
            
            this.startCheckingUpdate = true;
            this.GetFirstUpcomingSeasonalUpdateTime();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FindAllStartEndTime(ProtoData.SEASONAL_DATA eventData)
        {
            var val_21;
            var val_22;
            var val_25;
            var val_26;
            this._allDateTimes = new System.Collections.Generic.List<System.DateTime>();
            val_21 = 1152921504689487872;
            val_22 = eventData.Entries.GetEnumerator();
            label_20:
            var val_23 = 0;
            val_23 = val_23 + 1;
            if(val_22.MoveNext() == false)
            {
                goto label_8;
            }
            
            var val_24 = 0;
            val_24 = val_24 + 1;
            T val_7 = val_22.Current;
            System.DateTime val_9 = val_7.StartTime.ToDateTime();
            this._allDateTimes.Add(item:  new System.DateTime() {dateData = val_9.dateData});
            System.DateTime val_11 = val_7.EndTime.ToDateTime();
            this._allDateTimes.Add(item:  new System.DateTime() {dateData = val_11.dateData});
            goto label_20;
            label_8:
            val_25 = 0;
            val_26 = 96;
            if(val_22 == null)
            {
                
            }
            else
            {
                    var val_25 = 0;
                val_25 = val_25 + 1;
                val_22.Dispose();
            }
            
            if( == 96)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_22 = ???;
            val_26 = ???;
            val_21 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetFirstUpcomingSeasonalUpdateTime()
        {
            bool val_6;
            long val_1 = TheGame.ServerTime.GetCurrentTime();
            System.DateTime val_2 = val_1.UnixTimeInSecondsToUtcDateTime(unixTimeStamp:  val_1);
            this._lastCheckedTime = val_2;
            this._allDateTimes.Add(item:  new System.DateTime() {dateData = val_2.dateData});
            this._allDateTimes.Sort();
            System.Collections.Generic.List<System.DateTime> val_6 = this._allDateTimes;
            val_6 = (val_6.IndexOf(item:  new System.DateTime() {dateData = this._lastCheckedTime})) + 1;
            if(val_6 < this._allDateTimes.Count)
            {
                    System.DateTime val_5 = this._allDateTimes.Item[val_6];
                val_6 = 1;
                this.upcomingUpdateTime = val_5;
            }
            else
            {
                    val_6 = false;
            }
            
            this.upcomingUpdateExist = val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.DateTime UnixTimeInSecondsToUtcDateTime(long unixTimeStamp)
        {
            System.DateTime val_1 = 0.AddSeconds(value:  (double)unixTimeStamp);
            System.DateTime val_2 = val_1.dateData.ToUniversalTime();
            return (System.DateTime)val_2.dateData;
        }
    
    }

}
