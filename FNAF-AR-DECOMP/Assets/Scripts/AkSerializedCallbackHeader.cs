using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkSerializedCallbackHeader : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IntPtr pPackage { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkSerializedCallbackHeader pNext { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCallbackType eType { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkSerializedCallbackHeader(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkSerializedCallbackHeader obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkSerializedCallbackHeader(jarg1:  this.swigCPtr);
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
    public IntPtr get_pPackage()
    {
        return AkSoundEnginePINVOKE.CSharp_AkSerializedCallbackHeader_pPackage_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkSerializedCallbackHeader get_pNext()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkSerializedCallbackHeader_pNext_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkSerializedCallbackHeader)val_4;
        }
        
        AkSerializedCallbackHeader val_3 = null;
        val_4 = val_3;
        val_3 = new AkSerializedCallbackHeader();
        .swigCMemOwn = false;
        .swigCPtr = val_1;
        return (AkSerializedCallbackHeader)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCallbackType get_eType()
    {
        return AkSoundEnginePINVOKE.CSharp_AkSerializedCallbackHeader_eType_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IntPtr GetData()
    {
        return AkSoundEnginePINVOKE.CSharp_AkSerializedCallbackHeader_GetData(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkSerializedCallbackHeader()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkSerializedCallbackHeader();
    }

}
