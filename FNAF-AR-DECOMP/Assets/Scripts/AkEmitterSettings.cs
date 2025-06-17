using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkEmitterSettings : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint reflectAuxBusID { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float reflectionMaxPathLength { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float reflectionsAuxBusGain { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint reflectionsOrder { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint reflectorFilterMask { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float roomReverbAuxBusGain { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint diffractionMaxEdges { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint diffractionMaxPaths { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float diffractionMaxPathLength { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte useImageSources { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkEmitterSettings(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkEmitterSettings obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkEmitterSettings(jarg1:  this.swigCPtr);
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
    public AkEmitterSettings()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkEmitterSettings();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_reflectAuxBusID(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_reflectAuxBusID_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_reflectAuxBusID()
    {
        return AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_reflectAuxBusID_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_reflectionMaxPathLength(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_reflectionMaxPathLength_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_reflectionMaxPathLength()
    {
        return AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_reflectionMaxPathLength_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_reflectionsAuxBusGain(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_reflectionsAuxBusGain_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_reflectionsAuxBusGain()
    {
        return AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_reflectionsAuxBusGain_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_reflectionsOrder(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_reflectionsOrder_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_reflectionsOrder()
    {
        return AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_reflectionsOrder_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_reflectorFilterMask(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_reflectorFilterMask_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_reflectorFilterMask()
    {
        return AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_reflectorFilterMask_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_roomReverbAuxBusGain(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_roomReverbAuxBusGain_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_roomReverbAuxBusGain()
    {
        return AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_roomReverbAuxBusGain_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_diffractionMaxEdges(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_diffractionMaxEdges_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_diffractionMaxEdges()
    {
        return AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_diffractionMaxEdges_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_diffractionMaxPaths(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_diffractionMaxPaths_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_diffractionMaxPaths()
    {
        return AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_diffractionMaxPaths_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_diffractionMaxPathLength(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_diffractionMaxPathLength_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_diffractionMaxPathLength()
    {
        return AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_diffractionMaxPathLength_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_useImageSources(byte value)
    {
        AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_useImageSources_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_useImageSources()
    {
        return AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_useImageSources_get(jarg1:  this.swigCPtr);
    }

}
