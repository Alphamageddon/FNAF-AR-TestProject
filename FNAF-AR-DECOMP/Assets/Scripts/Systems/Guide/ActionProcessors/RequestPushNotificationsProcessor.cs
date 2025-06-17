using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RequestPushNotificationsProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartAction(Systems.Guide.GuideActionSharedContext context)
        {
            if((UnityEngine.PlayerPrefs.GetInt(key:  "PushNotificationPermissionAsked", defaultValue:  0)) > 2)
            {
                    return;
            }
            
            context._pushNotificationsInitializer.ShowPushRationaleDialogBeforeEnable();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RequestPushNotificationsProcessor()
        {
        
        }
    
    }

}
