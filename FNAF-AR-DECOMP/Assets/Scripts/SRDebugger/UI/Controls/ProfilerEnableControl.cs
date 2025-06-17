using UnityEngine;

namespace SRDebugger.UI.Controls
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ProfilerEnableControl : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _previousState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text ButtonText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Button EnableButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text Text;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            var val_4;
            var val_5;
            this.Start();
            if(UnityEngine.Profiling.Profiler.supported == false)
            {
                goto label_1;
            }
            
            if(UnityEngine.Application.HasProLicense() == false)
            {
                goto label_2;
            }
            
            this.UpdateLabels();
            return;
            label_1:
            val_4 = null;
            val_4 = null;
            if(this.Text != null)
            {
                goto label_12;
            }
            
            label_13:
            label_12:
            this.EnableButton.gameObject.SetActive(value:  false);
            this.enabled = false;
            return;
            label_2:
            val_5 = null;
            val_5 = null;
            if(this.Text != null)
            {
                goto label_12;
            }
            
            goto label_13;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void UpdateLabels()
        {
            var val_4;
            var val_5;
            UnityEngine.UI.Text val_6;
            var val_8;
            var val_9;
            val_4 = null;
            if(UnityEngine.Profiling.Profiler.enabled != false)
            {
                    val_5 = null;
                val_6 = this.ButtonText;
                val_8 = "Disable";
            }
            else
            {
                    val_9 = null;
                val_6 = this.ButtonText;
                val_8 = "Enable";
            }
            
            this._previousState = UnityEngine.Profiling.Profiler.enabled;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Update()
        {
            this.Update();
            var val_2 = (this._previousState == true) ? 1 : 0;
            val_2 = UnityEngine.Profiling.Profiler.enabled ^ val_2;
            if(val_2 == false)
            {
                    return;
            }
            
            this.UpdateLabels();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ToggleProfiler()
        {
            UnityEngine.Debug.Log(message:  "Toggle Profiler");
            bool val_1 = UnityEngine.Profiling.Profiler.enabled;
            val_1 = (~val_1) & 1;
            UnityEngine.Profiling.Profiler.enabled = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProfilerEnableControl()
        {
        
        }
    
    }

}
