using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class Crashes.<SendUnhandledExceptionReports>d__47 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Crashes.<SendUnhandledExceptionReports>d__47(int <>1__state)
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
        var val_7;
        var val_8;
        var val_9;
        System.Exception val_10;
        var val_11;
        var val_12;
        int val_13;
        if(((this.<>1__state) - 1) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        val_7 = null;
        val_7 = null;
        bool val_2 = false;
        System.Threading.Monitor.Enter(obj:  Microsoft.AppCenter.Unity.Crashes.Crashes._unhandledExceptions, lockTaken: ref  val_2);
        val_8 = null;
        val_8 = null;
        if(Microsoft.AppCenter.Unity.Crashes.Crashes._unhandledExceptions.Count < 1)
        {
            goto label_7;
        }
        
        val_9 = null;
        val_9 = null;
        val_10 = Microsoft.AppCenter.Unity.Crashes.Crashes._unhandledExceptions.Dequeue();
        val_11 = 0;
        val_12 = 117;
        goto label_29;
        label_1:
        val_13 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_13;
        }
        
        val_13 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_13;
        return (bool)val_13;
        label_7:
        val_11 = 0;
        val_10 = 0;
        val_12 = 161;
        label_29:
        if(val_2 != 0)
        {
                System.Threading.Monitor.Exit(obj:  Microsoft.AppCenter.Unity.Crashes.Crashes._unhandledExceptions);
        }
        
        if(161 != 117)
        {
                if(161 == 161)
        {
                val_13 = 0;
            return (bool)val_13;
        }
        
        }
        
        if(val_10 != 0)
        {
                Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal.TrackException(exception:  Microsoft.AppCenter.Unity.Crashes.Crashes.CreateWrapperException(exception:  val_10).GetRawObject());
        }
        
        val_13 = 1;
        this.<>2__current = 0;
        this.<>1__state = 2;
        return (bool)val_13;
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
