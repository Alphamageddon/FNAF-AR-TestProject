using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkAuxSendArray : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const int MAX_COUNT = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly int SIZE_OF_AKAUXSENDVALUE;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr m_Buffer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int m_Count;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkAuxSendValue Item { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool isFull { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkAuxSendArray()
    {
        this.SIZE_OF_AKAUXSENDVALUE = AkSoundEnginePINVOKE.CSharp_AkAuxSendValue_GetSizeOf();
        this.m_Buffer = System.Runtime.InteropServices.Marshal.AllocHGlobal(cb:  this.SIZE_OF_AKAUXSENDVALUE << 2);
        this.m_Count = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkAuxSendValue get_Item(int index)
    {
        if(this.m_Count > index)
        {
                long val_1 = this.m_Buffer.ToInt64();
            int val_5 = this.SIZE_OF_AKAUXSENDVALUE;
            val_5 = val_5 * index;
            val_1 = val_1 + (val_5 << );
            .swigCMemOwn = false;
            .swigCPtr = System.IntPtr.op_Explicit(value:  val_1);
            return (AkAuxSendValue)new AkAuxSendValue();
        }
        
        System.IndexOutOfRangeException val_4 = new System.IndexOutOfRangeException(message:  "Out of range access in AkAuxSendArray");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_isFull()
    {
        if(this.m_Count > 3)
        {
                return true;
        }
        
        return System.IntPtr.op_Equality(value1:  this.m_Buffer, value2:  0);
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
        this.m_Count = 0;
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
        this.m_Count = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Add(UnityEngine.GameObject in_listenerGameObj, uint in_AuxBusID, float in_fValue)
    {
        UnityEngine.GameObject val_5;
        var val_6;
        val_5 = in_listenerGameObj;
        if(this.isFull != false)
        {
                val_6 = 0;
            return (bool)val_6;
        }
        
        long val_2 = this.m_Buffer.ToInt64();
        int val_5 = this.SIZE_OF_AKAUXSENDVALUE;
        val_5 = val_5 * this.m_Count;
        val_2 = val_2 + (val_5 << );
        val_5 = AkSoundEngine.GetAkGameObjectID(gameObject:  val_5);
        AkSoundEnginePINVOKE.CSharp_AkAuxSendValue_Set(jarg1:  System.IntPtr.op_Explicit(value:  val_2), jarg2:  val_5, jarg3:  in_AuxBusID, jarg4:  in_fValue);
        int val_6 = this.m_Count;
        val_6 = 1;
        val_6 = val_6 + 1;
        this.m_Count = val_6;
        return (bool)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Add(uint in_AuxBusID, float in_fValue)
    {
        var val_4;
        if(this.isFull != false)
        {
                val_4 = 0;
            return (bool)val_4;
        }
        
        long val_2 = this.m_Buffer.ToInt64();
        int val_4 = this.SIZE_OF_AKAUXSENDVALUE;
        val_4 = val_4 * this.m_Count;
        val_2 = val_2 + (val_4 << );
        AkSoundEnginePINVOKE.CSharp_AkAuxSendValue_Set(jarg1:  System.IntPtr.op_Explicit(value:  val_2), jarg2:  0, jarg3:  in_AuxBusID, jarg4:  in_fValue);
        int val_5 = this.m_Count;
        val_4 = 1;
        val_5 = val_5 + 1;
        this.m_Count = val_5;
        return (bool)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Contains(UnityEngine.GameObject in_listenerGameObj, uint in_AuxBusID)
    {
        if(((System.IntPtr.op_Equality(value1:  this.m_Buffer, value2:  0)) != true) && (this.m_Count >= 1))
        {
                var val_7 = 0;
            do
        {
            long val_2 = this.m_Buffer.ToInt64();
            int val_6 = this.SIZE_OF_AKAUXSENDVALUE;
            val_6 = val_6 * val_7;
            val_2 = val_2 + (val_6 << );
            if((AkSoundEnginePINVOKE.CSharp_AkAuxSendValue_IsSame(jarg1:  System.IntPtr.op_Explicit(value:  val_2), jarg2:  AkSoundEngine.GetAkGameObjectID(gameObject:  in_listenerGameObj), jarg3:  in_AuxBusID)) == true)
        {
                return false;
        }
        
            val_7 = val_7 + 1;
        }
        while(val_7 < this.m_Count);
        
        }
        
        return false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Contains(uint in_AuxBusID)
    {
        if(((System.IntPtr.op_Equality(value1:  this.m_Buffer, value2:  0)) != true) && (this.m_Count >= 1))
        {
                var val_6 = 0;
            do
        {
            long val_2 = this.m_Buffer.ToInt64();
            int val_5 = this.SIZE_OF_AKAUXSENDVALUE;
            val_5 = val_5 * val_6;
            val_2 = val_2 + (val_5 << );
            if((AkSoundEnginePINVOKE.CSharp_AkAuxSendValue_IsSame(jarg1:  System.IntPtr.op_Explicit(value:  val_2), jarg2:  0, jarg3:  in_AuxBusID)) == true)
        {
                return false;
        }
        
            val_6 = val_6 + 1;
        }
        while(val_6 < this.m_Count);
        
        }
        
        return false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AKRESULT SetValues(UnityEngine.GameObject gameObject)
    {
        return AkSoundEnginePINVOKE.CSharp_SetGameObjectAuxSendValues(jarg1:  AkSoundEngine.GetAkGameObjectID(gameObject:  gameObject), jarg2:  this.m_Buffer, jarg3:  this.m_Count);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AKRESULT GetValues(UnityEngine.GameObject gameObject)
    {
        this.m_Count = 4;
        return (AKRESULT)AkSoundEnginePINVOKE.CSharp_GetGameObjectAuxSendValues(jarg1:  AkSoundEngine.GetAkGameObjectID(gameObject:  gameObject), jarg2:  this.m_Buffer, jarg3: ref  4);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IntPtr GetBuffer()
    {
        return (IntPtr)this.m_Buffer;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int Count()
    {
        return (int)this.m_Count;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr GetObjectPtr(int index)
    {
        long val_1 = this.m_Buffer.ToInt64();
        int val_2 = this.SIZE_OF_AKAUXSENDVALUE;
        val_2 = val_2 * index;
        val_1 = val_1 + (val_2 << );
        return System.IntPtr.op_Explicit(value:  val_1);
    }

}
