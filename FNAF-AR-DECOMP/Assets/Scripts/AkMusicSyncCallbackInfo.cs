using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkMusicSyncCallbackInfo : AkCallbackInfo
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint playingID { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int segmentInfo_iCurrentPosition { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int segmentInfo_iPreEntryDuration { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int segmentInfo_iActiveDuration { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int segmentInfo_iPostExitDuration { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int segmentInfo_iRemainingLookAheadTime { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float segmentInfo_fBeatDuration { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float segmentInfo_fBarDuration { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float segmentInfo_fGridDuration { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float segmentInfo_fGridOffset { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCallbackType musicSyncType { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string userCueName { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkMusicSyncCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
    {
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_SWIGUpcast(jarg1:  cPtr);
        cMemoryOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkMusicSyncCallbackInfo obj)
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
        this.setCPtr(cPtr:  AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_SWIGUpcast(jarg1:  cPtr));
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
                mem[1152921519339516728] = 0;
            AkSoundEnginePINVOKE.CSharp_delete_AkMusicSyncCallbackInfo(jarg1:  this.swigCPtr);
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
        return AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_playingID_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_segmentInfo_iCurrentPosition()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_segmentInfo_iCurrentPosition_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_segmentInfo_iPreEntryDuration()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPreEntryDuration_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_segmentInfo_iActiveDuration()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_segmentInfo_iActiveDuration_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_segmentInfo_iPostExitDuration()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPostExitDuration_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_segmentInfo_iRemainingLookAheadTime()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_segmentInfo_iRemainingLookAheadTime_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_segmentInfo_fBeatDuration()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBeatDuration_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_segmentInfo_fBarDuration()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBarDuration_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_segmentInfo_fGridDuration()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridDuration_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_segmentInfo_fGridOffset()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridOffset_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCallbackType get_musicSyncType()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_musicSyncType_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_userCueName()
    {
        return AkSoundEngine.StringFromIntPtrString(ptr:  AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_userCueName_get(jarg1:  this.swigCPtr));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMusicSyncCallbackInfo()
    {
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_new_AkMusicSyncCallbackInfo();
    }

}
