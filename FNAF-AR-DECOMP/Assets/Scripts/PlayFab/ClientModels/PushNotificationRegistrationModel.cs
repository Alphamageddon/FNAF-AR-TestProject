using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class PushNotificationRegistrationModel : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string NotificationEndpointARN;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.ClientModels.PushNotificationPlatform> Platform;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PushNotificationRegistrationModel()
        {
        
        }
    
    }

}
