using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private class ListEx.FunctorComparer<T> : IComparer<T>, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static System.Collections.Generic.Queue<StagPoint.Core.ListEx.FunctorComparer<T>> pool;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Comparison<T> comparison;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static StagPoint.Core.ListEx.FunctorComparer<T> Obtain(System.Comparison<T> comparison)
    {
        var val_1;
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
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
            goto label_31;
        }
        
        label_32:
        label_31:
        mem2[0] = comparison;
        return (ListEx.FunctorComparer<T>)__RuntimeMethodHiddenParam + 24 + 192 + 184;
        label_14:
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
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 16) != 0)
        {
            goto label_31;
        }
        
        goto label_32;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Release()
    {
        var val_1;
        var val_2;
        mem[1152921520175544784] = 0;
        val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_1 & 1) == 0)
        {
                val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 184) & 1) != 0)
        {
                return;
        }
        
        val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_2 & 1) == 0)
        {
                val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 184) == 0)
        {
            
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int Compare(T x, T y)
    {
        if(X21 == 0)
        {
            
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Dispose()
    {
        if(this == null)
        {
            
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ListEx.FunctorComparer<T>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ListEx.FunctorComparer<T>()
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
        
        mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 72;
    }

}
