using UnityEngine;

namespace SharedTechAssets.Scripts.TSDF2
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TSDF_Manager : IPointAccepter, IDepthMapAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedTechAssets.Scripts.TSDF2.TSDF_Config2 config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedTechAssets.Scripts.TSDF2.TSDF_Manager.TSDF_Data data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Queue<SharedTechAssets.Scripts.TSDF2.TSDF_Manager.CoordUpdate> coordsToUpdatePool;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private com.illumix.IntVector3.IntVector3Cache coordCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, com.illumix.IntVector3.IntVector3> coordToBlockKeyCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TechInterfaces.Dispensers.BlockCoordDispenser _blockCoordDispenser;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.ParticleSystem ps;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TSDF2.TSDF_SROptions debugOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TSDF2.TSDF_Updater tsdfUpdater;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TSDF2.TSDF_BlockDecayTracker _decayTracker;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TSDF2.SurfaceVerticesUpdater vertexUpdater;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long lastUpdateTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long lastGenTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera m_Camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.Vector3> coordsToAdd;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.Vector3> coordsToRemove;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(SharedTechAssets.Scripts.TechInterfaces.Dispensers.BlockCoordDispenser blockCoordDispenser, SharedTechAssets.Scripts.TSDF2.TSDF_Config2 config, com.illumix.IntVector3.IntVector3Cache coordCache, UnityEngine.Camera m_Camera)
        {
            var val_7;
            SharedTechAssets.Scripts.TSDF2.TSDF_SROptions val_1 = null;
            val_7 = 0;
            val_1 = new SharedTechAssets.Scripts.TSDF2.TSDF_SROptions(tSDF:  this);
            this.debugOptions = val_1;
            SRDebugger.Services.IDebugService val_2 = SRDebug.Instance;
            if(val_2 != null)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                val_7 = 12;
                val_2.AddOptionContainer(container:  this.debugOptions);
            }
            
            this._blockCoordDispenser = blockCoordDispenser;
            this.config = config;
            this.coordCache = coordCache;
            this.tsdfUpdater = new SharedTechAssets.Scripts.TSDF2.TSDF_Updater(tsdfDomain:  this);
            .domain = this;
            this.vertexUpdater = new SharedTechAssets.Scripts.TSDF2.SurfaceVerticesUpdater();
            this._decayTracker = new SharedTechAssets.Scripts.TSDF2.TSDF_BlockDecayTracker(domain:  this);
            this.m_Camera = m_Camera;
            this.SetupData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this.TeardownData();
            this.config = 0;
            this.tsdfUpdater = 0;
            this.vertexUpdater = 0;
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
            mem[1152921523043575336] = val_2;
            mem[1152921523043575320] = val_3;
            this.data = val_4;
            this.coordsToUpdatePool = new System.Collections.Generic.Queue<CoordUpdate>();
            this.coordToBlockKeyCache = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, com.illumix.IntVector3.IntVector3>();
            if(this.config.showParticles == false)
            {
                    return;
            }
            
            this.ps = UnityEngine.Object.Instantiate<UnityEngine.ParticleSystem>(original:  this.config.pointCloudParticlePrefab);
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
            this.vertexUpdater = 0;
            this.coordsToUpdatePool = 0;
            this.coordCache = 0;
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
        public SharedTechAssets.Scripts.TSDF2.TSDF_Manager.CoordUpdate GenerateTuple(com.illumix.IntVector3.IntVector3 coord, bool isAdd, bool isSeparator)
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
        public SharedTechAssets.Scripts.TSDF2.TSDF_Manager.TSDF_Data MakeNewData()
        {
            TSDF_Data val_0;
            val_0.tsdfStore = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, SharedTechAssets.Scripts.TSDF2.Voxel>>();
            val_0.cachedBlocks = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, SharedTechAssets.Scripts.TSDF2.VoxelBlock>();
            val_0.lastUpdatedBlocks = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean>>();
            val_0.blocksToUpdateCoords = new System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>();
            val_0.coordsToUpdate = new System.Collections.Generic.List<CoordUpdate>();
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedTechAssets.Scripts.TSDF2.VoxelBlock MakeNewVoxelBlock()
        {
            return (SharedTechAssets.Scripts.TSDF2.VoxelBlock)new SharedTechAssets.Scripts.TSDF2.VoxelBlock(blockSize:  this.config.blockSize);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetColumnPos(com.illumix.IntVector3.IntVector3 coord, com.illumix.IntVector3.IntVector3 blockKey, out int x, out int z)
        {
            int val_7 = this.config.blockSize;
            val_7 = blockKey.Item1 * val_7;
            val_7 = coord.Item1 - (val_7 << 1);
            int val_3 = (val_7 < 0) ? (val_7 + 1) : (val_7);
            val_3 = val_3 >> 1;
            x = val_3;
            int val_8 = this.config.blockSize;
            val_8 = blockKey.Item3 * val_8;
            val_8 = coord.Item3 - (val_8 << 1);
            int val_6 = (val_8 < 0) ? (val_8 + 1) : (val_8);
            val_6 = val_6 >> 1;
            z = val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetLayerPos(com.illumix.IntVector3.IntVector3 coord, com.illumix.IntVector3.IntVector3 blockKey)
        {
            int val_5 = this.config.blockSize;
            val_5 = blockKey.Item2 * val_5;
            val_5 = coord.Item2 - (val_5 << 1);
            return (int)((val_5 < 0) ? (val_5 + 1) : (val_5)) >> 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 IntVectorToVertexPosition(com.illumix.IntVector3.IntVector3 intVertex, float resolution)
        {
            var val_6;
            var val_7;
            if(intVertex != null)
            {
                    val_6 = intVertex.Item1;
                val_7 = intVertex.Item2;
            }
            else
            {
                    val_6 = 0.Item1;
                val_7 = 0.Item2;
            }
            
            float val_6 = (float)val_6;
            float val_7 = (float)val_7;
            float val_8 = (float)intVertex.Item3;
            float val_9 = 0.5f;
            val_6 = val_6 * resolution;
            val_7 = val_7 * resolution;
            val_8 = val_8 * resolution;
            val_6 = val_6 * val_9;
            val_7 = val_7 * val_9;
            val_9 = val_8 * val_9;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public com.illumix.IntVector3.IntVector3 GetBlockKey(com.illumix.IntVector3.IntVector3 discretePoint)
        {
            System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, com.illumix.IntVector3.IntVector3> val_31;
            var val_32;
            var val_33;
            int val_34;
            var val_35;
            var val_36;
            int val_37;
            var val_38;
            var val_39;
            int val_40;
            val_31 = this.coordToBlockKeyCache;
            if((val_31.TryGetValue(key:  discretePoint, value: out  0)) == true)
            {
                    return val_31;
            }
            
            if(discretePoint != null)
            {
                    val_32 = discretePoint.Item1;
                val_33 = discretePoint;
            }
            else
            {
                    val_32 = 0.Item1;
                val_33 = 0;
            }
            
            int val_5 = val_33.Item1;
            if((val_32 & 2147483648) != 0)
            {
                goto label_6;
            }
            
            var val_6 = (val_5 < 0) ? (val_5 + 1) : (val_5);
            val_6 = val_6 >> 1;
            val_34 = val_6 / this.config.blockSize;
            if(discretePoint == null)
            {
                goto label_7;
            }
            
            label_9:
            val_35 = discretePoint.Item2;
            val_36 = discretePoint;
            goto label_8;
            label_6:
            var val_10 = ((val_5 + 1) < 0) ? (val_5 + 2) : (val_5 + 1);
            val_10 = val_10 >> 1;
            val_10 = val_10 / this.config.blockSize;
            val_34 = val_10 - 1;
            if(discretePoint != null)
            {
                goto label_9;
            }
            
            label_7:
            val_35 = 0.Item2;
            val_36 = 0;
            label_8:
            int val_12 = val_36.Item2;
            if((val_35 & 2147483648) != 0)
            {
                goto label_10;
            }
            
            var val_13 = (val_12 < 0) ? (val_12 + 1) : (val_12);
            val_13 = val_13 >> 1;
            val_37 = val_13 / this.config.blockSize;
            if(discretePoint == null)
            {
                goto label_11;
            }
            
            label_13:
            val_38 = discretePoint.Item3;
            val_39 = discretePoint;
            goto label_12;
            label_10:
            var val_17 = ((val_12 + 1) < 0) ? (val_12 + 2) : (val_12 + 1);
            val_17 = val_17 >> 1;
            val_17 = val_17 / this.config.blockSize;
            val_37 = val_17 - 1;
            if(discretePoint != null)
            {
                goto label_13;
            }
            
            label_11:
            val_38 = 0.Item3;
            val_39 = 0;
            label_12:
            int val_19 = val_39.Item3;
            if((val_38 & 2147483648) == 0)
            {
                    var val_20 = (val_19 < 0) ? (val_19 + 1) : (val_19);
                val_20 = val_20 >> 1;
                val_40 = val_20 / this.config.blockSize;
            }
            else
            {
                    var val_23 = ((val_19 + 1) < 0) ? (val_19 + 2) : (val_19 + 1);
                val_23 = val_23 >> 1;
                val_23 = val_23 / this.config.blockSize;
                val_40 = val_23 - 1;
            }
            
            val_31 = this.GenerateIntVector(x:  val_34, y:  val_37, z:  val_40);
            this.coordToBlockKeyCache.set_Item(key:  discretePoint, value:  val_31);
            return val_31;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public com.illumix.IntVector3.IntVector3 BlockKeyToResolutionSpace(com.illumix.IntVector3.IntVector3 blockKey)
        {
            var val_10;
            var val_11;
            if(blockKey != null)
            {
                    val_10 = blockKey.Item1;
                val_11 = blockKey.Item2;
            }
            else
            {
                    val_10 = 0.Item1;
                val_11 = 0.Item2;
            }
            
            int val_6 = this.config.blockSize << 1;
            return this.GenerateIntVector(x:  val_6 * val_10, y:  val_6 * val_11, z:  val_6 * blockKey.Item3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CountData()
        {
            int val_4;
            var val_14;
            int val_15;
            var val_16;
            var val_17;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = Values.GetEnumerator();
            val_14 = 0;
            val_15 = 0;
            goto label_3;
            label_7:
            GameUI.EmailUIDataHandler val_5 = val_4.emailUIDataHandler;
            val_15 = val_5._masterDomain.Count + val_15;
            label_3:
            if((1258610400 & 1) != 0)
            {
                goto label_7;
            }
            
            val_16 = 0;
            val_17 = 1;
            long val_9 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523045326560});
            object[] val_12 = new object[5];
            val_4 = this.Count;
            val_12[0] = val_4;
            val_12[1] = (val_5._masterDomain.Count > 0) ? (val_14 + 1) : (val_14);
            val_12[2] = val_15;
            val_12[3] = 0;
            val_12[4] = this.data.Count;
            string val_13 = System.String.Format(format:  "Number of Blocks: {0} Non-empty: {1} Number of Surface Coordinates: {2} Number of triangles: {3} Number of TSDF voxels: {4}", args:  val_12);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SendBlockCoordEvents()
        {
            var val_3;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            HashSet.Enumerator<T> val_1 = GetEnumerator();
            val_27 = 0;
            label_37:
            if((1258845264 & 1) == 0)
            {
                goto label_2;
            }
            
            GameUI.EmailUIDataHandler val_4 = val_3.emailUIDataHandler;
            System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean> val_5 = X21.Item[val_4];
            com.illumix.IntVector3.IntVector3 val_6 = this.BlockKeyToResolutionSpace(blockKey:  val_4);
            UnityEngine.Vector3 val_17 = this.IntVectorToVertexPosition(intVertex:  this.GenerateIntVector(x:  val_6.Item1 + (((this.config.blockSize < 0) ? (this.config.blockSize + 1) : this.config.blockSize) >> 1), y:  val_6.Item2 + (((this.config.blockSize < 0) ? (this.config.blockSize + 1) : this.config.blockSize) >> 1), z:  val_6.Item3 + (((this.config.blockSize < 0) ? (this.config.blockSize + 1) : this.config.blockSize) >> 1)), resolution:  this.config.props);
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_19 = val_5.Keys.GetEnumerator();
            label_21:
            if((1258845232 & 1) == 0)
            {
                goto label_13;
            }
            
            GameUI.EmailUIDataHandler val_20 = val_3.emailUIDataHandler;
            if(val_5.Item[val_20] == false)
            {
                goto label_15;
            }
            
            UnityEngine.Vector3 val_22 = this.IntVectorToVertexPosition(intVertex:  val_20, resolution:  this.config.props);
            this.coordsToAdd.Add(item:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
            goto label_21;
            label_15:
            UnityEngine.Vector3 val_23 = this.IntVectorToVertexPosition(intVertex:  val_20, resolution:  this.config.props);
            this.coordsToRemove.Add(item:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
            goto label_21;
            label_13:
            val_28 = 1152921518724775088;
            val_29 = val_27;
            long val_24 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523045561392});
            if(((281 == 0) ? 281 : 281) == 281)
            {
                
            }
            
            this._blockCoordDispenser.UpdateBlockEvent(center:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, pointsToAdd:  this.coordsToAdd, pointsToRemove:  this.coordsToRemove);
            this.coordsToAdd.Clear();
            this.coordsToRemove.Clear();
            goto label_37;
            label_2:
            val_30 = 356;
            long val_26 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523045561424});
            if( == 0)
            {
                    return;
            }
            
            if(281 == 0)
            {
                    return;
            }
            
            if(281 == 356)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FeaturePointsUpdate(UnityEngine.Vector3[] realPoints, UnityEngine.Vector3 cameraPosition)
        {
            long val_4;
            System.DateTime val_1 = System.DateTime.UtcNow;
            long val_2 = val_1.dateData.Ticks;
            val_4 = this.lastUpdateTime;
            long val_3 = 1844674407370955 - val_4;
            if(this.config.updateTime >= 0)
            {
                    return;
            }
            
            val_4 = this.config;
            if(this.config.disableFeaturePoints != true)
            {
                    val_4 = this.tsdfUpdater;
                val_4.Add_FeaturePoints(points:  realPoints, cameraPosition:  new UnityEngine.Vector3() {x = cameraPosition.x, y = cameraPosition.y, z = cameraPosition.z});
                this._decayTracker.UpdateTimes();
                this._decayTracker.QueryBlocksToRemove();
                this.SendBlockCoordEvents();
                this.vertexUpdater.UpdateCachedBlocks();
            }
            
            this.lastUpdateTime = 1844674407370955;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DepthModel_Update(UnityEngine.Vector3[,] vertices, bool[,] keepMask, UnityEngine.Vector3 cameraPt)
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            long val_2 = val_1.dateData.Ticks;
            this.tsdfUpdater.Add_DepthModel_Depth(vertices:  vertices, keepMask:  keepMask, cameraPt:  new UnityEngine.Vector3() {x = cameraPt.x, y = cameraPt.y, z = cameraPt.z});
            this.vertexUpdater.UpdateCachedBlocks();
            System.DateTime val_3 = System.DateTime.UtcNow;
            long val_4 = val_3.dateData.Ticks;
            if(this.config != null)
            {
                    return;
            }
        
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
            this.coordsToAdd = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this.coordsToRemove = new System.Collections.Generic.List<UnityEngine.Vector3>();
        }
    
    }

}
