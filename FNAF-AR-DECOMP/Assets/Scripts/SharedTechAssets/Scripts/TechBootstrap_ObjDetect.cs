using UnityEngine;

namespace SharedTechAssets.Scripts
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TechBootstrap_ObjDetect : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Notes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DefaultNamespace.ObjectDetectionManager_Config _objDetConfig;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TimeEngine.TimeEngine _timeEngine;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DefaultNamespace.ObjectDetectionManager _objectDetectionManager;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private NativeARAdapter _nativeARAdapter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.XR.ARFoundation.ARPointCloudManager m_ARPointCloudManager;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.XR.ARFoundation.ARPlaneManager m_ARPlaneManager;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.Adapters.IxObjDetectAdapter _ixObjDetectAdapter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer _deliverer;
        
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
            this._objectDetectionManager = 0;
            this._objDetConfig = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetConfigs()
        {
            this._objDetConfig = this.GetComponent<DefaultNamespace.ObjectDetectionManager_Config>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BuildConnections()
        {
            this._nativeARAdapter = new NativeARAdapter();
            this._ixObjDetectAdapter = new SharedTechAssets.Scripts.Adapters.IxObjDetectAdapter();
            this._objectDetectionManager = new DefaultNamespace.ObjectDetectionManager();
            this._deliverer = new SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer();
            this.m_ARPointCloudManager = this.GetComponentInParent<UnityEngine.XR.ARFoundation.ARPointCloudManager>();
            this.m_ARPlaneManager = this.GetComponentInParent<UnityEngine.XR.ARFoundation.ARPlaneManager>();
            TimeUpdateDispenser val_7 = new TimeUpdateDispenser();
            val_7.SetAccepters(accepters:  new System.Collections.Generic.List<ITimeUpdateAccepter>());
            TimeUpdateDispenser val_9 = new TimeUpdateDispenser();
            val_9.SetAccepters(accepters:  new System.Collections.Generic.List<ITimeUpdateAccepter>());
            PointDispenser val_11 = new PointDispenser();
            val_11.SetAccepters(accepters:  new System.Collections.Generic.List<IPointAccepter>());
            ARPlaneDispenser val_13 = new ARPlaneDispenser();
            val_13.SetAccepters(accepters:  new System.Collections.Generic.List<IARPlaneAccepter>());
            this._nativeARAdapter.Setup(earlyTimeDispenser:  val_7, lateTimeDispenser:  val_9, pointDispenser:  val_11, planeDispenser:  val_13, pointCloudManager:  this.m_ARPointCloudManager, planeManager:  this.m_ARPlaneManager);
            this._timeEngine = this.gameObject.AddComponent<SharedTechAssets.Scripts.TimeEngine.TimeEngine>();
            TimeUpdateDispenser val_17 = new TimeUpdateDispenser();
            System.Collections.Generic.List<ITimeUpdateAccepter> val_18 = new System.Collections.Generic.List<ITimeUpdateAccepter>();
            val_18.Add(item:  this._objectDetectionManager);
            val_17.SetAccepters(accepters:  val_18);
            this._timeEngine._dispenser = val_17;
            System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IObjDetectAccepter> val_20 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IObjDetectAccepter>();
            val_20.Add(item:  this._ixObjDetectAdapter);
            .objDetectAccepters = val_20;
            this._objectDetectionManager.Setup(config:  this._objDetConfig, dispenser:  new SharedTechAssets.Scripts.TechInterfaces.Dispensers.ObjDetectDispenser(), modelDownloadStatus:  0);
            this._ixObjDetectAdapter.Setup(accepter:  this._deliverer);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TechBootstrap_ObjDetect()
        {
            this.Notes = "Add this as a child to the AR Session Origin. Make sure that the Origin includes the AR Plane Manager and AR Point Cloud Manager scripts";
        }
    
    }

}
