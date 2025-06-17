using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkSegmentInfo : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int iCurrentPosition { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int iPreEntryDuration { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int iActiveDuration { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int iPostExitDuration { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int iRemainingLookAheadTime { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fBeatDuration { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fBarDuration { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fGridDuration { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fGridOffset { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkSegmentInfo(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkSegmentInfo obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkSegmentInfo(jarg1:  this.swigCPtr);
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
    public void set_iCurrentPosition(int value)
    {
        AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_iCurrentPosition_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_iCurrentPosition()
    {
        return AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_iCurrentPosition_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_iPreEntryDuration(int value)
    {
        AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_iPreEntryDuration_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_iPreEntryDuration()
    {
        return AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_iPreEntryDuration_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_iActiveDuration(int value)
    {
        AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_iActiveDuration_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_iActiveDuration()
    {
        return AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_iActiveDuration_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_iPostExitDuration(int value)
    {
        AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_iPostExitDuration_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_iPostExitDuration()
    {
        return AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_iPostExitDuration_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_iRemainingLookAheadTime(int value)
    {
        AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_iRemainingLookAheadTime_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_iRemainingLookAheadTime()
    {
        return AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_iRemainingLookAheadTime_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_fBeatDuration(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_fBeatDuration_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fBeatDuration()
    {
        return AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_fBeatDuration_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_fBarDuration(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_fBarDuration_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fBarDuration()
    {
        return AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_fBarDuration_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_fGridDuration(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_fGridDuration_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fGridDuration()
    {
        return AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_fGridDuration_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_fGridOffset(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_fGridOffset_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fGridOffset()
    {
        return AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_fGridOffset_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkSegmentInfo()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkSegmentInfo();
    }

}
