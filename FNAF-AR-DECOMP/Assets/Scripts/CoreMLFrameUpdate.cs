using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class UnityCVManager.CoreMLFrameUpdate : MulticastDelegate
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityCVManager.CoreMLFrameUpdate(object object, IntPtr method)
    {
        mem[1152921519026641424] = object;
        mem[1152921519026641432] = method;
        mem[1152921519026641408] = method;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void Invoke(int index, string[] strings, float[] floats, int floatsW, int floatsH, double[] doubles, int doublesW, int doublesH)
    {
        UnityCVManager.CoreMLFrameUpdate val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_9 = this;
        if(X20 == 0)
        {
            goto label_0;
        }
        
        if((X20 + 24) == 0)
        {
                return;
        }
        
        var val_18 = 0;
        goto label_42;
        label_0:
        if((X27 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X27 + 72) == 1)
        {
            goto label_43;
        }
        
        if(X28 != 0)
        {
                if(((X28 + 265) & 1) != 0)
        {
            goto label_43;
        }
        
        }
        
        if((X28 + 265) == 0)
        {
            goto label_43;
        }
        
        if(X28 == 0)
        {
            goto label_9;
        }
        
        if(((X28 + 265) & 1) != 0)
        {
                return;
        }
        
        GameUI.ServerGameUIDataModel val_1 = X27.serverGameUIDataModel;
        if((X27 & 1) == 0)
        {
            goto label_11;
        }
        
        if((val_1 & 1) == 0)
        {
            goto label_12;
        }
        
        var val_24 = X28;
        if((X28 + 286) == 0)
        {
            goto label_16;
        }
        
        var val_6 = X28 + 176;
        var val_7 = 0;
        val_6 = val_6 + 8;
        label_15:
        if(((X28 + 176 + 8) + -8) == (X27 + 24))
        {
            goto label_14;
        }
        
        val_7 = val_7 + 1;
        val_6 = val_6 + 16;
        if(val_7 < (X28 + 286))
        {
            goto label_15;
        }
        
        goto label_16;
        label_34:
        val_9 = mem[X27 + 72];
        val_9 = X27 + 72;
        if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X28, typeof(X27 + 24), slot: 0)) & 1) == 0)
        {
            goto label_17;
        }
        
        if((X28 + 286) == 0)
        {
            goto label_41;
        }
        
        var val_8 = X28 + 176;
        var val_9 = 0;
        val_8 = val_8 + 8;
        label_20:
        if(((X28 + 176 + 8) + -8) == X27.serverGameUIDataModel)
        {
            goto label_19;
        }
        
        val_9 = val_9 + 1;
        val_8 = val_8 + 16;
        if(val_9 < (X28 + 286))
        {
            goto label_20;
        }
        
        goto label_41;
        label_35:
        var val_10 = X28;
        val_10 = val_10 + ((X27 + 72) << 4);
        val_13 = mem[(X28 + (X27 + 72) << 4) + 304];
        val_13 = (X28 + (X27 + 72) << 4) + 304;
        goto label_22;
        label_17:
        var val_11 = X28;
        val_11 = val_11 + val_9;
        var val_13 = (X28 + X27 + 72) + 296 + 8;
        goto label_41;
        label_37:
        var val_12 = val_6;
        val_12 = val_12 + strings;
        val_13 = val_13 + val_12;
        label_39:
        label_22:
        System.String[] val_14 = val_13[296];
        goto label_41;
        label_19:
        var val_15 = val_8;
        val_15 = val_15 + val_9;
        val_15 = X28 + val_15;
        val_12 = val_15 + 296;
        goto label_41;
        label_42:
        var val_3 = X20 + 0;
        val_10 = mem[(X20 + 0) + 32 + 32 + 8];
        val_10 = (X20 + 0) + 32 + 32 + 8;
        val_9 = mem[(X20 + 0) + 32 + 16];
        val_9 = (X20 + 0) + 32 + 16;
        if((val_10 & 1) == 0)
        {
            goto label_27;
        }
        
        if(((X20 + 0) + 32 + 32 + 8 + 72) == 1)
        {
            goto label_40;
        }
        
        if(((X20 + 0) + 32 + 32) != 0)
        {
                if((((X20 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_40;
        }
        
        }
        
        if(mem[1152921519026884488] == 0)
        {
            goto label_40;
        }
        
        if((((X20 + 0) + 32 + 32) == 0) || ((((X20 + 0) + 32 + 32 + 265) & 1) != 0))
        {
            goto label_41;
        }
        
        if((val_10 & 1) == 0)
        {
            goto label_34;
        }
        
        if((val_10.serverGameUIDataModel & 1) == 0)
        {
            goto label_35;
        }
        
        if(((X20 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_39;
        }
        
        var val_16 = (X20 + 0) + 32 + 32 + 176;
        var val_17 = 0;
        val_16 = val_16 + 8;
        label_38:
        if((((X20 + 0) + 32 + 32 + 176 + 8) + -8) == ((X20 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_37;
        }
        
        val_17 = val_17 + 1;
        val_16 = val_16 + 16;
        if(val_17 < ((X20 + 0) + 32 + 32 + 286))
        {
            goto label_38;
        }
        
        goto label_39;
        label_27:
        if(((X20 + 0) + 32 + 32 + 8 + 74) != 8)
        {
            goto label_40;
        }
        
        goto label_41;
        label_40:
        label_41:
        val_18 = val_18 + 1;
        if(val_18 != (X20 + 24))
        {
            goto label_42;
        }
        
        return;
        label_4:
        if((X27 + 74) != 8)
        {
            goto label_43;
        }
        
        label_9:
        label_43:
        label_51:
        label_11:
        if((val_1 & 1) == 0)
        {
            goto label_44;
        }
        
        val_14 = X27.serverGameUIDataModel;
        if((X28 + 286) == 0)
        {
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X28, typeof(val_5), slot: 0);
        }
        
        var val_19 = X28 + 176;
        var val_20 = 0;
        val_19 = val_19 + 8;
        label_47:
        if(((X28 + 176 + 8) + -8) == val_14)
        {
            goto label_46;
        }
        
        val_20 = val_20 + 1;
        val_19 = val_19 + 16;
        if(val_20 < (X28 + 286))
        {
            goto label_47;
        }
        
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X28, typeof(val_5), slot: 0);
        label_12:
        var val_21 = X28;
        val_21 = val_21 + ((X27 + 72) << 4);
        val_16 = mem[(X28 + (X27 + 72) << 4) + 304];
        val_16 = (X28 + (X27 + 72) << 4) + 304;
        goto label_51;
        label_44:
        var val_22 = X28;
        val_22 = val_22 + (X27 + 72);
        goto label_51;
        label_14:
        var val_23 = val_6;
        val_23 = val_23 + (X27 + 72);
        val_24 = val_24 + val_23;
        val_11 = val_24 + 296;
        label_16:
        val_16 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X28, typeof(X27 + 24), slot: 0) + 8];
        val_16 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X28, typeof(X27 + 24), slot: 0) + 8;
        goto label_51;
        label_46:
        var val_25 = val_19;
        val_25 = val_25 + (X27 + 72);
        val_14 = X28 + val_25;
        val_15 = val_14 + 296;
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X28, typeof(val_5), slot: 0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual System.IAsyncResult BeginInvoke(int index, string[] strings, float[] floats, int floatsW, int floatsH, double[] doubles, int doublesW, int doublesH, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
