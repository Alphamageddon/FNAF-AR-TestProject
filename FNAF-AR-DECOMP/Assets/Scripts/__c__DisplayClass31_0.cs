using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class PlayFabWebRequest.<>c__DisplayClass31_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PlayFab.Internal.CallRequestContainer reqContainer;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PlayFabWebRequest.<>c__DisplayClass31_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <ProcessJsonResponse>b__0()
    {
        PlayFab.Internal.CallRequestContainer val_1;
        PlayFab.SharedModels.PlayFabResultCommon val_2;
        PlayFab.Internal.CallRequestContainer val_3;
        val_1 = this.reqContainer;
        if(val_1 == null)
        {
            goto label_0;
        }
        
        val_2 = this.reqContainer.ApiResult;
        val_3 = val_1;
        goto label_3;
        label_0:
        val_3 = this.reqContainer;
        val_2 = this.reqContainer.ApiResult;
        if(val_3 == null)
        {
            goto label_2;
        }
        
        val_1 = val_3;
        goto label_3;
        label_2:
        val_1 = this.reqContainer;
        if(val_1 == null)
        {
            goto label_4;
        }
        
        label_3:
        PlayFab.Internal.PlayFabDeviceUtil.OnPlayFabLogin(result:  val_2, settings:  this.reqContainer.settings, instanceApi:  this.reqContainer.instanceApi);
        return;
        label_4:
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <ProcessJsonResponse>b__1()
    {
        PlayFab.Internal.CallRequestContainer val_1;
        string val_2;
        val_1 = this.reqContainer;
        if(val_1 == null)
        {
            goto label_1;
        }
        
        val_2 = this.reqContainer.ApiEndpoint;
        goto label_2;
        label_1:
        val_2 = this.reqContainer.ApiEndpoint;
        if(this.reqContainer == null)
        {
            goto label_3;
        }
        
        val_1 = this.reqContainer;
        label_2:
        label_9:
        PlayFab.Internal.PlayFabHttp.SendEvent(apiEndpoint:  val_2, request:  this.reqContainer.ApiRequest, result:  this.reqContainer.ApiResult, eventType:  1);
        this.reqContainer.InvokeSuccessCallback.Invoke();
        return;
        label_3:
        if(this.reqContainer != null)
        {
            goto label_9;
        }
        
        goto label_9;
    }

}
