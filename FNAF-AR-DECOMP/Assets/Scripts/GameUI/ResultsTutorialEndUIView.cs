using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ResultsTutorialEndUIView : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ResultSequencer tutorialEndSequence;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ResultsDataModel _results;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StartTutorialEndSequence(Game.Audio.IAudioPlayer audioPlayer)
        {
            int val_5;
            Master.MasterDomain val_6;
            Master.EventExposer val_7;
            val_5 = System.String.alignConst;
            this.GetDataSources();
            if(this.ValidateDataSources() != false)
            {
                    val_5 = this._results.<encounterResult>k__BackingField.AnimatronicAudioId;
            }
            
            val_6 = this._masterDomain;
            if(val_6 == null)
            {
                goto label_4;
            }
            
            val_7 = this._masterDomain.eventExposer;
            goto label_5;
            label_4:
            val_7 = this._masterDomain.eventExposer;
            if(this._masterDomain == null)
            {
                goto label_6;
            }
            
            val_6 = this._masterDomain;
            label_5:
            label_10:
            this.tutorialEndSequence.StartSequence(masterEventExposer:  val_7, gameAssetManagementDomain:  this._masterDomain.GameAssetManagementDomain, assetBundleRequirementModule:  val_6.theGameDomain.AssetBundleRequirementModule, audioPlayer:  audioPlayer, animatronicAudioId:  val_5, conditionalSettings:  new BaseResultStep.ConditionalSettings());
            return;
            label_6:
            if(this._masterDomain != null)
            {
                goto label_10;
            }
            
            goto label_10;
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
                    val_2 = "ResultsTutorialEndUIView";
                val_3 = "ValidateDataSources";
                val_4 = "MasterDomain is null";
            }
            else
            {
                    if((this._results != null) && ((this._results.<encounterResult>k__BackingField) != null))
            {
                    val_5 = 1;
                return (bool)val_5;
            }
            
                val_2 = "ResultsTutorialEndUIView";
                val_3 = "ValidateDataSources";
                val_4 = "ResultsDataModel or one of its children are null";
            }
            
            ConsoleLogger.LogError(className:  val_2, functionName:  val_3, logString:  val_4);
            val_5 = 0;
            return (bool)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ResultsTutorialEndUIView()
        {
        
        }
    
    }

}
