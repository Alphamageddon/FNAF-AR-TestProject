using UnityEngine;

namespace SRDebugger.UI.Controls
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ProfilerMemoryBlock : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _lastRefresh;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text CurrentUsedText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Slider Slider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text TotalAllocatedText;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnEnable()
        {
            this.OnEnable();
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
            long val_3 = UnityEngine.Profiling.Profiler.GetTotalReservedMemoryLong() >> 10;
            long val_4 = UnityEngine.Profiling.Profiler.GetTotalAllocatedMemoryLong() >> 10;
            val_3 = (val_3 < 0) ? (val_3 + 1023) : (val_3);
            object val_7 = val_3 >> 10;
            object val_9 = ((val_4 < 0) ? (val_4 + 1023) : (val_4)) >> 10;
            this.Slider.maxValue = (float)val_7;
            object[] val_10 = new object[1];
            if(val_10 == null)
            {
                goto label_3;
            }
            
            if(val_7 != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_7 == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_10[0] = val_7;
            string val_11 = SRF.SRFStringExtensions.Fmt(formatString:  "Reserved: <color=#FFFFFF>{0}</color>MB", args:  val_10);
            object[] val_12 = new object[1];
            if(val_12 == null)
            {
                goto label_10;
            }
            
            if(val_9 != 0)
            {
                goto label_11;
            }
            
            goto label_14;
            label_10:
            if(val_9 == 0)
            {
                goto label_14;
            }
            
            label_11:
            label_14:
            val_12[0] = val_9;
            string val_13 = SRF.SRFStringExtensions.Fmt(formatString:  "<color=#FFFFFF>{0}</color>MB", args:  val_12);
            if(this.CurrentUsedText != null)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerCleanup()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.CleanUp());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator CleanUp()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new ProfilerMemoryBlock.<CleanUp>d__8();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProfilerMemoryBlock()
        {
        
        }
    
    }

}
