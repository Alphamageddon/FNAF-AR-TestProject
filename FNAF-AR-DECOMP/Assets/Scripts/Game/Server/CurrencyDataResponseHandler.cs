using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CurrencyDataResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.Dictionary<string, int>> GotCurrencyData;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<System.Collections.Generic.Dictionary<string, int>> callback)
        {
            this.GotCurrencyData = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "Currency");
            if(val_1 == null)
            {
                    return;
            }
            
            this.HandleResponse(currency:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleResponse(Systems.Server.ServerData currency)
        {
            Systems.Server.ServerData val_8 = currency;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            if((val_8.ContainsKey(key:  "FAZ_TOKENS")) != false)
            {
                    System.Nullable<System.Int32> val_3 = val_8.GetInt(key:  "FAZ_TOKENS");
                val_1.Add(key:  "FAZ_TOKENS", value:  -906725768);
            }
            
            if((val_8.ContainsKey(key:  "PARTS")) != false)
            {
                    System.Nullable<System.Int32> val_5 = val_8.GetInt(key:  "PARTS");
                val_1.Add(key:  "PARTS", value:  -906725768);
            }
            
            if((val_8.ContainsKey(key:  "ESSENCE")) != false)
            {
                    System.Nullable<System.Int32> val_7 = val_8.GetInt(key:  "ESSENCE");
                val_8;
                val_1.Add(key:  "ESSENCE", value:  -906725768);
            }
            
            this.GotCurrencyData.Invoke(obj:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CurrencyDataResponseHandler()
        {
        
        }
    
    }

}
