using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkMIDIPostArray
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly int m_Count;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly int SIZE_OF;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr m_Buffer;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIPost Item { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIPostArray(int size)
    {
        this.SIZE_OF = AkSoundEnginePINVOKE.CSharp_AkMIDIPost_GetSizeOf();
        this.m_Buffer = 0;
        this.m_Count = size;
        this.m_Buffer = System.Runtime.InteropServices.Marshal.AllocHGlobal(cb:  this.SIZE_OF * size);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIPost get_Item(int index)
    {
        if(this.m_Count > index)
        {
                long val_1 = this.m_Buffer.ToInt64();
            int val_5 = this.SIZE_OF;
            val_5 = val_5 * index;
            val_1 = val_1 + (val_5 << );
            return (AkMIDIPost)new AkMIDIPost(cPtr:  System.IntPtr.op_Explicit(value:  val_1), cMemoryOwn:  false);
        }
        
        System.IndexOutOfRangeException val_4 = new System.IndexOutOfRangeException(message:  "Out of range access in AkMIDIPostArray");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Item(int index, AkMIDIPost value)
    {
        AkMIDIPost val_4 = value;
        if(this.m_Count > index)
        {
                long val_1 = this.m_Buffer.ToInt64();
            int val_4 = this.SIZE_OF;
            val_4 = val_4 * index;
            val_1 = val_1 + (val_4 << );
            if(val_4 != null)
        {
                val_4 = value.swigCPtr;
        }
        
            AkSoundEnginePINVOKE.CSharp_AkMIDIPost_Clone(jarg1:  System.IntPtr.op_Explicit(value:  val_1), jarg2:  val_4);
            return;
        }
        
        System.IndexOutOfRangeException val_3 = new System.IndexOutOfRangeException(message:  "Out of range access in AkMIDIPostArray");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void Finalize()
    {
        System.Runtime.InteropServices.Marshal.FreeHGlobal(hglobal:  this.m_Buffer);
        this.m_Buffer = 0;
        this.Finalize();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void PostOnEvent(uint in_eventID, UnityEngine.GameObject gameObject)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  gameObject);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  gameObject, id:  val_1);
        int val_2 = AkSoundEnginePINVOKE.CSharp_AkMIDIPost_PostOnEvent(jarg1:  this.m_Buffer, jarg2:  in_eventID, jarg3:  val_1, jarg4:  this.m_Count);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void PostOnEvent(uint in_eventID, UnityEngine.GameObject gameObject, int count)
    {
        if(this.m_Count > count)
        {
                ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  gameObject);
            AkSoundEngine.PreGameObjectAPICall(gameObject:  gameObject, id:  val_1);
            int val_2 = AkSoundEnginePINVOKE.CSharp_AkMIDIPost_PostOnEvent(jarg1:  this.m_Buffer, jarg2:  in_eventID, jarg3:  val_1, jarg4:  count);
            return;
        }
        
        System.IndexOutOfRangeException val_3 = new System.IndexOutOfRangeException(message:  "Out of range access in AkMIDIPostArray");
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
        int val_2 = this.SIZE_OF;
        val_2 = val_2 * index;
        val_1 = val_1 + (val_2 << );
        return System.IntPtr.op_Explicit(value:  val_1);
    }

}
