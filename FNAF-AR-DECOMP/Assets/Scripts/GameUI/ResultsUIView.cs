using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ResultsUIView : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.CanvasFlow.GameProject_Alpine_CanvasController_Results canvasController_Results;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DialogHandler_Results dialogHandler_Results;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.GameObject> rewardsDisplayWin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.GameObject> rewardsDisplayLoss;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ResultsPlayerWinUIView playerWinUIView;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ResultsPlayerLoseUIView playerLoseUIView;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ResultsTutorialEndUIView tutorialEndUIView;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool useOldSequence;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.IAudioPlayer _audioPlayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ResultsDisplayHandler resultsDisplayHandler;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            System.Action<T> val_6;
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            this._masterDomain = val_1;
            if(val_1 != 0)
            {
                    System.Action<Game.Audio.IAudioPlayer> val_4 = null;
                val_6 = val_4;
                val_4 = new System.Action<Game.Audio.IAudioPlayer>(object:  this, method:  System.Void GameUI.ResultsUIView::AudioPlayerReady(Game.Audio.IAudioPlayer audioPlayer));
                this._masterDomain.GameAudioDomain.AudioPlayer.GetInterfaceAsync(callback:  val_4);
                this._masterDomain.eventExposer.OnRewardDialogOpened();
            }
            
            if(this.useOldSequence == false)
            {
                    return;
            }
            
            val_6 = this.dialogHandler_Results;
            this.resultsDisplayHandler = new GameUI.ResultsDisplayHandler(masterDomain:  this._masterDomain, dialogHandler_Results:  val_6, winSequences:  this.rewardsDisplayWin, loseSequences:  this.rewardsDisplayLoss);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AudioPlayerReady(Game.Audio.IAudioPlayer audioPlayer)
        {
            this._audioPlayer = audioPlayer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            int val_6;
            string val_7;
            if(this.useOldSequence != false)
            {
                    this.resultsDisplayHandler.DispatchResults();
                return;
            }
            
            if(this._masterDomain == 0)
            {
                goto label_5;
            }
            
            GameUI.Domain val_2 = this._masterDomain.gameUIDomain;
            GameUI.WorkshopSlotDataModel val_3 = val_2.gameUIData.workshopSlotDataModel;
            val_6 = val_3.selectedWorkshopSlotDataIndex;
            if(val_6 != 0)
            {
                goto label_10;
            }
            
            goto label_10;
            label_5:
            Game.AttackSequence.Encounters.EncounterResult val_4 = null;
            val_6 = val_4;
            val_4 = new Game.AttackSequence.Encounters.EncounterResult();
            if(val_6 != null)
            {
                    .EncounterType = 0;
                .PlayerDidWin = false;
                val_7 = "???";
                .AnimatronicAudioId = val_7;
                .EntityId = val_7;
                .CpuId = val_7;
            }
            else
            {
                    mem[16] = 0;
                mem[56] = 0;
                mem[48] = "???";
                mem[32] = "???";
                mem[24] = "???";
                val_7 = "???";
            }
            
            .PlushSuitId = val_7;
            label_10:
            if((Game.AttackSequence.Encounters.EncounterResult)[1152921524942089344].EncounterType == 1)
            {
                    this.dialogHandler_Results.ShowResultsTutorialEnd();
                this.tutorialEndUIView.StartTutorialEndSequence(audioPlayer:  this._audioPlayer);
                return;
            }
            
            if(this.dialogHandler_Results == null)
            {
                goto label_16;
            }
            
            if((Game.AttackSequence.Encounters.EncounterResult)[1152921524942089344].PlayerDidWin == false)
            {
                goto label_17;
            }
            
            label_19:
            this.dialogHandler_Results.ShowResultsPlayerWin();
            bool val_5 = ((Game.AttackSequence.Encounters.EncounterResult)[1152921524942089344].EncounterType != 2) ? 1 : 0;
            this.playerWinUIView.StartPlayerWinSequence(audioPlayer:  this._audioPlayer, allowShortcut:  val_5, allowAds:  val_5);
            return;
            label_16:
            if((Game.AttackSequence.Encounters.EncounterResult)[1152921524942089344].PlayerDidWin == true)
            {
                goto label_19;
            }
            
            label_17:
            this.dialogHandler_Results.ShowResultsPlayerLose();
            this.playerLoseUIView.StartPlayerLoseSequence(audioPlayer:  this._audioPlayer);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(this.useOldSequence == false)
            {
                    return;
            }
            
            this.resultsDisplayHandler.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            if((this._masterDomain != 0) && (this._masterDomain.eventExposer != null))
            {
                    this._masterDomain.eventExposer.OnRewardDialogClosed();
            }
            
            if(this.useOldSequence == false)
            {
                    return;
            }
            
            this = this.resultsDisplayHandler;
            if(this.resultsDisplayHandler.rewardsSequencer != null)
            {
                    this.resultsDisplayHandler.rewardsSequencer.OnDestroy();
            }
            
            this.resultsDisplayHandler.rewardsSequencer = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ResultsUIView()
        {
        
        }
    
    }

}
