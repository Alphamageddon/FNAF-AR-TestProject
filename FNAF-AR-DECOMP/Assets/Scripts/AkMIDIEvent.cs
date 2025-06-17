using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkMIDIEvent : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte byChan { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIEvent.tGen Gen { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIEvent.tCc Cc { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIEvent.tNoteOnOff NoteOnOff { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIEvent.tPitchBend PitchBend { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIEvent.tNoteAftertouch NoteAftertouch { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIEvent.tChanAftertouch ChanAftertouch { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIEvent.tProgramChange ProgramChange { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIEventTypes byType { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte byOnOffNote { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte byVelocity { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDICcTypes byCc { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte byCcValue { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte byValueLsb { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte byValueMsb { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte byAftertouchNote { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte byNoteAftertouchValue { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte byChanAftertouchValue { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte byProgramNum { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkMIDIEvent(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkMIDIEvent obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkMIDIEvent(jarg1:  this.swigCPtr);
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
    public void set_byChan(byte value)
    {
        AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byChan_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_byChan()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byChan_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Gen(AkMIDIEvent.tGen value)
    {
        tGen val_1 = value;
        if(val_1 != null)
        {
                val_1 = value.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_Gen_set(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIEvent.tGen get_Gen()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_Gen_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (tGen)val_4;
        }
        
        AkMIDIEvent.tGen val_3 = null;
        val_4 = val_3;
        val_3 = new AkMIDIEvent.tGen();
        .swigCMemOwn = false;
        .swigCPtr = val_1;
        return (tGen)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Cc(AkMIDIEvent.tCc value)
    {
        tCc val_1 = value;
        if(val_1 != null)
        {
                val_1 = value.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_Cc_set(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIEvent.tCc get_Cc()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_Cc_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (tCc)val_4;
        }
        
        AkMIDIEvent.tCc val_3 = null;
        val_4 = val_3;
        val_3 = new AkMIDIEvent.tCc();
        .swigCMemOwn = false;
        .swigCPtr = val_1;
        return (tCc)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_NoteOnOff(AkMIDIEvent.tNoteOnOff value)
    {
        tNoteOnOff val_1 = value;
        if(val_1 != null)
        {
                val_1 = value.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_NoteOnOff_set(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIEvent.tNoteOnOff get_NoteOnOff()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_NoteOnOff_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (tNoteOnOff)val_4;
        }
        
        AkMIDIEvent.tNoteOnOff val_3 = null;
        val_4 = val_3;
        val_3 = new AkMIDIEvent.tNoteOnOff();
        .swigCMemOwn = false;
        .swigCPtr = val_1;
        return (tNoteOnOff)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PitchBend(AkMIDIEvent.tPitchBend value)
    {
        tPitchBend val_1 = value;
        if(val_1 != null)
        {
                val_1 = value.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_PitchBend_set(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIEvent.tPitchBend get_PitchBend()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_PitchBend_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (tPitchBend)val_4;
        }
        
        AkMIDIEvent.tPitchBend val_3 = null;
        val_4 = val_3;
        val_3 = new AkMIDIEvent.tPitchBend();
        .swigCMemOwn = false;
        .swigCPtr = val_1;
        return (tPitchBend)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_NoteAftertouch(AkMIDIEvent.tNoteAftertouch value)
    {
        tNoteAftertouch val_1 = value;
        if(val_1 != null)
        {
                val_1 = value.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_NoteAftertouch_set(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIEvent.tNoteAftertouch get_NoteAftertouch()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_NoteAftertouch_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (tNoteAftertouch)val_4;
        }
        
        AkMIDIEvent.tNoteAftertouch val_3 = null;
        val_4 = val_3;
        val_3 = new AkMIDIEvent.tNoteAftertouch();
        .swigCMemOwn = false;
        .swigCPtr = val_1;
        return (tNoteAftertouch)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ChanAftertouch(AkMIDIEvent.tChanAftertouch value)
    {
        tChanAftertouch val_1 = value;
        if(val_1 != null)
        {
                val_1 = value.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_ChanAftertouch_set(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIEvent.tChanAftertouch get_ChanAftertouch()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_ChanAftertouch_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (tChanAftertouch)val_4;
        }
        
        AkMIDIEvent.tChanAftertouch val_3 = null;
        val_4 = val_3;
        val_3 = new AkMIDIEvent.tChanAftertouch();
        .swigCMemOwn = false;
        .swigCPtr = val_1;
        return (tChanAftertouch)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ProgramChange(AkMIDIEvent.tProgramChange value)
    {
        tProgramChange val_1 = value;
        if(val_1 != null)
        {
                val_1 = value.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_ProgramChange_set(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIEvent.tProgramChange get_ProgramChange()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_ProgramChange_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (tProgramChange)val_4;
        }
        
        AkMIDIEvent.tProgramChange val_3 = null;
        val_4 = val_3;
        val_3 = new AkMIDIEvent.tProgramChange();
        .swigCMemOwn = false;
        .swigCPtr = val_1;
        return (tProgramChange)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_byType(AkMIDIEventTypes value)
    {
        AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byType_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIEventTypes get_byType()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byType_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_byOnOffNote(byte value)
    {
        AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byOnOffNote_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_byOnOffNote()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byOnOffNote_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_byVelocity(byte value)
    {
        AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byVelocity_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_byVelocity()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byVelocity_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_byCc(AkMIDICcTypes value)
    {
        AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byCc_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDICcTypes get_byCc()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byCc_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_byCcValue(byte value)
    {
        AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byCcValue_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_byCcValue()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byCcValue_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_byValueLsb(byte value)
    {
        AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byValueLsb_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_byValueLsb()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byValueLsb_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_byValueMsb(byte value)
    {
        AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byValueMsb_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_byValueMsb()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byValueMsb_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_byAftertouchNote(byte value)
    {
        AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byAftertouchNote_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_byAftertouchNote()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byAftertouchNote_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_byNoteAftertouchValue(byte value)
    {
        AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byNoteAftertouchValue_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_byNoteAftertouchValue()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byNoteAftertouchValue_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_byChanAftertouchValue(byte value)
    {
        AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byChanAftertouchValue_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_byChanAftertouchValue()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byChanAftertouchValue_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_byProgramNum(byte value)
    {
        AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byProgramNum_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_byProgramNum()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byProgramNum_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIEvent()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkMIDIEvent();
    }

}
