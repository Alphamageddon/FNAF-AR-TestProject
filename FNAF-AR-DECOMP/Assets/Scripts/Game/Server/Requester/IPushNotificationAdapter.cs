using UnityEngine;

namespace Game.Server.Requester
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IPushNotificationAdapter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Setup(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RegisterForPushNotifications(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Update(); // 0
    
    }

}
