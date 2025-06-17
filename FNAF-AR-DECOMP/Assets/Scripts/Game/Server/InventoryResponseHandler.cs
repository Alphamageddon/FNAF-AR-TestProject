using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class InventoryResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<TheGame.PlayerInventory> InventoryUpdated;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<TheGame.PlayerInventory> callback)
        {
            this.InventoryUpdated = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "Inventory");
            if(val_1 == null)
            {
                    return;
            }
            
            this.InventoryUpdated.Invoke(obj:  Game.Server.InventoryResponseHandler.ConstructPlayerInventory(data:  val_1));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static TheGame.PlayerInventory ConstructPlayerInventory(Systems.Server.ServerData data)
        {
            var val_14;
            var val_15;
            TheGame.PlayerInventory val_1 = new TheGame.PlayerInventory();
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
            val_1.SetItem(name:  val_10, item:  Game.Server.InventoryResponseHandler.ConstructAnimatronicInventory(data:  data.GetServerData(key:  val_10)));
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
            
            if( == 73)
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
        private static TheGame.PlayerAnimatronicInventory ConstructAnimatronicInventory(Systems.Server.ServerData data)
        {
            var val_13;
            var val_14;
            TheGame.PlayerAnimatronicInventory val_1 = new TheGame.PlayerAnimatronicInventory();
            var val_13 = 0;
            val_13 = val_13 + 1;
            var val_14 = 0;
            val_14 = val_14 + 1;
            System.Collections.Generic.IEnumerator<T> val_6 = data.BaseData.Keys.GetEnumerator();
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
            System.Nullable<System.Int32> val_11 = data.GetInt(key:  val_10);
            val_1.AddItem(name:  val_10, amount:  -899088488);
            goto label_25;
            label_17:
            val_13 = 0;
            val_14 = 74;
            if(val_6 == null)
            {
                
            }
            else
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
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
        public InventoryResponseHandler()
        {
        
        }
    
    }

}
