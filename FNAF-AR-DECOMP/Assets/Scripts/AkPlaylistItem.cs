using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkPlaylistItem : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint audioNodeID { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int msDelay { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IntPtr pCustomInfo { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkPlaylistItem(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkPlaylistItem obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkPlaylistItem(jarg1:  this.swigCPtr);
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
    public AkPlaylistItem()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkPlaylistItem__SWIG_0();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkPlaylistItem(AkPlaylistItem in_rCopy)
    {
        AkPlaylistItem val_2 = in_rCopy;
        if(val_2 != null)
        {
                val_2 = in_rCopy.swigCPtr;
        }
        
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkPlaylistItem__SWIG_1(jarg1:  val_2);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkPlaylistItem Assign(AkPlaylistItem in_rCopy)
    {
        AkPlaylistItem val_3 = in_rCopy;
        if(val_3 != null)
        {
                val_3 = in_rCopy.swigCPtr;
        }
        
        .swigCMemOwn = false;
        .swigCPtr = AkSoundEnginePINVOKE.CSharp_AkPlaylistItem_Assign(jarg1:  this.swigCPtr, jarg2:  val_3);
        return (AkPlaylistItem)new AkPlaylistItem();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsEqualTo(AkPlaylistItem in_rCopy)
    {
        AkPlaylistItem val_1 = in_rCopy;
        if(val_1 == null)
        {
                return AkSoundEnginePINVOKE.CSharp_AkPlaylistItem_IsEqualTo(jarg1:  this.swigCPtr, jarg2:  val_1 = in_rCopy.swigCPtr);
        }
        
        return AkSoundEnginePINVOKE.CSharp_AkPlaylistItem_IsEqualTo(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AKRESULT SetExternalSources(uint in_nExternalSrc, AkExternalSourceInfoArray in_pExternalSrc)
    {
        return AkSoundEnginePINVOKE.CSharp_AkPlaylistItem_SetExternalSources(jarg1:  this.swigCPtr, jarg2:  in_nExternalSrc, jarg3:  in_pExternalSrc.GetBuffer());
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_audioNodeID(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPlaylistItem_audioNodeID_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_audioNodeID()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPlaylistItem_audioNodeID_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_msDelay(int value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPlaylistItem_msDelay_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_msDelay()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPlaylistItem_msDelay_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_pCustomInfo(IntPtr value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPlaylistItem_pCustomInfo_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IntPtr get_pCustomInfo()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPlaylistItem_pCustomInfo_get(jarg1:  this.swigCPtr);
    }

}
