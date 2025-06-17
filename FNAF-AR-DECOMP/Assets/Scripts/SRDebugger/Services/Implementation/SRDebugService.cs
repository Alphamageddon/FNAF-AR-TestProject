using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SRDebugService : IDebugService
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SRDebugger.Services.IDebugPanelService _debugPanelService;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SRDebugger.Services.IDebugTriggerService _debugTrigger;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SRDebugger.Services.ISystemInformationService _informationService;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SRDebugger.Services.IOptionsService _optionsService;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SRDebugger.Services.IPinnedUIService _pinnedUiService;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _entryCodeEnabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _hasAuthorised;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<SRDebugger.DefaultTabs> _queuedTab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.RectTransform _worldSpaceTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.VisibilityChangedDelegate PanelVisibilityChanged;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.Settings Settings { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsDebugPanelVisible { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsTriggerEnabled { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsProfilerDocked { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.Services.IDockConsoleService DockConsole { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugService()
        {
            IntPtr val_28;
            var val_30;
            var val_32;
            var val_35;
            SRF.Service.SRServiceManager.RegisterService<SRDebugger.Services.IDebugService>(service:  this);
            SRDebugger.Services.IProfilerService val_1 = SRF.Service.SRServiceManager.GetService<SRDebugger.Services.IProfilerService>();
            this._debugTrigger = SRF.Service.SRServiceManager.GetService<SRDebugger.Services.IDebugTriggerService>();
            this._informationService = SRF.Service.SRServiceManager.GetService<SRDebugger.Services.ISystemInformationService>();
            this._pinnedUiService = SRF.Service.SRServiceManager.GetService<SRDebugger.Services.IPinnedUIService>();
            this._optionsService = SRF.Service.SRServiceManager.GetService<SRDebugger.Services.IOptionsService>();
            SRDebugger.Services.IDebugPanelService val_6 = SRF.Service.SRServiceManager.GetService<SRDebugger.Services.IDebugPanelService>();
            this._debugPanelService = val_6;
            System.Action<SRDebugger.Services.IDebugPanelService, System.Boolean> val_7 = null;
            val_28 = System.Void SRDebugger.Services.Implementation.SRDebugService::DebugPanelServiceOnVisibilityChanged(SRDebugger.Services.IDebugPanelService debugPanelService, bool b);
            val_7 = new System.Action<SRDebugger.Services.IDebugPanelService, System.Boolean>(object:  this, method:  val_28);
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_28 = 4;
            val_30 = public System.Void SRDebugger.Services.IDebugPanelService::add_VisibilityChanged(System.Action<SRDebugger.Services.IDebugPanelService, bool> value);
            val_6.add_VisibilityChanged(value:  val_7);
            SRDebugger.Settings val_9 = SRDebugger.Settings.Instance;
            if(val_9._triggerEnableMode == 0)
            {
                goto label_9;
            }
            
            SRDebugger.Settings val_10 = SRDebugger.Settings.Instance;
            if((val_10._triggerEnableMode != 1) || (UnityEngine.Application.isMobilePlatform == false))
            {
                goto label_12;
            }
            
            label_9:
            if(this._debugTrigger != null)
            {
                goto label_44;
            }
            
            label_45:
            label_44:
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_30 = 1;
            goto label_17;
            label_12:
            SRDebugger.Settings val_12 = SRDebugger.Settings.Instance;
            if(val_12._triggerEnableMode != 3)
            {
                goto label_19;
            }
            
            bool val_14 = UnityEngine.Debug.isDebugBuild;
            if(this._debugTrigger != null)
            {
                goto label_44;
            }
            
            goto label_45;
            label_17:
            val_32 = public System.Void SRDebugger.Services.IDebugTriggerService::set_IsEnabled(bool value);
            this._debugTrigger.IsEnabled = true;
            SRDebugger.Settings val_16 = SRDebugger.Settings.Instance;
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_32 = 3;
            this._debugTrigger.Position = val_16._triggerPosition;
            SRDebugger.Settings val_18 = SRDebugger.Settings.Instance;
            if(val_18._enableKeyboardShortcuts != false)
            {
                    SRDebugger.Services.Implementation.KeyboardShortcutListenerService val_19 = SRF.Service.SRServiceManager.GetService<SRDebugger.Services.Implementation.KeyboardShortcutListenerService>();
            }
            
            SRDebugger.Settings val_20 = SRDebugger.Settings.Instance;
            if(val_20._requireEntryCode == false)
            {
                goto label_35;
            }
            
            var val_32 = 0;
            val_32 = val_32 + 1;
            goto label_41;
            label_35:
            val_35 = 0;
            if(this != null)
            {
                goto label_46;
            }
            
            goto label_43;
            label_19:
            if(this._debugTrigger != null)
            {
                goto label_44;
            }
            
            goto label_45;
            label_41:
            if(this != null)
            {
                goto label_46;
            }
            
            label_43:
            label_46:
            this._entryCodeEnabled = (SRDebugger.Settings.Instance.EntryCode.Count == 4) ? 1 : 0;
            SRDebugger.Settings val_26 = SRDebugger.Settings.Instance;
            if((val_26._requireEntryCode != false) && (this._entryCodeEnabled != true))
            {
                    UnityEngine.Debug.LogError(message:  "[SRDebugger] RequireCode is enabled, but pin is not 4 digits");
            }
            
            UnityEngine.Object.DontDestroyOnLoad(target:  SRF.Hierarchy.Get(key:  "SRDebugger").gameObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.Settings get_Settings()
        {
            return SRDebugger.Settings.Instance;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsDebugPanelVisible()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this._debugPanelService.IsVisible;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsTriggerEnabled()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this._debugTrigger.IsEnabled;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_IsTriggerEnabled(bool value)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._debugTrigger.IsEnabled = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsProfilerDocked()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return SRDebugger.Internal.Service.PinnedUI.IsProfilerPinned;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_IsProfilerDocked(bool value)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            SRDebugger.Internal.Service.PinnedUI.IsProfilerPinned = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddSystemInfo(SRDebugger.InfoEntry entry, string category = "Default")
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._informationService.Add(info:  entry, category:  category);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowDebugPanel(bool requireEntryCode = True)
        {
            if((requireEntryCode != false) && (this._entryCodeEnabled != false))
            {
                    if(this._hasAuthorised == false)
            {
                goto label_3;
            }
            
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this = ???;
            this._debugPanelService.IsVisible = true;
            return;
            label_3:
            this.PromptEntryCode();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowDebugPanel(SRDebugger.DefaultTabs tab, bool requireEntryCode = True)
        {
            var val_10;
            SRDebugger.DefaultTabs val_11;
            var val_12;
            var val_14;
            val_10 = requireEntryCode;
            val_11 = tab;
            val_12 = this;
            if((val_10 != false) && (this._entryCodeEnabled != false))
            {
                    if(this._hasAuthorised == false)
            {
                goto label_3;
            }
            
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_14 = public System.Void SRDebugger.Services.IDebugPanelService::set_IsVisible(bool value);
            this._debugPanelService.IsVisible = true;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_14 = 7;
            val_12 = ???;
            val_11 = ???;
            val_10 = ???;
            this._debugPanelService.OpenTab(tab:  val_11);
            return;
            label_3:
            this._queuedTab = 0;
            this.PromptEntryCode();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HideDebugPanel()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._debugPanelService.IsVisible = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DestroyDebugPanel()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._debugPanelService.IsVisible = false;
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._debugPanelService.Unload();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddOptionContainer(object container)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._optionsService.AddContainer(obj:  container);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveOptionContainer(object container)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._optionsService.RemoveContainer(obj:  container);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PinAllOptions(string category)
        {
            var val_21;
            var val_22;
            var val_26;
            var val_27;
            var val_23 = 0;
            val_23 = val_23 + 1;
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_21 = 1152921504689487872;
            val_22 = this._optionsService.Options.GetEnumerator();
            label_29:
            var val_25 = 0;
            val_25 = val_25 + 1;
            if(val_22.MoveNext() == false)
            {
                goto label_16;
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            T val_8 = val_22.Current;
            if((System.String.op_Equality(a:  val_8.Category, b:  category)) == false)
            {
                goto label_29;
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            this._pinnedUiService.Pin(option:  val_8, order:  0);
            goto label_29;
            label_16:
            val_26 = 0;
            val_27 = 73;
            if(val_22 == null)
            {
                
            }
            else
            {
                    var val_28 = 0;
                val_28 = val_28 + 1;
                val_22.Dispose();
            }
            
            if( == 73)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_26 = ???;
            val_22 = ???;
            val_21 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UnpinAllOptions(string category)
        {
            var val_21;
            var val_22;
            var val_25;
            var val_27;
            var val_28;
            var val_23 = 0;
            val_23 = val_23 + 1;
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_21 = 1152921504689487872;
            val_22 = this._optionsService.Options.GetEnumerator();
            label_29:
            var val_25 = 0;
            val_25 = val_25 + 1;
            if(val_22.MoveNext() == false)
            {
                goto label_16;
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            T val_8 = val_22.Current;
            val_25 = 0;
            if((System.String.op_Equality(a:  val_8.Category, b:  category)) == false)
            {
                goto label_29;
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_25 = 5;
            this._pinnedUiService.Unpin(option:  val_8);
            goto label_29;
            label_16:
            val_27 = 0;
            val_28 = 72;
            if(val_22 == null)
            {
                
            }
            else
            {
                    var val_28 = 0;
                val_28 = val_28 + 1;
                val_22.Dispose();
            }
            
            if( == 72)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_27 = ???;
            val_22 = ???;
            val_21 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PinOption(string name)
        {
            var val_21;
            var val_22;
            var val_26;
            var val_27;
            var val_23 = 0;
            val_23 = val_23 + 1;
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_21 = 1152921504689487872;
            val_22 = this._optionsService.Options.GetEnumerator();
            label_29:
            var val_25 = 0;
            val_25 = val_25 + 1;
            if(val_22.MoveNext() == false)
            {
                goto label_16;
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            T val_8 = val_22.Current;
            if((System.String.op_Equality(a:  val_8.Name, b:  name)) == false)
            {
                goto label_29;
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            this._pinnedUiService.Pin(option:  val_8, order:  0);
            goto label_29;
            label_16:
            val_26 = 0;
            val_27 = 73;
            if(val_22 == null)
            {
                
            }
            else
            {
                    var val_28 = 0;
                val_28 = val_28 + 1;
                val_22.Dispose();
            }
            
            if( == 73)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_26 = ???;
            val_22 = ???;
            val_21 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UnpinOption(string name)
        {
            var val_21;
            var val_22;
            var val_25;
            var val_27;
            var val_28;
            var val_23 = 0;
            val_23 = val_23 + 1;
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_21 = 1152921504689487872;
            val_22 = this._optionsService.Options.GetEnumerator();
            label_29:
            var val_25 = 0;
            val_25 = val_25 + 1;
            if(val_22.MoveNext() == false)
            {
                goto label_16;
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            T val_8 = val_22.Current;
            val_25 = 0;
            if((System.String.op_Equality(a:  val_8.Name, b:  name)) == false)
            {
                goto label_29;
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_25 = 5;
            this._pinnedUiService.Unpin(option:  val_8);
            goto label_29;
            label_16:
            val_27 = 0;
            val_28 = 72;
            if(val_22 == null)
            {
                
            }
            else
            {
                    var val_28 = 0;
                val_28 = val_28 + 1;
                val_22.Dispose();
            }
            
            if( == 72)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_27 = ???;
            val_22 = ???;
            val_21 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearPinnedOptions()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._pinnedUiService.UnpinAll();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowBugReportSheet(SRDebugger.ActionCompleteCallback onComplete, bool takeScreenshot = True, string descriptionContent)
        {
            .onComplete = onComplete;
            SRDebugger.Services.Implementation.BugReportPopoverService val_2 = SRF.Service.SRServiceManager.GetService<SRDebugger.Services.Implementation.BugReportPopoverService>();
            if(val_2.IsShowingPopover != false)
            {
                    return;
            }
            
            val_2.ShowBugReporter(callback:  new SRDebugger.Services.BugReportCompleteCallback(object:  new SRDebugService.<>c__DisplayClass32_0(), method:  System.Void SRDebugService.<>c__DisplayClass32_0::<ShowBugReportSheet>b__0(bool succeed, string message)), takeScreenshotFirst:  takeScreenshot, descriptionText:  descriptionContent);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.Services.IDockConsoleService get_DockConsole()
        {
            return SRDebugger.Internal.Service.DockConsole;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_PanelVisibilityChanged(SRDebugger.VisibilityChangedDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.PanelVisibilityChanged, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PanelVisibilityChanged != 1152921522999564672);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_PanelVisibilityChanged(SRDebugger.VisibilityChangedDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.PanelVisibilityChanged, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PanelVisibilityChanged != 1152921522999701248);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DebugPanelServiceOnVisibilityChanged(SRDebugger.Services.IDebugPanelService debugPanelService, bool b)
        {
            if(this.PanelVisibilityChanged == null)
            {
                    return;
            }
            
            this.PanelVisibilityChanged.Invoke(isVisible:  b);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PromptEntryCode()
        {
            var val_5 = null;
            mem[1152921523000016608] = this;
            mem[1152921523000016616] = System.Void SRDebugger.Services.Implementation.SRDebugService::<PromptEntryCode>b__39_0(bool entered);
            mem[1152921523000016592] = System.Void SRDebugger.Services.Implementation.SRDebugService::<PromptEntryCode>b__39_0(bool entered);
            var val_5 = 0;
            val_5 = val_5 + 1;
            SRF.Service.SRServiceManager.GetService<SRDebugger.Services.IPinEntryService>().ShowPinEntry(requiredPin:  SRDebugger.Settings.Instance.EntryCode, message:  SRDebugger.Internal.SRDebugStrings.Current.PinEntryPrompt, callback:  new SRDebugger.Services.PinEntryCompleteCallback(), allowCancel:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform EnableWorldSpaceMode()
        {
            var val_5;
            var val_14;
            UnityEngine.RectTransform val_15;
            SRDebugger.Services.IDebugPanelService val_17;
            var val_18;
            val_14 = 0;
            if(this._worldSpaceTransform != 0)
            {
                    val_15 = this._worldSpaceTransform;
                return val_15;
            }
            
            SRDebugger.Settings val_2 = SRDebugger.Settings.Instance;
            if(val_2._useDebugCamera != true)
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_14 = 2;
                this._debugPanelService.IsVisible = true;
                val_17 = this._debugPanelService;
                if(val_17 != null)
            {
                    val_17 = 0;
            }
            
                SRDebugger.UI.DebugPanelRoot val_7 = val_17.RootObject;
                SRF.SRFGameObjectExtensions.RemoveComponentIfExists<SRF.UI.SRRetinaScaler>(obj:  val_7.Canvas.gameObject);
                SRF.SRFGameObjectExtensions.RemoveComponentIfExists<UnityEngine.UI.CanvasScaler>(obj:  val_7.Canvas.gameObject);
                val_7.Canvas.renderMode = 2;
                val_15 = val_7.Canvas.GetComponent<UnityEngine.RectTransform>();
                val_5 = 0;
                UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  1024f, y:  768f);
                val_15.sizeDelta = new UnityEngine.Vector2() {x = val_11.x, y = val_11.y};
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
                val_15.position = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
                this._worldSpaceTransform = val_15;
                return val_15;
            }
            
            val_18 = new System.InvalidOperationException(message:  "UseDebugCamera cannot be enabled at the same time as EnableWorldSpaceMode.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <PromptEntryCode>b__39_0(bool entered)
        {
            System.Nullable<SRDebugger.DefaultTabs> val_2;
            if(entered == false)
            {
                goto label_1;
            }
            
            SRDebugger.Settings val_1 = SRDebugger.Settings.Instance;
            if(val_1._requireEntryCodeEveryTime != true)
            {
                    this._hasAuthorised = true;
            }
            
            val_2 = this._queuedTab;
            if((val_2 & 1) == 0)
            {
                goto label_4;
            }
            
            this._queuedTab = 0;
            this.ShowDebugPanel(tab:  val_2, requireEntryCode:  false);
            goto label_7;
            label_1:
            val_2 = this._queuedTab;
            goto label_7;
            label_4:
            this.ShowDebugPanel(requireEntryCode:  false);
            label_7:
            mem2[0] = 0;
        }
    
    }

}
