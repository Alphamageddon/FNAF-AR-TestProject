using UnityEngine;

namespace Game.AttackSequence.Animatronic
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AttackAnimatronicExternalSystems
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Camera Camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform CameraStableTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Encounters.Encounter Encounter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Static.AttackStatic AttackStatic;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.DisruptionMechanic.AttackDisruption AttackDisruption;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.SurgeMechanic.AttackSurge AttackSurge;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public HaywireFxController HaywireFxController;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ThreatLevelFxController ThreatLevelFxController;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.CameraEquipment.Battery.IBattery Battery;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.CameraEquipment.Flashlight.IFlashlight Flashlight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.CameraEquipment.Mask.IMask Mask;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.CameraEquipment.Shocker.IShocker Shocker;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AttackAnimatronicExternalSystems()
        {
        
        }
    
    }

}
