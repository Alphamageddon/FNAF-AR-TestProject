using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class UnityCVManager_Android.ObjDetectUpdate : MulticastDelegate
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityCVManager_Android.ObjDetectUpdate(object object, IntPtr method)
    {
        mem[1152921519020641168] = object;
        mem[1152921519020641176] = method;
        mem[1152921519020641152] = method;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void Invoke(string[] labels, float[] minX, float[] minY, float[] maxX, float[] maxY, float[] confs)
    {
        UnityCVManager_Android.ObjDetectUpdate val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_42;
        var val_43;
        var val_44;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        System.Single[] val_52;
        var val_53;
        var val_54;
        var val_55;
        val_31 = this;
        val_32 = maxX;
        val_33 = minY;
        val_34 = minX;
        val_35 = labels;
        if(X25 == 0)
        {
            goto label_0;
        }
        
        val_31 = mem[X25 + 24];
        val_31 = X25 + 24;
        if(val_31 == 0)
        {
                return;
        }
        
        var val_42 = 0;
        goto label_65;
        label_0:
        if((X26 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X26 + 74) != 6)
        {
            goto label_5;
        }
        
        if((X26 + 72) == 65535)
        {
            goto label_9;
        }
        
        if(X27 != 0)
        {
                if(((X27 + 265) & 1) != 0)
        {
            goto label_9;
        }
        
        }
        
        if((X27 + 265) == 0)
        {
            goto label_9;
        }
        
        if(X27 == 0)
        {
            goto label_70;
        }
        
        if(((X27 + 265) & 1) != 0)
        {
                return;
        }
        
        val_37 = X26;
        GameUI.ServerGameUIDataModel val_1 = X26.serverGameUIDataModel;
        if((val_37 & 1) == 0)
        {
            goto label_12;
        }
        
        if((val_1 & 1) == 0)
        {
            goto label_13;
        }
        
        var val_49 = X27;
        if((X27 + 286) == 0)
        {
            goto label_17;
        }
        
        var val_26 = X27 + 176;
        var val_27 = 0;
        val_26 = val_26 + 8;
        label_16:
        val_38 = (X27 + 176 + 8) + -8;
        if(val_38 == (X26 + 24))
        {
            goto label_15;
        }
        
        val_27 = val_27 + 1;
        val_26 = val_26 + 16;
        if(val_27 < (X27 + 286))
        {
            goto label_16;
        }
        
        goto label_17;
        label_59:
        val_40 = mem[X26 + 72];
        val_40 = X26 + 72;
        if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X27, typeof(X26 + 24), slot: 0)) & 1) == 0)
        {
            goto label_18;
        }
        
        GameUI.ServerGameUIDataModel val_2 = X26.serverGameUIDataModel;
        var val_28 = 0;
        val_28 = val_28 + 1;
        goto label_22;
        label_60:
        System.String[] val_4 = 1152921505343581488 + ((X26 + 72) << 4);
        val_42 = mem[(1152921505343581488 + (X26 + 72) << 4) + 304];
        goto label_23;
        label_18:
        System.String[] val_5 = 1152921505343581488 + val_40;
        goto label_58;
        label_45:
        if((val_35 & 1) == 0)
        {
            goto label_25;
        }
        
        if((X26 + 72 + 286) == 0)
        {
            goto label_58;
        }
        
        var val_29 = X26 + 72 + 176;
        var val_30 = 0;
        val_29 = val_29 + 8;
        label_28:
        if(((X26 + 72 + 176 + 8) + -8) == X26.serverGameUIDataModel)
        {
            goto label_27;
        }
        
        val_30 = val_30 + 1;
        val_29 = val_29 + 16;
        if(val_30 < (X26 + 72 + 286))
        {
            goto label_28;
        }
        
        goto label_58;
        label_46:
        var val_31 = val_40;
        val_31 = val_31 + ((X26 + 72) << 4);
        val_44 = mem[(X26 + 72 + (X26 + 72) << 4) + 304];
        val_44 = (X26 + 72 + (X26 + 72) << 4) + 304;
        goto label_30;
        label_25:
        var val_32 = val_40;
        val_32 = val_32 + (X26 + 72);
        goto label_58;
        label_64:
        label_23:
        var val_34 = ;
        goto label_58;
        label_22:
        var val_36 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(labels, typeof(val_2), slot: 0);
        goto label_58;
        label_48:
        var val_35 = 1179403647;
        val_35 = val_35 + val_33;
        val_36 = val_36 + val_35;
        label_50:
        label_30:
        var val_37 = val_36[296];
        goto label_58;
        label_27:
        var val_38 = val_29;
        val_38 = val_38 + (X26 + 72);
        val_38 = val_40 + val_38;
        val_43 = val_38 + 296;
        goto label_58;
        label_65:
        var val_9 = X25 + 0;
        val_40 = mem[(X25 + 0) + 32 + 32];
        val_40 = (X25 + 0) + 32 + 32;
        if((((X25 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_37;
        }
        
        if(((X25 + 0) + 32 + 32 + 8 + 74) != 6)
        {
            goto label_38;
        }
        
        if(((X25 + 0) + 32 + 32 + 8 + 72) == 65535)
        {
            goto label_58;
        }
        
        if(val_40 != 0)
        {
                if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        }
        
        if(mem[1152921519021011208] == 0)
        {
            goto label_58;
        }
        
        if(val_40 == 0)
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
        
        var val_39 = (X25 + 0) + 32 + 32 + 176;
        var val_40 = 0;
        val_39 = val_39 + 8;
        label_49:
        if((((X25 + 0) + 32 + 32 + 176 + 8) + -8) == ((X25 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_48;
        }
        
        val_40 = val_40 + 1;
        val_39 = val_39 + 16;
        if(val_40 < ((X25 + 0) + 32 + 32 + 286))
        {
            goto label_49;
        }
        
        goto label_50;
        label_37:
        if(((X25 + 0) + 32 + 32 + 8 + 74) == 6)
        {
            goto label_56;
        }
        
        goto label_58;
        label_38:
        if(((X25 + 0) + 32 + 32 + 8 + 72) == 65535)
        {
            goto label_56;
        }
        
        if(val_40 != 0)
        {
                if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_56;
        }
        
        }
        
        if(mem[1152921519021011208] == 0)
        {
            goto label_56;
        }
        
        if(val_40 != 0)
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
        
        var val_41 = 0;
        val_41 = val_41 + 1;
        goto label_64;
        label_56:
        label_58:
        val_42 = val_42 + 1;
        if(val_42 != val_31)
        {
            goto label_65;
        }
        
        return;
        label_4:
        if((X26 + 74) == 6)
        {
            goto label_70;
        }
        
        label_9:
        label_95:
        label_5:
        if((X26 + 72) == 65535)
        {
            goto label_70;
        }
        
        if(X27 != 0)
        {
                if(((X27 + 265) & 1) != 0)
        {
            goto label_70;
        }
        
        }
        
        if((X27 + 265) == 0)
        {
            goto label_70;
        }
        
        if(X27 != 0)
        {
                if(((X27 + 265) & 1) != 0)
        {
                return;
        }
        
        }
        
        GameUI.ServerGameUIDataModel val_13 = X26.serverGameUIDataModel;
        if((X26 & 1) == 0)
        {
            goto label_73;
        }
        
        if((val_13 & 1) == 0)
        {
            goto label_74;
        }
        
        var val_43 = 0;
        val_43 = val_43 + 1;
        goto label_78;
        label_70:
        label_94:
        label_73:
        if((val_13 & 1) == 0)
        {
            goto label_79;
        }
        
        GameUI.ServerGameUIDataModel val_15 = X26.serverGameUIDataModel;
        var val_44 = 0;
        val_44 = val_44 + 1;
        goto label_94;
        label_74:
        System.String[] val_17 = 1152921505343581488 + ((X26 + 72) << 4);
        val_47 = mem[(1152921505343581488 + (X26 + 72) << 4) + 304];
        goto label_94;
        label_79:
        System.String[] val_18 = 1152921505343581488 + (X26 + 72);
        goto label_94;
        label_12:
        val_48 = mem[X26 + 72];
        val_48 = X26 + 72;
        if((val_1 & 1) == 0)
        {
            goto label_86;
        }
        
        val_49 = mem[X27];
        val_49 = X27;
        if((X27 + 286) == 0)
        {
            goto label_95;
        }
        
        var val_45 = 0;
        val_38 = (X27 + 176) + 8;
        label_89:
        if(((X27 + 176 + 8) + -8) == X26.serverGameUIDataModel)
        {
            goto label_88;
        }
        
        val_45 = val_45 + 1;
        val_38 = val_38 + 16;
        if(val_45 < (X27 + 286))
        {
            goto label_89;
        }
        
        goto label_95;
        label_13:
        var val_46 = X27;
        val_46 = val_46 + ((X26 + 72) << 4);
        val_51 = mem[(X27 + (X26 + 72) << 4) + 304];
        val_51 = (X27 + (X26 + 72) << 4) + 304;
        goto label_91;
        label_86:
        var val_47 = X27;
        val_52 = confs;
        val_47 = val_47 + val_48;
        val_49 = mem[(X27 + X26 + 72) + 296];
        val_49 = (X27 + X26 + 72) + 296;
        val_53 = mem[(X27 + X26 + 72) + 296 + 8];
        val_53 = (X27 + X26 + 72) + 296 + 8;
        goto label_92;
        label_78:
        val_47 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(labels, typeof(X26 + 24), slot: 0) + 8];
        val_47 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(labels, typeof(X26 + 24), slot: 0) + 8;
        goto label_94;
        label_15:
        var val_48 = val_26;
        val_48 = val_48 + (X26 + 72);
        val_49 = val_49 + val_48;
        val_39 = val_49 + 296;
        label_17:
        val_51 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X27, typeof(X26 + 24), slot: 0) + 8];
        val_51 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X27, typeof(X26 + 24), slot: 0) + 8;
        label_91:
        val_49 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X27, typeof(X26 + 24), slot: 0) + 8];
        val_49 = val_51;
        val_52 = confs;
        val_53 = val_51;
        label_92:
        val_33 = ???;
        val_32 = ???;
        val_35 = ???;
        val_34 = ???;
        val_54 = ???;
        val_55 = ???;
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X27, typeof(X26 + 24), slot: 0) + 8;
        label_88:
        var val_50 = val_38;
        val_50 = val_50 + val_54;
        val_50 = val_49 + val_50;
        val_50 = val_50 + 296;
        goto label_95;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual System.IAsyncResult BeginInvoke(string[] labels, float[] minX, float[] minY, float[] maxX, float[] maxY, float[] confs, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
