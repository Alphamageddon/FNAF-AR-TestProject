using UnityEngine;

namespace SRDebugger.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ProfilerFPSLabel : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _nextUpdate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.Services.IProfilerService _profilerService;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float UpdateFrequency;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text _text;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Update()
        {
            this.Update();
            if(UnityEngine.Time.realtimeSinceStartup <= this._nextUpdate)
            {
                    return;
            }
            
            this.Refresh();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Refresh()
        {
            object[] val_1 = new object[1];
            var val_6 = 0;
            val_6 = val_6 + 1;
            float val_3 = this._profilerService.AverageFrameTime;
            val_3 = 1f / val_3;
            if(val_1 == null)
            {
                goto label_6;
            }
            
            if(val_3 != 0)
            {
                goto label_7;
            }
            
            goto label_10;
            label_6:
            if(val_3 == 0)
            {
                goto label_10;
            }
            
            label_7:
            label_10:
            val_1[0] = val_3;
            string val_4 = SRF.SRFStringExtensions.Fmt(formatString:  "FPS: {0:0.00}", args:  val_1);
            float val_5 = UnityEngine.Time.realtimeSinceStartup;
            val_5 = val_5 + this.UpdateFrequency;
            this._nextUpdate = val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProfilerFPSLabel()
        {
            this.UpdateFrequency = 1f;
        }
    
    }

}
