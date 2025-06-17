using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkPlaylistArray : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkPlaylistArray(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkPlaylistArray obj)
    {
        IntPtr val_1;
        if(obj != null)
        {
                val_1 = obj.swigCPtr;
            return (IntPtr)val_1;
        }
        
        val_1 = 0;
        return (IntPtr)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal virtual void setCPtr(IntPtr cPtr)
    {
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void Finalize()
    {
        this.Finalize();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void Dispose()
    {
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  this, lockTaken: ref  val_1);
        if((System.IntPtr.op_Inequality(value1:  this.swigCPtr, value2:  0)) != false)
        {
                if(this.swigCMemOwn != false)
        {
                this.swigCMemOwn = false;
            AkSoundEnginePINVOKE.CSharp_delete_AkPlaylistArray(jarg1:  this.swigCPtr);
        }
        
            this.swigCPtr = 0;
        }
        
        System.GC.SuppressFinalize(obj:  this);
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  this);
        }
        
        if(85 == 85)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkPlaylistArray()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkPlaylistArray();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkIterator Begin()
    {
        .swigCMemOwn = true;
        .swigCPtr = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Begin(jarg1:  this.swigCPtr);
        return (AkIterator)new AkIterator();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkIterator End()
    {
        .swigCMemOwn = true;
        .swigCPtr = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_End(jarg1:  this.swigCPtr);
        return (AkIterator)new AkIterator();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkIterator FindEx(AkPlaylistItem in_Item)
    {
        AkPlaylistItem val_3 = in_Item;
        if(val_3 != null)
        {
                val_3 = in_Item.swigCPtr;
        }
        
        .swigCMemOwn = true;
        .swigCPtr = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_FindEx(jarg1:  this.swigCPtr, jarg2:  val_3);
        return (AkIterator)new AkIterator();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkIterator Erase(AkIterator in_rIter)
    {
        AkIterator val_3 = in_rIter;
        if(val_3 != null)
        {
                val_3 = in_rIter.swigCPtr;
        }
        
        .swigCMemOwn = true;
        .swigCPtr = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Erase__SWIG_0(jarg1:  this.swigCPtr, jarg2:  val_3);
        return (AkIterator)new AkIterator();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Erase(uint in_uIndex)
    {
        AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Erase__SWIG_1(jarg1:  this.swigCPtr, jarg2:  in_uIndex);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkIterator EraseSwap(AkIterator in_rIter)
    {
        AkIterator val_3 = in_rIter;
        if(val_3 != null)
        {
                val_3 = in_rIter.swigCPtr;
        }
        
        .swigCMemOwn = true;
        .swigCPtr = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_EraseSwap(jarg1:  this.swigCPtr, jarg2:  val_3);
        return (AkIterator)new AkIterator();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AKRESULT Reserve(uint in_ulReserve)
    {
        return AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Reserve(jarg1:  this.swigCPtr, jarg2:  in_ulReserve);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint Reserved()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Reserved(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Term()
    {
        AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Term(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint Length()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Length(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkPlaylistItem Data()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Data(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkPlaylistItem)val_4;
        }
        
        AkPlaylistItem val_3 = null;
        val_4 = val_3;
        val_3 = new AkPlaylistItem();
        .swigCMemOwn = false;
        .swigCPtr = val_1;
        return (AkPlaylistItem)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsEmpty()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_IsEmpty(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkPlaylistItem Exists(AkPlaylistItem in_Item)
    {
        IntPtr val_4;
        var val_5;
        val_4 = in_Item;
        if(val_4 != null)
        {
                val_4 = in_Item.swigCPtr;
        }
        
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Exists(jarg1:  this.swigCPtr, jarg2:  val_4);
        val_5 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkPlaylistItem)val_5;
        }
        
        AkPlaylistItem val_3 = null;
        val_5 = val_3;
        val_3 = new AkPlaylistItem();
        .swigCMemOwn = false;
        .swigCPtr = val_1;
        return (AkPlaylistItem)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkPlaylistItem AddLast()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_AddLast__SWIG_0(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkPlaylistItem)val_4;
        }
        
        AkPlaylistItem val_3 = null;
        val_4 = val_3;
        val_3 = new AkPlaylistItem();
        .swigCMemOwn = false;
        .swigCPtr = val_1;
        return (AkPlaylistItem)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkPlaylistItem AddLast(AkPlaylistItem in_rItem)
    {
        IntPtr val_4;
        var val_5;
        val_4 = in_rItem;
        if(val_4 != null)
        {
                val_4 = in_rItem.swigCPtr;
        }
        
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_AddLast__SWIG_1(jarg1:  this.swigCPtr, jarg2:  val_4);
        val_5 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkPlaylistItem)val_5;
        }
        
        AkPlaylistItem val_3 = null;
        val_5 = val_3;
        val_3 = new AkPlaylistItem();
        .swigCMemOwn = false;
        .swigCPtr = val_1;
        return (AkPlaylistItem)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkPlaylistItem Last()
    {
        .swigCMemOwn = false;
        .swigCPtr = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Last(jarg1:  this.swigCPtr);
        return (AkPlaylistItem)new AkPlaylistItem();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void RemoveLast()
    {
        AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_RemoveLast(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AKRESULT Remove(AkPlaylistItem in_rItem)
    {
        AkPlaylistItem val_1 = in_rItem;
        if(val_1 == null)
        {
                return AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Remove(jarg1:  this.swigCPtr, jarg2:  val_1 = in_rItem.swigCPtr);
        }
        
        return AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Remove(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AKRESULT RemoveSwap(AkPlaylistItem in_rItem)
    {
        AkPlaylistItem val_1 = in_rItem;
        if(val_1 == null)
        {
                return AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_RemoveSwap(jarg1:  this.swigCPtr, jarg2:  val_1 = in_rItem.swigCPtr);
        }
        
        return AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_RemoveSwap(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void RemoveAll()
    {
        AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_RemoveAll(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkPlaylistItem ItemAtIndex(uint uiIndex)
    {
        .swigCMemOwn = false;
        .swigCPtr = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_ItemAtIndex(jarg1:  this.swigCPtr, jarg2:  uiIndex);
        return (AkPlaylistItem)new AkPlaylistItem();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkPlaylistItem Insert(uint in_uIndex)
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Insert(jarg1:  this.swigCPtr, jarg2:  in_uIndex);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkPlaylistItem)val_4;
        }
        
        AkPlaylistItem val_3 = null;
        val_4 = val_3;
        val_3 = new AkPlaylistItem();
        .swigCMemOwn = false;
        .swigCPtr = val_1;
        return (AkPlaylistItem)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool GrowArray(uint in_uGrowBy)
    {
        return AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_GrowArray__SWIG_0(jarg1:  this.swigCPtr, jarg2:  in_uGrowBy);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool GrowArray()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_GrowArray__SWIG_1(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Resize(uint in_uiSize)
    {
        return AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Resize(jarg1:  this.swigCPtr, jarg2:  in_uiSize);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Transfer(AkPlaylistArray in_rSource)
    {
        AkPlaylistArray val_1 = in_rSource;
        if(val_1 != null)
        {
                val_1 = in_rSource.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Transfer(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AKRESULT Copy(AkPlaylistArray in_rSource)
    {
        AkPlaylistArray val_1 = in_rSource;
        if(val_1 == null)
        {
                return AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Copy(jarg1:  this.swigCPtr, jarg2:  val_1 = in_rSource.swigCPtr);
        }
        
        return AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Copy(jarg1:  this.swigCPtr, jarg2:  val_1);
    }

}
