using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class LowBatteryDetector
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ShouldCharge(Game.AttackSequence.Animatronic.PhaseManagement.IBlackboardPhaseAccess blackboard)
        {
            Game.CameraEquipment.Battery.IBattery val_7;
            var val_10;
            var val_15 = 0;
            val_15 = val_15 + 1;
            if(blackboard.Systems == null)
            {
                    return (bool)0 & 1;
            }
            
            val_7 = val_2.Battery;
            if(val_7 == null)
            {
                    return (bool)0 & 1;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_10 = blackboard.AttackProfile;
            if(val_4.EncounterType != 0)
            {
                    return (bool)0 & 1;
            }
            
            val_10 = 1152921505274736640;
            var val_17 = 0;
            val_17 = val_17 + 1;
            var val_18 = 0;
            val_18 = val_18 + 1;
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_8 = blackboard.AttackProfile;
            if(val_7.Charge >= 0)
            {
                    return (bool)0 & 1;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            if(val_7.IsExtraBatteryAvailableForUse() != false)
            {
                    return (bool)0 & 1;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            bool val_14 = val_7.IsExtraBatteryActive() ^ 1;
            return (bool)0 & 1;
        }
    
    }

}
