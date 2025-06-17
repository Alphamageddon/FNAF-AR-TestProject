using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ReflectionUtils.ThreadSafeDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, IEnumerable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly object _lock;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly PlayFab.Json.ReflectionUtils.ThreadSafeDictionaryValueFactory<TKey, TValue> _valueFactory;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.Dictionary<TKey, TValue> _dictionary;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.ICollection<TKey> Keys { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.ICollection<TValue> Values { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TValue Item { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int Count { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsReadOnly { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ReflectionUtils.ThreadSafeDictionary<TKey, TValue>(PlayFab.Json.ReflectionUtils.ThreadSafeDictionaryValueFactory<TKey, TValue> valueFactory)
    {
        mem[1152921525724123664] = new System.Object();
        mem[1152921525724123672] = valueFactory;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TValue Get(TKey key)
    {
        var val_1;
        var val_2;
        val_1 = mem[__RuntimeMethodHiddenParam + 24];
        val_1 = __RuntimeMethodHiddenParam + 24;
        if(this != null)
        {
                if((this & 1) != 0)
        {
                val_2 = 0;
            return (object)val_2;
        }
        
            val_1 = mem[__RuntimeMethodHiddenParam + 24];
            val_1 = __RuntimeMethodHiddenParam + 24;
        }
        
        val_2 = this;
        return (object)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TValue AddValue(TKey key)
    {
        var val_2;
        var val_3;
        var val_4;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  X20, lockTaken: ref  val_1);
        if(X20 == 0)
        {
            goto label_1;
        }
        
        if((X20 & 1) == 0)
        {
            goto label_2;
        }
        
        val_2 = 0;
        val_3 = 0;
        val_4 = 129;
        goto label_21;
        label_1:
        mem[1152921525724368160] = __RuntimeMethodHiddenParam + 24 + 192 + 24;
        val_3 = 0;
        val_2 = 0;
        goto label_6;
        label_2:
        val_3 = 0;
        val_2 = 0;
        mem[1152921525724368160] = __RuntimeMethodHiddenParam + 24 + 192 + 24;
        label_6:
        val_4 = 127;
        label_21:
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  X20);
        }
        
        if(val_4 != 127)
        {
                if(val_4 == 129)
        {
                return (object)val_2;
        }
        
        }
        
        val_2 = X19;
        return (object)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Add(TKey key, TValue value)
    {
        System.NotImplementedException val_1 = new System.NotImplementedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool ContainsKey(TKey key)
    {
        if(X20 == 0)
        {
            
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.ICollection<TKey> get_Keys()
    {
        if(X19 == 0)
        {
            
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Remove(TKey key)
    {
        System.NotImplementedException val_1 = new System.NotImplementedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool TryGetValue(TKey key, out TValue value)
    {
        value = this;
        return true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.ICollection<TValue> get_Values()
    {
        if(X19 == 0)
        {
            
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TValue get_Item(TKey key)
    {
        if(this == null)
        {
            
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Item(TKey key, TValue value)
    {
        System.NotImplementedException val_1 = new System.NotImplementedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item)
    {
        System.NotImplementedException val_1 = new System.NotImplementedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Clear()
    {
        System.NotImplementedException val_1 = new System.NotImplementedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item)
    {
        System.NotImplementedException val_1 = new System.NotImplementedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int arrayIndex)
    {
        System.NotImplementedException val_1 = new System.NotImplementedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_Count()
    {
        if(X19 == 0)
        {
            
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_IsReadOnly()
    {
        System.NotImplementedException val_1 = new System.NotImplementedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item)
    {
        System.NotImplementedException val_1 = new System.NotImplementedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        return (System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return (System.Collections.IEnumerator);
    }

}
