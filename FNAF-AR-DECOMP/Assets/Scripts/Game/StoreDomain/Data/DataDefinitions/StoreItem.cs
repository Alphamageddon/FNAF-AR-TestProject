using UnityEngine;

namespace Game.StoreDomain.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StoreItem
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Id;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Quantity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Type;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StoreItem(string id, string type, int quantity)
        {
            val_1 = new System.Object();
            this.Id = id;
            this.Type = val_1;
            this.Quantity = quantity;
        }
    
    }

}
