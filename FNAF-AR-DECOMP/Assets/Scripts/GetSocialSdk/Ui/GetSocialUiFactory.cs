using UnityEngine;

namespace GetSocialSdk.Ui
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static class GetSocialUiFactory
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static GetSocialSdk.Ui.IGetSocialUiNativeBridge InstantiateGetSocialUi()
        {
            return GetSocialSdk.Ui.GetSocialUiNativeBridgeAndroid.Instance;
        }
    
    }

}
