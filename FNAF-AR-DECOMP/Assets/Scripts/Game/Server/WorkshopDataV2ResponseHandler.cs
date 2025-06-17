using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WorkshopDataV2ResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<AnimatronicEntity.Data.WorkshopData> WorkshopDataV2Updated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Func<Systems.Server.ServerData, AnimatronicEntity.Data.WorkshopEntry> ProcessWorkshopDataEntry;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<AnimatronicEntity.Data.WorkshopData> callback, System.Func<Systems.Server.ServerData, AnimatronicEntity.Data.WorkshopEntry> processor)
        {
            this.WorkshopDataV2Updated = callback;
            this.ProcessWorkshopDataEntry = processor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            System.Collections.Generic.List<Systems.Server.ServerData> val_1 = data.GetServerDataList(key:  "WarehouseDataV2");
            if(val_1 == null)
            {
                    return;
            }
            
            this.HandleResponse(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleResponse(System.Collections.Generic.List<Systems.Server.ServerData> data)
        {
            AnimatronicEntity.Data.WorkshopData val_1 = new AnimatronicEntity.Data.WorkshopData();
            int val_2 = data.Count;
            if(val_2 >= 1)
            {
                    var val_5 = 0;
                do
            {
                val_1.Add(entry:  this.ProcessWorkshopDataEntry.Invoke(arg:  data.Item[0]));
                val_5 = val_5 + 1;
            }
            while(val_2 != val_5);
            
            }
            
            this.WorkshopDataV2Updated.Invoke(obj:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WorkshopDataV2ResponseHandler()
        {
        
        }
    
    }

}
