using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PurchasedSlotsResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<int> PurchasedSlotsUpdated;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<int> callback)
        {
            this.PurchasedSlotsUpdated = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            System.Nullable<System.Int32> val_1 = data.GetInt(key:  "PurchasedEndoskeletonSlots");
            if(((-893104392) & 1) == 0)
            {
                    return;
            }
            
            this.HandleResponse(purchasedSlots:  -893104392);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleResponse(int purchasedSlots)
        {
            if(this.PurchasedSlotsUpdated == null)
            {
                    return;
            }
            
            this.PurchasedSlotsUpdated.Invoke(obj:  purchasedSlots);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PurchasedSlotsResponseHandler()
        {
        
        }
    
    }

}
