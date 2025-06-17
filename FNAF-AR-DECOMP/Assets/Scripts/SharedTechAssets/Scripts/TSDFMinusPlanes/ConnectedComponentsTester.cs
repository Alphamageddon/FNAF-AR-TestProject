using UnityEngine;

namespace SharedTechAssets.Scripts.TSDFMinusPlanes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ConnectedComponentsTester : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private IllumixEngineConfig _engineConfig;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private IllumixAdapter _illumixAdapter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private IllumixSurfaceManager _illumixSurfaceManager;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MeshBlockDispenser mbDispenser;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int size;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool[,,] randomGrid;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool firstTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private com.illumix.IntVector3.IntVector3Cache coordCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TSDFMinusPlanes.ConnectedComponentsTracker cct;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TSDFMinusPlanes.MarchingCubes c;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long lastUpdateTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Random r;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int count;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.GetConfigs();
            this.BuildConnections();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetConfigs()
        {
            this._engineConfig = this.GetComponent<IllumixEngineConfig>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BuildConnections()
        {
            this._illumixAdapter = new IllumixAdapter();
            this._illumixSurfaceManager = new IllumixSurfaceManager();
            MeshBlockDispenser val_3 = new MeshBlockDispenser();
            this.mbDispenser = val_3;
            System.Collections.Generic.List<IMeshBlockAccepter> val_4 = new System.Collections.Generic.List<IMeshBlockAccepter>();
            val_4.Add(item:  this._illumixAdapter);
            val_3.SetAccepters(accepters:  val_4);
            this._illumixSurfaceManager.Setup(config:  this._engineConfig, m_Camera:  0);
            this._illumixAdapter.Setup(surfaceManager:  this._illumixSurfaceManager);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Initialize()
        {
            com.illumix.IntVector3.IntVector3Cache val_1 = new com.illumix.IntVector3.IntVector3Cache();
            this.coordCache = val_1;
            this.cct = new SharedTechAssets.Scripts.TSDFMinusPlanes.ConnectedComponentsTracker(coordCache:  val_1);
            this.c = new SharedTechAssets.Scripts.TSDFMinusPlanes.MarchingCubes(cache:  this.coordCache, dispenser:  this.mbDispenser);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            var val_13;
            SharedTechAssets.Scripts.TSDFMinusPlanes.ConnectedComponentsTester val_14;
            System.Collections.Generic.Dictionary<TKey, TValue> val_15;
            var val_16;
            var val_19;
            val_14 = this;
            if(this.firstTime != false)
            {
                    this.Initialize();
                this.firstTime = false;
            }
            
            System.DateTime val_1 = System.DateTime.UtcNow;
            long val_2 = val_1.dateData.Ticks;
            if((1844674407370955 - this.lastUpdateTime) < 251)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean> val_4 = null;
            val_15 = val_4;
            val_4 = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean>();
            if(this.r >= 1)
            {
                    do
            {
                val_16 = null;
                val_16 = null;
                System.Random val_13 = this.r;
                System.Random val_5 = this.r << 1;
                System.Random val_14 = this.r;
                val_13 = val_13 << 1;
                val_14 = val_14 << 1;
                bool val_15 = this.randomGrid[(System.Random.__il2cppRuntimeField_byval_arg * (System.Random.__il2cppRuntimeField_name * (long)(int)((this.r << 1))) + (long)(int)((this.r << 1))) + (long)(int)((this.r << 1))];
                this.randomGrid[(System.Random.__il2cppRuntimeField_byval_arg * (System.Random.__il2cppRuntimeField_name * (long)(int)((this.r << 1))) + (long)(int)((this.r << 1))) + (long)(int)((this.r << 1))] = (this.randomGrid[(System.Random.__il2cppRuntimeField_byval_arg * (System.Random.__il2cppRuntimeField_name * (long)(int)((this.r << 1))) + (long)(int)((this.r << 1))) + (long)(int)((this.r << 1))][0] ^;
                System.Random val_18 = this.r;
                bool val_16 = this.randomGrid[(System.Random.__il2cppRuntimeField_byval_arg * (System.Random.__il2cppRuntimeField_name * (long)(int)((this.r << 1))) + (long)(int)((this.r << 1))) + (long)(int)((this.r << 1))];
                val_15 = val_15;
                SharedTechAssets.Scripts.TSDFMinusPlanes.ConnectedComponentsTester val_11 = (long)val_13 + (val_14 * (long)val_5);
                val_4.set_Item(key:  mem[1152921523030046440].GenerateIntVector(x:  val_5, y:  val_13, z:  val_14), value:  ((this.randomGrid[(this.randomGrid[(System.Random.__il2cppRuntimeField_byval_arg * (System.Random.__il2cppRuntimeField_name * (long)(int)((this.r << 1))) + (long)(int)((this.r << 1))) + (long)(int)((this.r << 1))][0] * (this * (long)(int)((this.r << 1))) + (long)(int)((this.r << 1))) + (long)(int)((this.r << 1))]) == true) ? 1 : 0);
                val_14 = val_14;
                val_18 = val_18 - 1;
            }
            while(val_18 != 0);
            
            }
            
            mem[1152921523030046448].UpdateVoxels(changes:  val_4);
            val_13 = mem[1152921523030046448];
            val_19 = val_13;
            if(val_13 != 0)
            {
                goto label_27;
            }
            
            val_19 = mem[1152921523030046448];
            if(val_19 == 0)
            {
                goto label_28;
            }
            
            label_27:
            mem[1152921523030046456].PerformMarchingCubes(discretizedPoints:  mem[1152921523030046448] + 72, updatedPoints:  mem[1152921523030046448] + 120);
            val_4.Clear();
            var val_19 = mem[1152921523030046480];
            val_19 = val_19 + 1;
            this.lastUpdateTime = 1844674407370955;
            mem[1152921523030046480] = val_19;
            return;
            label_28:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ConnectedComponentsTester()
        {
            null = null;
            int val_2 = SharedTechAssets.Scripts.TSDFMinusPlanes.ConnectedComponentsTester.size;
            val_2 = val_2 << 1;
            this.randomGrid = null;
            this.firstTime = true;
            this.r = new System.Random(Seed:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static ConnectedComponentsTester()
        {
            SharedTechAssets.Scripts.TSDFMinusPlanes.ConnectedComponentsTester.size = 3;
        }
    
    }

}
