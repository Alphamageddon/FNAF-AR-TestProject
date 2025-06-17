using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BugReportApiService : SRServiceBase<SRDebugger.Services.IBugReportService>, IBugReportService
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float Timeout = 12;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.Services.BugReportCompleteCallback _completeCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _errorMessage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isBusy;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _previousProgress;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.Services.BugReportProgressCallback _progressCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.Internal.BugReportApi _reportApi;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendBugReport(SRDebugger.Services.BugReport report, SRDebugger.Services.BugReportCompleteCallback completeHandler, SRDebugger.Services.BugReportProgressCallback progressCallback)
        {
            string val_9;
            if(report == null)
            {
                goto label_1;
            }
            
            if(completeHandler == null)
            {
                goto label_2;
            }
            
            if(this._isBusy != false)
            {
                    label_7:
                completeHandler.Invoke(didSucceed:  false, errorMessage:  "BugReportApiService is already sending a bug report");
                return;
            }
            
            if(UnityEngine.Application.internetReachability == 0)
            {
                goto label_7;
            }
            
            this._errorMessage = "";
            this.enabled = true;
            this._isBusy = true;
            this._completeCallback = completeHandler;
            this._progressCallback = progressCallback;
            SRDebugger.Internal.BugReportApi val_4 = new SRDebugger.Internal.BugReportApi();
            ._apiKey = SRDebugger.Settings.Instance.ApiKey;
            ._bugReport = report;
            this._reportApi = val_4;
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  val_4.Submit());
            return;
            label_1:
            val_9 = "report";
            goto label_8;
            label_2:
            val_9 = "completeHandler";
            label_8:
            null = new System.ArgumentNullException(paramName:  val_9);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Awake()
        {
            this.Awake();
            this.CachedTransform.SetParent(p:  SRF.Hierarchy.Get(key:  "SRDebugger"));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnProgress(float progress)
        {
            if(this._progressCallback == null)
            {
                    return;
            }
            
            this._progressCallback.Invoke(progress:  progress);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnComplete()
        {
            SRDebugger.Internal.BugReportApi val_3;
            string val_4;
            this._isBusy = false;
            this.enabled = false;
            val_3 = this._reportApi;
            if(this._reportApi != null)
            {
                goto label_0;
            }
            
            val_3 = this._reportApi;
            if(val_3 == null)
            {
                goto label_1;
            }
            
            label_0:
            if((System.String.IsNullOrEmpty(value:  this._reportApi.<ErrorMessage>k__BackingField)) != false)
            {
                    val_4 = this._errorMessage;
            }
            else
            {
                    val_4 = this._reportApi.<ErrorMessage>k__BackingField;
            }
            
            this._completeCallback.Invoke(didSucceed:  ((this._reportApi.<WasSuccessful>k__BackingField) == true) ? 1 : 0, errorMessage:  mem[this._reportApi.<ErrorMessage>k__BackingField]);
            this._completeCallback = 0;
            return;
            label_1:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Update()
        {
            this.Update();
            if(this._isBusy == false)
            {
                    return;
            }
            
            if(this._reportApi == null)
            {
                    this._isBusy = false;
            }
            
            if((this._reportApi.<IsComplete>k__BackingField) != false)
            {
                    this.OnComplete();
                return;
            }
            
            if(this._previousProgress == this._reportApi.Progress)
            {
                    return;
            }
            
            if(this._progressCallback != null)
            {
                    this._progressCallback.Invoke(progress:  this._reportApi.Progress);
            }
            
            this._previousProgress = this._reportApi.Progress;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BugReportApiService()
        {
        
        }
    
    }

}
