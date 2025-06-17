using UnityEngine;

namespace Systems.GetSocialInviteHandling
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FazPassData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly bool <IsFazPassInEffect>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <NumInvites>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsFazPassInEffect { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NumInvites { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsFazPassInEffect()
        {
            return (bool)this.<IsFazPassInEffect>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_NumInvites()
        {
            return (int)this.<NumInvites>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_NumInvites(int value)
        {
            this.<NumInvites>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FazPassData(bool isFazPassInEffect, int numInvites)
        {
            this.<IsFazPassInEffect>k__BackingField = isFazPassInEffect;
            this.<NumInvites>k__BackingField = numInvites;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void decrementInvites()
        {
            int val_1 = this.<NumInvites>k__BackingField;
            val_1 = val_1 - 1;
            this.<NumInvites>k__BackingField = val_1;
        }
    
    }

}
