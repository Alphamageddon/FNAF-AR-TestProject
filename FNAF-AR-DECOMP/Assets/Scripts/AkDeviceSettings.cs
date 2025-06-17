using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkDeviceSettings : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IntPtr pIOMemory { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uIOMemorySize { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uIOMemoryAlignment { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int ePoolAttributes { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uGranularity { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uSchedulerTypeFlags { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkThreadProperties threadProperties { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fTargetAutoStmBufferLength { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uMaxConcurrentIO { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool bUseStreamCache { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uMaxCachePinnedBytes { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkDeviceSettings(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkDeviceSettings obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkDeviceSettings(jarg1:  this.swigCPtr);
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
    public void set_pIOMemory(IntPtr value)
    {
        AkSoundEnginePINVOKE.CSharp_AkDeviceSettings_pIOMemory_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IntPtr get_pIOMemory()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDeviceSettings_pIOMemory_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uIOMemorySize(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkDeviceSettings_uIOMemorySize_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uIOMemorySize()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDeviceSettings_uIOMemorySize_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uIOMemoryAlignment(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkDeviceSettings_uIOMemoryAlignment_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uIOMemoryAlignment()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDeviceSettings_uIOMemoryAlignment_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ePoolAttributes(int value)
    {
        AkSoundEnginePINVOKE.CSharp_AkDeviceSettings_ePoolAttributes_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_ePoolAttributes()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDeviceSettings_ePoolAttributes_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uGranularity(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkDeviceSettings_uGranularity_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uGranularity()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDeviceSettings_uGranularity_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uSchedulerTypeFlags(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkDeviceSettings_uSchedulerTypeFlags_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uSchedulerTypeFlags()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDeviceSettings_uSchedulerTypeFlags_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_threadProperties(AkThreadProperties value)
    {
        AkSoundEnginePINVOKE.CSharp_AkDeviceSettings_threadProperties_set(jarg1:  this.swigCPtr, jarg2:  AkThreadProperties.getCPtr(obj:  value));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkThreadProperties get_threadProperties()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkDeviceSettings_threadProperties_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkThreadProperties)val_4;
        }
        
        AkThreadProperties val_3 = null;
        val_4 = val_3;
        val_3 = new AkThreadProperties(cPtr:  val_1, cMemoryOwn:  false);
        return (AkThreadProperties)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_fTargetAutoStmBufferLength(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fTargetAutoStmBufferLength()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uMaxConcurrentIO(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkDeviceSettings_uMaxConcurrentIO_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uMaxConcurrentIO()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDeviceSettings_uMaxConcurrentIO_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_bUseStreamCache(bool value)
    {
        value = value;
        AkSoundEnginePINVOKE.CSharp_AkDeviceSettings_bUseStreamCache_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_bUseStreamCache()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDeviceSettings_bUseStreamCache_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uMaxCachePinnedBytes(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkDeviceSettings_uMaxCachePinnedBytes_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uMaxCachePinnedBytes()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDeviceSettings_uMaxCachePinnedBytes_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkDeviceSettings()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkDeviceSettings();
    }

}
