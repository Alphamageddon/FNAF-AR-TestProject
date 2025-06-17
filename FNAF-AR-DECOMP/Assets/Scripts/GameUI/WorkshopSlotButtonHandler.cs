using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WorkshopSlotButtonHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.GameObject> workshopAnimatronicButtons;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopSlotDataModel workshopSlotDataModel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopAnimatronicButton prefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopAnimatronicButton_Locked prefab_locked;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform parentTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<GameUI.IWorkshopSlotButton> UISelectButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<GameUI.IWorkshopSlotButton> UISelectLockedButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool didGenerateButtons;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopAnimatronicButton_Locked _endoSkeletonButton;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WorkshopSlotButtonHandler(Master.MasterDomain masterDomain, GameUI.WorkshopAnimatronicButton pfab, GameUI.WorkshopAnimatronicButton_Locked workshopAnimatronicButton_LockedPrefab, UnityEngine.Transform pTransform, System.Action<GameUI.IWorkshopSlotButton> UISelectButton, System.Action<GameUI.IWorkshopSlotButton> UISelectLockedButton)
        {
            System.Action val_8;
            this.prefab = pfab;
            this.prefab_locked = workshopAnimatronicButton_LockedPrefab;
            this.parentTransform = pTransform;
            this.UISelectButton = UISelectButton;
            this.UISelectLockedButton = UISelectLockedButton;
            this._masterDomain = masterDomain;
            GameUI.Domain val_1 = masterDomain.gameUIDomain;
            this.workshopSlotDataModel = val_1.gameUIData.emailUIDataHandler;
            this._masterDomain.eventExposer.add_WorkshopSlotDataUpdated(value:  new System.Action<System.Collections.Generic.List<GameUI.WorkshopSlotData>>(object:  this, method:  System.Void GameUI.WorkshopSlotButtonHandler::EventExposer_WorkshopSlotDataUpdated(System.Collections.Generic.List<GameUI.WorkshopSlotData> datas)));
            val_8 = System.Delegate.Combine(a:  val_4.VirtualGoodsIntegrated, b:  new System.Action(object:  this, method:  System.Void GameUI.WorkshopSlotButtonHandler::UpdatePurchasableEndoSkeletonButton()));
            if(this._masterDomain.StoreDomain.StoreContainer == null)
            {
                goto label_8;
            }
            
            if(val_8 != null)
            {
                goto label_9;
            }
            
            goto label_12;
            label_8:
            if(val_8 == null)
            {
                goto label_12;
            }
            
            label_9:
            if(null != null)
            {
                    val_8 = 0;
            }
            
            label_12:
            val_4.VirtualGoodsIntegrated = val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_WorkshopSlotDataUpdated(System.Collections.Generic.List<GameUI.WorkshopSlotData> datas)
        {
            this.GenerateAnimatronicButtons(datas:  datas);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateButtonsFromData(System.Collections.Generic.List<GameUI.WorkshopSlotData> datas)
        {
            List.Enumerator<T> val_1 = datas.GetEnumerator();
            label_4:
            if(((-1222635768) & 1) == 0)
            {
                goto label_2;
            }
            
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            this.CreateAndAddButtonToTable(slotData:  val_2, index:  datas.IndexOf(item:  val_2));
            goto label_4;
            label_2:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524859047688});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateAndAddButtonToTable(GameUI.WorkshopSlotData slotData, int index)
        {
            this.workshopAnimatronicButtons.Add(item:  this.CreateButtonWithData(data:  slotData, index:  index).gameObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopAnimatronicButton CreateButtonWithData(GameUI.WorkshopSlotData data, int index)
        {
            UnityEngine.Events.UnityAction val_11;
            var val_12;
            IntPtr val_14;
            .<>4__this = this;
            GameUI.WorkshopAnimatronicButton val_2 = UnityEngine.Object.Instantiate<GameUI.WorkshopAnimatronicButton>(original:  this.prefab, parent:  this.parentTransform);
            .workshopOrderButton = val_2;
            val_2.transform.SetSiblingIndex(index:  index);
            val_11 = UnityEngine.Object.op_Inequality(x:  (WorkshopSlotButtonHandler.<>c__DisplayClass14_0)[1152921524859437632].workshopOrderButton.GetComponent<UnityEngine.UI.Button>(), y:  0);
            if(((WorkshopSlotButtonHandler.<>c__DisplayClass14_0)[1152921524859437632].workshopOrderButton) == null)
            {
                goto label_7;
            }
            
            if(val_11 == false)
            {
                goto label_8;
            }
            
            label_11:
            val_12 = (WorkshopSlotButtonHandler.<>c__DisplayClass14_0)[1152921524859437632].workshopOrderButton.GetComponent<UnityEngine.UI.Button>().onClick;
            val_14 = 1152921524859355008;
            goto label_10;
            label_7:
            if(val_11 == true)
            {
                goto label_11;
            }
            
            label_8:
            GameUI.IllumixButton val_8 = (WorkshopSlotButtonHandler.<>c__DisplayClass14_0)[1152921524859437632].workshopOrderButton.GetComponent<GameUI.IllumixButton>();
            if(val_8 == null)
            {
                goto label_12;
            }
            
            val_12 = val_8.onClick;
            UnityEngine.Events.UnityAction val_10 = null;
            val_14 = 1152921524859368320;
            label_10:
            val_11 = val_10;
            val_10 = new UnityEngine.Events.UnityAction(object:  new WorkshopSlotButtonHandler.<>c__DisplayClass14_0(), method:  val_14);
            val_12.AddListener(call:  val_10);
            label_12:
            (WorkshopSlotButtonHandler.<>c__DisplayClass14_0)[1152921524859437632].workshopOrderButton.Initialize(data:  data, index:  index);
            return (GameUI.WorkshopAnimatronicButton)(WorkshopSlotButtonHandler.<>c__DisplayClass14_0)[1152921524859437632].workshopOrderButton;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetSelection()
        {
            UnityEngine.Object val_7;
            var val_8;
            var val_9;
            if(this.workshopAnimatronicButtons == null)
            {
                    return;
            }
            
            if(this.workshopAnimatronicButtons.Count < 1)
            {
                    return;
            }
            
            val_7 = this.workshopAnimatronicButtons.Item[0];
            if(val_7 == 0)
            {
                    return;
            }
            
            if(this.workshopSlotDataModel.selectedWorkshopSlotDataIndex < this.workshopAnimatronicButtons.Count)
            {
                    val_8 = public UnityEngine.GameObject System.Collections.Generic.List<UnityEngine.GameObject>::get_Item(int index);
                val_9 = this.workshopSlotDataModel.selectedWorkshopSlotDataIndex;
            }
            else
            {
                    val_8 = public UnityEngine.GameObject System.Collections.Generic.List<UnityEngine.GameObject>::get_Item(int index);
                val_9 = 0;
            }
            
            this.UISelectButton.Invoke(obj:  this.workshopAnimatronicButtons.Item[0].GetComponent<GameUI.IWorkshopSlotButton>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ClearOrderButtons()
        {
            if(this.workshopAnimatronicButtons == null)
            {
                goto label_1;
            }
            
            List.Enumerator<T> val_1 = this.workshopAnimatronicButtons.GetEnumerator();
            label_9:
            if(((-1221895928) & 1) == 0)
            {
                goto label_2;
            }
            
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            if(val_2 == 0)
            {
                goto label_9;
            }
            
            UnityEngine.Object.Destroy(obj:  val_2.gameObject);
            goto label_9;
            label_2:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524859787528});
            this.workshopAnimatronicButtons.Clear();
            this.workshopAnimatronicButtons = 0;
            label_1:
            this._endoSkeletonButton = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateOrderButtons(System.Collections.Generic.List<GameUI.WorkshopSlotData> datas)
        {
            this.workshopAnimatronicButtons = new System.Collections.Generic.List<UnityEngine.GameObject>();
            this.GenerateButtonsFromData(datas:  datas);
            this.UpdatePurchasableEndoSkeletonButton();
            this.GenerateRemainingLockedButtons();
            this.SetSelection();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateRemainingLockedButtons()
        {
            var val_9;
            System.Collections.Generic.List<System.Int32> val_2 = this._masterDomain.ItemDefinitionDomain.ItemDefinitions.GetStreaksForSlots();
            if(this._masterDomain != null)
            {
                    GameUI.Domain val_3 = this._masterDomain.gameUIDomain;
                if(val_3.gameUIData != 0)
            {
                goto label_7;
            }
            
            }
            
            label_7:
            val_9 = 0;
            goto label_8;
            label_15:
            if(0 < val_2.Item[0])
            {
                    this.workshopAnimatronicButtons.Add(item:  this.GenerateLockedButton(displayNumber:  val_2.Item[0], data:  0).gameObject);
            }
            
            val_9 = 1;
            label_8:
            if(val_9 < val_2.Count)
            {
                goto label_15;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DeletePurchasableEndoSkeletonButton()
        {
            if(this._endoSkeletonButton == 0)
            {
                    return;
            }
            
            bool val_3 = this.workshopAnimatronicButtons.Remove(item:  this._endoSkeletonButton.gameObject);
            UnityEngine.Object.Destroy(obj:  this._endoSkeletonButton.gameObject);
            this._endoSkeletonButton = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PurchaseEndoskeleton()
        {
            if(this._endoSkeletonButton == 0)
            {
                    return;
            }
            
            this._masterDomain.StoreDomain.StoreContainer.AddOwnedItem(shortCode:  this._endoSkeletonButton._storeDisplayData.shortCode, amount:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdatePurchasableEndoSkeletonButton()
        {
            Game.Store.Data.StoreDisplayData val_2 = this._masterDomain.StoreDomain.StoreContainer.GetNextAvailableEndoskeleton();
            if(val_2 == null)
            {
                goto label_4;
            }
            
            if(this._endoSkeletonButton != 0)
            {
                goto label_7;
            }
            
            GameUI.WorkshopAnimatronicButton_Locked val_4 = this.GenerateLockedButton(displayNumber:  val_2.Cost, data:  val_2);
            this._endoSkeletonButton = val_4;
            this.workshopAnimatronicButtons.Add(item:  val_4.gameObject);
            return;
            label_4:
            this.DeletePurchasableEndoSkeletonButton();
            return;
            label_7:
            this._endoSkeletonButton.SetDataForPurchase(price:  val_2.Cost.ToString(), data:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopAnimatronicButton_Locked GenerateLockedButton(int displayNumber, Game.Store.Data.StoreDisplayData data)
        {
            GameUI.WorkshopAnimatronicButton_Locked val_1 = UnityEngine.Object.Instantiate<GameUI.WorkshopAnimatronicButton_Locked>(original:  this.prefab_locked, parent:  this.parentTransform);
            val_1.Initialize(displayNumber:  displayNumber, data:  data, buttonCallback:  this.UISelectLockedButton);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SelectWarehouseButton(GameUI.IWorkshopSlotButton workshopAnimatronicButton)
        {
            var val_3;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_3 = 1;
            this.workshopSlotDataModel.SetSelectedSlotData(workshopSlotData:  workshopAnimatronicButton.GetWorkshopSlotData());
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_3 = 2;
            workshopAnimatronicButton.SetSelectedUI(value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GenerateAnimatronicButtons(System.Collections.Generic.List<GameUI.WorkshopSlotData> datas)
        {
            this.ClearOrderButtons();
            this.CreateOrderButtons(datas:  datas);
            this.SortWorkshopButtons();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SortWorkshopButtons()
        {
            object val_8 = this;
            this.workshopAnimatronicButtons.Sort(comparison:  new System.Comparison<UnityEngine.GameObject>(object:  this, method:  System.Int32 GameUI.WorkshopSlotButtonHandler::SortButtons(UnityEngine.GameObject x, UnityEngine.GameObject y)));
            List.Enumerator<T> val_2 = this.workshopAnimatronicButtons.GetEnumerator();
            label_7:
            if(((-1220485448) & 1) == 0)
            {
                    return;
            }
            
            GameUI.EmailUIDataHandler val_3 = 0.emailUIDataHandler;
            val_3.transform.SetSiblingIndex(index:  this.workshopAnimatronicButtons.IndexOf(item:  val_3));
            goto label_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int SortButtons(UnityEngine.GameObject x, UnityEngine.GameObject y)
        {
            UnityEngine.Object val_7;
            var val_8;
            var val_10;
            val_7 = y;
            val_8 = 1152921504851574784;
            if((x != 0) && (val_7 != 0))
            {
                    val_8 = 1152921524859596032;
                var val_9 = 0;
                val_9 = val_9 + 1;
            }
            else
            {
                    val_10 = 0;
                return (int)val_10;
            }
            
            val_7 = val_7.GetComponent<GameUI.IWorkshopSlotButton>();
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_10 = (x.GetComponent<GameUI.IWorkshopSlotButton>().GetSortWeight()) - val_7.GetSortWeight();
            return (int)val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDestroy()
        {
            System.Action val_6;
            if(this._masterDomain.eventExposer != null)
            {
                    this._masterDomain.eventExposer.remove_WorkshopSlotDataUpdated(value:  new System.Action<System.Collections.Generic.List<GameUI.WorkshopSlotData>>(object:  this, method:  System.Void GameUI.WorkshopSlotButtonHandler::EventExposer_WorkshopSlotDataUpdated(System.Collections.Generic.List<GameUI.WorkshopSlotData> datas)));
            }
            
            val_6 = System.Delegate.Remove(source:  val_2.VirtualGoodsIntegrated, value:  new System.Action(object:  this, method:  System.Void GameUI.WorkshopSlotButtonHandler::UpdatePurchasableEndoSkeletonButton()));
            if(this._masterDomain.StoreDomain.StoreContainer == null)
            {
                goto label_8;
            }
            
            if(val_6 != null)
            {
                goto label_9;
            }
            
            goto label_12;
            label_8:
            if(val_6 == null)
            {
                goto label_12;
            }
            
            label_9:
            if(null != null)
            {
                    val_6 = 0;
            }
            
            label_12:
            val_2.VirtualGoodsIntegrated = val_6;
        }
    
    }

}
