using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class EventExposer.FabButtonChangeHandler : MulticastDelegate
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public EventExposer.FabButtonChangeHandler(object object, IntPtr method)
    {
        mem[1152921523281527968] = object;
        mem[1152921523281527976] = method;
        mem[1152921523281527952] = method;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void Invoke(string buttonName, bool desiredState, object requestingEntity)
    {
        var val_33;
        var val_34;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_42;
        var val_43;
        var val_44;
        if(X26 == 0)
        {
            goto label_0;
        }
        
        if((X26 + 24) == 0)
        {
                return;
        }
        
        var val_44 = 0;
        goto label_65;
        label_0:
        if((X23 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X23 + 74) != 3)
        {
            goto label_5;
        }
        
        if((X23 + 72) == 65535)
        {
            goto label_9;
        }
        
        if(X24 != 0)
        {
                if(((X24 + 265) & 1) != 0)
        {
            goto label_9;
        }
        
        }
        
        if((X24 + 265) == 0)
        {
            goto label_9;
        }
        
        if(X24 == 0)
        {
            goto label_70;
        }
        
        if(((X24 + 265) & 1) != 0)
        {
                return;
        }
        
        GameUI.ServerGameUIDataModel val_1 = X23.serverGameUIDataModel;
        if((X23 & 1) == 0)
        {
            goto label_12;
        }
        
        if((val_1 & 1) == 0)
        {
            goto label_13;
        }
        
        var val_52 = X24;
        if((X24 + 286) == 0)
        {
            goto label_17;
        }
        
        var val_30 = X24 + 176;
        var val_31 = 0;
        val_30 = val_30 + 8;
        label_16:
        if(((X24 + 176 + 8) + -8) == (X23 + 24))
        {
            goto label_15;
        }
        
        val_31 = val_31 + 1;
        val_30 = val_30 + 16;
        if(val_31 < (X24 + 286))
        {
            goto label_16;
        }
        
        goto label_17;
        label_59:
        if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X24, typeof(X23 + 24), slot: 0)) & 1) == 0)
        {
            goto label_18;
        }
        
        GameUI.ServerGameUIDataModel val_2 = X23.serverGameUIDataModel;
        var val_32 = 0;
        val_32 = val_32 + 1;
        goto label_22;
        label_60:
        string val_3 = 1152921504623300608 + ((X23 + 72) << 4);
        val_36 = mem[(1152921504623300608 + (X23 + 72) << 4) + 304];
        goto label_23;
        label_18:
        bool val_4 = desiredState;
        string val_5 = 1152921504623300608 + (X23 + 72);
        goto label_58;
        label_45:
        val_37 = mem[X23 + 72];
        val_37 = X23 + 72;
        if((buttonName & 1) == 0)
        {
            goto label_25;
        }
        
        if((X23 + 72 + 286) == 0)
        {
            goto label_29;
        }
        
        var val_33 = X23 + 72 + 176;
        var val_34 = 0;
        val_33 = val_33 + 8;
        label_28:
        if(((X23 + 72 + 176 + 8) + -8) == X23.serverGameUIDataModel)
        {
            goto label_27;
        }
        
        val_34 = val_34 + 1;
        val_33 = val_33 + 16;
        if(val_34 < (X23 + 72 + 286))
        {
            goto label_28;
        }
        
        goto label_29;
        label_46:
        var val_35 = X23 + 72;
        val_35 = val_35 + ((X23 + 72) << 4);
        val_39 = mem[(X23 + 72 + (X23 + 72) << 4) + 304];
        val_39 = (X23 + 72 + (X23 + 72) << 4) + 304;
        goto label_30;
        label_25:
        var val_36 = X23 + 72;
        bool val_7 = desiredState;
        val_36 = val_36 + val_37;
        goto label_58;
        label_64:
        val_36 = mem[(((X23 + 72 + X23 + 72) + (((X24 + 176 + 8) + 16) + (desiredState & 1))) + 296) + 8];
        val_36 = (((X23 + 72 + X23 + 72) + (((X24 + 176 + 8) + 16) + (desiredState & 1))) + 296) + 8;
        label_23:
        bool val_9 = desiredState;
        goto label_58;
        label_22:
        var val_39 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(buttonName, typeof(val_2), slot: 0);
        bool val_11 = desiredState;
        goto label_58;
        label_48:
        var val_38 = 1179403647;
        val_38 = val_38 + requestingEntity;
        val_39 = val_39 + val_38;
        object val_12 = val_39 + 296;
        label_50:
        label_30:
        bool val_13 = desiredState;
        goto label_58;
        label_27:
        var val_40 = val_33;
        val_40 = val_40 + val_37;
        val_40 = (X23 + 72) + val_40;
        val_38 = val_40 + 296;
        label_29:
        bool val_14 = desiredState;
        goto label_58;
        label_65:
        var val_15 = X26 + 0;
        val_33 = mem[(X26 + 0) + 32 + 32 + 8];
        val_33 = (X26 + 0) + 32 + 32 + 8;
        val_37 = mem[(X26 + 0) + 32 + 16];
        val_37 = (X26 + 0) + 32 + 16;
        if((val_33 & 1) == 0)
        {
            goto label_37;
        }
        
        if(((X26 + 0) + 32 + 32 + 8 + 74) != 3)
        {
            goto label_38;
        }
        
        if(((X26 + 0) + 32 + 32 + 8 + 72) == 65535)
        {
            goto label_42;
        }
        
        if(((X26 + 0) + 32 + 32) != 0)
        {
                if((((X26 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_42;
        }
        
        }
        
        if(((X26 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_42;
        }
        
        if(((X26 + 0) + 32 + 32) == 0)
        {
            goto label_56;
        }
        
        if((((X26 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        if((val_33 & 1) == 0)
        {
            goto label_45;
        }
        
        if((val_33.serverGameUIDataModel & 1) == 0)
        {
            goto label_46;
        }
        
        if(((X26 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_50;
        }
        
        var val_41 = (X26 + 0) + 32 + 32 + 176;
        var val_42 = 0;
        val_41 = val_41 + 8;
        label_49:
        if((((X26 + 0) + 32 + 32 + 176 + 8) + -8) == ((X26 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_48;
        }
        
        val_42 = val_42 + 1;
        val_41 = val_41 + 16;
        if(val_42 < ((X26 + 0) + 32 + 32 + 286))
        {
            goto label_49;
        }
        
        goto label_50;
        label_37:
        if(((X26 + 0) + 32 + 32 + 8 + 74) == 3)
        {
            goto label_56;
        }
        
        label_42:
        desiredState = desiredState;
        goto label_58;
        label_38:
        if(((X26 + 0) + 32 + 32 + 8 + 72) == 65535)
        {
            goto label_56;
        }
        
        if(((X26 + 0) + 32 + 32) != 0)
        {
                if((((X26 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_56;
        }
        
        }
        
        if(((X26 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_56;
        }
        
        if(((X26 + 0) + 32 + 32) != 0)
        {
                if((((X26 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        }
        
        if((val_33 & 1) == 0)
        {
            goto label_59;
        }
        
        if((val_33.serverGameUIDataModel & 1) == 0)
        {
            goto label_60;
        }
        
        var val_43 = 0;
        val_43 = val_43 + 1;
        goto label_64;
        label_56:
        bool val_18 = desiredState;
        label_58:
        val_44 = val_44 + 1;
        if(val_44 != (X26 + 24))
        {
            goto label_65;
        }
        
        return;
        label_4:
        if((X23 + 74) == 3)
        {
            goto label_70;
        }
        
        label_9:
        desiredState = desiredState;
        label_96:
        label_5:
        if((X23 + 72) == 65535)
        {
            goto label_70;
        }
        
        if(X24 != 0)
        {
                if(((X24 + 265) & 1) != 0)
        {
            goto label_70;
        }
        
        }
        
        if((X24 + 265) == 0)
        {
            goto label_70;
        }
        
        if(X24 != 0)
        {
                if(((X24 + 265) & 1) != 0)
        {
                return;
        }
        
        }
        
        GameUI.ServerGameUIDataModel val_19 = X23.serverGameUIDataModel;
        if((X23 & 1) == 0)
        {
            goto label_73;
        }
        
        if((val_19 & 1) == 0)
        {
            goto label_74;
        }
        
        var val_45 = 0;
        val_45 = val_45 + 1;
        goto label_78;
        label_70:
        bool val_20 = desiredState;
        label_94:
        label_73:
        if((val_19 & 1) == 0)
        {
            goto label_79;
        }
        
        GameUI.ServerGameUIDataModel val_21 = X23.serverGameUIDataModel;
        var val_46 = 0;
        val_46 = val_46 + 1;
        goto label_83;
        label_74:
        string val_22 = 1152921504623300608 + ((X23 + 72) << 4);
        val_42 = mem[(1152921504623300608 + (X23 + 72) << 4) + 304];
        goto label_84;
        label_79:
        string val_23 = 1152921504623300608 + (X23 + 72);
        goto label_85;
        label_12:
        if((val_1 & 1) == 0)
        {
            goto label_86;
        }
        
        if((X24 + 286) == 0)
        {
            goto label_90;
        }
        
        var val_47 = X24 + 176;
        var val_48 = 0;
        val_47 = val_47 + 8;
        label_89:
        if(((X24 + 176 + 8) + -8) == X23.serverGameUIDataModel)
        {
            goto label_88;
        }
        
        val_48 = val_48 + 1;
        val_47 = val_47 + 16;
        if(val_48 < (X24 + 286))
        {
            goto label_89;
        }
        
        goto label_90;
        label_13:
        var val_49 = X24;
        val_49 = val_49 + ((X23 + 72) << 4);
        val_44 = mem[(X24 + (X23 + 72) << 4) + 304];
        val_44 = (X24 + (X23 + 72) << 4) + 304;
        goto label_91;
        label_86:
        var val_50 = X24;
        val_50 = val_50 + (X23 + 72);
        goto label_92;
        label_78:
        val_42 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(buttonName, typeof(X23 + 24), slot: 0) + 8];
        val_42 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(buttonName, typeof(X23 + 24), slot: 0) + 8;
        label_84:
        bool val_26 = desiredState;
        goto label_94;
        label_83:
        label_85:
        bool val_28 = desiredState;
        goto label_94;
        label_15:
        var val_51 = val_30;
        val_51 = val_51 + (X23 + 72);
        val_52 = val_52 + val_51;
        val_34 = val_52 + 296;
        label_17:
        val_44 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X24, typeof(X23 + 24), slot: 0) + 8];
        val_44 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X24, typeof(X23 + 24), slot: 0) + 8;
        label_91:
        bool val_29 = desiredState;
        goto label_96;
        label_88:
        var val_53 = val_47;
        val_53 = val_53 + (X23 + 72);
        val_53 = X24 + val_53;
        val_43 = val_53 + 296;
        label_90:
        label_92:
        desiredState = desiredState;
        goto label_96;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual System.IAsyncResult BeginInvoke(string buttonName, bool desiredState, object requestingEntity, System.AsyncCallback callback, object object)
    {
        bool val_1 = desiredState;
        return (System.IAsyncResult)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
