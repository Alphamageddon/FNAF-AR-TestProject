using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class PlayFabWebRequest.<>c__DisplayClass22_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PlayFab.Internal.PlayFabWebRequest <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string fullUrl;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte[] payload;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<byte[]> successCallback;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<string> errorCallback;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PlayFabWebRequest.<>c__DisplayClass22_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <SimplePutCall>b__0()
    {
        0.SimpleHttpsWorker(httpMethod:  "PUT", fullUrl:  this.fullUrl, payload:  this.payload, successCallback:  this.successCallback, errorCallback:  this.errorCallback);
    }

}
