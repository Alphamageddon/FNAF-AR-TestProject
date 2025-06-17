using UnityEngine;

namespace GetSocialSdk.Ui
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class GetSocialUiNativeBridgeAndroid : IGetSocialUiNativeBridge
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string GetSocialUiClassSignature = "im.getsocial.sdk.ui.GetSocialUi";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string AndroidUiAccessHelperClass = "im.getsocial.sdk.ui.GetSocialUiAccessHelper";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GetSocialSdk.Ui.IGetSocialUiNativeBridge _instance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly UnityEngine.AndroidJavaClass _getUiSocialJavaClass;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Ui.IGetSocialUiNativeBridge Instance { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialUiNativeBridgeAndroid()
        {
            this._getUiSocialJavaClass = new UnityEngine.AndroidJavaClass(className:  "im.getsocial.sdk.ui.GetSocialUi");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Ui.IGetSocialUiNativeBridge get_Instance()
        {
            GetSocialSdk.Ui.IGetSocialUiNativeBridge val_2 = GetSocialSdk.Ui.GetSocialUiNativeBridgeAndroid._instance;
            if(val_2 != null)
            {
                    return (GetSocialSdk.Ui.IGetSocialUiNativeBridge)val_2;
            }
            
            GetSocialSdk.Ui.GetSocialUiNativeBridgeAndroid val_1 = null;
            val_2 = val_1;
            val_1 = new GetSocialSdk.Ui.GetSocialUiNativeBridgeAndroid();
            GetSocialSdk.Ui.GetSocialUiNativeBridgeAndroid._instance = val_2;
            return (GetSocialSdk.Ui.IGetSocialUiNativeBridge)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool LoadDefaultConfiguration()
        {
            return GetSocialSdk.Core.JniUtils.RunOnUiThreadSafe(action:  new System.Action(object:  this, method:  System.Void GetSocialSdk.Ui.GetSocialUiNativeBridgeAndroid::<LoadDefaultConfiguration>b__7_0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool LoadConfiguration(string path)
        {
            GetSocialUiNativeBridgeAndroid.<>c__DisplayClass8_0 val_1 = new GetSocialUiNativeBridgeAndroid.<>c__DisplayClass8_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .path = path;
            return GetSocialSdk.Core.JniUtils.RunOnUiThreadSafe(action:  new System.Action(object:  val_1, method:  System.Void GetSocialUiNativeBridgeAndroid.<>c__DisplayClass8_0::<LoadConfiguration>b__0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShowView<T>(GetSocialSdk.Ui.ViewBuilder<T> viewBuilder)
        {
            if(viewBuilder == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool OnBackPressed()
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticBool(ajo:  this._getUiSocialJavaClass, methodName:  "onBackPressed", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CloseView(bool saveViewState)
        {
            GetSocialUiNativeBridgeAndroid.<>c__DisplayClass11_0 val_1 = new GetSocialUiNativeBridgeAndroid.<>c__DisplayClass11_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .saveViewState = saveViewState;
            return GetSocialSdk.Core.JniUtils.RunOnUiThreadSafe(action:  new System.Action(object:  val_1, method:  System.Void GetSocialUiNativeBridgeAndroid.<>c__DisplayClass11_0::<CloseView>b__0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool RestoreView()
        {
            return GetSocialSdk.Core.JniUtils.RunOnUiThreadSafe(action:  new System.Action(object:  this, method:  System.Void GetSocialSdk.Ui.GetSocialUiNativeBridgeAndroid::<RestoreView>b__12_0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <LoadDefaultConfiguration>b__7_0()
        {
            object[] val_1 = new object[1];
            UnityEngine.AndroidJavaObject val_2 = GetSocialSdk.Core.JniUtils.Activity;
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            bool val_3 = GetSocialSdk.Core.JniExtensionMethods.CallStaticBool(ajo:  this._getUiSocialJavaClass, methodName:  "loadDefaultConfiguration", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <RestoreView>b__12_0()
        {
            this._getUiSocialJavaClass.CallStatic(methodName:  "restoreView", args:  System.Array.Empty<System.Object>());
        }
    
    }

}
