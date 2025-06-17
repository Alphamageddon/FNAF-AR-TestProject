using UnityEngine;

namespace Game.CameraEquipment.Flashlight
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IFlashlight
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsOn { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_IsOn(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float GetCooldownPercent(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool CanTurnOn(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool HasEnoughBatteryToActivate(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void TriedToTurnOn(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetFlashlightState(bool setOn, bool shouldPlayAudio); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetFlashlightCooldown(float cooldown); // 0
    
    }

}
