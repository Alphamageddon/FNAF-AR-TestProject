using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class IllumixSurfaceManager : IIllumixObjectAccepter, ITimeUpdateAccepter
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.Dictionary<IllumixSurfaceManager.IntVector3, IllumixTile> horizontalTileStore;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.Dictionary<IllumixSurfaceManager.IntVector3, IllumixMeshBlock> meshBlockStore;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.Dictionary<IllumixSurfaceManager.IntVector3, IllumixDirectedPoint> directedPointsStore;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.Dictionary<int, IllumixHorizontalBoundedPlane> _horizontalBoundedPlaneStore;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.Dictionary<int, SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalBoundedPlane> _verticalBoundedPlaneStore;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<System.Tuple<UnityEngine.Vector3, long>> candidateRemoveTiles;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IllumixEngineConfig config;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IllumixEngine_SROptions options;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Camera m_Camera;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer HorizontalSupportedPlaneDeliverer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer VerticalSupportedPlaneDeliverer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SharedTechAssets.Scripts.IllumixEngine.IllumixDepthMapDeliverer DepthMapDeliverer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static IllumixSurfaceManager.SurfaceTileAdd SurfaceTileAddedEvent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static IllumixSurfaceManager.SurfaceTileUpdate SurfaceTileUpdatedEvent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static IllumixSurfaceManager.SurfaceTileRemove SurfaceTileRemovedEvent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static IllumixSurfaceManager.SurfaceMeshBlockUpdate SurfaceMeshBlockUpdatedEvent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static IllumixSurfaceManager.DirectedPointAdd SurfaceDirectedPointAddedEvent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static IllumixSurfaceManager.DirectedPointUpdate SurfaceDirectedPointUpdatedEvent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static IllumixSurfaceManager.DirectedPointRemove SurfaceDirectedPointRemovedEvent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static IllumixSurfaceManager.HorizontalBoundedPlaneAdd HorizontalBoundedPlaneAddedEvent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static IllumixSurfaceManager.HorizontalBoundedPlaneUpdate HorizontalBoundedPlaneUpdatedEvent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static IllumixSurfaceManager.HorizontalBoundedPlaneRemove HorizontalBoundedPlaneRemovedEvent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static IllumixSurfaceManager.VerticalBoundedPlaneAdd VerticalBoundedPlaneAddedEvent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static IllumixSurfaceManager.VerticalBoundedPlaneUpdate VerticalBoundedPlaneUpdatedEvent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static IllumixSurfaceManager.VerticalBoundedPlaneRemove VerticalBoundedPlaneRemovedEvent;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool IntVectorEqual(IllumixSurfaceManager.IntVector3 i, IllumixSurfaceManager.IntVector3 j)
    {
        if(i.x != j.x)
        {
                return false;
        }
        
        return (bool)((i.z == j.z) ? 1 : 0) & (((i.x >> 32) == (j.x >> 32)) ? 1 : 0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Setup(IllumixEngineConfig config, UnityEngine.Camera m_Camera)
    {
        this.config = config;
        .ism = this;
        this.options = new IllumixEngine_SROptions();
        SRDebugger.Services.IDebugService val_2 = SRDebug.Instance;
        if(val_2 != null)
        {
                var val_13 = 0;
            val_13 = val_13 + 1;
            val_2.AddOptionContainer(container:  this.options);
        }
        
        this.horizontalTileStore = new System.Collections.Generic.Dictionary<IntVector3, IllumixTile>();
        this.meshBlockStore = new System.Collections.Generic.Dictionary<IntVector3, IllumixMeshBlock>();
        this.directedPointsStore = new System.Collections.Generic.Dictionary<IntVector3, IllumixDirectedPoint>();
        this.candidateRemoveTiles = new System.Collections.Generic.List<System.Tuple<UnityEngine.Vector3, System.Int64>>();
        this._horizontalBoundedPlaneStore = new System.Collections.Generic.Dictionary<System.Int32, IllumixHorizontalBoundedPlane>();
        this._verticalBoundedPlaneStore = new System.Collections.Generic.Dictionary<System.Int32, SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalBoundedPlane>();
        this.HorizontalSupportedPlaneDeliverer = new SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer();
        this.VerticalSupportedPlaneDeliverer = new SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer();
        this.DepthMapDeliverer = new SharedTechAssets.Scripts.IllumixEngine.IllumixDepthMapDeliverer();
        this.m_Camera = m_Camera;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Teardown()
    {
        this.horizontalTileStore = 0;
        this.meshBlockStore = 0;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        if(val_1 == null)
        {
                return;
        }
        
        var val_3 = 0;
        val_3 = val_3 + 1;
        val_1.RemoveOptionContainer(container:  this.options);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void add_SurfaceTileAddedEvent(IllumixSurfaceManager.SurfaceTileAdd value)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  IllumixSurfaceManager.SurfaceTileAddedEvent, b:  value);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void remove_SurfaceTileAddedEvent(IllumixSurfaceManager.SurfaceTileAdd value)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  IllumixSurfaceManager.SurfaceTileAddedEvent, value:  value);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void add_SurfaceTileUpdatedEvent(IllumixSurfaceManager.SurfaceTileUpdate value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  IllumixSurfaceManager.SurfaceTileUpdatedEvent, b:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.SurfaceTileUpdatedEvent != 1152921505068724232);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void remove_SurfaceTileUpdatedEvent(IllumixSurfaceManager.SurfaceTileUpdate value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  IllumixSurfaceManager.SurfaceTileUpdatedEvent, value:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.SurfaceTileUpdatedEvent != 1152921505068724232);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void add_SurfaceTileRemovedEvent(IllumixSurfaceManager.SurfaceTileRemove value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  IllumixSurfaceManager.SurfaceTileRemovedEvent, b:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.SurfaceTileRemovedEvent != 1152921505068724240);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void remove_SurfaceTileRemovedEvent(IllumixSurfaceManager.SurfaceTileRemove value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  IllumixSurfaceManager.SurfaceTileRemovedEvent, value:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.SurfaceTileRemovedEvent != 1152921505068724240);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void add_SurfaceMeshBlockUpdatedEvent(IllumixSurfaceManager.SurfaceMeshBlockUpdate value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  IllumixSurfaceManager.SurfaceMeshBlockUpdatedEvent, b:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.SurfaceMeshBlockUpdatedEvent != 1152921505068724248);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void remove_SurfaceMeshBlockUpdatedEvent(IllumixSurfaceManager.SurfaceMeshBlockUpdate value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  IllumixSurfaceManager.SurfaceMeshBlockUpdatedEvent, value:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.SurfaceMeshBlockUpdatedEvent != 1152921505068724248);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void add_SurfaceDirectedPointAddedEvent(IllumixSurfaceManager.DirectedPointAdd value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  IllumixSurfaceManager.SurfaceDirectedPointAddedEvent, b:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.SurfaceDirectedPointAddedEvent != 1152921505068724256);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void remove_SurfaceDirectedPointAddedEvent(IllumixSurfaceManager.DirectedPointAdd value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  IllumixSurfaceManager.SurfaceDirectedPointAddedEvent, value:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.SurfaceDirectedPointAddedEvent != 1152921505068724256);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void add_SurfaceDirectedPointUpdatedEvent(IllumixSurfaceManager.DirectedPointUpdate value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  IllumixSurfaceManager.SurfaceDirectedPointUpdatedEvent, b:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.SurfaceDirectedPointUpdatedEvent != 1152921505068724264);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void remove_SurfaceDirectedPointUpdatedEvent(IllumixSurfaceManager.DirectedPointUpdate value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  IllumixSurfaceManager.SurfaceDirectedPointUpdatedEvent, value:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.SurfaceDirectedPointUpdatedEvent != 1152921505068724264);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void add_SurfaceDirectedPointRemovedEvent(IllumixSurfaceManager.DirectedPointRemove value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  IllumixSurfaceManager.SurfaceDirectedPointRemovedEvent, b:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.SurfaceDirectedPointRemovedEvent != 1152921505068724272);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void remove_SurfaceDirectedPointRemovedEvent(IllumixSurfaceManager.DirectedPointRemove value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  IllumixSurfaceManager.SurfaceDirectedPointRemovedEvent, value:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.SurfaceDirectedPointRemovedEvent != 1152921505068724272);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void add_HorizontalBoundedPlaneAddedEvent(IllumixSurfaceManager.HorizontalBoundedPlaneAdd value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  IllumixSurfaceManager.HorizontalBoundedPlaneAddedEvent, b:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.HorizontalBoundedPlaneAddedEvent != 1152921505068724280);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void remove_HorizontalBoundedPlaneAddedEvent(IllumixSurfaceManager.HorizontalBoundedPlaneAdd value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  IllumixSurfaceManager.HorizontalBoundedPlaneAddedEvent, value:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.HorizontalBoundedPlaneAddedEvent != 1152921505068724280);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void add_HorizontalBoundedPlaneUpdatedEvent(IllumixSurfaceManager.HorizontalBoundedPlaneUpdate value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  IllumixSurfaceManager.HorizontalBoundedPlaneUpdatedEvent, b:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.HorizontalBoundedPlaneUpdatedEvent != 1152921505068724288);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void remove_HorizontalBoundedPlaneUpdatedEvent(IllumixSurfaceManager.HorizontalBoundedPlaneUpdate value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  IllumixSurfaceManager.HorizontalBoundedPlaneUpdatedEvent, value:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.HorizontalBoundedPlaneUpdatedEvent != 1152921505068724288);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void add_HorizontalBoundedPlaneRemovedEvent(IllumixSurfaceManager.HorizontalBoundedPlaneRemove value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  IllumixSurfaceManager.HorizontalBoundedPlaneRemovedEvent, b:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.HorizontalBoundedPlaneRemovedEvent != 1152921505068724296);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void remove_HorizontalBoundedPlaneRemovedEvent(IllumixSurfaceManager.HorizontalBoundedPlaneRemove value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  IllumixSurfaceManager.HorizontalBoundedPlaneRemovedEvent, value:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.HorizontalBoundedPlaneRemovedEvent != 1152921505068724296);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void add_VerticalBoundedPlaneAddedEvent(IllumixSurfaceManager.VerticalBoundedPlaneAdd value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  IllumixSurfaceManager.VerticalBoundedPlaneAddedEvent, b:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.VerticalBoundedPlaneAddedEvent != 1152921505068724304);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void remove_VerticalBoundedPlaneAddedEvent(IllumixSurfaceManager.VerticalBoundedPlaneAdd value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  IllumixSurfaceManager.VerticalBoundedPlaneAddedEvent, value:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.VerticalBoundedPlaneAddedEvent != 1152921505068724304);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void add_VerticalBoundedPlaneUpdatedEvent(IllumixSurfaceManager.VerticalBoundedPlaneUpdate value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  IllumixSurfaceManager.VerticalBoundedPlaneUpdatedEvent, b:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.VerticalBoundedPlaneUpdatedEvent != 1152921505068724312);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void remove_VerticalBoundedPlaneUpdatedEvent(IllumixSurfaceManager.VerticalBoundedPlaneUpdate value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  IllumixSurfaceManager.VerticalBoundedPlaneUpdatedEvent, value:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.VerticalBoundedPlaneUpdatedEvent != 1152921505068724312);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void add_VerticalBoundedPlaneRemovedEvent(IllumixSurfaceManager.VerticalBoundedPlaneRemove value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  IllumixSurfaceManager.VerticalBoundedPlaneRemovedEvent, b:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.VerticalBoundedPlaneRemovedEvent != 1152921505068724320);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void remove_VerticalBoundedPlaneRemovedEvent(IllumixSurfaceManager.VerticalBoundedPlaneRemove value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  IllumixSurfaceManager.VerticalBoundedPlaneRemovedEvent, value:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(IllumixSurfaceManager.VerticalBoundedPlaneRemovedEvent != 1152921505068724320);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int DiscretizeWorldVal(float value)
    {
        value = value + value;
        value = value / this.config.resolution;
        return (int)(int)System.Math.Round(value:  (double)value, digits:  0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IllumixSurfaceManager.IntVector3 DiscretizePoint(UnityEngine.Vector3 point)
    {
        return new IntVector3() {x = this.DiscretizeWorldVal(value:  point.x), y = this.DiscretizeWorldVal(value:  point.x), z = this.DiscretizeWorldVal(value:  point.x)};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int CountTileNeighbors(IllumixTile tile)
    {
        var val_9;
        var val_10;
        System.Collections.Generic.Dictionary<IntVector3, IllumixTile> val_11;
        if(tile != null)
        {
                val_9 = this.DiscretizeWorldVal(value:  tile.length);
        }
        else
        {
                val_9 = this.DiscretizeWorldVal(value:  5.877482E-39f);
        }
        
        IntVector3 val_3 = this.DiscretizePoint(point:  new UnityEngine.Vector3() {x = 5.877482E-39f});
        val_10 = 0;
        var val_13 = 0;
        do
        {
            int val_10 = val_3.x;
            int val_12 = val_3.z - val_9;
            var val_11 = 0;
            val_10 = val_10 + (val_13 * val_9);
            int val_6 = (val_3.x & (-4294967296)) | val_10;
            do
        {
            if((val_11 | val_13) != 0)
        {
                val_11 = this.horizontalTileStore;
            if((val_11.ContainsKey(key:  new IntVector3() {x = val_6, y = val_6, z = val_12})) != false)
        {
                val_11 = this.horizontalTileStore;
            IllumixTile val_9 = val_11.Item[new IntVector3() {x = val_6, y = val_6, z = val_12}];
            val_10 = val_10 + 1152921518954814576;
        }
        
        }
        
            val_11 = val_11 + 1;
            val_12 = val_12 + val_9;
        }
        while(val_11 != 2);
        
            val_13 = val_13 + 1;
        }
        while(val_13 != 2);
        
        return (int)val_10;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void ClearIllumixEngineData()
    {
        this.horizontalTileStore.Clear();
        this.meshBlockStore.Clear();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void RemoveExpiredTileCandidates()
    {
        var val_22;
        var val_23;
        var val_24;
        System.Collections.Generic.List<System.Tuple<UnityEngine.Vector3, System.Int64>> val_25;
        IllumixEngineConfig val_26;
        var val_27;
        var val_28;
        System.DateTime val_1 = System.DateTime.UtcNow;
        long val_2 = val_1.dateData.Ticks;
        val_22 = 1152921518955078512;
        val_23 = 1152921518955080560;
        val_24 = 0;
        goto label_3;
        label_33:
        val_25 = this.candidateRemoveTiles.Item[0];
        val_26 = this.config;
        if((1844674407370955 - val_25.Item2) <= this.config.closeTimeThreshold)
        {
            goto label_7;
        }
        
        UnityEngine.Vector3 val_6 = val_25.Item1;
        IntVector3 val_7 = this.DiscretizePoint(point:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        val_26 = val_7.z & 4294967295;
        if((this.horizontalTileStore.ContainsKey(key:  new IntVector3() {x = val_7.x, y = val_7.y, z = val_26})) == false)
        {
            goto label_31;
        }
        
        IllumixTile val_9 = this.horizontalTileStore.Item[new IntVector3() {x = val_7.x, y = val_7.y, z = val_26}];
        bool val_11 = this.horizontalTileStore.Remove(key:  new IntVector3() {x = val_7.x, y = val_7.y, z = val_26});
        IntVector3 val_12 = this.DiscretizePoint(point:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        val_26 = val_12.z;
        if((public System.Boolean System.Collections.Generic.Dictionary<IntVector3, IllumixTile>::Remove(IntVector3 key)) == 0)
        {
            goto label_16;
        }
        
        val_27 = 0;
        int val_14 = val_12.x & 4294967295;
        int val_15 = val_26 & 4294967295;
        val_28 = -this.config.tileCloseThreshold;
        int val_16 = (val_12.x >> 32) - (this.config.tileCloseThreshold << 1);
        goto label_18;
        label_27:
        if((val_28 != 0) && ((this.horizontalTileStore.ContainsKey(key:  new IntVector3() {x = val_14, y = val_16, z = val_15})) != false))
        {
                IllumixTile val_18 = this.horizontalTileStore.Item[new IntVector3() {x = val_14, y = val_16, z = val_15}];
            if((public IllumixTile System.Collections.Generic.Dictionary<IntVector3, IllumixTile>::get_Item(IntVector3 key)) == 0)
        {
                this.UpdateTile(tileToDeactivate:  this.horizontalTileStore.Item[new IntVector3() {x = val_7.x, y = val_7.y, z = val_26}], tileToActivate:  this.horizontalTileStore.Item[new IntVector3() {x = val_14, y = val_16, z = val_15}]);
            val_27 = 1;
        }
        
        }
        
        val_28 = val_28 + 1;
        val_16 = val_16 + 2;
        label_18:
        val_26 = this.config;
        if(val_28 <= this.config.tileCloseThreshold)
        {
            goto label_27;
        }
        
        val_22 = 1152921518955078512;
        val_23 = 1152921518955080560;
        if((val_27 & 1) != 0)
        {
            goto label_28;
        }
        
        label_16:
        if(IllumixSurfaceManager.SurfaceTileRemovedEvent == null)
        {
            goto label_31;
        }
        
        (IllumixSurfaceManager.SurfaceTileRemovedEvent == 0) ? 0 : IllumixSurfaceManager.SurfaceTileRemovedEvent.Invoke(center:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        goto label_31;
        label_28:
        label_31:
        val_24 = 1;
        label_3:
        val_25 = this.candidateRemoveTiles;
        if(val_24 < val_25.Count)
        {
            goto label_33;
        }
        
        label_7:
        this.candidateRemoveTiles.RemoveRange(index:  0, count:  1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void UpdateTile(IllumixTile tileToDeactivate, IllumixTile tileToActivate)
    {
        int val_10;
        System.Collections.Generic.Dictionary<IntVector3, IllumixTile> val_11;
        IntVector3 val_1 = this.DiscretizePoint(point:  new UnityEngine.Vector3());
        val_10 = val_1.x;
        if((this.horizontalTileStore.ContainsKey(key:  new IntVector3() {x = val_10, y = val_1.y, z = val_1.z & 4294967295})) != false)
        {
                IntVector3 val_4 = this.DiscretizePoint(point:  new UnityEngine.Vector3());
            val_10 = val_4.x;
            IllumixTile val_6 = this.horizontalTileStore.Item[new IntVector3() {x = val_10, y = val_4.y, z = val_4.z & 4294967295}];
            mem2[0] = 0;
        }
        
        if(tileToActivate != null)
        {
                mem2[0] = 1152921518954814576;
            val_11 = this.horizontalTileStore;
        }
        else
        {
                mem2[0] = 1152921518954814576;
            val_11 = this.horizontalTileStore;
        }
        
        IntVector3 val_7 = this.DiscretizePoint(point:  new UnityEngine.Vector3());
        val_11.set_Item(key:  new IntVector3() {x = val_7.x, y = val_7.y, z = val_7.z & 4294967295}, value:  tileToActivate);
        mem2[0] = 1;
        if(IllumixSurfaceManager.SurfaceTileUpdatedEvent != null)
        {
                IllumixSurfaceManager.SurfaceTileUpdatedEvent.Invoke(oldValue:  tileToDeactivate, newValue:  tileToActivate);
        }
        
        this.RemoveDPsWithTileCollision(tile:  tileToActivate);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void AddInactiveTile(IllumixTile tile)
    {
        System.Collections.Generic.Dictionary<IntVector3, IllumixTile> val_3;
        if(tile != null)
        {
                mem2[0] = 0;
            val_3 = this.horizontalTileStore;
        }
        else
        {
                mem[40] = 0;
            val_3 = this.horizontalTileStore;
        }
        
        IntVector3 val_1 = this.DiscretizePoint(point:  new UnityEngine.Vector3());
        val_3.set_Item(key:  new IntVector3() {x = val_1.x, y = val_1.y, z = val_1.z & 4294967295}, value:  tile);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool UpdateMostRecent(IllumixTile tile)
    {
        System.Collections.Generic.Dictionary<IntVector3, IllumixTile> val_8;
        var val_9;
        var val_10;
        int val_11;
        IntVector3 val_1 = this.DiscretizePoint(point:  new UnityEngine.Vector3());
        val_8 = val_1.x >> 32;
        val_9 = 0;
        int val_2 = val_1.x & 4294967295;
        int val_3 = val_1.z & 4294967295;
        val_10 = -this.config.tileCloseThreshold;
        val_11 = val_8 - (this.config.tileCloseThreshold << 1);
        goto label_3;
        label_9:
        if(val_10 != 0)
        {
                val_8 = this.horizontalTileStore;
            if((val_8.ContainsKey(key:  new IntVector3() {x = val_2, y = val_11, z = val_3})) != false)
        {
                val_8 = this.horizontalTileStore;
            this.UpdateTile(tileToDeactivate:  val_8.Item[new IntVector3() {x = val_2, y = val_11, z = val_3}], tileToActivate:  tile);
            val_9 = 1;
        }
        
        }
        
        val_10 = val_10 + 1;
        val_11 = val_11 + 2;
        label_3:
        if(val_10 <= this.config.tileCloseThreshold)
        {
            goto label_9;
        }
        
        return (bool)val_9 & 1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool UpdateMajorityNeighbors(IllumixTile tile)
    {
        int val_14;
        var val_15;
        System.Collections.Generic.Dictionary<IntVector3, IllumixTile> val_16;
        var val_17;
        var val_18;
        var val_19;
        IntVector3 val_1 = this.DiscretizePoint(point:  new UnityEngine.Vector3());
        int val_2 = val_1.x >> 32;
        System.Collections.Generic.List<IllumixTile> val_4 = new System.Collections.Generic.List<IllumixTile>();
        int val_5 = val_1.x & 4294967295;
        val_14 = val_1.z & 4294967295;
        val_15 = -this.config.tileCloseThreshold;
        val_2 = val_2 - (this.config.tileCloseThreshold << 1);
        goto label_3;
        label_12:
        if(val_15 == 0)
        {
            goto label_6;
        }
        
        val_16 = this.horizontalTileStore;
        if((val_16.ContainsKey(key:  new IntVector3() {x = val_5, y = val_2, z = val_14})) == false)
        {
            goto label_6;
        }
        
        val_4.Add(item:  this.horizontalTileStore.Item[new IntVector3() {x = val_5, y = val_2, z = val_14}]);
        val_16 = this.horizontalTileStore;
        if((this.CountTileNeighbors(tile:  val_16.Item[new IntVector3() {x = val_5, y = val_2, z = val_14}])) > (this.CountTileNeighbors(tile:  tile)))
        {
            goto label_10;
        }
        
        label_6:
        val_15 = val_15 + 1;
        val_2 = val_2 + 2;
        label_3:
        if(val_15 <= this.config.tileCloseThreshold)
        {
            goto label_12;
        }
        
        val_17 = 0;
        goto label_13;
        label_10:
        val_17 = 1;
        label_13:
        val_18 = val_4;
        if(val_4.Count == 0)
        {
                return (bool)val_18;
        }
        
        if((val_17 & 1) == 0)
        {
            goto label_16;
        }
        
        this.AddInactiveTile(tile:  tile);
        goto label_17;
        label_16:
        val_14 = 1152921518955852144;
        val_19 = 0;
        goto label_18;
        label_21:
        this.UpdateTile(tileToDeactivate:  val_4.Item[0], tileToActivate:  tile);
        val_19 = 1;
        label_18:
        if(val_19 < val_4.Count)
        {
            goto label_21;
        }
        
        label_17:
        val_18 = 1;
        return (bool)val_18;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void RemoveDirectedPoints()
    {
        var val_15;
        System.Collections.Generic.List<IntVector3> val_1 = new System.Collections.Generic.List<IntVector3>();
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = this.directedPointsStore.Keys.GetEnumerator();
        label_9:
        if((1464313168 & 1) == 0)
        {
            goto label_3;
        }
        
        IllumixDirectedPoint val_6 = this.directedPointsStore.Item[new IntVector3() {x = 1464313168, y = 268435459, z = 1464277744}];
        if((this.AtValidDistance(idp:  val_6)) == true)
        {
            goto label_9;
        }
        
        if(IllumixSurfaceManager.SurfaceDirectedPointRemovedEvent != null)
        {
                (IllumixSurfaceManager.SurfaceDirectedPointRemovedEvent == 0) ? 0 : IllumixSurfaceManager.SurfaceDirectedPointRemovedEvent.Invoke(idp:  val_6);
        }
        
        val_1.Add(item:  new IntVector3() {x = 1464313168, y = 268435459, z = 1464277744});
        goto label_9;
        label_3:
        long val_9 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921518956062032});
        val_15 = 0;
        goto label_17;
        label_21:
        IntVector3 val_11 = val_1.Item[0];
        bool val_13 = this.directedPointsStore.Remove(key:  new IntVector3() {x = val_11.x, y = val_11.y, z = val_11.z & 4294967295});
        val_15 = 1;
        label_17:
        if(val_15 < val_1.Count)
        {
            goto label_21;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void RemoveDPsWithTileCollision(IllumixTile tile)
    {
        var val_16;
        int val_17;
        System.Collections.Generic.Dictionary<IntVector3, IllumixDirectedPoint> val_18;
        IntVector3 val_1 = this.DiscretizePoint(point:  new UnityEngine.Vector3());
        int val_2 = this.DiscretizeWorldVal(value:  tile.length);
        int val_5 = (val_2 < 0) ? (val_2 + 3) : (val_2);
        val_5 = val_5 >> 2;
        val_5 = val_5 + 1;
        val_16 = ((val_2 < 0) ? (val_2 + 1) : (val_2)) >> 1;
        val_5 = val_1.z - val_5;
        do
        {
            val_17 = 0;
            IntVector3 val_8 = this.DiscretizePoint(point:  new UnityEngine.Vector3() {x = tile.length});
            if(val_2 >= 2)
        {
                int val_15 = val_1.x >> 32;
            int val_17 = val_1.x - val_5;
            val_15 = val_15 + 0;
            val_15 = val_15 << 32;
            do
        {
            int val_16 = val_5;
            val_17 = val_15 | val_17;
            do
        {
            val_18 = this.directedPointsStore;
            if((val_18.ContainsKey(key:  new IntVector3() {x = val_17, y = val_17, z = val_16})) != false)
        {
                val_18 = this.directedPointsStore.Item[new IntVector3() {x = val_17, y = val_17, z = val_16}];
            if(val_17 != 0)
        {
                if(IllumixSurfaceManager.SurfaceDirectedPointRemovedEvent != null)
        {
                (IllumixSurfaceManager.SurfaceDirectedPointRemovedEvent == 0) ? 0 : IllumixSurfaceManager.SurfaceDirectedPointRemovedEvent.Invoke(idp:  this.directedPointsStore.Item[new IntVector3() {x = val_17, y = val_17, z = val_16}]);
        }
        
            val_18 = this.directedPointsStore;
            bool val_13 = val_18.Remove(key:  new IntVector3() {x = val_17, y = val_17, z = val_16});
        }
        
        }
        
            val_16 = val_16 - 1;
            val_16 = val_16 + 2;
        }
        while(val_16 != 0);
        
            val_16 = val_16;
            val_17 = val_17 + 2;
        }
        while(1 != val_16);
        
        }
        
            var val_14 = val_17 + 1;
        }
        while(val_17 != 0);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IllumixSurfaceManager.IntVector3 DPToPotentialTileKey(IllumixSurfaceManager.IntVector3 dpKey)
    {
        var val_12;
        var val_13;
        IllumixEngineConfig val_14;
        IllumixEngineConfig val_15;
        int val_10 = this.config.tileLength;
        val_10 = dpKey.x / val_10;
        val_12 = ((val_10 < 0) ? (val_10 + 1) : (val_10)) >> 1;
        if((dpKey.x & 2147483648) != 0)
        {
                int val_11 = this.config.tileLength;
            val_11 = val_11 << 1;
            val_11 = dpKey.x - ((dpKey.x / val_11) * val_11);
            val_12 = val_12 - ((val_11 != 0) ? 1 : 0);
        }
        
        int val_12 = this.config.tileLength;
        val_12 = dpKey.z / val_12;
        val_13 = ((val_12 < 0) ? (val_12 + 1) : (val_12)) >> 1;
        if((dpKey.z & 2147483648) != 0)
        {
                int val_13 = this.config.tileLength;
            val_13 = val_13 << 1;
            val_13 = dpKey.x - ((dpKey.x / val_13) * val_13);
            val_13 = val_13 - ((val_13 != 0) ? 1 : 0);
        }
        
        val_14 = this.config;
        if(this.config != null)
        {
            goto label_6;
        }
        
        val_14 = this.config;
        if(val_14 == null)
        {
            goto label_9;
        }
        
        label_6:
        val_15 = val_14;
        if(val_14 != null)
        {
            goto label_8;
        }
        
        val_15 = this.config;
        if(val_15 == null)
        {
            goto label_9;
        }
        
        label_8:
        int val_14 = this.config.tileLength;
        int val_15 = this.config.tileLength;
        int val_7 = val_12 * this.config.tileLength;
        val_7 = this.config.tileLength + (val_7 << 1);
        val_14 = val_13 * val_14;
        val_7 = val_7 - 1;
        val_15 = val_15 + (val_14 << 1);
        dpKey.x = val_15 - 1;
        return new IntVector3() {x = (dpKey.x & (-4294967296)) | val_7, y = (dpKey.x & (-4294967296)) | val_7, z = dpKey.x};
        label_9:
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool AtValidDistance(IllumixDirectedPoint idp)
    {
        IllumixEngineConfig val_5;
        var val_6;
        val_5 = this;
        UnityEngine.Vector3 val_2 = this.m_Camera.transform.position;
        double val_3 = Math3d.GetDistance(vec1:  new UnityEngine.Vector3() {x = idp.position, y = V11.16B, z = V12.16B}, vec2:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        double val_5 = (double)this.config.dpDistanceRatioThreshold;
        val_5 = idp.distanceFromCaptureToPoint * val_5;
        if(val_3 > val_5)
        {
                val_5 = this.config;
            var val_4 = (val_3 > (double)this.config.dpMinThreshold) ? 1 : 0;
            return (bool)val_6;
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnTileAddEvent(IllumixTile tile)
    {
        IllumixTile val_13;
        int val_14;
        val_13 = tile;
        IntVector3 val_1 = this.DiscretizePoint(point:  new UnityEngine.Vector3());
        val_14 = val_1.z & 4294967295;
        if((this.horizontalTileStore.ContainsKey(key:  new IntVector3() {x = val_1.x, y = val_1.y, z = val_14})) == false)
        {
            goto label_3;
        }
        
        val_14 = 0;
        val_13 = 0;
        goto label_4;
        label_9:
        UnityEngine.Vector3 val_5 = this.candidateRemoveTiles.Item[0].Item1;
        IntVector3 val_6 = this.DiscretizePoint(point:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        if(val_6.x == val_1.x)
        {
                int val_8 = ((val_6.x >> 32) == (val_1.x >> 32)) ? (val_14) : (val_13);
        }
        
        val_14 = 1;
        label_4:
        if(val_14 < this.candidateRemoveTiles.Count)
        {
            goto label_9;
        }
        
        if(val_8 == 1)
        {
                return;
        }
        
        this.candidateRemoveTiles.RemoveAt(index:  val_8);
        return;
        label_3:
        if(this.config.updateBehaviorType == 0)
        {
            goto label_13;
        }
        
        if((this.UpdateMajorityNeighbors(tile:  val_13)) == false)
        {
            goto label_14;
        }
        
        return;
        label_13:
        if((this.UpdateMostRecent(tile:  val_13)) == true)
        {
                return;
        }
        
        label_14:
        this.horizontalTileStore.set_Item(key:  new IntVector3() {x = val_1.x, y = val_1.y, z = val_14}, value:  val_13);
        if(IllumixSurfaceManager.SurfaceTileAddedEvent != null)
        {
                IllumixSurfaceManager.SurfaceTileAddedEvent.Invoke(obj:  val_13);
        }
        
        this.RemoveDPsWithTileCollision(tile:  val_13);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnTileRemoveEvent(UnityEngine.Vector3 center)
    {
        IntVector3 val_1 = this.DiscretizePoint(point:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
        int val_7 = val_1.z;
        val_7 = val_7 & 4294967295;
        if((this.horizontalTileStore.ContainsKey(key:  new IntVector3() {x = val_1.x, y = val_1.y, z = val_7})) != false)
        {
                IllumixTile val_3 = this.horizontalTileStore.Item[new IntVector3() {x = val_1.x, y = val_1.y, z = val_7}];
        }
        
        System.DateTime val_4 = System.DateTime.UtcNow;
        long val_5 = val_4.dateData.Ticks;
        this.candidateRemoveTiles.Add(item:  new System.Tuple<UnityEngine.Vector3, System.Int64>(item1:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, item2:  1844674407370955));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnMeshBlockAddedEvent(IllumixMeshBlock meshBlock)
    {
        IntVector3 val_1 = this.DiscretizePoint(point:  new UnityEngine.Vector3());
        this.meshBlockStore.set_Item(key:  new IntVector3() {x = val_1.x, y = val_1.y, z = val_1.z & 4294967295}, value:  meshBlock);
        if(IllumixSurfaceManager.SurfaceMeshBlockUpdatedEvent == null)
        {
                return;
        }
        
        IllumixSurfaceManager.SurfaceMeshBlockUpdatedEvent.Invoke(obj:  meshBlock);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnDirectedPointUpdate(IllumixDirectedPoint[] points)
    {
        var val_12;
        IllumixDirectedPoint val_13;
        val_12 = 0;
        goto label_1;
        label_21:
        IllumixDirectedPoint val_12 = points[0];
        IntVector3 val_1 = this.DiscretizePoint(point:  new UnityEngine.Vector3());
        int val_13 = val_1.z;
        val_13 = val_13 & 4294967295;
        if((this.directedPointsStore.ContainsKey(key:  new IntVector3() {x = val_1.x, y = val_1.y, z = val_13})) == false)
        {
            goto label_5;
        }
        
        if((public System.Boolean System.Collections.Generic.Dictionary<IntVector3, IllumixDirectedPoint>::ContainsKey(IntVector3 key)) != 0)
        {
                if(IllumixSurfaceManager.SurfaceDirectedPointUpdatedEvent != null)
        {
                val_13 = this.directedPointsStore.Item[new IntVector3() {x = val_1.x, y = val_1.y, z = val_13}];
            (IllumixSurfaceManager.SurfaceDirectedPointUpdatedEvent == 0) ? 0 : IllumixSurfaceManager.SurfaceDirectedPointUpdatedEvent.Invoke(old_dp:  val_13, new_dp:  val_12);
        }
        
        }
        
        label_19:
        this.directedPointsStore.set_Item(key:  new IntVector3() {x = val_1.x, y = val_1.y, z = val_13}, value:  val_12);
        goto label_16;
        label_5:
        IntVector3 val_7 = this.DPToPotentialTileKey(dpKey:  new IntVector3() {x = val_1.x, y = val_1.y, z = val_13 | (X22 & (-4294967296))});
        int val_14 = val_7.x;
        val_13 = val_7.z & 4294967295;
        if((this.horizontalTileStore.ContainsKey(key:  new IntVector3() {x = val_14, y = val_7.y, z = val_13})) == true)
        {
            goto label_16;
        }
        
        val_14 = val_14 + 8589934592;
        if(((this.horizontalTileStore.ContainsKey(key:  new IntVector3() {x = val_14, y = val_14, z = val_13})) == true) || ((this.AtValidDistance(idp:  val_12)) == false))
        {
            goto label_16;
        }
        
        if(IllumixSurfaceManager.SurfaceDirectedPointAddedEvent == null)
        {
            goto label_19;
        }
        
        (IllumixSurfaceManager.SurfaceDirectedPointAddedEvent == 0) ? 0 : IllumixSurfaceManager.SurfaceDirectedPointAddedEvent.Invoke(idp:  val_12);
        goto label_19;
        label_16:
        val_12 = 1;
        label_1:
        if(val_12 < points.Length)
        {
            goto label_21;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnHorizontalBoundedPlaneAddEvent(IllumixHorizontalBoundedPlane plane)
    {
        this._horizontalBoundedPlaneStore.set_Item(key:  plane.<Key>k__BackingField, value:  plane);
        if(IllumixSurfaceManager.HorizontalBoundedPlaneAddedEvent == null)
        {
                return;
        }
        
        IllumixSurfaceManager.HorizontalBoundedPlaneAddedEvent.Invoke(plane:  plane);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnHorizontalBoundedPlaneUpdateEvent(int key)
    {
        if(IllumixSurfaceManager.HorizontalBoundedPlaneUpdatedEvent == null)
        {
                return;
        }
        
        IllumixSurfaceManager.HorizontalBoundedPlaneUpdatedEvent.Invoke(plane:  this._horizontalBoundedPlaneStore.Item[key]);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnHorizontalBoundedPlaneRemoveEvent(int key)
    {
        if(IllumixSurfaceManager.HorizontalBoundedPlaneRemovedEvent != null)
        {
                IllumixSurfaceManager.HorizontalBoundedPlaneRemovedEvent.Invoke(plane:  this._horizontalBoundedPlaneStore.Item[key]);
        }
        
        bool val_2 = this._horizontalBoundedPlaneStore.Remove(key:  key);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnVerticalBoundedPlaneAddEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalBoundedPlane plane)
    {
        this._verticalBoundedPlaneStore.set_Item(key:  plane.Key, value:  plane);
        if(IllumixSurfaceManager.VerticalBoundedPlaneAddedEvent == null)
        {
                return;
        }
        
        IllumixSurfaceManager.VerticalBoundedPlaneAddedEvent.Invoke(plane:  plane);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnVerticalBoundedPlaneUpdateEvent(int key)
    {
        if(IllumixSurfaceManager.VerticalBoundedPlaneUpdatedEvent == null)
        {
                return;
        }
        
        IllumixSurfaceManager.VerticalBoundedPlaneUpdatedEvent.Invoke(plane:  this._verticalBoundedPlaneStore.Item[key]);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnVerticalBoundedPlaneRemoveEvent(int key)
    {
        if(IllumixSurfaceManager.VerticalBoundedPlaneRemovedEvent != null)
        {
                IllumixSurfaceManager.VerticalBoundedPlaneRemovedEvent.Invoke(plane:  this._verticalBoundedPlaneStore.Item[key]);
        }
        
        bool val_2 = this._verticalBoundedPlaneStore.Remove(key:  key);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IllumixHorizontalBoundedPlane GetHorizontalBoundedPlane(int key)
    {
        if(this._horizontalBoundedPlaneStore != null)
        {
                return this._horizontalBoundedPlaneStore.Item[key];
        }
        
        return this._horizontalBoundedPlaneStore.Item[key];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalBoundedPlane GetVerticalBoundedPlane(int key)
    {
        if(this._verticalBoundedPlaneStore != null)
        {
                return this._verticalBoundedPlaneStore.Item[key];
        }
        
        return this._verticalBoundedPlaneStore.Item[key];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IllumixMeshBlock GetMeshBlock(UnityEngine.Vector3 key)
    {
        System.NotImplementedException val_1 = new System.NotImplementedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void TimeUpdateEvent()
    {
        this.RemoveExpiredTileCandidates();
        this.RemoveDirectedPoints();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IllumixSurfaceManager()
    {
    
    }

}
