using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class TechBootstrap_PlaneAware : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.TSDF2.TSDF_Config2 _tsdfConfig;
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
    private SharedTechAssets.Scripts.TSDF2.TSDF_Manager _tSDFManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DirectedPointsManager _directedPointsManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private BoundedPlaneManager _boundedPlaneManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.DiscreteSupportedPlaneManager _discreteSupportedPlaneManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.TSDFMinusPlanes.TSDFMinusPlanesManager _tsdfMinusPlanesManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DefaultNamespace.ObjectDetectionManager _objectDetectionManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DefaultNamespace.ObjectPinner _objectPinner;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IllumixAdapter _illumixAdapter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IllumixSurfaceManager _illumixSurfaceManager;
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
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DefaultNamespace.ObjectDetectionDebugVisualizer _debugVisualizer;
    
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
        this._tsdfConfig = this.GetComponent<SharedTechAssets.Scripts.TSDF2.TSDF_Config2>();
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
        this._tSDFManager = new SharedTechAssets.Scripts.TSDF2.TSDF_Manager();
        this._directedPointsManager = new DirectedPointsManager();
        this._boundedPlaneManager = new BoundedPlaneManager();
        this._discreteSupportedPlaneManager = new SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.DiscreteSupportedPlaneManager();
        this._tsdfMinusPlanesManager = new SharedTechAssets.Scripts.TSDFMinusPlanes.TSDFMinusPlanesManager();
        this._objectDetectionManager = new DefaultNamespace.ObjectDetectionManager();
        this._objDetectDeliverer = new SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer();
        this._objectPinner = new DefaultNamespace.ObjectPinner();
        this._ixObjDetectAdapter = new SharedTechAssets.Scripts.Adapters.IxObjDetectAdapter();
        this._illumixAdapter = new IllumixAdapter();
        this._illumixSurfaceManager = new IllumixSurfaceManager();
        this._coordCache = new com.illumix.IntVector3.IntVector3Cache();
        this.m_ARPointCloudManager = this.GetComponentInParent<UnityEngine.XR.ARFoundation.ARPointCloudManager>();
        this.m_ARPlaneManager = this.GetComponentInParent<UnityEngine.XR.ARFoundation.ARPlaneManager>();
        this.arCamera = this.GetComponentInParent<UnityEngine.XR.ARFoundation.ARSessionOrigin>().gameObject.GetComponentInChildren<UnityEngine.Camera>();
        this._timeEngine = this.gameObject.AddComponent<SharedTechAssets.Scripts.TimeEngine.TimeEngine>();
        TimeUpdateDispenser val_23 = new TimeUpdateDispenser();
        System.Collections.Generic.List<ITimeUpdateAccepter> val_24 = new System.Collections.Generic.List<ITimeUpdateAccepter>();
        val_24.Add(item:  this._objectDetectionManager);
        val_23.SetAccepters(accepters:  val_24);
        this._timeEngine.Setup(dispenser:  val_23);
        TimeUpdateDispenser val_25 = new TimeUpdateDispenser();
        System.Collections.Generic.List<ITimeUpdateAccepter> val_26 = new System.Collections.Generic.List<ITimeUpdateAccepter>();
        val_26.Add(item:  this._depthObjectManager);
        val_25.SetAccepters(accepters:  val_26);
        TimeUpdateDispenser val_27 = new TimeUpdateDispenser();
        System.Collections.Generic.List<ITimeUpdateAccepter> val_28 = new System.Collections.Generic.List<ITimeUpdateAccepter>();
        val_28.Add(item:  this._illumixSurfaceManager);
        val_27.SetAccepters(accepters:  val_28);
        PointDispenser val_29 = new PointDispenser();
        System.Collections.Generic.List<IPointAccepter> val_30 = new System.Collections.Generic.List<IPointAccepter>();
        val_30.Add(item:  this._featurePointModifier);
        val_29.SetAccepters(accepters:  val_30);
        ARPlaneDispenser val_31 = new ARPlaneDispenser();
        System.Collections.Generic.List<IARPlaneAccepter> val_32 = new System.Collections.Generic.List<IARPlaneAccepter>();
        val_32.Add(item:  this._boundedPlaneManager);
        val_31.SetAccepters(accepters:  val_32);
        this._nativeARAdapter.Setup(earlyTimeDispenser:  val_25, lateTimeDispenser:  val_27, pointDispenser:  val_29, planeDispenser:  val_31, pointCloudManager:  this.m_ARPointCloudManager, planeManager:  this.m_ARPlaneManager);
        BoundedPlaneDispenser val_33 = new BoundedPlaneDispenser();
        System.Collections.Generic.List<IBoundedPlaneAccepter> val_34 = new System.Collections.Generic.List<IBoundedPlaneAccepter>();
        val_34.Add(item:  this._discreteSupportedPlaneManager);
        val_34.Add(item:  this._tsdfMinusPlanesManager);
        val_33.SetAccepters(accepters:  val_34);
        this._boundedPlaneManager.Setup(planeDispenser:  val_33);
        PointDispenser val_35 = new PointDispenser();
        System.Collections.Generic.List<IPointAccepter> val_36 = new System.Collections.Generic.List<IPointAccepter>();
        val_36.Add(item:  this._discreteSupportedPlaneManager);
        val_35.SetAccepters(accepters:  val_36);
        this._featurePointModifier.Setup(dispenser:  val_35, config:  this._featurePointModifierConfig, m_Camera:  this.arCamera);
        DepthMapDispenser val_37 = new DepthMapDispenser();
        System.Collections.Generic.List<IDepthMapAccepter> val_38 = new System.Collections.Generic.List<IDepthMapAccepter>();
        val_38.Add(item:  this._discreteSupportedPlaneManager);
        val_37.SetAccepters(accepters:  val_38);
        RawDirectedPointsDispenser val_39 = new RawDirectedPointsDispenser();
        System.Collections.Generic.List<IRawDirectedPointsAccepter> val_40 = new System.Collections.Generic.List<IRawDirectedPointsAccepter>();
        val_40.Add(item:  this._directedPointsManager);
        val_39.SetAccepters(accepters:  val_40);
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.RawDepthMapDispenser val_41 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.RawDepthMapDispenser();
        val_41.SetAccepters(accepters:  new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IRawDepthMapAccepter>());
        this._depthObjectManager.Setup(dispenser:  val_37, dirPtsDispenser:  val_39, rawDepthMapDispenser:  val_41, config:  this._depthConfig, m_Camera:  this.arCamera, modelDownloadStatus:  0);
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.SupportedHorizontalPlaneDispenser val_43 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.SupportedHorizontalPlaneDispenser();
        System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedHorizontalPlaneAccepter> val_44 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedHorizontalPlaneAccepter>();
        val_44.Add(item:  this._illumixAdapter);
        val_43.SetAccepters(accepters:  val_44);
        System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedHorizontalPlaneAccepter> val_46 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedHorizontalPlaneAccepter>();
        val_46.Add(item:  this._illumixAdapter);
        val_43.SetAccepters(accepters:  val_46);
        PointDispenser val_47 = new PointDispenser();
        System.Collections.Generic.List<IPointAccepter> val_48 = new System.Collections.Generic.List<IPointAccepter>();
        val_48.Add(item:  this._tSDFManager);
        val_47.SetAccepters(accepters:  val_48);
        this._discreteSupportedPlaneManager.Setup(dispenser:  val_43, vDispenser:  new SharedTechAssets.Scripts.TechInterfaces.Dispensers.SupportedVerticalPlaneDispenser(), config:  this._supportedPlaneConfig, pointDispenser:  val_47, camera:  this.arCamera);
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.BlockCoordDispenser val_49 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.BlockCoordDispenser();
        val_49.SetAccepters(accepters:  new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IBlockCoordAccepter>());
        MeshBlockDispenser val_51 = new MeshBlockDispenser();
        System.Collections.Generic.List<IMeshBlockAccepter> val_52 = new System.Collections.Generic.List<IMeshBlockAccepter>();
        val_52.Add(item:  this._illumixAdapter);
        val_51.SetAccepters(accepters:  val_52);
        this._tsdfMinusPlanesManager.Setup(dispenser:  val_51, blockCoordDispenser:  val_49, coordCache:  this._coordCache);
        ProcessedDirectedPointsDispenser val_53 = new ProcessedDirectedPointsDispenser();
        System.Collections.Generic.List<IProcessedDirectedPointsAccepter> val_54 = new System.Collections.Generic.List<IProcessedDirectedPointsAccepter>();
        val_54.Add(item:  this._illumixAdapter);
        val_53.SetAccepters(accepters:  val_54);
        this._directedPointsManager.Setup(config:  this._coarseMeshConfig, dispenser:  val_53, coordCache:  this._coordCache);
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.BlockCoordDispenser val_55 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.BlockCoordDispenser();
        System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IBlockCoordAccepter> val_56 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IBlockCoordAccepter>();
        val_56.Add(item:  this._tsdfMinusPlanesManager);
        val_55.SetAccepters(accepters:  val_56);
        this._tSDFManager.Setup(blockCoordDispenser:  val_55, config:  this._tsdfConfig, coordCache:  this._coordCache, m_Camera:  this.arCamera);
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.ObjDetectDispenser val_57 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.ObjDetectDispenser();
        System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IObjDetectAccepter> val_58 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IObjDetectAccepter>();
        val_58.Add(item:  this._ixObjDetectAdapter);
        val_58.Add(item:  this._objectPinner);
        val_57.SetAccepters(accepters:  val_58);
        this._objectDetectionManager.Setup(config:  this._objDetectConfig, dispenser:  val_57, modelDownloadStatus:  0);
        this._debugVisualizer = this.gameObject.GetComponent<DefaultNamespace.ObjectDetectionDebugVisualizer>();
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.ObjectPinEventDispenser val_61 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.ObjectPinEventDispenser();
        val_61.SetAccepters(accepters:  new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IObjectPinEventAccepter>());
        this._objectPinner.Setup(camera:  this.arCamera, cache:  this._coordCache, debugVisualizer:  this._debugVisualizer, geometryHandlers:  0, dispenser:  val_61);
        this._illumixSurfaceManager.Setup(config:  this._engineConfig, m_Camera:  this.arCamera);
        this._illumixAdapter.Setup(surfaceManager:  this._illumixSurfaceManager);
        this._ixObjDetectAdapter.Setup(accepter:  this._objDetectDeliverer);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TechBootstrap_PlaneAware()
    {
    
    }

}
