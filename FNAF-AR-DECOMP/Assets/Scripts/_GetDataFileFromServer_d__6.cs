using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class GameSparksDataDownloader.<GetDataFileFromServer>d__6 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string url;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<byte[]> callback;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Networking.UnityWebRequest <request>5__2;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GameSparksDataDownloader.<GetDataFileFromServer>d__6(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.IDisposable.Dispose()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool MoveNext()
    {
        string val_9;
        int val_10;
        val_9 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_12;
        }
        
        this.<>1__state = 0;
        UnityEngine.Networking.UnityWebRequest val_1 = UnityEngine.Networking.UnityWebRequest.Get(uri:  this.url);
        this.<request>5__2 = val_1;
        this.<>2__current = val_1.SendWebRequest();
        val_10 = 1;
        this.<>1__state = val_10;
        return (bool)val_10;
        label_1:
        this.<>1__state = 0;
        if((this.<request>5__2.isNetworkError) != true)
        {
                if((this.<request>5__2.isHttpError) == false)
        {
            goto label_8;
        }
        
        }
        
        val_9 = "Error: "("Error: ") + this.<request>5__2.error(this.<request>5__2.error);
        ConsoleLogger.LogError(className:  "GameSparksDataDownloader", functionName:  "OnGetDownloadableResponse", logString:  val_9);
        goto label_12;
        label_8:
        val_9 = this.callback;
        val_9.Invoke(obj:  this.<request>5__2.downloadHandler.data);
        label_12:
        val_10 = 0;
        return (bool)val_10;
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
