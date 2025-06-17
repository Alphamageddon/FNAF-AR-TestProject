using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ModInventoryResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.Workshop.Data.ModInventory> ModInventoryUpdated;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<Game.Workshop.Data.ModInventory> callback)
        {
            this.ModInventoryUpdated = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "ModInventory");
            if(val_1 == null)
            {
                    return;
            }
            
            if(this.ModInventoryUpdated == null)
            {
                    return;
            }
            
            this.ModInventoryUpdated.Invoke(obj:  Game.Server.ModInventoryResponseHandler.ConstructModInventory(data:  val_1));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Game.Workshop.Data.ModInventory ConstructModInventory(Systems.Server.ServerData data)
        {
            var val_14;
            var val_15;
            Game.Workshop.Data.ModInventory val_1 = new Game.Workshop.Data.ModInventory();
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
            new Game.ItemDefinition.Data.DataDefinitions.ModData() = new Game.ItemDefinition.Data.DataDefinitions.ModData(id:  val_10);
            System.Nullable<System.Int32> val_12 = data.GetInt(key:  val_10);
            val_1.AddMod(key:  new Game.ItemDefinition.Data.DataDefinitions.ModData(), amount:  -898558312);
            goto label_25;
            label_17:
            val_14 = 0;
            val_15 = 82;
            if(val_6 == null)
            {
                
            }
            else
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_6.Dispose();
            }
            
            if( == 82)
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
        public ModInventoryResponseHandler()
        {
        
        }
    
    }

}
