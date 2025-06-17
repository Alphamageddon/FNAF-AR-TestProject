using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class PlayFabWebRequest.<>c__DisplayClass21_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PlayFab.Internal.PlayFabWebRequest <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string fullUrl;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<byte[]> successCallback;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<string> errorCallback;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PlayFabWebRequest.<>c__DisplayClass21_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <SimpleGetCall>b__0()
    {
        0.SimpleHttpsWorker(httpMethod:  "GET", fullUrl:  this.fullUrl, payload:  0, successCallback:  this.successCallback, errorCallback:  this.errorCallback);
    }

}
