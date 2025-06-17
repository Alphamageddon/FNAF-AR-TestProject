using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class GetSocialUiNativeBridgeAndroid.<>c__DisplayClass8_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GetSocialSdk.Ui.GetSocialUiNativeBridgeAndroid <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string path;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GetSocialUiNativeBridgeAndroid.<>c__DisplayClass8_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <LoadConfiguration>b__0()
    {
        object[] val_1 = new object[2];
        UnityEngine.AndroidJavaObject val_2 = GetSocialSdk.Core.JniUtils.Activity;
        if(val_1 == null)
        {
            goto label_2;
        }
        
        if(val_2 != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(val_2 == null)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_1[0] = val_2;
        val_1[1] = this.path;
        bool val_3 = GetSocialSdk.Core.JniExtensionMethods.CallStaticBool(ajo:  this.<>4__this._getUiSocialJavaClass, methodName:  "loadConfiguration", args:  val_1);
    }

}
