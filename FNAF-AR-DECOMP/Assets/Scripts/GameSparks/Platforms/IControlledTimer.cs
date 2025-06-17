using UnityEngine;

namespace GameSparks.Platforms
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IControlledTimer : IGameSparksTimer
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Update(long ticks); // 0
    
    }

}
