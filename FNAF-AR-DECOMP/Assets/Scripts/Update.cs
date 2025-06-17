using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class IxTrackedObjectDeliverer.Update : MulticastDelegate
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IxTrackedObjectDeliverer.Update(object object, IntPtr method)
    {
        mem[1152921523120087728] = object;
        mem[1152921523120087736] = method;
        mem[1152921523120087712] = method;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void Invoke(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxTrackedObject obj, SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate update)
    {
        int val_3;
        System.Collections.Generic.HashSet<SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.TileInfo> val_4;
        System.Collections.Generic.HashSet<UnityEngine.Vector3Int> val_5;
        int val_6;
        float val_7;
        System.Collections.Generic.List<SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.TileUpdateInfo> val_8;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        val_17 = 1152921523120313664;
        if(X25 == 0)
        {
            goto label_0;
        }
        
        if((X25 + 24) == 0)
        {
                return;
        }
        
        var val_21 = 0;
        goto label_30;
        label_21:
        if((1333532576 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X22 + 286) == 0)
        {
            goto label_28;
        }
        
        var val_13 = X22 + 176;
        var val_14 = 0;
        val_13 = val_13 + 8;
        label_7:
        if(((X22 + 176 + 8) + -8) == X23.serverGameUIDataModel)
        {
            goto label_6;
        }
        
        val_14 = val_14 + 1;
        val_13 = val_13 + 16;
        if(val_14 < (X22 + 286))
        {
            goto label_7;
        }
        
        goto label_28;
        label_22:
        var val_15 = X22;
        val_15 = val_15 + ((X23 + 72) << 4);
        val_19 = (X22 + (X23 + 72) << 4) + 304;
        goto label_28;
        label_4:
        var val_16 = X22;
        val_16 = val_16 + (X23 + 72);
        goto label_28;
        label_24:
        var val_17 = X11;
        val_17 = val_17 + 1152921523120248976;
        val_16 = val_16 + val_17;
        var val_2 = val_16 + 296;
        label_26:
        val_19 = (((X22 + X23 + 72) + (X11 + 1152921523120248976)) + 296) + 8;
        goto label_28;
        label_6:
        var val_18 = val_13;
        val_18 = val_18 + (X23 + 72);
        val_18 = X22 + val_18;
        val_18 = val_18 + 296;
        goto label_28;
        label_30:
        var val_9 = X25 + 0;
        val_20 = mem[(X25 + 0) + 32 + 32 + 8];
        val_20 = (X25 + 0) + 32 + 32 + 8;
        if((val_20 & 1) == 0)
        {
            goto label_14;
        }
        
        if(((X25 + 0) + 32 + 32 + 8 + 72) == 1)
        {
            goto label_29;
        }
        
        if(((X25 + 0) + 32 + 32) != 0)
        {
                if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_29;
        }
        
        }
        
        if(((X25 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_29;
        }
        
        if((((X25 + 0) + 32 + 32) == 0) || ((((X25 + 0) + 32 + 32 + 265) & 1) != 0))
        {
            goto label_28;
        }
        
        if((val_20 & 1) == 0)
        {
            goto label_21;
        }
        
        if((val_20.serverGameUIDataModel & 1) == 0)
        {
            goto label_22;
        }
        
        val_5 = obj.voxels;
        val_4 = obj.horizontalTiles;
        val_3 = obj.id;
        val_8 = update.verticalTileUpdateInfo;
        val_7 = update.voxelResolution;
        val_6 = update.objId;
        if(((X25 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_26;
        }
        
        var val_19 = (X25 + 0) + 32 + 32 + 176;
        var val_20 = 0;
        val_19 = val_19 + 8;
        label_25:
        if((((X25 + 0) + 32 + 32 + 176 + 8) + -8) == ((X25 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_24;
        }
        
        val_20 = val_20 + 1;
        val_19 = val_19 + 16;
        if(val_20 < ((X25 + 0) + 32 + 32 + 286))
        {
            goto label_25;
        }
        
        goto label_26;
        label_14:
        if(((X25 + 0) + 32 + 32 + 8 + 74) != 2)
        {
            goto label_27;
        }
        
        goto label_28;
        label_27:
        label_29:
        label_28:
        val_21 = val_21 + 1;
        if(val_21 != (X25 + 24))
        {
            goto label_30;
        }
        
        return;
        label_0:
        if((X23 & 1) == 0)
        {
            goto label_33;
        }
        
        if((X23 + 72) == 1)
        {
            goto label_37;
        }
        
        if(X22 != 0)
        {
                if(((X22 + 265) & 1) != 0)
        {
            goto label_37;
        }
        
        }
        
        if((X22 + 265) == 0)
        {
            goto label_37;
        }
        
        if(X22 == 0)
        {
                return;
        }
        
        if(((X22 + 265) & 1) != 0)
        {
                return;
        }
        
        GameUI.ServerGameUIDataModel val_11 = X23.serverGameUIDataModel;
        if((X23 & 1) == 0)
        {
            goto label_40;
        }
        
        if((val_11 & 1) == 0)
        {
            goto label_41;
        }
        
        var val_29 = X22;
        if((X22 + 286) == 0)
        {
            goto label_45;
        }
        
        var val_22 = X22 + 176;
        var val_23 = 0;
        val_22 = val_22 + 8;
        label_44:
        if(((X22 + 176 + 8) + -8) == (X23 + 24))
        {
            goto label_43;
        }
        
        val_23 = val_23 + 1;
        val_22 = val_22 + 16;
        if(val_23 < (X22 + 286))
        {
            goto label_44;
        }
        
        goto label_45;
        label_33:
        if((X23 + 74) != 2)
        {
                return;
        }
        
        return;
        label_37:
        return;
        label_40:
        if((val_11 & 1) == 0)
        {
            goto label_50;
        }
        
        if((X22 + 286) == 0)
        {
                return;
        }
        
        var val_24 = X22 + 176;
        var val_25 = 0;
        val_24 = val_24 + 8;
        label_53:
        if(((X22 + 176 + 8) + -8) == X23.serverGameUIDataModel)
        {
            goto label_52;
        }
        
        val_25 = val_25 + 1;
        val_24 = val_24 + 16;
        if(val_25 < (X22 + 286))
        {
            goto label_53;
        }
        
        return;
        label_41:
        var val_26 = X22;
        val_26 = val_26 + ((X23 + 72) << 4);
        val_23 = (X22 + (X23 + 72) << 4) + 304;
        return;
        label_50:
        var val_27 = X22;
        val_27 = val_27 + (X23 + 72);
        return;
        label_43:
        var val_28 = val_22;
        val_28 = val_28 + (X23 + 72);
        val_29 = val_29 + val_28;
        val_21 = val_29 + 296;
        label_45:
        val_23 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X22, typeof(X23 + 24), slot: 0) + 8;
        return;
        label_52:
        var val_30 = val_24;
        val_30 = val_30 + (X23 + 72);
        val_30 = X22 + val_30;
        val_22 = val_30 + 296;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual System.IAsyncResult BeginInvoke(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxTrackedObject obj, SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate update, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
