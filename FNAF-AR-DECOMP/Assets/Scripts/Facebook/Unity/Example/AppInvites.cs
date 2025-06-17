using UnityEngine;

namespace Facebook.Unity.Example
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class AppInvites : MenuBase
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void GetGui()
        {
            Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppInviteResult> val_15;
            if((this.Button(label:  "Android Invite")) != false)
            {
                    mem[1152921520103904936] = "Logged FB.AppEvent";
                Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppInviteResult> val_3 = null;
                val_15 = val_3;
                val_3 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppInviteResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result));
                FB.Mobile.AppInvite(appLinkUrl:  new System.Uri(uriString:  "https://fb.me/892708710750483"), previewImageUrl:  0, callback:  val_3);
            }
            
            if((this.Button(label:  "Android Invite With Custom Image")) != false)
            {
                    mem[1152921520103904936] = "Logged FB.AppEvent";
                System.Uri val_6 = null;
                val_15 = val_6;
                val_6 = new System.Uri(uriString:  "http://i.imgur.com/zkYlB.jpg");
                FB.Mobile.AppInvite(appLinkUrl:  new System.Uri(uriString:  "https://fb.me/892708710750483"), previewImageUrl:  val_6, callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppInviteResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)));
            }
            
            if((this.Button(label:  "iOS Invite")) != false)
            {
                    mem[1152921520103904936] = "Logged FB.AppEvent";
                Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppInviteResult> val_10 = null;
                val_15 = val_10;
                val_10 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppInviteResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result));
                FB.Mobile.AppInvite(appLinkUrl:  new System.Uri(uriString:  "https://fb.me/810530068992919"), previewImageUrl:  0, callback:  val_10);
            }
            
            if((this.Button(label:  "iOS Invite With Custom Image")) == false)
            {
                    return;
            }
            
            mem[1152921520103904936] = "Logged FB.AppEvent";
            FB.Mobile.AppInvite(appLinkUrl:  new System.Uri(uriString:  "https://fb.me/810530068992919"), previewImageUrl:  new System.Uri(uriString:  "http://i.imgur.com/zkYlB.jpg"), callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppInviteResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AppInvites()
        {
        
        }
    
    }

}
