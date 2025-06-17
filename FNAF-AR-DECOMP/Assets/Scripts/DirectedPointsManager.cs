using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class DirectedPointsManager : IRawDirectedPointsAccepter
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private CoarseMesh_Config config;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, DirectedPointsManager.DirectedPointData> directedPoints;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProcessedDirectedPointsDispenser dispenser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private com.illumix.IntVector3.IntVector3Cache coordCache;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int[] intBuffer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<UnityEngine.Vector3> keys;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<DirectedPointsManager.DirectedPointData> dpds;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private com.illumix.IntVector3.IntVector3 DiscretizeVertex(UnityEngine.Vector3 vertex)
    {
        var val_7 = 0;
        do
        {
            float val_5 = this.config.resolution;
            val_5 = System.Math.Abs(vertex.x) / val_5;
            int val_6 = (int)val_5;
            val_5 = val_5 - (float)val_6;
            val_6 = ((val_5 > 0.5f) ? 1 : 0) + val_6;
            int val_2 = (vertex.x < 0) ? (-val_6) : (val_6);
            val_2 = val_2 << 1;
            val_7 = val_7 + 1;
            this.intBuffer[val_7] = val_2;
        }
        while(val_7 != 3);
        
        return (com.illumix.IntVector3.IntVector3)this.coordCache.GenerateIntVector(x:  this.intBuffer[0], y:  this.intBuffer[1], z:  this.intBuffer[2]);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Vector3 IntVectorToVertexPosition(com.illumix.IntVector3.IntVector3 intVertex)
    {
        float val_6 = this.config.resolution;
        float val_4 = (float)intVertex.Item1;
        float val_5 = (float)intVertex.Item2;
        val_4 = this.config.resolution * val_4;
        val_5 = this.config.resolution * val_5;
        val_6 = val_6 * (float)intVertex.Item3;
        val_4 = val_4 * 0.5f;
        val_5 = val_5 * 0.5f;
        val_6 = val_6 * 0.5f;
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Setup(CoarseMesh_Config config, ProcessedDirectedPointsDispenser dispenser, com.illumix.IntVector3.IntVector3Cache coordCache)
    {
        this.config = config;
        this.dispenser = dispenser;
        this.coordCache = coordCache;
        this.intBuffer = new int[3];
        this.directedPoints = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, DirectedPointData>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Teardown()
    {
        this.directedPoints.Clear();
        this.directedPoints = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnDirectedPointsUpdateEvent(UnityEngine.Vector3[] positions, UnityEngine.Vector3[] directions, UnityEngine.Vector3 cameraPos)
    {
        float val_4;
        float val_5;
        float val_6;
        float val_7;
        float val_8;
        float val_9;
        var val_10;
        UnityEngine.Vector3[] val_23;
        DirectedPointsManager val_24;
        var val_25;
        float val_26;
        float val_27;
        float val_28;
        float val_29;
        val_23 = positions;
        val_24 = this;
        val_25 = 0;
        goto label_1;
        label_21:
        val_26 = val_23 + (0 * 12);
        val_27 = mem[(0 * 12) + positions + 32];
        val_27 = (0 * 12) + positions + 32;
        val_28 = mem[(0 * 12) + positions + 32 + 4];
        val_28 = (0 * 12) + positions + 32 + 4;
        val_29 = mem[(0 * 12) + positions + 32 + 8];
        val_29 = (0 * 12) + positions + 32 + 8;
        com.illumix.IntVector3.IntVector3 val_1 = this.DiscretizeVertex(vertex:  new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_29});
        if((mem[1152921518981048104].ContainsKey(key:  val_1)) != false)
        {
                DirectedPointData val_3 = mem[1152921518981048104].Item[val_1];
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6}, d:  (float)val_10);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = (0 * 12) + positions + 32, y = (0 * 12) + positions + 32 + 4, z = (0 * 12) + positions + 32 + 8});
            int val_13 = val_10 + 1;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  (float)val_13);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9}, d:  (float)val_10);
            var val_22 = 12;
            val_22 = directions + (0 * val_22);
            val_27 = val_15.x;
            val_28 = val_15.y;
            val_29 = val_15.z;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_29}, b:  new UnityEngine.Vector3() {x = (0 * 12) + directions + 32, y = (0 * 12) + directions + 32 + 4, z = (0 * 12) + directions + 40});
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  (float)val_13);
            mem[1152921518981048104].set_Item(key:  val_1, value:  new DirectedPointData() {position = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, direction = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, weight = val_13});
        }
        else
        {
                val_26 = mem[(0 * 12) + positions + 32];
            val_26 = (0 * 12) + positions + 32;
            var val_23 = 12;
            val_23 = directions + (0 * val_23);
            mem[1152921518981048104].set_Item(key:  val_1, value:  new DirectedPointData() {position = new UnityEngine.Vector3() {x = val_26, y = (0 * 12) + positions + 32 + 4, z = (0 * 12) + positions + 32 + 8}, direction = new UnityEngine.Vector3() {x = (0 * 12) + directions + 32, y = (0 * 12) + directions + 32 + 4, z = (0 * 12) + directions + 40}, weight = 1});
            val_23 = val_23;
            val_24 = this;
        }
        
        UnityEngine.Vector3 val_18 = this.IntVectorToVertexPosition(intVertex:  val_1);
        mem[1152921518981048136].Add(item:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        DirectedPointData val_19 = mem[1152921518981048104].Item[val_1];
        mem[1152921518981048144].Add(item:  new DirectedPointData() {position = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, direction = new UnityEngine.Vector3() {x = val_4, y = val_7, z = val_7}, weight = val_7});
        val_25 = 1;
        label_1:
        if(val_25 < (positions + 24))
        {
            goto label_21;
        }
        
        mem[1152921518981048112].SendDirectedPointsEvent(keys:  mem[1152921518981048136].ToArray(), data:  mem[1152921518981048144].ToArray(), cameraPos:  new UnityEngine.Vector3() {x = cameraPos.x, y = cameraPos.y, z = cameraPos.z});
        mem[1152921518981048136].Clear();
        mem[1152921518981048144].Clear();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DirectedPointsManager()
    {
        this.keys = new System.Collections.Generic.List<UnityEngine.Vector3>();
        this.dpds = new System.Collections.Generic.List<DirectedPointData>();
    }

}
