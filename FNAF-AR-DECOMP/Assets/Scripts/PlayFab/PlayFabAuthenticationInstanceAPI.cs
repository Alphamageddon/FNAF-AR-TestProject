using UnityEngine;

namespace PlayFab
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayFabAuthenticationInstanceAPI : IPlayFabInstanceApi
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly PlayFab.PlayFabApiSettings apiSettings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly PlayFab.PlayFabAuthenticationContext authenticationContext;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabAuthenticationInstanceAPI()
        {
            this.authenticationContext = new PlayFab.PlayFabAuthenticationContext();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabAuthenticationInstanceAPI(PlayFab.PlayFabApiSettings settings)
        {
            this.apiSettings = settings;
            this.authenticationContext = new PlayFab.PlayFabAuthenticationContext();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabAuthenticationInstanceAPI(PlayFab.PlayFabAuthenticationContext context)
        {
            if(context == null)
            {
                goto label_1;
            }
            
            label_4:
            this.authenticationContext = context;
            return;
            label_1:
            PlayFab.PlayFabAuthenticationContext val_1 = new PlayFab.PlayFabAuthenticationContext();
            if(this != null)
            {
                goto label_4;
            }
            
            goto label_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabAuthenticationInstanceAPI(PlayFab.PlayFabApiSettings settings, PlayFab.PlayFabAuthenticationContext context)
        {
            PlayFab.PlayFabAuthenticationContext val_3 = val_1;
            val_1 = new System.Object();
            this.apiSettings = settings;
            if(val_3 == null)
            {
                    PlayFab.PlayFabAuthenticationContext val_2 = null;
                val_3 = val_2;
                val_2 = new PlayFab.PlayFabAuthenticationContext();
            }
            
            this.authenticationContext = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsEntityLoggedIn()
        {
            PlayFab.PlayFabAuthenticationContext val_3 = this.authenticationContext;
            if(val_3 != null)
            {
                    bool val_1 = System.String.IsNullOrEmpty(value:  this.authenticationContext.EntityToken);
                val_3 = val_1 ^ 1;
            }
            
            val_1 = val_3;
            return (bool)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ForgetAllCredentials()
        {
            if(this.authenticationContext == null)
            {
                    return;
            }
            
            this.authenticationContext.EntityType = 0;
            this.authenticationContext.ClientSessionTicket = 0;
            this.authenticationContext.EntityToken = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetEntityToken(PlayFab.AuthenticationModels.GetEntityTokenRequest request, System.Action<PlayFab.AuthenticationModels.GetEntityTokenResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_4;
            PlayFab.PlayFabApiSettings val_5;
            var val_7;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = this.authenticationContext;
            label_2:
            val_5 = this.apiSettings;
            if(val_5 == null)
            {
                goto label_3;
            }
            
            if(val_4 == null)
            {
                goto label_4;
            }
            
            label_8:
            var val_1 = (this.authenticationContext.ClientSessionTicket == null) ? 0 : 2;
            goto label_5;
            label_3:
            val_7 = null;
            val_7 = null;
            val_5 = PlayFab.PlayFabSettings.staticSettings;
            if(val_4 != null)
            {
                goto label_8;
            }
            
            label_4:
            label_5:
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.AuthenticationModels.GetEntityTokenResponse>(apiEndpoint:  "/Authentication/GetEntityToken", request:  request, authType:  (this.authenticationContext.EntityToken == null) ? ((11993091 == 0) ? 0 : 2) : 4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_4, apiSettings:  val_5, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ValidateEntityToken(PlayFab.AuthenticationModels.ValidateEntityTokenRequest request, System.Action<PlayFab.AuthenticationModels.ValidateEntityTokenResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_1;
            PlayFab.PlayFabApiSettings val_2;
            var val_3;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_1 = this.authenticationContext;
            label_2:
            val_2 = this.apiSettings;
            if(val_2 == null)
            {
                    val_3 = null;
                val_3 = null;
                val_2 = PlayFab.PlayFabSettings.staticSettings;
            }
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.AuthenticationModels.ValidateEntityTokenResponse>(apiEndpoint:  "/Authentication/ValidateEntityToken", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
    
    }

}
