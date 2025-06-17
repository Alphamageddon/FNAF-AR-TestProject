using UnityEngine;

namespace Master.Startup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PushNotificationsStartupTask : IStartupTask
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Startup.StartupSequencer _parent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Server.LoginDomain _loginDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Startup.PushNotificationsStartupTask Setup(Server.LoginDomain loginDomain)
        {
            this._loginDomain = loginDomain;
            return (Master.Startup.PushNotificationsStartupTask)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute(Master.Startup.StartupSequencer parent)
        {
            this._parent = parent;
            if((UnityEngine.PlayerPrefs.GetInt(key:  "PushNotificationPermissionAsked", defaultValue:  0)) >= 1)
            {
                    this._loginDomain.pushNotificationsInitializer.RegisterForPushNotifications();
            }
            
            this._parent.CompleteTask(task:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._parent = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetSize()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetName()
        {
            return "InitializeUTNotifications";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetPartialProgress()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PushNotificationsStartupTask()
        {
        
        }
    
    }

}
