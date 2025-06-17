using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class TechBootstrap_SemanticGeo : MonoBehaviour
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
    private SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.DiscreteSupportedPlaneManager _supportedPlaneManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.TSDFMinusPlanes.TSDFMinusPlanesManager _tsdfMinusPlanesManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DefaultNamespace.ObjectDetectionManager _objectDetectionManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DefaultNamespace.ObjectPinner _objectPinner;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectTrackingManager _objectTrackingManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.Adapters.IxTrackedObjectAdapter _trackedObjectAdapter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer _trackedObjectDeliverer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.SupportedHorizontalPlaneGeometryHandler _supportedHorizontalPlaneGeometryHandler;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.SupportedHorizontalPlaneGeometry_Config _supportedHorizontalPlaneGeometryConfig;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.SupportedPlaneHandler.SupportedVerticalPlaneGeometryHandler _supportedVerticalPlaneGeometryHandler;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.SupportedVerticalPlaneGeometryHandler_Config _supportedVerticalPlaneGeometryHandlerConfig;
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
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.Adapters.IxSemanticVerticalPlaneAdapter _semanticVerticalPlaneAdapter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.Adapters.IxSemanticHorizontalPlaneAdapter _semanticHorizontalPlaneAdapter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer _verticalSemanticPlaneDeliverer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer _horizontalSemanticPlaneDeliverer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.MeshBlockGeometryHandler _meshBlockGeometryHandler;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.MeshBlockGeometry_Config _meshBlockGeometryConfig;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.Adapters.IxSemanticVoxelAdapter _semanticVoxelAdapter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer _semanticVoxelDeliverer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.Adapters.IllumixDepthMapAdapter _illumixDepthMapAdapter;
    
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
        this._supportedHorizontalPlaneGeometryConfig = this.GetComponent<SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.SupportedHorizontalPlaneGeometry_Config>();
        this._supportedVerticalPlaneGeometryHandlerConfig = this.GetComponent<SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.SupportedVerticalPlaneGeometryHandler_Config>();
        this._meshBlockGeometryConfig = this.GetComponent<SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.MeshBlockGeometry_Config>();
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
        this._supportedPlaneManager = new SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.DiscreteSupportedPlaneManager();
        this._tsdfMinusPlanesManager = new SharedTechAssets.Scripts.TSDFMinusPlanes.TSDFMinusPlanesManager();
        this._objectDetectionManager = new DefaultNamespace.ObjectDetectionManager();
        this._objDetectDeliverer = new SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer();
        this._verticalSemanticPlaneDeliverer = new SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer();
        this._horizontalSemanticPlaneDeliverer = new SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer();
        this._semanticVoxelDeliverer = new SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer();
        this._objectTrackingManager = new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectTrackingManager();
        this._trackedObjectAdapter = new SharedTechAssets.Scripts.Adapters.IxTrackedObjectAdapter();
        this._trackedObjectDeliverer = new SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer();
        DefaultNamespace.SemanticHorizontalPlaneTracker val_17 = new DefaultNamespace.SemanticHorizontalPlaneTracker();
        DefaultNamespace.SemanticVerticalPlaneTracker val_18 = new DefaultNamespace.SemanticVerticalPlaneTracker();
        SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.SemanticBlockCoordTracker val_19 = new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.SemanticBlockCoordTracker(voxelResolution:  this._tsdfConfig.props);
        this._illumixDepthMapAdapter = new SharedTechAssets.Scripts.Adapters.IllumixDepthMapAdapter();
        this._objectPinner = new DefaultNamespace.ObjectPinner();
        this._semanticHorizontalPlaneAdapter = new SharedTechAssets.Scripts.Adapters.IxSemanticHorizontalPlaneAdapter();
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.SemanticHorizontalPlaneDispenser val_23 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.SemanticHorizontalPlaneDispenser();
        System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISemanticHorizontalPlaneAccepter> val_24 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISemanticHorizontalPlaneAccepter>();
        if(val_24 != null)
        {
                val_24.Add(item:  this._semanticHorizontalPlaneAdapter);
        }
        else
        {
                val_24.Add(item:  this._semanticHorizontalPlaneAdapter);
        }
        
        val_24.Add(item:  val_17);
        val_23.SetAccepters(accepters:  val_24);
        this._supportedHorizontalPlaneGeometryHandler = new SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.SupportedHorizontalPlaneGeometryHandler(config:  this._supportedHorizontalPlaneGeometryConfig, dispenser:  val_23);
        this._semanticVerticalPlaneAdapter = new SharedTechAssets.Scripts.Adapters.IxSemanticVerticalPlaneAdapter();
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.SemanticVerticalPlaneDispenser val_27 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.SemanticVerticalPlaneDispenser();
        System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISemanticVerticalPlaneAccepter> val_28 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISemanticVerticalPlaneAccepter>();
        if(val_28 != null)
        {
                val_28.Add(item:  this._semanticVerticalPlaneAdapter);
        }
        else
        {
                val_28.Add(item:  this._semanticVerticalPlaneAdapter);
        }
        
        val_28.Add(item:  val_18);
        val_27.SetAccepters(accepters:  val_28);
        this._supportedVerticalPlaneGeometryHandler = new SharedTechAssets.Scripts.SupportedPlaneHandler.SupportedVerticalPlaneGeometryHandler(config:  this._supportedVerticalPlaneGeometryHandlerConfig, dispenser:  val_27);
        this._semanticVoxelAdapter = new SharedTechAssets.Scripts.Adapters.IxSemanticVoxelAdapter();
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.SemanticBlockCoordDispenser val_31 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.SemanticBlockCoordDispenser();
        System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISemanticBlockCoordAccepter> val_32 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISemanticBlockCoordAccepter>();
        if(val_32 != null)
        {
                val_32.Add(item:  this._semanticVoxelAdapter);
        }
        else
        {
                val_32.Add(item:  this._semanticVoxelAdapter);
        }
        
        val_32.Add(item:  val_19);
        val_31.SetAccepters(accepters:  val_32);
        this._meshBlockGeometryHandler = new SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.MeshBlockGeometryHandler(config:  this._meshBlockGeometryConfig, dispenser:  val_31);
        this._ixObjDetectAdapter = new SharedTechAssets.Scripts.Adapters.IxObjDetectAdapter();
        this._illumixAdapter = new IllumixAdapter();
        this._illumixSurfaceManager = new IllumixSurfaceManager();
        this._coordCache = new com.illumix.IntVector3.IntVector3Cache();
        this.m_ARPointCloudManager = this.GetComponentInParent<UnityEngine.XR.ARFoundation.ARPointCloudManager>();
        this.m_ARPlaneManager = this.GetComponentInParent<UnityEngine.XR.ARFoundation.ARPlaneManager>();
        this.arCamera = this.GetComponentInParent<UnityEngine.XR.ARFoundation.ARSessionOrigin>().gameObject.GetComponentInChildren<UnityEngine.Camera>();
        this._timeEngine = this.gameObject.AddComponent<SharedTechAssets.Scripts.TimeEngine.TimeEngine>();
        TimeUpdateDispenser val_45 = new TimeUpdateDispenser();
        System.Collections.Generic.List<ITimeUpdateAccepter> val_46 = new System.Collections.Generic.List<ITimeUpdateAccepter>();
        val_46.Add(item:  this._objectDetectionManager);
        val_46.Add(item:  UnityCVManager_Android.Instance);
        val_45.SetAccepters(accepters:  val_46);
        this._timeEngine.Setup(dispenser:  val_45);
        TimeUpdateDispenser val_48 = new TimeUpdateDispenser();
        System.Collections.Generic.List<ITimeUpdateAccepter> val_49 = new System.Collections.Generic.List<ITimeUpdateAccepter>();
        val_49.Add(item:  this._depthObjectManager);
        val_48.SetAccepters(accepters:  val_49);
        TimeUpdateDispenser val_50 = new TimeUpdateDispenser();
        System.Collections.Generic.List<ITimeUpdateAccepter> val_51 = new System.Collections.Generic.List<ITimeUpdateAccepter>();
        val_51.Add(item:  this._illumixSurfaceManager);
        val_50.SetAccepters(accepters:  val_51);
        PointDispenser val_52 = new PointDispenser();
        System.Collections.Generic.List<IPointAccepter> val_53 = new System.Collections.Generic.List<IPointAccepter>();
        val_53.Add(item:  this._featurePointModifier);
        val_52.SetAccepters(accepters:  val_53);
        ARPlaneDispenser val_54 = new ARPlaneDispenser();
        System.Collections.Generic.List<IARPlaneAccepter> val_55 = new System.Collections.Generic.List<IARPlaneAccepter>();
        val_55.Add(item:  this._boundedPlaneManager);
        val_54.SetAccepters(accepters:  val_55);
        this._nativeARAdapter.Setup(earlyTimeDispenser:  val_48, lateTimeDispenser:  val_50, pointDispenser:  val_52, planeDispenser:  val_54, pointCloudManager:  this.m_ARPointCloudManager, planeManager:  this.m_ARPlaneManager);
        BoundedPlaneDispenser val_56 = new BoundedPlaneDispenser();
        System.Collections.Generic.List<IBoundedPlaneAccepter> val_57 = new System.Collections.Generic.List<IBoundedPlaneAccepter>();
        val_57.Add(item:  this._supportedPlaneManager);
        val_57.Add(item:  this._tsdfMinusPlanesManager);
        val_56.SetAccepters(accepters:  val_57);
        this._boundedPlaneManager.Setup(planeDispenser:  val_56);
        PointDispenser val_58 = new PointDispenser();
        System.Collections.Generic.List<IPointAccepter> val_59 = new System.Collections.Generic.List<IPointAccepter>();
        val_59.Add(item:  this._supportedPlaneManager);
        val_58.SetAccepters(accepters:  val_59);
        this._featurePointModifier.Setup(dispenser:  val_58, config:  this._featurePointModifierConfig, m_Camera:  this.arCamera);
        DepthMapDispenser val_60 = new DepthMapDispenser();
        System.Collections.Generic.List<IDepthMapAccepter> val_61 = new System.Collections.Generic.List<IDepthMapAccepter>();
        val_61.Add(item:  this._supportedPlaneManager);
        val_60.SetAccepters(accepters:  val_61);
        RawDirectedPointsDispenser val_62 = new RawDirectedPointsDispenser();
        System.Collections.Generic.List<IRawDirectedPointsAccepter> val_63 = new System.Collections.Generic.List<IRawDirectedPointsAccepter>();
        val_63.Add(item:  this._directedPointsManager);
        val_62.SetAccepters(accepters:  val_63);
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.RawDepthMapDispenser val_64 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.RawDepthMapDispenser();
        System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IRawDepthMapAccepter> val_65 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IRawDepthMapAccepter>();
        val_65.Add(item:  this._illumixDepthMapAdapter);
        val_64.SetAccepters(accepters:  val_65);
        this._depthObjectManager.Setup(dispenser:  val_60, dirPtsDispenser:  val_62, rawDepthMapDispenser:  val_64, config:  this._depthConfig, m_Camera:  this.arCamera, modelDownloadStatus:  0);
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.SupportedHorizontalPlaneDispenser val_66 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.SupportedHorizontalPlaneDispenser();
        System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedHorizontalPlaneAccepter> val_67 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedHorizontalPlaneAccepter>();
        val_67.Add(item:  this._illumixAdapter);
        val_67.Add(item:  this._semanticHorizontalPlaneAdapter);
        val_67.Add(item:  this._supportedHorizontalPlaneGeometryHandler);
        val_67.Add(item:  this._objectTrackingManager);
        val_66.SetAccepters(accepters:  val_67);
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.SupportedVerticalPlaneDispenser val_68 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.SupportedVerticalPlaneDispenser();
        System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedVerticalPlaneAccepter> val_69 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedVerticalPlaneAccepter>();
        val_69.Add(item:  this._illumixAdapter);
        val_69.Add(item:  this._semanticVerticalPlaneAdapter);
        val_69.Add(item:  this._supportedVerticalPlaneGeometryHandler);
        val_69.Add(item:  this._objectTrackingManager);
        val_68.SetAccepters(accepters:  val_69);
        PointDispenser val_70 = new PointDispenser();
        System.Collections.Generic.List<IPointAccepter> val_71 = new System.Collections.Generic.List<IPointAccepter>();
        val_71.Add(item:  this._tSDFManager);
        val_70.SetAccepters(accepters:  val_71);
        this._supportedPlaneManager.Setup(dispenser:  val_66, vDispenser:  val_68, config:  this._supportedPlaneConfig, pointDispenser:  val_70, camera:  this.arCamera);
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.BlockCoordDispenser val_72 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.BlockCoordDispenser();
        System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IBlockCoordAccepter> val_73 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IBlockCoordAccepter>();
        val_73.Add(item:  this._meshBlockGeometryHandler);
        val_73.Add(item:  this._supportedPlaneManager);
        val_72.SetAccepters(accepters:  val_73);
        MeshBlockDispenser val_74 = new MeshBlockDispenser();
        System.Collections.Generic.List<IMeshBlockAccepter> val_75 = new System.Collections.Generic.List<IMeshBlockAccepter>();
        val_75.Add(item:  this._illumixAdapter);
        val_75.Add(item:  this._meshBlockGeometryHandler);
        val_74.SetAccepters(accepters:  val_75);
        this._tsdfMinusPlanesManager.Setup(dispenser:  val_74, blockCoordDispenser:  val_72, coordCache:  this._coordCache);
        ProcessedDirectedPointsDispenser val_76 = new ProcessedDirectedPointsDispenser();
        System.Collections.Generic.List<IProcessedDirectedPointsAccepter> val_77 = new System.Collections.Generic.List<IProcessedDirectedPointsAccepter>();
        val_77.Add(item:  this._illumixAdapter);
        val_76.SetAccepters(accepters:  val_77);
        this._directedPointsManager.Setup(config:  this._coarseMeshConfig, dispenser:  val_76, coordCache:  this._coordCache);
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.BlockCoordDispenser val_78 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.BlockCoordDispenser();
        System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IBlockCoordAccepter> val_79 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IBlockCoordAccepter>();
        val_79.Add(item:  this._tsdfMinusPlanesManager);
        val_78.SetAccepters(accepters:  val_79);
        this._tSDFManager.Setup(blockCoordDispenser:  val_78, config:  this._tsdfConfig, coordCache:  this._coordCache, m_Camera:  this.arCamera);
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.ObjDetectDispenser val_80 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.ObjDetectDispenser();
        System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IObjDetectAccepter> val_81 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IObjDetectAccepter>();
        val_81.Add(item:  this._ixObjDetectAdapter);
        val_81.Add(item:  this._objectPinner);
        val_80.SetAccepters(accepters:  val_81);
        this._objectDetectionManager.Setup(config:  this._objDetectConfig, dispenser:  val_80, modelDownloadStatus:  0);
        System.Collections.Generic.List<SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.ISemanticGeometryHandler> val_82 = new System.Collections.Generic.List<SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.ISemanticGeometryHandler>();
        val_82.Add(item:  this._supportedVerticalPlaneGeometryHandler);
        val_82.Add(item:  this._supportedHorizontalPlaneGeometryHandler);
        val_82.Add(item:  this._meshBlockGeometryHandler);
        this._debugVisualizer = this.gameObject.GetComponent<DefaultNamespace.ObjectDetectionDebugVisualizer>();
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.ObjectPinEventDispenser val_85 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.ObjectPinEventDispenser();
        System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IObjectPinEventAccepter> val_86 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IObjectPinEventAccepter>();
        val_86.Add(item:  this._objectTrackingManager);
        val_85.SetAccepters(accepters:  val_86);
        this._objectPinner.Setup(camera:  this.arCamera, cache:  this._coordCache, debugVisualizer:  this._debugVisualizer, geometryHandlers:  val_82, dispenser:  val_85);
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.TrackedObjectDispenser val_87 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.TrackedObjectDispenser();
        System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ITrackedObjectAccepter> val_88 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ITrackedObjectAccepter>();
        val_88.Add(item:  this._trackedObjectAdapter);
        val_87.SetAccepters(accepters:  val_88);
        this._objectTrackingManager.Setup(horizontalPlaneTracker:  val_17, verticalPlaneTracker:  val_18, semanticVoxelTracker:  val_19, dispenser:  val_87);
        this._illumixSurfaceManager.Setup(config:  this._engineConfig, m_Camera:  this.arCamera);
        this._illumixAdapter.Setup(surfaceManager:  this._illumixSurfaceManager);
        this._ixObjDetectAdapter.Setup(accepter:  this._objDetectDeliverer);
        this._illumixDepthMapAdapter.Setup(accepter:  this._illumixSurfaceManager.DepthMapDeliverer);
        this._semanticVerticalPlaneAdapter.Setup(accepter:  this._verticalSemanticPlaneDeliverer);
        this._semanticHorizontalPlaneAdapter.Setup(accepter:  this._horizontalSemanticPlaneDeliverer);
        this._semanticVoxelAdapter.Setup(accepter:  this._semanticVoxelDeliverer, resolution:  this._tsdfConfig.props);
        this._trackedObjectAdapter.Setup(accepter:  this._trackedObjectDeliverer);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TechBootstrap_SemanticGeo()
    {
    
    }

}
