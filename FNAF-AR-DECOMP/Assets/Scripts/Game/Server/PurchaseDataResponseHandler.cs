using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PurchaseDataResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.Dictionary<string, int>> PurchaseDataReceived;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<System.Collections.Generic.Dictionary<string, int>> callback)
        {
            this.PurchaseDataReceived = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "PlayerPurchaseData");
            if(val_1 == null)
            {
                    return;
            }
            
            this.ProcessPurchaseData(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessPurchaseData(Systems.Server.ServerData data)
        {
            var val_13;
            var val_14;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
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
            val_1.Add(key:  val_10, value:  -893481624);
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
            
            if(this.PurchaseDataReceived == null)
            {
                    return;
            }
            
            this.PurchaseDataReceived.Invoke(obj:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PurchaseDataResponseHandler()
        {
        
        }
    
    }

}
