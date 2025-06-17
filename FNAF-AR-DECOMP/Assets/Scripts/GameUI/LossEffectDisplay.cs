using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LossEffectDisplay : MonoBehaviour, IUISequence
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float duration;
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
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GameUI.IUISequence.StartSequence(GameUI.UISequenceData data)
        {
            GameUI.UISequenceData val_6;
            this.uiSequenceData = data;
            this.status = new GameUI.RewardSequenceStatus(gameObject:  this.gameObject, time:  this.duration);
            this.sequenceComplete = false;
            this.gameObject.SetActive(value:  true);
            val_6 = this.uiSequenceData;
            if(this.uiSequenceData != null)
            {
                goto label_2;
            }
            
            val_6 = this.uiSequenceData;
            if(val_6 == null)
            {
                goto label_3;
            }
            
            label_2:
            var val_6 = 0;
            val_6 = val_6 + 1;
            this.uiSequenceData.AudioPlayer.RaiseGameEventForModeWithOverrideByName(name:  this.audioBeginEventName, overridePrefix:  this.uiSequenceData.AnimatronicAudioId, mode:  2);
            this.button.gameObject.SetActive(value:  false);
            return;
            label_3:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GameUI.IUISequence.UpdateSequence()
        {
            if(this.sequenceComplete == true)
            {
                    return;
            }
            
            this.sequenceComplete = this.status.AllComplete(statusTypes:  this.statusTypes);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool GameUI.IUISequence.IsSequenceDone()
        {
            return (bool)this.sequenceComplete;
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
        public LossEffectDisplay()
        {
            GameUI.StatusType[] val_1 = new GameUI.StatusType[1];
            val_1[0] = 3;
            this.statusTypes = val_1;
        }
    
    }

}
