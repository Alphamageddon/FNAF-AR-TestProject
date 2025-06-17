using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SeasonalEventDataResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData>> SeasonalDataReceived;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData>> callback)
        {
            this.SeasonalDataReceived = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "PlayerSeasonalData");
            if(val_1 == null)
            {
                    return;
            }
            
            this.ProcessSeasonalEventData(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessSeasonalEventData(Systems.Server.ServerData data)
        {
            var val_14;
            var val_15;
            System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData> val_1 = new System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData>();
            var val_14 = 0;
            val_14 = val_14 + 1;
            var val_15 = 0;
            val_15 = val_15 + 1;
            System.Collections.Generic.IEnumerator<T> val_6 = data.BaseData.Keys.GetEnumerator();
            label_25:
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            Systems.Server.ServerData val_11 = data.GetServerData(key:  val_6.Current);
            val_1.Add(item:  val_11.ConvertSeasonalEventData(data:  val_11));
            goto label_25;
            label_17:
            val_14 = 0;
            val_15 = 73;
            if(val_6 == null)
            {
                
            }
            else
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_6.Dispose();
            }
            
            if(this.SeasonalDataReceived == null)
            {
                    return;
            }
            
            this.SeasonalDataReceived.Invoke(obj:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.SeasonalEvents.Data.SeasonalEventData ConvertSeasonalEventData(Systems.Server.ServerData data)
        {
            .EventID = data.GetString(key:  "eventId");
            if(data != null)
            {
                    .SequentialRewardId = data.GetString(key:  "sequentialRewardId");
            }
            else
            {
                    .SequentialRewardId = 0.GetString(key:  "sequentialRewardId");
            }
            
            System.Nullable<System.Int32> val_5 = data.GetInt(key:  "sequentialRewardIndex");
            .SequentialRewardsIndex = val_5.HasValue;
            System.Nullable<System.Double> val_6 = data.GetDouble(key:  "nextRewardTimestamp");
            .NextRewardTimestamp = ;
            return (Game.SeasonalEvents.Data.SeasonalEventData)new Game.SeasonalEvents.Data.SeasonalEventData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SeasonalEventDataResponseHandler()
        {
        
        }
    
    }

}
