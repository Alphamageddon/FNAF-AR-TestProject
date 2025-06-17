using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkIterator : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkPlaylistItem pItem { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkIterator(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkIterator obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkIterator(jarg1:  this.swigCPtr);
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
    public void set_pItem(AkPlaylistItem value)
    {
        AkPlaylistItem val_1 = value;
        if(val_1 != null)
        {
                val_1 = value.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkIterator_pItem_set(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkPlaylistItem get_pItem()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkIterator_pItem_get(jarg1:  this.swigCPtr);
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
    public AkIterator NextIter()
    {
        .swigCMemOwn = false;
        .swigCPtr = AkSoundEnginePINVOKE.CSharp_AkIterator_NextIter(jarg1:  this.swigCPtr);
        return (AkIterator)new AkIterator();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkIterator PrevIter()
    {
        .swigCMemOwn = false;
        .swigCPtr = AkSoundEnginePINVOKE.CSharp_AkIterator_PrevIter(jarg1:  this.swigCPtr);
        return (AkIterator)new AkIterator();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkPlaylistItem GetItem()
    {
        .swigCMemOwn = false;
        .swigCPtr = AkSoundEnginePINVOKE.CSharp_AkIterator_GetItem(jarg1:  this.swigCPtr);
        return (AkPlaylistItem)new AkPlaylistItem();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsEqualTo(AkIterator in_rOp)
    {
        AkIterator val_1 = in_rOp;
        if(val_1 == null)
        {
                return AkSoundEnginePINVOKE.CSharp_AkIterator_IsEqualTo(jarg1:  this.swigCPtr, jarg2:  val_1 = in_rOp.swigCPtr);
        }
        
        return AkSoundEnginePINVOKE.CSharp_AkIterator_IsEqualTo(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsDifferentFrom(AkIterator in_rOp)
    {
        AkIterator val_1 = in_rOp;
        if(val_1 == null)
        {
                return AkSoundEnginePINVOKE.CSharp_AkIterator_IsDifferentFrom(jarg1:  this.swigCPtr, jarg2:  val_1 = in_rOp.swigCPtr);
        }
        
        return AkSoundEnginePINVOKE.CSharp_AkIterator_IsDifferentFrom(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkIterator()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkIterator();
    }

}
