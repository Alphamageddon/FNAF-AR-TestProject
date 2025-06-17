using UnityEngine;

namespace GetSocialSdk.Ui
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AvatarClickListenerProxy : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<GetSocialSdk.Core.PublicUser> _avatarClickListener;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AvatarClickListenerProxy(System.Action<GetSocialSdk.Core.PublicUser> avatarClickListener)
        {
            this._avatarClickListener = avatarClickListener;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onAvatarClicked(UnityEngine.AndroidJavaObject publicUserAjo)
        {
            .<>4__this = this;
            UnityEngine.Debug.Log(message:  ">>>>>>> XXXX");
            GetSocialSdk.Core.PublicUser val_2 = new GetSocialSdk.Core.PublicUser();
            GetSocialSdk.Core.PublicUser val_3 = val_2.ParseFromAJO(ajo:  publicUserAjo);
            .publicUser = val_2;
            GetSocialSdk.Core.MainThreadExecutor.Queue(action:  new System.Action(object:  new AvatarClickListenerProxy.<>c__DisplayClass2_0(), method:  System.Void AvatarClickListenerProxy.<>c__DisplayClass2_0::<onAvatarClicked>b__0()));
        }
    
    }

}
