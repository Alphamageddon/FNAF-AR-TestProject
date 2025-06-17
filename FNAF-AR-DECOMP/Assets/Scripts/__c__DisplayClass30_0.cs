using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class PlayFabWebRequest.<>c__DisplayClass30_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PlayFab.Internal.CallRequestContainer reqContainer;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PlayFabWebRequest.<>c__DisplayClass30_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <QueueRequestError>b__0()
    {
        PlayFab.Internal.CallRequestContainer val_1;
        PlayFab.Internal.CallRequestContainer val_2;
        val_1 = this.reqContainer;
        if(this.reqContainer != null)
        {
            goto label_1;
        }
        
        val_1 = this.reqContainer;
        if(val_1 == null)
        {
            goto label_8;
        }
        
        label_1:
        PlayFab.Internal.PlayFabHttp.SendErrorEvent(request:  this.reqContainer.ApiRequest, error:  this.reqContainer.Error);
        if(this.reqContainer.ErrorCallback == null)
        {
                return;
        }
        
        val_2 = this.reqContainer;
        if(this.reqContainer != null)
        {
            goto label_7;
        }
        
        val_2 = this.reqContainer;
        if(val_2 == null)
        {
            goto label_8;
        }
        
        label_7:
        this.reqContainer.ErrorCallback.Invoke(obj:  this.reqContainer.Error);
        return;
        label_8:
    }

}
