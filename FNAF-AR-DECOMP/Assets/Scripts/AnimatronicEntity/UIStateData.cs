using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UIStateData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.UIStateData.AnimatronicDisplayState <displayState>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.UIStateData.AnimatronicDisplayState displayState { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.UIStateData.AnimatronicDisplayState get_displayState()
        {
            return (AnimatronicDisplayState)this.<displayState>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_displayState(AnimatronicEntity.UIStateData.AnimatronicDisplayState value)
        {
            this.<displayState>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UIStateData()
        {
            this.<displayState>k__BackingField = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UIStateData(AnimatronicEntity.UIStateData stateData)
        {
            this.<displayState>k__BackingField = stateData.<displayState>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UIStateData(AnimatronicEntity.UIStateData.AnimatronicDisplayState animatronicState)
        {
            this.<displayState>k__BackingField = animatronicState;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            long val_2 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = this.<displayState>k__BackingField});
            return (string)this.<displayState>k__BackingField.ToString();
        }
    
    }

}
