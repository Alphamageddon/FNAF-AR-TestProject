using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class SQLiteConnection.<>c__DisplayClass82_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.IEnumerable objects;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int c;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SQLite4Unity3d.SQLiteConnection <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Type objType;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SQLiteConnection.<>c__DisplayClass82_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <InsertAll>b__0()
    {
        SQLite4Unity3d.SQLiteConnection val_18;
        var val_20;
        var val_21;
        var val_19 = 0;
        val_19 = val_19 + 1;
        System.Collections.IEnumerator val_2 = this.objects.GetEnumerator();
        goto label_6;
        label_18:
        var val_20 = 0;
        val_20 = val_20 + 1;
        val_18 = this.<>4__this;
        this.c = (val_18.Insert(obj:  val_2.Current, objType:  this.objType)) + this.c;
        label_6:
        var val_21 = 0;
        val_21 = val_21 + 1;
        if(val_2.MoveNext() == true)
        {
            goto label_18;
        }
        
        val_20 = 0;
        val_21 = 79;
        if(val_2 != null)
        {
                var val_22 = 0;
            val_22 = val_22 + 1;
            val_2.Dispose();
        }
        
        if( == 79)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
        
        val_20 = ???;
        val_21 = ???;
        val_18 = ???;
    }

}
