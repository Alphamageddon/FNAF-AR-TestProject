using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ResultSequencer : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ResultStepConfig[] _sequenceSteps;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.GameAssetManagementDomain _gameAssetManagementDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.AssetBundleRequirementModule _assetBundleRequirementModule;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Queue<GameUI.BaseResultStep> _remainingSteps;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<GameUI.BaseResultStep> _activeSteps;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.IAudioPlayer _audioPlayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _animatronicAudioId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _started;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _finished;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.BaseResultStep.ConditionalSettings _conditionalSettings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.BaseResultStep.StartupSettings _startupSettings;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StartSequence(Master.EventExposer masterEventExposer, Game.AssetManagement.GameAssetManagementDomain gameAssetManagementDomain, TheGame.AssetBundleRequirementModule assetBundleRequirementModule, Game.Audio.IAudioPlayer audioPlayer, string animatronicAudioId, GameUI.BaseResultStep.ConditionalSettings conditionalSettings)
        {
            this._masterEventExposer = masterEventExposer;
            this._gameAssetManagementDomain = gameAssetManagementDomain;
            this._assetBundleRequirementModule = assetBundleRequirementModule;
            this.GenerateStepQueue();
            this._audioPlayer = audioPlayer;
            this._animatronicAudioId = animatronicAudioId;
            this._conditionalSettings = conditionalSettings;
            this._started = true;
            this._finished = false;
            BaseResultStep.StartupSettings val_1 = new BaseResultStep.StartupSettings();
            float val_2 = UnityEngine.Time.time;
            if(val_1 != null)
            {
                    .LastStepStartTime = val_2;
                .EarliestActiveEndTime = -1f;
            }
            else
            {
                    mem[16] = val_2;
                .EarliestActiveEndTime = -1f;
            }
            
            .AllCompleteTime = -1f;
            this._startupSettings = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateStepQueue()
        {
            this._remainingSteps.Clear();
            this._activeSteps.Clear();
            if(this._sequenceSteps.Length < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            do
            {
                GameUI.BaseResultStep val_2 = this.CreateStep(config:  this._sequenceSteps[val_4]);
                if(val_2 != null)
            {
                    this._remainingSteps.Enqueue(item:  val_2);
            }
            
                val_4 = val_4 + 1;
            }
            while((this._sequenceSteps.Length & 4294967295) != val_4);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.BaseResultStep CreateStep(GameUI.ResultStepConfig config)
        {
            var val_6;
            if(config.executionType <= 5)
            {
                    var val_6 = 52945980 + (config.executionType) << 2;
                val_6 = val_6 + 52945980;
            }
            else
            {
                    val_6 = 0;
                return (GameUI.BaseResultStep);
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(this._started == false)
            {
                    return;
            }
            
            if(this._finished != false)
            {
                    return;
            }
            
            this.StartNewSteps();
            this.CheckForStepCompletion();
            this.CheckForSequenceCompletion();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartNewSteps()
        {
            BaseResultStep.ConditionalSettings val_8;
            goto label_6;
            label_16:
            GameUI.BaseResultStep val_1 = this._remainingSteps.Peek();
            val_8 = this._conditionalSettings;
            if((val_1.ShouldSkipStep(settings:  val_8)) != false)
            {
                    GameUI.BaseResultStep val_3 = this._remainingSteps.Dequeue();
            }
            else
            {
                    val_8 = this._startupSettings;
                if((val_1.ShouldStartStep(settings:  val_8)) == false)
            {
                    return;
            }
            
                this._startupSettings.LastStepStartTime = UnityEngine.Time.time;
                this._startupSettings.EarliestActiveEndTime = -1f;
                this._startupSettings.AllCompleteTime = -1f;
                this._activeSteps.Add(item:  this._remainingSteps.Dequeue());
                val_8 = this._audioPlayer;
                val_1.Start(audioPlayer:  val_8, animatronicAudioId:  this._animatronicAudioId);
            }
            
            label_6:
            if(this._remainingSteps.Count > 0)
            {
                goto label_16;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CheckForStepCompletion()
        {
            BaseResultStep.StartupSettings val_9;
            BaseResultStep.StartupSettings val_10;
            GameUI.BaseResultStep val_11;
            val_9 = this;
            System.Collections.Generic.List<GameUI.BaseResultStep> val_9 = this._activeSteps;
            val_9 = val_9.Count - 1;
            if((val_9 & 2147483648) == 0)
            {
                    do
            {
                val_10 = this._activeSteps.Item[val_9];
                if((val_10 & 1) != 0)
            {
                    if(this._activeSteps != null)
            {
                    val_11 = this._activeSteps.Item[val_9];
            }
            else
            {
                    val_11 = 0.Item[val_9];
            }
            
                bool val_5 = this._activeSteps.Remove(item:  val_11);
                val_10 = this._startupSettings;
                if(this._startupSettings.EarliestActiveEndTime < 0)
            {
                    val_10 = this._startupSettings;
                this._startupSettings.EarliestActiveEndTime = UnityEngine.Time.time;
            }
            
            }
            
                val_9 = val_9 - 1;
            }
            while((val_9 & 2147483648) == 0);
            
            }
            
            if(this._startupSettings.AllCompleteTime >= 0)
            {
                    return;
            }
            
            if(this._activeSteps.Count != 0)
            {
                    return;
            }
            
            val_9 = this._startupSettings;
            this._startupSettings.AllCompleteTime = UnityEngine.Time.time;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CheckForSequenceCompletion()
        {
            if(this._remainingSteps.Count != 0)
            {
                    return;
            }
            
            if(this._activeSteps.Count != 0)
            {
                    return;
            }
            
            this._finished = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ResultSequencer()
        {
            this._remainingSteps = new System.Collections.Generic.Queue<GameUI.BaseResultStep>();
            this._activeSteps = new System.Collections.Generic.List<GameUI.BaseResultStep>();
        }
    
    }

}
