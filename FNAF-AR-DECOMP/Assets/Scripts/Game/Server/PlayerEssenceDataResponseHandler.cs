using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayerEssenceDataResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.Server.PlayerEssenceData> PlayerEssenceDataUpdated;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<Game.Server.PlayerEssenceData> callback)
        {
            this.PlayerEssenceDataUpdated = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "PlayerEssenceData");
            if(val_1 == null)
            {
                    return;
            }
            
            this.HandleResponse(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleResponse(Systems.Server.ServerData data)
        {
            System.Nullable<System.Double> val_1 = data.GetDouble(key:  "LastGlobalTrigger");
            Systems.Server.ServerData val_2 = data.GetServerData(key:  "LastCategoryTriggers");
            Systems.Server.ServerData val_4 = data.GetServerData(key:  "Counts");
            Systems.Server.ServerData val_6 = data.GetServerData(key:  "Nodes");
            System.Nullable<System.Double> val_8 = data.GetDouble(key:  "LastThreatTrigger");
            if(this.PlayerEssenceDataUpdated == null)
            {
                    return;
            }
            
            this.PlayerEssenceDataUpdated.Invoke(obj:  new Game.Server.PlayerEssenceData() {lastGlobalTrigger = V0.16B, lastThreatTrigger = ???, lastCategoryTriggers = val_2.ParseCategoryCooldown(categoryCooldownData:  val_2), counts = val_4.ParseCounts(countData:  val_4), nodes = val_6.ParseNodes(nodeData:  val_6)});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, double> ParseCategoryCooldown(Systems.Server.ServerData categoryCooldownData)
        {
            var val_13;
            var val_14;
            System.Collections.Generic.Dictionary<System.String, System.Double> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Double>();
            var val_13 = 0;
            val_13 = val_13 + 1;
            var val_14 = 0;
            val_14 = val_14 + 1;
            System.Collections.Generic.IEnumerator<T> val_6 = categoryCooldownData.BaseData.Keys.GetEnumerator();
            label_25:
            var val_15 = 0;
            val_15 = val_15 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            T val_10 = val_6.Current;
            System.Nullable<System.Double> val_11 = categoryCooldownData.GetDouble(key:  val_10);
            val_1.Add(key:  val_10, value:  V0.16B);
            goto label_25;
            label_17:
            val_13 = 0;
            val_14 = 77;
            if(val_6 == null)
            {
                
            }
            else
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_6.Dispose();
            }
            
            if( == 77)
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
        private System.Collections.Generic.Dictionary<string, Game.Server.EssenceNodeEntry> ParseNodes(Systems.Server.ServerData nodeData)
        {
            var val_19;
            var val_20;
            System.Collections.Generic.Dictionary<System.String, Game.Server.EssenceNodeEntry> val_1 = new System.Collections.Generic.Dictionary<System.String, Game.Server.EssenceNodeEntry>();
            var val_19 = 0;
            val_19 = val_19 + 1;
            var val_20 = 0;
            val_20 = val_20 + 1;
            System.Collections.Generic.IEnumerator<T> val_6 = nodeData.BaseData.Keys.GetEnumerator();
            label_31:
            var val_21 = 0;
            val_21 = val_21 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            T val_10 = val_6.Current;
            Systems.Server.ServerData val_11 = nodeData.GetServerData(key:  val_10);
            new Game.Server.EssenceNodeEntry() = new System.Object();
            .id = val_11.GetString(key:  "id");
            .type = val_11.GetString(key:  "type");
            .motes = val_11.GetStringList(key:  "motes");
            .category = val_11.GetString(key:  "category");
            System.Nullable<System.Double> val_17 = val_11.GetDouble(key:  "spawnTime");
            .spawnTime = ;
            val_1.Add(key:  val_10, value:  new Game.Server.EssenceNodeEntry());
            goto label_31;
            label_17:
            val_19 = 0;
            val_20 = 173;
            if(val_6 == null)
            {
                
            }
            else
            {
                    var val_23 = 0;
                val_23 = val_23 + 1;
                val_6.Dispose();
            }
            
            if( == 173)
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
        private System.Collections.Generic.Dictionary<string, int> ParseCounts(Systems.Server.ServerData countData)
        {
            var val_13;
            var val_14;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            var val_13 = 0;
            val_13 = val_13 + 1;
            var val_14 = 0;
            val_14 = val_14 + 1;
            System.Collections.Generic.IEnumerator<T> val_6 = countData.BaseData.Keys.GetEnumerator();
            label_25:
            var val_15 = 0;
            val_15 = val_15 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            T val_10 = val_6.Current;
            System.Nullable<System.Int32> val_11 = countData.GetInt(key:  val_10);
            val_1.Add(key:  val_10, value:  -895513688);
            goto label_25;
            label_17:
            val_13 = 0;
            val_14 = 77;
            if(val_6 == null)
            {
                
            }
            else
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_6.Dispose();
            }
            
            if( == 77)
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
        public PlayerEssenceDataResponseHandler()
        {
        
        }
    
    }

}
