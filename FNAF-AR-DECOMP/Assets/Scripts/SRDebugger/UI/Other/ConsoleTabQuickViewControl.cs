using UnityEngine;

namespace SRDebugger.UI.Other
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ConsoleTabQuickViewControl : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int Max = 1000;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string MaxString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _prevErrorCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _prevInfoCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _prevWarningCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.Services.IConsoleService ConsoleService;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text ErrorCountText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text InfoCountText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text WarningCountText;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Awake()
        {
            this.Awake();
            if(this.InfoCountText == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Update()
        {
            var val_18;
            var val_21;
            var val_24;
            this.Update();
            if(this.ConsoleService == null)
            {
                    return;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            if((SRDebugger.UI.Other.ConsoleTabQuickViewControl.HasChanged(newCount:  this.ConsoleService.ErrorCount, oldCount: ref  this._prevErrorCount, max:  232)) != false)
            {
                    var val_23 = 0;
                val_23 = val_23 + 1;
                val_18 = null;
                val_18 = null;
                string val_7 = SRDebugger.Internal.SRDebuggerUtil.GetNumberString(value:  this.ConsoleService.ErrorCount, max:  232, exceedsMaxString:  SRDebugger.UI.Other.ConsoleTabQuickViewControl.MaxString);
            }
            
            var val_24 = 0;
            val_24 = val_24 + 1;
            if((SRDebugger.UI.Other.ConsoleTabQuickViewControl.HasChanged(newCount:  this.ConsoleService.WarningCount, oldCount: ref  this._prevWarningCount, max:  232)) != false)
            {
                    var val_25 = 0;
                val_25 = val_25 + 1;
                val_21 = null;
                val_21 = null;
                string val_14 = SRDebugger.Internal.SRDebuggerUtil.GetNumberString(value:  this.ConsoleService.WarningCount, max:  232, exceedsMaxString:  SRDebugger.UI.Other.ConsoleTabQuickViewControl.MaxString);
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            if((SRDebugger.UI.Other.ConsoleTabQuickViewControl.HasChanged(newCount:  this.ConsoleService.InfoCount, oldCount: ref  this._prevInfoCount, max:  232)) == false)
            {
                    return;
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_24 = null;
            val_24 = null;
            string val_21 = SRDebugger.Internal.SRDebuggerUtil.GetNumberString(value:  this.ConsoleService.InfoCount, max:  232, exceedsMaxString:  SRDebugger.UI.Other.ConsoleTabQuickViewControl.MaxString);
            if(this.InfoCountText == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool HasChanged(int newCount, ref int oldCount, int max)
        {
            oldCount = newCount;
            return (bool)((UnityEngine.Mathf.Clamp(value:  newCount, min:  0, max:  max)) != (UnityEngine.Mathf.Clamp(value:  oldCount, min:  0, max:  max))) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ConsoleTabQuickViewControl()
        {
            this._prevErrorCount = 0;
            this._prevInfoCount = 0;
            this._prevWarningCount = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static ConsoleTabQuickViewControl()
        {
            SRDebugger.UI.Other.ConsoleTabQuickViewControl.MaxString = 999 + "+"("+");
        }
    
    }

}
