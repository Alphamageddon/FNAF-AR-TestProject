using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class KeyboardShortcutListenerService : SRServiceBase<SRDebugger.Services.Implementation.KeyboardShortcutListenerService>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<SRDebugger.Settings.KeyboardShortcut> _shortcuts;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Awake()
        {
            this.Awake();
            this.CachedTransform.SetParent(p:  SRF.Hierarchy.Get(key:  "SRDebugger"));
            SRDebugger.Settings val_3 = SRDebugger.Settings.Instance;
            this._shortcuts = new System.Collections.Generic.List<KeyboardShortcut>(collection:  val_3._newKeyboardShortcuts);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ToggleTab(SRDebugger.DefaultTabs t)
        {
            var val_11 = 0;
            val_11 = val_11 + 1;
            System.Nullable<SRDebugger.DefaultTabs> val_3 = SRDebugger.Internal.Service.Panel.ActiveTab;
            var val_12 = 0;
            val_12 = val_12 + 1;
            if(((SRDebugger.Internal.Service.Panel.IsVisible != false) && ((1203527576 & 1) != 0)) && (1203527576 == t))
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
            }
            else
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                SRDebug.Instance.ShowDebugPanel(tab:  t, requireEntryCode:  true);
                return;
            }
            
            SRDebug.Instance.HideDebugPanel();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ExecuteShortcut(SRDebugger.Settings.KeyboardShortcut shortcut)
        {
            if((shortcut.Action - 1) <= 10)
            {
                    var val_8 = 52951356;
                val_8 = (52951356 + ((shortcut.Action - 1)) << 2) + val_8;
            }
            else
            {
                    UnityEngine.Debug.LogWarning(message:  "[SRDebugger] Unhandled keyboard shortcut: "("[SRDebugger] Unhandled keyboard shortcut: ") + shortcut.Action);
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Update()
        {
            var val_21;
            var val_22;
            this.Update();
            SRDebugger.Settings val_1 = SRDebugger.Settings.Instance;
            if((val_1._keyboardEscapeClose != false) && ((UnityEngine.Input.GetKeyDown(key:  27)) != false))
            {
                    var val_20 = 0;
                val_20 = val_20 + 1;
                if(SRDebugger.Internal.Service.Panel.IsVisible != false)
            {
                    var val_21 = 0;
                val_21 = val_21 + 1;
                SRDebug.Instance.HideDebugPanel();
            }
            
            }
            
            if((UnityEngine.Input.GetKey(key:  50)) != false)
            {
                
            }
            
            if((UnityEngine.Input.GetKey(key:  52)) != false)
            {
                    val_21 = 1;
            }
            else
            {
                    val_21 = UnityEngine.Input.GetKey(key:  51);
            }
            
            if((UnityEngine.Input.GetKey(key:  48)) != false)
            {
                
            }
            
            val_22 = 0;
            goto label_21;
            label_29:
            var val_15 = (val_14.Control == false) ? 1 : 0;
            val_15 = (UnityEngine.Input.GetKey(key:  49)) | val_15;
            if(val_15 == false)
            {
                goto label_26;
            }
            
            var val_16 = (val_14.Shift == false) ? 1 : 0;
            val_16 = (UnityEngine.Input.GetKey(key:  47)) | val_16;
            if(val_16 == false)
            {
                goto label_26;
            }
            
            var val_17 = (val_14.Alt == false) ? 1 : 0;
            val_17 = val_21 | val_17;
            if(val_17 == false)
            {
                goto label_26;
            }
            
            bool val_18 = UnityEngine.Input.GetKeyDown(key:  val_14.Key);
            if(val_18 == true)
            {
                goto label_27;
            }
            
            label_26:
            val_22 = 1;
            label_21:
            if(val_22 < this._shortcuts.Count)
            {
                goto label_29;
            }
            
            return;
            label_27:
            val_18.ExecuteShortcut(shortcut:  this._shortcuts.Item[0]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public KeyboardShortcutListenerService()
        {
        
        }
    
    }

}
