using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class FileLoader.<LoadFile>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Systems.AssetManagement.Files.FileLoadSettings settings;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Networking.UnityWebRequest <request>5__2;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FileLoader.<LoadFile>d__3(int <>1__state)
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
        int val_8;
        Systems.AssetManagement.Files.FileLoadSettings val_9;
        if((this.<>1__state) == 0)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 1)
        {
            goto label_38;
        }
        
        this.<>1__state = -3;
        if((this.<request>5__2.isNetworkError) != true)
        {
                if((this.<request>5__2.isHttpError) == false)
        {
            goto label_6;
        }
        
        }
        
        if(this.settings.FileLoadFailure == null)
        {
            goto label_17;
        }
        
        this.settings.FileLoadFailure.Invoke(obj:  this.settings);
        goto label_17;
        label_1:
        this.<>1__state = 0;
        UnityEngine.Networking.UnityWebRequest val_3 = UnityEngine.Networking.UnityWebRequest.Get(uri:  this.settings.FilePath);
        this.<request>5__2 = val_3;
        this.<>1__state = -3;
        this.<>2__current = val_3.SendWebRequest();
        val_8 = 1;
        this.<>1__state = val_8;
        return (bool)val_8;
        label_6:
        if(this.settings.FileLoadSuccess != null)
        {
                val_9 = this.settings;
            this.settings.FileLoadSuccess.Invoke(arg1:  val_9, arg2:  this.<request>5__2.downloadHandler);
        }
        
        if(this.settings.ByteLoadSuccess != null)
        {
                val_9 = this.settings;
            this.settings.ByteLoadSuccess.Invoke(arg1:  val_9, arg2:  this.<request>5__2.downloadHandler.data);
        }
        
        label_17:
        this.<>m__Finally1();
        val_8 = 0;
        this.<request>5__2 = 0;
        return (bool)val_8;
        label_38:
        val_8 = 0;
        return (bool)val_8;
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
