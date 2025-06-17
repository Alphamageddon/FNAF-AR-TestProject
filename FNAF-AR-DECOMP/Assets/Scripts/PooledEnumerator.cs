using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private class ListEx.PooledEnumerator<T> : IEnumerator<T>, IEnumerator, IDisposable, IEnumerable<T>, IEnumerable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static System.Collections.Generic.Queue<StagPoint.Core.ListEx.PooledEnumerator<T>> pool;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private StagPoint.Core.ListEx<T> list;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Func<T, bool> predicate;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int currentIndex;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private T currentValue;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool isValid;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public T Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static StagPoint.Core.ListEx.PooledEnumerator<T> Obtain(StagPoint.Core.ListEx<T> list, System.Func<T, bool> predicate)
    {
        var val_1;
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_1 & 1) == 0)
        {
                val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        val_2 = mem[__RuntimeMethodHiddenParam + 24 + 294];
        val_2 = __RuntimeMethodHiddenParam + 24 + 294;
        val_3 = __RuntimeMethodHiddenParam + 24;
        if((val_2 & 1) == 0)
        {
                val_3 = mem[__RuntimeMethodHiddenParam + 24];
            val_3 = __RuntimeMethodHiddenParam + 24;
            val_2 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_2 = __RuntimeMethodHiddenParam + 24 + 294;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 184) <= 0)
        {
            goto label_14;
        }
        
        val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_4 & 1) == 0)
        {
                val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        val_5 = mem[__RuntimeMethodHiddenParam + 24 + 294];
        val_5 = __RuntimeMethodHiddenParam + 24 + 294;
        val_6 = __RuntimeMethodHiddenParam + 24;
        if((val_5 & 1) == 0)
        {
                val_6 = mem[__RuntimeMethodHiddenParam + 24];
            val_6 = __RuntimeMethodHiddenParam + 24;
            val_5 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_5 = __RuntimeMethodHiddenParam + 24 + 294;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 184) != 0)
        {
            goto label_33;
        }
        
        label_34:
        label_33:
        val_7 = mem[__RuntimeMethodHiddenParam + 24 + 294];
        val_7 = __RuntimeMethodHiddenParam + 24 + 294;
        val_8 = __RuntimeMethodHiddenParam + 24;
        if((val_7 & 1) == 0)
        {
                val_8 = mem[__RuntimeMethodHiddenParam + 24];
            val_8 = __RuntimeMethodHiddenParam + 24;
            val_7 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_7 = __RuntimeMethodHiddenParam + 24 + 294;
        }
        
        if((val_7 & 1) != 0)
        {
                return (ListEx.PooledEnumerator<T>)__RuntimeMethodHiddenParam + 24 + 192 + 184;
        }
        
        return (ListEx.PooledEnumerator<T>)__RuntimeMethodHiddenParam + 24 + 192 + 184;
        label_14:
        val_9 = mem[__RuntimeMethodHiddenParam + 24 + 294];
        val_9 = __RuntimeMethodHiddenParam + 24 + 294;
        val_10 = __RuntimeMethodHiddenParam + 24;
        if((val_9 & 1) == 0)
        {
                val_10 = mem[__RuntimeMethodHiddenParam + 24];
            val_10 = __RuntimeMethodHiddenParam + 24;
            val_9 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_9 = __RuntimeMethodHiddenParam + 24 + 294;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 16) != 0)
        {
            goto label_33;
        }
        
        goto label_34;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Release()
    {
        var val_6;
        var val_7;
        val_6 = this;
        if(W8 == 0)
        {
                return;
        }
        
        mem[1152921520174148448] = 0;
        val_7 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_7 & 1) == 0)
        {
                val_7 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        val_6 = ???;
        goto __RuntimeMethodHiddenParam + 24 + 192 + 48;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public T get_Current()
    {
        if(true != 0)
        {
                return 38118;
        }
        
        System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "The enumerator is no longer valid");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ResetInternal(StagPoint.Core.ListEx<T> list, System.Func<T, bool> predicate)
    {
        mem[1152921520174389968] = list;
        mem[1152921520174389976] = predicate;
        mem[1152921520174389984] = 0;
        mem[1152921520174390000] = 1;
        mem[1152921520174389992] = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Dispose()
    {
        if(this == null)
        {
            
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.get_Current()
    {
        if(this == null)
        {
            
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool MoveNext()
    {
        var val_2;
        var val_3;
        if(true != 0)
        {
                label_6:
            if(W22 < 69746688)
        {
                mem[1152921520174739296] = 69746689;
            val_2 = X22;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 80) != 0)
        {
                if(((__RuntimeMethodHiddenParam + 24 + 192 + 80) & 1) == 0)
        {
            goto label_6;
        }
        
        }
        
            mem[1152921520174739304] = val_2;
            val_3 = 1;
            return (bool)val_3;
        }
        
            val_3 = 0;
            mem[1152921520174739304] = 0;
            return (bool)val_3;
        }
        
        System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "The enumerator is no longer valid");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Reset()
    {
        System.NotImplementedException val_1 = new System.NotImplementedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.IEnumerator<T> GetEnumerator()
    {
        return (System.Collections.Generic.IEnumerator<T>)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return (System.Collections.IEnumerator)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ListEx.PooledEnumerator<T>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ListEx.PooledEnumerator<T>()
    {
        var val_1;
        var val_2;
        val_1 = mem[__RuntimeMethodHiddenParam + 24 + 294];
        val_1 = __RuntimeMethodHiddenParam + 24 + 294;
        val_2 = __RuntimeMethodHiddenParam + 24;
        if((val_1 & 1) == 0)
        {
                val_2 = mem[__RuntimeMethodHiddenParam + 24];
            val_2 = __RuntimeMethodHiddenParam + 24;
            val_1 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_1 = __RuntimeMethodHiddenParam + 24 + 294;
        }
        
        mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 104;
    }

}
