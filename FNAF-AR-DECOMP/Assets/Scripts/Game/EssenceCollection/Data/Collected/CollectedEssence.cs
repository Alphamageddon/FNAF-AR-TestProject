using UnityEngine;

namespace Game.EssenceCollection.Data.Collected
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CollectedEssence
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _amount;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Amount { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Amount()
        {
            return (int)this._amount;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddEssence(int newEssence)
        {
            int val_1 = this._amount;
            val_1 = val_1 + newEssence;
            this._amount = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void RemoveEssence(int removedEssence)
        {
            int val_1 = this._amount;
            val_1 = val_1 - removedEssence;
            val_1 = val_1 & (~(val_1 >> 31));
            this._amount = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CollectedEssence()
        {
        
        }
    
    }

}
