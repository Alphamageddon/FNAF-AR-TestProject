using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkInitSettings : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uMaxNumPaths { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uDefaultPoolSize { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fDefaultPoolRatioThreshold { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uCommandQueueSize { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int uPrepareEventMemoryPoolID { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool bEnableGameSyncPreparation { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uContinuousPlaybackLookAhead { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uNumSamplesPerFrame { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uMonitorPoolSize { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uMonitorQueuePoolSize { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkOutputSettings settingsMainOutput { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uMaxHardwareTimeoutMs { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool bUseSoundBankMgrThread { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool bUseLEngineThread { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string szPluginDLLPath { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkFloorPlane eFloorPlane { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkInitSettings(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkInitSettings obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkInitSettings(jarg1:  this.swigCPtr);
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
    public void set_uMaxNumPaths(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkInitSettings_uMaxNumPaths_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uMaxNumPaths()
    {
        return AkSoundEnginePINVOKE.CSharp_AkInitSettings_uMaxNumPaths_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uDefaultPoolSize(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkInitSettings_uDefaultPoolSize_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uDefaultPoolSize()
    {
        return AkSoundEnginePINVOKE.CSharp_AkInitSettings_uDefaultPoolSize_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_fDefaultPoolRatioThreshold(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkInitSettings_fDefaultPoolRatioThreshold_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fDefaultPoolRatioThreshold()
    {
        return AkSoundEnginePINVOKE.CSharp_AkInitSettings_fDefaultPoolRatioThreshold_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uCommandQueueSize(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkInitSettings_uCommandQueueSize_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uCommandQueueSize()
    {
        return AkSoundEnginePINVOKE.CSharp_AkInitSettings_uCommandQueueSize_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uPrepareEventMemoryPoolID(int value)
    {
        AkSoundEnginePINVOKE.CSharp_AkInitSettings_uPrepareEventMemoryPoolID_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_uPrepareEventMemoryPoolID()
    {
        return AkSoundEnginePINVOKE.CSharp_AkInitSettings_uPrepareEventMemoryPoolID_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_bEnableGameSyncPreparation(bool value)
    {
        value = value;
        AkSoundEnginePINVOKE.CSharp_AkInitSettings_bEnableGameSyncPreparation_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_bEnableGameSyncPreparation()
    {
        return AkSoundEnginePINVOKE.CSharp_AkInitSettings_bEnableGameSyncPreparation_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uContinuousPlaybackLookAhead(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkInitSettings_uContinuousPlaybackLookAhead_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uContinuousPlaybackLookAhead()
    {
        return AkSoundEnginePINVOKE.CSharp_AkInitSettings_uContinuousPlaybackLookAhead_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uNumSamplesPerFrame(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkInitSettings_uNumSamplesPerFrame_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uNumSamplesPerFrame()
    {
        return AkSoundEnginePINVOKE.CSharp_AkInitSettings_uNumSamplesPerFrame_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uMonitorPoolSize(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkInitSettings_uMonitorPoolSize_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uMonitorPoolSize()
    {
        return AkSoundEnginePINVOKE.CSharp_AkInitSettings_uMonitorPoolSize_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uMonitorQueuePoolSize(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkInitSettings_uMonitorQueuePoolSize_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uMonitorQueuePoolSize()
    {
        return AkSoundEnginePINVOKE.CSharp_AkInitSettings_uMonitorQueuePoolSize_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_settingsMainOutput(AkOutputSettings value)
    {
        AkSoundEnginePINVOKE.CSharp_AkInitSettings_settingsMainOutput_set(jarg1:  this.swigCPtr, jarg2:  AkOutputSettings.getCPtr(obj:  value));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkOutputSettings get_settingsMainOutput()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkInitSettings_settingsMainOutput_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkOutputSettings)val_4;
        }
        
        AkOutputSettings val_3 = null;
        val_4 = val_3;
        val_3 = new AkOutputSettings(cPtr:  val_1, cMemoryOwn:  false);
        return (AkOutputSettings)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uMaxHardwareTimeoutMs(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkInitSettings_uMaxHardwareTimeoutMs_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uMaxHardwareTimeoutMs()
    {
        return AkSoundEnginePINVOKE.CSharp_AkInitSettings_uMaxHardwareTimeoutMs_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_bUseSoundBankMgrThread(bool value)
    {
        value = value;
        AkSoundEnginePINVOKE.CSharp_AkInitSettings_bUseSoundBankMgrThread_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_bUseSoundBankMgrThread()
    {
        return AkSoundEnginePINVOKE.CSharp_AkInitSettings_bUseSoundBankMgrThread_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_bUseLEngineThread(bool value)
    {
        value = value;
        AkSoundEnginePINVOKE.CSharp_AkInitSettings_bUseLEngineThread_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_bUseLEngineThread()
    {
        return AkSoundEnginePINVOKE.CSharp_AkInitSettings_bUseLEngineThread_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_szPluginDLLPath(string value)
    {
        AkSoundEnginePINVOKE.CSharp_AkInitSettings_szPluginDLLPath_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_szPluginDLLPath()
    {
        return AkSoundEngine.StringFromIntPtrOSString(ptr:  AkSoundEnginePINVOKE.CSharp_AkInitSettings_szPluginDLLPath_get(jarg1:  this.swigCPtr));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_eFloorPlane(AkFloorPlane value)
    {
        AkSoundEnginePINVOKE.CSharp_AkInitSettings_eFloorPlane_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkFloorPlane get_eFloorPlane()
    {
        return AkSoundEnginePINVOKE.CSharp_AkInitSettings_eFloorPlane_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkInitSettings()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkInitSettings();
    }

}
