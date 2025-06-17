using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class FileLoader.<DownloadFile>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string uri;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<string> failureCallback;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<string, UnityEngine.Networking.DownloadHandler> successCallback;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Networking.UnityWebRequest <request>5__2;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FileLoader.<DownloadFile>d__4(int <>1__state)
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
        int val_6;
        if((this.<>1__state) == 0)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 1)
        {
            goto label_24;
        }
        
        this.<>1__state = -3;
        if((this.<request>5__2.isNetworkError) != true)
        {
                if((this.<request>5__2.isHttpError) == false)
        {
            goto label_6;
        }
        
        }
        
        if(this.failureCallback == null)
        {
            goto label_11;
        }
        
        this.failureCallback.Invoke(obj:  this.uri);
        goto label_11;
        label_1:
        this.<>1__state = 0;
        UnityEngine.Networking.UnityWebRequest val_3 = UnityEngine.Networking.UnityWebRequest.Get(uri:  this.uri);
        this.<request>5__2 = val_3;
        this.<>1__state = -3;
        this.<>2__current = val_3.SendWebRequest();
        val_6 = 1;
        this.<>1__state = val_6;
        return (bool)val_6;
        label_6:
        if(this.successCallback != null)
        {
                this.successCallback.Invoke(arg1:  this.uri, arg2:  this.<request>5__2.downloadHandler);
        }
        
        label_11:
        this.<>m__Finally1();
        val_6 = 0;
        this.<request>5__2 = 0;
        return (bool)val_6;
        label_24:
        val_6 = 0;
        return (bool)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        if((this.<request>5__2) == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.<request>5__2.Dispose();
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
