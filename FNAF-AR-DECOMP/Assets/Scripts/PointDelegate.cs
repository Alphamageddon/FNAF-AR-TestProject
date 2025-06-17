using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class PoissonDiskSampler.PointDelegate : MulticastDelegate
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PoissonDiskSampler.PointDelegate(object object, IntPtr method)
    {
        mem[1152921519514867104] = object;
        mem[1152921519514867112] = method;
        mem[1152921519514867088] = method;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual float Invoke(ref UnityEngine.Vector2 point)
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        if(X24 == 0)
        {
            goto label_0;
        }
        
        if((X24 + 24) == 0)
        {
            goto label_1;
        }
        
        var val_17 = 0;
        val_10 = 0f;
        goto label_42;
        label_0:
        if((X22 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X22 + 72) == 1)
        {
            goto label_44;
        }
        
        if(X21 != 0)
        {
                if(((X21 + 265) & 1) != 0)
        {
            goto label_44;
        }
        
        }
        
        if((X21 + 265) == 0)
        {
            goto label_44;
        }
        
        if(X21 == 0)
        {
            goto label_9;
        }
        
        val_10 = 0f;
        if(((X21 + 265) & 1) != 0)
        {
                return (float)val_10;
        }
        
        GameUI.ServerGameUIDataModel val_1 = X22.serverGameUIDataModel;
        if((X22 & 1) == 0)
        {
            goto label_11;
        }
        
        if((val_1 & 1) == 0)
        {
            goto label_12;
        }
        
        var val_23 = X21;
        if((X21 + 286) == 0)
        {
            goto label_16;
        }
        
        var val_7 = X21 + 176;
        var val_8 = 0;
        val_7 = val_7 + 8;
        label_15:
        if(((X21 + 176 + 8) + -8) == (X22 + 24))
        {
            goto label_14;
        }
        
        val_8 = val_8 + 1;
        val_7 = val_7 + 16;
        if(val_8 < (X21 + 286))
        {
            goto label_15;
        }
        
        goto label_16;
        label_34:
        val_13 = mem[X22 + 72];
        val_13 = X22 + 72;
        if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(X22 + 24), slot: 0)) & 1) == 0)
        {
            goto label_17;
        }
        
        if((X21 + 286) == 0)
        {
            goto label_41;
        }
        
        var val_9 = X21 + 176;
        var val_10 = 0;
        val_9 = val_9 + 8;
        label_20:
        if(((X21 + 176 + 8) + -8) == X22.serverGameUIDataModel)
        {
            goto label_19;
        }
        
        val_10 = val_10 + 1;
        val_9 = val_9 + 16;
        if(val_10 < (X21 + 286))
        {
            goto label_20;
        }
        
        goto label_41;
        label_35:
        var val_11 = X21;
        val_11 = val_11 + ((X22 + 72) << 4);
        val_15 = mem[(X21 + (X22 + 72) << 4) + 304];
        val_15 = (X21 + (X22 + 72) << 4) + 304;
        goto label_41;
        label_17:
        var val_12 = X21;
        val_12 = val_12 + val_13;
        goto label_41;
        label_37:
        var val_13 = val_7;
        val_13 = val_13 + ((X21 + X22 + 72) + 296 + 8);
        val_12 = val_12 + val_13;
        var val_3 = val_12 + 296;
        label_39:
        val_15 = mem[(((X21 + X22 + 72) + (((X21 + 176 + 8) + 16) + (X21 + X22 + 72) + 296 + 8)) + 296) + 8];
        val_15 = (((X21 + X22 + 72) + (((X21 + 176 + 8) + 16) + (X21 + X22 + 72) + 296 + 8)) + 296) + 8;
        goto label_41;
        label_19:
        var val_14 = val_9;
        val_14 = val_14 + val_13;
        val_14 = X21 + val_14;
        val_14 = val_14 + 296;
        goto label_41;
        label_42:
        var val_4 = X24 + 0;
        val_11 = mem[(X24 + 0) + 32 + 32];
        val_11 = (X24 + 0) + 32 + 32;
        val_13 = mem[(X24 + 0) + 32 + 16];
        val_13 = (X24 + 0) + 32 + 16;
        if((((X24 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_27;
        }
        
        if(((X24 + 0) + 32 + 32 + 8 + 72) == 1)
        {
            goto label_40;
        }
        
        if(val_11 != 0)
        {
                if((((X24 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_40;
        }
        
        }
        
        if(((X24 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_40;
        }
        
        if(val_11 == 0)
        {
            goto label_41;
        }
        
        if((((X24 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_33;
        }
        
        if((((X24 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_34;
        }
        
        if((((X24 + 0) + 32 + 32 + 8.serverGameUIDataModel) & 1) == 0)
        {
            goto label_35;
        }
        
        if(((X24 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_39;
        }
        
        var val_15 = (X24 + 0) + 32 + 32 + 176;
        var val_16 = 0;
        val_15 = val_15 + 8;
        label_38:
        if((((X24 + 0) + 32 + 32 + 176 + 8) + -8) == ((X24 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_37;
        }
        
        val_16 = val_16 + 1;
        val_15 = val_15 + 16;
        if(val_16 < ((X24 + 0) + 32 + 32 + 286))
        {
            goto label_38;
        }
        
        goto label_39;
        label_27:
        if(((X24 + 0) + 32 + 32 + 8 + 74) != 1)
        {
            goto label_40;
        }
        
        goto label_41;
        label_40:
        label_41:
        val_10 = V0.16B;
        label_33:
        val_17 = val_17 + 1;
        if(val_17 != (X24 + 24))
        {
            goto label_42;
        }
        
        return (float)val_10;
        label_1:
        val_10 = 0f;
        return (float)val_10;
        label_4:
        if((X22 + 74) != 1)
        {
            goto label_44;
        }
        
        label_9:
        label_44:
        label_53:
        label_11:
        if((val_1 & 1) == 0)
        {
            goto label_45;
        }
        
        if((X21 + 286) == 0)
        {
            goto label_53;
        }
        
        var val_18 = X21 + 176;
        var val_19 = 0;
        val_18 = val_18 + 8;
        label_48:
        if(((X21 + 176 + 8) + -8) == X22.serverGameUIDataModel)
        {
            goto label_47;
        }
        
        val_19 = val_19 + 1;
        val_18 = val_18 + 16;
        if(val_19 < (X21 + 286))
        {
            goto label_48;
        }
        
        goto label_53;
        label_12:
        var val_20 = X21;
        val_20 = val_20 + ((X22 + 72) << 4);
        val_17 = mem[(X21 + (X22 + 72) << 4) + 304];
        val_17 = (X21 + (X22 + 72) << 4) + 304;
        goto label_53;
        label_45:
        var val_21 = X21;
        val_21 = val_21 + (X22 + 72);
        goto label_53;
        label_14:
        var val_22 = val_7;
        val_22 = val_22 + (X22 + 72);
        val_23 = val_23 + val_22;
        val_12 = val_23 + 296;
        label_16:
        val_17 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(X22 + 24), slot: 0) + 8];
        val_17 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(X22 + 24), slot: 0) + 8;
        goto label_53;
        label_47:
        var val_24 = val_18;
        val_24 = val_24 + (X22 + 72);
        val_24 = X21 + val_24;
        val_16 = val_24 + 296;
        goto label_53;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual System.IAsyncResult BeginInvoke(ref UnityEngine.Vector2 point, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual float EndInvoke(ref UnityEngine.Vector2 point, System.IAsyncResult result)
    {
        return (float)UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = result});
    }

}
