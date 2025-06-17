using UnityEngine;

namespace GetSocialSdk.Ui
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ActionButtonListenerProxy : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<string, GetSocialSdk.Core.ActivityPost> _onButtonClicked;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ActionButtonListenerProxy(System.Action<string, GetSocialSdk.Core.ActivityPost> onButtonClicked)
        {
            this._onButtonClicked = onButtonClicked;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onButtonClicked(string action, UnityEngine.AndroidJavaObject post)
        {
            ActionButtonListenerProxy.<>c__DisplayClass2_0 val_1 = new ActionButtonListenerProxy.<>c__DisplayClass2_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .action = action;
            UnityEngine.Debug.Log(message:  ">>>>>>> XXXX");
            .activityPost = new GetSocialSdk.Core.ActivityPost().ParseFromAJO(ajo:  post);
            GetSocialSdk.Core.MainThreadExecutor.Queue(action:  new System.Action(object:  val_1, method:  System.Void ActionButtonListenerProxy.<>c__DisplayClass2_0::<onButtonClicked>b__0()));
        }
    
    }

}
