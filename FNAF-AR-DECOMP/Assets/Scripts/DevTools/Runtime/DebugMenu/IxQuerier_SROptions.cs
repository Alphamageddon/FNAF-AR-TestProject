using UnityEngine;

namespace DevTools.Runtime.DebugMenu
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxQuerier_SROptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string CategoryName = "IxQuerier for permissions (iOS only)";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void QueryPushNotifAuthorization()
        {
            SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.add_PushNotificationStatusEvent(value:  new IxQuerier_iOS.PushNotificationStatus(object:  this, method:  System.Void DevTools.Runtime.DebugMenu.IxQuerier_SROptions::IxQuerier_IOsOnPushNotificationStatusEvent(bool isAuthorized)));
            SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.QueryRemotePushNotificationEnabled();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IxQuerier_IOsOnPushNotificationStatusEvent(bool isAuthorized)
        {
            ConsoleLogger.LogError(className:  "IxQuerier_SROptions", functionName:  "IxQuerier_IOsOnPushNotificationStatusEvent", logString:  "Push notifs authorized: "("Push notifs authorized: ") + (isAuthorized != true) ? "true" : "false"((isAuthorized != true) ? "true" : "false"));
            SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.remove_PushNotificationStatusEvent(value:  new IxQuerier_iOS.PushNotificationStatus(object:  this, method:  System.Void DevTools.Runtime.DebugMenu.IxQuerier_SROptions::IxQuerier_IOsOnPushNotificationStatusEvent(bool isAuthorized)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxQuerier_SROptions()
        {
        
        }
    
    }

}
