using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DockConsoleServiceImpl : IDockConsoleService
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.ConsoleAlignment _alignment;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.UI.Other.DockConsoleController _consoleRoot;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _didSuspendTrigger;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isExpanded;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isVisible;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsVisible { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsExpanded { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.ConsoleAlignment Alignment { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DockConsoleServiceImpl()
        {
            this._isExpanded = true;
            SRDebugger.Settings val_1 = SRDebugger.Settings.Instance;
            this._alignment = val_1._consoleAlignment;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsVisible()
        {
            return (bool)this._isVisible;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_IsVisible(bool value)
        {
            var val_1 = (this._isVisible == true) ? 1 : 0;
            val_1 = val_1 ^ value;
            if(val_1 == false)
            {
                    return;
            }
            
            this._isVisible = value;
            if((this._consoleRoot == 0) && (value != false))
            {
                    this.Load();
            }
            else
            {
                    this._consoleRoot.CachedGameObject.SetActive(value:  value);
            }
            
            this.CheckTrigger();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsExpanded()
        {
            return (bool)this._isExpanded;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_IsExpanded(bool value)
        {
            var val_1 = (this._isExpanded == true) ? 1 : 0;
            val_1 = val_1 ^ value;
            if(val_1 == false)
            {
                    return;
            }
            
            this._isExpanded = value;
            if((this._consoleRoot == 0) && (value != false))
            {
                    this.Load();
            }
            else
            {
                    this._consoleRoot.SetDropdownVisibility(visible:  value);
            }
            
            this.CheckTrigger();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.ConsoleAlignment get_Alignment()
        {
            return (SRDebugger.ConsoleAlignment)this._alignment;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Alignment(SRDebugger.ConsoleAlignment value)
        {
            this._alignment = value;
            if(this._consoleRoot != 0)
            {
                    this._consoleRoot.SetAlignmentMode(alignment:  value);
            }
            
            this.CheckTrigger();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Load()
        {
            var val_7;
            object val_8;
            if((SRF.Service.SRServiceManager.GetService<SRDebugger.Services.IPinnedUIService>()) == null)
            {
                goto label_3;
            }
            
            val_7 = 0;
            goto label_5;
            label_3:
            val_8 = "[DockConsoleService] PinnedUIService not found";
            goto label_8;
            label_5:
            if( != 0)
            {
                goto label_11;
            }
            
            val_8 = "[DockConsoleService] Expected IPinnedUIService to be PinnedUIServiceImpl";
            label_8:
            UnityEngine.Debug.LogError(message:  val_8);
            return;
            label_11:
            SRDebugger.UI.Other.DockConsoleController val_4 = DockConsoleController;
            this._consoleRoot = val_4;
            val_4.SetDropdownVisibility(visible:  (this._isExpanded == true) ? 1 : 0);
            this._consoleRoot.IsVisible = (this._isVisible == true) ? 1 : 0;
            this._consoleRoot.SetAlignmentMode(alignment:  this._alignment);
            this.CheckTrigger();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CheckTrigger()
        {
            var val_15;
            var val_18;
            var val_19;
            var val_21;
            bool val_24;
            var val_16 = 0;
            val_16 = val_16 + 1;
            SRDebugger.PinAlignment val_3 = SRDebugger.Internal.Service.Trigger.Position;
            if(val_3 <= 7)
            {
                    var val_17 = 1;
                val_17 = val_17 << val_3;
                if((val_17 & 67) == 0)
            {
                    val_17 = val_17 & 140;
                if(val_17 == 0)
            {
                goto label_30;
            }
            
                val_15 = 1152921522989841712;
            }
            else
            {
                    val_15 = 1152921522989841712;
            }
            
            }
            
            label_30:
            if((( & 1) != 0) && (this._isVisible != false))
            {
                    var val_5 = (this._alignment == ) ? 1 : 0;
            }
            else
            {
                    val_18 = 0;
            }
            
            SRDebugger.Services.IDebugTriggerService val_9 = SRDebugger.Internal.Service.Trigger;
            if(((((val_18 != 0) ? 1 : 0) | ((this._didSuspendTrigger == false) ? 1 : 0)) & 1) == 0)
            {
                goto label_14;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_19 = 0;
            goto label_18;
            label_14:
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_21 = 1;
            goto label_22;
            label_18:
            if((val_18 & val_9.IsEnabled) == false)
            {
                    return;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_19 = 1;
            goto label_28;
            label_22:
            val_9.IsEnabled = true;
            val_24 = 0;
            goto label_29;
            label_28:
            SRDebugger.Internal.Service.Trigger.IsEnabled = false;
            val_24 = true;
            label_29:
            this._didSuspendTrigger = val_24;
        }
    
    }

}
