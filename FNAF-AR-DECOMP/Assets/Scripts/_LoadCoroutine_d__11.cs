using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class SRSceneServiceBase.<LoadCoroutine>d__11<T, TImpl> : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SRF.Service.SRSceneServiceBase<T, TImpl> <>4__this;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SRSceneServiceBase.<LoadCoroutine>d__11<T, TImpl>(int <>1__state)
    {
        mem[1152921520781815040] = <>1__state;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.IDisposable.Dispose()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool MoveNext()
    {
        object val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_15 = this;
        if(true == 1)
        {
            goto label_1;
        }
        
        val_16 = 0;
        if(true != 0)
        {
                return (bool)val_16;
        }
        
        mem[1152921520782076240] = 0;
        if(static_value_04284048 != 0)
        {
            goto label_27;
        }
        
        val_17 = null;
        val_17 = null;
        int val_15 = SRF.Service.SRServiceManager.LoadingCount;
        val_15 = val_15 + 1;
        SRF.Service.SRServiceManager.LoadingCount = val_15;
        UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetSceneByName(name:  69746688);
        if(val_2.m_Handle.isLoaded == true)
        {
            goto label_11;
        }
        
        val_16 = 1;
        mem[1152921520782076248] = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName:  69746688, mode:  1);
        mem[1152921520782076240] = val_16;
        return (bool)val_16;
        label_1:
        mem[1152921520782076240] = 0;
        label_11:
        UnityEngine.GameObject val_5 = UnityEngine.GameObject.Find(name:  69746688);
        if(val_5 != 0)
        {
                if(val_5 != 0)
        {
            goto label_18;
        }
        
        }
        
        val_18 = null;
        val_18 = null;
        int val_16 = SRF.Service.SRServiceManager.LoadingCount;
        val_16 = val_16 - 1;
        SRF.Service.SRServiceManager.LoadingCount = val_16;
        object[] val_8 = new object[1];
        val_15 = 69746688;
        val_8[0] = val_15;
        UnityEngine.Debug.LogError(message:  SRF.SRFStringExtensions.Fmt(formatString:  "[Service] Root object ({0}) not found", args:  val_8), context:  69746688);
        enabled = false;
        goto label_27;
        label_18:
        val_5.transform.parent = CachedTransform;
        UnityEngine.Object.DontDestroyOnLoad(target:  val_5);
        object[] val_12 = new object[2];
        System.Type val_13 = GetType();
        if((val_13 != null) && (val_13 == null))
        {
                val_19 = 0;
        }
        
        if(val_12.Length == 0)
        {
                val_19 = 0;
        }
        
        val_12[0] = val_13;
        val_15 = 69746688;
        val_12[1] = val_15;
        UnityEngine.Debug.Log(message:  SRF.SRFStringExtensions.Fmt(formatString:  "[Service] Loading {0} complete. (Scene: {1})", args:  val_12), context:  69746688);
        val_20 = null;
        val_20 = null;
        int val_17 = SRF.Service.SRServiceManager.LoadingCount;
        val_17 = val_17 - 1;
        SRF.Service.SRServiceManager.LoadingCount = val_17;
        label_27:
        val_16 = 0;
        return (bool)val_16;
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
