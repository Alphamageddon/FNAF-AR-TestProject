using UnityEngine;

namespace SharedTechAssets.Scripts
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TechBootstrap_SceneRecog : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Notes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool isRelease;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer _objDetectDeliverer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.Adapters.IxObjDetectAdapter _ixObjDetectAdapter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.SceneRecognition.SceneRecognition_Config _sceneRecognitionConfig;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DefaultNamespace.ObjectDetectionManager_Config _objectDetectionManagerConfig;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DepthObjectManager_Config _depthConfig;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TimeEngine.TimeEngine _timeEngine;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.SceneRecognition.SceneRecognitionManager _sceneRecognitionManager;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DefaultNamespace.ObjectDetectionManager _objectDetectionManager;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DepthObjectManager _depthObjectManager;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private NativeARAdapter _nativeARAdapter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.XR.ARFoundation.ARPointCloudManager m_ARPointCloudManager;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.XR.ARFoundation.ARPlaneManager m_ARPlaneManager;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.Adapters.IllumixDepthMapAdapter _illumixDepthMapAdapter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.Adapters.IxModelDownloadProgressAdapter _modelDownloadProgressAdapter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera arCamera;
        
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
            this._sceneRecognitionManager = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetConfigs()
        {
            this._sceneRecognitionConfig = this.GetComponent<SharedTechAssets.Scripts.SceneRecognition.SceneRecognition_Config>();
            val_1.shouldDownloadModel = this.isRelease;
            this._objectDetectionManagerConfig = this.GetComponent<DefaultNamespace.ObjectDetectionManager_Config>();
            val_2.shouldDownloadModel = this.isRelease;
            this._depthConfig = this.GetComponent<DepthObjectManager_Config>();
            val_3.shouldDownloadModel = this.isRelease;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BuildConnections()
        {
            this._nativeARAdapter = new NativeARAdapter();
            this._sceneRecognitionManager = new SharedTechAssets.Scripts.SceneRecognition.SceneRecognitionManager();
            this._objectDetectionManager = new DefaultNamespace.ObjectDetectionManager();
            this._depthObjectManager = new DepthObjectManager();
            this.m_ARPointCloudManager = this.GetComponentInParent<UnityEngine.XR.ARFoundation.ARPointCloudManager>();
            this.m_ARPlaneManager = this.GetComponentInParent<UnityEngine.XR.ARFoundation.ARPlaneManager>();
            this._ixObjDetectAdapter = new SharedTechAssets.Scripts.Adapters.IxObjDetectAdapter();
            this._illumixDepthMapAdapter = new SharedTechAssets.Scripts.Adapters.IllumixDepthMapAdapter();
            this._modelDownloadProgressAdapter = new SharedTechAssets.Scripts.Adapters.IxModelDownloadProgressAdapter();
            this.arCamera = this.GetComponentInParent<UnityEngine.XR.ARFoundation.ARSessionOrigin>().gameObject.GetComponentInChildren<UnityEngine.Camera>();
            TimeUpdateDispenser val_13 = new TimeUpdateDispenser();
            val_13.SetAccepters(accepters:  new System.Collections.Generic.List<ITimeUpdateAccepter>());
            TimeUpdateDispenser val_15 = new TimeUpdateDispenser();
            val_15.SetAccepters(accepters:  new System.Collections.Generic.List<ITimeUpdateAccepter>());
            PointDispenser val_17 = new PointDispenser();
            val_17.SetAccepters(accepters:  new System.Collections.Generic.List<IPointAccepter>());
            ARPlaneDispenser val_19 = new ARPlaneDispenser();
            val_19.SetAccepters(accepters:  new System.Collections.Generic.List<IARPlaneAccepter>());
            this._nativeARAdapter.Setup(earlyTimeDispenser:  val_13, lateTimeDispenser:  val_15, pointDispenser:  val_17, planeDispenser:  val_19, pointCloudManager:  this.m_ARPointCloudManager, planeManager:  this.m_ARPlaneManager);
            DepthMapDispenser val_21 = new DepthMapDispenser();
            val_21.SetAccepters(accepters:  new System.Collections.Generic.List<IDepthMapAccepter>());
            RawDirectedPointsDispenser val_23 = new RawDirectedPointsDispenser();
            val_23.SetAccepters(accepters:  new System.Collections.Generic.List<IRawDirectedPointsAccepter>());
            System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IRawDepthMapAccepter> val_26 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IRawDepthMapAccepter>();
            val_26.Add(item:  this._illumixDepthMapAdapter);
            ._accepters = val_26;
            SharedTechAssets.Scripts.TechInterfaces.Dispensers.DownloadProgressDispenser val_27 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.DownloadProgressDispenser();
            System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IDownloadProgressAccepter> val_28 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IDownloadProgressAccepter>();
            val_28.Add(item:  this._modelDownloadProgressAdapter);
            .downloadProgressAccepters = val_28;
            this._depthObjectManager.Setup(dispenser:  val_21, dirPtsDispenser:  val_23, rawDepthMapDispenser:  new SharedTechAssets.Scripts.TechInterfaces.Dispensers.RawDepthMapDispenser(), config:  this._depthConfig, m_Camera:  this.arCamera, modelDownloadStatus:  0);
            this._timeEngine = this.arCamera.gameObject.AddComponent<SharedTechAssets.Scripts.TimeEngine.TimeEngine>();
            TimeUpdateDispenser val_31 = new TimeUpdateDispenser();
            System.Collections.Generic.List<ITimeUpdateAccepter> val_32 = new System.Collections.Generic.List<ITimeUpdateAccepter>();
            val_32.Add(item:  this._sceneRecognitionManager);
            val_31.SetAccepters(accepters:  val_32);
            this._timeEngine._dispenser = val_31;
            SharedTechAssets.Scripts.Adapters.IxSceneRecognitionAdapter val_34 = new SharedTechAssets.Scripts.Adapters.IxSceneRecognitionAdapter();
            val_34.Setup(accepter:  new SharedTechAssets.Scripts.IllumixEngine.IxSceneRecognitionDeliverer());
            System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISceneRecognitionAccepter> val_36 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISceneRecognitionAccepter>();
            val_36.Add(item:  val_34);
            .sceneRecognitionAccepters = val_36;
            SharedTechAssets.Scripts.TechInterfaces.Dispensers.DownloadProgressDispenser val_37 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.DownloadProgressDispenser();
            System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IDownloadProgressAccepter> val_38 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IDownloadProgressAccepter>();
            val_38.Add(item:  this._modelDownloadProgressAdapter);
            .downloadProgressAccepters = val_38;
            this._sceneRecognitionManager.Setup(config:  this._sceneRecognitionConfig, dispenser:  new SharedTechAssets.Scripts.TechInterfaces.Dispensers.SceneRecognitionDispenser(), modelDownloadStatus:  0);
            System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IObjDetectAccepter> val_40 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IObjDetectAccepter>();
            val_40.Add(item:  this._ixObjDetectAdapter);
            .objDetectAccepters = val_40;
            SharedTechAssets.Scripts.TechInterfaces.Dispensers.DownloadProgressDispenser val_41 = new SharedTechAssets.Scripts.TechInterfaces.Dispensers.DownloadProgressDispenser();
            System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IDownloadProgressAccepter> val_42 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IDownloadProgressAccepter>();
            val_42.Add(item:  this._modelDownloadProgressAdapter);
            .downloadProgressAccepters = val_42;
            this._objectDetectionManager.Setup(config:  this._objectDetectionManagerConfig, dispenser:  new SharedTechAssets.Scripts.TechInterfaces.Dispensers.ObjDetectDispenser(), modelDownloadStatus:  0);
            SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer val_43 = new SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer();
            this._objDetectDeliverer = val_43;
            this._ixObjDetectAdapter.Setup(accepter:  val_43);
            this._illumixDepthMapAdapter.Setup(accepter:  new SharedTechAssets.Scripts.IllumixEngine.IllumixDepthMapDeliverer());
            this._modelDownloadProgressAdapter.Setup(accepter:  new SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TechBootstrap_SceneRecog()
        {
            this.Notes = "Add this as a child to the AR Session Origin. Make sure that the Origin includes the AR Plane Manager and AR Point Cloud Manager scripts. Enable isRelease to trigger calls to download the models to be used. Make sure mlmodel_config.txt is properly set as well";
        }
    
    }

}
