using UnityEngine;

namespace Facebook.Unity.Example
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class AccessTokenMenu : MenuBase
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void GetGui()
        {
            if((this.Button(label:  "Refresh Access Token")) == false)
            {
                    return;
            }
            
            FB.Mobile.RefreshCurrentAccessToken(callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AccessTokenMenu()
        {
        
        }
    
    }

}
