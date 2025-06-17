using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class UnityCVManager.FloatUpdate : MulticastDelegate
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityCVManager.FloatUpdate(object object, IntPtr method)
    {
        mem[1152921519027638288] = object;
        mem[1152921519027638296] = method;
        mem[1152921519027638272] = method;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void Invoke(float[] floats)
    {
        var val_29;
        var val_30;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_38;
        var val_39;
        var val_40;
        if(X24 == 0)
        {
            goto label_0;
        }
        
        if((X24 + 24) == 0)
        {
                return;
        }
        
        var val_40 = 0;
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
            goto label_70;
        }
        
        if(((X22 + 265) & 1) != 0)
        {
                return;
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
        
        var val_48 = X22;
        if((X22 + 286) == 0)
        {
            goto label_17;
        }
        
        var val_26 = X22 + 176;
        var val_27 = 0;
        val_26 = val_26 + 8;
        label_16:
        if(((X22 + 176 + 8) + -8) == (X21 + 24))
        {
            goto label_15;
        }
        
        val_27 = val_27 + 1;
        val_26 = val_26 + 16;
        if(val_27 < (X22 + 286))
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
        var val_28 = 0;
        val_28 = val_28 + 1;
        goto label_22;
        label_60:
        System.Single[] val_4 = 1152921505924375376 + ((X21 + 72) << 4);
        val_32 = mem[(1152921505924375376 + (X21 + 72) << 4) + 304];
        goto label_58;
        label_18:
        System.Single[] val_5 = 1152921505924375376 + (X21 + 72);
        goto label_58;
        label_45:
        val_33 = mem[X21 + 72];
        val_33 = X21 + 72;
        if((floats & 1) == 0)
        {
            goto label_25;
        }
        
        if((X21 + 72 + 286) == 0)
        {
            goto label_58;
        }
        
        var val_29 = X21 + 72 + 176;
        var val_30 = 0;
        val_29 = val_29 + 8;
        label_28:
        if(((X21 + 72 + 176 + 8) + -8) == X21.serverGameUIDataModel)
        {
            goto label_27;
        }
        
        val_30 = val_30 + 1;
        val_29 = val_29 + 16;
        if(val_30 < (X21 + 72 + 286))
        {
            goto label_28;
        }
        
        goto label_58;
        label_46:
        var val_31 = X21 + 72;
        val_31 = val_31 + ((X21 + 72) << 4);
        val_35 = mem[(X21 + 72 + (X21 + 72) << 4) + 304];
        val_35 = (X21 + 72 + (X21 + 72) << 4) + 304;
        goto label_58;
        label_25:
        var val_32 = X21 + 72;
        val_32 = val_32 + val_33;
        goto label_58;
        label_64:
        val_32 = mem[(((X21 + 72 + X21 + 72) + (((X22 + 176 + 8) + 16) + (X21 + 72 + X21 + 72) + 296 + 8)) + 296) + 8];
        val_32 = (((X21 + 72 + X21 + 72) + (((X22 + 176 + 8) + 16) + (X21 + 72 + X21 + 72) + 296 + 8)) + 296) + 8;
        goto label_58;
        label_22:
        var val_35 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(floats, typeof(val_2), slot: 0);
        goto label_58;
        label_48:
        var val_34 = 1179403647;
        val_34 = val_34 + (X21 + 72);
        val_35 = val_35 + val_34;
        var val_10 = val_35 + 296;
        label_50:
        val_35 = mem[(((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(floats, typeof(val_2), slot: 0) + (1179403647 + X21 + 72)) + 296) + 8];
        val_35 = (((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(floats, typeof(val_2), slot: 0) + (1179403647 + X21 + 72)) + 296) + 8;
        goto label_58;
        label_27:
        var val_36 = val_29;
        val_36 = val_36 + val_33;
        val_36 = (X21 + 72) + val_36;
        val_34 = val_36 + 296;
        goto label_58;
        label_65:
        var val_11 = X24 + 0;
        val_29 = mem[(X24 + 0) + 32 + 32 + 8];
        val_29 = (X24 + 0) + 32 + 32 + 8;
        val_33 = mem[(X24 + 0) + 32 + 16];
        val_33 = (X24 + 0) + 32 + 16;
        if((val_29 & 1) == 0)
        {
            goto label_37;
        }
        
        if(((X24 + 0) + 32 + 32 + 8 + 74) != 1)
        {
            goto label_38;
        }
        
        if(((X24 + 0) + 32 + 32 + 8 + 72) == 65535)
        {
            goto label_58;
        }
        
        if(((X24 + 0) + 32 + 32) != 0)
        {
                if((((X24 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        }
        
        if(((X24 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_58;
        }
        
        if(((X24 + 0) + 32 + 32) == 0)
        {
            goto label_56;
        }
        
        if((((X24 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        if((val_29 & 1) == 0)
        {
            goto label_45;
        }
        
        if((val_29.serverGameUIDataModel & 1) == 0)
        {
            goto label_46;
        }
        
        if(((X24 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_50;
        }
        
        var val_37 = (X24 + 0) + 32 + 32 + 176;
        var val_38 = 0;
        val_37 = val_37 + 8;
        label_49:
        if((((X24 + 0) + 32 + 32 + 176 + 8) + -8) == ((X24 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_48;
        }
        
        val_38 = val_38 + 1;
        val_37 = val_37 + 16;
        if(val_38 < ((X24 + 0) + 32 + 32 + 286))
        {
            goto label_49;
        }
        
        goto label_50;
        label_37:
        if(((X24 + 0) + 32 + 32 + 8 + 74) == 1)
        {
            goto label_56;
        }
        
        goto label_58;
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
        
        if((val_29 & 1) == 0)
        {
            goto label_59;
        }
        
        if((val_29.serverGameUIDataModel & 1) == 0)
        {
            goto label_60;
        }
        
        var val_39 = 0;
        val_39 = val_39 + 1;
        goto label_64;
        label_56:
        label_58:
        val_40 = val_40 + 1;
        if(val_40 != (X24 + 24))
        {
            goto label_65;
        }
        
        return;
        label_4:
        if((X21 + 74) == 1)
        {
            goto label_70;
        }
        
        label_9:
        label_96:
        label_5:
        if((X21 + 72) == 65535)
        {
            goto label_70;
        }
        
        if(X22 != 0)
        {
                if(((X22 + 265) & 1) != 0)
        {
            goto label_70;
        }
        
        }
        
        if((X22 + 265) == 0)
        {
            goto label_70;
        }
        
        if(X22 != 0)
        {
                if(((X22 + 265) & 1) != 0)
        {
                return;
        }
        
        }
        
        GameUI.ServerGameUIDataModel val_15 = X21.serverGameUIDataModel;
        if((X21 & 1) == 0)
        {
            goto label_73;
        }
        
        if((val_15 & 1) == 0)
        {
            goto label_74;
        }
        
        var val_41 = 0;
        val_41 = val_41 + 1;
        goto label_78;
        label_70:
        label_94:
        label_73:
        if((val_15 & 1) == 0)
        {
            goto label_79;
        }
        
        GameUI.ServerGameUIDataModel val_17 = X21.serverGameUIDataModel;
        var val_42 = 0;
        val_42 = val_42 + 1;
        goto label_94;
        label_74:
        System.Single[] val_19 = 1152921505924375376 + ((X21 + 72) << 4);
        val_38 = mem[(1152921505924375376 + (X21 + 72) << 4) + 304];
        goto label_94;
        label_79:
        System.Single[] val_20 = 1152921505924375376 + (X21 + 72);
        goto label_94;
        label_12:
        if((val_1 & 1) == 0)
        {
            goto label_86;
        }
        
        if((X22 + 286) == 0)
        {
            goto label_96;
        }
        
        var val_43 = X22 + 176;
        var val_44 = 0;
        val_43 = val_43 + 8;
        label_89:
        if(((X22 + 176 + 8) + -8) == X21.serverGameUIDataModel)
        {
            goto label_88;
        }
        
        val_44 = val_44 + 1;
        val_43 = val_43 + 16;
        if(val_44 < (X22 + 286))
        {
            goto label_89;
        }
        
        goto label_96;
        label_13:
        var val_45 = X22;
        val_45 = val_45 + ((X21 + 72) << 4);
        val_40 = mem[(X22 + (X21 + 72) << 4) + 304];
        val_40 = (X22 + (X21 + 72) << 4) + 304;
        goto label_96;
        label_86:
        var val_46 = X22;
        val_46 = val_46 + (X21 + 72);
        goto label_96;
        label_78:
        val_38 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(floats, typeof(X21 + 24), slot: 0) + 8];
        val_38 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(floats, typeof(X21 + 24), slot: 0) + 8;
        goto label_94;
        label_15:
        var val_47 = val_26;
        val_47 = val_47 + (X21 + 72);
        val_48 = val_48 + val_47;
        val_30 = val_48 + 296;
        label_17:
        val_40 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X22, typeof(X21 + 24), slot: 0) + 8];
        val_40 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X22, typeof(X21 + 24), slot: 0) + 8;
        goto label_96;
        label_88:
        var val_49 = val_43;
        val_49 = val_49 + (X21 + 72);
        val_49 = X22 + val_49;
        val_39 = val_49 + 296;
        goto label_96;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual System.IAsyncResult BeginInvoke(float[] floats, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
