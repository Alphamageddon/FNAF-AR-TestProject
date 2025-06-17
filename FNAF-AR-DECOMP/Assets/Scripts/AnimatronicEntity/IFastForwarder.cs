using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IFastForwarder
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool HasCompleted { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract long FrameStartTime { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract long FrameEndTime { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_HasCompleted(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract long get_FrameStartTime(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract long get_FrameEndTime(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void AddTimeInCombat(float timeToAdd); // 0
    
    }

}
