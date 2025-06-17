using UnityEngine;

namespace SRDebugger.UI.Tabs
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class OptionsTabController : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<SRDebugger.UI.Controls.OptionsControlBase> _controls;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<SRDebugger.UI.Tabs.OptionsTabController.CategoryInstance> _categories;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<SRDebugger.Internal.OptionDefinition, SRDebugger.UI.Controls.OptionsControlBase> _options;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _queueRefresh;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _selectionModeEnabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Canvas _optionCanvas;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.UI.Controls.Data.ActionControl ActionControlPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.UI.Other.CategoryGroup CategoryGroupPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform ContentContainer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject NoOptionsNotice;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Toggle PinButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject PinPromptSpacer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject PinPromptText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isTogglingCategory;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            IntPtr val_12;
            IntPtr val_14;
            IntPtr val_16;
            this.Start();
            this.PinButton.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  public System.Void SRDebugger.UI.Tabs.OptionsTabController::SetSelectionModeEnabled(bool isEnabled)));
            this.PinPromptText.SetActive(value:  false);
            this.Populate();
            this._optionCanvas = this.GetComponent<UnityEngine.Canvas>();
            System.EventHandler val_4 = null;
            val_12 = System.Void SRDebugger.UI.Tabs.OptionsTabController::OnOptionsUpdated(object sender, System.EventArgs eventArgs);
            val_4 = new System.EventHandler(object:  this, method:  val_12);
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_12 = 0;
            SRDebugger.Internal.Service.Options.add_OptionsUpdated(value:  val_4);
            System.EventHandler<System.ComponentModel.PropertyChangedEventArgs> val_7 = null;
            val_14 = System.Void SRDebugger.UI.Tabs.OptionsTabController::OnOptionsValueChanged(object sender, System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs);
            val_7 = new System.EventHandler<System.ComponentModel.PropertyChangedEventArgs>(object:  this, method:  val_14);
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_14 = 2;
            SRDebugger.Internal.Service.Options.add_OptionsValueUpdated(value:  val_7);
            System.Action<SRDebugger.Internal.OptionDefinition, System.Boolean> val_10 = null;
            val_16 = System.Void SRDebugger.UI.Tabs.OptionsTabController::OnOptionPinnedStateChanged(SRDebugger.Internal.OptionDefinition optionDefinition, bool isPinned);
            val_10 = new System.Action<SRDebugger.Internal.OptionDefinition, System.Boolean>(object:  this, method:  val_16);
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_16 = 0;
            SRDebugger.Internal.Service.PinnedUI.add_OptionPinStateChanged(value:  val_10);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnOptionPinnedStateChanged(SRDebugger.Internal.OptionDefinition optionDefinition, bool isPinned)
        {
            if((this._options.ContainsKey(key:  optionDefinition)) == false)
            {
                    return;
            }
            
            this._options.Item[optionDefinition].IsSelected = isPinned;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnOptionsUpdated(object sender, System.EventArgs eventArgs)
        {
            this.Clear();
            this.Populate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnOptionsValueChanged(object sender, System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs)
        {
            this._queueRefresh = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnEnable()
        {
            IntPtr val_4;
            this.OnEnable();
            System.Action<SRDebugger.Services.IDebugPanelService, System.Boolean> val_2 = null;
            val_4 = System.Void SRDebugger.UI.Tabs.OptionsTabController::PanelOnVisibilityChanged(SRDebugger.Services.IDebugPanelService debugPanelService, bool b);
            val_2 = new System.Action<SRDebugger.Services.IDebugPanelService, System.Boolean>(object:  this, method:  val_4);
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = 4;
            SRDebugger.Internal.Service.Panel.add_VisibilityChanged(value:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnDisable()
        {
            IntPtr val_5;
            this.SetSelectionModeEnabled(isEnabled:  false);
            if(SRDebugger.Internal.Service.Panel != null)
            {
                    System.Action<SRDebugger.Services.IDebugPanelService, System.Boolean> val_3 = null;
                val_5 = System.Void SRDebugger.UI.Tabs.OptionsTabController::PanelOnVisibilityChanged(SRDebugger.Services.IDebugPanelService debugPanelService, bool b);
                val_3 = new System.Action<SRDebugger.Services.IDebugPanelService, System.Boolean>(object:  this, method:  val_5);
                var val_5 = 0;
                val_5 = val_5 + 1;
                val_5 = 5;
                SRDebugger.Internal.Service.Panel.remove_VisibilityChanged(value:  val_3);
            }
            
            this.OnDisable();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Update()
        {
            this.Update();
            if(this._queueRefresh == false)
            {
                    return;
            }
            
            this._queueRefresh = false;
            this.Refresh();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PanelOnVisibilityChanged(SRDebugger.Services.IDebugPanelService debugPanelService, bool b)
        {
            if(b == false)
            {
                goto label_1;
            }
            
            if(this.CachedGameObject.activeInHierarchy == true)
            {
                goto label_3;
            }
            
            goto label_4;
            label_1:
            this.SetSelectionModeEnabled(isEnabled:  false);
            label_3:
            this.Refresh();
            label_4:
            if(this._optionCanvas == 0)
            {
                    return;
            }
            
            this._optionCanvas.enabled = b;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetSelectionModeEnabled(bool isEnabled)
        {
            var val_6;
            System.Collections.Generic.List<CategoryInstance> val_22;
            var val_23;
            var val_1 = (this._selectionModeEnabled == true) ? 1 : 0;
            val_1 = val_1 ^ isEnabled;
            if(val_1 == false)
            {
                    return;
            }
            
            bool val_2 = isEnabled;
            this._selectionModeEnabled = val_2;
            this.PinButton.isOn = val_2;
            val_23 = 0;
            this.PinPromptText.SetActive(value:  isEnabled);
            Dictionary.Enumerator<TKey, TValue> val_4 = this._options.GetEnumerator();
            label_14:
            if((1153903200 & 1) == 0)
            {
                goto label_5;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_8 = val_6.trackableId;
            val_8.m_SubId1.SelectionModeEnabled = isEnabled;
            if(isEnabled == false)
            {
                goto label_14;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_23 = 7;
            ulong val_22 = val_8.m_SubId1.System.IConvertible.ToUInt64(provider:  public SRDebugger.Internal.OptionDefinition System.Collections.Generic.KeyValuePair<SRDebugger.Internal.OptionDefinition, SRDebugger.UI.Controls.OptionsControlBase>::get_Key());
            val_22 = SRDebugger.Internal.Service.PinnedUI.HasPinned(option:  val_22);
            val_8.m_SubId1.IsSelected = val_22;
            goto label_14;
            label_5:
            long val_14 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921522940619360});
            val_22 = this._categories;
            List.Enumerator<T> val_16 = val_22.GetEnumerator();
            label_28:
            if((1153903160 & 1) == 0)
            {
                goto label_25;
            }
            
            GameUI.EmailUIDataHandler val_17 = 0.emailUIDataHandler;
            val_17._masterDomain.SelectionModeEnabled = isEnabled;
            goto label_28;
            label_25:
            long val_19 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921522940619320});
            this.RefreshCategorySelection();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Refresh()
        {
            var val_8;
            var val_9;
            val_8 = 0;
            goto label_1;
            label_14:
            SRDebugger.UI.Controls.OptionsControlBase val_1 = this._controls.Item[0];
            val_9 = public SRDebugger.UI.Controls.OptionsControlBase System.Collections.Generic.List<SRDebugger.UI.Controls.OptionsControlBase>::get_Item(int index);
            SRDebugger.UI.Controls.OptionsControlBase val_4 = this._controls.Item[0];
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_9 = 7;
            SRDebugger.Internal.OptionDefinition val_9 = val_4.Option;
            val_9 = SRDebugger.Internal.Service.PinnedUI.HasPinned(option:  val_9);
            this._controls.Item[0].IsSelected = val_9;
            val_8 = 1;
            label_1:
            if(val_8 < this._options.Count)
            {
                goto label_14;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CommitPinnedOptions()
        {
            var val_4;
            System.Collections.Generic.Dictionary<SRDebugger.Internal.OptionDefinition, SRDebugger.UI.Controls.OptionsControlBase> val_22;
            var val_24;
            var val_27;
            val_22 = this._options;
            Dictionary.Enumerator<TKey, TValue> val_1 = val_22.GetEnumerator();
            label_30:
            if((1154260448 & 1) == 0)
            {
                    return;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_5 = val_4.trackableId;
            if(val_5.m_SubId1.IsSelected == false)
            {
                goto label_4;
            }
            
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_24 = public System.Boolean SRDebugger.Services.IPinnedUIService::HasPinned(SRDebugger.Internal.OptionDefinition option);
            if((SRDebugger.Internal.Service.PinnedUI.HasPinned(option:  val_5.m_SubId1.System.IConvertible.ToUInt64(provider:  public SRDebugger.Internal.OptionDefinition System.Collections.Generic.KeyValuePair<SRDebugger.Internal.OptionDefinition, SRDebugger.UI.Controls.OptionsControlBase>::get_Key()))) == false)
            {
                goto label_10;
            }
            
            label_4:
            if(val_5.m_SubId1.IsSelected == true)
            {
                goto label_30;
            }
            
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_24 = 7;
            goto label_17;
            label_10:
            var val_26 = 0;
            val_26 = val_26 + 1;
            goto label_22;
            label_17:
            val_27 = public System.Boolean SRDebugger.Services.IPinnedUIService::HasPinned(SRDebugger.Internal.OptionDefinition option);
            if((SRDebugger.Internal.Service.PinnedUI.HasPinned(option:  val_5.m_SubId1.System.IConvertible.ToUInt64(provider:  public SRDebugger.Internal.OptionDefinition System.Collections.Generic.KeyValuePair<SRDebugger.Internal.OptionDefinition, SRDebugger.UI.Controls.OptionsControlBase>::get_Key()))) == false)
            {
                goto label_30;
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_27 = 5;
            goto label_28;
            label_22:
            SRDebugger.Internal.Service.PinnedUI.Pin(option:  val_5.m_SubId1.System.IConvertible.ToUInt64(provider:  public SRDebugger.Internal.OptionDefinition System.Collections.Generic.KeyValuePair<SRDebugger.Internal.OptionDefinition, SRDebugger.UI.Controls.OptionsControlBase>::get_Key()), order:  0);
            goto label_30;
            label_28:
            SRDebugger.Internal.Service.PinnedUI.Unpin(option:  val_5.m_SubId1.System.IConvertible.ToUInt64(provider:  public SRDebugger.Internal.OptionDefinition System.Collections.Generic.KeyValuePair<SRDebugger.Internal.OptionDefinition, SRDebugger.UI.Controls.OptionsControlBase>::get_Key()));
            goto label_30;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RefreshCategorySelection()
        {
            var val_3;
            var val_10;
            this._isTogglingCategory = true;
            List.Enumerator<T> val_1 = this._categories.GetEnumerator();
            label_11:
            if((1154426800 & 1) == 0)
            {
                goto label_2;
            }
            
            GameUI.EmailUIDataHandler val_4 = val_3.emailUIDataHandler;
            var val_10 = 0;
            label_8:
            if(val_10 >= val_4._serverGameUIDataModel.Count)
            {
                goto label_5;
            }
            
            val_10 = val_10 + 1;
            if(val_4._serverGameUIDataModel.Item[0].IsSelected == true)
            {
                goto label_8;
            }
            
            val_10 = 0;
            goto label_9;
            label_5:
            val_10 = 1;
            label_9:
            val_4._masterDomain.IsSelected = true;
            goto label_11;
            label_2:
            long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921522941142960});
            this._isTogglingCategory = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnOptionSelectionToggle(bool selected)
        {
            if(this._isTogglingCategory != false)
            {
                    return;
            }
            
            this.RefreshCategorySelection();
            this.CommitPinnedOptions();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnCategorySelectionToggle(SRDebugger.UI.Tabs.OptionsTabController.CategoryInstance category, bool selected)
        {
            this._isTogglingCategory = true;
            goto label_1;
            label_6:
            category.Options.Item[0].IsSelected = selected;
            0 = 1;
            label_1:
            if(0 < category.Options.Count)
            {
                goto label_6;
            }
            
            this._isTogglingCategory = false;
            this.CommitPinnedOptions();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void Populate()
        {
            var val_22;
            var val_23;
            var val_25;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<SRDebugger.Internal.OptionDefinition>> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<SRDebugger.Internal.OptionDefinition>>();
            var val_22 = 0;
            val_22 = val_22 + 1;
            var val_23 = 0;
            val_23 = val_23 + 1;
            System.Collections.Generic.IEnumerator<T> val_6 = SRDebugger.Internal.Service.Options.Options.GetEnumerator();
            label_28:
            var val_24 = 0;
            val_24 = val_24 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_16;
            }
            
            var val_25 = 0;
            val_25 = val_25 + 1;
            T val_10 = val_6.Current;
            if((val_1.TryGetValue(key:  val_10.Category, value: out  0)) != true)
            {
                    System.Collections.Generic.List<SRDebugger.Internal.OptionDefinition> val_14 = new System.Collections.Generic.List<SRDebugger.Internal.OptionDefinition>();
                val_1.Add(key:  val_10.Category, value:  null);
            }
            
            null.Add(item:  val_10);
            goto label_28;
            label_16:
            val_22 = 0;
            val_23 = 96;
            if(val_6 == null)
            {
                
            }
            else
            {
                    var val_26 = 0;
                val_26 = val_26 + 1;
                val_6.Dispose();
            }
            
            if( != 96)
            {
                goto label_45;
            }
            
            if(val_1 != null)
            {
                goto label_49;
            }
            
            goto label_47;
            label_45:
            if( != false)
            {
                    val_22 = 0;
            }
            
            if(val_1 != null)
            {
                goto label_49;
            }
            
            label_47:
            label_49:
            Dictionary.Enumerator<TKey, TValue> val_17 = val_1.GetEnumerator();
            val_25 = 0;
            do
            {
                label_53:
                if((1154857056 & 1) == 0)
            {
                goto label_54;
            }
            
                UnityEngine.XR.ARSubsystems.TrackableId val_18 = 0.trackableId;
            }
            while(val_18.m_SubId1.Count == 0);
            
            this.CreateCategory(title:  val_18.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.List<SRDebugger.Internal.OptionDefinition>>::get_Key()), options:  val_18.m_SubId1);
            goto label_53;
            label_54:
            long val_21 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921522941573216});
            if(( & 1) == 0)
            {
                    return;
            }
            
            val_25 = mem[1152921522941585496];
            val_25.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void CreateCategory(string title, System.Collections.Generic.List<SRDebugger.Internal.OptionDefinition> options)
        {
            var val_8;
            string val_23;
            var val_24;
            var val_26;
            val_23 = title;
            .<>4__this = this;
            val_24 = null;
            val_24 = null;
            if((OptionsTabController.<>c.<>9__30_0) == null)
            {
                goto label_4;
            }
            
            label_50:
            options.Sort(comparison:  OptionsTabController.<>c.<>9__30_0);
            SRDebugger.UI.Other.CategoryGroup val_2 = SRInstantiate.Instantiate<SRDebugger.UI.Other.CategoryGroup>(prefab:  this.CategoryGroupPrefab);
            OptionsTabController.CategoryInstance val_3 = new OptionsTabController.CategoryInstance(group:  val_2);
            .categoryInstance = val_3;
            this._categories.Add(item:  val_3);
            val_2.CachedTransform.SetParent(parent:  this.ContentContainer, worldPositionStays:  false);
            val_2.SelectionModeEnabled = false;
            (OptionsTabController.<>c__DisplayClass30_0)[1152921522941915024].categoryInstance.<CategoryGroup>k__BackingField.SelectionToggle.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  new OptionsTabController.<>c__DisplayClass30_0(), method:  System.Void OptionsTabController.<>c__DisplayClass30_0::<CreateCategory>b__1(bool b)));
            List.Enumerator<T> val_6 = options.GetEnumerator();
            label_46:
            if((1155146544 & 1) == 0)
            {
                    return;
            }
            
            GameUI.EmailUIDataHandler val_9 = val_8.emailUIDataHandler;
            SRDebugger.UI.Controls.OptionsControlBase val_10 = SRDebugger.Internal.OptionControlFactory.CreateControl(from:  val_9, categoryPrefix:  val_23);
            if(val_10 != 0)
            {
                goto label_19;
            }
            
            object[] val_12 = new object[1];
            val_12[0] = val_9.Name;
            UnityEngine.Debug.LogError(message:  SRF.SRFStringExtensions.Fmt(formatString:  "[SRDebugger.OptionsTab] Failed to create option control for {0}", args:  val_12));
            goto label_46;
            label_19:
            (OptionsTabController.<>c__DisplayClass30_0)[1152921522941915024].categoryInstance.Options.Add(item:  val_10);
            val_26 = 0;
            val_10.CachedTransform.SetParent(parent:  val_2.Container, worldPositionStays:  false);
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_26 = 7;
            SRDebugger.Internal.OptionDefinition val_24 = val_9;
            val_24 = SRDebugger.Internal.Service.PinnedUI.HasPinned(option:  val_24);
            val_10.IsSelected = val_24;
            val_10.SelectionModeEnabled = false;
            UnityEngine.Events.UnityAction<System.Boolean> val_19 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void SRDebugger.UI.Tabs.OptionsTabController::OnOptionSelectionToggle(bool selected));
            val_10.SelectionModeToggle.onValueChanged.AddListener(call:  null);
            this._options.Add(key:  val_9, value:  val_10);
            this._controls.Add(item:  val_10);
            goto label_46;
            label_4:
            OptionsTabController.<>c.<>9__30_0 = new System.Comparison<SRDebugger.Internal.OptionDefinition>(object:  OptionsTabController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 OptionsTabController.<>c::<CreateCategory>b__30_0(SRDebugger.Internal.OptionDefinition d1, SRDebugger.Internal.OptionDefinition d2));
            if(options != null)
            {
                goto label_50;
            }
            
            goto label_50;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Clear()
        {
            List.Enumerator<T> val_1 = this._categories.GetEnumerator();
            label_7:
            if((1155425528 & 1) == 0)
            {
                goto label_2;
            }
            
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            UnityEngine.Object.Destroy(obj:  val_2._masterDomain.gameObject);
            goto label_7;
            label_2:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921522942141688});
            this._categories.Clear();
            this._controls.Clear();
            this._options.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public OptionsTabController()
        {
            this._controls = new System.Collections.Generic.List<SRDebugger.UI.Controls.OptionsControlBase>();
            this._categories = new System.Collections.Generic.List<CategoryInstance>();
            this._options = new System.Collections.Generic.Dictionary<SRDebugger.Internal.OptionDefinition, SRDebugger.UI.Controls.OptionsControlBase>();
        }
    
    }

}
