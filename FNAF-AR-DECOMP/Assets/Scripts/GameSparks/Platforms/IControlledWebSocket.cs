using UnityEngine;

namespace GameSparks.Platforms
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IControlledWebSocket : IGameSparksWebSocket
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int SocketId { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void TriggerOnClose(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void TriggerOnOpen(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void TriggerOnError(string message); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void TriggerOnMessage(string message); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool Update(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int get_SocketId(); // 0
    
    }

}
