using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class GetSocialUiNativeBridgeAndroid.<>c__DisplayClass11_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GetSocialSdk.Ui.GetSocialUiNativeBridgeAndroid <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool saveViewState;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GetSocialUiNativeBridgeAndroid.<>c__DisplayClass11_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <CloseView>b__0()
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_2;
        }
        
        if(this.saveViewState == true)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(this.saveViewState == false)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_1[0] = this.saveViewState;
        this.<>4__this._getUiSocialJavaClass.CallStatic(methodName:  "closeView", args:  val_1);
    }

}
