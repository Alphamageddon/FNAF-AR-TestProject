using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class AndroidDevicePushNotificationRegistrationRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ConfirmationMessage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DeviceToken;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> SendPushNotificationConfirmation;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AndroidDevicePushNotificationRegistrationRequest()
        {
        
        }
    
    }

}
