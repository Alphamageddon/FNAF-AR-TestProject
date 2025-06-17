using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkMonitoringCallbackInfo : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMonitorErrorCode errorCode { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMonitorErrorLevel errorLevel { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint playingID { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ulong gameObjID { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string message { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkMonitoringCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkMonitoringCallbackInfo obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkMonitoringCallbackInfo(jarg1:  this.swigCPtr);
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
    public AkMonitorErrorCode get_errorCode()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMonitoringCallbackInfo_errorCode_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMonitorErrorLevel get_errorLevel()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMonitoringCallbackInfo_errorLevel_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_playingID()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMonitoringCallbackInfo_playingID_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ulong get_gameObjID()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMonitoringCallbackInfo_gameObjID_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_message()
    {
        return AkSoundEngine.StringFromIntPtrOSString(ptr:  AkSoundEnginePINVOKE.CSharp_AkMonitoringCallbackInfo_message_get(jarg1:  this.swigCPtr));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMonitoringCallbackInfo()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkMonitoringCallbackInfo();
    }

}
