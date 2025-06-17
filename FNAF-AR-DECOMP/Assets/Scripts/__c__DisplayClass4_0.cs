using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class InviteUiCallbackProxy.<>c__DisplayClass4_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GetSocialSdk.Ui.InviteUiCallbackProxy <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string channelId;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public InviteUiCallbackProxy.<>c__DisplayClass4_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <onComplete>b__0()
    {
        this.<>4__this._onComplete.Invoke(obj:  this.channelId);
    }

}
