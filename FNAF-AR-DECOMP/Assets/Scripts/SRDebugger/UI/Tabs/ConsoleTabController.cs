using UnityEngine;

namespace SRDebugger.UI.Tabs
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ConsoleTabController : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int MaxLength = 2600;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Canvas _consoleCanvas;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isDirty;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.UI.Controls.ConsoleLogControl ConsoleLogControl;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Toggle PinToggle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.ScrollRect StackTraceScrollRect;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text StackTraceText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Toggle ToggleErrors;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text ToggleErrorsText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Toggle ToggleInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text ToggleInfoText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Toggle ToggleWarnings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text ToggleWarningsText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Toggle FilterToggle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.InputField FilterField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject FilterBarContainer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            IntPtr val_20;
            IntPtr val_22;
            this.Start();
            this._consoleCanvas = this.GetComponent<UnityEngine.Canvas>();
            this.ToggleErrors.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void SRDebugger.UI.Tabs.ConsoleTabController::<Start>b__16_0(bool isOn)));
            this.ToggleWarnings.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void SRDebugger.UI.Tabs.ConsoleTabController::<Start>b__16_1(bool isOn)));
            this.ToggleInfo.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void SRDebugger.UI.Tabs.ConsoleTabController::<Start>b__16_2(bool isOn)));
            this.PinToggle.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void SRDebugger.UI.Tabs.ConsoleTabController::PinToggleValueChanged(bool isOn)));
            this.FilterToggle.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void SRDebugger.UI.Tabs.ConsoleTabController::FilterToggleValueChanged(bool isOn)));
            this.FilterBarContainer.SetActive(value:  this.FilterToggle.isOn);
            this.FilterField.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void SRDebugger.UI.Tabs.ConsoleTabController::FilterValueChanged(string filterText)));
            this.ConsoleLogControl.SelectedItemChanged = new System.Action<SRDebugger.Services.ConsoleEntry>(object:  this, method:  System.Void SRDebugger.UI.Tabs.ConsoleTabController::ConsoleLogSelectedItemChanged(object item));
            SRDebugger.Services.ConsoleUpdatedEventHandler val_13 = null;
            val_20 = System.Void SRDebugger.UI.Tabs.ConsoleTabController::ConsoleOnUpdated(SRDebugger.Services.IConsoleService console);
            val_13 = new SRDebugger.Services.ConsoleUpdatedEventHandler(object:  this, method:  val_20);
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_20 = 5;
            SRDebugger.Internal.Service.Console.add_Updated(value:  val_13);
            System.Action<SRDebugger.Services.IDebugPanelService, System.Boolean> val_16 = null;
            val_22 = System.Void SRDebugger.UI.Tabs.ConsoleTabController::PanelOnVisibilityChanged(SRDebugger.Services.IDebugPanelService debugPanelService, bool b);
            val_16 = new System.Action<SRDebugger.Services.IDebugPanelService, System.Boolean>(object:  this, method:  val_22);
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_22 = 4;
            SRDebugger.Internal.Service.Panel.add_VisibilityChanged(value:  val_16);
            SRDebugger.Settings val_18 = SRDebugger.Settings.Instance;
            this.StackTraceText.supportRichText = (val_18._richTextInConsole == true) ? 1 : 0;
            this.PopulateStackTraceArea(entry:  0);
            this.Refresh();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FilterToggleValueChanged(bool isOn)
        {
            if(isOn != false)
            {
                    this.FilterBarContainer.SetActive(value:  true);
                string val_1 = this.FilterField.text;
                if((System.String.op_Inequality(a:  this.ConsoleLogControl._filter, b:  val_1)) == false)
            {
                    return;
            }
            
                this.ConsoleLogControl._filter = val_1;
                this.ConsoleLogControl._isDirty = true;
                return;
            }
            
            if((System.String.op_Inequality(a:  this.ConsoleLogControl._filter, b:  0)) != false)
            {
                    this.ConsoleLogControl._filter = 0;
                this.ConsoleLogControl._isDirty = true;
            }
            
            this.FilterBarContainer.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FilterValueChanged(string filterText)
        {
            string val_7 = filterText;
            if((this.FilterToggle.isOn != false) && ((System.String.IsNullOrEmpty(value:  val_7 = filterText)) != true))
            {
                    if(val_7.Trim().Length != 0)
            {
                    if((System.String.op_Inequality(a:  this.ConsoleLogControl._filter, b:  val_7)) == false)
            {
                    return;
            }
            
                this.ConsoleLogControl._filter = val_7;
                this.ConsoleLogControl._isDirty = true;
                return;
            }
            
            }
            
            val_7 = this.ConsoleLogControl;
            if((System.String.op_Inequality(a:  this.ConsoleLogControl._filter, b:  0)) == false)
            {
                    return;
            }
            
            this.ConsoleLogControl._filter = 0;
            this.ConsoleLogControl._isDirty = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PanelOnVisibilityChanged(SRDebugger.Services.IDebugPanelService debugPanelService, bool b)
        {
            var val_2;
            if(this._consoleCanvas == 0)
            {
                    return;
            }
            
            if(this._consoleCanvas == null)
            {
                goto label_4;
            }
            
            if(b == false)
            {
                goto label_5;
            }
            
            label_7:
            val_2 = 1;
            goto label_6;
            label_4:
            if(b == true)
            {
                goto label_7;
            }
            
            label_5:
            val_2 = 0;
            label_6:
            this._consoleCanvas.enabled = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PinToggleValueChanged(bool isOn)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            SRDebugger.Internal.Service.DockConsole.IsVisible = isOn;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnDestroy()
        {
            IntPtr val_5;
            if(SRDebugger.Internal.Service.Console != null)
            {
                    SRDebugger.Services.ConsoleUpdatedEventHandler val_3 = null;
                val_5 = System.Void SRDebugger.UI.Tabs.ConsoleTabController::ConsoleOnUpdated(SRDebugger.Services.IConsoleService console);
                val_3 = new SRDebugger.Services.ConsoleUpdatedEventHandler(object:  this, method:  val_5);
                var val_5 = 0;
                val_5 = val_5 + 1;
                val_5 = 6;
                SRDebugger.Internal.Service.Console.remove_Updated(value:  val_3);
            }
            
            this.OnDestroy();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnEnable()
        {
            this.OnEnable();
            this._isDirty = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ConsoleLogSelectedItemChanged(object item)
        {
            var val_1 = 0;
            this.PopulateStackTraceArea(entry:  null);
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
        private void PopulateStackTraceArea(SRDebugger.Services.ConsoleEntry entry)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_8 = entry;
            if(val_8 == null)
            {
                goto label_1;
            }
            
            if((System.String.IsNullOrEmpty(value:  entry.StackTrace)) != false)
            {
                    val_9 = null;
                val_9 = null;
                SRDebugger.Internal.SRDebugStrings.Current.Console_NoStackTrace
            }
            
            val_10 = entry.Message + System.Environment.NewLine + mem[SRDebugger.Internal.SRDebugStrings.Current.Console_NoStackTrace];
            if(val_10.Length >= 2601)
            {
                    val_11 = null;
                val_11 = null;
                val_10 = val_10.Substring(startIndex:  0, length:  40)(val_10.Substring(startIndex:  0, length:  40)) + "\n" + SRDebugger.Internal.SRDebugStrings.Current.Console_MessageTruncated;
            }
            
            if(this.StackTraceText != null)
            {
                goto label_13;
            }
            
            goto label_13;
            label_1:
            label_13:
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  0f, y:  1f);
            this.StackTraceScrollRect.normalizedPosition = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Refresh()
        {
            var val_23 = 0;
            val_23 = val_23 + 1;
            string val_4 = SRDebugger.Internal.SRDebuggerUtil.GetNumberString(value:  SRDebugger.Internal.Service.Console.InfoCount, max:  231, exceedsMaxString:  "999+");
            var val_24 = 0;
            val_24 = val_24 + 1;
            string val_8 = SRDebugger.Internal.SRDebuggerUtil.GetNumberString(value:  SRDebugger.Internal.Service.Console.WarningCount, max:  231, exceedsMaxString:  "999+");
            var val_25 = 0;
            val_25 = val_25 + 1;
            string val_12 = SRDebugger.Internal.SRDebuggerUtil.GetNumberString(value:  SRDebugger.Internal.Service.Console.ErrorCount, max:  231, exceedsMaxString:  "999+");
            this.ConsoleLogControl._showErrors = this.ToggleErrors.isOn;
            this.ConsoleLogControl._isDirty = true;
            this.ConsoleLogControl._showWarnings = this.ToggleWarnings.isOn;
            this.ConsoleLogControl._isDirty = true;
            this.ConsoleLogControl._showInfo = this.ToggleInfo.isOn;
            this.ConsoleLogControl._isDirty = true;
            var val_26 = 0;
            val_26 = val_26 + 1;
            this.PinToggle.isOn = SRDebugger.Internal.Service.DockConsole.IsVisible;
            this._isDirty = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ConsoleOnUpdated(SRDebugger.Services.IConsoleService console)
        {
            this._isDirty = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Clear()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            SRDebugger.Internal.Service.Console.Clear();
            this._isDirty = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ConsoleTabController()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <Start>b__16_0(bool isOn)
        {
            this._isDirty = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <Start>b__16_1(bool isOn)
        {
            this._isDirty = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <Start>b__16_2(bool isOn)
        {
            this._isDirty = true;
        }
    
    }

}
