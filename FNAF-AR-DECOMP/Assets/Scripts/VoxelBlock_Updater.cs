using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class VoxelBlock_Updater
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private com.illumix.TSDF.TSDF_Manager domain;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TSDF_Config config;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3> seenCubes;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public VoxelBlock_Updater(com.illumix.TSDF.TSDF_Manager tsdfDomain)
    {
        this.seenCubes = new System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>();
        this.domain = tsdfDomain;
        this.config = tsdfDomain.config;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool CompareVectors(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2)
    {
        if(p1.x < 0)
        {
                return true;
        }
        
        if(p1.x > p2.x)
        {
                return false;
        }
        
        if(p1.y < 0)
        {
                return true;
        }
        
        if(p1.y <= p2.y)
        {
                return (bool)(p1.z < 0) ? 1 : 0;
        }
        
        return false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private com.illumix.IntVector3.IntVector3 IdxToVectorPosition(com.illumix.IntVector3.IntVector3 base_vec, int idx)
    {
        if(idx <= 7)
        {
                var val_42 = 52948128 + (idx) << 2;
            val_42 = val_42 + 52948128;
        }
        else
        {
                System.Exception val_41 = new System.Exception(message:  "Invalid idx");
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Vector3 VertexInterpolation(com.illumix.IntVector3.IntVector3 p1, com.illumix.IntVector3.IntVector3 p2, bool isFineResolution)
    {
        com.illumix.IntVector3.IntVector3 val_21;
        com.illumix.TSDF.TSDF_Manager val_22;
        var val_23;
        com.illumix.TSDF.TSDF_Manager val_24;
        float val_25;
        float val_26;
        float val_27;
        var val_28;
        float val_29;
        float val_30;
        float val_31;
        float val_32;
        float val_33;
        float val_34;
        float val_35;
        float val_36;
        float val_37;
        val_21 = p1;
        val_22 = this;
        if((this.domain.data.ContainsKey(key:  val_21)) != false)
        {
                val_23 = (~(this.domain.data.ContainsKey(key:  p2))) & 1;
        }
        else
        {
                val_23 = 1;
        }
        
        UnityEngine.Vector3 val_3 = this.domain.IntVectorToVertexPosition(intVertex:  val_21, resolution:  this.config.props);
        val_24 = this.domain;
        val_25 = val_3.y;
        val_26 = val_3.z;
        UnityEngine.Vector3 val_4 = val_24.IntVectorToVertexPosition(intVertex:  p2, resolution:  this.config.props);
        val_27 = val_4.y;
        if(val_23 == 0)
        {
            goto label_9;
        }
        
        goto label_12;
        label_9:
        val_24 = 1152921518993270528;
        val_21 = this.domain.data.Item[val_21];
        com.illumix.TSDF.Voxel val_6 = this.domain.data.Item[p2];
        float val_20 = val_6.sdf;
        if(val_3.x >= 0)
        {
            goto label_17;
        }
        
        label_30:
        val_28 = 1;
        goto label_32;
        label_17:
        if(val_3.x <= val_4.x)
        {
            goto label_19;
        }
        
        label_31:
        val_28 = 0;
        label_32:
        float val_8 = (val_28 != 0) ? (val_20) : val_5.sdf;
        val_27 = (val_28 != 0) ? (val_25) : (val_27);
        val_32 = val_27;
        val_33 = (val_28 != 0) ? (val_26) : val_4.z;
        val_29 = (val_28 != 0) ? val_5.sdf : (val_20);
        val_22 = this.domain;
        val_20 = val_8 - val_29;
        val_26 = System.Math.Abs(val_20);
        if(val_22 == null)
        {
                val_27 = val_33;
            val_32 = val_32;
            val_36 = (val_28 != 0) ? val_4.z : (val_26);
            val_35 = (val_28 != 0) ? (val_27) : (val_25);
            val_34 = (val_28 != 0) ? val_4.x : val_3.x;
            val_31 = (val_28 != 0) ? val_3.x : val_4.x;
            val_30 = val_8;
            val_33 = val_27;
            val_29 = val_29;
        }
        
        if(val_26 > this.domain.EPSILON)
        {
                val_32 = val_32;
            val_37 = val_36;
            val_33 = val_33;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_31, y = val_32, z = val_33}, b:  new UnityEngine.Vector3() {x = val_34, y = val_35, z = val_37});
            float val_21 = System.Math.Abs(val_30);
            val_21 = W24 - val_21;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  System.Math.Abs(val_21));
            float val_23 = val_29;
            val_23 = val_23 - val_30;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  System.Math.Abs(val_23));
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_34, y = val_35, z = val_37}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
        }
        
        val_26 = val_33;
        val_25 = val_36;
        label_12:
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_34, y = val_35, z = val_25}, b:  new UnityEngine.Vector3() {x = val_31, y = val_32, z = val_26});
        return UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, d:  2f);
        label_19:
        if(val_25 < 0)
        {
            goto label_30;
        }
        
        if(val_25 > val_27)
        {
            goto label_31;
        }
        
        var val_19 = (val_26 < 0) ? 1 : 0;
        goto label_32;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int CubeTypeToTrianglesWithInterpolation(int cubeType, com.illumix.IntVector3.IntVector3 baseVector, out UnityEngine.Vector3[] triangles, bool isFineResolution)
    {
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        com.illumix.IntVector3.IntVector3 val_34;
        com.illumix.IntVector3.IntVector3 val_35;
        com.illumix.IntVector3.IntVector3 val_36;
        com.illumix.IntVector3.IntVector3 val_37;
        com.illumix.IntVector3.IntVector3 val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        val_30 = cubeType;
        mem2[0] = new UnityEngine.Vector3[15];
        UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[12];
        val_31 = 1152921505070956544;
        val_32 = null;
        val_32 = null;
        val_33 = (long)val_30;
        System.Int32[] val_3 = MarchingCubeConstants.edgeTable + (((long)(int)(cubeType)) << 2);
        val_34 = this.IdxToVectorPosition(base_vec:  baseVector, idx:  0);
        com.illumix.IntVector3.IntVector3 val_5 = this.IdxToVectorPosition(base_vec:  baseVector, idx:  1);
        com.illumix.IntVector3.IntVector3 val_6 = this.IdxToVectorPosition(base_vec:  baseVector, idx:  2);
        val_35 = this.IdxToVectorPosition(base_vec:  baseVector, idx:  3);
        com.illumix.IntVector3.IntVector3 val_8 = this.IdxToVectorPosition(base_vec:  baseVector, idx:  4);
        com.illumix.IntVector3.IntVector3 val_9 = this.IdxToVectorPosition(base_vec:  baseVector, idx:  5);
        com.illumix.IntVector3.IntVector3 val_10 = this.IdxToVectorPosition(base_vec:  baseVector, idx:  6);
        val_36 = baseVector;
        com.illumix.IntVector3.IntVector3 val_11 = this.IdxToVectorPosition(base_vec:  val_36, idx:  7);
        if((((MarchingCubeConstants.edgeTable + ((long)(int)(cubeType)) << 2) + 32) & 1) != 0)
        {
            goto label_5;
        }
        
        if((((MarchingCubeConstants.edgeTable + ((long)(int)(cubeType)) << 2) + 32) & 2) != 0)
        {
            goto label_6;
        }
        
        label_20:
        if((((MarchingCubeConstants.edgeTable + ((long)(int)(cubeType)) << 2) + 32) & 4) != 0)
        {
            goto label_7;
        }
        
        label_23:
        if((((MarchingCubeConstants.edgeTable + ((long)(int)(cubeType)) << 2) + 32) & 8) != 0)
        {
            goto label_8;
        }
        
        label_26:
        if((((MarchingCubeConstants.edgeTable + ((long)(int)(cubeType)) << 2) + 32) & 16) != 0)
        {
            goto label_9;
        }
        
        label_29:
        if((((MarchingCubeConstants.edgeTable + ((long)(int)(cubeType)) << 2) + 32) & 32) != 0)
        {
            goto label_10;
        }
        
        label_32:
        if((((MarchingCubeConstants.edgeTable + ((long)(int)(cubeType)) << 2) + 32) & 64) != 0)
        {
            goto label_11;
        }
        
        label_35:
        if((((MarchingCubeConstants.edgeTable + ((long)(int)(cubeType)) << 2) + 32) & 128) != 0)
        {
            goto label_12;
        }
        
        label_38:
        if((((MarchingCubeConstants.edgeTable + ((long)(int)(cubeType)) << 2) + 32) & 256) != 0)
        {
            goto label_13;
        }
        
        label_41:
        if((((MarchingCubeConstants.edgeTable + ((long)(int)(cubeType)) << 2) + 32) & 512) != 0)
        {
            goto label_14;
        }
        
        label_44:
        if((((MarchingCubeConstants.edgeTable + ((long)(int)(cubeType)) << 2) + 32) & 1024) != 0)
        {
            goto label_15;
        }
        
        label_47:
        if((((MarchingCubeConstants.edgeTable + ((long)(int)(cubeType)) << 2) + 32) & 2048) != 0)
        {
            goto label_16;
        }
        
        label_50:
        UnityEngine.Vector3[] val_30 = val_2;
        val_30 = val_30 + 24;
        goto label_17;
        label_5:
        UnityEngine.Vector3 val_12 = this.VertexInterpolation(p1:  val_34, p2:  val_5, isFineResolution:  false);
        mem[1152921518995930784] = val_12.x;
        mem[1152921518995930788] = val_12.y;
        mem[1152921518995930792] = val_12.z;
        if((((MarchingCubeConstants.edgeTable + ((long)(int)(cubeType)) << 2) + 32) & 2) == 0)
        {
            goto label_20;
        }
        
        label_6:
        UnityEngine.Vector3 val_13 = this.VertexInterpolation(p1:  val_5, p2:  val_30, isFineResolution:  false);
        mem[1152921518995930796] = val_13.x;
        mem[1152921518995930800] = val_13.y;
        mem[1152921518995930804] = val_13.z;
        if((((MarchingCubeConstants.edgeTable + ((long)(int)(cubeType)) << 2) + 32) & 4) == 0)
        {
            goto label_23;
        }
        
        label_7:
        UnityEngine.Vector3 val_14 = this.VertexInterpolation(p1:  val_30, p2:  val_35, isFineResolution:  false);
        mem[1152921518995930808] = val_14.x;
        mem[1152921518995930812] = val_14.y;
        mem[1152921518995930816] = val_14.z;
        if((((MarchingCubeConstants.edgeTable + ((long)(int)(cubeType)) << 2) + 32) & 8) == 0)
        {
            goto label_26;
        }
        
        label_8:
        UnityEngine.Vector3 val_15 = this.VertexInterpolation(p1:  val_35, p2:  val_34, isFineResolution:  false);
        mem[1152921518995930820] = val_15.x;
        mem[1152921518995930824] = val_15.y;
        mem[1152921518995930828] = val_15.z;
        if((((MarchingCubeConstants.edgeTable + ((long)(int)(cubeType)) << 2) + 32) & 16) == 0)
        {
            goto label_29;
        }
        
        label_9:
        UnityEngine.Vector3 val_16 = this.VertexInterpolation(p1:  val_8, p2:  val_9, isFineResolution:  false);
        mem[1152921518995930832] = val_16.x;
        mem[1152921518995930836] = val_16.y;
        mem[1152921518995930840] = val_16.z;
        if((((MarchingCubeConstants.edgeTable + ((long)(int)(cubeType)) << 2) + 32) & 32) == 0)
        {
            goto label_32;
        }
        
        label_10:
        UnityEngine.Vector3 val_17 = this.VertexInterpolation(p1:  val_9, p2:  val_10, isFineResolution:  false);
        mem[1152921518995930844] = val_17.x;
        mem[1152921518995930848] = val_17.y;
        mem[1152921518995930852] = val_17.z;
        if((((MarchingCubeConstants.edgeTable + ((long)(int)(cubeType)) << 2) + 32) & 64) == 0)
        {
            goto label_35;
        }
        
        label_11:
        UnityEngine.Vector3 val_18 = this.VertexInterpolation(p1:  val_10, p2:  val_11, isFineResolution:  false);
        mem[1152921518995930856] = val_18.x;
        mem[1152921518995930860] = val_18.y;
        mem[1152921518995930864] = val_18.z;
        if((((MarchingCubeConstants.edgeTable + ((long)(int)(cubeType)) << 2) + 32) & 128) == 0)
        {
            goto label_38;
        }
        
        label_12:
        UnityEngine.Vector3 val_19 = this.VertexInterpolation(p1:  val_11, p2:  val_8, isFineResolution:  false);
        mem[1152921518995930868] = val_19.x;
        mem[1152921518995930872] = val_19.y;
        mem[1152921518995930876] = val_19.z;
        if((((MarchingCubeConstants.edgeTable + ((long)(int)(cubeType)) << 2) + 32) & 256) == 0)
        {
            goto label_41;
        }
        
        label_13:
        val_37 = val_34;
        UnityEngine.Vector3 val_20 = this.VertexInterpolation(p1:  val_37, p2:  val_8, isFineResolution:  false);
        if(mem[1152921518995930776] <= 8)
        {
                val_37 = 0;
        }
        
        mem[1152921518995930880] = val_20.x;
        mem[1152921518995930884] = val_20.y;
        mem[1152921518995930888] = val_20.z;
        if((((MarchingCubeConstants.edgeTable + ((long)(int)(cubeType)) << 2) + 32) & 512) == 0)
        {
            goto label_44;
        }
        
        label_14:
        val_38 = val_5;
        UnityEngine.Vector3 val_21 = this.VertexInterpolation(p1:  val_38, p2:  val_9, isFineResolution:  false);
        if(mem[1152921518995930776] <= 9)
        {
                val_38 = 0;
        }
        
        mem[1152921518995930892] = val_21.x;
        mem[1152921518995930896] = val_21.y;
        mem[1152921518995930900] = val_21.z;
        if((((MarchingCubeConstants.edgeTable + ((long)(int)(cubeType)) << 2) + 32) & 1024) == 0)
        {
            goto label_47;
        }
        
        label_15:
        UnityEngine.Vector3 val_22 = this.VertexInterpolation(p1:  val_30, p2:  val_10, isFineResolution:  false);
        mem[1152921518995930904] = val_22.x;
        mem[1152921518995930908] = val_22.y;
        mem[1152921518995930912] = val_22.z;
        if((((MarchingCubeConstants.edgeTable + ((long)(int)(cubeType)) << 2) + 32) & 2048) == 0)
        {
            goto label_50;
        }
        
        label_16:
        UnityEngine.Vector3 val_23 = this.VertexInterpolation(p1:  val_35, p2:  val_11, isFineResolution:  false);
        mem[1152921518995930916] = val_23.x;
        mem[1152921518995930920] = val_23.y;
        mem[1152921518995930924] = val_23.z;
        label_17:
        val_39 = 0;
        goto label_53;
        label_68:
        val_40 = null;
        val_40 = null;
        val_41 = mem[MarchingCubeConstants.triTable + 16];
        val_41 = MarchingCubeConstants.triTable + 16;
        val_35 = val_30;
        if(val_41 <= val_30)
        {
                val_41 = mem[MarchingCubeConstants.triTable + 16];
            val_41 = MarchingCubeConstants.triTable + 16;
        }
        
        var val_24 = val_11 + ((MarchingCubeConstants.triTable + 16 + 16) * val_33);
        System.Int32[,] val_25 = MarchingCubeConstants.triTable + (((MarchingCubeConstants.triTable + 16 + 16 * (long)(int)(cubeType)) + val_11) << 2);
        val_34 = val_33;
        var val_26 = val_2 + (((MarchingCubeConstants.triTable + ((MarchingCubeConstants.triTable + 16 + 16 * (long)(int)(cubeType)) + val_11) << 2) + 32) * 12);
        com.illumix.IntVector3.IntVector3 val_27 = triangles + (val_11 * 12);
        mem2[0] = ((MarchingCubeConstants.triTable + ((MarchingCubeConstants.triTable + 16 + 16 * (long)(int)(cubeType)) + val_11) << 2) + 32 * 12) + val_2 + 32;
        mem2[0] = ((MarchingCubeConstants.triTable + ((MarchingCubeConstants.triTable + 16 + 16 * (long)(int)(cubeType)) + val_11) << 2) + 32 * 12) + val_2 + 32 + 4;
        mem2[0] = ((MarchingCubeConstants.triTable + ((MarchingCubeConstants.triTable + 16 + 16 * (long)(int)(cubeType)) + val_11) << 2) + 32 * 12) + val_2 + 40;
        val_39 = 1;
        val_30 = val_35;
        val_31 = val_31;
        val_33 = val_34;
        label_53:
        val_42 = null;
        val_43 = mem[MarchingCubeConstants.triTable + 16];
        val_43 = MarchingCubeConstants.triTable + 16;
        if(val_43 <= val_30)
        {
                val_43 = mem[MarchingCubeConstants.triTable + 16];
            val_43 = MarchingCubeConstants.triTable + 16;
        }
        
        var val_28 = 1 + ((MarchingCubeConstants.triTable + 16 + 16) * val_33);
        System.Int32[,] val_29 = MarchingCubeConstants.triTable + (((MarchingCubeConstants.triTable + 16 + 16 * (long)(int)(cubeType)) + 1) << 2);
        if(((MarchingCubeConstants.triTable + ((MarchingCubeConstants.triTable + 16 + 16 * (long)(int)(cubeType)) + 1) << 2) + 32) != 1)
        {
            goto label_68;
        }
        
        return (int)val_39;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void CubeTypeToTriangles(int cubeType, com.illumix.IntVector3.IntVector3 baseVector, float resolution, com.illumix.TSDF.VoxelBlock block)
    {
        com.illumix.TSDF.VoxelBlock val_25;
        com.illumix.IntVector3.IntVector3 val_26;
        int val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        int val_33;
        var val_34;
        var val_35;
        val_25 = block;
        val_26 = baseVector;
        val_27 = cubeType;
        val_28 = 1152921505070956544;
        val_29 = 0;
        val_30 = (long)val_27;
        goto label_1;
        label_33:
        val_31 = null;
        val_31 = null;
        val_32 = mem[MarchingCubeConstants.triTable + 16];
        val_32 = MarchingCubeConstants.triTable + 16;
        if(val_32 <= val_27)
        {
                val_32 = mem[MarchingCubeConstants.triTable + 16];
            val_32 = MarchingCubeConstants.triTable + 16;
        }
        
        var val_1 = X22 + ((MarchingCubeConstants.triTable + 16 + 16) * val_30);
        System.Int32[,] val_2 = MarchingCubeConstants.triTable + (((MarchingCubeConstants.triTable + 16 + 16 * (long)(int)(cubeType)) + X22) << 2);
        com.illumix.IntVector3.IntVector3[] val_3 = MarchingCubeConstants.edgeIdxToCoords + (((MarchingCubeConstants.triTable + ((MarchingCubeConstants.triTable + 16 + 16 * (long)(int)(cubeType)) + X22) << 2) + 32) << 3);
        UnityEngine.Vector3 val_14 = this.domain.IntVectorToVertexPosition(intVertex:  this.domain.GenerateIntVector(x:  ((MarchingCubeConstants.edgeIdxToCoords + ((MarchingCubeConstants.triTable + ((MarchingCubeConstants.triTable + 16 + 16 * (long)(int)(cubeType)) + X22) << 2) + 32) << 3) + 32.Item1) + val_26.Item1, y:  ((MarchingCubeConstants.edgeIdxToCoords + ((MarchingCubeConstants.triTable + ((MarchingCubeConstants.triTable + 16 + 16 * (long)(int)(cubeType)) + X22) << 2) + 32) << 3) + 32.Item2) + val_26.Item2, z:  ((MarchingCubeConstants.edgeIdxToCoords + ((MarchingCubeConstants.triTable + ((MarchingCubeConstants.triTable + 16 + 16 * (long)(int)(cubeType)) + X22) << 2) + 32) << 3) + 32.Item3) + val_26.Item3), resolution:  resolution);
        val_25 = val_25;
        val_27 = val_27;
        val_30 = val_30;
        val_26 = val_26;
        val_28 = 1152921505070956544;
        if((block + 24.ContainsKey(key:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z})) != true)
        {
                if((block + 24) != 0)
        {
                val_33 = block + 24.Count;
        }
        else
        {
                val_33 = block + 24.Count;
        }
        
            block + 24.set_Item(key:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, value:  val_33);
            block + 16.Add(item:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        }
        
        if(val_29 == 0)
        {
                block + 32.set_Item(key:  val_26, value:  new System.Collections.Generic.List<System.Int32>());
        }
        
        block + 32.Item[val_26].Add(item:  block + 24.Item[new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}]);
        val_29 = val_29 + 1;
        label_1:
        val_34 = null;
        val_35 = mem[MarchingCubeConstants.triTable + 16];
        val_35 = MarchingCubeConstants.triTable + 16;
        if(val_35 <= val_27)
        {
                val_35 = mem[MarchingCubeConstants.triTable + 16];
            val_35 = MarchingCubeConstants.triTable + 16;
        }
        
        var val_21 = (long)val_29 + ((MarchingCubeConstants.triTable + 16 + 16) * val_30);
        System.Int32[,] val_22 = MarchingCubeConstants.triTable + (((MarchingCubeConstants.triTable + 16 + 16 * (long)(int)(cubeType)) + (long)(int)((val_29 + 1))) << 2);
        if(((MarchingCubeConstants.triTable + ((MarchingCubeConstants.triTable + 16 + 16 * (long)(int)(cubeType)) + (long)(int)((val_29 + 1))) << 2) + 32) != 1)
        {
            goto label_33;
        }
        
        if(val_29 != 0)
        {
                return;
        }
        
        val_29 = mem[block + 32];
        val_29 = block + 32;
        if((val_29.ContainsKey(key:  val_26)) == false)
        {
                return;
        }
        
        bool val_24 = block + 32.Remove(key:  val_26);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void UpdateTriangles()
    {
        com.illumix.TSDF.TSDF_Manager val_42;
        com.illumix.IntVector3.IntVector3 val_43;
        int val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        com.illumix.IntVector3.IntVector3 val_49;
        System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3> val_50;
        var val_52;
        var val_53;
        int val_28 = 0;
        int val_29 = 0;
        val_42 = this.domain;
        if(this.domain != null)
        {
            goto label_1;
        }
        
        val_42 = this.domain;
        if(val_42 == null)
        {
            goto label_2;
        }
        
        label_1:
        val_44 = val_42.Count;
        int val_2 = System.Math.Min(val1:  this.config.maxCoordsToUpdate, val2:  val_44);
        if(val_2 < 1)
        {
            goto label_58;
        }
        
        val_45 = X23 >> 32;
        label_57:
        if(val_42 != 0)
        {
                val_46 = val_42.Count;
        }
        else
        {
                val_46 = val_42.Count;
        }
        
        CoordUpdate val_6 = val_42.Item[val_46 + 0];
        if(val_6.isSeparator == false)
        {
            goto label_12;
        }
        
        this.seenCubes.Clear();
        goto label_14;
        label_12:
        val_43 = val_6.coord;
        val_47 = 0;
        label_56:
        com.illumix.IntVector3.IntVector3 val_7 = this.IdxToVectorPosition(base_vec:  val_43, idx:  0);
        com.illumix.IntVector3.IntVector3 val_8 = this.domain.GetBlockKey(discretePoint:  val_7);
        if((X22.ContainsKey(key:  val_8)) != true)
        {
                X22.set_Item(key:  val_8, value:  this.domain.MakeNewVoxelBlock());
        }
        
        if((this.seenCubes.Contains(item:  val_7)) == true)
        {
            goto label_22;
        }
        
        bool val_13 = this.domain.blocksUpdated.Add(item:  val_8);
        val_48 = null;
        val_48 = null;
        int val_14 = MarchingCubeConstants.InverseEdge.Item[0];
        val_49 = val_7;
        int val_15 = val_14 & 31;
        var val_45 = 1;
        val_15 = val_45 << val_15;
        label_54:
        int val_17 = val_14 + val_45;
        var val_19 = (val_17 < 0) ? (val_17 + 7) : (val_17);
        val_19 = val_19 & 4294967288;
        int val_20 = val_17 - val_19;
        com.illumix.IntVector3.IntVector3 val_21 = this.IdxToVectorPosition(base_vec:  val_49, idx:  val_20);
        com.illumix.IntVector3.IntVector3 val_22 = this.domain.GetBlockKey(discretePoint:  val_21);
        if((X22.ContainsKey(key:  val_22)) == false)
        {
            goto label_43;
        }
        
        com.illumix.TSDF.VoxelBlock val_24 = X22.Item[val_22];
        bool val_25 = this.domain.blocksUpdated.Add(item:  val_22);
        if(val_45 == 0)
        {
            goto label_34;
        }
        
        if(val_45 == 1)
        {
            goto label_35;
        }
        
        val_49 = val_7;
        if(val_45 != 2)
        {
            goto label_43;
        }
        
        val_50 = val_24.tsdfCoords;
        if(val_50 != null)
        {
            goto label_41;
        }
        
        goto label_39;
        label_35:
        val_49 = val_7;
        val_50 = val_24.smoothedTsdfCoords;
        if(val_50 != null)
        {
            goto label_41;
        }
        
        label_39:
        label_41:
        if((val_50.Contains(item:  val_21)) == false)
        {
            goto label_43;
        }
        
        int val_27 = val_20 & 31;
        val_27 = 1 << val_27;
        int val_41 = (val_6.isAdd == false) ? 0 : (val_15);
        val_41 = val_27 | val_41;
        goto label_43;
        label_34:
        this.domain.GetColumnPos(coord:  val_21, blockKey:  val_22, x: out  val_28, z: out  val_29);
        val_49 = val_7;
        if((val_24.isTileLayer[(long)this.domain.GetLayerPos(coord:  val_21, blockKey:  val_22)]) == true)
        {
            goto label_49;
        }
        
        val_49 = val_7;
        if((val_24.isColumn[val_29 + ((val_24.isTileLayer[(long)(int)(val_30)][0] + 16) * val_28)]) == false)
        {
            goto label_53;
        }
        
        label_49:
        int val_32 = val_20 & 31;
        val_32 = 1 << val_32;
        int val_44 = val_41;
        val_44 = val_32 | val_44;
        label_53:
        val_45 = val_45;
        label_43:
        val_45 = val_45 + 1;
        if(val_45 != 8)
        {
            goto label_54;
        }
        
        this.CubeTypeToTriangles(cubeType:  val_44, baseVector:  val_49, resolution:  this.domain.config.props, block:  X22.Item[val_8]);
        bool val_33 = this.seenCubes.Add(item:  val_49);
        val_43 = val_43;
        val_47 = val_47;
        label_22:
        val_47 = val_47 + 1;
        if(val_47 != 8)
        {
            goto label_56;
        }
        
        label_14:
        var val_46 = 0;
        val_44 = val_42;
        val_46 = val_46 + 1;
        if(val_46 != val_2)
        {
            goto label_57;
        }
        
        if(val_2 >= 1)
        {
                val_43 = 1152921518996388640;
            var val_47 = -val_2;
            do
        {
            if(val_42 != 0)
        {
                val_52 = val_42.Count;
        }
        else
        {
                val_52 = val_42.Count;
        }
        
            this.domain.coordsToUpdatePool.Enqueue(item:  val_42.Item[val_52 + val_47]);
            val_47 = val_47 + 1;
        }
        while(val_47 != 0);
        
            val_44 = val_42;
            if(val_44 != 0)
        {
                val_53 = val_44.Count;
        }
        else
        {
                val_53 = val_44.Count;
        }
        
            val_44.RemoveRange(index:  val_53 - val_2, count:  val_2);
        }
        
        label_58:
        this.seenCubes.Clear();
        return;
        label_2:
    }

}
