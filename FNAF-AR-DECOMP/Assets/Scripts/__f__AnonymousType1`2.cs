using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
internal sealed class __f__AnonymousType1____h__TransparentIdentifier0_j__TPar, _v_j__TPar_
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly <<>h__TransparentIdentifier0>j__TPar <<>h__TransparentIdentifier0>i__Field;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly <v>j__TPar <v>i__Field;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public <<>h__TransparentIdentifier0>j__TPar <>h__TransparentIdentifier0 { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public <v>j__TPar v { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public <<>h__TransparentIdentifier0>j__TPar get_<>h__TransparentIdentifier0()
    {
        return (__f__AnonymousType0__p_j__TPar, _k_j__TPar_<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public <v>j__TPar get_v()
    {
        return (string)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public __f__AnonymousType1____h__TransparentIdentifier0_j__TPar, _v_j__TPar_(<<>h__TransparentIdentifier0>j__TPar <>h__TransparentIdentifier0, <v>j__TPar v)
    {
        val_1 = new System.Object();
        mem[1152921518845244080] = <>h__TransparentIdentifier0;
        mem[1152921518845244088] = val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object value)
    {
        var val_9;
        var val_10;
        var val_11;
        val_9 = this;
        val_10 = value;
        if(val_10 == null)
        {
                return false;
        }
        
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 8) & 1) == 0)
        {
                return false;
        }
        
        val_9 = ???;
        val_10 = ???;
        val_11 = ???;
        goto __RuntimeMethodHiddenParam + 24 + 192 + 32 + 424;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 32;
        val_2 = (val_2 + ((__RuntimeMethodHiddenParam + 24 + 192 + 8) * 2773833001)) + 176954279;
        return (int)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string ToString()
    {
        object val_5;
        var val_6;
        var val_7;
        object val_8;
        object[] val_1 = new object[2];
        object val_2 = (1152921505343392448 == 0) ? 0 : 1353843912;
        if(null == 0)
        {
            goto label_1;
        }
        
        val_5 = mem[1152921505343392448 == 0x0 ? 0 : 1152921518845592776];
        val_5 = val_2;
        if(val_5 == 0)
        {
                val_5 = mem[1152921505343392448 == 0x0 ? 0 : 1152921518845592776];
            val_5 = val_2;
        }
        
        val_6 = mem[1152921505343392448 == 0x0 ? 0 : 1152921518845592776 + 344 + 8];
        val_6 = 1152921505343392448 == 0x0 ? 0 : 1152921518845592776 + 344 + 8;
        if(val_1 != null)
        {
            goto label_12;
        }
        
        label_13:
        label_12:
        if((val_5 != 0) && (val_5 == 0))
        {
                val_6 = 0;
        }
        
        if(val_1.Length == 0)
        {
                val_6 = 0;
        }
        
        val_1[0] = val_5;
        var val_3 = (val_1.Length == 0) ? 0 : ();
        if(val_1.Length == 0)
        {
            goto label_7;
        }
        
        val_7 = mem[val_1.Length == 0 ? 0 : ];
        val_7 = val_3;
        if(val_7 == 0)
        {
                val_7 = mem[val_1.Length == 0 ? 0 : ];
            val_7 = val_3;
        }
        
        val_8 = val_7;
        if((val_8 == 0) || (val_8 != 0))
        {
            goto label_11;
        }
        
        goto label_11;
        label_1:
        if(val_1 != null)
        {
            goto label_12;
        }
        
        goto label_13;
        label_7:
        val_8 = 0;
        label_11:
        val_1[1] = val_8;
        return (string)System.String.Format(provider:  0, format:  "{{ <>h__TransparentIdentifier0 = {0}, v = {1} }}", args:  val_1);
    }

}
