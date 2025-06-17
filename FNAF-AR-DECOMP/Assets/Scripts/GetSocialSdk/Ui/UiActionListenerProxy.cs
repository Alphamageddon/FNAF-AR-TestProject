using UnityEngine;

namespace GetSocialSdk.Ui
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class UiActionListenerProxy : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Ui.UiActionListener _uiActionListener;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UiActionListenerProxy(GetSocialSdk.Ui.UiActionListener uiActionListener)
        {
            this._uiActionListener = uiActionListener;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onUiAction(UnityEngine.AndroidJavaObject actionType, UnityEngine.AndroidJavaObject pendingAction)
        {
            .pendingAction = pendingAction;
            this._uiActionListener.Invoke(action:  this.toUIActionEnum(actionType:  actionType), pendingAction:  new System.Action(object:  new UiActionListenerProxy.<>c__DisplayClass2_0(), method:  System.Void UiActionListenerProxy.<>c__DisplayClass2_0::<onUiAction>b__0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Ui.UiAction toUIActionEnum(UnityEngine.AndroidJavaObject actionType)
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallInt(ajo:  actionType, methodName:  "ordinal", args:  System.Array.Empty<System.Object>());
        }
    
    }

}
