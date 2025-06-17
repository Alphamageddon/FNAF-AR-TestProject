using UnityEngine;

namespace Game.Server.Requester
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RegisterForPushNotificationsRequester : AbstractRequester
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.Requester.IPushNotificationAdapter _adapter;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RegisterForPushNotificationsRequester(Game.Server.LogEventHandler eventHandler)
        {
            this = new System.Object();
            mem[1152921525207700832] = eventHandler;
            Game.Server.Requester.AndroidPushNotificationAdapter val_2 = new Game.Server.Requester.AndroidPushNotificationAdapter();
            this._adapter = val_2;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_2.Setup();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RegisterForPushNotifications()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._adapter.RegisterForPushNotifications();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if(this._adapter == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._adapter.Update();
        }
    
    }

}
