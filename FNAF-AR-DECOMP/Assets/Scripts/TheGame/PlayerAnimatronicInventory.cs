using UnityEngine;

namespace TheGame
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayerAnimatronicInventory
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, int> inventory;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayerAnimatronicInventory()
        {
            this.inventory = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddItem(string name, int amount)
        {
            bool val_1 = this.inventory.ContainsKey(key:  name);
            if(this.inventory == null)
            {
                goto label_2;
            }
            
            if(val_1 == false)
            {
                goto label_3;
            }
            
            label_5:
            this.inventory.set_Item(key:  name, value:  this.inventory.Item[name] + amount);
            return;
            label_2:
            if(val_1 == true)
            {
                goto label_5;
            }
            
            label_3:
            this.inventory.Add(key:  name, value:  amount);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, int> GetInventory()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.Int32>)this.inventory;
        }
    
    }

}
