using UnityEngine;

namespace Facebook.Unity.Example
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class AppLinks : MenuBase
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void GetGui()
        {
            if((this.Button(label:  "Get App Link")) != false)
            {
                    Facebook.Unity.FB.GetAppLink(callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)));
            }
            
            if(Facebook.Unity.Constants.IsMobile == false)
            {
                    return;
            }
            
            if((this.Button(label:  "Fetch Deferred App Link")) == false)
            {
                    return;
            }
            
            FB.Mobile.FetchDeferredAppLinkData(callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AppLinks()
        {
        
        }
    
    }

}
