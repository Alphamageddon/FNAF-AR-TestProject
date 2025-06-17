using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class AkCallbackManager.BankCallback : MulticastDelegate
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCallbackManager.BankCallback(object object, IntPtr method)
    {
        mem[1152921519393337744] = object;
        mem[1152921519393337752] = method;
        mem[1152921519393337728] = method;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void Invoke(uint in_bankID, IntPtr in_InMemoryBankPtr, AKRESULT in_eLoadResult, uint in_memPoolId, object in_Cookie)
    {
        AkCallbackManager.BankCallback val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        val_10 = this;
        if(X28 == 0)
        {
            goto label_0;
        }
        
        if((X28 + 24) == 0)
        {
                return;
        }
        
        goto label_42;
        label_0:
        if((X26 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X26 + 72) == 1)
        {
            goto label_43;
        }
        
        if(X25 != 0)
        {
                if(((X25 + 265) & 1) != 0)
        {
            goto label_43;
        }
        
        }
        
        if((X25 + 265) == 0)
        {
            goto label_43;
        }
        
        if(X25 == 0)
        {
            goto label_9;
        }
        
        if(((X25 + 265) & 1) != 0)
        {
                return;
        }
        
        GameUI.ServerGameUIDataModel val_1 = X26.serverGameUIDataModel;
        if((X26 & 1) == 0)
        {
            goto label_11;
        }
        
        if((val_1 & 1) == 0)
        {
            goto label_12;
        }
        
        var val_22 = X25;
        if((X25 + 286) == 0)
        {
            goto label_16;
        }
        
        var val_7 = X25 + 176;
        var val_8 = 0;
        val_7 = val_7 + 8;
        label_15:
        if(((X25 + 176 + 8) + -8) == (X26 + 24))
        {
            goto label_14;
        }
        
        val_8 = val_8 + 1;
        val_7 = val_7 + 16;
        if(val_8 < (X25 + 286))
        {
            goto label_15;
        }
        
        goto label_16;
        label_34:
        val_13 = mem[X26 + 72];
        val_13 = X26 + 72;
        if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X25, typeof(X26 + 24), slot: 0)) & 1) == 0)
        {
            goto label_17;
        }
        
        if((X25 + 286) == 0)
        {
            goto label_41;
        }
        
        var val_9 = X25 + 176;
        var val_10 = 0;
        val_9 = val_9 + 8;
        label_20:
        if(((X25 + 176 + 8) + -8) == X26.serverGameUIDataModel)
        {
            goto label_19;
        }
        
        val_10 = val_10 + 1;
        val_9 = val_9 + 16;
        if(val_10 < (X25 + 286))
        {
            goto label_20;
        }
        
        goto label_41;
        label_35:
        var val_11 = X25;
        val_11 = val_11 + ((X26 + 72) << 4);
        val_15 = mem[(X25 + (X26 + 72) << 4) + 304];
        val_15 = (X25 + (X26 + 72) << 4) + 304;
        goto label_41;
        label_17:
        var val_12 = X25;
        val_12 = val_12 + val_13;
        goto label_41;
        label_37:
        var val_13 = val_7;
        val_13 = val_13 + in_InMemoryBankPtr;
        val_12 = val_12 + val_13;
        IntPtr val_3 = val_12 + 296;
        label_39:
        val_15 = mem[(((X25 + X26 + 72) + (((X25 + 176 + 8) + 16) + in_InMemoryBankPtr)) + 296) + 8];
        val_15 = (((X25 + X26 + 72) + (((X25 + 176 + 8) + 16) + in_InMemoryBankPtr)) + 296) + 8;
        goto label_41;
        label_19:
        var val_14 = val_9;
        val_14 = val_14 + val_13;
        val_14 = X25 + val_14;
        val_14 = val_14 + 296;
        goto label_41;
        label_42:
        var val_4 = X28 + 0;
        val_11 = mem[(X28 + 0) + 32 + 32];
        val_11 = (X28 + 0) + 32 + 32;
        val_13 = mem[(X28 + 0) + 32 + 16];
        val_13 = (X28 + 0) + 32 + 16;
        if((((X28 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_27;
        }
        
        if(((X28 + 0) + 32 + 32 + 8 + 72) == 1)
        {
            goto label_40;
        }
        
        if(val_11 != 0)
        {
                if((((X28 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_40;
        }
        
        }
        
        if(mem[1152921519393478408] == 0)
        {
            goto label_40;
        }
        
        if((val_11 == 0) || ((((X28 + 0) + 32 + 32 + 265) & 1) != 0))
        {
            goto label_41;
        }
        
        if((((X28 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_34;
        }
        
        if((((X28 + 0) + 32 + 32 + 8.serverGameUIDataModel) & 1) == 0)
        {
            goto label_35;
        }
        
        if(((X28 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_39;
        }
        
        var val_15 = (X28 + 0) + 32 + 32 + 176;
        var val_16 = 0;
        val_15 = val_15 + 8;
        label_38:
        if((((X28 + 0) + 32 + 32 + 176 + 8) + -8) == ((X28 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_37;
        }
        
        val_16 = val_16 + 1;
        val_15 = val_15 + 16;
        if(val_16 < ((X28 + 0) + 32 + 32 + 286))
        {
            goto label_38;
        }
        
        goto label_39;
        label_27:
        if(((X28 + 0) + 32 + 32 + 8 + 74) != 5)
        {
            goto label_40;
        }
        
        goto label_41;
        label_40:
        label_41:
        val_10 = 0 + 1;
        if(val_10 != (X28 + 24))
        {
            goto label_42;
        }
        
        return;
        label_4:
        if((X26 + 74) != 5)
        {
            goto label_43;
        }
        
        label_9:
        label_43:
        label_52:
        label_11:
        if((val_1 & 1) == 0)
        {
            goto label_44;
        }
        
        if((X25 + 286) == 0)
        {
            goto label_52;
        }
        
        var val_17 = X25 + 176;
        var val_18 = 0;
        val_17 = val_17 + 8;
        label_47:
        if(((X25 + 176 + 8) + -8) == X26.serverGameUIDataModel)
        {
            goto label_46;
        }
        
        val_18 = val_18 + 1;
        val_17 = val_17 + 16;
        if(val_18 < (X25 + 286))
        {
            goto label_47;
        }
        
        goto label_52;
        label_12:
        var val_19 = X25;
        val_19 = val_19 + ((X26 + 72) << 4);
        val_17 = mem[(X25 + (X26 + 72) << 4) + 304];
        val_17 = (X25 + (X26 + 72) << 4) + 304;
        goto label_52;
        label_44:
        var val_20 = X25;
        val_20 = val_20 + (X26 + 72);
        goto label_52;
        label_14:
        var val_21 = val_7;
        val_21 = val_21 + (X26 + 72);
        val_22 = val_22 + val_21;
        val_12 = val_22 + 296;
        label_16:
        val_17 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X25, typeof(X26 + 24), slot: 0) + 8];
        val_17 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X25, typeof(X26 + 24), slot: 0) + 8;
        goto label_52;
        label_46:
        var val_23 = val_17;
        val_23 = val_23 + (X26 + 72);
        val_23 = X25 + val_23;
        val_16 = val_23 + 296;
        goto label_52;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual System.IAsyncResult BeginInvoke(uint in_bankID, IntPtr in_InMemoryBankPtr, AKRESULT in_eLoadResult, uint in_memPoolId, object in_Cookie, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
