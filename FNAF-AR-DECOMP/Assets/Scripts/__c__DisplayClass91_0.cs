using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class SQLiteConnection.<>c__DisplayClass91_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.IEnumerable objects;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int c;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SQLite4Unity3d.SQLiteConnection <>4__this;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SQLiteConnection.<>c__DisplayClass91_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <UpdateAll>b__0()
    {
        var val_16;
        var val_19;
        var val_20;
        var val_18 = 0;
        val_18 = val_18 + 1;
        System.Collections.IEnumerator val_2 = this.objects.GetEnumerator();
        val_16 = 1152921504685174784;
        goto label_6;
        label_18:
        var val_19 = 0;
        val_19 = val_19 + 1;
        this.c = (this.<>4__this.Update(obj:  val_2.Current)) + this.c;
        label_6:
        var val_20 = 0;
        val_20 = val_20 + 1;
        if(val_2.MoveNext() == true)
        {
            goto label_18;
        }
        
        val_19 = 0;
        val_20 = 73;
        if(val_2 != null)
        {
                var val_21 = 0;
            val_21 = val_21 + 1;
            val_2.Dispose();
        }
        
        if( == 73)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
        
        val_19 = ???;
        val_20 = ???;
        val_16 = ???;
    }

}
