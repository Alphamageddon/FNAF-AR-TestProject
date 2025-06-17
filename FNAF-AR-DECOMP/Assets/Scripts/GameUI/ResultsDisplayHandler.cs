using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ResultsDisplayHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DialogHandler_Results dialogHandler_Results;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.UISequencer rewardsSequencer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.GameObject> winSequences;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.GameObject> loseSequences;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.IAudioPlayer audioPlayer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ResultsDisplayHandler(Master.MasterDomain masterDomain, GameUI.DialogHandler_Results dialogHandler_Results, System.Collections.Generic.List<UnityEngine.GameObject> winSequences, System.Collections.Generic.List<UnityEngine.GameObject> loseSequences)
        {
            val_1 = new System.Object();
            this._masterDomain = masterDomain;
            this.dialogHandler_Results = dialogHandler_Results;
            this.winSequences = val_1;
            this.loseSequences = loseSequences;
            this.rewardsSequencer = new GameUI.UISequencer();
            masterDomain.GameAudioDomain.AudioPlayer.GetInterfaceAsync(callback:  new System.Action<Game.Audio.IAudioPlayer>(object:  this, method:  System.Void GameUI.ResultsDisplayHandler::AudioPlayerReady(Game.Audio.IAudioPlayer player)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AudioPlayerReady(Game.Audio.IAudioPlayer player)
        {
            this.audioPlayer = player;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RewardsFlowComplete()
        {
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            GameUI.WorkshopSlotDataModel val_2 = val_1.gameUIData.workshopSlotDataModel;
            val_2._masterDomain = 0;
            val_2.selectedWorkshopSlotData = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DispatchResults()
        {
            string val_5;
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            GameUI.WorkshopSlotDataModel val_2 = val_1.gameUIData.workshopSlotDataModel;
            if(this.dialogHandler_Results == null)
            {
                goto label_5;
            }
            
            if((val_2.selectedWorkshopSlotDataIndex + 56) == 0)
            {
                goto label_6;
            }
            
            label_10:
            this.dialogHandler_Results.ShowRewardsWin();
            if(this.rewardsSequencer != null)
            {
                goto label_11;
            }
            
            label_12:
            label_11:
            this.rewardsSequencer.LoadSequencer(sequencesToLoad:  this.winSequences);
            GameUI.UISequenceData val_3 = new GameUI.UISequenceData();
            if(val_3 == null)
            {
                goto label_8;
            }
            
            .AudioPlayer = this.audioPlayer;
            val_5 = mem[val_2.selectedWorkshopSlotDataIndex + 48];
            val_5 = val_2.selectedWorkshopSlotDataIndex + 48;
            goto label_9;
            label_5:
            if((val_2.selectedWorkshopSlotDataIndex + 56) != 0)
            {
                goto label_10;
            }
            
            label_6:
            this.dialogHandler_Results.ShowRewardsLose();
            if(this.rewardsSequencer != null)
            {
                goto label_11;
            }
            
            goto label_12;
            label_8:
            mem[16] = this.audioPlayer;
            val_5 = mem[val_2.selectedWorkshopSlotDataIndex + 48];
            val_5 = val_2.selectedWorkshopSlotDataIndex + 48;
            label_9:
            .AnimatronicAudioId = val_5;
            this.rewardsSequencer.uiSequenceData = val_3;
            this.rewardsSequencer.OnComplete = new System.Action(object:  this, method:  System.Void GameUI.ResultsDisplayHandler::RewardsFlowComplete());
            this.rewardsSequencer.Iterate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.rewardsSequencer.UpdateSequencer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDestroy()
        {
            if(this.rewardsSequencer != null)
            {
                    this.rewardsSequencer.OnDestroy();
            }
            
            this.rewardsSequencer = 0;
        }
    
    }

}
