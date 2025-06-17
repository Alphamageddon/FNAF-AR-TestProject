using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class AmsCrossSceneReferenceResolver.ResolveCrossSceneReferenceDelegate : MulticastDelegate
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AmsCrossSceneReferenceResolver.ResolveCrossSceneReferenceDelegate(object object, IntPtr method)
    {
        mem[1152921520113228192] = object;
        mem[1152921520113228200] = method;
        mem[1152921520113228176] = method;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual bool Invoke(CodingJar.MultiScene.RuntimeCrossSceneReference xRef)
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        if(X24 == 0)
        {
            goto label_0;
        }
        
        if((X24 + 24) == 0)
        {
            goto label_1;
        }
        
        val_13 = 0;
        var val_18 = 0;
        goto label_30;
        label_21:
        if(((-1673298528) & 1) == 0)
        {
            goto label_4;
        }
        
        var val_15 = X21;
        if((X21 + 286) == 0)
        {
            goto label_5;
        }
        
        var val_9 = X21 + 176;
        var val_10 = 0;
        val_9 = val_9 + 8;
        label_7:
        if(((X21 + 176 + 8) + -8) == X22.serverGameUIDataModel)
        {
            goto label_6;
        }
        
        val_10 = val_10 + 1;
        val_9 = val_9 + 16;
        if(val_10 < (X21 + 286))
        {
            goto label_7;
        }
        
        label_5:
        val_15 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(val_1), slot: 0);
        goto label_8;
        label_22:
        var val_11 = X21;
        val_11 = val_11 + (((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(val_1), slot: 0) + 72) << 4);
        val_16 = (X21 + ((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(val_1), slot: 0) + 72) << 4) + 304;
        goto label_9;
        label_4:
        var val_13 = X21;
        var val_2 = val_13 + (X22 + 72);
        goto label_10;
        label_24:
        var val_12 = X11;
        val_12 = val_12 + ((X21 + X22 + 72) + 304);
        val_13 = val_13 + val_12;
        var val_3 = val_13 + 296;
        label_26:
        val_16 = ((X21 + (X11 + (X21 + X22 + 72) + 304)) + 296) + 8;
        label_9:
        val_14 = X21;
        goto label_28;
        label_6:
        var val_14 = val_9;
        val_14 = val_14 + (X22 + 72);
        val_15 = val_15 + val_14;
        val_15 = val_15 + 296;
        label_8:
        label_10:
        val_14 = X21;
        goto label_28;
        label_30:
        var val_4 = X24 + 0;
        val_17 = mem[(X24 + 0) + 32 + 32];
        val_17 = (X24 + 0) + 32 + 32;
        val_18 = mem[(X24 + 0) + 32 + 16];
        val_18 = (X24 + 0) + 32 + 16;
        if((((X24 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_14;
        }
        
        if(((X24 + 0) + 32 + 32 + 8 + 72) == 1)
        {
            goto label_29;
        }
        
        if(val_17 != 0)
        {
                if((((X24 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_29;
        }
        
        }
        
        if(((X24 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_29;
        }
        
        if(val_17 == 0)
        {
            goto label_28;
        }
        
        if((((X24 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_20;
        }
        
        if((((X24 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_21;
        }
        
        if((((X24 + 0) + 32 + 32 + 8.serverGameUIDataModel) & 1) == 0)
        {
            goto label_22;
        }
        
        if(((X24 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_26;
        }
        
        var val_16 = (X24 + 0) + 32 + 32 + 176;
        var val_17 = 0;
        val_16 = val_16 + 8;
        label_25:
        if((((X24 + 0) + 32 + 32 + 176 + 8) + -8) == ((X24 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_24;
        }
        
        val_17 = val_17 + 1;
        val_16 = val_16 + 16;
        if(val_17 < ((X24 + 0) + 32 + 32 + 286))
        {
            goto label_25;
        }
        
        goto label_26;
        label_14:
        if(((X24 + 0) + 32 + 32 + 8 + 74) != 1)
        {
            goto label_27;
        }
        
        goto label_28;
        label_27:
        label_29:
        val_14 = val_17;
        label_28:
        val_13 = val_14 & 1;
        label_20:
        val_18 = val_18 + 1;
        if(val_18 != (X24 + 24))
        {
            goto label_30;
        }
        
        goto label_31;
        label_0:
        if((X22 & 1) == 0)
        {
            goto label_33;
        }
        
        if((X22 + 72) == 1)
        {
            goto label_37;
        }
        
        if(X21 != 0)
        {
                if(((X21 + 265) & 1) != 0)
        {
            goto label_37;
        }
        
        }
        
        if((X21 + 265) == 0)
        {
            goto label_37;
        }
        
        if((X21 == 0) || (((X21 + 265) & 1) != 0))
        {
            goto label_60;
        }
        
        GameUI.ServerGameUIDataModel val_6 = X22.serverGameUIDataModel;
        if((X22 & 1) == 0)
        {
            goto label_40;
        }
        
        if((val_6 & 1) == 0)
        {
            goto label_41;
        }
        
        var val_25 = X21;
        if((X21 + 286) == 0)
        {
            goto label_45;
        }
        
        var val_19 = X21 + 176;
        var val_20 = 0;
        val_19 = val_19 + 8;
        label_44:
        if(((X21 + 176 + 8) + -8) == (X22 + 24))
        {
            goto label_43;
        }
        
        val_20 = val_20 + 1;
        val_19 = val_19 + 16;
        if(val_20 < (X21 + 286))
        {
            goto label_44;
        }
        
        goto label_45;
        label_1:
        val_13 = 0;
        label_31:
        val_20 = val_13 & 1;
        goto label_60;
        label_33:
        if((X22 + 74) != 1)
        {
            goto label_47;
        }
        
        goto label_60;
        label_37:
        goto label_49;
        label_47:
        label_49:
        val_20 = X21;
        label_60:
        val_20 = val_20 & 1;
        return (bool)val_20;
        label_40:
        if((val_6 & 1) == 0)
        {
            goto label_52;
        }
        
        var val_27 = X21;
        if((X21 + 286) == 0)
        {
            goto label_53;
        }
        
        var val_21 = X21 + 176;
        var val_22 = 0;
        val_21 = val_21 + 8;
        label_55:
        if(((X21 + 176 + 8) + -8) == X22.serverGameUIDataModel)
        {
            goto label_54;
        }
        
        val_22 = val_22 + 1;
        val_21 = val_21 + 16;
        if(val_22 < (X21 + 286))
        {
            goto label_55;
        }
        
        label_53:
        val_21 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(val_7), slot: 0);
        goto label_60;
        label_41:
        var val_23 = X21;
        val_23 = val_23 + ((X22 + 72) << 4);
        val_22 = (X21 + (X22 + 72) << 4) + 304;
        goto label_60;
        label_52:
        var val_8 = X21 + (X22 + 72);
        goto label_60;
        label_43:
        var val_24 = val_19;
        val_24 = val_24 + (X22 + 72);
        val_25 = val_25 + val_24;
        val_19 = val_25 + 296;
        label_45:
        val_22 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(X22 + 24), slot: 0) + 8;
        goto label_60;
        label_54:
        var val_26 = val_21;
        val_26 = val_26 + (X22 + 72);
        val_27 = val_27 + val_26;
        val_21 = val_27 + 296;
        goto label_60;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual System.IAsyncResult BeginInvoke(CodingJar.MultiScene.RuntimeCrossSceneReference xRef, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual bool EndInvoke(System.IAsyncResult result)
    {
        return (bool)UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = result});
    }

}
