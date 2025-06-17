using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class DepthObjectManager : ITimeUpdateAccepter
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DepthObjectManager_Config config;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DepthObjectManager.Vector3Manager vecManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Camera _camera;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.DepthHandler.DepthPredictionStarter dps;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.IModelDownloadStatus _modelDownloadStatus;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const string MODEL_NAME = "FCRN_Depth";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool isModelDownloaded;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DepthMapDispenser dispenser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private RawDirectedPointsDispenser dirPtsDispenser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.TechInterfaces.Dispensers.RawDepthMapDispenser _rawDepthMapDispenser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool pendingResponse;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.ParticleSystem currentPS;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DepthObjectManager_SROptions debugOptions;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject sphereParent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const int UP = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const int DOWN = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const int LEFT = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const int RIGHT = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool lastOrientationIsLandscape;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Matrix4x4 lastCameraWorldTransform;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Matrix4x4 lastCameraProjectionMatrix;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 lastCameraPosition;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float[] lastSparseData;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DepthObjectManager.ImageType lastImageType;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool firstTime;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Vector3[,] vertices;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool[,] isClose;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double[] filteredMap;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DepthObjectManager.ImageParams _imgParams;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private long lastDepthFire;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool initModel;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Setup(DepthMapDispenser dispenser, RawDirectedPointsDispenser dirPtsDispenser, SharedTechAssets.Scripts.TechInterfaces.Dispensers.RawDepthMapDispenser rawDepthMapDispenser, DepthObjectManager_Config config, UnityEngine.Camera m_Camera, SharedTechAssets.Scripts.IModelDownloadStatus modelDownloadStatus)
    {
        var val_7;
        var val_8;
        var val_9;
        Vector3Manager val_10;
        .depthObjectManager = this;
        this.debugOptions = new DepthObjectManager_SROptions();
        SRDebugger.Services.IDebugService val_2 = SRDebug.Instance;
        if(val_2 != null)
        {
                var val_16 = 0;
            val_16 = val_16 + 1;
            val_2.AddOptionContainer(container:  this.debugOptions);
        }
        
        this.dispenser = dispenser;
        this.dirPtsDispenser = dirPtsDispenser;
        this._rawDepthMapDispenser = rawDepthMapDispenser;
        this.config = config;
        this._modelDownloadStatus = modelDownloadStatus;
        this.currentPS = UnityEngine.Object.Instantiate<UnityEngine.ParticleSystem>(original:  config.pointCloudParticlePrefab);
        UnityEngine.GameObject val_5 = new UnityEngine.GameObject();
        this.sphereParent = val_5;
        Vector3Manager val_6 = val_5.CreateManager();
        mem[1152921518926338472] = val_7;
        mem[1152921518926338456] = val_8;
        mem[1152921518926338440] = val_9;
        this.vecManager = val_10;
        this.dps = new SharedTechAssets.Scripts.DepthHandler.DepthPredictionStarter(manager:  this, camera:  m_Camera);
        UnityCVManager.Instance.SetupFloatCallback(callback:  new UnityCVManager.FloatUpdate(object:  this, method:  System.Void DepthObjectManager::HandleFloatUpdate(float[] floats)));
        UnityCVManager.Instance.SetupIntCallback(callback:  new UnityCVManager.IntUpdate(object:  this, method:  System.Void DepthObjectManager::HandleIntUpdate(int cropType)));
        this._camera = m_Camera;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Teardown()
    {
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        if(val_1 != null)
        {
                var val_3 = 0;
            val_3 = val_3 + 1;
            val_1.RemoveOptionContainer(container:  this.debugOptions);
        }
        
        this.debugOptions = 0;
        this.dispenser = 0;
        UnityEngine.Object.Destroy(obj:  this.currentPS);
        this.currentPS = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool GetWithinBounds(int minBoundary, int point, int maxBoundaryExclusive)
    {
        return (bool)((minBoundary <= point) ? 1 : 0) & ((point < maxBoundaryExclusive) ? 1 : 0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DepthObjectManager.Vector3Manager CreateManager()
    {
        Vector3Manager val_0;
        val_0.directionVectors = new UnityEngine.Vector3[4];
        val_0.depthPoint.x = 0f;
        val_0.depthPoint.y = 0f;
        val_0.depthPoint.z = 0f;
        mem[1152921518926911188] = 0;
        val_0.featurePointsUsed = new System.Collections.Generic.List<UnityEngine.Vector3>();
        val_0.directions = new System.Collections.Generic.List<UnityEngine.Vector3>();
        val_0.currentDirection.x = 0f;
        val_0.currentDirection.y = 0f;
        val_0.currentDirection.z = 0f;
        mem[1152921518926911220] = 0;
        return val_0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool GetDirection(int hIndex, int wIndex, int w, int h, double[] depth)
    {
        int val_12;
        DepthObjectManager_Config val_13;
        float val_14;
        var val_15;
        val_12 = h;
        val_13 = this.config;
        int val_1 = hIndex - this.config.downsampleRate;
        if((val_1 & 2147483648) == 0)
        {
                hIndex = this.config.downsampleRate + hIndex;
            if(hIndex < val_12)
        {
                int val_2 = wIndex - this.config.downsampleRate;
            if((val_2 & 2147483648) == 0)
        {
                val_13 = this.config.downsampleRate + wIndex;
            if(val_13 < w)
        {
                this.SetViewSpacePointFromIndexes(h_depth:  hIndex, w_depth:  wIndex, w:  w, h:  val_12, depth:  depth, dirVecIdx:  0);
            this.SetViewSpacePointFromIndexes(h_depth:  val_1, w_depth:  wIndex, w:  w, h:  val_12, depth:  depth, dirVecIdx:  1);
            this.SetViewSpacePointFromIndexes(h_depth:  hIndex, w_depth:  val_2, w:  w, h:  val_12, depth:  depth, dirVecIdx:  2);
            this.SetViewSpacePointFromIndexes(h_depth:  hIndex, w_depth:  val_13, w:  w, h:  val_12, depth:  depth, dirVecIdx:  3);
            float val_11 = mem[this.vecManager + 76];
            val_12 = this.vecManager;
            val_11 = val_11 - (mem[this.vecManager + 64]);
            val_11 = val_11 / ((mem[this.vecManager + 68]) - (mem[this.vecManager + 56]));
            float val_12 = mem[this.vecManager + 48];
            float val_4 = this.vecManager.currentDirection - (mem[this.vecManager + 52]);
            val_12 = (mem[this.vecManager + 36]) - val_12;
            val_12 = val_4 / val_12;
            double val_5 = (double)val_11 * (double)val_11;
            val_4 = (double)val_12 * (double)val_12;
            val_5 = val_5 + val_4;
            val_4 = val_5 + 1;
            if(val_5 >= _TYPE_MAX_)
        {
                val_14 = val_4;
        }
        
            val_4 = (double)val_11 / val_14;
            double val_6 = (double)val_12 / val_14;
            double val_7 = 1 / val_14;
            UnityEngine.Vector3 val_9 = this._camera.transform.TransformDirection(direction:  new UnityEngine.Vector3() {x = (double)val_12, y = (double)val_11, z = 1});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(d:  -1f, a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            val_15 = 1;
            mem[1152921518927101760] = val_10.x;
            mem[1152921518927101764] = val_10.y;
            mem[1152921518927101768] = val_10.z;
            return (bool)val_15;
        }
        
        }
        
        }
        
        }
        
        val_15 = 0;
        return (bool)val_15;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SetViewSpacePointFromIndexes(int h_depth, int w_depth, int w, int h, double[] depth, int dirVecIdx)
    {
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        val_20 = w;
        val_21 = w_depth;
        val_22 = h_depth;
        val_23 = dirVecIdx;
        val_24 = h;
        val_25 = this;
        double val_20 = depth[(long)val_21 + (val_20 * val_22)];
        if(UnityEngine.Input.deviceOrientation != 3)
        {
                if(UnityEngine.Input.deviceOrientation != 4)
        {
                if(UnityEngine.Screen.width <= UnityEngine.Screen.height)
        {
            goto label_4;
        }
        
        }
        
        }
        
        float val_8 = (float)UnityEngine.Screen.height / (float)UnityEngine.Screen.width;
        float val_9 = 1f - val_8;
        val_9 = val_9 * 0.5f;
        float val_21 = (float)val_21;
        float val_22 = (float)val_22;
        val_21 = val_21 / ((float)val_20 - 1);
        var val_23 = 12;
        val_22 = val_22 / ((float)val_24 - 1);
        val_23 = this.vecManager + ((long)val_23 * val_23);
        val_21 = val_21 * val_8;
        var val_12 = val_23 + 32;
        val_21 = val_21 + val_9;
        val_22 = 1f - val_22;
        label_9:
        val_22 = ???;
        val_24 = ???;
        val_21 = ???;
        val_20 = ???;
        val_25 = ???;
        val_23 = ???;
        label_4:
        float val_15 = (float)UnityEngine.Screen.width / (float)UnityEngine.Screen.height;
        float val_16 = 1f - val_15;
        val_16 = val_16 * 0.5f;
        float val_24 = (float)val_21;
        float val_25 = (float)val_22;
        val_24 = val_24 / ((float)val_20 - 1);
        val_25 = val_25 / ((float)val_24 - 1);
        var val_26 = 12;
        val_25 = 1f - val_25;
        val_26 = (val_25 + 24) + ((long)val_23 * val_26);
        val_25 = val_25 * val_15;
        var val_19 = val_26 + 32;
        val_24 = 1f - val_24;
        val_25 = val_25 + val_16;
        goto label_9;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void HandleIntUpdate(int cropType)
    {
        ImageType val_7;
        if(UnityEngine.Input.deviceOrientation != 3)
        {
                if(UnityEngine.Input.deviceOrientation != 4)
        {
                if(UnityEngine.Screen.width <= UnityEngine.Screen.height)
        {
            goto label_7;
        }
        
        }
        
        }
        
        label_7:
        this.lastOrientationIsLandscape = true;
        if(cropType == 2)
        {
            goto label_3;
        }
        
        if(cropType != 1)
        {
            goto label_4;
        }
        
        var val_5 = (true == 0) ? 3 : (0 + 1);
        goto label_6;
        label_3:
        var val_6 = (true != 0) ? 2 : 4;
        goto label_6;
        label_4:
        val_7 = 0;
        label_6:
        this.lastImageType = val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void HandleFloatUpdate(float[] floats)
    {
        var val_2;
        var val_3;
        var val_4;
        UnityEngine.Matrix4x4 val_5;
        var val_7;
        var val_8;
        var val_9;
        UnityEngine.Matrix4x4 val_10;
        UnityEngine.Matrix4x4 val_1 = this._camera.worldToCameraMatrix;
        mem[1152921518927713468] = val_2;
        mem[1152921518927713452] = val_3;
        mem[1152921518927713436] = val_4;
        this.lastCameraWorldTransform = val_5;
        UnityEngine.Matrix4x4 val_6 = this._camera.projectionMatrix;
        mem[1152921518927713532] = val_7;
        mem[1152921518927713516] = val_8;
        mem[1152921518927713500] = val_9;
        this.lastCameraProjectionMatrix = val_10;
        UnityEngine.Vector3 val_13 = this._camera.gameObject.transform.position;
        this.lastCameraPosition = val_13;
        mem[1152921518927713552] = val_13.y;
        mem[1152921518927713556] = val_13.z;
        int val_18 = UnityCVManager.Instance.StartCoreMLSessionWithSparseDepth(sparseDepth:  this.dps.SetupForPrediction(floats:  floats), callback:  new UnityCVManager.CoreMLFrameUpdate(object:  this, method:  System.Void DepthObjectManager::CoreMLFrameUpdated(int index, string[] strings, float[] floats, int floatsW, int floatsH, double[] depth, int w, int h)), modelType:  1, useCPUOnly:  (this.config.useCPUOnly == true) ? 1 : 0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void FillFilterMap(double[] depth)
    {
        ImageParams val_49;
        var val_50;
        System.Boolean[,] val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        System.Single[] val_56;
        float val_57;
        System.Single[] val_58;
        float val_59;
        float val_60;
        float val_61;
        DepthObjectManager_Config val_62;
        int val_63;
        int val_64;
        DepthObjectManager_Config val_65;
        System.Double[] val_66;
        var val_68;
        DepthObjectManager val_69;
        var val_71;
        if(this.lastOrientationIsLandscape != false)
        {
                val_49 = this._imgParams;
            val_50 = 0;
            int val_1 = UnityEngine.Screen.height;
        }
        else
        {
                val_50 = 0;
        }
        
        ImageType val_47 = this.lastImageType;
        val_51 = UnityEngine.Screen.width;
        val_47 = val_47 - 1;
        if(val_47 > 3)
        {
            goto label_3;
        }
        
        var val_48 = 52950908 + ((this.lastImageType - 1)) << 2;
        val_48 = val_48 + 52950908;
        goto (52950908 + ((this.lastImageType - 1)) << 2 + 52950908);
        label_3:
        if(this.lastOrientationIsLandscape != false)
        {
                val_53 = UnityEngine.Screen.width;
            val_54 = 0;
            int val_6 = UnityEngine.Screen.height;
        }
        else
        {
                val_53 = UnityEngine.Screen.height;
            val_54 = 0;
        }
        
        int val_11 = val_53 - UnityEngine.Screen.width;
        val_52 = ((val_11 < 0) ? (val_11 + 1) : (val_11)) >> 1;
        int val_49 = this.lastSparseData.Length;
        if(val_49 < 3)
        {
                return;
        }
        
        val_49 = val_49 >> 32;
        float val_14 = (6.97344E+07f) / (float)val_51;
        val_49 = val_49 + (val_49 >> 63);
        label_98:
        if(this.lastOrientationIsLandscape != false)
        {
                val_55 = 0 + 0;
            float val_50 = this.lastSparseData[(long)val_55];
            val_50 = val_50 - (float)val_52;
            val_56 = (long)val_55 + 1;
            val_57 = this.lastSparseData[val_56];
            val_58 = this.lastSparseData;
            val_59 = val_14 * val_50;
            val_60 = (float)this._imgParams;
        }
        else
        {
                val_55 = 0 + 0;
            val_56 = this.lastSparseData;
            float val_51 = this.lastSparseData[(long)val_55];
            val_51 = val_14 * val_51;
            val_58 = this.lastSparseData;
            val_59 = (float)val_51 - val_51;
            val_60 = (float)this._imgParams;
            val_57 = (val_56[(long)val_55 + 1]) - (float)val_52;
        }
        
        val_57 = val_14 * val_57;
        var val_18 = val_55 + 2;
        val_61 = val_58[(long)val_18];
        val_62 = this.config;
        if(this.config == null)
        {
                val_62 = this.config;
        }
        
        float val_53 = (float)val_58;
        val_53 = (val_60 - val_57) - val_53;
        float val_54 = (float)this.config.downsampleRate;
        val_54 = val_53 / val_54;
        val_63 = (int)val_54;
        val_51 = this.isClose;
        val_64 = this.config.downsampleRate;
        if(((val_63 & 2147483648) != 0) || ((val_51.GetLength(dimension:  0)) <= val_63))
        {
            goto label_39;
        }
        
        float val_55 = (float)this.config;
        val_51 = this.isClose;
        val_55 = val_59 - val_55;
        val_55 = val_55 / (float)val_64;
        val_49 = (int)val_55;
        if(((val_49 & 2147483648) != 0) || ((val_51.GetLength(dimension:  1)) <= val_49))
        {
            goto label_39;
        }
        
        val_65 = this.config;
        if(val_65 == null)
        {
            goto label_30;
        }
        
        val_51 = val_18 + (this.config.downsampleRate * val_63);
        goto label_31;
        label_30:
        if(this.config == null)
        {
            goto label_32;
        }
        
        val_65 = this.config;
        val_51 = this.lastCameraProjectionMatrix + (this.config.downsampleRate * val_63);
        label_31:
        val_66 = depth;
        int val_21 = this.config.downsampleRate + (this.config.downsampleRate * val_49);
        val_56 = val_21 + (this.lastCameraProjectionMatrix * val_51);
        if(val_66 == 0)
        {
                val_66 = depth;
        }
        
        if(val_61 < 0)
        {
            goto label_39;
        }
        
        System.Double[] val_22 = depth + (((long)(int)((this.lastCameraProjectionMatrix * (this.config.downsampleRate * (((this._imgParams - ((6.97344E+07f / val_2) * (this.lastSparseData[(long)(int)(((0 + 0) + 1))][0] - (val_11 < 0 ? ((val_9 - val_10) + 1) : (val_9 - val_10) >> 1)))) - this.lastSparseData) / this.config.downsampleRate)) + this.lastCameraProjectionMatrix) + (this.config.downsampleRate * (((val_2 - ((6.97344E+07f / val_2) * this.lastSparseData[(long)(int)((0 + 0))][0])) - this.config) / this.config.downsampleRate)) + this.config.downsampleRate)) << 3);
        var val_56 = (depth + ((long)(int)((this.lastCameraProjectionMatrix * (this.config.downsampleRate * (((this._imgParams - ((6.97344E+07f / val_2) * (this.lastSparseData[(long)(int)(((0 + 0) + 1))][0] - (val_11 < 0  + 32;
        val_56 = (float)val_56 - val_61;
        val_63 = val_63;
        if((System.Math.Abs(val_56) / val_61) > this.config.fpDeviationThreshold)
        {
            goto label_39;
        }
        
        val_68 = (long)val_63;
        this.isClose[(System.Math.__il2cppRuntimeField_cctor_finished + 16 * (long)(int)((((this._imgParams - ((6.97344E+07f / val_2) * (this.lastSparseData[(long)(int)(((0 + 0) + 1))][0] - (val_11 < 0 ? ((val_9 - val_10) + 1) : (val_9 - val_10) >> 1)))) - this.lastSparseData) / this.config.downsampleRate))) + (long)(int)((((val_2 - ((6.97344E+07f / val_2) * this.lastSparseData[(long)(int)((0 + 0))][0])) - this.config) / this.config.downsampleRate))] = true;
        UnityEngine.Camera.main.worldToCameraMatrix = new UnityEngine.Matrix4x4() {m00 = this.lastCameraWorldTransform, m10 = this.lastCameraWorldTransform, m20 = this.lastCameraWorldTransform, m30 = this.lastCameraWorldTransform, m01 = this.lastCameraWorldTransform + 16, m11 = this.lastCameraWorldTransform + 16, m21 = this.lastCameraWorldTransform + 16, m31 = this.lastCameraWorldTransform + 16, m02 = this.lastCameraWorldTransform + 32, m12 = this.lastCameraWorldTransform + 32, m22 = this.lastCameraWorldTransform + 32, m32 = this.lastCameraWorldTransform + 32, m03 = this.lastCameraWorldTransform + 48, m13 = this.lastCameraWorldTransform + 48, m23 = this.lastCameraWorldTransform + 48, m33 = this.lastCameraWorldTransform + 48};
        val_69 = this;
        UnityEngine.Camera.main.projectionMatrix = new UnityEngine.Matrix4x4() {m00 = this.lastCameraProjectionMatrix, m10 = this.lastCameraProjectionMatrix, m20 = this.lastCameraProjectionMatrix, m30 = this.lastCameraProjectionMatrix, m01 = this.lastCameraProjectionMatrix + 16, m11 = this.lastCameraProjectionMatrix + 16, m21 = this.lastCameraProjectionMatrix + 16, m31 = this.lastCameraProjectionMatrix + 16, m02 = this.lastCameraProjectionMatrix + 32, m12 = this.lastCameraProjectionMatrix + 32, m22 = this.lastCameraProjectionMatrix + 32, m32 = this.lastCameraProjectionMatrix + 32, m03 = this.lastCameraProjectionMatrix + 48, m13 = this.lastCameraProjectionMatrix + 48, m23 = this.lastCameraProjectionMatrix + 48, m33 = this.lastCameraProjectionMatrix + 48};
        if(this.config.computeFPDirection != false)
        {
                this.SetViewSpacePointFromIndexes(h_depth:  val_51, w_depth:  val_21, w:  mem[1152921518928395044], h:  val_49, depth:  depth, dirVecIdx:  0);
            if((this.GetDirection(hIndex:  val_51, wIndex:  val_21, w:  mem[1152921518928395044], h:  val_49, depth:  depth)) != false)
        {
                UnityEngine.Vector3 val_29 = UnityEngine.Camera.main.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[1152921518928394712] + 32, y = mem[1152921518928394712] + 32 + 4, z = mem[1152921518928394712] + 40});
            mem[1152921518928394736].Add(item:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
            val_61 = mem[1152921518928394752];
            val_64 = mem[1152921518928394760];
            mem[1152921518928394744].Add(item:  new UnityEngine.Vector3() {x = val_61, y = mem[1152921518928394756], z = val_64});
        }
        
            UnityEngine.Camera.main.ResetWorldToCameraMatrix();
            val_51 = UnityEngine.Camera.main;
            val_51.ResetProjectionMatrix();
        }
        
        val_63 = val_63;
        float val_32 = val_49 + 1;
        float val_33 = val_49 - 1;
        val_56 = 1;
        goto label_55;
        label_97:
        if((val_56 & 2147483648) == 0)
        {
                var val_61 = 0;
            var val_60 = 0;
            do
        {
            float val_58 = val_32;
            val_68 = val_63 + val_60;
            float val_34 = val_58 + val_61;
            float val_35 = val_63 + val_61;
            if(((val_68 & 2147483648) == 0) && (val_68 < (val_51.GetLength(dimension:  0))))
        {
                if(((val_34 & 2147483648) == 0) && (val_34 < (val_51.GetLength(dimension:  1))))
        {
                val_58 = (long)val_34 + ((((((val_2 - ((6.97344E+07f / val_2) * this.lastSparseData[(long)(int)((0 + 0))][0])) - this.config) / this.config.downsampleRate) + 1) + 16) * (long)val_68);
            val_51[val_58] = true;
            val_69 = this;
            val_71 = val_56;
        }
        
        }
        
            float val_59 = val_33;
            val_51 = val_51;
            float val_38 = val_59 + val_60;
            if(((val_35 & 2147483648) == 0) && (val_35 < (val_51.GetLength(dimension:  0))))
        {
                val_51 = val_51;
            if(((val_38 & 2147483648) == 0) && (val_38 < (val_51.GetLength(dimension:  1))))
        {
                val_51 = val_51;
            val_59 = (long)val_38 + ((((((val_2 - ((6.97344E+07f / val_2) * this.lastSparseData[(long)(int)((0 + 0))][0])) - this.config) / this.config.downsampleRate) - 1) + 16) * (long)val_35);
            val_51[val_59] = true;
            val_69 = this;
            val_63 = val_63;
            val_71 = val_56;
        }
        
        }
        
            if((val_60 != 0) && (val_71 != val_60))
        {
                if(((val_68 & 2147483648) == 0) && (val_68 < (val_51.GetLength(dimension:  0))))
        {
                if(((val_38 & 2147483648) == 0) && (val_38 < (val_51.GetLength(dimension:  1))))
        {
                val_68 = (long)val_68;
            val_51[(long)val_38 + (val_71 * val_68)] = true;
            val_63 = val_63;
            val_71 = val_56;
        }
        
        }
        
            val_51 = val_51;
            if(((val_35 & 2147483648) == 0) && (val_35 < (val_51.GetLength(dimension:  0))))
        {
                val_51 = val_51;
            if(((val_34 & 2147483648) == 0) && (val_34 < (val_51.GetLength(dimension:  1))))
        {
                val_51 = val_51;
            val_51[(long)val_34 + (val_38 * (long)val_35)] = true;
            val_63 = val_63;
            val_71 = val_56;
        }
        
        }
        
        }
        
            val_60 = val_60 + 1;
            val_61 = val_61 - 1;
        }
        while(val_71 >= val_60);
        
        }
        
        float val_62 = val_32;
        val_56 = val_71 + 1;
        val_62 = val_62 + 1;
        float val_63 = val_33;
        val_63 = val_63 - 1;
        label_55:
        val_49 = this.config;
        if(val_56 <= this.config.radius)
        {
            goto label_97;
        }
        
        label_39:
        var val_64 = 0;
        val_64 = val_64 + 1;
        if(val_64 != val_49)
        {
            goto label_98;
        }
        
        return;
        label_32:
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SetupImageParameters(int w, int h)
    {
        if(this.config != null)
        {
            goto label_0;
        }
        
        this.config = this.config;
        if(this.config == null)
        {
            goto label_1;
        }
        
        label_0:
        float val_5 = this.config.depthModelIgnoreBoundary;
        float val_4 = 1f;
        int val_8 = this.config.downsampleRate;
        int val_6 = (int)val_5 * (float)h;
        val_4 = val_4 - val_5;
        val_5 = val_5 * (float)w;
        int val_7 = (int)val_5;
        mem[1152921518928965800] = val_6;
        mem[1152921518928965808] = val_7;
        val_6 = ((int)val_4 * (float)h) - val_6;
        val_7 = ((int)val_4 * (float)w) - val_7;
        val_6 = val_6 / val_8;
        val_8 = val_7 / val_8;
        this._imgParams = h;
        mem[1152921518928965796] = w;
        mem[1152921518928965804] = (int)val_4 * (float)h;
        mem[1152921518928965812] = (int)val_4 * (float)w;
        mem[1152921518928965816] = val_6;
        mem[1152921518928965820] = val_8;
        return;
        label_1:
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ProcessDepthMap(double[] depth, int w, int h)
    {
        int val_54;
        UnityEngine.Vector3[] val_55;
        DepthObjectManager_Config val_56;
        DepthObjectManager.Representation val_57;
        var val_60;
        int val_61;
        var val_62;
        int val_65;
        var val_67;
        var val_68;
        ImageType val_69;
        float val_70;
        float val_71;
        double val_73;
        UnityEngine.GameObject val_74;
        UnityEngine.Transform val_75;
        DepthObjectManager_Config val_76;
        float val_78;
        var val_79;
        float val_86;
        System.Double[] val_89;
        val_54 = h;
        val_55 = this;
        this.pendingResponse = false;
        if(w == 0)
        {
                return;
        }
        
        if(val_54 == 0)
        {
                return;
        }
        
        val_56 = this.config;
        if(this.config != null)
        {
            goto label_3;
        }
        
        val_56 = this.config;
        if(val_56 == null)
        {
            goto label_77;
        }
        
        label_3:
        val_57 = this.config.representation;
        if(this.config.onlyOneMap == false)
        {
            goto label_48;
        }
        
        if(this.config.representation != 0)
        {
                if((val_57 != 1) || (this.config.showSpheres == false))
        {
            goto label_48;
        }
        
        }
        
        System.Collections.IEnumerator val_2 = this.sphereParent.transform.GetEnumerator();
        label_32:
        var val_49 = 0;
        val_49 = val_49 + 1;
        if(val_2.MoveNext() == false)
        {
            goto label_18;
        }
        
        var val_50 = 0;
        val_50 = val_50 + 1;
        val_60 = val_2.Current;
        if(val_60 != null)
        {
                val_60 = 0;
        }
        
        UnityEngine.Object.Destroy(obj:  val_60.gameObject);
        goto label_32;
        label_18:
        val_61 = 0;
        val_62 = 139;
        val_57 = val_57;
        if(val_2 != null)
        {
                var val_51 = 0;
            val_51 = val_51 + 1;
            val_2.Dispose();
        }
        
        label_48:
        if(this.firstTime != false)
        {
                this.SetupImageParameters(w:  w, h:  val_54);
            this.vertices = null;
            this.isClose = null;
            this.filteredMap = new double[0];
            this._rawDepthMapDispenser.SendAddEvent(w:  null, h:  val_57);
            this.firstTime = false;
            val_57 = val_57;
        }
        else
        {
                System.Array.Clear(array:  this.isClose, index:  0, length:  (Klass->__il2cppRuntimeField_interfaceOffsets[].offset * this.firstTime)>>0&0xFFFFFFFF);
            val_2.Clear();
            val_2.Clear();
            System.Array.Clear(array:  this.filteredMap, index:  0, length:  (Klass->__il2cppRuntimeField_interfaceOffsets[].offset * this.firstTime)>>0&0xFFFFFFFF);
        }
        
        DepthObjectManager_Config val_63 = this.config;
        if(this.config.filterNearFP != false)
        {
                this.FillFilterMap(depth:  depth);
        }
        
        if(this.lastOrientationIsLandscape != false)
        {
                val_67 = UnityEngine.Screen.height;
            val_68 = 0;
            int val_18 = UnityEngine.Screen.width;
        }
        else
        {
                val_67 = UnityEngine.Screen.width;
            val_68 = 0;
        }
        
        val_69 = this.lastImageType;
        float val_21 = (float)val_67 / (float)UnityEngine.Screen.height;
        if((val_69 - 1) > 3)
        {
            goto label_58;
        }
        
        var val_52 = 52950924 + ((this.lastImageType - 1)) << 2;
        val_52 = val_52 + 52950924;
        goto (52950924 + ((this.lastImageType - 1)) << 2 + 52950924);
        label_58:
        float val_53 = 1f;
        val_53 = val_53 - val_21;
        val_70 = val_53 * 0.5f;
        int val_54 = w;
        val_54 = val_54 - 1;
        if(val_63 >= val_54)
        {
            goto label_61;
        }
        
        float val_55 = (float)Klass->__il2cppRuntimeField_interfaceOffsets[].offset;
        val_55 = val_55 / ((float)val_54 - 1);
        val_71 = 1f - val_55;
        val_55 = val_21 * val_71;
        float val_24 = val_70 + val_55;
        label_126:
        val_76 = this.config;
        if(val_76 == null)
        {
            goto label_75;
        }
        
        goto label_76;
        label_75:
        DepthObjectManager_Config val_57 = this.config;
        if(val_57 == null)
        {
            goto label_77;
        }
        
        val_76 = val_57;
        label_76:
        val_57 = val_63 - val_57;
        val_78 = (float)depth[(long)(long)(int)((this.config + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset * w)))];
        DepthObjectManager_Config val_26 = val_57 / this.config.downsampleRate;
        if(this.lastOrientationIsLandscape != false)
        {
                float val_58 = (float)val_63;
            val_58 = val_58 / (float)val_54;
            val_58 = val_21 * val_58;
            val_58 = val_70 + val_58;
            val_79 = val_26;
        }
        else
        {
                float val_59 = (float)val_63;
            val_59 = val_59 / (float)val_54;
            val_59 = 1f - val_59;
        }
        
        UnityEngine.Camera.main.worldToCameraMatrix = new UnityEngine.Matrix4x4() {m00 = this.lastCameraWorldTransform.m00, m01 = this.lastCameraWorldTransform.m01, m02 = this.lastCameraWorldTransform.m02, m03 = this.lastCameraWorldTransform.m03};
        UnityEngine.Camera.main.projectionMatrix = new UnityEngine.Matrix4x4() {m00 = this.lastCameraProjectionMatrix, m10 = this.lastCameraProjectionMatrix, m20 = this.lastCameraProjectionMatrix, m30 = this.lastCameraProjectionMatrix, m01 = this.lastCameraProjectionMatrix + 16, m11 = this.lastCameraProjectionMatrix + 16, m21 = this.lastCameraProjectionMatrix + 16, m31 = this.lastCameraProjectionMatrix + 16, m02 = this.lastCameraProjectionMatrix + 32, m12 = this.lastCameraProjectionMatrix + 32, m22 = this.lastCameraProjectionMatrix + 32, m32 = this.lastCameraProjectionMatrix + 32, m03 = this.lastCameraProjectionMatrix + 48, m13 = this.lastCameraProjectionMatrix + 48, m23 = this.lastCameraProjectionMatrix + 48, m33 = this.lastCameraProjectionMatrix + 48};
        if(this.config.filterNearFP != false)
        {
                bool val_60 = this.isClose[(this.config.filterNearFP + 16 * (long)(int)(((Klass->__il2cppRuntimeField_interfaceOffsets[].offset - (long)(int)((this.config + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset * w)))) / this.config.downsampleRate))) + (long)(int)(((this.config - this.config) / this.config.downsampleRate))];
            val_57 = val_57;
        }
        
        val_73 = (double)val_78;
        mem2[0] = val_73;
        if(val_57 == 1)
        {
            goto label_90;
        }
        
        if(val_57 != 0)
        {
            goto label_104;
        }
        
        if(this.config.filterNearFP != false)
        {
                bool val_61 = this.isClose[(this.config.filterNearFP + 16 * (long)(int)(((Klass->__il2cppRuntimeField_interfaceOffsets[].offset - (long)(int)((this.config + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset * w)))) / this.config.downsampleRate))) + (long)(int)(((this.config - this.config) / this.config.downsampleRate))];
        }
        
        UnityEngine.Vector3 val_34 = UnityEngine.Camera.main.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = val_78, y = V11.16B, z = V12.16B});
        val_78 = val_34.x;
        val_86 = val_34.z;
        UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  this.config.spherePrefab, parent:  this.sphereParent.transform).position = new UnityEngine.Vector3() {x = val_78, y = val_34.y, z = val_86};
        goto label_104;
        label_90:
        if(this.config.showSpheres != false)
        {
                if(this.config.filterNearFP != false)
        {
                bool val_62 = this.isClose[(this.config.filterNearFP + 16 * (long)(int)(((Klass->__il2cppRuntimeField_interfaceOffsets[].offset - (long)(int)((this.config + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset * w)))) / this.config.downsampleRate))) + (long)(int)(((this.config - this.config) / this.config.downsampleRate))];
            val_57 = val_57;
        }
        
            val_74 = this.sphereParent;
            val_75 = this.config.spherePrefab;
            UnityEngine.Vector3 val_39 = UnityEngine.Camera.main.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = val_78, y = V11.16B, z = V12.16B});
            UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  val_75, parent:  val_74.transform).position = new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z};
        }
        
        UnityEngine.Vector3 val_41 = UnityEngine.Camera.main.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z});
        val_78 = val_41.x;
        val_86 = val_41.z;
        mem2[0] = val_78;
        mem2[0] = val_41.y;
        mem2[0] = val_86;
        label_104:
        UnityEngine.Camera.main.ResetWorldToCameraMatrix();
        UnityEngine.Camera.main.ResetProjectionMatrix();
        val_63 = this.config.downsampleRate + val_63;
        if(val_63 < 12)
        {
            goto label_126;
        }
        
        label_61:
        val_69 = this.lastImageType;
        val_89 = this.filteredMap;
        val_54 = this.lastOrientationIsLandscape;
        this._rawDepthMapDispenser.SendUpdateEvent(depth:  val_89, isLandscape:  (val_54 == true) ? 1 : 0, cameraTransform:  new UnityEngine.Matrix4x4() {m00 = this.lastCameraWorldTransform.m00, m01 = this.lastCameraWorldTransform.m01, m02 = this.lastCameraWorldTransform.m02, m03 = this.lastCameraWorldTransform.m03}, projectionMatrix:  new UnityEngine.Matrix4x4() {m00 = this.lastCameraProjectionMatrix.m00, m01 = this.lastCameraProjectionMatrix.m01, m02 = this.lastCameraProjectionMatrix.m02, m03 = this.lastCameraProjectionMatrix.m03}, position:  val_69);
        if(val_57 != 1)
        {
                return;
        }
        
        val_89 = this.vertices;
        val_71 = this.lastCameraPosition;
        this.dispenser.SendDepthMapEvent(depthMap:  val_89, mask:  this.isClose, cameraPos:  new UnityEngine.Vector3() {x = val_71, y = V9.16B, z = V10.16B});
        if(this.config.computeFPDirection == false)
        {
                return;
        }
        
        val_54 = 1152921518929705776;
        val_89 = val_89.ToArray();
        val_71 = this.lastCameraPosition;
        val_55 = this.isClose.ToArray();
        this.dirPtsDispenser.SendDirectedPointsEvent(positions:  val_89, directions:  val_55, cameraPos:  new UnityEngine.Vector3() {x = val_71, y = V9.16B, z = V10.16B});
        return;
        label_77:
        val_65 = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void CoreMLFrameUpdated(int index, string[] strings, float[] floats, int floatsW, int floatsH, double[] depth, int w, int h)
    {
        this.ProcessDepthMap(depth:  depth, w:  w, h:  h);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void LogDebug(string functionName, string logString)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void LogError(string functionName, string logString)
    {
        ConsoleLogger.LogError(className:  logString.GetType(), functionName:  functionName, logString:  logString);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void TimeUpdateEvent()
    {
        if(this.isModelDownloaded != true)
        {
                var val_8 = 0;
            val_8 = val_8 + 1;
            bool val_2 = this._modelDownloadStatus.HasBeenDownloaded();
            this.isModelDownloaded = val_2;
            if(val_2 == false)
        {
                return;
        }
        
        }
        
        bool val_9 = this.pendingResponse;
        val_9 = val_9 + 3;
        var val_10 = ~val_9;
        val_10 = val_10 & 3;
        if(val_10 != 0)
        {
                return;
        }
        
        System.DateTime val_4 = System.DateTime.UtcNow;
        long val_5 = val_4.dateData.Ticks;
        if(this.config.enableDepthMap == false)
        {
                return;
        }
        
        if((1844674407370955 - this.lastDepthFire) <= this.config.updateFrequency)
        {
                return;
        }
        
        this.lastDepthFire = 1844674407370955;
        this.pendingResponse = true;
        UnityCVManager.Instance.ActivateDepthSession();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DepthObjectManager()
    {
        this.firstTime = true;
        this.initModel = true;
    }

}
