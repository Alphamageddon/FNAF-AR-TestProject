using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EssenceNodeCustomReponse
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.List<Game.Server.EssenceNodeEntry>> callback;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EssenceNodeCustomReponse(System.Action<System.Collections.Generic.List<Game.Server.EssenceNodeEntry>> newCallback)
        {
            this.callback = newCallback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnResponse(Systems.Server.ServerResponse response)
        {
            this.TryHandleResponse(data:  response.ScriptData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryHandleResponse(Systems.Server.ServerData data)
        {
            System.Collections.Generic.List<Systems.Server.ServerData> val_1 = data.GetServerDataList(key:  "EssencesToSpawn");
            if(val_1 == null)
            {
                    return;
            }
            
            this.HandleResponse(dataToParse:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleResponse(System.Collections.Generic.List<Systems.Server.ServerData> dataToParse)
        {
            var val_11;
            System.Collections.Generic.List<Game.Server.EssenceNodeEntry> val_1 = new System.Collections.Generic.List<Game.Server.EssenceNodeEntry>();
            int val_2 = dataToParse.Count;
            if(val_2 >= 1)
            {
                    var val_11 = 0;
                do
            {
                Systems.Server.ServerData val_3 = dataToParse.Item[0];
                .id = val_3.GetString(key:  "id");
                if(val_3 != null)
            {
                    .type = val_3.GetString(key:  "type");
            }
            else
            {
                    .type = val_3.GetString(key:  "type");
            }
            
                .motes = val_3.GetStringList(key:  "motes");
                if(val_3 != null)
            {
                    val_11 = 0;
            }
            else
            {
                    val_11 = 1;
            }
            
                System.Nullable<System.Double> val_9 = val_3.GetDouble(key:  "spawnTime");
                .spawnTime = ;
                .category = val_3.GetString(key:  "category");
                val_1.Add(item:  new Game.Server.EssenceNodeEntry());
                val_11 = val_11 + 1;
            }
            while(val_2 != val_11);
            
            }
            
            mem[1152921525160446448].Invoke(obj:  val_1);
        }
    
    }

}
