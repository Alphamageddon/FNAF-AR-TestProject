using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class BaseResultStep
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected readonly GameUI.ResultStepConfig Config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HasStarted>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool HasStarted { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool get_HasStarted()
        {
            return (bool)this.<HasStarted>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HasStarted(bool value)
        {
            this.<HasStarted>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected BaseResultStep(GameUI.ResultStepConfig config)
        {
            this.Config = config;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsComplete(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract void StartStep(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShouldSkipStep(GameUI.BaseResultStep.ConditionalSettings settings)
        {
            var val_10;
            if(this.Config.executionCondition <= 12)
            {
                    var val_10 = 52946092 + (this.Config.executionCondition) << 2;
                val_10 = val_10 + 52946092;
            }
            else
            {
                    val_10 = 1;
                return (bool)( == true) ? 1 : 0;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShouldStartStep(GameUI.BaseResultStep.StartupSettings settings)
        {
            GameUI.ResultStepConfig val_5;
            float val_6;
            float val_7;
            var val_8;
            val_5 = this;
            if(this.Config.startMode == 2)
            {
                goto label_1;
            }
            
            if(this.Config.startMode != 1)
            {
                goto label_2;
            }
            
            val_6 = settings.LastStepStartTime;
            if(val_6 < 0f)
            {
                goto label_4;
            }
            
            float val_1 = UnityEngine.Time.time;
            val_5 = this.Config;
            val_7 = settings.LastStepStartTime;
            return (bool)((UnityEngine.Time.time - val_7) >= this.Config.delay) ? 1 : 0;
            label_1:
            val_6 = settings.AllCompleteTime;
            if(val_6 >= 0f)
            {
                goto label_7;
            }
            
            label_4:
            val_8 = 0;
            return (bool)((UnityEngine.Time.time - val_7) >= this.Config.delay) ? 1 : 0;
            label_2:
            val_8 = 1;
            return (bool)((UnityEngine.Time.time - val_7) >= this.Config.delay) ? 1 : 0;
            label_7:
            val_5 = this.Config;
            val_7 = settings.AllCompleteTime;
            return (bool)((UnityEngine.Time.time - val_7) >= this.Config.delay) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Start(Game.Audio.IAudioPlayer audioPlayer, string animatronicAudioId)
        {
            string val_3;
            this.<HasStarted>k__BackingField = true;
            val_3 = 0;
            if((audioPlayer != null) && ((System.String.IsNullOrWhiteSpace(value:  this.Config.audioEventName)) != true))
            {
                    var val_3 = 0;
                val_3 = val_3 + 1;
                val_3 = this.Config.audioEventName;
                audioPlayer.RaiseGameEventForModeWithOverrideByName(name:  val_3, overridePrefix:  animatronicAudioId, mode:  2);
            }
        
        }
    
    }

}
