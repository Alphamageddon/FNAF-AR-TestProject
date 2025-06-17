using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class InviteChannelPluginProxy : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly GetSocialSdk.Core.InviteChannelPlugin _invitePlugin;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InviteChannelPluginProxy(GetSocialSdk.Core.InviteChannelPlugin invitePlugin)
        {
            this._invitePlugin = invitePlugin;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool isAvailableForDevice(UnityEngine.AndroidJavaObject inviteChannelAJO)
        {
            GetSocialSdk.Core.InviteChannel val_1 = new GetSocialSdk.Core.InviteChannel();
            GetSocialSdk.Core.InviteChannel val_2 = val_1.ParseFromAJO(ajo:  inviteChannelAJO);
            var val_4 = 0;
            val_4 = val_4 + 1;
            return this._invitePlugin.IsAvailableForDevice(inviteChannel:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void presentChannelInterface(UnityEngine.AndroidJavaObject inviteChannelAJO, UnityEngine.AndroidJavaObject invitePackageAJO, UnityEngine.AndroidJavaObject callbackAJO)
        {
            InviteChannelPluginProxy.<>c__DisplayClass3_0 val_1 = new InviteChannelPluginProxy.<>c__DisplayClass3_0();
            if(val_1 != null)
            {
                    .inviteChannelAJO = inviteChannelAJO;
                .invitePackageAJO = invitePackageAJO;
                .callbackAJO = callbackAJO;
            }
            else
            {
                    mem[16] = inviteChannelAJO;
                mem[24] = invitePackageAJO;
                mem[32] = callbackAJO;
            }
            
            .<>4__this = this;
            GetSocialSdk.Core.JavaInterfaceProxy.ExecuteOnMainThread(action:  new System.Action(object:  val_1, method:  System.Void InviteChannelPluginProxy.<>c__DisplayClass3_0::<presentChannelInterface>b__0()));
        }
    
    }

}
