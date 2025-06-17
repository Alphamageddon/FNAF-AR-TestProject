using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class IxModelDownloadProgressDeliverer.Complete : MulticastDelegate
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IxModelDownloadProgressDeliverer.Complete(object object, IntPtr method)
    {
        mem[1152921523112025936] = object;
        mem[1152921523112025944] = method;
        mem[1152921523112025920] = method;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void Invoke(string label, bool didFail)
    {
        var val_33;
        var val_34;
        var val_36;
        var val_37;
        var val_38;
        var val_41;
        var val_42;
        var val_43;
        if(X25 == 0)
        {
            goto label_0;
        }
        
        if((X25 + 24) == 0)
        {
                return;
        }
        
        var val_44 = 0;
        goto label_65;
        label_0:
        if((X22 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X22 + 74) != 2)
        {
            goto label_5;
        }
        
        if((X22 + 72) == 65535)
        {
            goto label_9;
        }
        
        if(X23 != 0)
        {
                if(((X23 + 265) & 1) != 0)
        {
            goto label_9;
        }
        
        }
        
        if((X23 + 265) == 0)
        {
            goto label_9;
        }
        
        if(X23 == 0)
        {
            goto label_70;
        }
        
        if(((X23 + 265) & 1) != 0)
        {
                return;
        }
        
        GameUI.ServerGameUIDataModel val_1 = X22.serverGameUIDataModel;
        if((X22 & 1) == 0)
        {
            goto label_12;
        }
        
        if((val_1 & 1) == 0)
        {
            goto label_13;
        }
        
        var val_52 = X23;
        if((X23 + 286) == 0)
        {
            goto label_17;
        }
        
        var val_30 = X23 + 176;
        var val_31 = 0;
        val_30 = val_30 + 8;
        label_16:
        if(((X23 + 176 + 8) + -8) == (X22 + 24))
        {
            goto label_15;
        }
        
        val_31 = val_31 + 1;
        val_30 = val_30 + 16;
        if(val_31 < (X23 + 286))
        {
            goto label_16;
        }
        
        goto label_17;
        label_59:
        val_33 = mem[X22 + 72];
        val_33 = X22 + 72;
        if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X22 + 24), slot: 0)) & 1) == 0)
        {
            goto label_18;
        }
        
        GameUI.ServerGameUIDataModel val_2 = X22.serverGameUIDataModel;
        var val_32 = 0;
        val_32 = val_32 + 1;
        goto label_22;
        label_60:
        string val_3 = 1152921504623300608 + ((X22 + 72) << 4);
        val_36 = mem[(1152921504623300608 + (X22 + 72) << 4) + 304];
        goto label_23;
        label_18:
        bool val_4 = didFail;
        string val_5 = 1152921504623300608 + val_33;
        goto label_58;
        label_45:
        if((label & 1) == 0)
        {
            goto label_25;
        }
        
        if((X22 + 72 + 286) == 0)
        {
            goto label_29;
        }
        
        var val_33 = X22 + 72 + 176;
        var val_34 = 0;
        val_33 = val_33 + 8;
        label_28:
        if(((X22 + 72 + 176 + 8) + -8) == X22.serverGameUIDataModel)
        {
            goto label_27;
        }
        
        val_34 = val_34 + 1;
        val_33 = val_33 + 16;
        if(val_34 < (X22 + 72 + 286))
        {
            goto label_28;
        }
        
        goto label_29;
        label_46:
        var val_35 = val_33;
        val_35 = val_35 + ((X22 + 72) << 4);
        val_38 = mem[(X22 + 72 + (X22 + 72) << 4) + 304];
        val_38 = (X22 + 72 + (X22 + 72) << 4) + 304;
        goto label_30;
        label_25:
        var val_36 = val_33;
        bool val_7 = didFail;
        val_36 = val_36 + (X22 + 72);
        goto label_58;
        label_64:
        val_36 = mem[(((X22 + 72 + X22 + 72) + (((X23 + 176 + 8) + 16) + (didFail & 1))) + 296) + 8];
        val_36 = (((X22 + 72 + X22 + 72) + (((X23 + 176 + 8) + 16) + (didFail & 1))) + 296) + 8;
        label_23:
        bool val_9 = didFail;
        goto label_58;
        label_22:
        var val_39 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(label, typeof(val_2), slot: 0);
        bool val_11 = didFail;
        goto label_58;
        label_48:
        var val_38 = 1179403647;
        val_38 = val_38 + ((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(label, typeof(val_2), slot: 0) + 8);
        val_39 = val_39 + val_38;
        var val_12 = val_39 + 296;
        label_50:
        val_38 = mem[(((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(label, typeof(val_2), slot: 0) + (1179403647 + (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(label, typeof(val_2), slot: 0) + 8)) + 296) + 8];
        val_38 = (((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(label, typeof(val_2), slot: 0) + (1179403647 + (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(label, typeof(val_2), slot: 0) + 8)) + 296) + 8;
        label_30:
        bool val_13 = didFail;
        goto label_58;
        label_27:
        var val_40 = val_33;
        val_40 = val_40 + (X22 + 72);
        val_40 = val_33 + val_40;
        val_37 = val_40 + 296;
        label_29:
        bool val_14 = didFail;
        goto label_58;
        label_65:
        var val_15 = X25 + 0;
        val_33 = mem[(X25 + 0) + 32 + 32];
        val_33 = (X25 + 0) + 32 + 32;
        if((((X25 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_37;
        }
        
        if(((X25 + 0) + 32 + 32 + 8 + 74) != 2)
        {
            goto label_38;
        }
        
        if(((X25 + 0) + 32 + 32 + 8 + 72) == 65535)
        {
            goto label_42;
        }
        
        if(val_33 != 0)
        {
                if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_42;
        }
        
        }
        
        if(((X25 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_42;
        }
        
        if(val_33 == 0)
        {
            goto label_56;
        }
        
        if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        if((((X25 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_45;
        }
        
        if((((X25 + 0) + 32 + 32 + 8.serverGameUIDataModel) & 1) == 0)
        {
            goto label_46;
        }
        
        if(((X25 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_50;
        }
        
        var val_41 = (X25 + 0) + 32 + 32 + 176;
        var val_42 = 0;
        val_41 = val_41 + 8;
        label_49:
        if((((X25 + 0) + 32 + 32 + 176 + 8) + -8) == ((X25 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_48;
        }
        
        val_42 = val_42 + 1;
        val_41 = val_41 + 16;
        if(val_42 < ((X25 + 0) + 32 + 32 + 286))
        {
            goto label_49;
        }
        
        goto label_50;
        label_37:
        if(((X25 + 0) + 32 + 32 + 8 + 74) == 2)
        {
            goto label_56;
        }
        
        label_42:
        didFail = didFail;
        goto label_58;
        label_38:
        if(((X25 + 0) + 32 + 32 + 8 + 72) == 65535)
        {
            goto label_56;
        }
        
        if(val_33 != 0)
        {
                if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_56;
        }
        
        }
        
        if(((X25 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_56;
        }
        
        if(val_33 != 0)
        {
                if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        }
        
        if((((X25 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_59;
        }
        
        if((((X25 + 0) + 32 + 32 + 8.serverGameUIDataModel) & 1) == 0)
        {
            goto label_60;
        }
        
        var val_43 = 0;
        val_43 = val_43 + 1;
        goto label_64;
        label_56:
        bool val_18 = didFail;
        label_58:
        val_44 = val_44 + 1;
        if(val_44 != (X25 + 24))
        {
            goto label_65;
        }
        
        return;
        label_4:
        if((X22 + 74) == 2)
        {
            goto label_70;
        }
        
        label_9:
        didFail = didFail;
        label_96:
        label_5:
        if((X22 + 72) == 65535)
        {
            goto label_70;
        }
        
        if(X23 != 0)
        {
                if(((X23 + 265) & 1) != 0)
        {
            goto label_70;
        }
        
        }
        
        if((X23 + 265) == 0)
        {
            goto label_70;
        }
        
        if(X23 != 0)
        {
                if(((X23 + 265) & 1) != 0)
        {
                return;
        }
        
        }
        
        GameUI.ServerGameUIDataModel val_19 = X22.serverGameUIDataModel;
        if((X22 & 1) == 0)
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
        bool val_20 = didFail;
        label_94:
        label_73:
        if((val_19 & 1) == 0)
        {
            goto label_79;
        }
        
        GameUI.ServerGameUIDataModel val_21 = X22.serverGameUIDataModel;
        var val_46 = 0;
        val_46 = val_46 + 1;
        goto label_83;
        label_74:
        string val_22 = 1152921504623300608 + ((X22 + 72) << 4);
        val_41 = mem[(1152921504623300608 + (X22 + 72) << 4) + 304];
        goto label_84;
        label_79:
        string val_23 = 1152921504623300608 + (X22 + 72);
        goto label_85;
        label_12:
        if((val_1 & 1) == 0)
        {
            goto label_86;
        }
        
        if((X23 + 286) == 0)
        {
            goto label_90;
        }
        
        var val_47 = X23 + 176;
        var val_48 = 0;
        val_47 = val_47 + 8;
        label_89:
        if(((X23 + 176 + 8) + -8) == X22.serverGameUIDataModel)
        {
            goto label_88;
        }
        
        val_48 = val_48 + 1;
        val_47 = val_47 + 16;
        if(val_48 < (X23 + 286))
        {
            goto label_89;
        }
        
        goto label_90;
        label_13:
        var val_49 = X23;
        val_49 = val_49 + ((X22 + 72) << 4);
        val_43 = mem[(X23 + (X22 + 72) << 4) + 304];
        val_43 = (X23 + (X22 + 72) << 4) + 304;
        goto label_91;
        label_86:
        var val_50 = X23;
        val_50 = val_50 + (X22 + 72);
        goto label_92;
        label_78:
        val_41 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(label, typeof(X22 + 24), slot: 0) + 8];
        val_41 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(label, typeof(X22 + 24), slot: 0) + 8;
        label_84:
        bool val_26 = didFail;
        goto label_94;
        label_83:
        label_85:
        bool val_28 = didFail;
        goto label_94;
        label_15:
        var val_51 = val_30;
        val_51 = val_51 + (X22 + 72);
        val_52 = val_52 + val_51;
        val_34 = val_52 + 296;
        label_17:
        val_43 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X22 + 24), slot: 0) + 8];
        val_43 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X22 + 24), slot: 0) + 8;
        label_91:
        bool val_29 = didFail;
        goto label_96;
        label_88:
        var val_53 = val_47;
        val_53 = val_53 + (X22 + 72);
        val_53 = X23 + val_53;
        val_42 = val_53 + 296;
        label_90:
        label_92:
        didFail = didFail;
        goto label_96;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual System.IAsyncResult BeginInvoke(string label, bool didFail, System.AsyncCallback callback, object object)
    {
        bool val_1 = didFail;
        return (System.IAsyncResult)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
