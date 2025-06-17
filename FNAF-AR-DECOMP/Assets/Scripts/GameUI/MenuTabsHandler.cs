using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MenuTabsHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.TabParentKeyValue> tabParents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.Tab currentTab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<GameUI.Tab> DidSwitchTabs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<GameUI.Tab> WillSwitchTabs;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsCurrentTab(GameUI.Tab tab)
        {
            .tab = tab;
            GameUI.TabParentKeyValue val_3 = this.tabParents.Find(match:  new System.Predicate<GameUI.TabParentKeyValue>(object:  new MenuTabsHandler.<>c__DisplayClass4_0(), method:  System.Boolean MenuTabsHandler.<>c__DisplayClass4_0::<IsCurrentTab>b__0(GameUI.TabParentKeyValue x)));
            if(val_3 == null)
            {
                    return (bool)val_3;
            }
            
            if(val_3.parent != null)
            {
                    return val_3.parent.activeSelf;
            }
            
            return val_3.parent.activeSelf;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MenuTabsHandler(System.Collections.Generic.List<GameUI.TabParentKeyValue> tabParents, System.Action<GameUI.Tab> switchedTabs, System.Action<GameUI.Tab> willSwitchTabs)
        {
            this.tabParents = tabParents;
            this.DidSwitchTabs = switchedTabs;
            this.WillSwitchTabs = willSwitchTabs;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowTab(GameUI.Tab tab)
        {
            var val_4;
            System.Collections.Generic.List<GameUI.TabParentKeyValue> val_10;
            GameUI.ServerGameUIDataModel val_11;
            if((this.IsCurrentTab(tab:  tab)) == true)
            {
                    return;
            }
            
            this.WillSwitchTabs.Invoke(obj:  tab);
            val_10 = this.tabParents;
            List.Enumerator<T> val_2 = val_10.GetEnumerator();
            label_8:
            if(((-1242178672) & 1) == 0)
            {
                goto label_14;
            }
            
            if(val_4.emailUIDataHandler != null)
            {
                    val_11 = val_5._serverGameUIDataModel;
            }
            else
            {
                    val_11 = 15026800;
            }
            
            val_11.SetActive(value:  (val_5._masterDomain == tab) ? 1 : 0);
            goto label_8;
            label_14:
            this.DidSwitchTabs.Invoke(obj:  tab);
            if(tab != 2)
            {
                    if(tab != 0)
            {
                    return;
            }
            
                Systems.Analytics.AnalyticsCalls.FireEvent_Ui_UserHitNavigationButton_Profile();
                return;
            }
            
            Systems.Analytics.AnalyticsCalls.FireEvent_Ui_UserHitNavigationButton_Leaderboards();
        }
    
    }

}
