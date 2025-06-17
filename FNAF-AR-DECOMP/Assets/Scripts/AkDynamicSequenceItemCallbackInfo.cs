using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkDynamicSequenceItemCallbackInfo : AkCallbackInfo
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint playingID { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint audioNodeID { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IntPtr pCustomInfo { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkDynamicSequenceItemCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
    {
        this = new System.Object();
        mem[1152921519298221744] = AkSoundEnginePINVOKE.CSharp_AkDynamicSequenceItemCallbackInfo_SWIGUpcast(jarg1:  cPtr);
        mem[1152921519298221752] = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkDynamicSequenceItemCallbackInfo obj)
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
        mem[1152921519298453936] = AkSoundEnginePINVOKE.CSharp_AkDynamicSequenceItemCallbackInfo_SWIGUpcast(jarg1:  cPtr);
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
                mem[1152921519298677944] = 0;
            AkSoundEnginePINVOKE.CSharp_delete_AkDynamicSequenceItemCallbackInfo(jarg1:  this.swigCPtr);
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
    public uint get_playingID()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDynamicSequenceItemCallbackInfo_playingID_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_audioNodeID()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDynamicSequenceItemCallbackInfo_audioNodeID_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IntPtr get_pCustomInfo()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDynamicSequenceItemCallbackInfo_pCustomInfo_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkDynamicSequenceItemCallbackInfo()
    {
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_new_AkDynamicSequenceItemCallbackInfo();
    }

}
