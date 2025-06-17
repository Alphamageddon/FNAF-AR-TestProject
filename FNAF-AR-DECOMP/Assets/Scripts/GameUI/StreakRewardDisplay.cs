using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StreakRewardDisplay : MonoBehaviour, IUISequence
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject newStreakParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject maxStreakParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI newStreakNum;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI maxStreakNum;
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
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GameUI.IUISequence.StartSequence(GameUI.UISequenceData data)
        {
            GameUI.UISequenceData val_5;
            this.uiSequenceData = data;
            this.status = new GameUI.RewardSequenceStatus(gameObject:  this.gameObject, time:  -1f);
            this.SetDisplayData();
            this.gameObject.SetActive(value:  true);
            val_5 = this.uiSequenceData;
            if(this.uiSequenceData != null)
            {
                goto label_2;
            }
            
            val_5 = this.uiSequenceData;
            if(val_5 == null)
            {
                goto label_3;
            }
            
            label_2:
            var val_5 = 0;
            val_5 = val_5 + 1;
            this.uiSequenceData.AudioPlayer.RaiseGameEventForModeWithOverrideByName(name:  this.audioBeginEventName, overridePrefix:  this.uiSequenceData.AnimatronicAudioId, mode:  2);
            return;
            label_3:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetDisplayData()
        {
            var val_4;
            GameUI.PopDownDataModel val_5;
            var val_6;
            TMPro.TextMeshProUGUI val_7;
            GameUI.Domain val_2 = Master.MasterDomain.GetDomain().gameUIDomain;
            if(val_2.gameUIData != 0)
            {
                    val_4 = val_2.gameUIData;
                val_5 = mem[val_2.gameUIData + 24];
                val_5 = val_2.gameUIData.<popDownDataModel>k__BackingField;
            }
            else
            {
                    val_4 = 24;
                val_5 = 15026800;
            }
            
            if(val_5 < (mem[val_2.gameUIData + 28]))
            {
                    this.newStreakParent.SetActive(value:  true);
                val_7 = this.newStreakNum;
            }
            else
            {
                    this.maxStreakParent.SetActive(value:  true);
                val_6 = 15026800;
                val_7 = this.maxStreakNum;
            }
            
            val_7.text = val_6.ToString();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GameUI.IUISequence.UpdateSequence()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool GameUI.IUISequence.IsSequenceDone()
        {
            if(this.status.gameObjectClick.buttonClicked != false)
            {
                    return true;
            }
            
            if(this.status != null)
            {
                    return this.status.AllComplete(statusTypes:  this.statusTypes);
            }
            
            return this.status.AllComplete(statusTypes:  this.statusTypes);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GameUI.IUISequence.TeardownSequence()
        {
            GameUI.UISequenceData val_3;
            this.gameObject.SetActive(value:  false);
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
        public StreakRewardDisplay()
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
