using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ResultsPlayerWinUIView : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ResultSequencer playerWinSequence;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject returnButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject shortcutButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI oldStreakNumberText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI newStreakNumberText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI bestStreakNumberText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.RewardCell bestStreakReward;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.RewardGroup[] normalRewards;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ResultsDataModel _results;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Container.ProgressionData _progressionData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.BaseResultStep.ConditionalSettings _conditionalSettings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _animatronicAudioId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StartPlayerWinSequence(Game.Audio.IAudioPlayer audioPlayer, bool allowShortcut, bool allowAds)
        {
            Master.MasterDomain val_7;
            Master.EventExposer val_8;
            if(this.shortcutButton != 0)
            {
                    this.shortcutButton.SetActive(value:  allowShortcut);
            }
            
            this.GetDataSources();
            if(this.ValidateDataSources() != false)
            {
                    this.SetDynamicData(allowAds:  allowAds);
            }
            else
            {
                    ConsoleLogger.LogError(className:  "ResultsPlayerWinUIView", functionName:  "StartPlayerWinSequence", logString:  "Missing necessary data to fully display rewards. Using fallback data");
            }
            
            val_7 = this._masterDomain;
            if(val_7 == null)
            {
                goto label_9;
            }
            
            val_8 = this._masterDomain.eventExposer;
            goto label_10;
            label_9:
            val_8 = this._masterDomain.eventExposer;
            if(this._masterDomain == null)
            {
                goto label_11;
            }
            
            val_7 = this._masterDomain;
            label_10:
            label_15:
            this.playerWinSequence.StartSequence(masterEventExposer:  val_8, gameAssetManagementDomain:  this._masterDomain.GameAssetManagementDomain, assetBundleRequirementModule:  val_7.theGameDomain.AssetBundleRequirementModule, audioPlayer:  audioPlayer, animatronicAudioId:  this._animatronicAudioId, conditionalSettings:  this._conditionalSettings);
            return;
            label_11:
            if(this._masterDomain != null)
            {
                goto label_15;
            }
            
            goto label_15;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowReturnButton()
        {
            this.returnButton.SetActive(value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetDataSources()
        {
            GameUI.ResultsDataModel val_7;
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            this._masterDomain = val_1;
            if(val_1 == 0)
            {
                goto label_3;
            }
            
            GameUI.Domain val_3 = this._masterDomain.gameUIDomain;
            GameUI.WorkshopSlotDataModel val_4 = val_3.gameUIData.workshopSlotDataModel;
            this._results = val_4;
            if(val_4 != null)
            {
                goto label_6;
            }
            
            return;
            label_3:
            val_7 = this._results;
            if(val_7 == null)
            {
                    return;
            }
            
            label_6:
            if((this._results.<encounterResult>k__BackingField) == null)
            {
                    return;
            }
            
            this._progressionData = this._masterDomain.ItemDefinitionDomain.ItemDefinitions.GetProgressionDataForMaxStreak(maxStreak:  this._results.<encounterResult>k__BackingField.NewBestStreak);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ValidateDataSources()
        {
            string val_3;
            string val_4;
            string val_5;
            var val_6;
            if(this._masterDomain != 0)
            {
                goto label_3;
            }
            
            val_3 = "ResultsPlayerWinUIView";
            val_4 = "ValidateDataSources";
            val_5 = "MasterDomain is null";
            goto label_6;
            label_3:
            if(((this._results == null) || ((this._results.<encounterResult>k__BackingField) == null)) || ((this._results.<rewardDataV3>k__BackingField) == null))
            {
                goto label_9;
            }
            
            if(this._progressionData == null)
            {
                goto label_10;
            }
            
            val_6 = 1;
            return (bool)val_6;
            label_9:
            val_3 = "ResultsPlayerWinUIView";
            val_4 = "ValidateDataSources";
            val_5 = "ResultsDataModel or one of its children are null";
            label_6:
            label_16:
            ConsoleLogger.LogError(className:  val_3, functionName:  val_4, logString:  val_5);
            val_6 = 0;
            return (bool)val_6;
            label_10:
            string val_2 = System.String.Format(format:  "ProgressionData for streak {0} is null", arg0:  this._results.<encounterResult>k__BackingField.NewBestStreak);
            goto label_16;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetDynamicData(bool allowAds)
        {
            string val_21;
            GameUI.ItemUIDescription val_23;
            var val_24;
            GameUI.RewardV3Translator val_1 = new GameUI.RewardV3Translator(masterDomain:  this._masterDomain);
            System.Collections.Generic.List<GameUI.ItemUIDescription> val_2 = val_1.GetAllWinRewardDescriptions(rewardDataV3:  this._results.<rewardDataV3>k__BackingField);
            .IsNewBestStreak = ((this._results.<encounterResult>k__BackingField.NewBestStreak) > (this._results.<encounterResult>k__BackingField.OldBestStreak)) ? 1 : 0;
            .NumRewards = val_2.Count;
            .AllowAds = allowAds;
            this._conditionalSettings = new BaseResultStep.ConditionalSettings();
            this._animatronicAudioId = this._results.<encounterResult>k__BackingField.AnimatronicAudioId;
            this.oldStreakNumberText.text = this._results.<encounterResult>k__BackingField.OldCurrentStreak.ToString();
            this.newStreakNumberText.text = this._results.<encounterResult>k__BackingField.NewCurrentStreak.ToString();
            val_21 = this._results.<encounterResult>k__BackingField.NewBestStreak.ToString();
            this.bestStreakNumberText.text = val_21;
            if(this._conditionalSettings.IsNewBestStreak == false)
            {
                goto label_21;
            }
            
            if(this._progressionData.HasModSlotUnlock == false)
            {
                goto label_23;
            }
            
            GameUI.ItemUIDescription val_11 = val_1.GetModSlotRewardDescription();
            goto label_25;
            label_23:
            if(this._progressionData.HasEndoskeletonUnlock == false)
            {
                goto label_27;
            }
            
            label_25:
            val_21 = this;
            val_23 = val_1.GetEndoskeletonSlotRewardDescription();
            this.bestStreakReward.HideNumTextGroup();
            goto label_30;
            label_27:
            val_23 = val_1.GetPartsRewardDescription(numParts:  this._progressionData.BonusParts);
            val_21 = this.bestStreakReward;
            label_30:
            mem[this.bestStreakReward].SetData(itemUiDescription:  val_23);
            mem[this.bestStreakReward].SetSprite(sprite:  val_14.sprite);
            label_21:
            if(val_2.Count > this.normalRewards.Length)
            {
                    val_21 = this.normalRewards;
                ConsoleLogger.LogError(className:  "ResultsPlayerWinUIView", functionName:  "SetDynamicData", logString:  System.String.Format(format:  "More rewards were given ({0}) than the UI can support ({1})", arg0:  val_2.Count, arg1:  this.normalRewards.Length));
            }
            
            val_24 = 0;
            goto label_43;
            label_60:
            val_21 = this.normalRewards[0];
            if(val_24 < val_2.Count)
            {
                    this.normalRewards[0x0][0].rewardCell.SetData(itemUiDescription:  val_2.Item[0]);
                GameUI.RewardGroup val_21 = this.normalRewards[0];
                GameUI.ItemUIDescription val_20 = val_2.Item[0];
                val_21 = val_20.sprite;
                this.normalRewards[0x0][0].rewardCell.SetSprite(sprite:  val_21);
            }
            else
            {
                    this.normalRewards[0x0][0].rewardCellParent.SetActive(value:  false);
            }
            
            val_24 = 1;
            label_43:
            if(val_24 < this.normalRewards.Length)
            {
                goto label_60;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetFallbackData()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ResultsPlayerWinUIView()
        {
        
        }
    
    }

}
