using UnityEngine;

namespace Game.TheGame.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CPUInventory
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, int> <entries>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, int> entries { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_entries(System.Collections.Generic.Dictionary<string, int> value)
        {
            this.<entries>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, int> get_entries()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.Int32>)this.<entries>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CPUInventory()
        {
            this.<entries>k__BackingField = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Add(string key, int amount)
        {
            this.<entries>k__BackingField.Add(key:  key, value:  amount);
        }
    
    }

}
