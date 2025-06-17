using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CPUInventoryResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.TheGame.Data.CPUInventory> CPUInventoryUpdated;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<Game.TheGame.Data.CPUInventory> callback)
        {
            this.CPUInventoryUpdated = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "CPUInventory");
            if(val_1 == null)
            {
                    return;
            }
            
            this.HandleResponse(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleResponse(Systems.Server.ServerData data)
        {
            var val_13;
            var val_14;
            Game.TheGame.Data.CPUInventory val_1 = new Game.TheGame.Data.CPUInventory();
            var val_13 = 0;
            val_13 = val_13 + 1;
            var val_14 = 0;
            val_14 = val_14 + 1;
            System.Collections.Generic.IEnumerator<T> val_6 = data.BaseData.Keys.GetEnumerator();
            label_26:
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
            if(((-907239432) & 1) == 0)
            {
                goto label_26;
            }
            
            val_1.Add(key:  val_10, amount:  -907239432);
            goto label_26;
            label_17:
            val_13 = 0;
            val_14 = 83;
            if(val_6 == null)
            {
                
            }
            else
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_6.Dispose();
            }
            
            this.CPUInventoryUpdated.Invoke(obj:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CPUInventoryResponseHandler()
        {
        
        }
    
    }

}
