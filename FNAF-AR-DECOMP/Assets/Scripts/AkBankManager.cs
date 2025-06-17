using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public static class AkBankManager
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly System.Collections.Generic.Dictionary<string, AkBankManager.BankHandle> m_BankHandles;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly System.Collections.Generic.List<AkBankManager.BankHandle> BanksToUnload;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly System.Threading.Mutex m_Mutex;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static void DoUnloadBanks()
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        val_3 = null;
        val_3 = null;
        int val_1 = AkBankManager.BanksToUnload.Count;
        val_4 = null;
        val_5 = (uint)(((uint)((AkBankManager.__il2cppRuntimeField_127>>1) & 0x1)) >> 1) & 1;
        if(val_1 >= 1)
        {
                var val_3 = 0;
            do
        {
            val_6 = null;
            BankHandle val_2 = AkBankManager.BanksToUnload.Item[0];
            val_7 = null;
            val_3 = val_3 + 1;
            val_5 = (uint)(((uint)((AkBankManager.__il2cppRuntimeField_127>>1) & 0x1)) >> 1) & 1;
        }
        while(val_1 != val_3);
        
        }
        
        val_7 = null;
        AkBankManager.BanksToUnload.Clear();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static void Reset()
    {
        null = null;
        AkBankManager.m_BankHandles.Clear();
        AkBankManager.BanksToUnload.Clear();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void LoadInitBank(bool doReset = True)
    {
        bool val_4 = doReset;
        if(val_4 != false)
        {
                AkBankManager.Reset();
        }
        
        AKRESULT val_2 = AkSoundEngine.LoadBank(in_pszString:  "Init.bnk", in_memPoolId:  0, out_bankID: out  0);
        if(val_2 == 1)
        {
                return;
        }
        
        val_4 = "WwiseUnity: Failed load Init.bnk with result: "("WwiseUnity: Failed load Init.bnk with result: ") + val_2;
        UnityEngine.Debug.LogError(message:  val_4);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void UnloadInitBank()
    {
        AKRESULT val_1 = AkSoundEngine.UnloadBank(in_pszString:  "Init.bnk", in_pInMemoryBankPtr:  0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void LoadBank(string name, bool decodeBank, bool saveDecodedBank)
    {
        AkBankManager.BankHandle val_7;
        var val_8;
        var val_9;
        System.Threading.Mutex val_10;
        var val_11;
        val_7 = decodeBank;
        val_8 = null;
        val_8 = null;
        bool val_1 = AkBankManager.m_Mutex.WaitOne();
        if((AkBankManager.m_BankHandles.TryGetValue(key:  name, value: out  0)) != false)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            mem[28] = val_7;
            val_9 = null;
            val_9 = null;
            val_10 = AkBankManager.m_Mutex;
            val_10.ReleaseMutex();
            return;
        }
        
        if(val_7 != false)
        {
                AkBankManager.DecodableBankHandle val_5 = null;
            val_7 = val_5;
            val_5 = new AkBankManager.DecodableBankHandle(name:  name, save:  saveDecodedBank);
        }
        else
        {
                AkBankManager.BankHandle val_6 = null;
            val_7 = val_6;
            val_6 = new AkBankManager.BankHandle();
            .bankName = name;
        }
        
        val_11 = null;
        val_11 = null;
        val_7 = val_7;
        AkBankManager.m_BankHandles.Add(key:  name, value:  val_6);
        AkBankManager.m_Mutex.ReleaseMutex();
        val_10 = val_7;
        val_6.LoadBank();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void LoadBankAsync(string name, AkCallbackManager.BankCallback callback)
    {
        var val_5;
        System.Collections.Generic.Dictionary<System.String, BankHandle> val_6;
        var val_7;
        System.Threading.Mutex val_8;
        var val_9;
        val_5 = null;
        val_5 = null;
        bool val_1 = AkBankManager.m_Mutex.WaitOne();
        val_6 = AkBankManager.m_BankHandles;
        if((val_6.TryGetValue(key:  name, value: out  0)) != false)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            mem[28] = val_5;
            val_7 = null;
            val_7 = null;
            val_8 = AkBankManager.m_Mutex;
            val_8.ReleaseMutex();
            return;
        }
        
        AkBankManager.AsyncBankHandle val_4 = null;
        val_6 = val_4;
        val_4 = new AkBankManager.AsyncBankHandle();
        mem[1152921519387175168] = name;
        .bankCallback = callback;
        val_9 = null;
        val_9 = null;
        AkBankManager.m_BankHandles.Add(key:  name, value:  val_4);
        val_8 = AkBankManager.m_Mutex;
        val_8.ReleaseMutex();
        val_4.LoadBank();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void UnloadBank(string name)
    {
        var val_5;
        var val_6;
        var val_7;
        val_5 = null;
        val_5 = null;
        bool val_1 = AkBankManager.m_Mutex.WaitOne();
        if((AkBankManager.m_BankHandles.TryGetValue(key:  name, value: out  0)) != false)
        {
                val_2.DecRef();
            if(0 == 0)
        {
                val_6 = null;
            val_6 = null;
            bool val_4 = AkBankManager.m_BankHandles.Remove(key:  name);
        }
        
        }
        
        val_7 = null;
        val_7 = null;
        AkBankManager.m_Mutex.ReleaseMutex();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkBankManager()
    {
        AkBankManager.m_BankHandles = new System.Collections.Generic.Dictionary<System.String, BankHandle>();
        AkBankManager.BanksToUnload = new System.Collections.Generic.List<BankHandle>();
        AkBankManager.m_Mutex = new System.Threading.Mutex();
    }

}
