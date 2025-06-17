using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkMarkerCallbackInfo : AkEventCallbackInfo
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uIdentifier { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uPosition { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string strLabel { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkMarkerCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
    {
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkMarkerCallbackInfo_SWIGUpcast(jarg1:  cPtr);
        cMemoryOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkMarkerCallbackInfo obj)
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
        this.setCPtr(cPtr:  AkSoundEnginePINVOKE.CSharp_AkMarkerCallbackInfo_SWIGUpcast(jarg1:  cPtr));
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
                mem[1152921519318078392] = 0;
            AkSoundEnginePINVOKE.CSharp_delete_AkMarkerCallbackInfo(jarg1:  this.swigCPtr);
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
    public uint get_uIdentifier()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMarkerCallbackInfo_uIdentifier_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uPosition()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMarkerCallbackInfo_uPosition_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_strLabel()
    {
        return AkSoundEngine.StringFromIntPtrString(ptr:  AkSoundEnginePINVOKE.CSharp_AkMarkerCallbackInfo_strLabel_get(jarg1:  this.swigCPtr));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMarkerCallbackInfo()
    {
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_new_AkMarkerCallbackInfo();
    }

}
