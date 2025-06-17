using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WorkshopDataResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<AnimatronicEntity.Data.WorkshopData> WorkshopDataUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Func<Systems.Server.ServerData, AnimatronicEntity.Data.WorkshopEntry> ProcessWorkshopDataEntry;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<AnimatronicEntity.Data.WorkshopData> callback, System.Func<Systems.Server.ServerData, AnimatronicEntity.Data.WorkshopEntry> processor)
        {
            this.WorkshopDataUpdated = callback;
            this.ProcessWorkshopDataEntry = processor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "WarehouseData");
            if(val_1 == null)
            {
                    return;
            }
            
            this.HandleResponse(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleResponse(Systems.Server.ServerData data)
        {
            var val_14;
            var val_15;
            AnimatronicEntity.Data.WorkshopData val_1 = new AnimatronicEntity.Data.WorkshopData();
            var val_14 = 0;
            val_14 = val_14 + 1;
            var val_15 = 0;
            val_15 = val_15 + 1;
            System.Collections.Generic.IEnumerator<T> val_6 = data.BaseData.Keys.GetEnumerator();
            label_26:
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_1.Add(entry:  this.ProcessWorkshopDataEntry.Invoke(arg:  data.GetServerData(key:  val_6.Current)));
            goto label_26;
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
            
            this.WorkshopDataUpdated.Invoke(obj:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WorkshopDataResponseHandler()
        {
        
        }
    
    }

}
