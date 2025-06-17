using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class StalkingTimerData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.StalkingTimerData.Direction <direction>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <timeRemainingInitialized>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _timeRemaining;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <switchbackTimeRemaining>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.StalkingTimerData.Direction direction { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool timeRemainingInitialized { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float timeRemaining { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float switchbackTimeRemaining { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.StalkingTimerData.Direction get_direction()
        {
            return (Direction)this.<direction>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_direction(AnimatronicEntity.StalkingTimerData.Direction value)
        {
            this.<direction>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_timeRemainingInitialized()
        {
            return (bool)this.<timeRemainingInitialized>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_timeRemainingInitialized(bool value)
        {
            this.<timeRemainingInitialized>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_timeRemaining()
        {
            return (float)this._timeRemaining;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_timeRemaining(float value)
        {
            this._timeRemaining = value;
            this.<timeRemainingInitialized>k__BackingField = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_switchbackTimeRemaining()
        {
            return (float)this.<switchbackTimeRemaining>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_switchbackTimeRemaining(float value)
        {
            this.<switchbackTimeRemaining>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StalkingTimerData()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StalkingTimerData(AnimatronicEntity.StalkingTimerData stalkingTimerData)
        {
            bool val_1 = stalkingTimerData.<timeRemainingInitialized>k__BackingField;
            if(val_1 != false)
            {
                    this._timeRemaining = stalkingTimerData._timeRemaining;
                val_1 = stalkingTimerData.<timeRemainingInitialized>k__BackingField;
            }
            
            this.<timeRemainingInitialized>k__BackingField = val_1;
            this.<direction>k__BackingField = stalkingTimerData.<direction>k__BackingField;
            this.<switchbackTimeRemaining>k__BackingField = stalkingTimerData.<switchbackTimeRemaining>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StalkingTimerData(bool newTimeRemainingInitialized, AnimatronicEntity.StalkingTimerData.Direction newDirection, float newSwitchbackTimeRemaining, float newTimeRemaining)
        {
            if(newTimeRemainingInitialized != false)
            {
                    this._timeRemaining = newTimeRemaining;
            }
            
            this.<direction>k__BackingField = newDirection;
            this.<timeRemainingInitialized>k__BackingField = newTimeRemainingInitialized;
            this.<switchbackTimeRemaining>k__BackingField = newSwitchbackTimeRemaining;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            long val_2 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = this.<direction>k__BackingField});
            return (string)System.String.Format(format:  "[timeRemaining:{0}, Direction:{1}, SwitchbackTimeRemaining:{2}]", arg0:  this._timeRemaining, arg1:  this.<direction>k__BackingField.ToString(), arg2:  this.<switchbackTimeRemaining>k__BackingField);
        }
    
    }

}
