using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WorkshopModifyStateUIActions : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopModifyStateUIView workshopModifyStateUIView;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SellMod(GameUI.ModCell modCell)
        {
            this.workshopModifyStateUIView.SellMod(modContext:  modCell.modContext);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowAssembleMenu()
        {
            this.workshopModifyStateUIView.ShowTab(tab:  4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowBodySelectionDialog()
        {
            this.workshopModifyStateUIView.ShowTab(tab:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowCPUSelectionDialog()
        {
            this.workshopModifyStateUIView.ShowTab(tab:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowEssenceSelectionDialog()
        {
            this.workshopModifyStateUIView.ShowTab(tab:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowModsSlot1()
        {
            bool val_1 = this.workshopModifyStateUIView.IsModSlotUnlocked(index:  0);
            if(val_1 != false)
            {
                    this.workshopModifyStateUIView.PopulateModSelection(index:  0);
            }
            
            this._masterDomain.eventExposer.OnWorkshopModIconPressed(unlocked:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowModsSlot2()
        {
            bool val_1 = this.workshopModifyStateUIView.IsModSlotUnlocked(index:  1);
            if(val_1 != false)
            {
                    this.workshopModifyStateUIView.PopulateModSelection(index:  1);
            }
            
            this._masterDomain.eventExposer.OnWorkshopModIconPressed(unlocked:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowModsSlot3()
        {
            bool val_1 = this.workshopModifyStateUIView.IsModSlotUnlocked(index:  2);
            if(val_1 != false)
            {
                    this.workshopModifyStateUIView.PopulateModSelection(index:  2);
            }
            
            this._masterDomain.eventExposer.OnWorkshopModIconPressed(unlocked:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowModsSlot4()
        {
            bool val_1 = this.workshopModifyStateUIView.IsModSlotUnlocked(index:  3);
            if(val_1 != false)
            {
                    this.workshopModifyStateUIView.PopulateModSelection(index:  3);
            }
            
            this._masterDomain.eventExposer.OnWorkshopModIconPressed(unlocked:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void ConfirmSellSelectedMod(GameUI.ModCell modCell)
        {
            this.SellMod(modCell:  modCell);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ConfirmSetEssenceValue()
        {
            this.workshopModifyStateUIView.SetEssenceValueFromSlider();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void DisplaySellMod(GameUI.ModCell modCell)
        {
            this.workshopModifyStateUIView.ShowSellModDialog(modCell:  modCell, ConfirmSellMod:  new System.Action<GameUI.ModCell>(object:  this, method:  System.Void GameUI.WorkshopModifyStateUIActions::ConfirmSellSelectedMod(GameUI.ModCell modCell)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowMoreInfoPlush()
        {
            this.workshopModifyStateUIView.ShowMoreInfoPlush();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowMoreInfoCPU()
        {
            this.workshopModifyStateUIView.ShowMoreInfoCPU();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowMoreInfoRemnant()
        {
            this.workshopModifyStateUIView.ShowMoreInfoRemnant();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._masterDomain = Master.MasterDomain.GetDomain();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WorkshopModifyStateUIActions()
        {
        
        }
    
    }

}
