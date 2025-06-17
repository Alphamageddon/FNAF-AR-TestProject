using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkMIDIEventCallbackInfo : AkEventCallbackInfo
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte byChan { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte byParam1 { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte byParam2 { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIEventTypes byType { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte byOnOffNote { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte byVelocity { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDICcTypes byCc { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte byCcValue { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte byValueLsb { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte byValueMsb { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte byAftertouchNote { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte byNoteAftertouchValue { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte byChanAftertouchValue { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte byProgramNum { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkMIDIEventCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
    {
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkMIDIEventCallbackInfo_SWIGUpcast(jarg1:  cPtr);
        cMemoryOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkMIDIEventCallbackInfo obj)
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
        this.setCPtr(cPtr:  AkSoundEnginePINVOKE.CSharp_AkMIDIEventCallbackInfo_SWIGUpcast(jarg1:  cPtr));
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
                mem[1152921519332739384] = 0;
            AkSoundEnginePINVOKE.CSharp_delete_AkMIDIEventCallbackInfo(jarg1:  this.swigCPtr);
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
    public byte get_byChan()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEventCallbackInfo_byChan_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_byParam1()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEventCallbackInfo_byParam1_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_byParam2()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEventCallbackInfo_byParam2_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIEventTypes get_byType()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEventCallbackInfo_byType_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_byOnOffNote()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEventCallbackInfo_byOnOffNote_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_byVelocity()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEventCallbackInfo_byVelocity_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDICcTypes get_byCc()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEventCallbackInfo_byCc_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_byCcValue()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEventCallbackInfo_byCcValue_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_byValueLsb()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEventCallbackInfo_byValueLsb_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_byValueMsb()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEventCallbackInfo_byValueMsb_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_byAftertouchNote()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEventCallbackInfo_byAftertouchNote_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_byNoteAftertouchValue()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEventCallbackInfo_byNoteAftertouchValue_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_byChanAftertouchValue()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEventCallbackInfo_byChanAftertouchValue_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_byProgramNum()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEventCallbackInfo_byProgramNum_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIEventCallbackInfo()
    {
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_new_AkMIDIEventCallbackInfo();
    }

}
