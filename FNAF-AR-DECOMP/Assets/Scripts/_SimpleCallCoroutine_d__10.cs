using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class PlayFabUnityHttp.<SimpleCallCoroutine>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte[] payload;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string fullUrl;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<string> errorCallback;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<byte[]> successCallback;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string method;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Networking.UnityWebRequest <www>5__2;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PlayFabUnityHttp.<SimpleCallCoroutine>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.IDisposable.Dispose()
    {
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 3)
        {
                return;
        }
        
        }
        
        this.<>m__Finally1();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool MoveNext()
    {
        string val_19;
        UnityEngine.Networking.UnityWebRequest val_20;
        var val_21;
        int val_22;
        if((this.<>1__state) == 0)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 2)
        {
            goto label_66;
        }
        
        this.<>1__state = 0;
        if((this.<www>5__2.isNetworkError) != true)
        {
                if((this.<www>5__2.isHttpError) == false)
        {
            goto label_7;
        }
        
        }
        
        val_19 = this.<www>5__2.error;
        this.errorCallback.Invoke(obj:  val_19);
        goto label_35;
        label_2:
        this.<>1__state = -3;
        if((System.String.IsNullOrEmpty(value:  this.<www>5__2.error)) == false)
        {
            goto label_12;
        }
        
        val_19 = this.<www>5__2.downloadHandler.data;
        this.successCallback.Invoke(obj:  val_19);
        goto label_16;
        label_1:
        this.<>1__state = 0;
        if(this.payload == null)
        {
            goto label_17;
        }
        
        val_19 = this.fullUrl;
        if((System.String.op_Equality(a:  this.method, b:  "put")) == false)
        {
            goto label_18;
        }
        
        val_20 = UnityEngine.Networking.UnityWebRequest.Put(uri:  val_19, bodyData:  this.payload);
        val_21 = this;
        this.<www>5__2 = val_20;
        if(val_20 != null)
        {
            goto label_29;
        }
        
        goto label_20;
        label_12:
        val_19 = this.<www>5__2.error;
        this.errorCallback.Invoke(obj:  val_19);
        label_16:
        this.<>m__Finally1();
        label_35:
        val_22 = 0;
        this.<www>5__2 = 0;
        return (bool)val_22;
        label_17:
        UnityEngine.Networking.UnityWebRequest val_11 = UnityEngine.Networking.UnityWebRequest.Get(uri:  this.fullUrl);
        this.<www>5__2 = val_11;
        this.<>1__state = -3;
        this.<>2__current = val_11.SendWebRequest();
        val_22 = 1;
        this.<>1__state = val_22;
        return (bool)val_22;
        label_18:
        new UnityEngine.Networking.UnityWebRequest() = new UnityEngine.Networking.UnityWebRequest(url:  val_19, method:  "POST");
        val_21 = this;
        this.<www>5__2 = new UnityEngine.Networking.UnityWebRequest();
        new UnityEngine.Networking.UploadHandlerRaw() = new UnityEngine.Networking.UploadHandlerRaw(data:  this.payload);
        new UnityEngine.Networking.UnityWebRequest().uploadHandler = new UnityEngine.Networking.UploadHandlerRaw();
        val_19 = new UnityEngine.Networking.DownloadHandlerBuffer();
        val_19 = new UnityEngine.Networking.DownloadHandlerBuffer();
        new UnityEngine.Networking.UnityWebRequest().downloadHandler = new UnityEngine.Networking.DownloadHandlerBuffer();
        new UnityEngine.Networking.UnityWebRequest().SetRequestHeader(name:  "Content-Type", value:  "application/json");
        val_20 = this.<www>5__2;
        if(val_20 != null)
        {
            goto label_29;
        }
        
        label_20:
        label_29:
        new UnityEngine.Networking.UnityWebRequest().chunkedTransfer = false;
        this.<>2__current = new UnityEngine.Networking.UnityWebRequest().SendWebRequest();
        this.<>1__state = 2;
        val_22 = 1;
        return (bool)val_22;
        label_7:
        this.successCallback.Invoke(obj:  this.<www>5__2.downloadHandler.data);
        goto label_35;
        label_66:
        val_22 = 0;
        return (bool)val_22;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        if((this.<www>5__2) == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.<www>5__2.Dispose();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
