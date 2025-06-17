using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DebugPanelServiceImpl : ScriptableObject, IDebugPanelService
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.UI.DebugPanelRoot _debugPanelRootObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<SRDebugger.Services.IDebugPanelService, bool> VisibilityChanged;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isVisible;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<bool> _cursorWasVisible;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<UnityEngine.CursorLockMode> _cursorLockMode;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.UI.DebugPanelRoot RootObject { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsLoaded { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsVisible { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<SRDebugger.DefaultTabs> ActiveTab { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_VisibilityChanged(System.Action<SRDebugger.Services.IDebugPanelService, bool> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.VisibilityChanged, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.VisibilityChanged != 1152921522985727232);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_VisibilityChanged(System.Action<SRDebugger.Services.IDebugPanelService, bool> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.VisibilityChanged, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.VisibilityChanged != 1152921522985863808);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.UI.DebugPanelRoot get_RootObject()
        {
            return (SRDebugger.UI.DebugPanelRoot)this._debugPanelRootObject;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsLoaded()
        {
            return UnityEngine.Object.op_Inequality(x:  this._debugPanelRootObject, y:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsVisible()
        {
            var val_3;
            if(this.IsLoaded != false)
            {
                    var val_2 = (this._isVisible == true) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
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
            
            bool val_2 = this.IsLoaded;
            if(value == false)
            {
                goto label_2;
            }
            
            if(val_2 != true)
            {
                    this.Load();
            }
            
            bool val_3 = SRDebugger.Internal.SRDebuggerUtil.EnsureEventSystemExists();
            this._debugPanelRootObject.CanvasGroup.alpha = 1f;
            this._debugPanelRootObject.CanvasGroup.interactable = true;
            this._debugPanelRootObject.CanvasGroup.blocksRaycasts = true;
            bool val_5 = UnityEngine.Cursor.visible;
            this._cursorWasVisible = 0;
            UnityEngine.CursorLockMode val_6 = UnityEngine.Cursor.lockState;
            this._cursorLockMode = 0;
            if(SRDebugger.Settings.Instance.AutomaticallyShowCursor == false)
            {
                goto label_21;
            }
            
            UnityEngine.Cursor.visible = true;
            UnityEngine.Cursor.lockState = 0;
            goto label_21;
            label_2:
            if(val_2 != false)
            {
                    this._debugPanelRootObject.CanvasGroup.alpha = 0f;
                this._debugPanelRootObject.CanvasGroup.interactable = false;
                this._debugPanelRootObject.CanvasGroup.blocksRaycasts = false;
            }
            
            if((this._cursorWasVisible & 1) != 0)
            {
                    System.Nullable<System.Boolean> val_10 = this._cursorWasVisible;
                val_10 = val_10 & 1;
                UnityEngine.Cursor.visible = val_10;
                mem2[0] = 0;
            }
            
            if((this._cursorLockMode & 1) != 0)
            {
                    UnityEngine.Cursor.lockState = this._cursorLockMode;
                mem2[0] = 0;
            }
            
            label_21:
            bool val_9 = value;
            this._isVisible = val_9;
            if(this.VisibilityChanged == null)
            {
                    return;
            }
            
            this.VisibilityChanged.Invoke(arg1:  this, arg2:  val_9);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<SRDebugger.DefaultTabs> get_ActiveTab()
        {
            if(this._debugPanelRootObject == 0)
            {
                    return 0;
            }
            
            if(this._debugPanelRootObject.TabController != null)
            {
                    return this._debugPanelRootObject.TabController.ActiveTab;
            }
            
            return this._debugPanelRootObject.TabController.ActiveTab;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OpenTab(SRDebugger.DefaultTabs tab)
        {
            if(this.IsLoaded != false)
            {
                    if(this._isVisible == true)
            {
                goto label_1;
            }
            
            }
            
            this.IsVisible = true;
            label_1:
            bool val_2 = this._debugPanelRootObject.TabController.OpenTab(tab:  tab);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Unload()
        {
            if(this._debugPanelRootObject == 0)
            {
                    return;
            }
            
            this.IsVisible = false;
            this._debugPanelRootObject.CachedGameObject.SetActive(value:  false);
            UnityEngine.Object.Destroy(obj:  this._debugPanelRootObject.CachedGameObject);
            this._debugPanelRootObject = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Load()
        {
            SRDebugger.UI.DebugPanelRoot val_1 = UnityEngine.Resources.Load<SRDebugger.UI.DebugPanelRoot>(path:  "SRDebugger/UI/Prefabs/DebugPanel");
            if(val_1 == 0)
            {
                    UnityEngine.Debug.LogError(message:  "[SRDebugger] Error loading debug panel prefab");
                return;
            }
            
            SRDebugger.UI.DebugPanelRoot val_3 = SRInstantiate.Instantiate<SRDebugger.UI.DebugPanelRoot>(prefab:  val_1);
            this._debugPanelRootObject = val_3;
            val_3.name = "Panel";
            UnityEngine.Object.DontDestroyOnLoad(target:  this._debugPanelRootObject);
            this._debugPanelRootObject.CachedTransform.SetParent(parent:  SRF.Hierarchy.Get(key:  "SRDebugger"), worldPositionStays:  true);
            bool val_6 = SRDebugger.Internal.SRDebuggerUtil.EnsureEventSystemExists();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DebugPanelServiceImpl()
        {
        
        }
    
    }

}
