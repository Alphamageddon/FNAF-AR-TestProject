using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class SurfaceVerticesUpdater
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private com.illumix.TSDF.TSDF_Manager domain;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TSDF_Config config;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float NEIGHBOR_WEIGHT;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SurfaceVerticesUpdater(com.illumix.TSDF.TSDF_Manager tsdfDomain)
    {
        this.NEIGHBOR_WEIGHT = 0.25f;
        this.domain = tsdfDomain;
        this.config = tsdfDomain.config;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void UpdateVertices()
    {
        System.Collections.Generic.List<com.illumix.IntVector3.IntVector3> val_1 = this.UpdateCachedBlocks();
        if(W8 != 0)
        {
                if(W8 != 1)
        {
                return;
        }
        
            this.SmoothPostprocessing(blocksProcessed:  val_1);
            return;
        }
        
        this.TilePostprocessing(blocksProcessed:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<com.illumix.IntVector3.IntVector3> UpdateCachedBlocks()
    {
        int val_4;
        object val_25;
        var val_75;
        com.illumix.IntVector3.IntVector3 val_76;
        GameUI.EmailUIDataHandler val_77;
        GameUI.EmailUIDataHandler val_78;
        GameUI.EmailUIDataHandler val_79;
        var val_80;
        var val_81;
        var val_82;
        var val_83;
        var val_84;
        var val_85;
        var val_90;
        var val_91;
        var val_92;
        int val_58 = 0;
        int val_59 = 0;
        int val_62 = 0;
        System.Collections.Generic.List<com.illumix.IntVector3.IntVector3> val_1 = new System.Collections.Generic.List<com.illumix.IntVector3.IntVector3>();
        HashSet.Enumerator<T> val_2 = X23.GetEnumerator();
        val_75 = 1152921518981975376;
        val_76 = 0;
        com.illumix.TSDF.TSDF_Manager val_5 = this.domain & (-4294967296);
        label_416:
        if((1490489568 & 1) == 0)
        {
            goto label_5;
        }
        
        GameUI.EmailUIDataHandler val_6 = val_4.emailUIDataHandler;
        System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean> val_7 = X21.Item[val_6];
        if((X27.ContainsKey(key:  val_6)) != true)
        {
                X27.set_Item(key:  val_6, value:  this.domain.MakeNewVoxelBlock());
        }
        
        int val_12 = val_7.Keys.Count;
        Dictionary.KeyCollection<TKey, TValue> val_13 = val_7.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_14 = val_13.GetEnumerator();
        label_274:
        val_77 = val_6;
        goto label_268;
        label_261:
        object[] val_16 = new object[14];
        val_16[0] = "layer pos ";
        val_4 = val_12;
        val_16[1] = val_4;
        val_16[2] = " coord1 ";
        val_16[3] = val_13.Item1;
        val_16[4] = " coord2 ";
        val_16[5] = val_13.Item2;
        val_16[6] = " coord3 ";
        val_16[7] = val_13.Item3;
        val_16[8] = " block1 ";
        val_16[9] = val_6.Item1;
        val_16[10] = " block2 ";
        val_16[11] = val_6.Item2;
        val_16[12] = " block3 ";
        val_78 = val_6;
        val_16[13] = val_78.Item3;
        ConsoleLogger.LogError(className:  "TSDF", functionName:  "UpdateVerticesAndTriangles", logString:  +val_16);
        val_75 = 1152921518981975376;
        goto label_69;
        label_265:
        object[] val_24 = new object[14];
        val_24[0] = "layer pos ";
        val_4 = val_25;
        val_24[1] = val_4;
        val_24[2] = " coord1 ";
        val_24[3] = val_13.Item1;
        val_24[4] = " coord2 ";
        val_24[5] = val_13.Item2;
        val_24[6] = " coord3 ";
        val_24[7] = val_13.Item3;
        val_24[8] = " block1 ";
        val_24[9] = val_6.Item1;
        val_24[10] = " block2 ";
        val_24[11] = val_6.Item2;
        val_24[12] = " block3 ";
        val_24[13] = val_6.Item3;
        ConsoleLogger.LogError(className:  "TSDF", functionName:  "UpdateVerticesAndTriangles", logString:  +val_24);
        val_75 = 1152921518981975376;
        goto label_121;
        label_248:
        object[] val_33 = new object[14];
        val_33[0] = "layer pos ";
        val_4 = val_12;
        val_33[1] = val_4;
        val_33[2] = " coord1 ";
        val_33[3] = val_13.Item1;
        val_33[4] = " coord2 ";
        val_33[5] = val_13.Item2;
        val_33[6] = " coord3 ";
        val_33[7] = val_13.Item3;
        val_33[8] = " block1 ";
        val_33[9] = val_6.Item1;
        val_33[10] = " block2 ";
        val_33[11] = val_6.Item2;
        val_33[12] = " block3 ";
        val_79 = val_6;
        val_33[13] = val_79.Item3;
        ConsoleLogger.LogError(className:  "TSDF", functionName:  "UpdateVerticesAndTriangles", logString:  +val_33);
        goto label_173;
        label_254:
        object[] val_41 = new object[14];
        val_41[0] = "layer pos ";
        val_4 = val_12;
        val_41[1] = val_4;
        val_41[2] = " coord1 ";
        val_41[3] = val_13.Item1;
        val_41[4] = " coord2 ";
        val_41[5] = val_13.Item2;
        val_41[6] = " coord3 ";
        val_41[7] = val_13.Item3;
        val_41[8] = " block1 ";
        val_41[9] = val_6.Item1;
        val_41[10] = " block2 ";
        val_41[11] = val_6.Item2;
        val_41[12] = " block3 ";
        val_41[13] = val_6.Item3;
        ConsoleLogger.LogError(className:  "TSDF", functionName:  "UpdateVerticesAndTriangles", logString:  +val_41);
        val_80 = val_58;
        val_81 = val_59;
        goto label_225;
        label_268:
        if((1490489536 & 1) == 0)
        {
            goto label_226;
        }
        
        GameUI.EmailUIDataHandler val_49 = val_4.emailUIDataHandler;
        if(val_7.Item[val_49] == false)
        {
            goto label_228;
        }
        
        if(val_5 != 8589934592)
        {
            goto label_229;
        }
        
        if((val_10 + 40.Add(item:  val_49)) == false)
        {
            goto label_268;
        }
        
        Add(item:  this.domain.GenerateTuple(coord:  val_49, isAdd:  true, isSeparator:  false));
        goto label_235;
        label_228:
        if(val_5 != 8589934592)
        {
            goto label_236;
        }
        
        if((val_10 + 40.Remove(item:  val_49)) == false)
        {
            goto label_268;
        }
        
        Add(item:  this.domain.GenerateTuple(coord:  val_49, isAdd:  false, isSeparator:  false));
        label_235:
        var val_74 = 0;
        val_74 = val_74 + 1;
        goto label_268;
        label_229:
        if((val_10 + 40.Add(item:  val_49)) == false)
        {
            goto label_268;
        }
        
        var val_75 = val_10 + 96;
        val_75 = val_75 + 1;
        mem2[0] = val_75;
        int val_56 = this.domain.GetLayerPos(coord:  val_49, blockKey:  val_77);
        if(((val_56 & 2147483648) != 0) || (val_56 >= this.config.blockSize))
        {
            goto label_248;
        }
        
        label_173:
        var val_57 = (val_10 + 72) + (((long)(int)(val_56)) << 2);
        var val_76 = (val_10 + 72 + ((long)(int)(val_56)) << 2) + 32;
        val_76 = val_76 + 1;
        mem2[0] = val_76;
        this.domain.GetColumnPos(coord:  val_49, blockKey:  val_77, x: out  val_58, z: out  val_59);
        val_81 = val_59;
        if(0 >= this.config.blockSize)
        {
            goto label_254;
        }
        
        val_80 = val_58;
        if((0 >= this.config.blockSize) || ((0 & 2147483648) != 0))
        {
            goto label_254;
        }
        
        label_225:
        val_82 = mem[val_10 + 88 + 16];
        val_82 = val_10 + 88 + 16;
        if(val_80 >= val_82)
        {
                val_82 = mem[val_10 + 88 + 16];
            val_82 = val_10 + 88 + 16;
        }
        
        long val_77 = 0;
        val_77 = 0 + ((val_10 + 88 + 16 + 16) * val_77);
        var val_60 = (val_10 + 88) + (((val_10 + 88 + 16 + 16 * 0) + 0) << 2);
        var val_78 = (val_10 + 88 + ((val_10 + 88 + 16 + 16 * 0) + 0) << 2) + 32;
        val_78 = val_78 + 1;
        mem2[0] = val_78;
        goto label_268;
        label_236:
        int val_61 = this.domain.GetLayerPos(coord:  val_49, blockKey:  val_77);
        if(((val_61 & 2147483648) != 0) || (val_61 >= this.config.blockSize))
        {
            goto label_261;
        }
        
        label_69:
        val_25 = val_61;
        this.domain.GetColumnPos(coord:  val_49, blockKey:  val_77, x: out  val_62, z: out  val_62);
        if(((0 >= this.config.blockSize) || (0 >= this.config.blockSize)) || ((0 & 2147483648) != 0))
        {
            goto label_265;
        }
        
        label_121:
        if((val_10 + 40.Remove(item:  val_49)) == false)
        {
            goto label_268;
        }
        
        var val_79 = val_10 + 96;
        val_79 = val_79 + 1;
        mem2[0] = val_79;
        var val_64 = (val_10 + 72) + (((long)(int)(val_61)) << 2);
        var val_80 = (val_10 + 72 + ((long)(int)(val_61)) << 2) + 32;
        val_80 = val_80 - 1;
        mem2[0] = val_80;
        val_83 = mem[val_10 + 88 + 16];
        val_83 = val_10 + 88 + 16;
        if(val_59 >= val_83)
        {
                val_83 = mem[val_10 + 88 + 16];
            val_83 = val_10 + 88 + 16;
        }
        
        var val_65 = 0 + ((val_10 + 88 + 16 + 16) * val_59);
        var val_66 = (val_10 + 88) + (((val_10 + 88 + 16 + 16 * val_59) + 0) << 2);
        var val_81 = (val_10 + 88 + ((val_10 + 88 + 16 + 16 * val_59) + 0) << 2) + 32;
        val_81 = val_81 - 1;
        mem2[0] = val_81;
        goto label_274;
        label_226:
        val_84 = ???;
        val_76 = val_76;
        val_85 = 1413;
        long val_67 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921518982238400});
        if((( == 0) ? 1413 : ()) != 1413)
        {
            goto label_410;
        }
        
        if( != 0)
        {
            goto label_414;
        }
        
        goto label_412;
        label_410:
        val_76 = 0;
        if( != 0)
        {
            goto label_414;
        }
        
        label_412:
        label_414:
        set_Item(key:  val_77, value:  X27.Item[val_6]);
        val_1.Add(item:  val_77);
        if((this.config.maxCoordsToUpdate - 0) >= val_12)
        {
            goto label_416;
        }
        
        label_5:
        val_90 = 0;
        val_91 = 1466;
        long val_69 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921518982238432});
        val_92 = 0;
        goto label_435;
        label_442:
        val_76 = val_1.Item[0];
        X21.Item[val_76].Clear();
        bool val_72 = this.domain.Remove(item:  val_76);
        val_92 = 1;
        label_435:
        if(val_92 < val_1.Count)
        {
            goto label_442;
        }
        
        return val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 GetTileCenter(com.illumix.IntVector3.IntVector3 blockKey, int blockSize, int layer_idx, float resolution)
    {
        var val_12;
        var val_13;
        com.illumix.IntVector3.IntVector3 val_1 = this.domain.BlockKeyToResolutionSpace(blockKey:  blockKey);
        if(val_1 != null)
        {
                val_12 = val_1.Item1;
            val_13 = val_1.Item2;
        }
        else
        {
                val_12 = 0.Item1;
            val_13 = 0.Item2;
        }
        
        int val_7 = blockSize - 1;
        if(this.domain != null)
        {
                return this.domain.IntVectorToVertexPosition(intVertex:  this.domain.GenerateIntVector(x:  val_7 + val_12, y:  val_13 + (layer_idx << 1), z:  val_7 + val_1.Item3), resolution:  resolution);
        }
        
        return this.domain.IntVectorToVertexPosition(intVertex:  this.domain.GenerateIntVector(x:  val_7 + val_12, y:  val_13 + (layer_idx << 1), z:  val_7 + val_1.Item3), resolution:  resolution);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void TilePostprocessing(System.Collections.Generic.List<com.illumix.IntVector3.IntVector3> blocksProcessed)
    {
        System.Collections.Generic.List<com.illumix.IntVector3.IntVector3> val_37;
        SurfaceVerticesUpdater val_38;
        var val_39;
        com.illumix.TSDF.TSDF_Manager val_40;
        var val_41;
        var val_45;
        var val_46;
        System.Boolean[,] val_47;
        var val_51;
        var val_52;
        com.illumix.IntVector3.IntVector3 val_53;
        val_37 = blocksProcessed;
        val_38 = this;
        val_41 = 0;
        goto label_3;
        label_72:
        com.illumix.IntVector3.IntVector3 val_1 = val_37.Item[0];
        com.illumix.TSDF.VoxelBlock val_2 = X23.Item[val_1];
        if(this.config.blockSize < 1)
        {
            goto label_6;
        }
        
        var val_44 = 0;
        label_23:
        if(val_2.isTileLayer[val_44] == true)
        {
            goto label_14;
        }
        
        int val_39 = val_2.layerwiseCounts[val_44];
        float val_40 = this.config.thresholdTileLayerRatio;
        val_40 = val_40 * (float)this.config.blockSize;
        val_40 = val_40 * (float)this.config.blockSize;
        if(val_40 >= 0)
        {
            goto label_14;
        }
        
        this.AddTile(blockKey:  val_1, block:  val_2, layer_idx:  0);
        goto label_22;
        label_14:
        if(val_2.isTileLayer[val_44] != false)
        {
                float val_43 = this.config.thresholdTileDropLayerRatio;
            val_43 = val_43 * (float)this.config.blockSize;
            val_43 = val_43 * (float)this.config.blockSize;
            if(val_43 >= (float)val_2.layerwiseCounts[val_44])
        {
                this.ClearLayer(blockKey:  val_1, block:  val_2, layer_idx:  0);
        }
        
        }
        
        label_22:
        val_44 = val_44 + 1;
        if(this.config.blockSize != val_44)
        {
            goto label_23;
        }
        
        label_6:
        val_40 = this.domain;
        if((this.config.showColumns != false) && (this.config.blockSize >= 1))
        {
                var val_53 = 0;
            do
        {
            if(this.config.blockSize >= 1)
        {
                var val_52 = 0;
            do
        {
            if((val_2.isColumn[val_52 + ((this.config.showColumns + 16) * val_53)]) != true)
        {
                int val_46 = val_2.columnwiseCounts[val_52 + ((val_2.isColumn[(this.config.showColumns + 16 * 0) + 0][0] + 16) * val_53)];
            float val_47 = this.config.thresholdColumnRatio;
            val_47 = val_47 * (float)this.config.blockSize;
            if(val_47 < 0)
        {
                var val_48 = 0;
            val_2.isColumn[val_52 + (val_44 * val_53)] = true;
            do
        {
            if(val_1 != null)
        {
                val_45 = val_1.Item1;
            val_46 = val_1.Item2;
        }
        else
        {
                val_45 = val_1.Item1;
            val_46 = val_1.Item2;
        }
        
            val_38 = val_38;
            this.domain.Add(item:  this.domain.GenerateTuple(coord:  this.domain.GenerateIntVector(x:  (val_53 + (val_45 * this.config.blockSize)) << 1, y:  (val_48 + (val_46 * this.config.blockSize)) << 1, z:  (val_52 + (val_1.Item3 * this.config.blockSize)) << 1), isAdd:  true, isSeparator:  false));
            val_48 = val_48 + 1;
        }
        while(this.config.blockSize != val_48);
        
        }
        
        }
        
            val_47 = val_2.isColumn;
            if(val_47[0] != false)
        {
                val_47 = val_2.columnwiseCounts[val_52 + ((val_2.isColumn[0x0][0] + 16) * val_53)];
            float val_50 = this.config.thresholdColumnDropRatio;
            val_50 = val_50 * (float)this.config.blockSize;
            if(val_50 >= (float)val_47)
        {
                do
        {
            val_2.isColumn[val_52 + (this.domain * val_53)] = false;
            if(val_1 != null)
        {
                val_51 = val_1.Item1;
            val_52 = val_1.Item2;
        }
        else
        {
                val_51 = val_1.Item1;
            val_52 = val_1.Item2;
        }
        
            val_38 = val_38;
            if(val_2.isTileLayer[0] != true)
        {
                this.domain.Add(item:  this.domain.GenerateTuple(coord:  this.domain.GenerateIntVector(x:  (val_53 + (val_51 * this.config.blockSize)) << 1, y:  (0 + (val_52 * this.config.blockSize)) << 1, z:  (val_52 + (val_1.Item3 * this.config.blockSize)) << 1), isAdd:  false, isSeparator:  false));
        }
        
            val_47 = 0 + 1;
        }
        while(this.config.blockSize != val_47);
        
        }
        
        }
        
            val_52 = val_52 + 1;
        }
        while(val_52 != this.config.blockSize);
        
            val_40 = this.domain;
        }
        
            val_53 = val_53 + 1;
        }
        while(val_53 != this.config.blockSize);
        
        }
        
        val_39 = ???;
        val_37 = val_37;
        val_41 = val_41 + 1;
        label_3:
        if(val_41 < val_37.Count)
        {
            goto label_72;
        }
        
        if(this.domain != null)
        {
                val_53 = this.domain.GenerateIntVector(x:  0, y:  0, z:  0);
        }
        else
        {
                val_53 = 0.GenerateIntVector(x:  0, y:  0, z:  0);
        }
        
        val_40.Add(item:  this.domain.GenerateTuple(coord:  val_53, isAdd:  false, isSeparator:  true));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SmoothPostprocessing(System.Collections.Generic.List<com.illumix.IntVector3.IntVector3> blocksProcessed)
    {
        System.Collections.Generic.List<com.illumix.IntVector3.IntVector3> val_9;
        var val_10;
        com.illumix.IntVector3.IntVector3 val_11;
        val_9 = blocksProcessed;
        val_10 = 0;
        goto label_4;
        label_47:
        com.illumix.IntVector3.IntVector3 val_2 = val_9.Item[0];
        com.illumix.TSDF.VoxelBlock val_3 = this.config.Item[val_2];
        if(this.config.blockSize < 1)
        {
            goto label_7;
        }
        
        var val_21 = 0;
        label_45:
        if(val_3.isTileLayer[val_21] == false)
        {
            goto label_11;
        }
        
        float val_11 = this.config.thresholdTileDropLayerRatio;
        val_11 = val_11 * (float)this.config.blockSize;
        val_11 = val_11 * (float)this.config.blockSize;
        if(val_11 < (float)val_3.layerwiseCounts[val_21])
        {
            goto label_44;
        }
        
        UnityEngine.Vector3 val_4 = this.GetTileCenter(blockKey:  val_2, blockSize:  this.config.blockSize, layer_idx:  0, resolution:  this.config.props);
        this.domain.tilesToSend.Add(item:  new TileParams() {center = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, length = this.config.props * (float)this.config.blockSize, isAdd = false});
        int val_12 = val_3.layerwiseCounts[val_21];
        float val_13 = this.config.thresholdSmoothDropLayerRatio;
        val_13 = val_13 * (float)this.config.blockSize;
        val_13 = val_13 * (float)this.config.blockSize;
        if(val_13 >= 0)
        {
            goto label_21;
        }
        
        this.PerformSmoothing(blockKey:  val_2, block:  val_3, layer_idx:  0);
        goto label_44;
        label_11:
        int val_15 = val_3.layerwiseCounts[val_21];
        float val_16 = this.config.thresholdTileLayerRatio;
        val_16 = val_16 * (float)this.config.blockSize;
        val_16 = val_16 * (float)this.config.blockSize;
        if(val_3.isSmoothLayer[val_21] == false)
        {
            goto label_28;
        }
        
        if(val_16 < 0)
        {
            goto label_29;
        }
        
        if(val_3.changesSinceLastUpdate > this.config.changesToUpdateSmoothLayer)
        {
            goto label_31;
        }
        
        float val_18 = this.config.thresholdSmoothDropLayerRatio;
        val_18 = val_18 * (float)this.config.blockSize;
        val_18 = val_18 * (float)this.config.blockSize;
        if(val_18 <= (float)val_3.layerwiseCounts[val_21])
        {
            goto label_44;
        }
        
        label_21:
        this.ClearLayer(blockKey:  val_2, block:  val_3, layer_idx:  0);
        goto label_44;
        label_28:
        if(val_16 >= 0)
        {
            goto label_37;
        }
        
        label_29:
        this.AddTile(blockKey:  val_2, block:  val_3, layer_idx:  0);
        goto label_44;
        label_37:
        int val_19 = val_3.layerwiseCounts[val_21];
        float val_20 = this.config.thresholdSmoothLayerRatio;
        val_20 = val_20 * (float)this.config.blockSize;
        val_20 = val_20 * (float)this.config.blockSize;
        if(val_20 >= 0)
        {
            goto label_44;
        }
        
        label_31:
        this.PerformSmoothing(blockKey:  val_2, block:  val_3, layer_idx:  0);
        if(this.config.smoothAddFilter != false)
        {
                this.FilterLayer(blockKey:  val_2, block:  val_3, layer_idx:  0);
        }
        
        label_44:
        val_21 = val_21 + 1;
        if(this.config.blockSize != val_21)
        {
            goto label_45;
        }
        
        label_7:
        val_9 = val_9;
        val_10 = 1;
        label_4:
        if(val_10 < val_9.Count)
        {
            goto label_47;
        }
        
        if(this.domain != null)
        {
                val_11 = this.domain.GenerateIntVector(x:  0, y:  0, z:  0);
        }
        else
        {
                val_11 = 0.GenerateIntVector(x:  0, y:  0, z:  0);
        }
        
        true.Add(item:  this.domain.GenerateTuple(coord:  val_11, isAdd:  true, isSeparator:  true));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void AddTile(com.illumix.IntVector3.IntVector3 blockKey, com.illumix.TSDF.VoxelBlock block, int layer_idx)
    {
        TSDF_Config val_16;
        com.illumix.TSDF.TSDF_Manager val_17;
        System.Collections.Generic.List<TileParams> val_18;
        var val_19;
        var val_20;
        TSDF_Config val_21;
        val_16 = this.config;
        if(this.config != null)
        {
            goto label_1;
        }
        
        val_16 = this.config;
        if(val_16 == null)
        {
            goto label_2;
        }
        
        label_1:
        TSDF_Properties val_16 = this.config.props;
        block.isTileLayer[(long)layer_idx] = true;
        block.isSmoothLayer[(long)layer_idx] = false;
        block.changesSinceLastUpdate = 0;
        UnityEngine.Vector3 val_1 = this.GetTileCenter(blockKey:  blockKey, blockSize:  this.config.blockSize, layer_idx:  layer_idx, resolution:  val_16);
        val_17 = this.domain;
        val_18 = this.domain.tilesToSend;
        val_16 = (float)this.config.blockSize * val_16;
        val_18.Add(item:  new TileParams() {center = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, length = val_16, isAdd = true});
        if(this.config.blockSize < 1)
        {
                return;
        }
        
        do
        {
            var val_18 = 0;
            do
        {
            if(blockKey != null)
        {
                val_19 = blockKey.Item1;
            val_20 = blockKey.Item2;
        }
        else
        {
                val_19 = 0.Item1;
            val_20 = 0.Item2;
        }
        
            int val_17 = layer_idx;
            val_17 = val_17 + (val_20 * this.config.blockSize);
            val_18 = this.domain.GenerateIntVector(x:  (0 + (val_19 * this.config.blockSize)) << 1, y:  val_17 << 1, z:  (val_18 + (blockKey.Item3 * this.config.blockSize)) << 1);
            com.illumix.TSDF.VoxelBlock val_13 = X23.Item[blockKey];
            if((val_13.smoothedTsdfCoords.Add(item:  val_18)) != false)
        {
                val_21 = val_16;
            val_18 = this.domain.GenerateTuple(coord:  val_18, isAdd:  true, isSeparator:  false);
            if(val_21 == 0)
        {
                val_21 = val_16;
        }
        
            val_21.Add(item:  val_18);
        }
        
            val_18 = val_18 + 1;
        }
        while(this.config.blockSize != val_18);
        
            val_17 = 0 + 1;
        }
        while(val_17 != this.config.blockSize);
        
        return;
        label_2:
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void PerformSmoothing(com.illumix.IntVector3.IntVector3 blockKey, com.illumix.TSDF.VoxelBlock block, int layer_idx)
    {
        com.illumix.IntVector3.IntVector3 val_56;
        com.illumix.IntVector3.IntVector3 val_57;
        TSDF_Config val_58;
        TSDF_Config val_59;
        var val_60;
        float val_61;
        var val_62;
        var val_63;
        float val_64;
        float val_65;
        float val_66;
        var val_67;
        int val_68;
        var val_69;
        int val_70;
        int val_71;
        int val_72;
        int val_73;
        int val_74;
        com.illumix.IntVector3.IntVector3 val_75;
        int val_76;
        var val_77;
        var val_78;
        float val_79;
        TSDF_Config val_80;
        TSDF_Config val_81;
        val_56 = block;
        val_57 = blockKey;
        com.illumix.TSDF.Voxel val_10 = 0;
        val_58 = this.config;
        if(this.config != null)
        {
            goto label_1;
        }
        
        val_58 = this.config;
        if(val_58 == null)
        {
            goto label_60;
        }
        
        label_1:
        val_59 = (long)layer_idx;
        block.isSmoothLayer[val_59] = true;
        block.isTileLayer[val_59] = false;
        block.changesSinceLastUpdate = 0;
        if(this.config.blockSize < 1)
        {
                return;
        }
        
        label_94:
        var val_60 = 0;
        goto label_93;
        label_69:
        if(W24 != 0)
        {
            goto label_12;
        }
        
        label_74:
        val_59 = this.config;
        if(val_59 != null)
        {
            goto label_82;
        }
        
        goto label_14;
        label_24:
        val_60 = val_10;
        if(val_60 == 0)
        {
            goto label_60;
        }
        
        val_61 = mem[X24 + 20];
        val_61 = X24 + 20;
        goto label_16;
        label_93:
        if(val_57 != null)
        {
                val_62 = val_57.Item1;
            val_63 = val_57.Item2;
        }
        else
        {
                val_62 = 0.Item1;
            val_63 = 0.Item2;
        }
        
        var val_55 = 0;
        int val_57 = this.config.blockSize;
        int val_56 = layer_idx;
        val_55 = val_55 + (val_62 * val_57);
        val_56 = val_56 + (val_63 * val_57);
        val_57 = val_60 + (val_57.Item3 * val_57);
        val_56 = this.domain.GenerateIntVector(x:  val_55 << 1, y:  val_56 << 1, z:  val_57 << 1);
        val_64 = 0f;
        val_65 = 0f;
        if((this.domain.data.TryGetValue(key:  val_56, value: out  val_10)) == false)
        {
            goto label_21;
        }
        
        val_60 = val_10;
        if(val_60 == 0)
        {
            goto label_22;
        }
        
        val_66 = 1.68059E-38f;
        goto label_23;
        label_22:
        val_66 = 1.68059E-38f;
        if(val_10 == 0)
        {
            goto label_24;
        }
        
        val_60 = val_10;
        label_23:
        val_61 = 1.401298E-45f;
        label_16:
        val_61 = val_66 * val_61;
        val_65 = val_61 + 0f;
        val_64 = (1.401298E-45f) + 0f;
        label_21:
        com.illumix.IntVector3.IntVector3[] val_12 = new com.illumix.IntVector3.IntVector3[4];
        if(val_56 != null)
        {
                val_67 = val_56.Item1;
            val_68 = val_56.Item2;
        }
        else
        {
                val_67 = 0.Item1;
            val_68 = 0.Item2;
        }
        
        com.illumix.IntVector3.IntVector3 val_19 = this.domain.GenerateIntVector(x:  val_67 - 2, y:  val_68, z:  val_56.Item3);
        if(val_12 == null)
        {
            goto label_28;
        }
        
        if(val_19 != null)
        {
            goto label_29;
        }
        
        goto label_32;
        label_28:
        if(val_19 == null)
        {
            goto label_32;
        }
        
        label_29:
        label_32:
        val_12[0] = val_19;
        if(val_56 != null)
        {
                val_69 = val_56.Item1;
            val_70 = val_56.Item2;
        }
        else
        {
                val_69 = 0.Item1;
            val_70 = 0.Item2;
        }
        
        val_12[1] = this.domain.GenerateIntVector(x:  val_69 + 2, y:  val_70, z:  val_56.Item3);
        if(val_56 != null)
        {
                val_71 = val_56.Item1;
            val_72 = val_56.Item2;
        }
        else
        {
                val_71 = 0.Item1;
            val_72 = 0.Item2;
        }
        
        val_12[2] = this.domain.GenerateIntVector(x:  val_71, y:  val_72, z:  val_56.Item3 + 2);
        if(val_56 != null)
        {
                val_73 = val_56.Item1;
            val_74 = val_56.Item2;
        }
        else
        {
                val_73 = 0.Item1;
            val_74 = 0.Item2;
        }
        
        val_75 = this.domain.GenerateIntVector(x:  val_73, y:  val_74, z:  val_56.Item3 - 2);
        val_76 = val_12.Length;
        if(val_76 <= 3)
        {
                val_76 = val_12.Length;
        }
        
        val_77 = 0;
        val_12[3] = val_75;
        if(val_76 < 1)
        {
            goto label_52;
        }
        
        label_64:
        val_75 = 0;
        if((this.domain.data.TryGetValue(key:  val_12[val_75], value: out  val_10)) == false)
        {
            goto label_63;
        }
        
        val_78 = val_10;
        if(val_10 != 0)
        {
            goto label_56;
        }
        
        val_78 = val_10;
        if(val_78 == 0)
        {
            goto label_60;
        }
        
        label_56:
        if(val_78 == 0)
        {
            goto label_58;
        }
        
        val_79 = (1.401298E-45f) * this.NEIGHBOR_WEIGHT;
        goto label_59;
        label_58:
        if(val_10 == 0)
        {
            goto label_60;
        }
        
        val_78 = val_10;
        val_79 = (1.401298E-45f) * this.NEIGHBOR_WEIGHT;
        label_59:
        float val_42 = (1.68059E-38f) * (1.401298E-45f);
        val_42 = val_42 * this.NEIGHBOR_WEIGHT;
        val_65 = val_65 + val_42;
        val_64 = val_64 + val_79;
        if(((1.68059E-38f) <= S8) && ((1.401298E-45f) >= this.config.weightThreshold))
        {
                val_77 = val_77 + 1;
        }
        
        label_63:
        if((val_75 + 1) < val_12.Length)
        {
            goto label_64;
        }
        
        label_52:
        if(val_64 <= 0f)
        {
            goto label_65;
        }
        
        val_57 = val_57;
        if((val_77 == 4) || ((System.Math.Abs(val_65 / val_64)) <= S8))
        {
            goto label_69;
        }
        
        com.illumix.TSDF.VoxelBlock val_45 = ???.Item[val_57];
        if((val_77 == 0) || ((val_45.tsdfCoords.Contains(item:  val_56)) == false))
        {
            goto label_74;
        }
        
        label_12:
        com.illumix.TSDF.VoxelBlock val_47 = ???.Item[val_57];
        val_59 = val_47.smoothedTsdfCoords;
        if((val_59.Add(item:  val_56)) == false)
        {
            goto label_87;
        }
        
        val_80 = val_58;
        val_59 = this.domain.GenerateTuple(coord:  val_56, isAdd:  true, isSeparator:  false);
        if(val_80 == 0)
        {
                val_80 = val_58;
        }
        
        val_80.Add(item:  val_59);
        goto label_87;
        label_65:
        val_59 = this.config;
        val_57 = val_57;
        if(val_59 != null)
        {
            goto label_82;
        }
        
        label_14:
        label_82:
        if(this.config.smoothEnableRemoval != false)
        {
                com.illumix.TSDF.VoxelBlock val_50 = ???.Item[val_57];
            val_59 = val_50.smoothedTsdfCoords;
            if((val_59.Contains(item:  val_56)) != false)
        {
                val_81 = val_58;
            if(val_81 == 0)
        {
                val_81 = val_58;
        }
        
            val_81.Add(item:  this.domain.GenerateTuple(coord:  val_56, isAdd:  false, isSeparator:  false));
            com.illumix.TSDF.VoxelBlock val_53 = ???.Item[val_57];
            val_59 = val_53.smoothedTsdfCoords;
            bool val_54 = val_59.Remove(item:  val_56);
        }
        
        }
        
        label_87:
        val_60 = val_60 + 1;
        if(val_60 != this.config.blockSize)
        {
            goto label_93;
        }
        
        if(1 != this.config.blockSize)
        {
            goto label_94;
        }
        
        return;
        label_60:
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ClearLayer(com.illumix.IntVector3.IntVector3 blockKey, com.illumix.TSDF.VoxelBlock block, int layer_idx)
    {
        var val_16;
        System.Boolean[] val_17;
        var val_18;
        var val_19;
        com.illumix.IntVector3.IntVector3 val_20;
        var val_22;
        val_16 = (long)layer_idx;
        block.isTileLayer[val_16] = false;
        val_17 = block.isSmoothLayer;
        val_17[val_16] = false;
        if(this.config.blockSize < 1)
        {
                return;
        }
        
        do
        {
            do
        {
            if(blockKey != null)
        {
                val_18 = blockKey.Item1;
            val_19 = blockKey.Item2;
        }
        else
        {
                val_18 = 0.Item1;
            val_19 = 0.Item2;
        }
        
            int val_16 = layer_idx;
            val_16 = val_16 + (val_19 * this.config.blockSize);
            val_20 = this.domain.GenerateIntVector(x:  (0 + (val_18 * this.config.blockSize)) << 1, y:  val_16 << 1, z:  (0 + (blockKey.Item3 * this.config.blockSize)) << 1);
            var val_12 = block.isColumn + (0 * ((val_3 * this.config.blockSize) + 0 + 16));
            val_12 = val_12 + 0;
            if((((0 * (val_3 * this.config.blockSize) + 0 + 16) + block.isColumn + 0) + 32) == 0)
        {
                val_22 = true;
            if(val_22 == 0)
        {
                val_22 = true;
        }
        
            com.illumix.TSDF.VoxelBlock val_13 = val_22.Item[blockKey];
            if((val_13.smoothedTsdfCoords.Remove(item:  val_20)) != false)
        {
                val_20 = this.domain.GenerateTuple(coord:  val_20, isAdd:  false, isSeparator:  false);
            true.Add(item:  val_20);
        }
        
        }
        
            val_16 = 0 + 1;
        }
        while(this.config.blockSize != val_16);
        
            val_17 = 0 + 1;
        }
        while(val_17 != this.config.blockSize);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void FilterLayer(com.illumix.IntVector3.IntVector3 blockKey, com.illumix.TSDF.VoxelBlock block, int layer_idx)
    {
        com.illumix.TSDF.TSDF_Manager val_54;
        int val_55;
        com.illumix.IntVector3.IntVector3 val_56;
        var val_57;
        var val_58;
        var val_59;
        int val_60;
        var val_61;
        int val_62;
        int val_63;
        int val_64;
        int val_65;
        int val_66;
        int val_67;
        var val_68;
        com.illumix.TSDF.TSDF_Manager val_69;
        com.illumix.IntVector3.IntVector3 val_70;
        var val_71;
        val_54 = this.domain;
        val_55 = this.config.blockSize;
        val_56 = blockKey;
        if(val_55 < 1)
        {
                return;
        }
        
        val_54 = 1152921518981985616;
        label_64:
        label_63:
        if(val_56 != 0)
        {
                val_57 = val_56.Item1;
            val_58 = val_56.Item2;
        }
        else
        {
                val_57 = 0.Item1;
            val_58 = 0.Item2;
        }
        
        int val_56 = layer_idx;
        var val_55 = 0;
        val_55 = val_55 + (val_57 * val_55);
        val_56 = val_56 + (val_58 * val_55);
        com.illumix.IntVector3.IntVector3 val_10 = this.domain.GenerateIntVector(x:  val_55 << 1, y:  val_56 << 1, z:  (0 + (val_56.Item3 * val_55)) << 1);
        com.illumix.IntVector3.IntVector3[] val_11 = new com.illumix.IntVector3.IntVector3[4];
        if(val_10 != null)
        {
                val_59 = val_10.Item1;
            val_60 = val_10.Item2;
        }
        else
        {
                val_59 = 0.Item1;
            val_60 = 0.Item2;
        }
        
        com.illumix.IntVector3.IntVector3 val_18 = this.domain.GenerateIntVector(x:  val_59 - 2, y:  val_60, z:  val_10.Item3);
        if(val_11 == null)
        {
            goto label_10;
        }
        
        if(val_18 != null)
        {
            goto label_11;
        }
        
        goto label_14;
        label_10:
        if(val_18 == null)
        {
            goto label_14;
        }
        
        label_11:
        label_14:
        val_11[0] = val_18;
        if(val_10 != null)
        {
                val_61 = val_10.Item1;
            val_62 = val_10.Item2;
        }
        else
        {
                val_61 = 0.Item1;
            val_62 = 0.Item2;
        }
        
        val_11[1] = this.domain.GenerateIntVector(x:  val_61 + 2, y:  val_62, z:  val_10.Item3);
        if(val_10 != null)
        {
                val_63 = val_10.Item1;
            val_64 = val_10.Item2;
        }
        else
        {
                val_63 = 0.Item1;
            val_64 = 0.Item2;
        }
        
        val_11[2] = this.domain.GenerateIntVector(x:  val_63, y:  val_64, z:  val_10.Item3 + 2);
        if(val_10 != null)
        {
                val_65 = val_10.Item1;
            val_66 = val_10.Item2;
        }
        else
        {
                val_65 = 0.Item1;
            val_66 = 0.Item2;
        }
        
        val_67 = val_11.Length;
        if(val_67 <= 3)
        {
                val_67 = val_11.Length;
        }
        
        val_11[3] = this.domain.GenerateIntVector(x:  val_65, y:  val_66, z:  val_10.Item3 - 2);
        if(val_67 < 1)
        {
            goto label_34;
        }
        
        val_68 = 0;
        do
        {
            val_69 = this.domain;
            com.illumix.IntVector3.IntVector3 val_57 = val_11[0];
            com.illumix.IntVector3.IntVector3 val_40 = val_69.GetBlockKey(discretePoint:  val_57);
            if((X22.ContainsKey(key:  val_40)) != false)
        {
                com.illumix.TSDF.VoxelBlock val_42 = X22.Item[val_40];
            val_69 = val_42.smoothedTsdfCoords;
            val_68 = val_68 + (val_69.Contains(item:  val_57));
        }
        
        }
        while((0 + 1) < val_11.Length);
        
        if(val_68 == true)
        {
            goto label_43;
        }
        
        val_56 = blockKey;
        if(val_68 == true)
        {
            goto label_57;
        }
        
        label_34:
        com.illumix.TSDF.VoxelBlock val_46 = X22.Item[val_56];
        val_69 = val_46.smoothedTsdfCoords;
        if((val_69.Contains(item:  val_10)) == false)
        {
            goto label_57;
        }
        
        com.illumix.TSDF.VoxelBlock val_48 = X22.Item[val_56];
        bool val_49 = val_48.smoothedTsdfCoords.Remove(item:  val_10);
        val_70 = val_10;
        val_71 = 0;
        goto label_53;
        label_43:
        com.illumix.TSDF.VoxelBlock val_50 = X22.Item[blockKey];
        val_69 = val_50.smoothedTsdfCoords;
        if((val_69.Contains(item:  val_10)) == true)
        {
            goto label_57;
        }
        
        com.illumix.TSDF.VoxelBlock val_52 = X22.Item[blockKey];
        bool val_53 = val_52.smoothedTsdfCoords.Add(item:  val_10);
        val_71 = 1;
        val_70 = val_10;
        label_53:
        val_69 = this.domain.GenerateTuple(coord:  val_70, isAdd:  true, isSeparator:  false);
        true.Add(item:  val_69);
        label_57:
        var val_58 = 0;
        val_55 = val_55;
        val_58 = val_58 + 1;
        if(val_58 != val_55)
        {
            goto label_63;
        }
        
        if(1 != val_55)
        {
            goto label_64;
        }
    
    }

}
