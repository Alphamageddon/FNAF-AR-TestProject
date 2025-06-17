using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class OriginData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.OriginData.OriginState <originState>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.OriginData.OriginState originState { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.OriginData.OriginState get_originState()
        {
            return (OriginState)this.<originState>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_originState(AnimatronicEntity.OriginData.OriginState value)
        {
            this.<originState>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public OriginData()
        {
            this.<originState>k__BackingField = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public OriginData(AnimatronicEntity.OriginData originData)
        {
            this.<originState>k__BackingField = originData.<originState>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public OriginData(AnimatronicEntity.OriginData.OriginState originState)
        {
            this.<originState>k__BackingField = originState;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            long val_2 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = this.<originState>k__BackingField});
            return (string)this.<originState>k__BackingField.ToString();
        }
    
    }

}
