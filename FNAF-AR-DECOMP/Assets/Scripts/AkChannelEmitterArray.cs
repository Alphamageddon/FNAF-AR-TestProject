using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkChannelEmitterArray : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IntPtr m_Buffer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr m_Current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private uint m_MaxCount;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private uint <Count>k__BackingField;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint Count { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkChannelEmitterArray(uint in_Count)
    {
        IntPtr val_3 = System.Runtime.InteropServices.Marshal.AllocHGlobal(cb:  (in_Count + (in_Count << 2)) << 3);
        this.m_Buffer = val_3;
        this.m_Current = val_3;
        this.m_MaxCount = in_Count;
        this.<Count>k__BackingField = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_Count()
    {
        return (uint)this.<Count>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void set_Count(uint value)
    {
        this.<Count>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Dispose()
    {
        if((System.IntPtr.op_Inequality(value1:  this.m_Buffer, value2:  0)) == false)
        {
                return;
        }
        
        System.Runtime.InteropServices.Marshal.FreeHGlobal(hglobal:  this.m_Buffer);
        this.m_Buffer = 0;
        this.m_MaxCount = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void Finalize()
    {
        this.Dispose();
        this.Finalize();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Reset()
    {
        this.<Count>k__BackingField = 0;
        this.m_Current = this.m_Buffer;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Add(UnityEngine.Vector3 in_Pos, UnityEngine.Vector3 in_Forward, UnityEngine.Vector3 in_Top, uint in_ChannelMask)
    {
        float val_1;
        if((this.<Count>k__BackingField) < this.m_MaxCount)
        {
                System.Runtime.InteropServices.Marshal.WriteInt32(ptr:  this.m_Current, val:  System.BitConverter.ToInt32(value:  System.BitConverter.GetBytes(value:  in_Forward.x), startIndex:  0));
            long val_4 = this.m_Current.ToInt64();
            val_4 = val_4 + 4;
            IntPtr val_5 = System.IntPtr.op_Explicit(value:  val_4);
            this.m_Current = val_5;
            System.Runtime.InteropServices.Marshal.WriteInt32(ptr:  val_5, val:  System.BitConverter.ToInt32(value:  System.BitConverter.GetBytes(value:  in_Forward.y), startIndex:  0));
            long val_8 = this.m_Current.ToInt64();
            val_8 = val_8 + 4;
            IntPtr val_9 = System.IntPtr.op_Explicit(value:  val_8);
            this.m_Current = val_9;
            System.Runtime.InteropServices.Marshal.WriteInt32(ptr:  val_9, val:  System.BitConverter.ToInt32(value:  System.BitConverter.GetBytes(value:  in_Forward.z), startIndex:  0));
            long val_12 = this.m_Current.ToInt64();
            val_12 = val_12 + 4;
            IntPtr val_13 = System.IntPtr.op_Explicit(value:  val_12);
            this.m_Current = val_13;
            System.Runtime.InteropServices.Marshal.WriteInt32(ptr:  val_13, val:  System.BitConverter.ToInt32(value:  System.BitConverter.GetBytes(value:  in_Top.x), startIndex:  0));
            long val_16 = this.m_Current.ToInt64();
            val_16 = val_16 + 4;
            IntPtr val_17 = System.IntPtr.op_Explicit(value:  val_16);
            this.m_Current = val_17;
            System.Runtime.InteropServices.Marshal.WriteInt32(ptr:  val_17, val:  System.BitConverter.ToInt32(value:  System.BitConverter.GetBytes(value:  val_1), startIndex:  0));
            long val_20 = this.m_Current.ToInt64();
            val_20 = val_20 + 4;
            IntPtr val_21 = System.IntPtr.op_Explicit(value:  val_20);
            this.m_Current = val_21;
            System.Runtime.InteropServices.Marshal.WriteInt32(ptr:  val_21, val:  System.BitConverter.ToInt32(value:  System.BitConverter.GetBytes(value:  in_Top.y), startIndex:  0));
            long val_24 = this.m_Current.ToInt64();
            val_24 = val_24 + 4;
            IntPtr val_25 = System.IntPtr.op_Explicit(value:  val_24);
            this.m_Current = val_25;
            System.Runtime.InteropServices.Marshal.WriteInt32(ptr:  val_25, val:  System.BitConverter.ToInt32(value:  System.BitConverter.GetBytes(value:  in_Pos.x), startIndex:  0));
            long val_28 = this.m_Current.ToInt64();
            val_28 = val_28 + 4;
            IntPtr val_29 = System.IntPtr.op_Explicit(value:  val_28);
            this.m_Current = val_29;
            System.Runtime.InteropServices.Marshal.WriteInt32(ptr:  val_29, val:  System.BitConverter.ToInt32(value:  System.BitConverter.GetBytes(value:  in_Pos.y), startIndex:  0));
            long val_32 = this.m_Current.ToInt64();
            val_32 = val_32 + 4;
            IntPtr val_33 = System.IntPtr.op_Explicit(value:  val_32);
            this.m_Current = val_33;
            System.Runtime.InteropServices.Marshal.WriteInt32(ptr:  val_33, val:  System.BitConverter.ToInt32(value:  System.BitConverter.GetBytes(value:  in_Pos.z), startIndex:  0));
            long val_36 = this.m_Current.ToInt64();
            val_36 = val_36 + 4;
            IntPtr val_37 = System.IntPtr.op_Explicit(value:  val_36);
            this.m_Current = val_37;
            System.Runtime.InteropServices.Marshal.WriteInt32(ptr:  val_37, val:  in_ChannelMask);
            long val_38 = this.m_Current.ToInt64();
            val_38 = val_38 + 4;
            uint val_41 = this.<Count>k__BackingField;
            this.m_Current = System.IntPtr.op_Explicit(value:  val_38);
            val_41 = val_41 + 1;
            this.<Count>k__BackingField = val_41;
            return;
        }
        
        System.IndexOutOfRangeException val_40 = new System.IndexOutOfRangeException(message:  "Out of range access in AkChannelEmitterArray");
    }

}
