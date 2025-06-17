using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class SQLiteCommand.<ExecuteDeferredQuery>d__12<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private T <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>l__initialThreadId;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SQLite4Unity3d.SQLiteCommand <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SQLite4Unity3d.TableMapping map;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SQLite4Unity3d.TableMapping <>3__map;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr <stmt>5__2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SQLite4Unity3d.TableMapping.Column[] <cols>5__3;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private T System.Collections.Generic.IEnumerator<T>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SQLiteCommand.<ExecuteDeferredQuery>d__12<T>(int <>1__state)
    {
        mem[1152921519650019728] = <>1__state;
        mem[1152921519650019744] = System.Environment.CurrentManagedThreadId;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.IDisposable.Dispose()
    {
        if(W8 != 1)
        {
                if(W8 != 3)
        {
                return;
        }
        
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool MoveNext()
    {
        var val_18;
        var val_19;
        object val_20;
        var val_21;
        var val_22;
        Column[] val_23;
        var val_24;
        if(true == 0)
        {
            goto label_1;
        }
        
        if(true != 1)
        {
            goto label_64;
        }
        
        mem[1152921519650284688] = -3;
        label_33:
        if((SQLite4Unity3d.SQLite3.Step(stmt:  null)) != 100)
        {
            goto label_3;
        }
        
        object val_3 = System.Activator.CreateInstance(type:  X22.MappedType);
        val_19 = 0;
        goto label_5;
        label_17:
        if(val_19 >= (X24 + 24))
        {
                val_20 = 0;
        }
        
        var val_4 = X24 + 0;
        if(((X24 + 0) + 32) != 0)
        {
                var val_6 = X26 + 0;
            val_20 = ReadCol(stmt:  X25, index:  0, type:  SQLite4Unity3d.SQLite3.ColumnType(stmt:  null, index:  0), clrType:  (X26 + 0) + 32.ColumnType);
            (X25 + 0) + 32.SetValue(obj:  val_3, val:  val_20);
        }
        
        val_19 = 1;
        label_5:
        if(val_19 < (X25 + 0))
        {
            goto label_17;
        }
        
        val_18 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8];
        val_18 = __RuntimeMethodHiddenParam + 24 + 192 + 8;
        if(val_3 == null)
        {
            goto label_20;
        }
        
        val_21 = val_3;
        if(val_21 != null)
        {
            goto label_21;
        }
        
        label_20:
        val_21 = 0;
        label_21:
        mem[1152921519650284696] = val_21;
        val_22 = 1;
        mem[1152921519650284688] = val_22;
        return (bool)val_22;
        label_1:
        mem[1152921519650284688] = 0;
        bool val_11 = mem[69746704].Trace;
        IntPtr val_12 = Prepare();
        mem[1152921519650284736] = val_12;
        mem[1152921519650284688] = -3;
        int val_13 = SQLite4Unity3d.SQLite3.ColumnCount(stmt:  val_12);
        val_23 = new Column[0];
        val_24 = 0;
        mem[1152921519650284744] = val_23;
        goto label_25;
        label_32:
        var val_17 = X25 + 0;
        mem2[0] = X24.FindColumn(columnName:  SQLite4Unity3d.SQLite3.ColumnName16(stmt:  mem[1152921519650284736], index:  0));
        val_24 = 1;
        label_25:
        if(val_24 < (val_16.<Name>k__BackingField))
        {
            goto label_32;
        }
        
        goto label_33;
        label_3:
        mem[1152921519650284744] = 0;
        label_64:
        val_22 = 0;
        return (bool)val_22;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <>m__Finally1()
    {
        mem[1152921519650441744] = 0;
        Result val_1 = SQLite4Unity3d.SQLite3.Finalize(stmt:  X8);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private T System.Collections.Generic.IEnumerator<T>.get_Current()
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
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
    {
        var val_2;
        if((W8 == 2) && (W21 == System.Environment.CurrentManagedThreadId))
        {
                mem[1152921519650903056] = 0;
            val_2 = this;
        }
        else
        {
                val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 24;
            mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 24;
        }
        
        mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 32;
        return (System.Collections.Generic.IEnumerator<T>)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        if(this == null)
        {
            
        }
    
    }

}
