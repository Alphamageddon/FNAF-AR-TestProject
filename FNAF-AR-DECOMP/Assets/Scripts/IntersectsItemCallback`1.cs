using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class SpacialDatabaseQuery.IntersectsItemCallback<T, TItem> : MulticastDelegate
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SpacialDatabaseQuery.IntersectsItemCallback<T, TItem>(object object, IntPtr method)
    {
        mem[1152921520161334320] = object;
        mem[1152921520161334328] = method;
        mem[1152921520161334304] = method;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual bool Invoke(ref UnityEngine.Bounds bounds, TItem item)
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        if(X25 == 0)
        {
            goto label_0;
        }
        
        if((X25 + 24) == 0)
        {
            goto label_1;
        }
        
        val_11 = 0;
        var val_18 = 0;
        goto label_42;
        label_0:
        if((X23 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X23 + 72) == 1)
        {
                return (bool)val_11 & 1;
        }
        
        if(X22 != 0)
        {
                if(((X22 + 265) & 1) != 0)
        {
                return (bool)val_11 & 1;
        }
        
        }
        
        if((X22 + 265) == 0)
        {
                return (bool)val_11 & 1;
        }
        
        if(X22 == 0)
        {
                return (bool)val_11 & 1;
        }
        
        if(((X22 + 265) & 1) != 0)
        {
                return (bool)val_11 & 1;
        }
        
        GameUI.ServerGameUIDataModel val_1 = X23.serverGameUIDataModel;
        if((X23 & 1) == 0)
        {
            goto label_11;
        }
        
        if((val_1 & 1) == 0)
        {
            goto label_12;
        }
        
        var val_24 = X22;
        if((X22 + 286) == 0)
        {
            goto label_16;
        }
        
        var val_8 = X22 + 176;
        var val_9 = 0;
        val_8 = val_8 + 8;
        label_15:
        if(((X22 + 176 + 8) + -8) == (X23 + 24))
        {
            goto label_14;
        }
        
        val_9 = val_9 + 1;
        val_8 = val_8 + 16;
        if(val_9 < (X22 + 286))
        {
            goto label_15;
        }
        
        goto label_16;
        label_34:
        if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X22, typeof(X23 + 24), slot: 0)) & 1) == 0)
        {
            goto label_17;
        }
        
        if((X22 + 286) == 0)
        {
            goto label_21;
        }
        
        var val_10 = X22 + 176;
        var val_11 = 0;
        val_10 = val_10 + 8;
        label_20:
        if(((X22 + 176 + 8) + -8) == X23.serverGameUIDataModel)
        {
            goto label_19;
        }
        
        val_11 = val_11 + 1;
        val_10 = val_10 + 16;
        if(val_11 < (X22 + 286))
        {
            goto label_20;
        }
        
        goto label_21;
        label_35:
        var val_12 = X22;
        val_12 = val_12 + ((X23 + 72) << 4);
        val_14 = mem[(X22 + (X23 + 72) << 4) + 304];
        val_14 = (X22 + (X23 + 72) << 4) + 304;
        goto label_22;
        label_17:
        var val_13 = X22;
        val_15 = X22;
        val_13 = val_13 + (X23 + 72);
        goto label_41;
        label_37:
        var val_14 = val_8;
        val_14 = val_14 + item;
        val_13 = val_13 + val_14;
        object val_3 = val_13 + 296;
        label_39:
        label_22:
        val_15 = X22;
        goto label_41;
        label_19:
        var val_15 = val_10;
        val_15 = val_15 + (X23 + 72);
        val_15 = X22 + val_15;
        val_13 = val_15 + 296;
        label_21:
        val_15 = X22;
        goto label_41;
        label_42:
        var val_4 = X25 + 0;
        if((((X25 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_27;
        }
        
        if(((X25 + 0) + 32 + 32 + 8 + 72) == 1)
        {
            goto label_40;
        }
        
        if(((X25 + 0) + 32 + 32) != 0)
        {
                if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_40;
        }
        
        }
        
        if(((X25 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_40;
        }
        
        if(((X25 + 0) + 32 + 32) == 0)
        {
            goto label_32;
        }
        
        if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_33;
        }
        
        if((((X25 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_34;
        }
        
        if((((X25 + 0) + 32 + 32 + 8.serverGameUIDataModel) & 1) == 0)
        {
            goto label_35;
        }
        
        if(((X25 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_39;
        }
        
        var val_16 = (X25 + 0) + 32 + 32 + 176;
        var val_17 = 0;
        val_16 = val_16 + 8;
        label_38:
        if((((X25 + 0) + 32 + 32 + 176 + 8) + -8) == ((X25 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_37;
        }
        
        val_17 = val_17 + 1;
        val_16 = val_16 + 16;
        if(val_17 < ((X25 + 0) + 32 + 32 + 286))
        {
            goto label_38;
        }
        
        goto label_39;
        label_27:
        if(((X25 + 0) + 32 + 32 + 8 + 74) != 2)
        {
            goto label_40;
        }
        
        label_32:
        val_15 = 1152921520161506944;
        goto label_41;
        label_40:
        val_15 = (X25 + 0) + 32 + 32;
        label_41:
        val_11 = val_15 & 1;
        label_33:
        val_18 = val_18 + 1;
        if(val_18 != (X25 + 24))
        {
            goto label_42;
        }
        
        return (bool)val_11 & 1;
        label_1:
        val_11 = 0;
        return (bool)val_11 & 1;
        label_4:
        if((X23 + 74) != 2)
        {
                return (bool)val_11 & 1;
        }
        
        return (bool)val_11 & 1;
        label_11:
        if((val_1 & 1) == 0)
        {
            goto label_46;
        }
        
        if((X22 + 286) == 0)
        {
                return (bool)val_11 & 1;
        }
        
        var val_19 = X22 + 176;
        var val_20 = 0;
        val_19 = val_19 + 8;
        label_49:
        if(((X22 + 176 + 8) + -8) == X23.serverGameUIDataModel)
        {
            goto label_48;
        }
        
        val_20 = val_20 + 1;
        val_19 = val_19 + 16;
        if(val_20 < (X22 + 286))
        {
            goto label_49;
        }
        
        return (bool)val_11 & 1;
        label_12:
        var val_21 = X22;
        val_21 = val_21 + ((X23 + 72) << 4);
        val_17 = mem[(X22 + (X23 + 72) << 4) + 304];
        val_17 = (X22 + (X23 + 72) << 4) + 304;
        return (bool)val_11 & 1;
        label_46:
        var val_22 = X22;
        val_22 = val_22 + (X23 + 72);
        return (bool)val_11 & 1;
        label_14:
        var val_23 = val_8;
        val_23 = val_23 + (X23 + 72);
        val_24 = val_24 + val_23;
        val_12 = val_24 + 296;
        label_16:
        val_17 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X22, typeof(X23 + 24), slot: 0) + 8];
        val_17 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X22, typeof(X23 + 24), slot: 0) + 8;
        return (bool)val_11 & 1;
        label_48:
        var val_25 = val_19;
        val_25 = val_25 + (X23 + 72);
        val_25 = X22 + val_25;
        val_16 = val_25 + 296;
        return (bool)val_11 & 1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual System.IAsyncResult BeginInvoke(ref UnityEngine.Bounds bounds, TItem item, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual bool EndInvoke(ref UnityEngine.Bounds bounds, System.IAsyncResult result)
    {
        return (bool)UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = result});
    }

}
