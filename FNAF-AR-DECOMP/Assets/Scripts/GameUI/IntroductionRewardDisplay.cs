using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IntroductionRewardDisplay : MonoBehaviour, IUISequence
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI message;
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
        private void SetDisplayData()
        {
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.IntroductionRewardDisplay::<SetDisplayData>b__6_0(Game.Localization.ILocalization localization)));
        }
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
        private void GameUI.IUISequence.UpdateSequence()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool GameUI.IUISequence.IsSequenceDone()
        {
            if((this.status.IsComplete(statusType:  2)) != false)
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
        public IntroductionRewardDisplay()
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
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <SetDisplayData>b__6_0(Game.Localization.ILocalization localization)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.message.text = localization.GetLocalizedString(localizedStringId:  "ui_results_display_you_did_it", originalString:  "You Did It!");
        }
    
    }

}
