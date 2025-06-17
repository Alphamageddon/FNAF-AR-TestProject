using UnityEngine;

namespace Game.Server.Requester
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AndroidPushNotificationAdapter : IPushNotificationAdapter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string _pushToken;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup()
        {
            this.InitializeToken();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RegisterForPushNotifications()
        {
            bool val_1 = this.IsTokenInitialized();
            if(val_1 != false)
            {
                    PlayFab.PlayFabClientAPI.AndroidDevicePushNotificationRegistration(request:  val_1.BuildPushRequest(), resultCallback:  new System.Action<PlayFab.ClientModels.AndroidDevicePushNotificationRegistrationResult>(object:  this, method:  System.Void Game.Server.Requester.AndroidPushNotificationAdapter::OnSuccess(PlayFab.ClientModels.AndroidDevicePushNotificationRegistrationResult result)), errorCallback:  new System.Action<PlayFab.PlayFabError>(object:  this, method:  System.Void Game.Server.Requester.AndroidPushNotificationAdapter::OnFail(PlayFab.PlayFabError error)), customData:  0, extraHeaders:  0);
                return;
            }
            
            ConsoleLogger.LogError(className:  "AndroidPushNotificationAdapter", functionName:  "RegisterForPushNotifications", logString:  "Attempted to register for push notifications but token no initialized");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.ClientModels.AndroidDevicePushNotificationRegistrationRequest BuildPushRequest()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            mem[1152921525206048608] = Game.Server.ServerDomain.AuthContext;
            val_3 = null;
            val_3 = null;
            .DeviceToken = Game.Server.Requester.AndroidPushNotificationAdapter._pushToken;
            .SendPushNotificationConfirmation = 0;
            .ConfirmationMessage = "Push notifications registered successfully";
            return (PlayFab.ClientModels.AndroidDevicePushNotificationRegistrationRequest)new PlayFab.ClientModels.AndroidDevicePushNotificationRegistrationRequest();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnSuccess(PlayFab.ClientModels.AndroidDevicePushNotificationRegistrationResult result)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnFail(PlayFab.PlayFabError error)
        {
            ConsoleLogger.LogError(className:  "FirebaseNotificationsInitializer", functionName:  "OnPfFail", logString:  error.GenerateErrorReport());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InitializeToken()
        {
            System.Threading.Tasks.Task val_3 = Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(continuationAction:  new System.Action<System.Threading.Tasks.Task<Firebase.DependencyStatus>>(object:  this, method:  System.Void Game.Server.Requester.AndroidPushNotificationAdapter::OnAndroidDependencyCheck(System.Threading.Tasks.Task<Firebase.DependencyStatus> task)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnAndroidDependencyCheck(System.Threading.Tasks.Task<Firebase.DependencyStatus> task)
        {
            if(task.Result != 0)
            {
                    ConsoleLogger.LogError(className:  "FirebaseNotificationsInitializer", functionName:  "OnAndroidDependencyCheck", logString:  "Android dependency check fail");
                return;
            }
            
            Firebase.Messaging.FirebaseMessaging.add_TokenReceived(value:  new System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs>(object:  this, method:  System.Void Game.Server.Requester.AndroidPushNotificationAdapter::OnTokenReceived(object sender, Firebase.Messaging.TokenReceivedEventArgs args)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnTokenReceived(object sender, Firebase.Messaging.TokenReceivedEventArgs args)
        {
            var val_2 = null;
            Game.Server.Requester.AndroidPushNotificationAdapter._pushToken = args.Token;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsTokenInitialized()
        {
            null = null;
            bool val_1 = System.String.IsNullOrEmpty(value:  Game.Server.Requester.AndroidPushNotificationAdapter._pushToken);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AndroidPushNotificationAdapter()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AndroidPushNotificationAdapter()
        {
            Game.Server.Requester.AndroidPushNotificationAdapter._pushToken = System.String.alignConst;
        }
    
    }

}
