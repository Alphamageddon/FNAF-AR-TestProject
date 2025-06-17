using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class BoundedPlaneManager : IARPlaneAccepter
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool useWeightedHeight;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool enableV;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool enableH;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int horizontalPlaneIdx;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int verticalPlaneIdx;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private BoundedPlaneDispenser _dispenser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.BoundedPlaneHandler.BoundedPlane_SROptions _srOptions;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.Dictionary<UnityEngine.XR.ARSubsystems.TrackableId, BoundedPlaneManager.HorizontalPlaneInfo> _horizontalPlaneToInfo;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.Dictionary<UnityEngine.XR.ARSubsystems.TrackableId, BoundedPlaneManager.VerticalPlaneInfo> _verticalPlaneToInfo;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Vector3 bufferPt;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Setup(BoundedPlaneDispenser planeDispenser)
    {
        var val_6;
        this._dispenser = planeDispenser;
        this._horizontalPlaneToInfo = new System.Collections.Generic.Dictionary<UnityEngine.XR.ARSubsystems.TrackableId, HorizontalPlaneInfo>();
        this._verticalPlaneToInfo = new System.Collections.Generic.Dictionary<UnityEngine.XR.ARSubsystems.TrackableId, VerticalPlaneInfo>();
        SharedTechAssets.Scripts.BoundedPlaneHandler.BoundedPlane_SROptions val_3 = null;
        val_6 = 0;
        val_3 = new SharedTechAssets.Scripts.BoundedPlaneHandler.BoundedPlane_SROptions(manager:  this);
        this._srOptions = val_3;
        SRDebugger.Services.IDebugService val_4 = SRDebug.Instance;
        if(val_4 == null)
        {
                return;
        }
        
        var val_6 = 0;
        val_6 = val_6 + 1;
        val_6 = 12;
        val_4.AddOptionContainer(container:  this._srOptions);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Plane_BoundaryChanged(UnityEngine.XR.ARFoundation.ARPlaneBoundaryChangedEventArgs obj)
    {
        this.UpdatePlaneInfo(plane:  obj.<plane>k__BackingField.emailUIDataHandler);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void RemoveHorizontalPlane(UnityEngine.XR.ARFoundation.ARPlane plane)
    {
        bool val_2 = UnityEngine.Object.op_Inequality(x:  plane.subsumedBy, y:  0);
        UnityEngine.XR.ARSubsystems.TrackableId val_3 = plane.trackableId;
        HorizontalPlaneInfo val_4 = this._horizontalPlaneToInfo.Item[new UnityEngine.XR.ARSubsystems.TrackableId() {m_SubId1 = val_3.m_SubId1, m_SubId2 = val_3.m_SubId2}];
        UnityEngine.XR.ARSubsystems.TrackableId val_5 = plane.trackableId;
        bool val_6 = this._horizontalPlaneToInfo.Remove(key:  new UnityEngine.XR.ARSubsystems.TrackableId() {m_SubId1 = val_5.m_SubId1, m_SubId2 = val_5.m_SubId2});
        this._dispenser.OnHorizontalPlaneRemove(id:  val_4.id);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void RemoveVerticalPlane(UnityEngine.XR.ARFoundation.ARPlane plane)
    {
        bool val_2 = UnityEngine.Object.op_Inequality(x:  plane.subsumedBy, y:  0);
        UnityEngine.XR.ARSubsystems.TrackableId val_3 = plane.trackableId;
        VerticalPlaneInfo val_4 = this._verticalPlaneToInfo.Item[new UnityEngine.XR.ARSubsystems.TrackableId() {m_SubId1 = val_3.m_SubId1, m_SubId2 = val_3.m_SubId2}];
        UnityEngine.XR.ARSubsystems.TrackableId val_5 = plane.trackableId;
        bool val_6 = this._verticalPlaneToInfo.Remove(key:  new UnityEngine.XR.ARSubsystems.TrackableId() {m_SubId1 = val_5.m_SubId1, m_SubId2 = val_5.m_SubId2});
        this._dispenser.OnVerticalPlaneRemove(id:  val_4.id);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool isHorizontal(UnityEngine.XR.ARFoundation.ARPlane plane)
    {
        var val_4;
        if(plane.alignment != 100)
        {
                return (bool)(plane.alignment == 101) ? 1 : 0;
        }
        
        val_4 = 1;
        return (bool)(plane.alignment == 101) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void UpdatePlaneInfo(UnityEngine.XR.ARFoundation.ARPlane plane)
    {
        float val_18;
        BoundedPlaneDispenser val_35;
        System.Collections.Generic.Dictionary<UnityEngine.XR.ARSubsystems.TrackableId, HorizontalPlaneInfo> val_36;
        ulong val_37;
        float val_38;
        var val_39;
        var val_41;
        float val_42;
        float val_43;
        int val_44;
        val_35 = this;
        bool val_2 = UnityEngine.Object.op_Inequality(x:  plane.subsumedBy, y:  0);
        bool val_3 = val_2.isHorizontal(plane:  plane);
        if(val_2 == false)
        {
            goto label_4;
        }
        
        if(val_3 == false)
        {
            goto label_5;
        }
        
        val_36 = this._horizontalPlaneToInfo;
        UnityEngine.XR.ARSubsystems.TrackableId val_4 = plane.trackableId;
        val_37 = val_4.m_SubId2;
        if((val_36.ContainsKey(key:  new UnityEngine.XR.ARSubsystems.TrackableId() {m_SubId1 = val_4.m_SubId1, m_SubId2 = val_37})) == false)
        {
                return;
        }
        
        this.RemoveHorizontalPlane(plane:  plane);
        return;
        label_4:
        if(val_3 == false)
        {
            goto label_10;
        }
        
        val_36 = this._horizontalPlaneToInfo;
        UnityEngine.XR.ARSubsystems.TrackableId val_6 = plane.trackableId;
        val_37 = val_6.m_SubId2;
        if((val_36.ContainsKey(key:  new UnityEngine.XR.ARSubsystems.TrackableId() {m_SubId1 = val_6.m_SubId1, m_SubId2 = val_37})) == false)
        {
            goto label_24;
        }
        
        UnityEngine.XR.ARSubsystems.TrackableId val_8 = plane.trackableId;
        val_36 = this._horizontalPlaneToInfo.Item[new UnityEngine.XR.ARSubsystems.TrackableId() {m_SubId1 = val_8.m_SubId1, m_SubId2 = val_8.m_SubId2}];
        if(val_36 == null)
        {
            goto label_16;
        }
        
        val_38 = val_9.weight;
        goto label_17;
        label_5:
        val_36 = this._verticalPlaneToInfo;
        UnityEngine.XR.ARSubsystems.TrackableId val_10 = plane.trackableId;
        val_37 = val_10.m_SubId2;
        if((val_36.ContainsKey(key:  new UnityEngine.XR.ARSubsystems.TrackableId() {m_SubId1 = val_10.m_SubId1, m_SubId2 = val_37})) == false)
        {
                return;
        }
        
        this.RemoveVerticalPlane(plane:  plane);
        return;
        label_10:
        val_36 = this._verticalPlaneToInfo;
        UnityEngine.XR.ARSubsystems.TrackableId val_12 = plane.trackableId;
        val_37 = val_12.m_SubId2;
        bool val_13 = val_36.ContainsKey(key:  new UnityEngine.XR.ARSubsystems.TrackableId() {m_SubId1 = val_12.m_SubId1, m_SubId2 = val_37});
        if(val_13 == false)
        {
            goto label_24;
        }
        
        val_36 = val_13.ConvertBoundaryToWorldspace(plane:  plane);
        UnityEngine.XR.ARSubsystems.TrackableId val_15 = plane.trackableId;
        VerticalPlaneInfo val_16 = this._verticalPlaneToInfo.Item[new UnityEngine.XR.ARSubsystems.TrackableId() {m_SubId1 = val_15.m_SubId1, m_SubId2 = val_15.m_SubId2}];
        val_37 = "";
        List.Enumerator<T> val_17 = val_36.GetEnumerator();
        val_39 = 1152921518724926064;
        label_29:
        if((1433453392 & 1) == 0)
        {
            goto label_28;
        }
        
        UnityEngine.Vector3 val_20 = val_18.position;
        val_18 = val_20.x;
        string val_21 = val_37 + val_20 + " ";
        goto label_29;
        label_24:
        this.OnPlaneAddedEvent(plane:  plane);
        return;
        label_16:
        val_38 = val_9.weight;
        label_17:
        UnityEngine.Transform val_22 = plane.transform;
        UnityEngine.Vector3 val_23 = val_22.position;
        float val_34 = val_9.weight;
        val_23.y = (val_38 * val_9.weightedHeight) + val_23.y;
        val_34 = val_34 + 1f;
        val_23.y = val_23.y / val_34;
        val_9.weightedHeight = val_23.y;
        val_9.weight = val_34;
        System.Collections.Generic.List<UnityEngine.Vector3> val_25 = val_22.ConvertBoundaryToWorldspace(plane:  plane);
        if(this.useWeightedHeight == false)
        {
            goto label_33;
        }
        
        val_39 = 1152921518725068768;
        val_41 = 0;
        val_37 = this.bufferPt;
        goto label_34;
        label_38:
        UnityEngine.Vector3 val_26 = val_25.Item[0];
        val_25.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = this.bufferPt, y = val_9.weightedHeight, z = V10.16B});
        val_41 = 1;
        label_34:
        if(val_41 < val_25.Count)
        {
            goto label_38;
        }
        
        val_35 = this._dispenser;
        val_43 = val_9.weightedHeight;
        val_44 = val_9.id;
        goto label_40;
        label_33:
        val_37 = this._dispenser;
        val_35 = val_9.id;
        UnityEngine.Vector3 val_29 = plane.transform.position;
        val_43 = val_29.y;
        val_44 = val_35;
        label_40:
        val_37.OnHorizontalPlaneUpdate(id:  val_44, boundary:  val_25, height:  val_43);
        return;
        label_28:
        long val_30 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921518925202256});
        val_35 = this._dispenser;
        UnityEngine.Vector3 val_32 = plane.center;
        val_43 = val_32.x;
        val_42 = val_32.z;
        UnityEngine.Vector3 val_33 = plane.normal;
        val_35.OnVerticalPlaneUpdate(id:  val_16.id, boundary:  val_36, center:  new UnityEngine.Vector3() {x = val_43, y = val_32.y, z = val_42}, normal:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<UnityEngine.Vector3> ConvertBoundaryToWorldspace(UnityEngine.XR.ARFoundation.ARPlane plane)
    {
        var val_15;
        var val_16;
        Unity.Collections.NativeArray<UnityEngine.Vector2> val_1 = plane.boundary;
        val_15 = 0;
        System.Collections.Generic.List<UnityEngine.Vector3> val_2 = new System.Collections.Generic.List<UnityEngine.Vector3>(capacity:  0);
        val_16 = 0;
        goto label_2;
        label_14:
        Unity.Collections.NativeArray<UnityEngine.Vector2> val_3 = plane.boundary;
        UnityEngine.Vector3 val_5 = plane.transform.position;
        UnityEngine.Vector3 val_7 = plane.transform.right;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(d:  1.674571E+13f, a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        val_15 = plane.transform;
        UnityEngine.Vector3 val_11 = val_15.forward;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(d:  1152921518925393568.__il2cppRuntimeField_4, a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        val_2.Add(item:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        val_16 = 1;
        label_2:
        Unity.Collections.NativeArray<UnityEngine.Vector2> val_14 = plane.boundary;
        if(val_16 < 0)
        {
            goto label_14;
        }
        
        return val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnPlaneAddedEvent(UnityEngine.XR.ARFoundation.ARPlane plane)
    {
        BoundedPlaneDispenser val_14;
        float val_15;
        float val_16;
        if((this.isHorizontal(plane:  plane)) != false)
        {
                if(this.enableH == false)
        {
                return;
        }
        
            this.horizontalPlaneIdx = this.horizontalPlaneIdx + 1;
            UnityEngine.XR.ARSubsystems.TrackableId val_3 = plane.trackableId;
            .id = this.horizontalPlaneIdx;
            this._horizontalPlaneToInfo.set_Item(key:  new UnityEngine.XR.ARSubsystems.TrackableId() {m_SubId1 = val_3.m_SubId1, m_SubId2 = val_3.m_SubId2}, value:  new BoundedPlaneManager.HorizontalPlaneInfo());
            val_14 = this._dispenser;
            UnityEngine.Vector3 val_6 = plane.center;
            val_15 = val_6.x;
            val_16 = val_6.z;
            val_14.OnHorizontalPlaneAdd(id:  this.horizontalPlaneIdx, boundary:  this._horizontalPlaneToInfo.ConvertBoundaryToWorldspace(plane:  plane), center:  new UnityEngine.Vector3() {x = val_15, y = val_6.y, z = val_16});
        }
        else
        {
                if(this.enableV == false)
        {
                return;
        }
        
            this.verticalPlaneIdx = this.verticalPlaneIdx + 1;
            UnityEngine.XR.ARSubsystems.TrackableId val_8 = plane.trackableId;
            .id = this.verticalPlaneIdx;
            this._verticalPlaneToInfo.set_Item(key:  new UnityEngine.XR.ARSubsystems.TrackableId() {m_SubId1 = val_8.m_SubId1, m_SubId2 = val_8.m_SubId2}, value:  new BoundedPlaneManager.VerticalPlaneInfo());
            val_14 = this._dispenser;
            UnityEngine.Vector3 val_11 = plane.center;
            val_15 = val_11.x;
            val_16 = val_11.z;
            UnityEngine.Vector3 val_12 = plane.normal;
            val_14.OnVerticalPlaneAdd(id:  this.verticalPlaneIdx, boundary:  this._verticalPlaneToInfo.ConvertBoundaryToWorldspace(plane:  plane), center:  new UnityEngine.Vector3() {x = val_15, y = val_11.y, z = val_16}, normal:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        }
        
        plane.add_boundaryChanged(value:  new System.Action<UnityEngine.XR.ARFoundation.ARPlaneBoundaryChangedEventArgs>(object:  this, method:  System.Void BoundedPlaneManager::Plane_BoundaryChanged(UnityEngine.XR.ARFoundation.ARPlaneBoundaryChangedEventArgs obj)));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnPlaneRemovedEvent(UnityEngine.XR.ARFoundation.ARPlane plane)
    {
        if((this.isHorizontal(plane:  plane)) != false)
        {
                this.RemoveHorizontalPlane(plane:  plane);
            return;
        }
        
        this.RemoveVerticalPlane(plane:  plane);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public BoundedPlaneManager()
    {
        this.useWeightedHeight = true;
        this.enableV = true;
        this.enableH = true;
    }

}
