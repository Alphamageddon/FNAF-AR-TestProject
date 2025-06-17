using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class Receipt
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string StoreID;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TransactionID;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Payload;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Receipt()
        {
        
        }
    
    }

}
