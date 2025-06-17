using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkPositioningInfo : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fCenterPct { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkSpeakerPanningType pannerType { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Ak3DPositionType e3dPositioningType { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool bHoldEmitterPosAndOrient { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Ak3DSpatializationMode e3DSpatializationMode { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool bEnableAttenuation { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool bUseConeAttenuation { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fInnerAngle { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fOuterAngle { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fConeMaxAttenuation { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float LPFCone { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float HPFCone { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fMaxDistance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fVolDryAtMaxDist { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fVolAuxGameDefAtMaxDist { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fVolAuxUserDefAtMaxDist { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float LPFValueAtMaxDist { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float HPFValueAtMaxDist { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkPositioningInfo(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkPositioningInfo obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkPositioningInfo(jarg1:  this.swigCPtr);
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
    public void set_fCenterPct(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fCenterPct_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fCenterPct()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fCenterPct_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_pannerType(AkSpeakerPanningType value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_pannerType_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkSpeakerPanningType get_pannerType()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_pannerType_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_e3dPositioningType(Ak3DPositionType value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_e3dPositioningType_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Ak3DPositionType get_e3dPositioningType()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_e3dPositioningType_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_bHoldEmitterPosAndOrient(bool value)
    {
        value = value;
        AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_bHoldEmitterPosAndOrient()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_e3DSpatializationMode(Ak3DSpatializationMode value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_e3DSpatializationMode_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Ak3DSpatializationMode get_e3DSpatializationMode()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_e3DSpatializationMode_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_bEnableAttenuation(bool value)
    {
        value = value;
        AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_bEnableAttenuation_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_bEnableAttenuation()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_bEnableAttenuation_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_bUseConeAttenuation(bool value)
    {
        value = value;
        AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_bUseConeAttenuation_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_bUseConeAttenuation()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_bUseConeAttenuation_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_fInnerAngle(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fInnerAngle_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fInnerAngle()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fInnerAngle_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_fOuterAngle(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fOuterAngle_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fOuterAngle()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fOuterAngle_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_fConeMaxAttenuation(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fConeMaxAttenuation_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fConeMaxAttenuation()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fConeMaxAttenuation_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_LPFCone(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_LPFCone_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_LPFCone()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_LPFCone_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_HPFCone(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_HPFCone_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_HPFCone()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_HPFCone_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_fMaxDistance(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fMaxDistance_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fMaxDistance()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fMaxDistance_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_fVolDryAtMaxDist(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fVolDryAtMaxDist_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fVolDryAtMaxDist()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fVolDryAtMaxDist_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_fVolAuxGameDefAtMaxDist(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fVolAuxGameDefAtMaxDist()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_fVolAuxUserDefAtMaxDist(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fVolAuxUserDefAtMaxDist()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_LPFValueAtMaxDist(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_LPFValueAtMaxDist_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_LPFValueAtMaxDist()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_LPFValueAtMaxDist_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_HPFValueAtMaxDist(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_HPFValueAtMaxDist_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_HPFValueAtMaxDist()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_HPFValueAtMaxDist_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkPositioningInfo()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkPositioningInfo();
    }

}
