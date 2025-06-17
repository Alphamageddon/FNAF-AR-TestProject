using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ResultsPlayerLoseUIView : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ResultSequencer playerLoseSequence;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject returnButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.NumberChanger streakNumberChanger;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI lostRemnantText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI currentRemnantText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.NumberChanger remnantNumberChanger;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool shouldFinalRemnantAnimate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ResultsDataModel _results;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.BaseResultStep.ConditionalSettings _conditionalSettings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _animatronicAudioId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StartPlayerLoseSequence(Game.Audio.IAudioPlayer audioPlayer)
        {
            Master.MasterDomain val_4;
            Master.EventExposer val_5;
            this.GetDataSources();
            if(this.ValidateDataSources() != false)
            {
                    this.SetDynamicData();
            }
            else
            {
                    ConsoleLogger.LogError(className:  "ResultsPlayerLoseUIView", functionName:  "StartPlayerLoseSequence", logString:  "Missing necessary data to fully display losses. Using fallback data");
            }
            
            val_4 = this._masterDomain;
            if(val_4 == null)
            {
                goto label_5;
            }
            
            val_5 = this._masterDomain.eventExposer;
            goto label_6;
            label_5:
            val_5 = this._masterDomain.eventExposer;
            if(this._masterDomain == null)
            {
                goto label_7;
            }
            
            val_4 = this._masterDomain;
            label_6:
            label_11:
            this.playerLoseSequence.StartSequence(masterEventExposer:  val_5, gameAssetManagementDomain:  this._masterDomain.GameAssetManagementDomain, assetBundleRequirementModule:  val_4.theGameDomain.AssetBundleRequirementModule, audioPlayer:  audioPlayer, animatronicAudioId:  this._animatronicAudioId, conditionalSettings:  this._conditionalSettings);
            return;
            label_7:
            if(this._masterDomain != null)
            {
                goto label_11;
            }
            
            goto label_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowReturnButton()
        {
            this.returnButton.SetActive(value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetDataSources()
        {
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            this._masterDomain = val_1;
            if(val_1 == 0)
            {
                    return;
            }
            
            GameUI.Domain val_3 = this._masterDomain.gameUIDomain;
            this._results = val_3.gameUIData.workshopSlotDataModel;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ValidateDataSources()
        {
            string val_2;
            string val_3;
            string val_4;
            var val_5;
            if(this._masterDomain == 0)
            {
                    val_2 = "ResultsPlayerLoseUIView";
                val_3 = "ValidateDataSources";
                val_4 = "MasterDomain is null";
            }
            else
            {
                    if(((this._results != null) && ((this._results.<encounterResult>k__BackingField) != null)) && ((this._results.<rewardDataV3>k__BackingField) != null))
            {
                    val_5 = 1;
                return (bool)val_5;
            }
            
                val_2 = "ResultsPlayerLoseUIView";
                val_3 = "ValidateDataSources";
                val_4 = "ResultsDataModel or one of its children are null";
            }
            
            ConsoleLogger.LogError(className:  val_2, functionName:  val_3, logString:  val_4);
            val_5 = 0;
            return (bool)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetDynamicData()
        {
            BaseResultStep.ConditionalSettings val_1 = new BaseResultStep.ConditionalSettings();
            if(val_1 != null)
            {
                    .StartingStreak = this._results.<encounterResult>k__BackingField.OldCurrentStreak;
            }
            else
            {
                    mem[24] = this._results.<encounterResult>k__BackingField.OldCurrentStreak;
            }
            
            .AllowAds = true;
            this._conditionalSettings = val_1;
            this._animatronicAudioId = this._results.<encounterResult>k__BackingField.AnimatronicAudioId;
            this.streakNumberChanger.InitValues(startNumber:  this._results.<encounterResult>k__BackingField.OldCurrentStreak, endNumber:  this._results.<encounterResult>k__BackingField.NewCurrentStreak);
            this.lostRemnantText.text = System.String.Format(format:  "-{0}", arg0:  this._results.<rewardDataV3>k__BackingField.essenceOnLoss);
            this.currentRemnantText.text = System.String.Format(format:  "{0}", arg0:  this._results.<encounterResult>k__BackingField.CurrentRemnant);
            int val_5 = UnityEngine.Mathf.Max(a:  (this._results.<encounterResult>k__BackingField.CurrentRemnant) - (this._results.<rewardDataV3>k__BackingField.essenceOnLoss), b:  0);
            this.remnantNumberChanger.InitValues(startNumber:  (this.shouldFinalRemnantAnimate == true) ? this._results.<encounterResult>k__BackingField.CurrentRemnant : (val_5), endNumber:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetFallbackData()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ResultsPlayerLoseUIView()
        {
        
        }
    
    }

}
