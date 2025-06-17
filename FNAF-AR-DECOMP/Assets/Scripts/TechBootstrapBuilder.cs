using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class TechBootstrapBuilder : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Notes;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SharedTechAssets.Scripts.TechBootstrap_Config BootstrapConfig;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SharedTechAssets.Scripts.Utilities.ModelLoadingHandler ModelLoadingHandler;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject ComponentConfigs;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.TSDF2.TSDF_Config2 _tsdfConfig;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DepthObjectManager_Config _depthConfig;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private FeaturePointModifier_Config _featurePointModifierConfig;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private CoarseMesh_Config _directedPointsConfig;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedPlaneConfig _supportedPlaneConfig;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DefaultNamespace.ObjectDetectionManager_Config _objDetectConfig;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.SupportedHorizontalPlaneGeometry_Config _supportedHorizontalPlaneGeometryConfig;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.SupportedVerticalPlaneGeometryHandler_Config _supportedVerticalPlaneGeometryHandlerConfig;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.MeshBlockGeometry_Config _meshBlockGeometryConfig;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.SceneRecognition.SceneRecognition_Config _sceneRecognitionConfig;
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
    private SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectTrackingManager _objectTrackingManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IllumixSurfaceManager _illumixSurfaceManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.SceneRecognition.SceneRecognitionManager _sceneRecognitionManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private NativeARAdapter _nativeARAdapter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.Adapters.IllumixDepthMapAdapter _illumixDepthMapAdapter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.Adapters.IxDirectedPointAdapter _ixDirectedPointAdapter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.Adapters.IxBoundedPlaneAdapter _ixBoundedPlaneAdapter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.Adapters.IxSupportedPlaneAdapter _ixSupportedPlaneAdapter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.Adapters.IxMeshBlockAdapter _meshBlockAdapter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.Adapters.IxObjDetectAdapter _objDetectAdapter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.Adapters.IxSceneRecognitionAdapter _sceneRecognitionAdapter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.Adapters.IxModelDownloadProgressAdapter _modelDownloadProgressAdapter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.Adapters.IxSemanticVerticalPlaneAdapter _semanticVerticalPlaneAdapter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.Adapters.IxSemanticHorizontalPlaneAdapter _semanticHorizontalPlaneAdapter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.Adapters.IxSemanticVoxelAdapter _semanticVoxelAdapter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.Adapters.IxTrackedObjectAdapter _trackedObjectAdapter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.MeshBlockGeometryHandler _meshBlockGeometryHandler;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.SupportedHorizontalPlaneGeometryHandler _supportedHorizontalPlaneGeometryHandler;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.SupportedPlaneHandler.SupportedVerticalPlaneGeometryHandler _supportedVerticalPlaneGeometryHandler;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DefaultNamespace.ObjectPinner _objectPinner;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DefaultNamespace.SemanticHorizontalPlaneTracker semanticHorizontalPlaneTracker;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DefaultNamespace.SemanticVerticalPlaneTracker semanticVerticalPlaneTracker;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.SemanticBlockCoordTracker semanticBlockCoordTracker;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.XR.ARFoundation.ARPointCloudManager m_ARPointCloudManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.XR.ARFoundation.ARPlaneManager m_ARPlaneManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Camera arCamera;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.TimeEngine.TimeEngine _timeEngine;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private com.illumix.IntVector3.IntVector3Cache _coordCache;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxModelDownloadTriggerer _modelDownloadTriggerer;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        if(this.ModelLoadingHandler.IsSetupComplete != false)
        {
                this.GetConfigs();
            this.BuildConnections();
            return;
        }
        
        this.ModelLoadingHandler.add_OnSetupComplete(value:  new System.Action(object:  this, method:  System.Void TechBootstrapBuilder::ModelLoadingHandlerOnSetupComplete()));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ModelLoadingHandlerOnSetupComplete()
    {
        this.GetConfigs();
        this.BuildConnections();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void GetConfigs()
    {
        if(this.BootstrapConfig.DepthModelRequired != false)
        {
                this._depthConfig = this.ComponentConfigs.GetComponent<DepthObjectManager_Config>();
            val_1.shouldDownloadModel = this.BootstrapConfig.isRelease;
        }
        
        if(this.BootstrapConfig.SupportedPlanesRequired != false)
        {
                this._supportedPlaneConfig = this.ComponentConfigs.GetComponent<SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedPlaneConfig>();
        }
        
        if(this.BootstrapConfig.PlaneAwareMeshBlocksRequired != false)
        {
                this._tsdfConfig = this.ComponentConfigs.GetComponent<SharedTechAssets.Scripts.TSDF2.TSDF_Config2>();
        }
        
        if(this.BootstrapConfig.ObjDetectionRequired != false)
        {
                this._objDetectConfig = this.ComponentConfigs.GetComponent<DefaultNamespace.ObjectDetectionManager_Config>();
            val_4.shouldDownloadModel = this.BootstrapConfig.isRelease;
        }
        
        if(this.BootstrapConfig.SceneRecognitionRequired != false)
        {
                this._sceneRecognitionConfig = this.ComponentConfigs.GetComponent<SharedTechAssets.Scripts.SceneRecognition.SceneRecognition_Config>();
            val_5.shouldDownloadModel = this.BootstrapConfig.isRelease;
        }
        
        if(this.BootstrapConfig.SemanticVoxelsRequired != false)
        {
                this._meshBlockGeometryConfig = this.ComponentConfigs.GetComponent<SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.MeshBlockGeometry_Config>();
        }
        
        if(this.BootstrapConfig.IxDirectedPoints != false)
        {
                this._directedPointsConfig = this.ComponentConfigs.GetComponent<CoarseMesh_Config>();
            this._depthConfig.computeFPDirection = true;
        }
        
        if(this.BootstrapConfig.SupportedPlanesRequired != false)
        {
                this._supportedHorizontalPlaneGeometryConfig = this.ComponentConfigs.GetComponent<SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.SupportedHorizontalPlaneGeometry_Config>();
            this._supportedVerticalPlaneGeometryHandlerConfig = this.ComponentConfigs.GetComponent<SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.SupportedVerticalPlaneGeometryHandler_Config>();
        }
        
        if(this.BootstrapConfig.FeaturePointsRequired == false)
        {
                return;
        }
        
        this._featurePointModifierConfig = this.ComponentConfigs.GetComponent<FeaturePointModifier_Config>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void BuildConnections()
    {
        BoundedPlaneDispenser val_82;
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.SemanticHorizontalPlaneDispenser val_83;
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.SemanticVerticalPlaneDispenser val_84;
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.ObjectPinEventDispenser val_85;
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.TrackedObjectDispenser val_86;
        var val_87;
        MeshBlockDispenser val_88;
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.ObjDetectDispenser val_89;
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.TrackedObjectDispenser val_90;
        SharedTechAssets.Scripts.Adapters.IxSemanticVoxelAdapter val_91;
        this.m_ARPointCloudManager = this.GetComponentInParent<UnityEngine.XR.ARFoundation.ARPointCloudManager>();
        this.m_ARPlaneManager = this.GetComponentInParent<UnityEngine.XR.ARFoundation.ARPlaneManager>();
        this.arCamera = this.GetComponentInParent<UnityEngine.XR.ARFoundation.ARSessionOrigin>().gameObject.GetComponentInChildren<UnityEngine.Camera>();
        this._nativeARAdapter = new NativeARAdapter();
        TimeUpdateDispenser val_7 = new TimeUpdateDispenser();
        val_7.SetAccepters(accepters:  new System.Collections.Generic.List<ITimeUpdateAccepter>());
        TimeUpdateDispenser val_9 = new TimeUpdateDispenser();
        val_9.SetAccepters(accepters:  new System.Collections.Generic.List<ITimeUpdateAccepter>());
        PointDispenser val_11 = new PointDispenser();
        ARPlaneDispenser val_12 = new ARPlaneDispenser();
        this._nativeARAdapter.Setup(earlyTimeDispenser:  val_7, lateTimeDispenser:  val_9, pointDispenser:  val_11, planeDispenser:  val_12, pointCloudManager:  this.m_ARPointCloudManager, planeManager:  this.m_ARPlaneManager);
        this._timeEngine = this.gameObject.AddComponent<SharedTechAssets.Scripts.TimeEngine.TimeEngine>();
        TimeUpdateDispenser val_15 = new TimeUpdateDispenser();
        this._timeEngine.Setup(dispenser:  val_15);
        this._coordCache = new com.illumix.IntVector3.IntVector3Cache();
        val_15.AddAccepter(accepter:  UnityCVManager_Android.Instance);
        PointDispenser val_18 = new PointDispenser();
        if(this.BootstrapConfig.FeaturePointsRequired != false)
        {
                FeaturePointModifier val_19 = new FeaturePointModifier();
            this._featurePointModifier = val_19;
            val_11.AddAccepter(accepter:  val_19);
            this._featurePointModifier.Setup(dispenser:  val_18, config:  this._featurePointModifierConfig, m_Camera:  this.arCamera);
        }
        
        DepthMapDispenser val_20 = new DepthMapDispenser();
        RawDirectedPointsDispenser val_21 = new RawDirectedPointsDispenser();
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.RawDepthMapDispenser val_22 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.RawDepthMapDispenser();
        if(this.BootstrapConfig.DepthModelRequired != false)
        {
                DepthObjectManager val_23 = new DepthObjectManager();
            this._depthObjectManager = val_23;
            val_15.AddAccepter(accepter:  val_23);
            this._depthObjectManager.Setup(dispenser:  val_20, dirPtsDispenser:  val_21, rawDepthMapDispenser:  val_22, config:  this._depthConfig, m_Camera:  this.arCamera, modelDownloadStatus:  this.ModelLoadingHandler.ModelDownloadStatuses.Item[1]);
        }
        
        BoundedPlaneDispenser val_25 = null;
        val_82 = val_25;
        val_25 = new BoundedPlaneDispenser();
        if(this.BootstrapConfig.BoundedPlanesRequired != false)
        {
                BoundedPlaneManager val_26 = new BoundedPlaneManager();
            this._boundedPlaneManager = val_26;
            val_12.AddAccepter(accepter:  val_26);
            this._boundedPlaneManager.Setup(planeDispenser:  val_25);
        }
        
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.SupportedHorizontalPlaneDispenser val_27 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.SupportedHorizontalPlaneDispenser();
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.SupportedVerticalPlaneDispenser val_28 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.SupportedVerticalPlaneDispenser();
        PointDispenser val_29 = new PointDispenser();
        if(this.BootstrapConfig.SupportedPlanesRequired != false)
        {
                SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.DiscreteSupportedPlaneManager val_30 = new SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.DiscreteSupportedPlaneManager();
            this._supportedPlaneManager = val_30;
            val_25.AddAccepter(accepter:  val_30);
            val_18.AddAccepter(accepter:  this._supportedPlaneManager);
            this._supportedPlaneManager.Setup(dispenser:  val_27, vDispenser:  val_28, config:  this._supportedPlaneConfig, pointDispenser:  val_29, camera:  this.arCamera);
        }
        
        MeshBlockDispenser val_31 = new MeshBlockDispenser();
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.BlockCoordDispenser val_32 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.BlockCoordDispenser();
        if(this.BootstrapConfig.PlaneAwareMeshBlocksRequired != false)
        {
                SharedTechAssets.Scripts.TSDFMinusPlanes.TSDFMinusPlanesManager val_33 = new SharedTechAssets.Scripts.TSDFMinusPlanes.TSDFMinusPlanesManager();
            this._tsdfMinusPlanesManager = val_33;
            val_33.Setup(dispenser:  val_31, blockCoordDispenser:  val_32, coordCache:  this._coordCache);
            val_25.AddAccepter(accepter:  this._tsdfMinusPlanesManager);
            SharedTechAssets.Scripts.TSDF2.TSDF_Manager val_34 = new SharedTechAssets.Scripts.TSDF2.TSDF_Manager();
            this._tSDFManager = val_34;
            val_29.AddAccepter(accepter:  val_34);
            SharedTechAssets.Scripts.TechInterfaces.Dispensers.BlockCoordDispenser val_35 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.BlockCoordDispenser();
            val_35.AddAccepter(accepter:  this._tsdfMinusPlanesManager);
            this._tSDFManager.Setup(blockCoordDispenser:  val_35, config:  this._tsdfConfig, coordCache:  this._coordCache, m_Camera:  this.arCamera);
        }
        
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.ObjDetectDispenser val_36 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.ObjDetectDispenser();
        if(this.BootstrapConfig.ObjDetectionRequired != false)
        {
                DefaultNamespace.ObjectDetectionManager val_37 = new DefaultNamespace.ObjectDetectionManager();
            this._objectDetectionManager = val_37;
            val_37.Setup(config:  this._objDetectConfig, dispenser:  val_36, modelDownloadStatus:  this.ModelLoadingHandler.ModelDownloadStatuses.Item[4]);
            val_15.AddAccepter(accepter:  this._objectDetectionManager);
        }
        
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.SceneRecognitionDispenser val_39 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.SceneRecognitionDispenser();
        if(this.BootstrapConfig.SceneRecognitionRequired != false)
        {
                SharedTechAssets.Scripts.SceneRecognition.SceneRecognitionManager val_40 = new SharedTechAssets.Scripts.SceneRecognition.SceneRecognitionManager();
            this._sceneRecognitionManager = val_40;
            val_40.Setup(config:  this._sceneRecognitionConfig, dispenser:  val_39, modelDownloadStatus:  this.ModelLoadingHandler.ModelDownloadStatuses.Item[5]);
            val_15.AddAccepter(accepter:  this._sceneRecognitionManager);
        }
        
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.SemanticHorizontalPlaneDispenser val_42 = null;
        val_83 = val_42;
        val_42 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.SemanticHorizontalPlaneDispenser();
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.SemanticVerticalPlaneDispenser val_43 = null;
        val_84 = val_43;
        val_43 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.SemanticVerticalPlaneDispenser();
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.SemanticBlockCoordDispenser val_44 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.SemanticBlockCoordDispenser();
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.ObjectPinEventDispenser val_45 = null;
        val_85 = val_45;
        val_45 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.ObjectPinEventDispenser();
        SharedTechAssets.Scripts.TechInterfaces.Dispensers.TrackedObjectDispenser val_46 = null;
        val_86 = val_46;
        val_46 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.TrackedObjectDispenser();
        if((this.BootstrapConfig.SemanticPlanesRequired != true) && (this.BootstrapConfig.SemanticVoxelsRequired != true))
        {
                if(this.BootstrapConfig.TrackedObjectsRequired == false)
        {
            goto label_71;
        }
        
        }
        
        System.Collections.Generic.List<SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.ISemanticGeometryHandler> val_47 = new System.Collections.Generic.List<SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.ISemanticGeometryHandler>();
        if(this.BootstrapConfig.SemanticPlanesRequired != true)
        {
                if(this.BootstrapConfig.TrackedObjectsRequired == false)
        {
            goto label_58;
        }
        
        }
        
        SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.SupportedHorizontalPlaneGeometryHandler val_48 = new SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.SupportedHorizontalPlaneGeometryHandler(config:  this._supportedHorizontalPlaneGeometryConfig, dispenser:  val_42);
        this._supportedHorizontalPlaneGeometryHandler = val_48;
        val_27.AddAccepter(accepter:  val_48);
        val_87 = 1152921518970361072;
        val_47.Add(item:  this._supportedHorizontalPlaneGeometryHandler);
        SharedTechAssets.Scripts.SupportedPlaneHandler.SupportedVerticalPlaneGeometryHandler val_49 = new SharedTechAssets.Scripts.SupportedPlaneHandler.SupportedVerticalPlaneGeometryHandler(config:  this._supportedVerticalPlaneGeometryHandlerConfig, dispenser:  val_43);
        this._supportedVerticalPlaneGeometryHandler = val_49;
        val_28.AddAccepter(accepter:  val_49);
        val_47.Add(item:  this._supportedVerticalPlaneGeometryHandler);
        label_58:
        if(this.BootstrapConfig.SemanticVoxelsRequired != false)
        {
                SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.MeshBlockGeometryHandler val_50 = new SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.MeshBlockGeometryHandler(config:  this._meshBlockGeometryConfig, dispenser:  val_44);
            this._meshBlockGeometryHandler = val_50;
            val_32.AddAccepter(accepter:  val_50);
            val_88 = val_31;
            if(val_88 == 0)
        {
                val_88 = val_31;
        }
        
            val_31.AddAccepter(accepter:  this._meshBlockGeometryHandler);
            val_47.Add(item:  this._meshBlockGeometryHandler);
        }
        
        DefaultNamespace.ObjectPinner val_51 = new DefaultNamespace.ObjectPinner();
        this._objectPinner = val_51;
        val_89 = val_36;
        if(val_89 == 0)
        {
                val_89 = val_36;
        }
        
        val_36.AddAccepter(accepter:  val_51);
        this._objectPinner.Setup(camera:  this.arCamera, cache:  this._coordCache, debugVisualizer:  0, geometryHandlers:  val_47, dispenser:  val_45);
        val_84 = val_84;
        val_83 = val_83;
        val_82 = val_82;
        val_90 = val_86;
        if(this.BootstrapConfig.TrackedObjectsRequired != false)
        {
                SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectTrackingManager val_52 = new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectTrackingManager();
            this._objectTrackingManager = val_52;
            val_45.AddAccepter(accepter:  val_52);
            this.semanticHorizontalPlaneTracker = new DefaultNamespace.SemanticHorizontalPlaneTracker();
            this.semanticVerticalPlaneTracker = new DefaultNamespace.SemanticVerticalPlaneTracker();
            SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.SemanticBlockCoordTracker val_55 = new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.SemanticBlockCoordTracker(voxelResolution:  this._tsdfConfig.props);
            val_85 = this.semanticHorizontalPlaneTracker;
            this.semanticBlockCoordTracker = val_55;
            this._objectTrackingManager.Setup(horizontalPlaneTracker:  val_85, verticalPlaneTracker:  this.semanticVerticalPlaneTracker, semanticVoxelTracker:  val_55, dispenser:  val_46);
        }
        
        label_71:
        if(this.BootstrapConfig.IxDepthMap != false)
        {
                SharedTechAssets.Scripts.Adapters.IllumixDepthMapAdapter val_56 = new SharedTechAssets.Scripts.Adapters.IllumixDepthMapAdapter();
            this._illumixDepthMapAdapter = val_56;
            val_22.AddAccepter(accepter:  val_56);
            this._illumixDepthMapAdapter.Setup(accepter:  new SharedTechAssets.Scripts.IllumixEngine.IllumixDepthMapDeliverer());
        }
        
        if(this.BootstrapConfig.IxDirectedPoints != false)
        {
                DirectedPointsManager val_58 = new DirectedPointsManager();
            this._directedPointsManager = val_58;
            val_21.AddAccepter(accepter:  val_58);
            this._ixDirectedPointAdapter = new SharedTechAssets.Scripts.Adapters.IxDirectedPointAdapter();
            ProcessedDirectedPointsDispenser val_60 = new ProcessedDirectedPointsDispenser();
            System.Collections.Generic.List<IProcessedDirectedPointsAccepter> val_61 = new System.Collections.Generic.List<IProcessedDirectedPointsAccepter>();
            val_61.Add(item:  this._ixDirectedPointAdapter);
            val_60.SetAccepters(accepters:  val_61);
            this._directedPointsManager.Setup(config:  this._directedPointsConfig, dispenser:  val_60, coordCache:  this._coordCache);
            this._ixDirectedPointAdapter.Setup(accepter:  new SharedTechAssets.Scripts.IllumixEngine.IxDirectedPointDeliverer());
        }
        
        if(this.BootstrapConfig.IxBoundedPlanes != false)
        {
                SharedTechAssets.Scripts.Adapters.IxBoundedPlaneAdapter val_63 = new SharedTechAssets.Scripts.Adapters.IxBoundedPlaneAdapter();
            this._ixBoundedPlaneAdapter = val_63;
            val_25.AddAccepter(accepter:  val_63);
            this._ixBoundedPlaneAdapter.Setup(accepter:  new SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer());
        }
        
        if(this.BootstrapConfig.IxSupportedPlanes != false)
        {
                SharedTechAssets.Scripts.Adapters.IxSupportedPlaneAdapter val_65 = new SharedTechAssets.Scripts.Adapters.IxSupportedPlaneAdapter();
            this._ixSupportedPlaneAdapter = val_65;
            val_27.AddAccepter(accepter:  val_65);
            val_28.AddAccepter(accepter:  this._ixSupportedPlaneAdapter);
            this._ixSupportedPlaneAdapter.Setup(horizontalSupportedPlaneAccepter:  new SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer(), verticalSupportedPlaneAccepter:  new SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer());
        }
        
        if(this.BootstrapConfig.IxPlaneAwareMeshBlocks != false)
        {
                SharedTechAssets.Scripts.Adapters.IxMeshBlockAdapter val_68 = new SharedTechAssets.Scripts.Adapters.IxMeshBlockAdapter();
            this._meshBlockAdapter = val_68;
            val_31.AddAccepter(accepter:  val_68);
            this._meshBlockAdapter.Setup(accepter:  new SharedTechAssets.Scripts.IllumixEngine.IxMeshBlockDeliverer());
        }
        
        if(this.BootstrapConfig.IxObjectDetection != false)
        {
                SharedTechAssets.Scripts.Adapters.IxObjDetectAdapter val_70 = new SharedTechAssets.Scripts.Adapters.IxObjDetectAdapter();
            this._objDetectAdapter = val_70;
            val_36.AddAccepter(accepter:  val_70);
            this._objDetectAdapter.Setup(accepter:  new SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer());
        }
        
        if(this.BootstrapConfig.IxSceneRecognition != false)
        {
                SharedTechAssets.Scripts.Adapters.IxSceneRecognitionAdapter val_72 = new SharedTechAssets.Scripts.Adapters.IxSceneRecognitionAdapter();
            this._sceneRecognitionAdapter = val_72;
            val_39.AddAccepter(accepter:  val_72);
            this._sceneRecognitionAdapter.Setup(accepter:  new SharedTechAssets.Scripts.IllumixEngine.IxSceneRecognitionDeliverer());
        }
        
        if(this.BootstrapConfig.IxSemanticPlanes != true)
        {
                if(this.BootstrapConfig.IxTrackedObjects == false)
        {
            goto label_110;
        }
        
        }
        
        this._semanticHorizontalPlaneAdapter = new SharedTechAssets.Scripts.Adapters.IxSemanticHorizontalPlaneAdapter();
        this._semanticVerticalPlaneAdapter = new SharedTechAssets.Scripts.Adapters.IxSemanticVerticalPlaneAdapter();
        val_42.AddAccepter(accepter:  this._semanticHorizontalPlaneAdapter);
        val_43.AddAccepter(accepter:  this._semanticVerticalPlaneAdapter);
        val_27.AddAccepter(accepter:  this._semanticHorizontalPlaneAdapter);
        val_28.AddAccepter(accepter:  this._semanticVerticalPlaneAdapter);
        this._semanticHorizontalPlaneAdapter.Setup(accepter:  new SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer());
        this._semanticVerticalPlaneAdapter.Setup(accepter:  new SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer());
        label_110:
        if(this.BootstrapConfig.IxSemanticVoxels == false)
        {
            goto label_118;
        }
        
        label_135:
        SharedTechAssets.Scripts.Adapters.IxSemanticVoxelAdapter val_78 = new SharedTechAssets.Scripts.Adapters.IxSemanticVoxelAdapter();
        this._semanticVoxelAdapter = val_78;
        val_44.AddAccepter(accepter:  val_78);
        val_91 = this._semanticVoxelAdapter;
        val_91.Setup(accepter:  new SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer(), resolution:  this._tsdfConfig.props);
        label_136:
        if(this.BootstrapConfig.IxTrackedObjects != false)
        {
                val_42.AddAccepter(accepter:  this.semanticHorizontalPlaneTracker);
            val_43.AddAccepter(accepter:  this.semanticVerticalPlaneTracker);
            val_44.AddAccepter(accepter:  this.semanticBlockCoordTracker);
            SharedTechAssets.Scripts.Adapters.IxTrackedObjectAdapter val_80 = new SharedTechAssets.Scripts.Adapters.IxTrackedObjectAdapter();
            this._trackedObjectAdapter = val_80;
            val_46.AddAccepter(accepter:  val_80);
            val_91 = this._trackedObjectAdapter;
            val_91.Setup(accepter:  new SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer());
        }
        
        if(this.BootstrapConfig.EnableDepthMapAugmentation == false)
        {
                return;
        }
        
        val_20.AddAccepter(accepter:  this._supportedPlaneManager);
        return;
        label_118:
        if(this.BootstrapConfig.IxTrackedObjects == false)
        {
            goto label_136;
        }
        
        if(this.BootstrapConfig.TrackedObjects_Voxels_Enabled == true)
        {
            goto label_135;
        }
        
        goto label_136;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TechBootstrapBuilder()
    {
        this.Notes = "Add this as a child to the AR Session Origin. Make sure that the Origin includes the AR Plane Manager and AR Point Cloud Manager scripts";
    }

}
