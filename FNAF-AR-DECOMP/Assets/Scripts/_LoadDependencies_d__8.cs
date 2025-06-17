using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class SRDependencyServiceBase.<LoadDependencies>d__8<T> : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SRF.Service.SRDependencyServiceBase<T> <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Type[] <>7__wrap1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>7__wrap2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SRF.Service.IAsyncService <a>5__4;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SRDependencyServiceBase.<LoadDependencies>d__8<T>(int <>1__state)
    {
        mem[1152921520780172064] = <>1__state;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.IDisposable.Dispose()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool MoveNext()
    {
        UnityEngine.WaitForEndOfFrame val_8;
        var val_9;
        var val_10;
        object val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_18;
        var val_19;
        if(true == 1)
        {
            goto label_1;
        }
        
        if(true != 0)
        {
            goto label_38;
        }
        
        mem[1152921520780412640] = 0;
        val_9 = null;
        val_9 = null;
        int val_9 = SRF.Service.SRServiceManager.LoadingCount;
        val_9 = val_9 + 1;
        SRF.Service.SRServiceManager.LoadingCount = val_9;
        val_10 = mem[mem[69746688] + 488 + 8];
        val_10 = mem[69746688] + 488 + 8;
        val_11 = 69746688;
        val_12 = this;
        mem[1152921520780412664] = val_11;
        val_13 = 1152921520780412664;
        val_14 = 0;
        mem[1152921520780412672] = 0;
        if(!=0)
        {
            goto label_7;
        }
        
        goto label_7;
        label_1:
        val_15 = this;
        mem[1152921520780412640] = 0;
        if(X21 == 0)
        {
                val_16 = 0;
        }
        else
        {
                val_16 = ;
        }
        
        var val_10 = 0;
        val_10 = val_10 + 1;
        val_10 = public System.Boolean SRF.Service.IAsyncService::get_IsLoaded();
        if(IsLoaded == false)
        {
            goto label_23;
        }
        
        val_13 = 1152921520780412672;
        val_12 = 1152921520780412664;
        mem[1152921520780412680] = 0;
        mem[1152921520780412672] = mem[1152921520780412680];
        label_7:
        mem[1152921520780412664] = 0;
        val_18 = null;
        val_18 = null;
        int val_11 = SRF.Service.SRServiceManager.LoadingCount;
        val_11 = val_11 - 1;
        SRF.Service.SRServiceManager.LoadingCount = val_11;
        label_38:
        val_19 = 0;
        return (bool)val_19;
        label_23:
        UnityEngine.WaitForEndOfFrame val_6 = null;
        val_8 = val_6;
        val_6 = new UnityEngine.WaitForEndOfFrame();
        val_19 = 1;
        mem[1152921520780412648] = val_8;
        mem[1152921520780412640] = val_19;
        return (bool)val_19;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this;
    }

}
