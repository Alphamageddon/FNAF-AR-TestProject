using UnityEngine;

namespace Facebook.Unity.Example
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal sealed class MainMenu : MenuBase
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool ShowBackButton()
        {
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void GetGui()
        {
            var val_47;
            var val_48;
            IntPtr val_49;
            UnityEngine.GUILayout.BeginVertical(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            bool val_2 = UnityEngine.GUI.enabled;
            if((this.Button(label:  "FB.Init")) != false)
            {
                    Facebook.Unity.FB.Init(onInitComplete:  new Facebook.Unity.InitDelegate(object:  this, method:  System.Void Facebook.Unity.Example.MainMenu::OnInitComplete()), onHideUnity:  new Facebook.Unity.HideUnityDelegate(object:  this, method:  System.Void Facebook.Unity.Example.MainMenu::OnHideUnity(bool isGameShown)), authResponse:  0);
                mem[1152921520107805416] = "FB.Init() called with " + Facebook.Unity.FB.AppId;
            }
            
            UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            if(val_2 != false)
            {
                    val_47 = Facebook.Unity.FB.IsInitialized;
            }
            else
            {
                    val_47 = 0;
            }
            
            UnityEngine.GUI.enabled = false;
            if((this.Button(label:  "Login")) != false)
            {
                    this.CallFBLogin();
                mem[1152921520107805416] = "Login called";
            }
            
            UnityEngine.GUI.enabled = Facebook.Unity.FB.IsLoggedIn;
            if((this.Button(label:  "Get publish_actions")) != false)
            {
                    this.CallFBLoginForPublish();
                mem[1152921520107805416] = "Login (for publish_actions) called";
            }
            
            val_48 = null;
            val_48 = null;
            UnityEngine.GUILayoutOption[] val_14 = new UnityEngine.GUILayoutOption[1];
            val_14[0] = UnityEngine.GUILayout.MinWidth(minWidth:  (Facebook.Unity.Constants.IsMobile != true) ? 0f : 48f);
            UnityEngine.GUILayout.Label(content:  UnityEngine.GUIContent.none, options:  val_14);
            UnityEngine.GUILayout.EndHorizontal();
            UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayoutOption[] val_19 = new UnityEngine.GUILayoutOption[1];
            val_19[0] = UnityEngine.GUILayout.MinWidth(minWidth:  (Facebook.Unity.Constants.IsMobile != true) ? 0f : 48f);
            UnityEngine.GUILayout.Label(content:  UnityEngine.GUIContent.none, options:  val_19);
            UnityEngine.GUILayout.EndHorizontal();
            bool val_23 = this.Button(label:  "Logout");
            if(val_23 != false)
            {
                    val_23.CallFBLogout();
                mem[1152921520107805416] = "Logout called";
            }
            
            if(val_2 != false)
            {
                    val_49 = Facebook.Unity.FB.IsInitialized;
            }
            else
            {
                    val_49 = 0;
            }
            
            UnityEngine.GUI.enabled = false;
            if((this.Button(label:  "Share Dialog")) != false)
            {
                    val_49 = null;
                this.SwitchMenu(menuClass:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_49}));
            }
            
            if((this.Button(label:  "App Requests")) != false)
            {
                    val_49 = null;
                this.SwitchMenu(menuClass:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_49}));
            }
            
            if((this.Button(label:  "Graph Request")) != false)
            {
                    val_49 = null;
                this.SwitchMenu(menuClass:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_49}));
            }
            
            if(Facebook.Unity.Constants.IsWeb != false)
            {
                    if((this.Button(label:  "Pay")) != false)
            {
                    val_49 = null;
                this.SwitchMenu(menuClass:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_49}));
            }
            
            }
            
            if((this.Button(label:  "App Events")) != false)
            {
                    val_49 = null;
                this.SwitchMenu(menuClass:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_49}));
            }
            
            if((this.Button(label:  "App Links")) != false)
            {
                    val_49 = null;
                this.SwitchMenu(menuClass:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_49}));
            }
            
            if(Facebook.Unity.Constants.IsMobile != false)
            {
                    if((this.Button(label:  "App Invites")) != false)
            {
                    val_49 = null;
                this.SwitchMenu(menuClass:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_49}));
            }
            
            }
            
            if(Facebook.Unity.Constants.IsMobile != false)
            {
                    if((this.Button(label:  "Access Token")) != false)
            {
                    val_49 = null;
                this.SwitchMenu(menuClass:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_49}));
            }
            
            }
            
            UnityEngine.GUILayout.EndVertical();
            UnityEngine.GUI.enabled = val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CallFBLogin()
        {
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            if(val_1 != null)
            {
                    val_1.Add(item:  "public_profile");
            }
            else
            {
                    val_1.Add(item:  "public_profile");
            }
            
            val_1.Add(item:  "email");
            val_1.Add(item:  "user_friends");
            Facebook.Unity.FB.LogInWithReadPermissions(permissions:  val_1, callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CallFBLoginForPublish()
        {
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            val_1.Add(item:  "publish_actions");
            Facebook.Unity.FB.LogInWithPublishPermissions(permissions:  val_1, callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CallFBLogout()
        {
            Facebook.Unity.FB.LogOut();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnInitComplete()
        {
            string val_8;
            mem[1152921520108483560] = "Success - Check log for details";
            mem[1152921520108483568] = "Success Response: OnInitComplete Called\n";
            val_8 = System.String.Format(format:  "OnInitCompleteCalled IsLoggedIn=\'{0}\' IsInitialized=\'{1}\'", arg0:  Facebook.Unity.FB.IsLoggedIn, arg1:  Facebook.Unity.FB.IsInitialized);
            Facebook.Unity.Example.LogView.AddLog(log:  val_8);
            if(Facebook.Unity.AccessToken.CurrentAccessToken == null)
            {
                    return;
            }
            
            val_8 = Facebook.Unity.AccessToken.CurrentAccessToken;
            Facebook.Unity.Example.LogView.AddLog(log:  val_8);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnHideUnity(bool isGameShown)
        {
            bool val_1 = isGameShown;
            mem[1152921520108632696] = "Success - Check log for details";
            mem[1152921520108632704] = System.String.Format(format:  "Success Response: OnHideUnity Called {0}\n", arg0:  val_1);
            Facebook.Unity.Example.LogView.AddLog(log:  "Is game shown: "("Is game shown: ") + val_1.ToString());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MainMenu()
        {
        
        }
    
    }

}
