using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class InviteUiCallbackProxy.<>c__DisplayClass6_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GetSocialSdk.Ui.InviteUiCallbackProxy <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string channelId;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.AndroidJavaObject throwable;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public InviteUiCallbackProxy.<>c__DisplayClass6_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <onError>b__0()
    {
        if((this.<>4__this) == null)
        {
                51491 = 0;
        }
        
        this.<>4__this._onFailure.Invoke(arg1:  this.channelId, arg2:  GetSocialSdk.Core.JniUtils.ToGetSocialError(getSocialExceptionAJO:  this.throwable));
    }

}
