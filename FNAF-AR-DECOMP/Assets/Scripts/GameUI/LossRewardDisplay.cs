using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LossRewardDisplay : MonoBehaviour, IUISequence
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI message;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button button;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string audioBeginEventName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string audioEndEventName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.UISequenceData uiSequenceData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.RewardSequenceStatus status;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly GameUI.StatusType[] statusTypes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool sequenceComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool rewardExists;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool CheckForReward()
        {
            var val_8;
            var val_9;
            GameUI.Domain val_2 = Master.MasterDomain.GetDomain().gameUIDomain;
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(val_2.rewardDataV3 == null)
            {
                goto label_4;
            }
            
            val_8 = 0;
            goto label_5;
            label_3:
            val_9 = 1;
            return (bool)val_9 & 1;
            label_4:
            val_8 = 0;
            label_5:
            val_9 = ((val_8.region != 0) ? 1 : 0) | 1152921524870454121;
            return (bool)val_9 & 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetDisplayData()
        {
            string val_11;
            .<>4__this = this;
            Game.AttackSequence.Encounters.EncounterResult val_4 = Master.MasterDomain.GetDomain().gameUIDomain.encounterResult;
            if((val_2.ItemDefinitionDomain.ItemDefinitions.GetCPUById(id:  val_4.CpuId)) != null)
            {
                    val_11 = val_6.LossTextKey;
            }
            else
            {
                    val_11 = 0;
            }
            
            .youLostKey = (val_11 == 0) ? "You Lost!" : (val_11);
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  new LossRewardDisplay.<>c__DisplayClass10_0(), method:  System.Void LossRewardDisplay.<>c__DisplayClass10_0::<SetDisplayData>b__0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GameUI.IUISequence.StartSequence(GameUI.UISequenceData data)
        {
            GameUI.UISequenceData val_7;
            this.uiSequenceData = data;
            this.status = new GameUI.RewardSequenceStatus(gameObject:  this.gameObject, time:  -1f);
            this.sequenceComplete = false;
            this.SetDisplayData();
            this.rewardExists = this.CheckForReward();
            this.gameObject.SetActive(value:  true);
            val_7 = this.uiSequenceData;
            if(this.uiSequenceData != null)
            {
                goto label_2;
            }
            
            val_7 = this.uiSequenceData;
            if(val_7 == null)
            {
                goto label_3;
            }
            
            label_2:
            var val_7 = 0;
            val_7 = val_7 + 1;
            this.uiSequenceData.AudioPlayer.RaiseGameEventForModeWithOverrideByName(name:  this.audioBeginEventName, overridePrefix:  this.uiSequenceData.AnimatronicAudioId, mode:  2);
            return;
            label_3:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GameUI.IUISequence.UpdateSequence()
        {
            bool val_6;
            if(this.sequenceComplete != true)
            {
                    if((this.status.IsComplete(statusType:  2)) != false)
            {
                    val_6 = 1;
            }
            else
            {
                    val_6 = this.status.AllComplete(statusTypes:  this.statusTypes);
            }
            
                this.sequenceComplete = val_6;
            }
            
            UnityEngine.GameObject val_3 = this.button.gameObject;
            if(this.rewardExists == false)
            {
                goto label_6;
            }
            
            if(val_3 != null)
            {
                goto label_8;
            }
            
            label_9:
            label_8:
            val_3.SetActive(value:  (0 != 0) ? 1 : 0);
            return;
            label_6:
            if(val_3 != null)
            {
                goto label_8;
            }
            
            goto label_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool GameUI.IUISequence.IsSequenceDone()
        {
            if(this.rewardExists == false)
            {
                    return false;
            }
            
            return (bool)(this.sequenceComplete == true) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GameUI.IUISequence.TeardownSequence()
        {
            GameUI.UISequenceData val_3;
            UnityEngine.GameObject val_1 = this.gameObject;
            if(val_1 != null)
            {
                    val_1.SetActive(value:  false);
            }
            
            val_3 = this.uiSequenceData;
            if(this.uiSequenceData != null)
            {
                goto label_2;
            }
            
            val_3 = this.uiSequenceData;
            if(val_3 == null)
            {
                goto label_3;
            }
            
            label_2:
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.uiSequenceData.AudioPlayer.RaiseGameEventForModeWithOverrideByName(name:  this.audioEndEventName, overridePrefix:  this.uiSequenceData.AnimatronicAudioId, mode:  2);
            return;
            label_3:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LossRewardDisplay()
        {
            int val_2;
            GameUI.StatusType[] val_1 = new GameUI.StatusType[3];
            val_2 = val_1.Length;
            if(val_2 == 0)
            {
                    val_2 = val_1.Length;
            }
            
            val_1[0] = 3;
            val_1[0] = 1;
            this.statusTypes = val_1;
        }
    
    }

}
