using UnityEngine;

namespace SRDebugger.UI.Controls
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ProfilerMonoBlock : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _lastRefresh;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text CurrentUsedText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject NotSupportedMessage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Slider Slider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text TotalAllocatedText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isSupported;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnEnable()
        {
            this.OnEnable();
            long val_1 = UnityEngine.Profiling.Profiler.GetMonoUsedSizeLong();
            this._isSupported = (val_1 > 0) ? 1 : 0;
            this.NotSupportedMessage.SetActive(value:  (val_1 < 1) ? 1 : 0);
            this.CurrentUsedText.gameObject.SetActive(value:  (this._isSupported == true) ? 1 : 0);
            this.TriggerRefresh();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Update()
        {
            this.Update();
            var val_6 = 0;
            val_6 = val_6 + 1;
            if(SRDebug.Instance.IsDebugPanelVisible == false)
            {
                    return;
            }
            
            float val_4 = UnityEngine.Time.realtimeSinceStartup;
            val_4 = val_4 - this._lastRefresh;
            if(val_4 <= 1f)
            {
                    return;
            }
            
            this.TriggerRefresh();
            this._lastRefresh = UnityEngine.Time.realtimeSinceStartup;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerRefresh()
        {
            UnityEngine.UI.Text val_15;
            object val_17;
            val_15 = this;
            if(this._isSupported != false)
            {
                    long val_1 = UnityEngine.Profiling.Profiler.GetMonoHeapSizeLong();
            }
            
            long val_4 = (System.GC.GetTotalMemory(forceFullCollection:  false)) >> 10;
            long val_5 = UnityEngine.Profiling.Profiler.GetMonoUsedSizeLong() >> 10;
            val_4 = (val_4 < 0) ? (val_4 + 1023) : (val_4);
            object val_8 = val_4 >> 10;
            this.Slider.maxValue = (float)val_8;
            object[] val_11 = new object[1];
            val_11[0] = val_8;
            val_17 = SRF.SRFStringExtensions.Fmt(formatString:  "Total: <color=#FFFFFF>{0}</color>MB", args:  val_11);
            if(val_5 < 1024)
            {
                    return;
            }
            
            val_15 = this.CurrentUsedText;
            object[] val_13 = new object[1];
            val_17 = ((val_5 < 0) ? (val_5 + 1023) : (val_5)) >> 10;
            val_13[0] = val_17;
            string val_14 = SRF.SRFStringExtensions.Fmt(formatString:  "<color=#FFFFFF>{0}</color>MB", args:  val_13);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerCollection()
        {
            System.GC.Collect();
            this.TriggerRefresh();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProfilerMonoBlock()
        {
        
        }
    
    }

}
