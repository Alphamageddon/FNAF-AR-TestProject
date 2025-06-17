using UnityEngine;

namespace GameUI.CanvasFlow
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GameProject_Alpine_CanvasController_Loading : CanvasController
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float LowSpeed = 0.05;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float MidSpeed = 0.1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float HighSpeed = 0.15;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.LoadingHandler _loadingHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _counterComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _running;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _percent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _displayPercent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _assetDownloadInProgress;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _loadingScreenHidden;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            Master.MasterDomain val_3;
            this.Start();
            val_3 = Master.MasterDomain.GetDomain();
            this._masterDomain = val_3;
            if(val_3 == null)
            {
                goto label_1;
            }
            
            this._loadingHandler = val_1.loadingHandler;
            goto label_2;
            label_1:
            val_3 = this._masterDomain;
            this._loadingHandler = val_1.loadingHandler;
            if(this._masterDomain == null)
            {
                goto label_3;
            }
            
            label_2:
            this._loadingScreenHidden = false;
            this._running = true;
            this._masterEvents = this._masterDomain.eventExposer;
            this._masterDomain.eventExposer.add_AssetBundleDownloadProgressUpdated(value:  new System.Action<Systems.AssetManagement.Bundles.BundleDownloadProgressData>(object:  this, method:  System.Void GameUI.CanvasFlow.GameProject_Alpine_CanvasController_Loading::AssetBundleDownloadProgressUpdated(Systems.AssetManagement.Bundles.BundleDownloadProgressData data)));
            return;
            label_3:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            this._masterEvents.remove_AssetBundleDownloadProgressUpdated(value:  new System.Action<Systems.AssetManagement.Bundles.BundleDownloadProgressData>(object:  this, method:  System.Void GameUI.CanvasFlow.GameProject_Alpine_CanvasController_Loading::AssetBundleDownloadProgressUpdated(Systems.AssetManagement.Bundles.BundleDownloadProgressData data)));
            this._loadingHandler = 0;
            this._masterEvents = 0;
            this._masterDomain = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(this._running == false)
            {
                    return;
            }
            
            this.UpdateCounterValues();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetDisplayPercent()
        {
            return (float)this._displayPercent;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsAssetDownloadInProgress()
        {
            return (bool)this._assetDownloadInProgress;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool LoadingComplete()
        {
            return (bool)this._counterComplete;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadingScreenEnd()
        {
            this._loadingScreenHidden = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AssetBundleDownloadProgressUpdated(Systems.AssetManagement.Bundles.BundleDownloadProgressData data)
        {
            int val_2;
            if(data != null)
            {
                    val_2 = data.Complete;
            }
            else
            {
                    val_2 = 11993091;
            }
            
            this._assetDownloadInProgress = (11993091 < data.Total) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateCounterValues()
        {
            float val_7;
            float val_8;
            int val_1 = this._loadingHandler.GetTotalLoaded();
            int val_2 = this._loadingHandler.GetTotalLoads();
            if(val_2 != 0)
            {
                    val_7 = (float)val_1 / (float)val_2;
            }
            else
            {
                    val_7 = 1f;
            }
            
            this._percent = val_7;
            float val_6 = 0f;
            float val_3 = UnityEngine.Mathf.Clamp(value:  val_7, min:  val_6, max:  1f);
            float val_7 = this._displayPercent;
            val_8 = 0.15f;
            this._percent = val_3;
            val_6 = val_3 - val_7;
            if(val_6 < val_8)
            {
                    val_8 = 0.05f;
                if(val_6 >= val_8)
            {
                    val_8 = 0.1f;
            }
            
            }
            
            float val_4 = UnityEngine.Time.deltaTime;
            val_4 = val_8 * val_4;
            val_7 = val_7 + val_4;
            this._displayPercent = val_7;
            float val_5 = UnityEngine.Mathf.Clamp(value:  val_7, min:  0f, max:  this._percent);
            this._displayPercent = val_5;
            if(val_2 >= 1)
            {
                    if(val_1 < val_2)
            {
                    return;
            }
            
                if(val_5 < 0.97f)
            {
                    return;
            }
            
            }
            
            this._counterComplete = true;
            if(this._loadingScreenHidden == false)
            {
                    return;
            }
            
            this._running = false;
            this.PerformTransitionWithIdentifier(identifier:  "Dismiss");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameProject_Alpine_CanvasController_Loading()
        {
        
        }
    
    }

}
