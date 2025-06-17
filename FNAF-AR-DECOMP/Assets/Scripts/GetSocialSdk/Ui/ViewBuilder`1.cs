using UnityEngine;

namespace GetSocialSdk.Ui
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class ViewBuilder<T>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected System.Action _onOpen;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected System.Action _onClose;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected string _customWindowTitle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected GetSocialSdk.Ui.UiActionListener _uiActionListener;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T SetWindowTitle(string title)
        {
            var val_2;
            mem[1152921525957129296] = title;
            val_2 = this;
            if(this != null)
            {
                    return (object)val_2;
            }
            
            val_2 = 0;
            return (object)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T SetViewStateCallbacks(System.Action onOpen, System.Action onClose)
        {
            var val_2;
            mem[1152921525957253568] = onOpen;
            mem[1152921525957253576] = onClose;
            val_2 = this;
            if(this != null)
            {
                    return (object)val_2;
            }
            
            val_2 = 0;
            return (object)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T SetUiActionListener(GetSocialSdk.Ui.UiActionListener listener)
        {
            var val_2;
            mem[1152921525957377880] = listener;
            val_2 = this;
            if(this != null)
            {
                    return (object)val_2;
            }
            
            val_2 = 0;
            return (object)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal abstract bool ShowInternal(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Show()
        {
            goto __RuntimeMethodHiddenParam + 24 + 192 + 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool ShowBuilder(UnityEngine.AndroidJavaObject builder)
        {
            if((__RuntimeMethodHiddenParam + 24 + 192 + 16) == 0)
            {
                goto label_2;
            }
            
            mem2[0] = builder;
            if(this != null)
            {
                goto label_8;
            }
            
            label_9:
            label_8:
            GetSocialSdk.Ui.IGetSocialUiNativeBridge val_1 = GetSocialSdk.Ui.GetSocialUiFactory.InstantiateGetSocialUi();
            return GetSocialSdk.Core.JniUtils.RunOnUiThreadSafe(action:  new System.Action(object:  __RuntimeMethodHiddenParam + 24 + 192 + 16, method:  __RuntimeMethodHiddenParam + 24 + 192 + 56));
            label_2:
            mem[16] = builder;
            if(this != null)
            {
                goto label_8;
            }
            
            goto label_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetTitleAJO(UnityEngine.AndroidJavaObject builderAJO)
        {
            if(true == 0)
            {
                    return;
            }
            
            object[] val_1 = new object[1];
            val_1[0] = null;
            UnityEngine.AndroidJavaObject val_2 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  builderAJO, methodName:  "setWindowTitle", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetUiActionListenerAJO(UnityEngine.AndroidJavaObject builderAJO)
        {
            if(true == 0)
            {
                    return;
            }
            
            object[] val_1 = new object[1];
            val_1[0] = new GetSocialSdk.Ui.UiActionListenerProxy(uiActionListener:  X22);
            UnityEngine.AndroidJavaObject val_3 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  builderAJO, methodName:  "setUiActionListener", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetViewStateListener(UnityEngine.AndroidJavaObject builderAJO)
        {
            if(true == 0)
            {
                    if(true == 0)
            {
                    return;
            }
            
            }
            
            object[] val_1 = new object[1];
            val_1[0] = new GetSocialSdk.Ui.ViewStateListener(onOpen:  X22, onClose:  X23);
            UnityEngine.AndroidJavaObject val_3 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  builderAJO, methodName:  "setViewStateListener", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected ViewBuilder<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
    
    }

}
