using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class IxVerticalSupportedPlaneDeliverer.PointsUpdate : MulticastDelegate
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IxVerticalSupportedPlaneDeliverer.PointsUpdate(object object, IntPtr method)
    {
        mem[1152921523132823536] = object;
        mem[1152921523132823544] = method;
        mem[1152921523132823520] = method;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void Invoke(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> points)
    {
        var val_23;
        var val_24;
        var val_26;
        var val_27;
        var val_28;
        var val_31;
        var val_32;
        var val_33;
        if(X25 == 0)
        {
            goto label_0;
        }
        
        if((X25 + 24) == 0)
        {
                return;
        }
        
        var val_34 = 0;
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
        
        var val_42 = X23;
        if((X23 + 286) == 0)
        {
            goto label_17;
        }
        
        var val_20 = X23 + 176;
        var val_21 = 0;
        val_20 = val_20 + 8;
        label_16:
        if(((X23 + 176 + 8) + -8) == (X22 + 24))
        {
            goto label_15;
        }
        
        val_21 = val_21 + 1;
        val_20 = val_20 + 16;
        if(val_21 < (X23 + 286))
        {
            goto label_16;
        }
        
        goto label_17;
        label_59:
        val_23 = mem[X22 + 72];
        val_23 = X22 + 72;
        if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X22 + 24), slot: 0)) & 1) == 0)
        {
            goto label_18;
        }
        
        GameUI.ServerGameUIDataModel val_2 = X22.serverGameUIDataModel;
        var val_22 = 0;
        val_22 = val_22 + 1;
        goto label_22;
        label_60:
        SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane val_3 = 1152921505160146944 + ((X22 + 72) << 4);
        val_26 = mem[(1152921505160146944 + (X22 + 72) << 4) + 304];
        goto label_58;
        label_18:
        SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane val_4 = 1152921505160146944 + val_23;
        goto label_58;
        label_45:
        if((plane.Equals(obj:  points)) == false)
        {
            goto label_25;
        }
        
        if((X22 + 72 + 286) == 0)
        {
            goto label_58;
        }
        
        var val_23 = X22 + 72 + 176;
        var val_24 = 0;
        val_23 = val_23 + 8;
        label_28:
        if(((X22 + 72 + 176 + 8) + -8) == X22.serverGameUIDataModel)
        {
            goto label_27;
        }
        
        val_24 = val_24 + 1;
        val_23 = val_23 + 16;
        if(val_24 < (X22 + 72 + 286))
        {
            goto label_28;
        }
        
        goto label_58;
        label_46:
        var val_25 = val_23;
        val_25 = val_25 + ((X22 + 72) << 4);
        val_28 = mem[(X22 + 72 + (X22 + 72) << 4) + 304];
        val_28 = (X22 + 72 + (X22 + 72) << 4) + 304;
        goto label_58;
        label_25:
        var val_26 = val_23;
        val_26 = val_26 + (X22 + 72);
        goto label_58;
        label_22:
        var val_29 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(plane, typeof(val_2), slot: 0);
        goto label_58;
        label_48:
        var val_28 = 1179403647;
        val_28 = val_28 + ((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(plane, typeof(val_2), slot: 0) + 8);
        val_29 = val_29 + val_28;
        var val_9 = val_29 + 296;
        label_50:
        val_28 = mem[(((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(plane, typeof(val_2), slot: 0) + (1179403647 + (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(plane, typeof(val_2), slot: 0) + 8)) + 296) + 8];
        val_28 = (((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(plane, typeof(val_2), slot: 0) + (1179403647 + (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(plane, typeof(val_2), slot: 0) + 8)) + 296) + 8;
        goto label_58;
        label_27:
        var val_30 = val_23;
        val_30 = val_30 + (X22 + 72);
        val_30 = val_23 + val_30;
        val_27 = val_30 + 296;
        goto label_58;
        label_65:
        var val_10 = X25 + 0;
        val_23 = mem[(X25 + 0) + 32 + 32];
        val_23 = (X25 + 0) + 32 + 32;
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
            goto label_58;
        }
        
        if(val_23 != 0)
        {
                if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        }
        
        if(((X25 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_58;
        }
        
        if(val_23 == 0)
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
        
        var val_31 = (X25 + 0) + 32 + 32 + 176;
        var val_32 = 0;
        val_31 = val_31 + 8;
        label_49:
        if((((X25 + 0) + 32 + 32 + 176 + 8) + -8) == ((X25 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_48;
        }
        
        val_32 = val_32 + 1;
        val_31 = val_31 + 16;
        if(val_32 < ((X25 + 0) + 32 + 32 + 286))
        {
            goto label_49;
        }
        
        goto label_50;
        label_37:
        if(((X25 + 0) + 32 + 32 + 8 + 74) == 2)
        {
            goto label_56;
        }
        
        goto label_58;
        label_38:
        if(((X25 + 0) + 32 + 32 + 8 + 72) == 65535)
        {
            goto label_56;
        }
        
        if(val_23 != 0)
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
        
        if(val_23 != 0)
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
        
        var val_33 = 0;
        val_33 = val_33 + 1;
        goto label_58;
        label_56:
        label_58:
        val_34 = val_34 + 1;
        if(val_34 != (X25 + 24))
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
        
        GameUI.ServerGameUIDataModel val_13 = X22.serverGameUIDataModel;
        if((X22 & 1) == 0)
        {
            goto label_73;
        }
        
        if((val_13 & 1) == 0)
        {
            goto label_74;
        }
        
        var val_35 = 0;
        val_35 = val_35 + 1;
        goto label_78;
        label_70:
        label_94:
        label_73:
        if((val_13 & 1) == 0)
        {
            goto label_79;
        }
        
        GameUI.ServerGameUIDataModel val_14 = X22.serverGameUIDataModel;
        var val_36 = 0;
        val_36 = val_36 + 1;
        goto label_94;
        label_74:
        SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane val_15 = 1152921505160146944 + ((X22 + 72) << 4);
        val_31 = mem[(1152921505160146944 + (X22 + 72) << 4) + 304];
        goto label_94;
        label_79:
        SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane val_16 = 1152921505160146944 + (X22 + 72);
        goto label_94;
        label_12:
        if((val_1 & 1) == 0)
        {
            goto label_86;
        }
        
        if((X23 + 286) == 0)
        {
            goto label_96;
        }
        
        var val_37 = X23 + 176;
        var val_38 = 0;
        val_37 = val_37 + 8;
        label_89:
        if(((X23 + 176 + 8) + -8) == X22.serverGameUIDataModel)
        {
            goto label_88;
        }
        
        val_38 = val_38 + 1;
        val_37 = val_37 + 16;
        if(val_38 < (X23 + 286))
        {
            goto label_89;
        }
        
        goto label_96;
        label_13:
        var val_39 = X23;
        val_39 = val_39 + ((X22 + 72) << 4);
        val_33 = mem[(X23 + (X22 + 72) << 4) + 304];
        val_33 = (X23 + (X22 + 72) << 4) + 304;
        goto label_96;
        label_86:
        var val_40 = X23;
        val_40 = val_40 + (X22 + 72);
        goto label_96;
        label_78:
        val_31 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(plane, typeof(X22 + 24), slot: 0) + 8];
        val_31 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(plane, typeof(X22 + 24), slot: 0) + 8;
        goto label_94;
        label_15:
        var val_41 = val_20;
        val_41 = val_41 + (X22 + 72);
        val_42 = val_42 + val_41;
        val_24 = val_42 + 296;
        label_17:
        val_33 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X22 + 24), slot: 0) + 8];
        val_33 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X22 + 24), slot: 0) + 8;
        goto label_96;
        label_88:
        var val_43 = val_37;
        val_43 = val_43 + (X22 + 72);
        val_43 = X23 + val_43;
        val_32 = val_43 + 296;
        goto label_96;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual System.IAsyncResult BeginInvoke(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> points, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
