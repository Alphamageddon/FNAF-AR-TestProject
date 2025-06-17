using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkDurationCallbackInfo : AkEventCallbackInfo
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fDuration { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fEstimatedDuration { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint audioNodeID { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint mediaID { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool bStreaming { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkDurationCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
    {
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkDurationCallbackInfo_SWIGUpcast(jarg1:  cPtr);
        cMemoryOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkDurationCallbackInfo obj)
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
    internal override void setCPtr(IntPtr cPtr)
    {
        this.setCPtr(cPtr:  AkSoundEnginePINVOKE.CSharp_AkDurationCallbackInfo_SWIGUpcast(jarg1:  cPtr));
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void Finalize()
    {
        this.Finalize();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void Dispose()
    {
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  this, lockTaken: ref  val_1);
        if((System.IntPtr.op_Inequality(value1:  this.swigCPtr, value2:  0)) != false)
        {
                if(true != 0)
        {
                mem[1152921519297437752] = 0;
            AkSoundEnginePINVOKE.CSharp_delete_AkDurationCallbackInfo(jarg1:  this.swigCPtr);
        }
        
            this.swigCPtr = 0;
        }
        
        System.GC.SuppressFinalize(obj:  this);
        this.Dispose();
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  this);
        }
        
        if(91 == 91)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fDuration()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDurationCallbackInfo_fDuration_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fEstimatedDuration()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDurationCallbackInfo_fEstimatedDuration_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_audioNodeID()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDurationCallbackInfo_audioNodeID_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_mediaID()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDurationCallbackInfo_mediaID_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_bStreaming()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDurationCallbackInfo_bStreaming_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkDurationCallbackInfo()
    {
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_new_AkDurationCallbackInfo();
    }

}
