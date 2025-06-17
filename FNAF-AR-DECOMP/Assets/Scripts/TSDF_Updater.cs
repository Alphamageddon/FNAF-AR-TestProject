using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class TSDF_Updater
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private com.illumix.TSDF.TSDF_Manager domain;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TSDF_Config config;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int[] intBuffer;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TSDF_Updater(com.illumix.TSDF.TSDF_Manager tsdfDomain)
    {
        this.domain = tsdfDomain;
        this.config = tsdfDomain.config;
        this.intBuffer = new int[3];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float CalculateNorm(UnityEngine.Vector3 v)
    {
        v.x = v.x * v.x;
        v.x = v.x + (v.x * v.x);
        float val_2 = v.x * v.x;
        val_2 = v.x + val_2;
        if(v.x < _TYPE_MAX_)
        {
                return (float)val_2;
        }
        
        return (float)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public com.illumix.IntVector3.IntVector3 DiscretizeVertex(UnityEngine.Vector3 vertex)
    {
        var val_7 = 0;
        do
        {
            TSDF_Properties val_5 = this.domain.config.props;
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
        
        return (com.illumix.IntVector3.IntVector3)this.domain.GenerateIntVector(x:  this.intBuffer[0], y:  this.intBuffer[1], z:  this.intBuffer[2]);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double GetDistance(UnityEngine.Vector3 vertex, UnityEngine.Vector3 cameraPos)
    {
        vertex.x = vertex.x - cameraPos.x;
        vertex.y = vertex.y - cameraPos.y;
        vertex.z = vertex.z - cameraPos.z;
        double val_1 = (double)vertex.x;
        double val_2 = (double)vertex.y;
        double val_3 = (double)vertex.z;
        val_1 = val_1 * val_1;
        val_2 = val_2 * val_2;
        val_3 = val_3 * val_3;
        val_1 = val_1 + val_2;
        val_1 = val_3 + val_1;
        if(val_2 <= _TYPE_MAX_)
        {
                return (double)val_2;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void UpdateInBand(UnityEngine.Vector3 vertex, UnityEngine.Vector3 cameraPt, com.illumix.TSDF.TSDF_Manager.TSDF_Data data)
    {
        var val_32;
        TSDF_Updater val_33;
        System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, com.illumix.TSDF.Voxel> val_34;
        TSDF_Config val_35;
        TSDF_Config val_37;
        float val_38;
        TSDF_Properties val_39;
        float val_40;
        com.illumix.TSDF.TSDF_Manager val_41;
        float val_42;
        float val_43;
        var val_44;
        var val_45;
        float val_46;
        var val_47;
        var val_48;
        float val_49;
        float val_50;
        float val_51;
        System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean>> val_52;
        TSDF_Config val_53;
        int val_54;
        TSDF_Config val_55;
        var val_56;
        com.illumix.IntVector3.IntVector3 val_57;
        var val_58;
        var val_59;
        val_32 = 1152921518993398208;
        val_33 = this;
        com.illumix.TSDF.VoxelBlock val_25 = 0;
        val_34 = data.tsdfStore;
        val_35 = this.config;
        if(val_35 == null)
        {
            goto label_1;
        }
        
        goto label_2;
        label_1:
        val_37 = this.config;
        if(val_37 == null)
        {
            goto label_3;
        }
        
        val_35 = val_37;
        label_2:
        label_65:
        label_66:
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = vertex.x, y = vertex.y, z = vertex.z}, b:  new UnityEngine.Vector3() {x = cameraPt.x, y = cameraPt.y, z = cameraPt.z});
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  this.CalculateNorm(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}));
        val_38 = val_3.y;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  V9.16B);
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = vertex.x, y = vertex.y, z = vertex.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        val_39 = this.config.props;
        val_40 = val_5.x;
        val_41 = this.domain;
        float val_6 = S9 + S9;
        val_6 = val_6 / val_39;
        val_42 = val_5.y;
        val_43 = val_5.z;
        val_44 = (int)val_6 + 1;
        if(val_44 < (1.401298E-45f))
        {
                return;
        }
        
        val_37 = 1152921504621436928;
        val_38 = val_39 * val_38;
        val_40 = val_39 * val_3.z;
        label_64:
        val_41 = this.DiscretizeVertex(vertex:  new UnityEngine.Vector3() {x = val_40, y = val_42, z = val_43});
        if((val_41.GenerateIntVector(x:  0, y:  999, z:  0)) == val_41)
        {
            goto label_22;
        }
        
        if((data.tsdfStore.ContainsKey(key:  val_41)) != true)
        {
                data.tsdfStore.set_Item(key:  val_41, value:  new com.illumix.TSDF.Voxel(sdf:  0f, weight:  0f));
        }
        
        com.illumix.TSDF.Voxel val_12 = data.tsdfStore.Item[val_41];
        val_45 = 1f;
        if(this.config.weightSystem != 0)
        {
                float val_31 = ???;
            float val_30 = System.Math.Abs(val_31);
            if(this.config.weightSystem != 1)
        {
                if(val_31 <= 0f)
        {
            goto label_19;
        }
        
        }
        
            val_31 = val_30 / S9;
            val_46 = 1f - val_31;
        }
        
        if(val_12 == null)
        {
            goto label_20;
        }
        
        label_27:
        val_47 = val_12;
        float val_32 = val_12.sdf;
        val_48 = val_12 + 16;
        float val_33 = ???;
        val_32 = val_32 * (val_12 + 16 + 4);
        val_33 = val_33 * val_46;
        val_49 = val_46 + (val_12 + 16 + 4);
        val_32 = val_33 + val_32;
        val_32 = val_32 / val_49;
        mem2[0] = val_32;
        mem2[0] = val_49;
        goto label_21;
        label_19:
        val_31 = val_30 / S9;
        val_50 = System.Math.Min(val1:  val_39, val2:  1f - val_31);
        if(val_12 != null)
        {
            goto label_27;
        }
        
        label_20:
        val_48 = val_12;
        float val_34 = ???;
        float val_15 = (1.68059E-38f) * val_12.weight;
        val_38 = val_38;
        val_42 = val_42;
        val_51 = val_43;
        val_40 = val_40;
        val_34 = val_34 * val_50;
        val_15 = val_34 + val_15;
        val_15 = val_15 / (val_50 + (val_12 + 20));
        mem[16] = val_15;
        val_39 = this.config.props;
        mem2[0] = val_50 + (val_12 + 20);
        val_49 = mem[val_12 + 20];
        val_49 = val_12 + 20;
        val_47 = 16;
        label_21:
        if(val_49 > (float)this.config.maxWeight)
        {
                mem2[0] = (float)this.config.maxWeight;
        }
        
        com.illumix.IntVector3.IntVector3 val_18 = this.domain.GetBlockKey(discretePoint:  val_41);
        val_52 = data.lastUpdatedBlocks;
        if((data.lastUpdatedBlocks.ContainsKey(key:  val_18)) == true)
        {
            goto label_34;
        }
        
        val_53 = this.config;
        if(val_53 == null)
        {
            goto label_35;
        }
        
        val_54 = this.config.blockSize;
        val_55 = val_53;
        goto label_38;
        label_35:
        val_55 = this.config;
        val_54 = this.config.blockSize;
        if(val_55 == null)
        {
            goto label_37;
        }
        
        val_53 = val_55;
        goto label_38;
        label_37:
        val_53 = this.config;
        if(val_53 == null)
        {
            goto label_39;
        }
        
        label_38:
        val_52 = data.lastUpdatedBlocks;
        data.lastUpdatedBlocks.set_Item(key:  val_18, value:  new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean>(capacity:  (this.config.blockSize * val_54) * this.config.blockSize));
        val_33 = val_33;
        val_32 = val_32;
        label_34:
        bool val_23 = data.blocksToUpdateCoords.Add(item:  val_18);
        val_37 = 1152921504621436928;
        if(System.Math.Abs(val_47) <= this.config.props)
        {
                if((val_12 + 20) >= this.config.weightThreshold)
        {
            goto label_48;
        }
        
        }
        
        val_35 = val_41;
        val_34 = val_34;
        if((mem[16].TryGetValue(key:  val_18, value: out  val_25)) == false)
        {
            goto label_62;
        }
        
        val_35 = val_25;
        if((69077560.Contains(item:  val_41)) == false)
        {
            goto label_62;
        }
        
        val_56 = 1152921518993332992;
        val_57 = val_41;
        val_58 = 0;
        goto label_56;
        label_48:
        val_35 = val_41;
        val_34 = val_34;
        if((mem[16].TryGetValue(key:  val_18, value: out  val_25)) == false)
        {
            goto label_59;
        }
        
        val_35 = val_25;
        if((69077560.Contains(item:  val_41)) == true)
        {
            goto label_62;
        }
        
        label_59:
        val_56 = 1152921518993332992;
        val_58 = 1;
        val_57 = val_41;
        label_56:
        data.lastUpdatedBlocks.Item[val_18].set_Item(key:  val_57, value:  true);
        label_62:
        float val_36 = ???;
        val_42 = val_38 + val_42;
        val_59 = val_40 + val_51;
        val_36 = val_36 - val_39;
        float val_37 = val_40;
        val_37 = (val_39 * val_3.x) + val_37;
        label_22:
        val_44 = val_44 - 1;
        if(val_44 != 0)
        {
            goto label_64;
        }
        
        return;
        label_3:
        if(this.config != null)
        {
            goto label_65;
        }
        
        if(this.config != null)
        {
            goto label_66;
        }
        
        label_39:
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Add_FeaturePoints(UnityEngine.Vector3[] points, UnityEngine.Vector3 cameraPosition)
    {
        goto label_0;
        label_4:
        this.UpdateInBand(vertex:  new UnityEngine.Vector3() {x = 8.96831E-44f, y = 0f, z = 1.85775E-36f}, cameraPt:  new UnityEngine.Vector3() {x = cameraPosition.x, y = cameraPosition.y, z = cameraPosition.z}, data:  new TSDF_Data() {tsdfStore = this.domain.data, cachedBlocks = this.domain.data, lastUpdatedBlocks = cameraPosition.x});
        0 = 1;
        label_0:
        if(0 < points.Length)
        {
            goto label_4;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Add_DepthModel_Depth(UnityEngine.Vector3[,] vertices, bool[,] keepMask, UnityEngine.Vector3 cameraPt)
    {
        var val_9;
        var val_10;
        TSDF_Config val_12;
        val_9 = 0;
        goto label_1;
        label_27:
        val_10 = 0;
        goto label_2;
        label_25:
        var val_1 = 0 + (16824064 * 0);
        val_1 = vertices + (val_1 * 12);
        val_12 = this.config;
        if(this.config.useMask == false)
        {
            goto label_7;
        }
        
        val_12 = mem[this.config.useMask + 16];
        val_12 = this.config.useMask + 16;
        if((keepMask[0 + (val_12 * 0)]) == false)
        {
            goto label_22;
        }
        
        label_7:
        if(this.config.useBlockMask == false)
        {
            goto label_13;
        }
        
        com.illumix.IntVector3.IntVector3 val_4 = this.domain.GetBlockKey(discretePoint:  this.DiscretizeVertex(vertex:  new UnityEngine.Vector3() {x = ((16824064 * 0) + 0 * 12) + vertices + 32, y = ((16824064 * 0) + 0 * 12) + vertices + 32 + 4, z = ((16824064 * 0) + 0 * 12) + vertices + 40}));
        if((this.domain.ContainsKey(key:  val_4)) == false)
        {
            goto label_22;
        }
        
        com.illumix.TSDF.VoxelBlock val_6 = this.domain.Item[val_4];
        if(val_6.tsdfCoords.Count == 0)
        {
            goto label_22;
        }
        
        label_13:
        this.UpdateInBand(vertex:  new UnityEngine.Vector3() {x = ((16824064 * 0) + 0 * 12) + vertices + 32, y = ((16824064 * 0) + 0 * 12) + vertices + 32 + 4, z = ((16824064 * 0) + 0 * 12) + vertices + 40}, cameraPt:  new UnityEngine.Vector3() {x = cameraPt.x, y = cameraPt.y, z = cameraPt.z}, data:  new TSDF_Data() {tsdfStore = this.domain.data, cachedBlocks = this.domain.data, lastUpdatedBlocks = ((16824064 * 0) + 0 * 12) + vertices + 32, blocksToUpdateCoords = ((16824064 * 0) + 0 * 12) + vertices + 32, coordsToUpdate = 1152921518993873408});
        label_22:
        val_10 = 1;
        label_2:
        if(val_10 < (vertices.GetLength(dimension:  1)))
        {
            goto label_25;
        }
        
        val_9 = 1;
        label_1:
        if(val_9 < (vertices.GetLength(dimension:  0)))
        {
            goto label_27;
        }
    
    }

}
