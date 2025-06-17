using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AllRewardsDisplay : MonoBehaviour, IUISequence
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button button;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.RewardCell rewardCellPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform rewardCellsParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string audioBeginEventName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string audioEndEventName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.UISequenceData uiSequenceData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.RewardCellBuilder rewardCellBuilder;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.RewardCell> rewardCells;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.RewardSequenceStatus status;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.RewardV3Translator rewardV3Translator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly GameUI.StatusType[] statusTypes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool sequenceComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CTAClicked()
        {
            this.sequenceComplete = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateRewardCellsFromDescriptions(System.Collections.Generic.List<GameUI.ItemUIDescription> itemUIDescriptions)
        {
            var val_6 = this;
            List.Enumerator<T> val_1 = itemUIDescriptions.GetEnumerator();
            label_5:
            if(((-1219470984) & 1) == 0)
            {
                goto label_2;
            }
            
            this.rewardCells.Add(item:  this.rewardCellBuilder.CreateRewardCell(itemUiDescription:  0.emailUIDataHandler, rewardCellsParent:  this.rewardCellsParent));
            goto label_5;
            label_2:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524862212472});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddWinRewardCells(Game.TheGame.Data.RewardDataV3 rewardDataV3)
        {
            this.CreateRewardCellsFromDescriptions(itemUIDescriptions:  this.rewardV3Translator.GetAllWinRewardDescriptions(rewardDataV3:  rewardDataV3));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddLossRewardCells(Game.TheGame.Data.RewardDataV3 rewardDataV3)
        {
            this.CreateRewardCellsFromDescriptions(itemUIDescriptions:  this.rewardV3Translator.GetEssenceOnLossCellDescriptions(rewardDataV3:  rewardDataV3));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GameUI.IUISequence.StartSequence(GameUI.UISequenceData data)
        {
            GameUI.UISequenceData val_18;
            this.uiSequenceData = data;
            this._masterDomain = Master.MasterDomain.GetDomain();
            this.status = new GameUI.RewardSequenceStatus(gameObject:  this.gameObject, time:  -1f);
            this.rewardCellBuilder = new GameUI.RewardCellBuilder(rewardCellPrefab:  this.rewardCellPrefab);
            this.rewardV3Translator = new GameUI.RewardV3Translator(masterDomain:  this._masterDomain);
            this.button.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GameUI.AllRewardsDisplay::CTAClicked()));
            this.button.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GameUI.AllRewardsDisplay::CTAClicked()));
            GameUI.Domain val_10 = this._masterDomain.gameUIDomain;
            Game.AttackSequence.Encounters.EncounterResult val_12 = val_10.gameUIData.workshopSlotDataModel.encounterResult;
            GameUI.Domain val_13 = this._masterDomain.gameUIDomain;
            Game.TheGame.Data.RewardDataV3 val_15 = val_13.gameUIData.workshopSlotDataModel.rewardDataV3;
            if(val_12.PlayerDidWin != false)
            {
                    this.AddWinRewardCells(rewardDataV3:  val_15);
            }
            else
            {
                    this.AddLossRewardCells(rewardDataV3:  val_15);
            }
            
            this.gameObject.SetActive(value:  true);
            val_18 = this.uiSequenceData;
            if(this.uiSequenceData != null)
            {
                goto label_15;
            }
            
            val_18 = this.uiSequenceData;
            if(val_18 == null)
            {
                goto label_16;
            }
            
            label_15:
            var val_18 = 0;
            val_18 = val_18 + 1;
            this.uiSequenceData.AudioPlayer.RaiseGameEventForModeWithOverrideByName(name:  this.audioBeginEventName, overridePrefix:  this.uiSequenceData.AnimatronicAudioId, mode:  2);
            return;
            label_16:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GameUI.IUISequence.UpdateSequence()
        {
            bool val_6;
            if(this.button.gameObject.activeSelf != false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_3 = this.button.gameObject;
            if((this.status.IsComplete(statusType:  2)) == false)
            {
                goto label_5;
            }
            
            val_6 = 1;
            if(val_3 != null)
            {
                goto label_9;
            }
            
            goto label_7;
            label_5:
            val_6 = this.status.AllComplete(statusTypes:  this.statusTypes);
            if(val_3 != null)
            {
                goto label_9;
            }
            
            label_7:
            label_9:
            val_3.SetActive(value:  val_6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool GameUI.IUISequence.IsSequenceDone()
        {
            return (bool)this.sequenceComplete;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GameUI.IUISequence.TeardownSequence()
        {
            var val_3;
            GameUI.UISequenceData val_10;
            List.Enumerator<T> val_1 = this.rewardCells.GetEnumerator();
            label_6:
            if(((-1218317648) & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.Object.Destroy(obj:  val_3.emailUIDataHandler.gameObject);
            goto label_6;
            label_2:
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524863365808});
            this.rewardCells.Clear();
            this.gameObject.SetActive(value:  false);
            val_10 = this.uiSequenceData;
            if(this.uiSequenceData != null)
            {
                goto label_14;
            }
            
            val_10 = this.uiSequenceData;
            if(val_10 == null)
            {
                goto label_15;
            }
            
            label_14:
            var val_10 = 0;
            val_10 = val_10 + 1;
            this.uiSequenceData.AudioPlayer.RaiseGameEventForModeWithOverrideByName(name:  this.audioEndEventName, overridePrefix:  this.uiSequenceData.AnimatronicAudioId, mode:  2);
            return;
            label_15:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AllRewardsDisplay()
        {
            int val_3;
            this.rewardCells = new System.Collections.Generic.List<GameUI.RewardCell>();
            GameUI.StatusType[] val_2 = new GameUI.StatusType[3];
            val_3 = val_2.Length;
            if(val_3 == 0)
            {
                    val_3 = val_2.Length;
            }
            
            val_2[0] = 1;
            val_2[1] = 3;
            this.statusTypes = val_2;
        }
    
    }

}
