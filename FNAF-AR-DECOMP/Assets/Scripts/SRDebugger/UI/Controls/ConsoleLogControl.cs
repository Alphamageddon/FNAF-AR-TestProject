using UnityEngine;

namespace SRDebugger.UI.Controls
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ConsoleLogControl : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRF.UI.Layout.VirtualVerticalLayoutGroup _consoleScrollLayoutGroup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.ScrollRect _consoleScrollRect;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isDirty;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<UnityEngine.Vector2> _scrollPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _showErrors;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _showInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _showWarnings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<SRDebugger.Services.ConsoleEntry> SelectedItemChanged;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _filter;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShowErrors { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShowWarnings { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShowInfo { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool EnableSelection { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Filter { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_ShowErrors()
        {
            return (bool)this._showErrors;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ShowErrors(bool value)
        {
            this._showErrors = value;
            this._isDirty = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_ShowWarnings()
        {
            return (bool)this._showWarnings;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ShowWarnings(bool value)
        {
            this._showWarnings = value;
            this._isDirty = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_ShowInfo()
        {
            return (bool)this._showInfo;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ShowInfo(bool value)
        {
            this._showInfo = value;
            this._isDirty = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_EnableSelection()
        {
            if(this._consoleScrollLayoutGroup != null)
            {
                    return (bool)this._consoleScrollLayoutGroup.EnableSelection;
            }
            
            return (bool)this._consoleScrollLayoutGroup.EnableSelection;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_EnableSelection(bool value)
        {
            this._consoleScrollLayoutGroup.EnableSelection = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Filter()
        {
            return (string)this._filter;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Filter(string value)
        {
            if((System.String.op_Inequality(a:  this._filter, b:  value)) == false)
            {
                    return;
            }
            
            this._filter = value;
            this._isDirty = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Awake()
        {
            IntPtr val_6;
            this.Awake();
            this._consoleScrollLayoutGroup.SelectedItemChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Object>(object:  this, method:  System.Void SRDebugger.UI.Controls.ConsoleLogControl::OnSelectedItemChanged(object arg0)));
            SRDebugger.Services.ConsoleUpdatedEventHandler val_4 = null;
            val_6 = System.Void SRDebugger.UI.Controls.ConsoleLogControl::ConsoleOnUpdated(SRDebugger.Services.IConsoleService console);
            val_4 = new SRDebugger.Services.ConsoleUpdatedEventHandler(object:  this, method:  val_6);
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = 5;
            SRDebugger.Internal.Service.Console.add_Updated(value:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            this.Start();
            this._isDirty = true;
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.ScrollToBottom());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator ScrollToBottom()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new ConsoleLogControl.<ScrollToBottom>d__26();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnDestroy()
        {
            IntPtr val_5;
            if(SRDebugger.Internal.Service.Console != null)
            {
                    SRDebugger.Services.ConsoleUpdatedEventHandler val_3 = null;
                val_5 = System.Void SRDebugger.UI.Controls.ConsoleLogControl::ConsoleOnUpdated(SRDebugger.Services.IConsoleService console);
                val_3 = new SRDebugger.Services.ConsoleUpdatedEventHandler(object:  this, method:  val_5);
                var val_5 = 0;
                val_5 = val_5 + 1;
                val_5 = 6;
                SRDebugger.Internal.Service.Console.remove_Updated(value:  val_3);
            }
            
            this.OnDestroy();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnSelectedItemChanged(object arg0)
        {
            var val_1 = 0;
            if(this.SelectedItemChanged == null)
            {
                    return;
            }
            
            this.SelectedItemChanged.Invoke(obj:  null);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Update()
        {
            this.Update();
            if((this._scrollPosition & 1) != 0)
            {
                    this._consoleScrollRect.normalizedPosition = new UnityEngine.Vector2() {x = V0.16B, y = V1.16B};
                mem2[0] = 0;
                mem2[0] = 0;
            }
            
            if(this._isDirty == false)
            {
                    return;
            }
            
            this.Refresh();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Refresh()
        {
            var val_12;
            SRF.UI.Layout.VirtualVerticalLayoutGroup val_14;
            UnityEngine.Vector2 val_1 = this._consoleScrollRect.normalizedPosition;
            if((SRF.SRFFloatExtensions.ApproxZero(f:  val_1.y)) != false)
            {
                    UnityEngine.Vector2 val_3 = this._consoleScrollRect.normalizedPosition;
                this._scrollPosition = 0;
                mem[1152921522959816692] = 0;
            }
            
            this._consoleScrollLayoutGroup.ClearItems();
            var val_14 = 0;
            val_14 = val_14 + 1;
            SRDebugger.IReadOnlyList<SRDebugger.Services.ConsoleEntry> val_6 = SRDebugger.Internal.Service.Console.Entries;
            val_12 = 0;
            goto label_10;
            label_37:
            var val_15 = 0;
            val_15 = val_15 + 1;
            T val_8 = val_6.Item[0];
            if((val_8 + 36) > 4)
            {
                goto label_21;
            }
            
            var val_16 = 52951564 + (val_8 + 36) << 2;
            val_16 = val_16 + 52951564;
            goto (52951564 + (val_8 + 36) << 2 + 52951564);
            label_21:
            if((System.String.IsNullOrEmpty(value:  this._filter)) != true)
            {
                    if(((val_8 + 40.IndexOf(value:  this._filter, comparisonType:  5)) & 2147483648) != 0)
            {
                goto label_26;
            }
            
            }
            
            val_14 = this._consoleScrollLayoutGroup;
            val_14.AddItem(item:  val_8);
            goto label_30;
            label_26:
            val_14 = this._consoleScrollLayoutGroup;
            if(val_8 == val_14.SelectedItem)
            {
                    this._consoleScrollLayoutGroup.SelectedItem = 0;
            }
            
            label_30:
            val_12 = 1;
            label_10:
            var val_17 = 0;
            val_17 = val_17 + 1;
            if(val_12 < val_6.Count)
            {
                goto label_37;
            }
            
            this._isDirty = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetIsDirty()
        {
            this._isDirty = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ConsoleOnUpdated(SRDebugger.Services.IConsoleService console)
        {
            this._isDirty = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ConsoleLogControl()
        {
            this._showErrors = true;
            this._showInfo = true;
            this._showWarnings = true;
        }
    
    }

}
