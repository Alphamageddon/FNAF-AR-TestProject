using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
internal sealed class __f__AnonymousType0__p_j__TPar, _k_j__TPar_
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly <p>j__TPar <p>i__Field;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly <k>j__TPar <k>i__Field;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public <p>j__TPar p { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public <k>j__TPar k { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public <p>j__TPar get_p()
    {
        return (System.Collections.Generic.KeyValuePair<System.Object, System.Object>)X8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public <k>j__TPar get_k()
    {
        return (object)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public __f__AnonymousType0__p_j__TPar, _k_j__TPar_(<p>j__TPar p, <k>j__TPar k)
    {
        val_1 = new System.Object();
        mem[1152921518844535072] = p.Value;
        mem[1152921518844535080] = val_1;
        mem[1152921518844535088] = __RuntimeMethodHiddenParam;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object value)
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_11 = this;
        val_12 = value;
        if(val_12 == null)
        {
                return false;
        }
        
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 8) & 1) == 0)
        {
                return false;
        }
        
        val_11 = ???;
        val_12 = ???;
        val_13 = ???;
        val_14 = ???;
        goto __RuntimeMethodHiddenParam + 24 + 192 + 32 + 424;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 32;
        val_2 = (val_2 + ((__RuntimeMethodHiddenParam + 24 + 192 + 8) * 2773833001)) + 570449407;
        return (int)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string ToString()
    {
        var val_4;
        var val_5;
        object val_6;
        object[] val_1 = new object[2];
        val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 72 + 344 + 8];
        val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 72 + 344 + 8;
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 72) != 0) && ((__RuntimeMethodHiddenParam + 24 + 192 + 72) == 0))
        {
                val_4 = 0;
        }
        
        if(val_1.Length == 0)
        {
                val_4 = 0;
        }
        
        val_1[0] = ;
        var val_2 = (val_1.Length == 0) ? 0 : 1353130728;
        if(val_1.Length == 0)
        {
            goto label_6;
        }
        
        val_5 = mem[val_1.Length == 0 ? 0 : 1152921518844879592];
        val_5 = val_2;
        if(val_5 == 0)
        {
                val_5 = mem[val_1.Length == 0 ? 0 : 1152921518844879592];
            val_5 = val_2;
        }
        
        val_6 = val_5;
        if((val_6 == 0) || (val_6 != 0))
        {
            goto label_10;
        }
        
        goto label_10;
        label_6:
        val_6 = 0;
        label_10:
        val_1[1] = val_6;
        return (string)System.String.Format(provider:  0, format:  "{{ p = {0}, k = {1} }}", args:  val_1);
    }

}
