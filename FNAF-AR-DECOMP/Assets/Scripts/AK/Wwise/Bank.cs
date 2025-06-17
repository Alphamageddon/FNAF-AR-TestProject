using UnityEngine;

namespace AK.Wwise
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class Bank : BaseType
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WwiseBankReference WwiseObjectReference;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override WwiseObjectReference ObjectReference { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override WwiseObjectType WwiseObjectType { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override WwiseObjectReference get_ObjectReference()
        {
            return (WwiseObjectReference)this.WwiseObjectReference;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void set_ObjectReference(WwiseObjectReference value)
        {
            var val_2 = 0;
            this.WwiseObjectReference = ;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override WwiseObjectType get_WwiseObjectType()
        {
            return 7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Load(bool decodeBank = False, bool saveDecodedBank = False)
        {
            if((this & 1) == 0)
            {
                    return;
            }
            
            saveDecodedBank = saveDecodedBank;
            AkBankManager.LoadBank(name:  this, decodeBank:  decodeBank, saveDecodedBank:  saveDecodedBank);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadAsync(AkCallbackManager.BankCallback callback)
        {
            if((this & 1) == 0)
            {
                    return;
            }
            
            AkBankManager.LoadBankAsync(name:  this, callback:  callback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Unload()
        {
            if((this & 1) == 0)
            {
                    return;
            }
            
            AkBankManager.UnloadBank(name:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Bank()
        {
            val_1 = new System.Object();
        }
    
    }

}
