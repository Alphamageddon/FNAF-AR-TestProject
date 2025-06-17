using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkInitializationSettings : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMemSettings memSettings { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkStreamMgrSettings streamMgrSettings { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkDeviceSettings deviceSettings { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkInitSettings initSettings { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkPlatformInitSettings platformSettings { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMusicSettings musicSettings { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint preparePoolSize { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkUnityPlatformSpecificSettings unityPlatformSpecificSettings { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkInitializationSettings(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkInitializationSettings obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkInitializationSettings(jarg1:  this.swigCPtr);
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
    public AkInitializationSettings()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkInitializationSettings();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_memSettings(AkMemSettings value)
    {
        AkMemSettings val_1 = value;
        if(val_1 != null)
        {
                val_1 = value.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkInitializationSettings_memSettings_set(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMemSettings get_memSettings()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkInitializationSettings_memSettings_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkMemSettings)val_4;
        }
        
        AkMemSettings val_3 = null;
        val_4 = val_3;
        val_3 = new AkMemSettings();
        .swigCMemOwn = false;
        .swigCPtr = val_1;
        return (AkMemSettings)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_streamMgrSettings(AkStreamMgrSettings value)
    {
        AkSoundEnginePINVOKE.CSharp_AkInitializationSettings_streamMgrSettings_set(jarg1:  this.swigCPtr, jarg2:  AkStreamMgrSettings.getCPtr(obj:  value));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkStreamMgrSettings get_streamMgrSettings()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkInitializationSettings_streamMgrSettings_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkStreamMgrSettings)val_4;
        }
        
        AkStreamMgrSettings val_3 = null;
        val_4 = val_3;
        val_3 = new AkStreamMgrSettings(cPtr:  val_1, cMemoryOwn:  false);
        return (AkStreamMgrSettings)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_deviceSettings(AkDeviceSettings value)
    {
        AkSoundEnginePINVOKE.CSharp_AkInitializationSettings_deviceSettings_set(jarg1:  this.swigCPtr, jarg2:  AkDeviceSettings.getCPtr(obj:  value));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkDeviceSettings get_deviceSettings()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkInitializationSettings_deviceSettings_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkDeviceSettings)val_4;
        }
        
        AkDeviceSettings val_3 = null;
        val_4 = val_3;
        val_3 = new AkDeviceSettings(cPtr:  val_1, cMemoryOwn:  false);
        return (AkDeviceSettings)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_initSettings(AkInitSettings value)
    {
        AkSoundEnginePINVOKE.CSharp_AkInitializationSettings_initSettings_set(jarg1:  this.swigCPtr, jarg2:  AkInitSettings.getCPtr(obj:  value));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkInitSettings get_initSettings()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkInitializationSettings_initSettings_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkInitSettings)val_4;
        }
        
        AkInitSettings val_3 = null;
        val_4 = val_3;
        val_3 = new AkInitSettings(cPtr:  val_1, cMemoryOwn:  false);
        return (AkInitSettings)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_platformSettings(AkPlatformInitSettings value)
    {
        AkPlatformInitSettings val_1 = value;
        if(val_1 != null)
        {
                val_1 = value.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkInitializationSettings_platformSettings_set(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkPlatformInitSettings get_platformSettings()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkInitializationSettings_platformSettings_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkPlatformInitSettings)val_4;
        }
        
        AkPlatformInitSettings val_3 = null;
        val_4 = val_3;
        val_3 = new AkPlatformInitSettings();
        .swigCMemOwn = false;
        .swigCPtr = val_1;
        return (AkPlatformInitSettings)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_musicSettings(AkMusicSettings value)
    {
        AkMusicSettings val_1 = value;
        if(val_1 != null)
        {
                val_1 = value.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkInitializationSettings_musicSettings_set(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMusicSettings get_musicSettings()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkInitializationSettings_musicSettings_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkMusicSettings)val_4;
        }
        
        AkMusicSettings val_3 = null;
        val_4 = val_3;
        val_3 = new AkMusicSettings();
        .swigCMemOwn = false;
        .swigCPtr = val_1;
        return (AkMusicSettings)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_preparePoolSize(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkInitializationSettings_preparePoolSize_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_preparePoolSize()
    {
        return AkSoundEnginePINVOKE.CSharp_AkInitializationSettings_preparePoolSize_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_unityPlatformSpecificSettings(AkUnityPlatformSpecificSettings value)
    {
        AkSoundEnginePINVOKE.CSharp_AkInitializationSettings_unityPlatformSpecificSettings_set(jarg1:  this.swigCPtr, jarg2:  AkUnityPlatformSpecificSettings.getCPtr(obj:  value));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkUnityPlatformSpecificSettings get_unityPlatformSpecificSettings()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkInitializationSettings_unityPlatformSpecificSettings_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkUnityPlatformSpecificSettings)val_4;
        }
        
        AkUnityPlatformSpecificSettings val_3 = null;
        val_4 = val_3;
        val_3 = new AkUnityPlatformSpecificSettings(cPtr:  val_1, cMemoryOwn:  false);
        return (AkUnityPlatformSpecificSettings)val_4;
    }

}
