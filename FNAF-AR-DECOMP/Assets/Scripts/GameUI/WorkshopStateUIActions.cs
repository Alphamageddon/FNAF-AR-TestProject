using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WorkshopStateUIActions : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string LOC_MAX_SCAVENGERS = "ui_workshop_too_many_scavengers";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject buttonPanel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DialogHandler_Workshop dialogHandler_Workshop;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopStateUIView workshopStateUIView;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopSlotDataModel workshopSlotDataModel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> SpawnNewAnimatronic;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action EndoSkeletonPurchased;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RecallAttackingAnimatronic()
        {
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            AnimatronicEntity.Data.WorkshopEntry val_4 = val_1.gameUIData.emailUIDataHandler.GetSelectedSlotData().ServerEntry;
            val_4.status = 3;
            GameUI.Domain val_5 = this._masterDomain.gameUIDomain;
            this._masterDomain.serverDomain.recallAttackingAnimatronicRequester.RecallAnimatronicAttack(slotId:  val_5.gameUIData.emailUIDataHandler.GetSelectedSlotDataIndex());
            this._masterDomain.eventExposer.OnRecallButtonTapped();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SendAnimatronic(string userId)
        {
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            GameUI.WorkshopSlotData val_3 = val_1.gameUIData.emailUIDataHandler.GetSelectedSlotData();
            AnimatronicEntity.Data.WorkshopEntry val_4 = val_3.ServerEntry;
            val_4.status = 2;
            GameUI.Domain val_5 = this._masterDomain.gameUIDomain;
            int val_7 = val_5.gameUIData.emailUIDataHandler.GetSelectedSlotDataIndex();
            Game.Server.SendAnimatronicV2Params val_8 = new Game.Server.SendAnimatronicV2Params();
            if(val_8 != null)
            {
                    .slotId = val_7;
            }
            else
            {
                    mem[16] = val_7;
            }
            
            .userId = userId;
            this._masterDomain.serverDomain.sendAnimatronicV2Requester.SendAnimatronic(parameters:  val_8, callbacks:  new Game.Server.SendAnimatronicV2Callbacks(success:  new System.Action<Game.Server.SendAnimatronicV2ResponseData>(object:  this, method:  System.Void GameUI.WorkshopStateUIActions::SendAnimatronicSuccess(Game.Server.SendAnimatronicV2ResponseData obj)), error:  new System.Action<System.String>(object:  this, method:  System.Void GameUI.WorkshopStateUIActions::SendAnimatronicFailed(string obj))));
            if(val_3.DisplayEndoskeleton == null)
            {
                    return;
            }
            
            Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData val_13 = val_3.DisplayEndoskeleton;
            Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData val_14 = val_3.DisplayEndoskeleton;
            Systems.Analytics.AnalyticsCalls.FireEvent_SendAnimatronicToFriend(cpuId:  val_13.cpu, plushSuitId:  val_14.plushSuit, userId:  userId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SendAnimatronicSuccess(Game.Server.SendAnimatronicV2ResponseData obj)
        {
            this.dialogHandler_Workshop.DismissSendSelect();
            this.workshopStateUIView.ReenableSendSelect();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SendAnimatronicFailed(string obj)
        {
            this.dialogHandler_Workshop.DismissSendSelect();
            this.workshopStateUIView.ReenableSendSelect();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OrderRepair()
        {
            System.Action val_13;
            AnimatronicEntity.Data.WorkshopEntry val_3 = this.workshopSlotDataModel.GetSelectedSlotData().ServerEntry;
            Game.ItemDefinition.Data.DataDefinitions.WearAndTearData val_4 = this._masterDomain.ItemDefinitionDomain.ItemDefinitions.GetWearAndTearData(index:  val_3.health);
            this.CheckIfHasEnoughParts(cost:  val_4.RepairParts, parts:  this._masterDomain.theGameDomain.bank.GetCurrency(currencyName:  "PARTS"));
            val_13 = System.Delegate.Combine(a:  this._masterDomain.serverDomain.repairAnimatronicRequester.RepairFailure, b:  new System.Action(object:  this, method:  System.Void GameUI.WorkshopStateUIActions::RepairFailure()));
            if(this._masterDomain.serverDomain.repairAnimatronicRequester == null)
            {
                goto label_14;
            }
            
            if(val_13 != null)
            {
                goto label_15;
            }
            
            goto label_18;
            label_14:
            if(val_13 == null)
            {
                goto label_18;
            }
            
            label_15:
            if(null != null)
            {
                    val_13 = 0;
            }
            
            label_18:
            this._masterDomain.serverDomain.repairAnimatronicRequester.RepairFailure = val_13;
            this._masterDomain.eventExposer.add_WorkshopDataV2Updated(value:  new System.Action<AnimatronicEntity.Data.WorkshopData>(object:  this, method:  System.Void GameUI.WorkshopStateUIActions::RepairSuccess(AnimatronicEntity.Data.WorkshopData obj)));
            this._masterDomain.serverDomain.repairAnimatronicRequester.RepairAnimatronic(slot:  this.workshopSlotDataModel.GetSelectedSlotDataIndex(), cost:  val_4.RepairParts);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CheckIfHasEnoughParts(int cost, int parts)
        {
            if(cost <= parts)
            {
                    return;
            }
            
            this.dialogHandler_Workshop.ShowRepairError();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RecallScavengingAnimatronic()
        {
            AnimatronicEntity.AnimatronicEntity val_9;
            GameUI.WorkshopSlotData val_1 = this.workshopSlotDataModel.GetSelectedSlotData();
            if(val_1 == null)
            {
                    return;
            }
            
            if(val_1.ServerEntry == null)
            {
                    return;
            }
            
            val_9 = val_1.ServerEntry;
            if((System.String.IsNullOrWhiteSpace(value:  val_3.entityId)) == true)
            {
                    return;
            }
            
            AnimatronicEntity.Data.WorkshopEntry val_6 = val_1.ServerEntry;
            val_9 = this._masterDomain.AnimatronicEntityDomain.container.GetEntity(entityId:  val_6.entityId);
            if(val_9 == null)
            {
                    return;
            }
            
            AnimatronicEntity.Data.WorkshopEntry val_8 = val_1.ServerEntry;
            val_8.status = 3;
            this._masterDomain.serverDomain.recallScavengeRequester.Recall(entity:  val_9);
            this._masterDomain.eventExposer.OnRecallButtonTapped();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OrderSelectedScavenge()
        {
            if(this.MaxScavengersDeployed() != false)
            {
                    Game.Localization.LocalizationDomain val_2 = Game.Localization.LocalizationDomain.Instance;
                var val_13 = 0;
                val_13 = val_13 + 1;
            }
            else
            {
                    GameUI.Domain val_3 = this._masterDomain.gameUIDomain;
                GameUI.WorkshopSlotData val_5 = val_3.gameUIData.emailUIDataHandler.GetSelectedSlotData();
                AnimatronicEntity.Data.WorkshopEntry val_6 = val_5.ServerEntry;
                val_6.status = 1;
                this._masterDomain.serverDomain.sendScavengeAnimatronicV2Requester.SendAnimatronicScavenge(slotId:  this.workshopSlotDataModel.GetSelectedSlotDataIndex());
                if(val_5.DisplayEndoskeleton == null)
            {
                    return;
            }
            
                Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData val_9 = val_5.DisplayEndoskeleton;
                Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData val_10 = val_5.DisplayEndoskeleton;
                Systems.Analytics.AnalyticsCalls.FireEvent_SendAnimatronicToSalvage(cpuId:  val_9.cpu, plushSuitId:  val_10.plushSuit);
                return;
            }
            
            this.dialogHandler_Workshop.ShowErrorDialog(error:  val_2.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_too_many_scavengers", originalString:  "ui_workshop_too_many_scavengers"));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool MaxScavengersDeployed()
        {
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            return (bool)(val_1.gameUIData.emailUIDataHandler.NumScavengers() >= this.workshopStateUIView._maxScavengers) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowPurchaseDialog(UnityEngine.Sprite icon, Game.Store.Data.StoreDisplayData data)
        {
            this.dialogHandler_Workshop.ShowPurchaseDialog(data:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InGamePurchaseRequest(Game.Store.Data.StoreDisplayData displayData)
        {
            bool val_1 = this._masterDomain.StoreDomain.CanAfford(data:  displayData);
            if(this._masterDomain.eventExposer == null)
            {
                goto label_3;
            }
            
            if(val_1 == false)
            {
                goto label_4;
            }
            
            label_8:
            this._masterDomain.eventExposer.OnPurchaseRequestAudioInvoked(canAfford:  true);
            if(this.EndoSkeletonPurchased != null)
            {
                    this.EndoSkeletonPurchased.Invoke();
            }
            
            this._masterDomain.StoreDomain.InitiatePurchase(data:  displayData);
            return;
            label_3:
            if(val_1 == true)
            {
                goto label_8;
            }
            
            label_4:
            this._masterDomain.eventExposer.OnPurchaseRequestAudioInvoked(canAfford:  false);
            this._masterDomain.eventExposer.OnBuyMoreCoinsDialogRequest();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowSendSelectDialog()
        {
            this.workshopStateUIView.SetupSendSelectDialog(SendSelectedSlotToUserId:  new System.Action<System.String>(object:  this, method:  public System.Void GameUI.WorkshopStateUIActions::SendSelectedSlotToUserId(string userId)));
            this.dialogHandler_Workshop.ShowSendSelect();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowRepairConfirmation()
        {
            this.dialogHandler_Workshop.ShowRepairConfirm();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SelectDeployButton()
        {
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            AnimatronicEntity.Data.WorkshopEntry val_4 = val_1.gameUIData.emailUIDataHandler.GetSelectedSlotData().ServerEntry;
            if(val_4.status == 4)
            {
                goto label_5;
            }
            
            if(val_4.status == 1)
            {
                goto label_6;
            }
            
            if(val_4.status != 0)
            {
                    return;
            }
            
            this.ShowDeployDialog();
            return;
            label_5:
            this.RecallAttackingAnimatronic();
            return;
            label_6:
            this.RecallScavengingAnimatronic();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShowDeployDialog()
        {
            string val_8;
            string val_9;
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            GameUI.WorkshopSlotData val_3 = val_1.gameUIData.emailUIDataHandler.GetSelectedSlotData();
            if((val_3 != null) && (val_3.DisplayEndoskeleton != null))
            {
                    val_8 = val_4.plushSuit;
            }
            else
            {
                    val_8 = 0;
            }
            
            Game.ItemDefinition.Data.DataDefinitions.PlushSuitData val_6 = this._masterDomain.ItemDefinitionDomain.ItemDefinitions.GetPlushSuitById(id:  val_8);
            if(val_6 != null)
            {
                    val_9 = val_6.AnimatronicName;
            }
            else
            {
                    val_9 = 0;
            }
            
            this.dialogHandler_Workshop.ShowDeploySelectionDialog(displayName:  val_9);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowScavengeDialog()
        {
            this.OrderSelectedScavenge();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PurchaseRepair()
        {
            this.OrderRepair();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendSelectedSlotToUserId(string userId)
        {
            this.SendAnimatronic(userId:  userId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            this._masterDomain = val_1;
            GameUI.Domain val_2 = val_1.gameUIDomain;
            this.workshopSlotDataModel = val_2.gameUIData.emailUIDataHandler;
            this.SpawnNewAnimatronic = new System.Action<System.String>(object:  this._masterDomain.AnimatronicsSpawnerDomain.spawner, method:  public System.Void Animatronics.Spawner.Spawner::SpawnNewAnimatronic(string animatronicId));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            this.SpawnNewAnimatronic = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RepairSuccess(AnimatronicEntity.Data.WorkshopData obj)
        {
            this._masterDomain.eventExposer.OnWorkshopRepairSuccess();
            this.RemoveCallbacks();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RepairFailure()
        {
            this.RemoveCallbacks();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemoveCallbacks()
        {
            System.Delegate val_5 = System.Delegate.Remove(source:  this._masterDomain.serverDomain.repairAnimatronicRequester.RepairFailure, value:  new System.Action(object:  this, method:  System.Void GameUI.WorkshopStateUIActions::RepairFailure()));
            if(this._masterDomain.serverDomain.repairAnimatronicRequester == null)
            {
                goto label_4;
            }
            
            if(val_5 != null)
            {
                goto label_5;
            }
            
            goto label_8;
            label_4:
            if(val_5 == null)
            {
                goto label_8;
            }
            
            label_5:
            if(null != null)
            {
                    val_5 = 0;
            }
            
            label_8:
            this._masterDomain.serverDomain.repairAnimatronicRequester.RepairFailure = val_5;
            this._masterDomain.eventExposer.remove_WorkshopDataV2Updated(value:  new System.Action<AnimatronicEntity.Data.WorkshopData>(object:  this, method:  System.Void GameUI.WorkshopStateUIActions::RepairSuccess(AnimatronicEntity.Data.WorkshopData obj)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WorkshopStateUIActions()
        {
        
        }
    
    }

}
