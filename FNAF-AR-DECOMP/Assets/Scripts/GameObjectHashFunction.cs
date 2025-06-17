using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class AkSoundEngine.GameObjectHashFunction : MulticastDelegate
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkSoundEngine.GameObjectHashFunction(object object, IntPtr method)
    {
        mem[1152921519143706448] = object;
        mem[1152921519143706456] = method;
        mem[1152921519143706432] = method;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual ulong Invoke(UnityEngine.GameObject gameObject)
    {
        var val_22;
        var val_23;
        var val_24;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_32;
        var val_33;
        var val_34;
        if(X24 == 0)
        {
            goto label_0;
        }
        
        if((X24 + 24) == 0)
        {
            goto label_73;
        }
        
        val_22 = 0;
        var val_33 = 0;
        goto label_65;
        label_0:
        if((X21 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X21 + 74) != 1)
        {
            goto label_5;
        }
        
        if((X21 + 72) == 65535)
        {
            goto label_9;
        }
        
        if(X22 != 0)
        {
                if(((X22 + 265) & 1) != 0)
        {
            goto label_9;
        }
        
        }
        
        if((X22 + 265) == 0)
        {
            goto label_9;
        }
        
        if(X22 == 0)
        {
            goto label_71;
        }
        
        if(((X22 + 265) & 1) != 0)
        {
            goto label_73;
        }
        
        GameUI.ServerGameUIDataModel val_1 = X21.serverGameUIDataModel;
        if((X21 & 1) == 0)
        {
            goto label_12;
        }
        
        if((val_1 & 1) == 0)
        {
            goto label_13;
        }
        
        var val_41 = X22;
        if((X22 + 286) == 0)
        {
            goto label_17;
        }
        
        var val_19 = X22 + 176;
        var val_20 = 0;
        val_19 = val_19 + 8;
        label_16:
        if(((X22 + 176 + 8) + -8) == (X21 + 24))
        {
            goto label_15;
        }
        
        val_20 = val_20 + 1;
        val_19 = val_19 + 16;
        if(val_20 < (X22 + 286))
        {
            goto label_16;
        }
        
        goto label_17;
        label_59:
        if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X22, typeof(X21 + 24), slot: 0)) & 1) == 0)
        {
            goto label_18;
        }
        
        GameUI.ServerGameUIDataModel val_2 = X21.serverGameUIDataModel;
        var val_21 = 0;
        val_21 = val_21 + 1;
        goto label_22;
        label_60:
        UnityEngine.GameObject val_3 = 1152921504835440640 + ((X21 + 72) << 4);
        val_26 = mem[(1152921504835440640 + (X21 + 72) << 4) + 304];
        goto label_23;
        label_18:
        val_27 = gameObject;
        UnityEngine.GameObject val_4 = 1152921504835440640 + (X21 + 72);
        goto label_52;
        label_45:
        if((val_27 & 1) == 0)
        {
            goto label_25;
        }
        
        if((X21 + 72 + 286) == 0)
        {
            goto label_29;
        }
        
        var val_22 = X21 + 72 + 176;
        var val_23 = 0;
        val_22 = val_22 + 8;
        label_28:
        if(((X21 + 72 + 176 + 8) + -8) == X21.serverGameUIDataModel)
        {
            goto label_27;
        }
        
        val_23 = val_23 + 1;
        val_22 = val_22 + 16;
        if(val_23 < (X21 + 72 + 286))
        {
            goto label_28;
        }
        
        goto label_29;
        label_46:
        var val_24 = X21 + 72;
        val_24 = val_24 + ((X21 + 72) << 4);
        val_29 = mem[(X21 + 72 + (X21 + 72) << 4) + 304];
        val_29 = (X21 + 72 + (X21 + 72) << 4) + 304;
        goto label_30;
        label_25:
        var val_25 = X21 + 72;
        val_27 = X21 + 72;
        val_25 = val_25 + (X21 + 72);
        goto label_52;
        label_64:
        val_26 = mem[(((X21 + 72 + X21 + 72) + (((X22 + 176 + 8) + 16) + (X21 + 72 + X21 + 72) + 296 + 8)) + 296) + 8];
        val_26 = (((X21 + 72 + X21 + 72) + (((X22 + 176 + 8) + 16) + (X21 + 72 + X21 + 72) + 296 + 8)) + 296) + 8;
        label_23:
        val_27 = gameObject;
        goto label_52;
        label_22:
        var val_28 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(gameObject, typeof(val_2), slot: 0);
        val_27 = gameObject;
        goto label_52;
        label_48:
        var val_27 = 1179403647;
        val_27 = val_27 + (X21 + 72);
        val_28 = val_28 + val_27;
        var val_8 = val_28 + 296;
        label_50:
        val_29 = mem[(((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(gameObject, typeof(val_2), slot: 0) + (1179403647 + X21 + 72)) + 296) + 8];
        val_29 = (((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(gameObject, typeof(val_2), slot: 0) + (1179403647 + X21 + 72)) + 296) + 8;
        label_30:
        val_27 = X21 + 72;
        goto label_52;
        label_27:
        var val_29 = val_22;
        val_29 = val_29 + (X21 + 72);
        val_29 = (X21 + 72) + val_29;
        val_28 = val_29 + 296;
        label_29:
        val_27 = X21 + 72;
        goto label_52;
        label_65:
        var val_9 = X24 + 0;
        val_23 = mem[(X24 + 0) + 32 + 32 + 8];
        val_23 = (X24 + 0) + 32 + 32 + 8;
        if((val_23 & 1) == 0)
        {
            goto label_37;
        }
        
        if(((X24 + 0) + 32 + 32 + 8 + 74) != 1)
        {
            goto label_38;
        }
        
        if(((X24 + 0) + 32 + 32 + 8 + 72) == 65535)
        {
            goto label_42;
        }
        
        if(((X24 + 0) + 32 + 32) != 0)
        {
                if((((X24 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_42;
        }
        
        }
        
        if(((X24 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_42;
        }
        
        if(((X24 + 0) + 32 + 32) == 0)
        {
            goto label_56;
        }
        
        if((((X24 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        if((val_23 & 1) == 0)
        {
            goto label_45;
        }
        
        if((val_23.serverGameUIDataModel & 1) == 0)
        {
            goto label_46;
        }
        
        if(((X24 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_50;
        }
        
        var val_30 = (X24 + 0) + 32 + 32 + 176;
        var val_31 = 0;
        val_30 = val_30 + 8;
        label_49:
        if((((X24 + 0) + 32 + 32 + 176 + 8) + -8) == ((X24 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_48;
        }
        
        val_31 = val_31 + 1;
        val_30 = val_30 + 16;
        if(val_31 < ((X24 + 0) + 32 + 32 + 286))
        {
            goto label_49;
        }
        
        goto label_50;
        label_37:
        if(((X24 + 0) + 32 + 32 + 8 + 74) == 1)
        {
            goto label_56;
        }
        
        label_42:
        val_27 = (X24 + 0) + 32 + 32;
        goto label_52;
        label_38:
        if(((X24 + 0) + 32 + 32 + 8 + 72) == 65535)
        {
            goto label_56;
        }
        
        if(((X24 + 0) + 32 + 32) != 0)
        {
                if((((X24 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_56;
        }
        
        }
        
        if(((X24 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_56;
        }
        
        if(((X24 + 0) + 32 + 32) != 0)
        {
                if((((X24 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        }
        
        if((val_23 & 1) == 0)
        {
            goto label_59;
        }
        
        if((val_23.serverGameUIDataModel & 1) == 0)
        {
            goto label_60;
        }
        
        var val_32 = 0;
        val_32 = val_32 + 1;
        goto label_64;
        label_56:
        val_27 = gameObject;
        label_52:
        val_22 = val_27;
        label_58:
        val_33 = val_33 + 1;
        if(val_33 != (X24 + 24))
        {
            goto label_65;
        }
        
        return (ulong)val_22;
        label_4:
        if((X21 + 74) == 1)
        {
            goto label_71;
        }
        
        label_9:
        label_97:
        label_5:
        if((X21 + 72) == 65535)
        {
            goto label_71;
        }
        
        if(X22 != 0)
        {
                if(((X22 + 265) & 1) != 0)
        {
            goto label_71;
        }
        
        }
        
        if((X22 + 265) == 0)
        {
            goto label_71;
        }
        
        if(X22 != 0)
        {
                if(((X22 + 265) & 1) != 0)
        {
            goto label_73;
        }
        
        }
        
        GameUI.ServerGameUIDataModel val_12 = X21.serverGameUIDataModel;
        if((X21 & 1) == 0)
        {
            goto label_74;
        }
        
        if((val_12 & 1) == 0)
        {
            goto label_75;
        }
        
        var val_34 = 0;
        val_34 = val_34 + 1;
        goto label_79;
        label_73:
        val_22 = 0;
        return (ulong)val_22;
        label_71:
        label_95:
        label_74:
        if((val_12 & 1) == 0)
        {
            goto label_80;
        }
        
        GameUI.ServerGameUIDataModel val_13 = X21.serverGameUIDataModel;
        var val_35 = 0;
        val_35 = val_35 + 1;
        goto label_95;
        label_75:
        UnityEngine.GameObject val_14 = 1152921504835440640 + ((X21 + 72) << 4);
        val_32 = mem[(1152921504835440640 + (X21 + 72) << 4) + 304];
        goto label_95;
        label_80:
        UnityEngine.GameObject val_15 = 1152921504835440640 + (X21 + 72);
        goto label_95;
        label_12:
        if((val_1 & 1) == 0)
        {
            goto label_87;
        }
        
        if((X22 + 286) == 0)
        {
            goto label_97;
        }
        
        var val_36 = X22 + 176;
        var val_37 = 0;
        val_36 = val_36 + 8;
        label_90:
        if(((X22 + 176 + 8) + -8) == X21.serverGameUIDataModel)
        {
            goto label_89;
        }
        
        val_37 = val_37 + 1;
        val_36 = val_36 + 16;
        if(val_37 < (X22 + 286))
        {
            goto label_90;
        }
        
        goto label_97;
        label_13:
        var val_38 = X22;
        val_38 = val_38 + ((X21 + 72) << 4);
        val_34 = mem[(X22 + (X21 + 72) << 4) + 304];
        val_34 = (X22 + (X21 + 72) << 4) + 304;
        goto label_97;
        label_87:
        var val_39 = X22;
        val_39 = val_39 + (X21 + 72);
        goto label_97;
        label_79:
        val_32 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(gameObject, typeof(X21 + 24), slot: 0) + 8];
        val_32 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(gameObject, typeof(X21 + 24), slot: 0) + 8;
        goto label_95;
        label_15:
        var val_40 = val_19;
        val_40 = val_40 + (X21 + 72);
        val_41 = val_41 + val_40;
        val_24 = val_41 + 296;
        label_17:
        val_34 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X22, typeof(X21 + 24), slot: 0) + 8];
        val_34 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X22, typeof(X21 + 24), slot: 0) + 8;
        goto label_97;
        label_89:
        var val_42 = val_36;
        val_42 = val_42 + (X21 + 72);
        val_42 = X22 + val_42;
        val_33 = val_42 + 296;
        goto label_97;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual System.IAsyncResult BeginInvoke(UnityEngine.GameObject gameObject, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual ulong EndInvoke(System.IAsyncResult result)
    {
        return (ulong)UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = result});
    }

}
