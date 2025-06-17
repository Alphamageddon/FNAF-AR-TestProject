using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ModifyTabHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ModifyTabType _currentTab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.GameObject> assembleTabs;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ModifyTabHandler(Master.MasterDomain masterDomain, System.Collections.Generic.List<UnityEngine.GameObject> assembleTabs)
        {
            val_1 = new System.Object();
            this._masterDomain = masterDomain;
            this.assembleTabs = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SwapTabs(int index)
        {
            List.Enumerator<T> val_1 = this.assembleTabs.GetEnumerator();
            label_5:
            if(((-1241640552) & 1) == 0)
            {
                goto label_2;
            }
            
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            val_2.SetActive(value:  ((this.assembleTabs.IndexOf(item:  val_2)) == index) ? 1 : 0);
            goto label_5;
            label_2:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524840042904});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DispatchClosedEvents(GameUI.ModifyTabType type)
        {
            if(type != 3)
            {
                    if(type != 1)
            {
                    return;
            }
            
                if(this._masterDomain.eventExposer == null)
            {
                    return;
            }
            
                this._masterDomain.eventExposer.OnWorkshopCpuMenuClosed();
                return;
            }
            
            if(this._masterDomain.eventExposer == null)
            {
                    return;
            }
            
            this._masterDomain.eventExposer.OnWorkshopModMenuClosed();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowTab(GameUI.ModifyTabType modifyTabType)
        {
            this.DispatchClosedEvents(type:  this._currentTab);
            this.SwapTabs(index:  modifyTabType);
            if(modifyTabType == 1)
            {
                goto label_0;
            }
            
            if(modifyTabType != 3)
            {
                goto label_4;
            }
            
            this._masterDomain.eventExposer.OnWorkshopModMenuOpened();
            goto label_4;
            label_0:
            this._masterDomain.eventExposer.OnWorkshopCpuMenuOpened();
            label_4:
            this._currentTab = modifyTabType;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDisable()
        {
            this.DispatchClosedEvents(type:  this._currentTab);
        }
    
    }

}
