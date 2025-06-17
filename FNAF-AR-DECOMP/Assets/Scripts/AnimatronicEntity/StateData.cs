using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class StateData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.StateData.AnimatronicState <animatronicState>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <expressDelivery>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AnimatronicEntity.StateData.AnimatronicState[] beforeAttackStates;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AnimatronicEntity.StateData.AnimatronicState[] afterStalkingStates;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.StateData.AnimatronicState animatronicState { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool expressDelivery { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.StateData.AnimatronicState get_animatronicState()
        {
            return (AnimatronicState)this.<animatronicState>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_animatronicState(AnimatronicEntity.StateData.AnimatronicState value)
        {
            this.<animatronicState>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_expressDelivery()
        {
            return (bool)this.<expressDelivery>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_expressDelivery(bool value)
        {
            this.<expressDelivery>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsInState(AnimatronicEntity.StateData.AnimatronicState sourceState, AnimatronicEntity.StateData.AnimatronicState stateToCheck)
        {
            return (bool)(sourceState == stateToCheck) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsInStates(AnimatronicEntity.StateData.AnimatronicState sourceState, AnimatronicEntity.StateData.AnimatronicState[] statesToCheck)
        {
            var val_1;
            var val_2;
            val_1 = 0;
            label_3:
            if(val_1 >= statesToCheck.Length)
            {
                goto label_1;
            }
            
            val_1 = val_1 + 1;
            if(statesToCheck[0] != sourceState)
            {
                goto label_3;
            }
            
            val_2 = 1;
            return (bool)val_2;
            label_1:
            val_2 = 0;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsBeforeAttack(AnimatronicEntity.StateData.AnimatronicState sourceState)
        {
            null = null;
            return AnimatronicEntity.StateData.IsInStates(sourceState:  sourceState, statesToCheck:  AnimatronicEntity.StateData.beforeAttackStates);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsAfterStalking(AnimatronicEntity.StateData.AnimatronicState sourceState)
        {
            null = null;
            return AnimatronicEntity.StateData.IsInStates(sourceState:  sourceState, statesToCheck:  AnimatronicEntity.StateData.afterStalkingStates);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StateData()
        {
            this.<animatronicState>k__BackingField = 0;
            this.<expressDelivery>k__BackingField = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StateData(AnimatronicEntity.StateData stateData)
        {
            if(stateData != null)
            {
                    this.<animatronicState>k__BackingField = stateData.<animatronicState>k__BackingField;
            }
            else
            {
                    this.<animatronicState>k__BackingField = 11993091;
            }
            
            this.<expressDelivery>k__BackingField = stateData.<expressDelivery>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StateData(AnimatronicEntity.StateData.AnimatronicState animatronicState, bool expressDelivery)
        {
            this.<animatronicState>k__BackingField = animatronicState;
            this.<expressDelivery>k__BackingField = expressDelivery;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            long val_2 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = this.<animatronicState>k__BackingField});
            return (string)this.<animatronicState>k__BackingField.ToString();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static StateData()
        {
            int val_3;
            int val_4;
            AnimatronicState[] val_1 = new AnimatronicState[3];
            val_3 = val_1.Length;
            if(val_3 <= 1)
            {
                    val_3 = val_1.Length;
            }
            
            val_1[0] = 1;
            val_1[1] = 2;
            AnimatronicEntity.StateData.beforeAttackStates = val_1;
            AnimatronicState[] val_2 = new AnimatronicState[2];
            val_4 = val_2.Length;
            if(val_4 == 0)
            {
                    val_4 = val_2.Length;
            }
            
            val_2[0] = 2;
            val_2[0] = 3;
            AnimatronicEntity.StateData.afterStalkingStates = val_2;
        }
    
    }

}
