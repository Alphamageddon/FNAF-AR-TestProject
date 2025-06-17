using UnityEngine;

namespace Game.CameraEquipment.Battery
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IBattery
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float Charge { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int NumExtraBatteriesUsed { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float get_Charge(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int get_NumExtraBatteriesUsed(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsExtraBatteryAvailableForUse(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsExtraBatteryActive(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetExtraBatteryBlocker(bool isBlocked); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetBatteryDrain(string id, Game.ItemDefinition.Data.DataDefinitions.BatteryData drainSettings); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RemoveBatteryDrain(string id); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void DrainCharge(float drainAmount); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RestoreCharge(float restoreAmount); // 0
    
    }

}
