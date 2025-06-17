using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PinnedUIServiceImpl : SRServiceBase<SRDebugger.Services.IPinnedUIService>, IPinnedUIService
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<SRDebugger.UI.Controls.OptionsControlBase> _controlList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<SRDebugger.Internal.OptionDefinition, SRDebugger.UI.Controls.OptionsControlBase> _pinnedObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _queueRefresh;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.UI.Other.PinnedUIRoot _uiRoot;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<SRDebugger.Internal.OptionDefinition, bool> OptionPinStateChanged;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.UI.Other.DockConsoleController DockConsoleController { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsProfilerPinned { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.UI.Other.DockConsoleController get_DockConsoleController()
        {
            if(this._uiRoot == 0)
            {
                    this.Load();
            }
            
            if(this._uiRoot != null)
            {
                    return (SRDebugger.UI.Other.DockConsoleController)this._uiRoot.DockConsoleController;
            }
            
            return (SRDebugger.UI.Other.DockConsoleController)this._uiRoot.DockConsoleController;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OptionPinStateChanged(System.Action<SRDebugger.Internal.OptionDefinition, bool> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OptionPinStateChanged, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OptionPinStateChanged != 1152921522993867576);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OptionPinStateChanged(System.Action<SRDebugger.Internal.OptionDefinition, bool> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OptionPinStateChanged, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OptionPinStateChanged != 1152921522994004152);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsProfilerPinned()
        {
            if(this._uiRoot == 0)
            {
                    return false;
            }
            
            if(this._uiRoot.Profiler != null)
            {
                    return this._uiRoot.Profiler.activeSelf;
            }
            
            return this._uiRoot.Profiler.activeSelf;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_IsProfilerPinned(bool value)
        {
            if(this._uiRoot == 0)
            {
                    this.Load();
            }
            
            this._uiRoot.Profiler.SetActive(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Pin(SRDebugger.Internal.OptionDefinition obj, int order = -1)
        {
            var val_6;
            if(this._uiRoot == 0)
            {
                    this.Load();
            }
            
            if((this._pinnedObjects.ContainsKey(key:  obj)) != false)
            {
                    return;
            }
            
            SRDebugger.UI.Controls.OptionsControlBase val_3 = SRDebugger.Internal.OptionControlFactory.CreateControl(from:  obj, categoryPrefix:  0);
            val_6 = val_3.CachedTransform;
            val_6.SetParent(parent:  this._uiRoot.Container, worldPositionStays:  false);
            if((order & 2147483648) == 0)
            {
                    val_6 = val_3.CachedTransform;
                val_6.SetSiblingIndex(index:  order);
            }
            
            this._pinnedObjects.Add(key:  obj, value:  val_3);
            this._controlList.Add(item:  val_3);
            this.OnPinnedStateChanged(option:  obj, isPinned:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Unpin(SRDebugger.Internal.OptionDefinition obj)
        {
            if((this._pinnedObjects.ContainsKey(key:  obj)) == false)
            {
                    return;
            }
            
            SRDebugger.UI.Controls.OptionsControlBase val_2 = this._pinnedObjects.Item[obj];
            bool val_3 = this._pinnedObjects.Remove(key:  obj);
            bool val_4 = this._controlList.Remove(item:  val_2);
            UnityEngine.Object.Destroy(obj:  val_2.CachedGameObject);
            this.OnPinnedStateChanged(option:  obj, isPinned:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnPinnedStateChanged(SRDebugger.Internal.OptionDefinition option, bool isPinned)
        {
            if(this.OptionPinStateChanged == null)
            {
                    return;
            }
            
            isPinned = isPinned;
            this.OptionPinStateChanged.Invoke(arg1:  option, arg2:  isPinned);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UnpinAll()
        {
            Dictionary.Enumerator<TKey, TValue> val_1 = this._pinnedObjects.GetEnumerator();
            label_6:
            if((1208188424 & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_2 = 0.trackableId;
            UnityEngine.Object.Destroy(obj:  val_2.m_SubId1.CachedGameObject);
            goto label_6;
            label_2:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921522994904584});
            this._pinnedObjects.Clear();
            this._controlList.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasPinned(SRDebugger.Internal.OptionDefinition option)
        {
            if(this._pinnedObjects != null)
            {
                    return this._pinnedObjects.ContainsKey(key:  option);
            }
            
            return this._pinnedObjects.ContainsKey(key:  option);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Awake()
        {
            this.Awake();
            this.CachedTransform.SetParent(p:  SRF.Hierarchy.Get(key:  "SRDebugger"));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Load()
        {
            var val_14;
            IntPtr val_16;
            IntPtr val_18;
            SRDebugger.UI.Other.PinnedUIRoot val_1 = UnityEngine.Resources.Load<SRDebugger.UI.Other.PinnedUIRoot>(path:  "SRDebugger/UI/Prefabs/PinnedUI");
            if(val_1 == 0)
            {
                    UnityEngine.Debug.LogError(message:  "[SRDebugger.PinnedUI] Error loading ui prefab");
                return;
            }
            
            SRDebugger.UI.Other.PinnedUIRoot val_3 = SRInstantiate.Instantiate<SRDebugger.UI.Other.PinnedUIRoot>(prefab:  val_1);
            val_14 = 0;
            val_3.CachedTransform.SetParent(parent:  this.CachedTransform, worldPositionStays:  false);
            this._uiRoot = val_3;
            this.UpdateAnchors();
            mem[1152921522995405888] = this;
            mem[1152921522995405896] = System.Void SRDebugger.Services.Implementation.PinnedUIServiceImpl::OnDebugPanelVisibilityChanged(bool isVisible);
            mem[1152921522995405872] = System.Void SRDebugger.Services.Implementation.PinnedUIServiceImpl::OnDebugPanelVisibilityChanged(bool isVisible);
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_14 = 20;
            SRDebug.Instance.add_PanelVisibilityChanged(value:  new SRDebugger.VisibilityChangedDelegate());
            System.EventHandler val_9 = null;
            val_16 = System.Void SRDebugger.Services.Implementation.PinnedUIServiceImpl::OnOptionsUpdated(object sender, System.EventArgs eventArgs);
            val_9 = new System.EventHandler(object:  this, method:  val_16);
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_16 = 0;
            SRDebugger.Internal.Service.Options.add_OptionsUpdated(value:  val_9);
            System.EventHandler<System.ComponentModel.PropertyChangedEventArgs> val_12 = null;
            val_18 = System.Void SRDebugger.Services.Implementation.PinnedUIServiceImpl::OptionsOnPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs);
            val_12 = new System.EventHandler<System.ComponentModel.PropertyChangedEventArgs>(object:  this, method:  val_18);
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_18 = 2;
            SRDebugger.Internal.Service.Options.add_OptionsValueUpdated(value:  val_12);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateAnchors()
        {
            var val_12;
            UnityEngine.UI.VerticalLayoutGroup val_13;
            UnityEngine.TextAnchor val_14;
            SRDebugger.Settings val_1 = SRDebugger.Settings.Instance;
            SRDebugger.PinAlignment val_12 = val_1._profilerAlignment;
            if(val_12 <= 5)
            {
                    val_12 = 1 << val_12;
                val_12 = val_12 & 21;
                if(val_12 != 0)
            {
                    UnityEngine.Transform val_2 = this._uiRoot.Profiler.transform;
                val_12 = 0;
            }
            else
            {
                    val_12 = 1;
            }
            
                this._uiRoot.Profiler.transform.SetSiblingIndex(index:  1);
            }
            
            SRDebugger.Settings val_4 = SRDebugger.Settings.Instance;
            SRDebugger.PinAlignment val_13 = val_4._profilerAlignment;
            if(val_13 > 5)
            {
                goto label_30;
            }
            
            var val_14 = 1;
            val_13 = val_14 << val_13;
            val_14 = val_13 & 3;
            if(val_14 != 0)
            {
                goto label_12;
            }
            
            val_13 = val_13 & 12;
            if(val_13 == 0)
            {
                goto label_13;
            }
            
            val_13 = this._uiRoot.ProfilerVerticalLayoutGroup;
            val_14 = 7;
            goto label_19;
            label_12:
            val_13 = this._uiRoot.ProfilerVerticalLayoutGroup;
            val_14 = 1;
            goto label_19;
            label_13:
            val_13 = this._uiRoot.ProfilerVerticalLayoutGroup;
            val_14 = 4;
            label_19:
            val_13.childAlignment = val_14;
            label_30:
            SRDebugger.Settings val_5 = SRDebugger.Settings.Instance;
            this._uiRoot.ProfilerHandleManager.SetAlignment(alignment:  val_5._profilerAlignment);
            SRDebugger.Settings val_6 = SRDebugger.Settings.Instance;
            if(val_6._optionsAlignment > 7)
            {
                    return;
            }
            
            var val_15 = 52951400 + (val_6._optionsAlignment) << 2;
            val_15 = val_15 + 52951400;
            goto (52951400 + (val_6._optionsAlignment) << 2 + 52951400);
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
        private void OnOptionsUpdated(object sender, System.EventArgs eventArgs)
        {
            var val_5;
            var val_12;
            var val_13;
            val_12 = this;
            List.Enumerator<T> val_3 = System.Linq.Enumerable.ToList<SRDebugger.Internal.OptionDefinition>(source:  this._pinnedObjects.Keys).GetEnumerator();
            do
            {
                label_15:
                if((1209217184 & 1) == 0)
            {
                    return;
            }
            
                var val_14 = 0;
                val_14 = val_14 + 1;
                val_13 = 4;
                var val_15 = 0;
                val_15 = val_15 + 1;
                val_13 = 4;
            }
            while((SRDebugger.Internal.Service.Options.Options.Contains(item:  null)) == true);
            
            this.Unpin(obj:  val_5.emailUIDataHandler);
            goto label_15;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OptionsOnPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs)
        {
            this._queueRefresh = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDebugPanelVisibilityChanged(bool isVisible)
        {
            if(isVisible == true)
            {
                    return;
            }
            
            this._queueRefresh = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Refresh()
        {
            goto label_1;
            label_5:
            SRDebugger.UI.Controls.OptionsControlBase val_1 = this._controlList.Item[0];
            0 = 1;
            label_1:
            if(0 < this._controlList.Count)
            {
                goto label_5;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PinnedUIServiceImpl()
        {
            this._controlList = new System.Collections.Generic.List<SRDebugger.UI.Controls.OptionsControlBase>();
            this._pinnedObjects = new System.Collections.Generic.Dictionary<SRDebugger.Internal.OptionDefinition, SRDebugger.UI.Controls.OptionsControlBase>();
        }
    
    }

}
