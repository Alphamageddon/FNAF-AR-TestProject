using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private class AkBankManager.BankHandle
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected readonly string bankName;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected uint m_BankID;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <RefCount>k__BackingField;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int RefCount { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkBankManager.BankHandle(string name)
    {
        this.bankName = name;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_RefCount()
    {
        return (int)this.<RefCount>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void set_RefCount(int value)
    {
        this.<RefCount>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual AKRESULT DoLoadBank()
    {
        return AkSoundEngine.LoadBank(in_pszString:  this.bankName, in_memPoolId:  0, out_bankID: out  this.m_BankID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void LoadBank()
    {
        var val_3;
        var val_4;
        if((this.<RefCount>k__BackingField) == 0)
        {
                val_3 = null;
            val_3 = null;
            if((AkBankManager.BanksToUnload.Contains(item:  this)) != false)
        {
                val_4 = null;
            val_4 = null;
            bool val_2 = AkBankManager.BanksToUnload.Remove(item:  this);
        }
        else
        {
                this.LogLoadResult(result:  this);
        }
        
        }
        
        int val_3 = this.<RefCount>k__BackingField;
        val_3 = val_3 + 1;
        this.<RefCount>k__BackingField = val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void UnloadBank()
    {
        AKRESULT val_1 = AkSoundEngine.UnloadBank(in_bankID:  this.m_BankID, in_pInMemoryBankPtr:  0, in_pfnBankCallback:  0, in_pCookie:  0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void IncRef()
    {
        int val_1 = this.<RefCount>k__BackingField;
        val_1 = val_1 + 1;
        this.<RefCount>k__BackingField = val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void DecRef()
    {
        var val_1;
        int val_1 = this.<RefCount>k__BackingField;
        val_1 = val_1 - 1;
        this.<RefCount>k__BackingField = val_1;
        if(val_1 != 0)
        {
                return;
        }
        
        val_1 = null;
        val_1 = null;
        AkBankManager.BanksToUnload.Add(item:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected void LogLoadResult(AKRESULT result)
    {
        object val_4;
        if(result == 1)
        {
                return;
        }
        
        if(AkSoundEngine.IsInitialized() == false)
        {
                return;
        }
        
        object[] val_2 = new object[5];
        val_2[0] = "WwiseUnity: Bank ";
        val_2[1] = this.bankName;
        this = " failed to load (";
        val_2[2] = this;
        val_2[3] = result;
        val_2[4] = ")";
        val_4 = +val_2;
        UnityEngine.Debug.LogWarning(message:  val_4);
    }

}
