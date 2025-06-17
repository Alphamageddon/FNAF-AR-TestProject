using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkSpatialAudioInitSettings : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int uPoolID { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uPoolSize { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uMaxSoundPropagationDepth { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uDiffractionFlags { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fDiffractionShadowAttenFactor { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fDiffractionShadowDegrees { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fMovementThreshold { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkSpatialAudioInitSettings(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkSpatialAudioInitSettings obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkSpatialAudioInitSettings(jarg1:  this.swigCPtr);
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
    public AkSpatialAudioInitSettings()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkSpatialAudioInitSettings();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uPoolID(int value)
    {
        AkSoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uPoolID_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_uPoolID()
    {
        return AkSoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uPoolID_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uPoolSize(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uPoolSize_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uPoolSize()
    {
        return AkSoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uPoolSize_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uMaxSoundPropagationDepth(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uMaxSoundPropagationDepth()
    {
        return AkSoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uDiffractionFlags(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uDiffractionFlags_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uDiffractionFlags()
    {
        return AkSoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uDiffractionFlags_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_fDiffractionShadowAttenFactor(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_fDiffractionShadowAttenFactor_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fDiffractionShadowAttenFactor()
    {
        return AkSoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_fDiffractionShadowAttenFactor_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_fDiffractionShadowDegrees(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_fDiffractionShadowDegrees_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fDiffractionShadowDegrees()
    {
        return AkSoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_fDiffractionShadowDegrees_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_fMovementThreshold(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_fMovementThreshold_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fMovementThreshold()
    {
        return AkSoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_fMovementThreshold_get(jarg1:  this.swigCPtr);
    }

}
