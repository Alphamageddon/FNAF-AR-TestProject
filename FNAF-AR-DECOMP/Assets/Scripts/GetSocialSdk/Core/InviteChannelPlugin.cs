using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface InviteChannelPlugin
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsAvailableForDevice(GetSocialSdk.Core.InviteChannel inviteChannel); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void PresentChannelInterface(GetSocialSdk.Core.InviteChannel inviteChannel, GetSocialSdk.Core.InvitePackage invitePackage, System.Action onComplete, System.Action onCancel, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
    
    }

}
