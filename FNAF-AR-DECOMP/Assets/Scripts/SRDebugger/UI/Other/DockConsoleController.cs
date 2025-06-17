using UnityEngine;

namespace SRDebugger.UI.Other
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DockConsoleController : SRMonoBehaviourEx, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float NonFocusOpacity = 0.65;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isDirty;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isDragging;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _pointersOver;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject BottomHandle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.CanvasGroup CanvasGroup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.UI.Controls.ConsoleLogControl Console;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject Dropdown;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Image DropdownToggleSprite;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text TextErrors;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text TextInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text TextWarnings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Toggle ToggleErrors;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Toggle ToggleInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Toggle ToggleWarnings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject TopBar;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject TopHandle;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsVisible { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsVisible()
        {
            UnityEngine.GameObject val_1 = this.CachedGameObject;
            if(val_1 != null)
            {
                    return val_1.activeSelf;
            }
            
            return val_1.activeSelf;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_IsVisible(bool value)
        {
            this.CachedGameObject.SetActive(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            IntPtr val_4;
            this.Start();
            SRDebugger.Services.ConsoleUpdatedEventHandler val_2 = null;
            val_4 = System.Void SRDebugger.UI.Other.DockConsoleController::ConsoleOnUpdated(SRDebugger.Services.IConsoleService console);
            val_2 = new SRDebugger.Services.ConsoleUpdatedEventHandler(object:  this, method:  val_4);
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = 5;
            SRDebugger.Internal.Service.Console.add_Updated(value:  val_2);
            this.Refresh();
            this.RefreshAlpha();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnDestroy()
        {
            IntPtr val_5;
            this.OnDestroy();
            if(SRDebugger.Internal.Service.Console == null)
            {
                    return;
            }
            
            SRDebugger.Services.ConsoleUpdatedEventHandler val_3 = null;
            val_5 = System.Void SRDebugger.UI.Other.DockConsoleController::ConsoleOnUpdated(SRDebugger.Services.IConsoleService console);
            val_3 = new SRDebugger.Services.ConsoleUpdatedEventHandler(object:  this, method:  val_5);
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = 6;
            SRDebugger.Internal.Service.Console.remove_Updated(value:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnEnable()
        {
            this.OnEnable();
            this._pointersOver = 0;
            this._isDragging = false;
            this.RefreshAlpha();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnDisable()
        {
            this.OnDisable();
            this._pointersOver = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Update()
        {
            this.Update();
            if(this._isDirty == false)
            {
                    return;
            }
            
            this.Refresh();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ConsoleOnUpdated(SRDebugger.Services.IConsoleService console)
        {
            this._isDirty = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetDropdownVisibility(bool visible)
        {
            visible = visible;
            this.Dropdown.SetActive(value:  visible);
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  (visible != true) ? 0f : 180f);
            this.DropdownToggleSprite.rectTransform.localRotation = new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAlignmentMode(SRDebugger.ConsoleAlignment alignment)
        {
            var val_12;
            float val_13;
            float val_14;
            float val_15;
            if(alignment != 1)
            {
                    if(alignment != 0)
            {
                    return;
            }
            
                this.TopBar.transform.SetSiblingIndex(index:  0);
                this.Dropdown.transform.SetSiblingIndex(index:  2);
                this.TopHandle.SetActive(value:  false);
                this.BottomHandle.SetActive(value:  true);
                this.transform.SetSiblingIndex(index:  0);
                val_12 = this.DropdownToggleSprite.rectTransform.parent;
                val_13 = 0f;
                val_14 = 0f;
                val_15 = 0f;
            }
            else
            {
                    this.Dropdown.transform.SetSiblingIndex(index:  0);
                this.TopBar.transform.SetSiblingIndex(index:  2);
                this.TopHandle.SetActive(value:  true);
                this.BottomHandle.SetActive(value:  false);
                this.transform.SetSiblingIndex(index:  1);
                val_12 = this.DropdownToggleSprite.rectTransform.parent;
                val_15 = 180f;
                val_13 = 0f;
                val_14 = 0f;
            }
            
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.Euler(x:  val_13, y:  val_14, z:  val_15);
            val_12.localRotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Refresh()
        {
            var val_13 = 0;
            val_13 = val_13 + 1;
            string val_4 = SRDebugger.Internal.SRDebuggerUtil.GetNumberString(value:  SRDebugger.Internal.Service.Console.InfoCount, max:  231, exceedsMaxString:  "999+");
            var val_14 = 0;
            val_14 = val_14 + 1;
            string val_8 = SRDebugger.Internal.SRDebuggerUtil.GetNumberString(value:  SRDebugger.Internal.Service.Console.WarningCount, max:  231, exceedsMaxString:  "999+");
            var val_15 = 0;
            val_15 = val_15 + 1;
            string val_12 = SRDebugger.Internal.SRDebuggerUtil.GetNumberString(value:  SRDebugger.Internal.Service.Console.ErrorCount, max:  231, exceedsMaxString:  "999+");
            this._isDirty = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RefreshAlpha()
        {
            if(this._isDragging != true)
            {
                    if(this._pointersOver < 1)
            {
                goto label_1;
            }
            
            }
            
            label_4:
            this.CanvasGroup.alpha = 1f;
            return;
            label_1:
            if(this.CanvasGroup != null)
            {
                goto label_4;
            }
            
            goto label_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ToggleDropdownVisible()
        {
            this.SetDropdownVisibility(visible:  (~this.Dropdown.activeSelf) & 1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void MenuButtonPressed()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            SRDebug.Instance.ShowDebugPanel(tab:  2, requireEntryCode:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearButtonPressed()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            SRDebugger.Internal.Service.Console.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TogglesUpdated()
        {
            this.Console._showErrors = this.ToggleErrors.isOn;
            this.Console._isDirty = true;
            this.Console._showWarnings = this.ToggleWarnings.isOn;
            this.Console._isDirty = true;
            this.Console._showInfo = this.ToggleInfo.isOn;
            this.Console._isDirty = true;
            this.SetDropdownVisibility(visible:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData e)
        {
            this._pointersOver = 1;
            this.RefreshAlpha();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPointerExit(UnityEngine.EventSystems.PointerEventData e)
        {
            this._pointersOver = 0;
            this.RefreshAlpha();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnBeginDrag()
        {
            this._isDragging = true;
            this.RefreshAlpha();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEndDrag()
        {
            this._isDragging = false;
            this._pointersOver = 0;
            this.RefreshAlpha();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DockConsoleController()
        {
        
        }
    
    }

}
