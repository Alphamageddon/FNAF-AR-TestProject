using UnityEngine;

namespace DevTools.Runtime.DebugMenu
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FPS_SROptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string CategoryName = "FPS";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _fpsCounterVisible;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _fpsLimited;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShowFpsCounterDisplay { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool LimitFPS { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_ShowFpsCounterDisplay()
        {
            return (bool)this._fpsCounterVisible;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ShowFpsCounterDisplay(bool value)
        {
            if(value != false)
            {
                    CodeStage.AdvancedFPSCounter.AFPSCounter val_1 = CodeStage.AdvancedFPSCounter.AFPSCounter.AddToScene(keepAlive:  true);
                CodeStage.AdvancedFPSCounter.AFPSCounter.Instance.ScaleFactor = 2f;
            }
            else
            {
                    CodeStage.AdvancedFPSCounter.AFPSCounter.SelfDestroy();
            }
            
            this._fpsCounterVisible = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_LimitFPS()
        {
            return (bool)this._fpsLimited;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_LimitFPS(bool value)
        {
            var val_2;
            if(value != false)
            {
                    UnityEngine.Application.targetFrameRate = 3;
                val_2 = 0;
            }
            else
            {
                    UnityEngine.Application.targetFrameRate = 0;
                val_2 = 1;
            }
            
            UnityEngine.QualitySettings.vSyncCount = 1;
            this._fpsLimited = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FPS_SROptions()
        {
        
        }
    
    }

}
