using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class TechBootstrap : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TSDF_Config _tsdfConfig;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DepthObjectManager_Config _depthConfig;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private FeaturePointModifier_Config _featurePointModifierConfig;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IllumixEngineConfig _engineConfig;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private CoarseMesh_Config _coarseMeshConfig;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedPlaneConfig _supportedPlaneConfig;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DefaultNamespace.ObjectDetectionManager_Config _objDetectConfig;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer _objDetectDeliverer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.Adapters.IxObjDetectAdapter _ixObjDetectAdapter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private NativeARAdapter _nativeARAdapter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private FeaturePointModifier _featurePointModifier;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DepthObjectManager _depthObjectManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private com.illumix.TSDF.TSDF_Manager _tSDFManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DirectedPointsManager _directedPointsManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private BoundedPlaneManager _boundedPlaneManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.DiscreteSupportedPlaneManager _discreteSupportedPlaneManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DefaultNamespace.ObjectDetectionManager _objectDetectionManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IllumixAdapter _illumixAdapter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IllumixSurfaceManager _illumixSurfaceManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.Adapters.IllumixDepthMapAdapter _illumixDepthMapAdapter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private com.illumix.IntVector3.IntVector3Cache _coordCache;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.XR.ARFoundation.ARPointCloudManager m_ARPointCloudManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.XR.ARFoundation.ARPlaneManager m_ARPlaneManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Camera arCamera;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.TimeEngine.TimeEngine _timeEngine;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this.GetConfigs();
        this.BuildConnections();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnApplicationQuit()
    {
        this._nativeARAdapter.Teardown();
        this._featurePointModifier.Teardown();
        this._depthObjectManager.Teardown();
        this._tSDFManager.Teardown();
        this._illumixAdapter.Teardown();
        this._illumixSurfaceManager.Teardown();
        this._featurePointModifierConfig = 0;
        this._tsdfConfig = 0;
        this._nativeARAdapter = 0;
        this._depthObjectManager = 0;
        this._illumixAdapter = 0;
        this._illumixSurfaceManager = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void GetConfigs()
    {
        this._tsdfConfig = this.GetComponent<TSDF_Config>();
        this._depthConfig = this.GetComponent<DepthObjectManager_Config>();
        this._featurePointModifierConfig = this.GetComponent<FeaturePointModifier_Config>();
        this._engineConfig = this.GetComponent<IllumixEngineConfig>();
        this._coarseMeshConfig = this.GetComponent<CoarseMesh_Config>();
        this._supportedPlaneConfig = this.GetComponent<SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedPlaneConfig>();
        this._objDetectConfig = this.GetComponent<DefaultNamespace.ObjectDetectionManager_Config>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void BuildConnections()
    {
        this._nativeARAdapter = new NativeARAdapter();
        this._featurePointModifier = new FeaturePointModifier();
        this._depthObjectManager = new DepthObjectManager();
        this._tSDFManager = new com.illumix.TSDF.TSDF_Manager();
        this._directedPointsManager = new DirectedPointsManager();
        this._boundedPlaneManager = new BoundedPlaneManager();
        this._discreteSupportedPlaneManager = new SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.DiscreteSupportedPlaneManager();
        this._objectDetectionManager = new DefaultNamespace.ObjectDetectionManager();
        this._objDetectDeliverer = new SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer();
        this._ixObjDetectAdapter = new SharedTechAssets.Scripts.Adapters.IxObjDetectAdapter();
        this._illumixAdapter = new IllumixAdapter();
        this._illumixDepthMapAdapter = new SharedTechAssets.Scripts.Adapters.IllumixDepthMapAdapter();
        this._illumixSurfaceManager = new IllumixSurfaceManager();
        this._coordCache = new com.illumix.IntVector3.IntVector3Cache();
        this.m_ARPointCloudManager = this.GetComponentInParent<UnityEngine.XR.ARFoundation.ARPointCloudManager>();
        this.m_ARPlaneManager = this.GetComponentInParent<UnityEngine.XR.ARFoundation.ARPlaneManager>();
        this.arCamera = this.GetComponentInParent<UnityEngine.XR.ARFoundation.ARSessionOrigin>().camera;
        this._timeEngine = this.gameObject.AddComponent<SharedTechAssets.Scripts.TimeEngine.TimeEngine>();
        TimeUpdateDispenser val_21 = new TimeUpdateDispenser();
        System.Collections.Generic.List<ITimeUpdateAccepter> val_22 = new System.Collections.Generic.List<ITimeUpdateAccepter>();
        val_22.Add(item:  this._objectDetectionManager);
        val_21.SetAccepters(accepters:  val_22);
        this._timeEngine.Setup(dispenser:  val_21);
        TimeUpdateDispenser val_23 = new TimeUpdateDispenser();
        System.Collections.Generic.List<ITimeUpdateAccepter> val_24 = new System.Collections.Generic.List<ITimeUpdateAccepter>();
        val_24.Add(item:  this._depthObjectManager);
        val_23.SetAccepters(accepters:  val_24);
        TimeUpdateDispenser val_25 = new TimeUpdateDispenser();
        System.Collections.Generic.List<ITimeUpdateAccepter> val_26 = new System.Collections.Generic.List<ITimeUpdateAccepter>();
        val_26.Add(item:  this._illumixSurfaceManager);
        val_25.SetAccepters(accepters:  val_26);
        PointDispenser val_27 = new PointDispenser();
        System.Collections.Generic.List<IPointAccepter> val_28 = new System.Collections.Generic.List<IPointAccepter>();
        val_28.Add(item:  this._featurePointModifier);
        val_27.SetAccepters(accepters:  val_28);
        ARPlaneDispenser val_29 = new ARPlaneDispenser();
        System.Collections.Generic.List<IARPlaneAccepter> val_30 = new System.Collections.Generic.List<IARPlaneAccepter>();
        val_30.Add(item:  this._boundedPlaneManager);
        val_29.SetAccepters(accepters:  val_30);
        this._nativeARAdapter.Setup(earlyTimeDispenser:  val_23, lateTimeDispenser:  val_25, pointDispenser:  val_27, planeDispenser:  val_29, pointCloudManager:  this.m_ARPointCloudManager, planeManager:  this.m_ARPlaneManager);
        BoundedPlaneDispenser val_31 = new BoundedPlaneDispenser();
        System.Collections.Generic.List<IBoundedPlaneAccepter> val_32 = new System.Collections.Generic.List<IBoundedPlaneAccepter>();
        val_32.Add(item:  this._discreteSupportedPlaneManager);
        val_31.SetAccepters(accepters:  val_32);
        this._boundedPlaneManager.Setup(planeDispenser:  val_31);
        PointDispenser val_33 = new PointDispenser();
        System.Collections.Generic.List<IPointAccepter> val_34 = new System.Collections.Generic.List<IPointAccepter>();
        val_34.Add(item:  this._tSDFManager);
        val_34.Add(item:  this._discreteSupportedPlaneManager);
        val_33.SetAccepters(accepters:  val_34);
        this._featurePointModifier.Setup(dispenser:  val_33, config:  this._featurePointModifierConfig, m_Camera:  this.arCamera);
        DepthMapDispenser val_35 = new DepthMapDispenser();
        System.Collections.Generic.List<IDepthMapAccepter> val_36 = new System.Collections.Generic.List<IDepthMapAccepter>();
        val_36.Add(item:  this._tSDFManager);
        val_36.Add(item:  this._discreteSupportedPlaneManager);
        val_35.SetAccepters(accepters:  val_36);
        RawDirectedPointsDispenser val_37 = new RawDirectedPointsDispenser();
        System.Collections.Generic.List<IRawDirectedPointsAccepter> val_38 = new System.Collections.Generic.List<IRawDirectedPointsAccepter>();
        val_38.Add(item:  this._directedPointsManager);
        val_37.SetAccepters(accepters:  val_38);
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.RawDepthMapDispenser val_39 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.RawDepthMapDispenser();
        System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IRawDepthMapAccepter> val_40 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IRawDepthMapAccepter>();
        val_40.Add(item:  this._illumixDepthMapAdapter);
        val_39.SetAccepters(accepters:  val_40);
        this._depthObjectManager.Setup(dispenser:  val_35, dirPtsDispenser:  val_37, rawDepthMapDispenser:  val_39, config:  this._depthConfig, m_Camera:  this.arCamera, modelDownloadStatus:  0);
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.SupportedHorizontalPlaneDispenser val_41 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.SupportedHorizontalPlaneDispenser();
        System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedHorizontalPlaneAccepter> val_42 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedHorizontalPlaneAccepter>();
        val_42.Add(item:  this._illumixAdapter);
        val_41.SetAccepters(accepters:  val_42);
        System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedHorizontalPlaneAccepter> val_44 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedHorizontalPlaneAccepter>();
        val_44.Add(item:  this._illumixAdapter);
        val_41.SetAccepters(accepters:  val_44);
        PointDispenser val_45 = new PointDispenser();
        System.Collections.Generic.List<IPointAccepter> val_46 = new System.Collections.Generic.List<IPointAccepter>();
        val_46.Add(item:  this._tSDFManager);
        val_45.SetAccepters(accepters:  val_46);
        this._discreteSupportedPlaneManager.Setup(dispenser:  val_41, vDispenser:  new SharedTechAssets.Scripts.TechInterfaces.Dispensers.SupportedVerticalPlaneDispenser(), config:  this._supportedPlaneConfig, pointDispenser:  val_45, camera:  this.arCamera);
        ProcessedDirectedPointsDispenser val_47 = new ProcessedDirectedPointsDispenser();
        System.Collections.Generic.List<IProcessedDirectedPointsAccepter> val_48 = new System.Collections.Generic.List<IProcessedDirectedPointsAccepter>();
        val_48.Add(item:  this._illumixAdapter);
        val_47.SetAccepters(accepters:  val_48);
        this._directedPointsManager.Setup(config:  this._coarseMeshConfig, dispenser:  val_47, coordCache:  this._coordCache);
        TileDispenser val_49 = new TileDispenser();
        System.Collections.Generic.List<ITileAccepter> val_50 = new System.Collections.Generic.List<ITileAccepter>();
        val_50.Add(item:  this._illumixAdapter);
        val_49.SetAccepters(accepters:  val_50);
        MeshBlockDispenser val_51 = new MeshBlockDispenser();
        System.Collections.Generic.List<IMeshBlockAccepter> val_52 = new System.Collections.Generic.List<IMeshBlockAccepter>();
        val_52.Add(item:  this._illumixAdapter);
        val_51.SetAccepters(accepters:  val_52);
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.BlockCoordDispenser val_53 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.BlockCoordDispenser();
        val_53.SetAccepters(accepters:  new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IBlockCoordAccepter>());
        this._tSDFManager.Setup(tileDispenser:  val_49, meshBlockDispenser:  val_51, blockCoordDispenser:  val_53, config:  this._tsdfConfig, coordCache:  this._coordCache, m_Camera:  this.arCamera);
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.ObjDetectDispenser val_55 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.ObjDetectDispenser();
        System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IObjDetectAccepter> val_56 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IObjDetectAccepter>();
        val_56.Add(item:  this._ixObjDetectAdapter);
        val_55.SetAccepters(accepters:  val_56);
        this._objectDetectionManager.Setup(config:  this._objDetectConfig, dispenser:  val_55, modelDownloadStatus:  0);
        this._illumixSurfaceManager.Setup(config:  this._engineConfig, m_Camera:  this.arCamera);
        this._illumixAdapter.Setup(surfaceManager:  this._illumixSurfaceManager);
        this._ixObjDetectAdapter.Setup(accepter:  this._objDetectDeliverer);
        this._illumixDepthMapAdapter.Setup(accepter:  this._illumixSurfaceManager.DepthMapDeliverer);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TechBootstrap()
    {
    
    }

}
