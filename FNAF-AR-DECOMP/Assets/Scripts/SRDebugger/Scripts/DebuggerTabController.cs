using UnityEngine;

namespace SRDebugger.Scripts
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DebuggerTabController : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.UI.Other.SRTab _aboutTabInstance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<SRDebugger.DefaultTabs> _activeTab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _hasStarted;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.UI.Other.SRTab AboutTab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.UI.Other.SRTabController TabController;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<SRDebugger.DefaultTabs> ActiveTab { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<SRDebugger.DefaultTabs> get_ActiveTab()
        {
            string val_8;
            var val_9;
            string val_2 = this.TabController.ActiveTab.Key;
            val_8 = val_2;
            if((System.String.IsNullOrEmpty(value:  val_2)) != false)
            {
                    val_9 = 0;
                return (System.Nullable<SRDebugger.DefaultTabs>)val_9;
            }
            
            val_8 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_8);
            val_9 = 0;
            if((System.Enum.IsDefined(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_8)) == false)
            {
                    return (System.Nullable<SRDebugger.DefaultTabs>)val_9;
            }
            
            val_9 = 0;
            return (System.Nullable<SRDebugger.DefaultTabs>)val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            SRDebugger.UI.Other.SRTabController val_26;
            var val_27;
            SRDebugger.UI.Other.SRTabController val_28;
            System.String[] val_29;
            var val_30;
            SRDebugger.UI.Other.SRTabController val_31;
            var val_33;
            val_26 = this;
            this.Start();
            this._hasStarted = true;
            val_27 = 1152921505143640064;
            val_28 = 1152921522931990272;
            val_29 = System.Enum.GetNames(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_30 = 0;
            goto label_5;
            label_33:
            T val_28 = UnityEngine.Resources.LoadAll<SRDebugger.UI.Other.SRTab>(path:  "SRDebugger/UI/Prefabs/Tabs")[0];
            val_31 = val_28.GetComponent(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            if(val_31 == null)
            {
                goto label_10;
            }
            
            var val_29 = 0;
            val_29 = val_29 + 1;
            if(val_31.IsEnabled == false)
            {
                goto label_30;
            }
            
            label_10:
            if((System.Linq.Enumerable.Contains<System.String>(source:  val_29, value:  val_28.Key)) == false)
            {
                goto label_23;
            }
            
            val_33 = 0;
            if((System.Enum.IsDefined(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_28.Key))) == false)
            {
                goto label_23;
            }
            
            val_31 = SRDebugger.Settings.Instance.DisabledTabs;
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_33 = 4;
            val_27 = val_27;
            val_26 = val_26;
            val_28 = val_28;
            val_29 = val_29;
            if((val_31.Contains(item:  val_29)) == true)
            {
                goto label_30;
            }
            
            label_23:
            val_31 = this.TabController;
            val_31.AddTab(tab:  SRInstantiate.Instantiate<SRDebugger.UI.Other.SRTab>(prefab:  val_28), visibleInSidebar:  true);
            label_30:
            val_30 = 1;
            label_5:
            if(val_30 < val_1.Length)
            {
                goto label_33;
            }
            
            if(this.AboutTab != 0)
            {
                    SRDebugger.UI.Other.SRTab val_21 = SRInstantiate.Instantiate<SRDebugger.UI.Other.SRTab>(prefab:  this.AboutTab);
                val_28 = this.TabController;
                this._aboutTabInstance = val_21;
                val_28.AddTab(tab:  val_21, visibleInSidebar:  false);
            }
            
            if((1145376152 & 1) != 0)
            {
                    UnityEngine.XR.ARCore.ARCoreFaceRegion val_22 = this._activeTab.region;
            }
            
            if((this.OpenTab(tab:  SRDebugger.Settings.Instance.DefaultTab)) == true)
            {
                    return;
            }
            
            val_26 = this.TabController;
            val_26.ActiveTab = System.Linq.Enumerable.FirstOrDefault<SRDebugger.UI.Other.SRTab>(source:  val_26.Tabs);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool OpenTab(SRDebugger.DefaultTabs tab)
        {
            SRDebugger.DefaultTabs val_10;
            var val_12;
            var val_15;
            var val_16;
            val_10 = tab;
            if(this._hasStarted != false)
            {
                    long val_2 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = val_10});
                var val_13 = 0;
                val_13 = val_13 + 1;
            }
            else
            {
                    val_12 = 1;
                this._activeTab = 0;
                return (bool)val_12;
            }
            
            val_10 = this.TabController.Tabs.GetEnumerator();
            label_23:
            var val_14 = 0;
            val_14 = val_14 + 1;
            if(val_10.MoveNext() == false)
            {
                goto label_16;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            T val_9 = val_10.Current;
            if((System.String.op_Equality(a:  val_9.Key, b:  val_10.ToString())) == false)
            {
                goto label_23;
            }
            
            this.TabController.ActiveTab = val_9;
            val_15 = 0;
            val_12 = 1;
            val_16 = 114;
            if(val_10 != null)
            {
                goto label_27;
            }
            
            goto label_34;
            label_16:
            val_15 = 0;
            val_12 = 0;
            val_16 = 112;
            if(val_10 != null)
            {
                goto label_27;
            }
            
            goto label_34;
            label_27:
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_10.Dispose();
            label_34:
            if( != 112)
            {
                    if( == 114)
            {
                    return (bool)val_12;
            }
            
            }
            
            val_12 = 0;
            return (bool)val_12;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowAboutTab()
        {
            if(this._aboutTabInstance == 0)
            {
                    return;
            }
            
            this.TabController.ActiveTab = this._aboutTabInstance;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DebuggerTabController()
        {
        
        }
    
    }

}
