using UnityEngine;

namespace SRDebugger.UI.Other
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SRTabController : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SRF.SRList<SRDebugger.UI.Other.SRTab> _tabs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.UI.Other.SRTab _activeTab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform TabButtonContainer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.UI.Controls.SRTabButton TabButtonPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform TabContentsContainer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform TabHeaderContentContainer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text TabHeaderText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<SRDebugger.UI.Other.SRTabController, SRDebugger.UI.Other.SRTab> ActiveTabChanged;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.UI.Other.SRTab ActiveTab { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IList<SRDebugger.UI.Other.SRTab> Tabs { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.UI.Other.SRTab get_ActiveTab()
        {
            return (SRDebugger.UI.Other.SRTab)this._activeTab;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ActiveTab(SRDebugger.UI.Other.SRTab value)
        {
            this.MakeActive(tab:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IList<SRDebugger.UI.Other.SRTab> get_Tabs()
        {
            if(this._tabs != null)
            {
                    return this._tabs.AsReadOnly();
            }
            
            return this._tabs.AsReadOnly();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ActiveTabChanged(System.Action<SRDebugger.UI.Other.SRTabController, SRDebugger.UI.Other.SRTab> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ActiveTabChanged, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ActiveTabChanged != 1152921522955103920);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ActiveTabChanged(System.Action<SRDebugger.UI.Other.SRTabController, SRDebugger.UI.Other.SRTab> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ActiveTabChanged, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ActiveTabChanged != 1152921522955240496);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddTab(SRDebugger.UI.Other.SRTab tab, bool visibleInSidebar = True)
        {
            UnityEngine.Events.UnityAction val_12;
            SRTabController.<>c__DisplayClass15_0 val_1 = new SRTabController.<>c__DisplayClass15_0();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .tab = tab;
            mem[1152921522955482688] = this;
            if(tab != null)
            {
                goto label_35;
            }
            
            label_36:
            label_35:
            val_12 = tab.CachedTransform;
            val_12.SetParent(parent:  this.TabContentsContainer, worldPositionStays:  false);
            .tab.CachedGameObject.SetActive(value:  false);
            if(visibleInSidebar != false)
            {
                    SRDebugger.UI.Controls.SRTabButton val_4 = SRInstantiate.Instantiate<SRDebugger.UI.Controls.SRTabButton>(prefab:  this.TabButtonPrefab);
                val_4.CachedTransform.SetParent(parent:  this.TabButtonContainer, worldPositionStays:  false);
                string val_6 = tab._title.ToUpper();
                if(tab.IconExtraContent != 0)
            {
                    SRInstantiate.Instantiate<UnityEngine.RectTransform>(prefab:  tab.IconExtraContent).SetParent(parent:  val_4.ExtraContentContainer, worldPositionStays:  false);
            }
            
                val_4.IconStyleComponent.StyleKey = tab.IconStyleKey;
                val_4.IsActive = false;
                UnityEngine.Events.UnityAction val_10 = null;
                val_12 = val_10;
                val_10 = new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void SRTabController.<>c__DisplayClass15_0::<AddTab>b__0());
                val_4.Button.onClick.AddListener(call:  val_10);
                TabButton = val_4;
            }
            
            this._tabs.Add(item:  .tab);
            this.SortTabs();
            if(this._tabs.Count != 1)
            {
                    return;
            }
            
            this.MakeActive(tab:  .tab);
            return;
            label_1:
            mem[16] = this;
            mem[24] = tab;
            if(mem[24] != 0)
            {
                goto label_35;
            }
            
            goto label_36;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MakeActive(SRDebugger.UI.Other.SRTab tab)
        {
            SRDebugger.UI.Other.SRTab val_16;
            if((this._tabs.Contains(item:  tab)) != false)
            {
                    val_16 = this._activeTab;
                if(val_16 != 0)
            {
                    this._activeTab.CachedGameObject.SetActive(value:  false);
                if(this._activeTab.TabButton != 0)
            {
                    this._activeTab.TabButton.IsActive = false;
            }
            
                val_16 = this._activeTab.HeaderExtraContent;
                if(val_16 != 0)
            {
                    val_16 = this._activeTab.HeaderExtraContent.gameObject;
                val_16.SetActive(value:  false);
            }
            
            }
            
                this._activeTab = tab;
                if(tab != 0)
            {
                    this._activeTab.CachedGameObject.SetActive(value:  true);
                val_16 = mem[val_9 != true ? (this._activeTab + 128 - 8) : this._activeTab + 128];
                val_16 = ((System.String.IsNullOrEmpty(value:  this._activeTab._longTitle)) != true) ? ((this._activeTab + 128) - 8) : (this._activeTab + 128);
                if(this._activeTab.TabButton != 0)
            {
                    this._activeTab.TabButton.IsActive = true;
            }
            
                if(this._activeTab.HeaderExtraContent != 0)
            {
                    val_16 = this.TabHeaderContentContainer;
                this._activeTab.HeaderExtraContent.SetParent(parent:  val_16, worldPositionStays:  false);
                this._activeTab.HeaderExtraContent.gameObject.SetActive(value:  true);
            }
            
            }
            
                if(this.ActiveTabChanged == null)
            {
                    return;
            }
            
                this.ActiveTabChanged.Invoke(arg1:  this, arg2:  this._activeTab);
                return;
            }
            
            System.ArgumentException val_15 = new System.ArgumentException(message:  "tab is not a member of this tab controller", paramName:  "tab");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SortTabs()
        {
            var val_7;
            var val_9;
            val_7 = null;
            val_7 = null;
            if((SRTabController.<>c.<>9__17_0) == null)
            {
                goto label_3;
            }
            
            label_20:
            this._tabs.Sort(comparer:  SRTabController.<>c.<>9__17_0);
            val_9 = 0;
            goto label_5;
            label_16:
            SRDebugger.UI.Other.SRTab val_1 = this._tabs.Item[0];
            if(val_1.TabButton != 0)
            {
                    SRDebugger.UI.Other.SRTab val_3 = this._tabs.Item[0];
                val_3.TabButton.CachedTransform.SetSiblingIndex(index:  0);
            }
            
            val_9 = 1;
            label_5:
            if(val_9 < this._tabs.Count)
            {
                goto label_16;
            }
            
            return;
            label_3:
            SRTabController.<>c.<>9__17_0 = new System.Comparison<SRDebugger.UI.Other.SRTab>(object:  SRTabController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 SRTabController.<>c::<SortTabs>b__17_0(SRDebugger.UI.Other.SRTab t1, SRDebugger.UI.Other.SRTab t2));
            if(this._tabs != null)
            {
                goto label_20;
            }
            
            goto label_20;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRTabController()
        {
            this._tabs = new SRF.SRList<SRDebugger.UI.Other.SRTab>();
        }
    
    }

}
