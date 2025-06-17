using UnityEngine;

namespace Game.CameraEquipment.Mask
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IMask
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsMaskAvailable { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_IsMaskAvailable(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsMaskFullyOn(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsMaskFullyOff(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsMaskInTransition(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetMaskAvailable(bool shouldMaskBeAvailable); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetDesiredMaskState(bool desiredMaskState); // 0
    
    }

}
