using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnimatronicStatsResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.Dictionary<string, Animatronics.AnimatronicStats.StatsData>> PlayerAnimatronicStatsDataLoaded;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<System.Collections.Generic.Dictionary<string, Animatronics.AnimatronicStats.StatsData>> callback)
        {
            this.PlayerAnimatronicStatsDataLoaded = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "AnimatronicStats");
            if(val_1 == null)
            {
                    return;
            }
            
            this.HandleResponse(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleResponse(Systems.Server.ServerData data)
        {
            this.PlayerAnimatronicStatsDataLoaded.Invoke(obj:  this.ConstructStats(data:  data));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, Animatronics.AnimatronicStats.StatsData> ConstructStats(Systems.Server.ServerData data)
        {
            var val_14;
            var val_15;
            System.Collections.Generic.Dictionary<System.String, Animatronics.AnimatronicStats.StatsData> val_1 = new System.Collections.Generic.Dictionary<System.String, Animatronics.AnimatronicStats.StatsData>();
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
            T val_10 = val_6.Current;
            Systems.Server.ServerData val_11 = data.GetServerData(key:  val_10);
            val_1.Add(key:  val_10, value:  val_11.GenerateStatsData(data:  val_11));
            goto label_25;
            label_17:
            val_14 = 0;
            val_15 = 74;
            if(val_6 == null)
            {
                
            }
            else
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_6.Dispose();
            }
            
            if( == 74)
            {
                    return val_1;
            }
            
            if( == false)
            {
                    return val_1;
            }
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.AnimatronicStats.StatsData GenerateStatsData(Systems.Server.ServerData data)
        {
            System.Nullable<System.Int32> val_2 = data.GetInt(key:  "version");
            .version = ;
            System.Nullable<System.Int32> val_3 = data.GetInt(key:  "numberOfOrders");
            .numberOfOrders = val_3.HasValue;
            return (Animatronics.AnimatronicStats.StatsData)new Animatronics.AnimatronicStats.StatsData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicStatsResponseHandler()
        {
        
        }
    
    }

}
