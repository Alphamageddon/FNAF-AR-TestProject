using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkPlatformInitSettings : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkThreadProperties threadLEngine { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkThreadProperties threadOutputMgr { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkThreadProperties threadBankManager { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkThreadProperties threadMonitor { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fLEngineDefaultPoolRatioThreshold { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uLEngineDefaultPoolSize { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uSampleRate { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ushort uNumRefillsInVoice { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uChannelMask { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool bRoundFrameSizeToHWSize { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkPlatformInitSettings(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkPlatformInitSettings obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkPlatformInitSettings(jarg1:  this.swigCPtr);
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
    public void set_threadLEngine(AkThreadProperties value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPlatformInitSettings_threadLEngine_set(jarg1:  this.swigCPtr, jarg2:  AkThreadProperties.getCPtr(obj:  value));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkThreadProperties get_threadLEngine()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkPlatformInitSettings_threadLEngine_get(jarg1:  this.swigCPtr);
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
    public void set_threadOutputMgr(AkThreadProperties value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPlatformInitSettings_threadOutputMgr_set(jarg1:  this.swigCPtr, jarg2:  AkThreadProperties.getCPtr(obj:  value));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkThreadProperties get_threadOutputMgr()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkPlatformInitSettings_threadOutputMgr_get(jarg1:  this.swigCPtr);
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
    public void set_threadBankManager(AkThreadProperties value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPlatformInitSettings_threadBankManager_set(jarg1:  this.swigCPtr, jarg2:  AkThreadProperties.getCPtr(obj:  value));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkThreadProperties get_threadBankManager()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkPlatformInitSettings_threadBankManager_get(jarg1:  this.swigCPtr);
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
    public void set_threadMonitor(AkThreadProperties value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPlatformInitSettings_threadMonitor_set(jarg1:  this.swigCPtr, jarg2:  AkThreadProperties.getCPtr(obj:  value));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkThreadProperties get_threadMonitor()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkPlatformInitSettings_threadMonitor_get(jarg1:  this.swigCPtr);
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
    public void set_fLEngineDefaultPoolRatioThreshold(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPlatformInitSettings_fLEngineDefaultPoolRatioThreshold_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fLEngineDefaultPoolRatioThreshold()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPlatformInitSettings_fLEngineDefaultPoolRatioThreshold_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uLEngineDefaultPoolSize(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPlatformInitSettings_uLEngineDefaultPoolSize_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uLEngineDefaultPoolSize()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPlatformInitSettings_uLEngineDefaultPoolSize_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uSampleRate(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPlatformInitSettings_uSampleRate_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uSampleRate()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPlatformInitSettings_uSampleRate_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uNumRefillsInVoice(ushort value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPlatformInitSettings_uNumRefillsInVoice_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ushort get_uNumRefillsInVoice()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPlatformInitSettings_uNumRefillsInVoice_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uChannelMask(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPlatformInitSettings_uChannelMask_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uChannelMask()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPlatformInitSettings_uChannelMask_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_bRoundFrameSizeToHWSize(bool value)
    {
        value = value;
        AkSoundEnginePINVOKE.CSharp_AkPlatformInitSettings_bRoundFrameSizeToHWSize_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_bRoundFrameSizeToHWSize()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPlatformInitSettings_bRoundFrameSizeToHWSize_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkPlatformInitSettings()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkPlatformInitSettings();
    }

}
