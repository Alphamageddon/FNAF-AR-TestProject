using UnityEngine;

namespace com.illumix.TSDF
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TSDF_Manager : IPointAccepter, IDepthMapAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TSDF_Config config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public com.illumix.TSDF.TSDF_Manager.TSDF_Data data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<com.illumix.TSDF.TSDF_Manager.TileParams> tilesToSend;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Queue<com.illumix.TSDF.TSDF_Manager.CoordUpdate> coordsToUpdatePool;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private com.illumix.IntVector3.IntVector3Cache coordCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, com.illumix.IntVector3.IntVector3> coordToBlockKeyCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3> blocksUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TileDispenser tileDispenser;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MeshBlockDispenser meshBlockDispenser;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.ParticleSystem ps;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TSDF_SROptions debugOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TSDF_Updater tsdfUpdater;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SurfaceVerticesUpdater vertexUpdater;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private VoxelBlock_Updater blockUpdater;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TSDF_Visual visualUpdater;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long lastUpdateTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long lastGenTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera m_Camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float EPSILON;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<int> triangleList;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(TileDispenser tileDispenser, MeshBlockDispenser meshBlockDispenser, SharedTechAssets.Scripts.TechInterfaces.Dispensers.BlockCoordDispenser blockCoordDispenser, TSDF_Config config, com.illumix.IntVector3.IntVector3Cache coordCache, UnityEngine.Camera m_Camera)
        {
            var val_8;
            TSDF_SROptions val_1 = null;
            val_8 = 0;
            val_1 = new TSDF_SROptions(tSDF:  this);
            this.debugOptions = val_1;
            SRDebugger.Services.IDebugService val_2 = SRDebug.Instance;
            if(val_2 != null)
            {
                    var val_8 = 0;
                val_8 = val_8 + 1;
                val_8 = 12;
                val_2.AddOptionContainer(container:  this.debugOptions);
            }
            
            this.tileDispenser = tileDispenser;
            this.meshBlockDispenser = meshBlockDispenser;
            this.config = config;
            this.coordCache = coordCache;
            this.tsdfUpdater = new TSDF_Updater(tsdfDomain:  this);
            this.vertexUpdater = new SurfaceVerticesUpdater(tsdfDomain:  this);
            this.blockUpdater = new VoxelBlock_Updater(tsdfDomain:  this);
            this.visualUpdater = new TSDF_Visual(tsdfDomain:  this);
            this.m_Camera = m_Camera;
            this.SetupData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this.TeardownData();
            this.config = 0;
            this.tileDispenser = 0;
            this.tsdfUpdater = 0;
            this.blockUpdater = 0;
            SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
            if(val_1 != null)
            {
                    var val_3 = 0;
                val_3 = val_3 + 1;
                val_1.RemoveOptionContainer(container:  this.debugOptions);
            }
            
            this.debugOptions = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetupData()
        {
            var val_2;
            var val_3;
            TSDF_Data val_4;
            TSDF_Data val_1 = this.MakeNewData();
            mem[1152921523018966856] = val_2;
            mem[1152921523018966840] = val_3;
            this.data = val_4;
            this.tilesToSend = new System.Collections.Generic.List<TileParams>();
            this.coordsToUpdatePool = new System.Collections.Generic.Queue<CoordUpdate>();
            this.coordToBlockKeyCache = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, com.illumix.IntVector3.IntVector3>();
            if(this.config.showParticles != false)
            {
                    this.ps = UnityEngine.Object.Instantiate<UnityEngine.ParticleSystem>(original:  this.config.pointCloudParticlePrefab);
            }
            
            this.blocksUpdated = new System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>();
            this.visualUpdater.ClearMeshes();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearData()
        {
            Clear();
            this.data.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TeardownData()
        {
            this.tsdfUpdater = 0;
            this.visualUpdater.ClearMeshes();
            this.coordsToUpdatePool = 0;
            this.coordCache = 0;
            this.tilesToSend = 0;
            this.blockUpdater = 0;
            this.visualUpdater = 0;
            this.vertexUpdater = 0;
            if(this.config.showParticles == false)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this.ps);
            this.ps = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public com.illumix.IntVector3.IntVector3 GenerateIntVector(int x, int y, int z)
        {
            if(this.coordCache != null)
            {
                    return this.coordCache.GenerateIntVector(x:  x, y:  y, z:  z);
            }
            
            return this.coordCache.GenerateIntVector(x:  x, y:  y, z:  z);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public com.illumix.TSDF.TSDF_Manager.CoordUpdate GenerateTuple(com.illumix.IntVector3.IntVector3 coord, bool isAdd, bool isSeparator)
        {
            var val_7;
            if(this.coordsToUpdatePool.Count == 0)
            {
                goto label_2;
            }
            
            val_7 = this.coordsToUpdatePool.Dequeue();
            if(val_7 != null)
            {
                goto label_4;
            }
            
            mem[16] = coord;
            mem[24] = isAdd;
            goto label_5;
            label_2:
            TSDF_Manager.CoordUpdate val_4 = null;
            val_7 = val_4;
            val_4 = new TSDF_Manager.CoordUpdate();
            label_4:
            .coord = coord;
            .isAdd = isAdd;
            label_5:
            .isSeparator = isSeparator;
            return (CoordUpdate)val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public com.illumix.TSDF.TSDF_Manager.TSDF_Data MakeNewData()
        {
            TSDF_Data val_0;
            val_0.tsdfStore = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, com.illumix.TSDF.Voxel>();
            val_0.cachedBlocks = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, com.illumix.TSDF.VoxelBlock>();
            val_0.lastUpdatedBlocks = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean>>();
            val_0.blocksToUpdateCoords = new System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>();
            val_0.coordsToUpdate = new System.Collections.Generic.List<CoordUpdate>();
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public com.illumix.TSDF.VoxelBlock MakeNewVoxelBlock()
        {
            return (com.illumix.TSDF.VoxelBlock)new com.illumix.TSDF.VoxelBlock(blockSize:  this.config.blockSize);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetColumnPos(com.illumix.IntVector3.IntVector3 coord, com.illumix.IntVector3.IntVector3 blockKey, out int x, out int z)
        {
            int val_3 = this.config.blockSize;
            val_3 = (blockKey.<Item1>k__BackingField) * val_3;
            val_3 = (coord.<Item1>k__BackingField) - (val_3 << 1);
            int val_1 = (val_3 < 0) ? (val_3 + 1) : (val_3);
            val_1 = val_1 >> 1;
            x = val_1;
            int val_4 = this.config.blockSize;
            val_4 = (blockKey.<Item3>k__BackingField) * val_4;
            val_4 = (coord.<Item3>k__BackingField) - (val_4 << 1);
            int val_2 = (val_4 < 0) ? (val_4 + 1) : (val_4);
            val_2 = val_2 >> 1;
            z = val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetLayerPos(com.illumix.IntVector3.IntVector3 coord, com.illumix.IntVector3.IntVector3 blockKey)
        {
            int val_3 = this.config.blockSize;
            val_3 = (blockKey.<Item2>k__BackingField) * val_3;
            val_3 = (coord.<Item2>k__BackingField) - (val_3 << 1);
            return (int)((val_3 < 0) ? (val_3 + 1) : (val_3)) >> 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 IntVectorToVertexPosition(com.illumix.IntVector3.IntVector3 intVertex, float resolution)
        {
            int val_1;
            int val_2;
            if(intVertex != null)
            {
                    val_1 = intVertex.<Item1>k__BackingField;
                val_2 = intVertex.<Item2>k__BackingField;
            }
            else
            {
                    val_1 = 11993091;
                val_2 = 1;
            }
            
            float val_1 = 1.199309E+07f;
            float val_2 = 1f;
            float val_3 = (float)intVertex.<Item3>k__BackingField;
            val_1 = val_1 * resolution;
            val_2 = val_2 * resolution;
            val_3 = val_3 * resolution;
            val_1 = val_1 * 0.5f;
            val_2 = val_2 * 0.5f;
            val_3 = val_3 * 0.5f;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public com.illumix.IntVector3.IntVector3 GetBlockKey(com.illumix.IntVector3.IntVector3 discretePoint)
        {
            System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, com.illumix.IntVector3.IntVector3> val_16;
            int val_17;
            int val_18;
            int val_19;
            int val_20;
            int val_21;
            int val_22;
            val_16 = this.coordToBlockKeyCache;
            if((val_16.TryGetValue(key:  discretePoint, value: out  0)) == true)
            {
                    return val_16;
            }
            
            if(discretePoint == null)
            {
                goto label_4;
            }
            
            val_17 = discretePoint.<Item1>k__BackingField;
            if((val_17 & 2147483648) != 0)
            {
                goto label_5;
            }
            
            label_11:
            var val_3 = (val_17 < 0) ? (val_17 + 1) : (val_17);
            val_3 = val_3 >> 1;
            val_18 = val_3 / this.config.blockSize;
            if(discretePoint == null)
            {
                goto label_6;
            }
            
            label_12:
            val_19 = discretePoint.<Item2>k__BackingField;
            if((val_19 & 2147483648) != 0)
            {
                goto label_7;
            }
            
            label_13:
            var val_4 = (val_19 < 0) ? (val_19 + 1) : (val_19);
            val_4 = val_4 >> 1;
            val_20 = val_4 / this.config.blockSize;
            if(discretePoint == null)
            {
                goto label_8;
            }
            
            label_14:
            val_21 = discretePoint.<Item3>k__BackingField;
            if((val_21 & 2147483648) != 0)
            {
                goto label_9;
            }
            
            label_15:
            var val_5 = (val_21 < 0) ? (val_21 + 1) : (val_21);
            val_5 = val_5 >> 1;
            val_22 = val_5 / this.config.blockSize;
            goto label_10;
            label_4:
            val_17 = 11993091;
            if((11993091 & 2147483648) == 0)
            {
                goto label_11;
            }
            
            label_5:
            val_17 = (11993092 < 0) ? (val_17 + 2) : (val_17 + 1);
            val_17 = val_17 >> 1;
            val_17 = val_17 / this.config.blockSize;
            val_18 = val_17 - 1;
            if(discretePoint != null)
            {
                goto label_12;
            }
            
            label_6:
            val_19 = 1;
            if((1 & 2147483648) == 0)
            {
                goto label_13;
            }
            
            label_7:
            val_19 = ((val_19 + 1) < 0) ? (val_19 + 2) : (val_19 + 1);
            val_19 = val_19 >> 1;
            val_19 = val_19 / this.config.blockSize;
            val_20 = val_19 - 1;
            if(discretePoint != null)
            {
                goto label_14;
            }
            
            label_8:
            val_21 = 15026800;
            if((15026800 & 2147483648) == 0)
            {
                goto label_15;
            }
            
            label_9:
            val_21 = ((val_21 + 1) < 0) ? (val_21 + 2) : (val_21 + 1);
            val_21 = val_21 >> 1;
            val_21 = val_21 / this.config.blockSize;
            val_22 = val_21 - 1;
            label_10:
            val_16 = this.GenerateIntVector(x:  val_18, y:  val_20, z:  val_22);
            this.coordToBlockKeyCache.set_Item(key:  discretePoint, value:  val_16);
            return val_16;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public com.illumix.IntVector3.IntVector3 BlockKeyToResolutionSpace(com.illumix.IntVector3.IntVector3 blockKey)
        {
            int val_5;
            int val_6;
            if(blockKey != null)
            {
                    val_5 = blockKey.<Item1>k__BackingField;
                val_6 = blockKey.<Item2>k__BackingField;
            }
            else
            {
                    val_5 = 11993091;
                val_6 = 1;
            }
            
            int val_1 = this.config.blockSize << 1;
            return this.GenerateIntVector(x:  val_1 * val_5, y:  val_1 * val_6, z:  val_1 * (blockKey.<Item3>k__BackingField));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetMeshInfoFromBlock(com.illumix.TSDF.VoxelBlock block, out UnityEngine.Vector3[] coordsArr, out int[] trianglesArr)
        {
            var val_8;
            var val_9;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = block.cubeToTriangles.Keys.GetEnumerator();
            label_7:
            if((1234102088 & 1) == 0)
            {
                goto label_4;
            }
            
            this.triangleList.AddRange(collection:  block.cubeToTriangles.Item[0.emailUIDataHandler]);
            goto label_7;
            label_4:
            val_8 = 0;
            val_9 = 1;
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523020818248});
            coordsArr = block.vertices_1d_list.ToArray();
            trianglesArr = this.triangleList.ToArray();
            this.triangleList.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CountData()
        {
            var val_4;
            var val_20;
            var val_21;
            var val_22;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = X20.Values.GetEnumerator();
            val_20 = 0;
            int val_21 = 0;
            int val_20 = 0;
            label_17:
            if((1234406832 & 1) == 0)
            {
                goto label_3;
            }
            
            GameUI.EmailUIDataHandler val_5 = val_4.emailUIDataHandler;
            val_20 = val_5._emailIdsToBeDeletedOnServer.Count + val_20;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_10 = val_5._emailDatas.Values.GetEnumerator();
            goto label_9;
            label_11:
            val_21 = val_4.emailUIDataHandler.Count + val_21;
            label_9:
            if((1234406800 & 1) != 0)
            {
                goto label_11;
            }
            
            val_21 = val_20;
            long val_13 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523021122960});
            if((((139 == 0) ? 139 : 139) == 139) || ( == 0))
            {
                goto label_17;
            }
            
            goto label_17;
            label_3:
            val_22 = 164;
            long val_15 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523021122992});
            object[] val_18 = new object[5];
            val_18[0] = mem[1152921523021135152].Count;
            val_18[1] = (val_5._emailIdsToBeDeletedOnServer.Count > 0) ? (0 + 1) : 0;
            val_18[2] = val_20;
            val_18[3] = val_21;
            val_18[4] = mem[1152921523021135144].Count;
            string val_19 = System.String.Format(format:  "Number of Blocks: {0} Non-empty: {1} Number of Surface Coordinates: {2} Number of triangles: {3} Number of TSDF voxels: {4}", args:  val_18);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SendTileEvents()
        {
            float val_2;
            float val_3;
            float val_4;
            var val_5;
            float val_6;
            goto label_1;
            label_8:
            TileParams val_1 = X21.Item[0];
            if(val_5 != false)
            {
                    this.tileDispenser.SendTileAddEvent(center:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4}, length:  val_6);
            }
            else
            {
                    this.tileDispenser.SentTileRemoveEvent(center:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4});
            }
            
            0 = 1;
            label_1:
            if(0 < this.tilesToSend.Count)
            {
                goto label_8;
            }
            
            this.tilesToSend.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SendMeshBlockEvents()
        {
            var val_3;
            TSDF_Config val_18;
            int val_19;
            int val_20;
            var val_21;
            var val_22;
            System.Int32[] val_7 = 0;
            UnityEngine.Vector3[] val_6 = 0;
            HashSet.Enumerator<T> val_1 = this.blocksUpdated.GetEnumerator();
            label_10:
            if((1234768992 & 1) == 0)
            {
                goto label_2;
            }
            
            GameUI.EmailUIDataHandler val_4 = val_3.emailUIDataHandler;
            this.GetMeshInfoFromBlock(block:  X21.Item[val_4], coordsArr: out  val_6, trianglesArr: out  val_7);
            com.illumix.IntVector3.IntVector3 val_8 = this.BlockKeyToResolutionSpace(blockKey:  val_4);
            val_18 = this.config;
            if(val_18 == null)
            {
                goto label_5;
            }
            
            val_19 = this.config.blockSize;
            val_20 = val_8.<Item2>k__BackingField;
            goto label_6;
            label_5:
            val_19 = this.config.blockSize;
            val_20 = val_8.<Item2>k__BackingField;
            if(this.config == null)
            {
                goto label_7;
            }
            
            val_18 = this.config;
            label_6:
            label_12:
            UnityEngine.Vector3 val_16 = this.IntVectorToVertexPosition(intVertex:  this.GenerateIntVector(x:  (val_8.<Item1>k__BackingField) + (((val_19 < 0) ? (val_19 + 1) : (val_19)) >> 1), y:  val_20 + (((this.config.blockSize < 0) ? (this.config.blockSize + 1) : this.config.blockSize) >> 1), z:  (val_8.<Item3>k__BackingField) + (((this.config.blockSize < 0) ? (this.config.blockSize + 1) : this.config.blockSize) >> 1)), resolution:  this.config.props);
            this.meshBlockDispenser.SendMeshBlockEvent(key:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, vertices:  val_6, triangles:  val_7);
            goto label_10;
            label_7:
            if(this.config != null)
            {
                goto label_12;
            }
            
            goto label_12;
            label_2:
            val_21 = 0;
            val_22 = 1;
            long val_17 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523021485152});
            this.blocksUpdated.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FeaturePointsUpdate(UnityEngine.Vector3[] realPoints, UnityEngine.Vector3 cameraPosition)
        {
            System.Object[] val_24;
            TSDF_Config val_25;
            object val_26;
            int val_27;
            TSDF_Config val_28;
            long val_29;
            val_24 = this;
            val_25 = 1152921504617603072;
            System.DateTime val_1 = System.DateTime.UtcNow;
            long val_2 = val_1.dateData.Ticks;
            long val_3 = 1844674407370955 - this.lastUpdateTime;
            if(this.config.updateTime < 0)
            {
                    if(this.config.disableFeaturePoints != true)
            {
                    this.tsdfUpdater.Add_FeaturePoints(points:  realPoints, cameraPosition:  new UnityEngine.Vector3() {x = cameraPosition.x, y = cameraPosition.y, z = cameraPosition.z});
            }
            
                System.DateTime val_4 = System.DateTime.UtcNow;
                long val_5 = val_4.dateData.Ticks;
                val_26 = 1844674407370955 - 1844674407370955;
                this.lastUpdateTime = 1844674407370955;
            }
            else
            {
                    val_26 = 0;
            }
            
            System.DateTime val_6 = System.DateTime.UtcNow;
            long val_7 = val_6.dateData.Ticks;
            int val_8 = this.lastUpdateTime.Count;
            val_27 = this.config.maxCoordsToUpdate;
            if(val_8 <= val_27)
            {
                    val_28 = this.config;
                val_29 = this.lastGenTime;
                long val_9 = 1844674407370955 - val_29;
                if(this.config.updateTime >= 0)
            {
                    return;
            }
            
            }
            
            this.vertexUpdater.UpdateVertices();
            System.DateTime val_10 = System.DateTime.UtcNow;
            val_29 = val_10.dateData.Ticks;
            this.blockUpdater.UpdateTriangles();
            System.DateTime val_12 = System.DateTime.UtcNow;
            var val_22 = val_12.dateData.Ticks;
            if(val_8 <= val_27)
            {
                    if(this.config.hideMesh != false)
            {
                    this.SendTileEvents();
                this.SendMeshBlockEvents();
            }
            else
            {
                    this.visualUpdater.UpdateMeshes();
            }
            
            }
            
            System.DateTime val_14 = System.DateTime.UtcNow;
            long val_15 = val_14.dateData.Ticks;
            val_25 = this.config;
            val_28 = 1844674407370955;
            this.lastGenTime = val_28;
            if(this.config.showTimeOutput == false)
            {
                    return;
            }
            
            int val_16 = val_27 >> 11;
            int val_17 = X28 >> 11;
            object[] val_18 = new object[5];
            val_24 = val_18;
            val_16 = val_16 + (val_27 >> 63);
            val_25 = val_17 + ((X28) >> 63);
            val_27 = val_22 >> 11;
            val_17 = val_25 - val_16;
            val_24[0] = val_26;
            val_22 = val_27 + (val_22 >> 63);
            val_24[1] = val_17;
            val_24[2] = val_22 - val_25;
            val_29 = val_28 - 1844674407370955;
            val_24[3] = val_28 - val_22;
            val_24[4] = val_29;
            string val_21 = System.String.Format(format:  "FPs: {0} vertexes: {1} triangles: {2} visuals: {3} Total: {4}", args:  val_18);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DepthModel_Update(UnityEngine.Vector3[,] vertices, bool[,] keepMask, UnityEngine.Vector3 cameraPt)
        {
            this.tsdfUpdater.Add_DepthModel_Depth(vertices:  vertices, keepMask:  keepMask, cameraPt:  new UnityEngine.Vector3() {x = cameraPt.x, y = cameraPt.y, z = cameraPt.z});
            this.vertexUpdater.UpdateVertices();
            this.blockUpdater.UpdateTriangles();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPointUpdatedEvent(UnityEngine.Vector3[] pointData)
        {
            UnityEngine.Vector3 val_2 = this.m_Camera.transform.position;
            this.FeaturePointsUpdate(realPoints:  pointData, cameraPosition:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDepthMapUpdatedEvent(UnityEngine.Vector3[,] depthMap, bool[,] keepMask, UnityEngine.Vector3 cameraPos)
        {
            this.DepthModel_Update(vertices:  depthMap, keepMask:  keepMask, cameraPt:  new UnityEngine.Vector3() {x = cameraPos.x, y = cameraPos.y, z = cameraPos.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TSDF_Manager()
        {
            this.EPSILON = 0.0001f;
            this.triangleList = new System.Collections.Generic.List<System.Int32>();
        }
    
    }

}
