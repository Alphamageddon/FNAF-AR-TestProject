using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private class AkBankManager.AsyncBankHandle : AkBankManager.BankHandle
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly AkCallbackManager.BankCallback bankCallback;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkBankManager.AsyncBankHandle(string name, AkCallbackManager.BankCallback callback)
    {
        val_1 = new System.Object();
        mem[1152921519388604224] = name;
        this.bankCallback = callback;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void GlobalBankCallback(uint in_bankID, IntPtr in_pInMemoryBankPtr, AKRESULT in_eLoadResult, uint in_memPoolId, object in_Cookie)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = in_Cookie;
        val_6 = null;
        val_6 = null;
        bool val_1 = AkBankManager.m_Mutex.WaitOne();
        val_5 = 0;
        if(in_eLoadResult != 1)
        {
                val_5.LogLoadResult(result:  in_eLoadResult);
            val_7 = null;
            val_7 = null;
            bool val_4 = AkBankManager.m_BankHandles.Remove(key:  11993091);
        }
        
        val_8 = null;
        val_8 = null;
        AkBankManager.m_Mutex.ReleaseMutex();
        if(64 == 0)
        {
                return;
        }
        
        64.Invoke(in_bankID:  in_bankID, in_InMemoryBankPtr:  in_pInMemoryBankPtr, in_eLoadResult:  in_eLoadResult, in_memPoolId:  in_memPoolId, in_Cookie:  0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override AKRESULT DoLoadBank()
    {
        mem[1152921519388889936] = 0;
        mem[1152921519388889944] = static System.Void AkBankManager.AsyncBankHandle::GlobalBankCallback(uint in_bankID, IntPtr in_pInMemoryBankPtr, AKRESULT in_eLoadResult, uint in_memPoolId, object in_Cookie);
        mem[1152921519388889920] = static System.Void AkBankManager.AsyncBankHandle::GlobalBankCallback(uint in_bankID, IntPtr in_pInMemoryBankPtr, AKRESULT in_eLoadResult, uint in_memPoolId, object in_Cookie);
        return AkSoundEngine.LoadBank(in_pszString:  69738496, in_pfnBankCallback:  new AkCallbackManager.BankCallback(), in_pCookie:  this, in_memPoolId:  0, out_bankID: out  1152921519388857928);
    }

}
