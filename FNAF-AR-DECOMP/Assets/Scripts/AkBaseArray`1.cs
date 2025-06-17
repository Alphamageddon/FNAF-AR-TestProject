using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public abstract class AkBaseArray<T> : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <Capacity>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr m_Buffer;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int Capacity { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected abstract int StructureSize { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public T Item { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkBaseArray<T>(int capacity)
    {
        var val_4;
        if(this != null)
        {
                val_4 = 0;
        }
        else
        {
                val_4 = 0;
        }
        
        IntPtr val_2 = System.Runtime.InteropServices.Marshal.AllocHGlobal(cb:  this * capacity);
        mem[1152921519409739064] = val_2;
        if((System.IntPtr.op_Inequality(value1:  val_2, value2:  0)) == false)
        {
                return;
        }
        
        if(capacity < 1)
        {
                return;
        }
        
        var val_4 = 0;
        do
        {
            val_4 = val_4 + 1;
        }
        while(capacity != val_4);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Dispose()
    {
        var val_7 = this;
        if((System.IntPtr.op_Inequality(value1:  1485, value2:  0)) == false)
        {
                return;
        }
        
        if(val_7 >= 1)
        {
                IntPtr val_7 = 0;
            do
        {
            val_7 = val_7 + 1;
        }
        while(val_7 < val_7);
        
        }
        
        System.Runtime.InteropServices.Marshal.FreeHGlobal(hglobal:  val_7);
        mem[1152921519409851064] = 0;
        val_7 = ???;
        goto __RuntimeMethodHiddenParam + 24 + 192 + 8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void Finalize()
    {
        this.Finalize();
        if(15 == 15)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        this = ???;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_Capacity()
    {
        return (int)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void set_Capacity(int value)
    {
        mem[1152921519410187056] = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual int Count()
    {
        if(this == null)
        {
            
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected abstract int get_StructureSize(); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected virtual void DefaultConstructAtIntPtr(IntPtr address)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected virtual void ReleaseAllocatedMemoryFromReferenceAtIntPtr(IntPtr address)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected abstract T CreateNewReferenceFromIntPtr(IntPtr address); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected abstract void CloneIntoReferenceFromIntPtr(IntPtr address, T other); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public T get_Item(int index)
    {
        if(this == null)
        {
            
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Item(int index, T value)
    {
        if(this == null)
        {
            
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IntPtr GetBuffer()
    {
        return (IntPtr)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected IntPtr GetObjectPtr(int index)
    {
        if(this > index)
        {
                long val_6 = this;
            val_6 = emailUIDataHandler + ((val_6 * index) << );
            return System.IntPtr.op_Explicit(value:  val_6);
        }
        
        System.IndexOutOfRangeException val_5 = new System.IndexOutOfRangeException(message:  "Out of range access in " + this.GetType());
    }

}
