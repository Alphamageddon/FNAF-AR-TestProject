using UnityEngine;

namespace Game.CameraEquipment.Shocker
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IShocker
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float GetTotalMissCooldownTime(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float GetTotalHitCooldownTime(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Game.CameraEquipment.Shocker.ShockerStatus GetStatus(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float GetRemainingCooldownTime(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float GetCooldownPercent(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Activate(bool didHitAnimatronic, bool isDisruptionFullyActive); // 0
    
    }

}
