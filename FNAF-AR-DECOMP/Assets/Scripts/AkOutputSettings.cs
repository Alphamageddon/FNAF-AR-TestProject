using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkOutputSettings : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint audioDeviceShareset { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint idDevice { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkPanningRule ePanningRule { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkChannelConfig channelConfig { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkOutputSettings(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkOutputSettings obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkOutputSettings(jarg1:  this.swigCPtr);
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
    public AkOutputSettings()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkOutputSettings__SWIG_0();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice, AkChannelConfig in_channelConfig, AkPanningRule in_ePanning)
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkOutputSettings__SWIG_1(jarg1:  in_szDeviceShareSet, jarg2:  in_idDevice, jarg3:  AkChannelConfig.getCPtr(obj:  in_channelConfig), jarg4:  in_ePanning);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice, AkChannelConfig in_channelConfig)
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkOutputSettings__SWIG_2(jarg1:  in_szDeviceShareSet, jarg2:  in_idDevice, jarg3:  AkChannelConfig.getCPtr(obj:  in_channelConfig));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice)
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkOutputSettings__SWIG_3(jarg1:  in_szDeviceShareSet, jarg2:  in_idDevice);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkOutputSettings(string in_szDeviceShareSet)
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkOutputSettings__SWIG_4(jarg1:  in_szDeviceShareSet);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_audioDeviceShareset(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkOutputSettings_audioDeviceShareset_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_audioDeviceShareset()
    {
        return AkSoundEnginePINVOKE.CSharp_AkOutputSettings_audioDeviceShareset_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_idDevice(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkOutputSettings_idDevice_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_idDevice()
    {
        return AkSoundEnginePINVOKE.CSharp_AkOutputSettings_idDevice_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ePanningRule(AkPanningRule value)
    {
        AkSoundEnginePINVOKE.CSharp_AkOutputSettings_ePanningRule_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkPanningRule get_ePanningRule()
    {
        return AkSoundEnginePINVOKE.CSharp_AkOutputSettings_ePanningRule_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_channelConfig(AkChannelConfig value)
    {
        AkSoundEnginePINVOKE.CSharp_AkOutputSettings_channelConfig_set(jarg1:  this.swigCPtr, jarg2:  AkChannelConfig.getCPtr(obj:  value));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkChannelConfig get_channelConfig()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkOutputSettings_channelConfig_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkChannelConfig)val_4;
        }
        
        AkChannelConfig val_3 = null;
        val_4 = val_3;
        val_3 = new AkChannelConfig(cPtr:  val_1, cMemoryOwn:  false);
        return (AkChannelConfig)val_4;
    }

}
