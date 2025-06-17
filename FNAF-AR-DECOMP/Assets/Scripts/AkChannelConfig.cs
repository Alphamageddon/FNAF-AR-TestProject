using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkChannelConfig : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uNumChannels { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint eConfigType { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uChannelMask { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkChannelConfig(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkChannelConfig obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkChannelConfig(jarg1:  this.swigCPtr);
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
    public void set_uNumChannels(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkChannelConfig_uNumChannels_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uNumChannels()
    {
        return AkSoundEnginePINVOKE.CSharp_AkChannelConfig_uNumChannels_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_eConfigType(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkChannelConfig_eConfigType_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_eConfigType()
    {
        return AkSoundEnginePINVOKE.CSharp_AkChannelConfig_eConfigType_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uChannelMask(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkChannelConfig_uChannelMask_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uChannelMask()
    {
        return AkSoundEnginePINVOKE.CSharp_AkChannelConfig_uChannelMask_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkChannelConfig()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkChannelConfig__SWIG_0();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkChannelConfig(uint in_uNumChannels, uint in_uChannelMask)
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkChannelConfig__SWIG_1(jarg1:  in_uNumChannels, jarg2:  in_uChannelMask);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Clear()
    {
        AkSoundEnginePINVOKE.CSharp_AkChannelConfig_Clear(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetStandard(uint in_uChannelMask)
    {
        AkSoundEnginePINVOKE.CSharp_AkChannelConfig_SetStandard(jarg1:  this.swigCPtr, jarg2:  in_uChannelMask);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetStandardOrAnonymous(uint in_uNumChannels, uint in_uChannelMask)
    {
        AkSoundEnginePINVOKE.CSharp_AkChannelConfig_SetStandardOrAnonymous(jarg1:  this.swigCPtr, jarg2:  in_uNumChannels, jarg3:  in_uChannelMask);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetAnonymous(uint in_uNumChannels)
    {
        AkSoundEnginePINVOKE.CSharp_AkChannelConfig_SetAnonymous(jarg1:  this.swigCPtr, jarg2:  in_uNumChannels);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetAmbisonic(uint in_uNumChannels)
    {
        AkSoundEnginePINVOKE.CSharp_AkChannelConfig_SetAmbisonic(jarg1:  this.swigCPtr, jarg2:  in_uNumChannels);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsValid()
    {
        return AkSoundEnginePINVOKE.CSharp_AkChannelConfig_IsValid(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint Serialize()
    {
        return AkSoundEnginePINVOKE.CSharp_AkChannelConfig_Serialize(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Deserialize(uint in_uChannelConfig)
    {
        AkSoundEnginePINVOKE.CSharp_AkChannelConfig_Deserialize(jarg1:  this.swigCPtr, jarg2:  in_uChannelConfig);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkChannelConfig RemoveLFE()
    {
        .swigCMemOwn = true;
        .swigCPtr = AkSoundEnginePINVOKE.CSharp_AkChannelConfig_RemoveLFE(jarg1:  this.swigCPtr);
        return (AkChannelConfig)new AkChannelConfig();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkChannelConfig RemoveCenter()
    {
        .swigCMemOwn = true;
        .swigCPtr = AkSoundEnginePINVOKE.CSharp_AkChannelConfig_RemoveCenter(jarg1:  this.swigCPtr);
        return (AkChannelConfig)new AkChannelConfig();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsChannelConfigSupported()
    {
        return AkSoundEnginePINVOKE.CSharp_AkChannelConfig_IsChannelConfigSupported(jarg1:  this.swigCPtr);
    }

}
