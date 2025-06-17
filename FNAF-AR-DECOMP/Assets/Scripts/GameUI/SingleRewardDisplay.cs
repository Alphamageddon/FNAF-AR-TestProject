using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SingleRewardDisplay : MonoBehaviour, IUISequence
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image rewardIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI rewardTitle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI rewardNumber;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string audioBeginEventName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string audioEndEventName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.GameObject> stars;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.UISequenceData uiSequenceData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.RewardSequenceStatus status;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly GameUI.StatusType[] statusTypes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Queue<GameUI.ItemUIDescription> rewardQueue;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.RewardV3Translator rewardV3Translator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool singleRewardSequenceComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool showingSubSequence;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool receivedResults;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_RewardsReceived(Game.TheGame.Data.RewardData obj)
        {
            this.masterDomain.eventExposer.remove_RewardsReceived(value:  new System.Action<Game.TheGame.Data.RewardData>(object:  this, method:  System.Void GameUI.SingleRewardDisplay::EventExposer_RewardsReceived(Game.TheGame.Data.RewardData obj)));
            GameUI.Domain val_2 = this.masterDomain.gameUIDomain;
            GameUI.WorkshopSlotDataModel val_3 = val_2.gameUIData.workshopSlotDataModel;
            this.BuildRewardQueue(rewardDataV3:  val_3._masterDomain);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddListToQueue(System.Collections.Generic.Queue<GameUI.ItemUIDescription> baseQueue, System.Collections.Generic.List<GameUI.ItemUIDescription> incomingList)
        {
            List.Enumerator<T> val_1 = incomingList.GetEnumerator();
            label_4:
            if(((-1207112536) & 1) == 0)
            {
                goto label_2;
            }
            
            baseQueue.Enqueue(item:  0.emailUIDataHandler);
            goto label_4;
            label_2:
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524874570920});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BuildRewardQueue(Game.TheGame.Data.RewardDataV3 rewardDataV3)
        {
            GameUI.Domain val_1 = this.masterDomain.gameUIDomain;
            GameUI.WorkshopSlotDataModel val_2 = val_1.gameUIData.workshopSlotDataModel;
            if(this.rewardV3Translator == null)
            {
                goto label_4;
            }
            
            if((val_2.selectedWorkshopSlotDataIndex + 56) == 0)
            {
                goto label_5;
            }
            
            label_7:
            System.Collections.Generic.List<GameUI.ItemUIDescription> val_3 = this.rewardV3Translator.GetAllWinRewardDescriptions(rewardDataV3:  rewardDataV3);
            goto label_6;
            label_4:
            if((val_2.selectedWorkshopSlotDataIndex + 56) != 0)
            {
                goto label_7;
            }
            
            label_5:
            System.Collections.Generic.List<GameUI.ItemUIDescription> val_4 = this.rewardV3Translator.GetEssenceOnLossCellDescriptions(rewardDataV3:  rewardDataV3);
            label_6:
            val_4.AddListToQueue(baseQueue:  this.rewardQueue, incomingList:  val_4);
            this.receivedResults = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateDisplayFromItemUIDefinition(GameUI.ItemUIDescription itemUiDescription)
        {
            GameUI.ItemUIDescription val_9 = itemUiDescription;
            this.rewardIcon.sprite = itemUiDescription.sprite;
            this.rewardTitle.text = (itemUiDescription.rewardCategory == 4) ? itemUiDescription.displayName : itemUiDescription.typeName;
            this.rewardNumber.text = itemUiDescription.number.ToString();
            List.Enumerator<T> val_3 = this.stars.GetEnumerator();
            label_9:
            if(((-1206761576) & 1) == 0)
            {
                goto label_6;
            }
            
            GameUI.EmailUIDataHandler val_4 = 0.emailUIDataHandler;
            val_4.SetActive(value:  ((this.stars.IndexOf(item:  val_4)) < itemUiDescription.magnitude) ? 1 : 0);
            goto label_9;
            label_6:
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524874921880});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShowSubSequence()
        {
            GameUI.UISequenceData val_4;
            this.UpdateDisplayFromItemUIDefinition(itemUiDescription:  this.rewardQueue.Dequeue());
            this.gameObject.SetActive(value:  true);
            this.showingSubSequence = true;
            val_4 = this.uiSequenceData;
            if(this.uiSequenceData != null)
            {
                goto label_3;
            }
            
            val_4 = this.uiSequenceData;
            if(val_4 == null)
            {
                goto label_4;
            }
            
            label_3:
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.uiSequenceData.AudioPlayer.RaiseGameEventForModeWithOverrideByName(name:  this.audioBeginEventName, overridePrefix:  this.uiSequenceData.AnimatronicAudioId, mode:  2);
            return;
            label_4:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CloseOutSubSequence()
        {
            GameUI.UISequenceData val_3;
            this.status.ResetClick();
            this.status.RestartTimer();
            this.gameObject.SetActive(value:  false);
            this.showingSubSequence = false;
            val_3 = this.uiSequenceData;
            if(this.uiSequenceData != null)
            {
                goto label_4;
            }
            
            val_3 = this.uiSequenceData;
            if(val_3 == null)
            {
                goto label_5;
            }
            
            label_4:
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.uiSequenceData.AudioPlayer.RaiseGameEventForModeWithOverrideByName(name:  this.audioEndEventName, overridePrefix:  this.uiSequenceData.AnimatronicAudioId, mode:  2);
            return;
            label_5:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GameUI.IUISequence.StartSequence(GameUI.UISequenceData data)
        {
            this.uiSequenceData = data;
            this.masterDomain = Master.MasterDomain.GetDomain();
            this.singleRewardSequenceComplete = false;
            this.showingSubSequence = false;
            this.status = new GameUI.RewardSequenceStatus(gameObject:  this.gameObject, time:  -1f);
            this.rewardQueue = new System.Collections.Generic.Queue<GameUI.ItemUIDescription>();
            this.rewardV3Translator = new GameUI.RewardV3Translator(masterDomain:  this.masterDomain);
            GameUI.Domain val_6 = this.masterDomain.gameUIDomain;
            GameUI.WorkshopSlotDataModel val_7 = val_6.gameUIData.workshopSlotDataModel;
            if(this.masterDomain == null)
            {
                goto label_4;
            }
            
            if(val_7.selectedWorkshopSlotData == null)
            {
                goto label_5;
            }
            
            label_8:
            GameUI.Domain val_8 = this.masterDomain.gameUIDomain;
            GameUI.WorkshopSlotDataModel val_9 = val_8.gameUIData.workshopSlotDataModel;
            this.BuildRewardQueue(rewardDataV3:  val_9._masterDomain);
            return;
            label_4:
            if(val_7.selectedWorkshopSlotData != null)
            {
                goto label_8;
            }
            
            label_5:
            this.masterDomain.eventExposer.add_RewardsReceived(value:  new System.Action<Game.TheGame.Data.RewardData>(object:  this, method:  System.Void GameUI.SingleRewardDisplay::EventExposer_RewardsReceived(Game.TheGame.Data.RewardData obj)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GameUI.IUISequence.UpdateSequence()
        {
            if(this.receivedResults == false)
            {
                    return;
            }
            
            if(this.showingSubSequence != true)
            {
                    if(this.rewardQueue.Count <= 0)
            {
                    this.singleRewardSequenceComplete = true;
            }
            
            }
            
            if(this.singleRewardSequenceComplete != false)
            {
                    return;
            }
            
            bool val_2 = this.EvaluateNextSequence();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool EvaluateNextSequence()
        {
            if(this.showingSubSequence != false)
            {
                    if(this.status.gameObjectClick.buttonClicked != true)
            {
                    if((this.status.AllComplete(statusTypes:  this.statusTypes)) == false)
            {
                    return false;
            }
            
            }
            
                this.CloseOutSubSequence();
                return false;
            }
            
            this.ShowSubSequence();
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool GameUI.IUISequence.IsSequenceDone()
        {
            return (bool)this.singleRewardSequenceComplete;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GameUI.IUISequence.TeardownSequence()
        {
            if(this.rewardQueue != null)
            {
                    this.rewardQueue.Clear();
            }
            
            this.rewardQueue = 0;
            this.CloseOutSubSequence();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SingleRewardDisplay()
        {
            int val_2;
            GameUI.StatusType[] val_1 = new GameUI.StatusType[3];
            val_2 = val_1.Length;
            if(val_2 == 0)
            {
                    val_2 = val_1.Length;
            }
            
            val_1[0] = 1;
            val_1[1] = 3;
            this.statusTypes = val_1;
        }
    
    }

}
