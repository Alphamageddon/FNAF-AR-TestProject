using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkAudioFormat : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uSampleRate { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkChannelConfig channelConfig { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uBitsPerSample { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uBlockAlign { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uTypeID { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uInterleaveID { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkAudioFormat(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkAudioFormat obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkAudioFormat(jarg1:  this.swigCPtr);
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
    public void set_uSampleRate(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkAudioFormat_uSampleRate_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uSampleRate()
    {
        return AkSoundEnginePINVOKE.CSharp_AkAudioFormat_uSampleRate_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_channelConfig(AkChannelConfig value)
    {
        AkChannelConfig val_1 = value;
        if(val_1 != null)
        {
                val_1 = value.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkAudioFormat_channelConfig_set(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkChannelConfig get_channelConfig()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkAudioFormat_channelConfig_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkChannelConfig)val_4;
        }
        
        AkChannelConfig val_3 = null;
        val_4 = val_3;
        val_3 = new AkChannelConfig();
        .swigCMemOwn = false;
        .swigCPtr = val_1;
        return (AkChannelConfig)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uBitsPerSample(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkAudioFormat_uBitsPerSample_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uBitsPerSample()
    {
        return AkSoundEnginePINVOKE.CSharp_AkAudioFormat_uBitsPerSample_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uBlockAlign(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkAudioFormat_uBlockAlign_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uBlockAlign()
    {
        return AkSoundEnginePINVOKE.CSharp_AkAudioFormat_uBlockAlign_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uTypeID(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkAudioFormat_uTypeID_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uTypeID()
    {
        return AkSoundEnginePINVOKE.CSharp_AkAudioFormat_uTypeID_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uInterleaveID(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkAudioFormat_uInterleaveID_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uInterleaveID()
    {
        return AkSoundEnginePINVOKE.CSharp_AkAudioFormat_uInterleaveID_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint GetNumChannels()
    {
        return AkSoundEnginePINVOKE.CSharp_AkAudioFormat_GetNumChannels(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint GetBitsPerSample()
    {
        return AkSoundEnginePINVOKE.CSharp_AkAudioFormat_GetBitsPerSample(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint GetBlockAlign()
    {
        return AkSoundEnginePINVOKE.CSharp_AkAudioFormat_GetBlockAlign(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint GetTypeID()
    {
        return AkSoundEnginePINVOKE.CSharp_AkAudioFormat_GetTypeID(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint GetInterleaveID()
    {
        return AkSoundEnginePINVOKE.CSharp_AkAudioFormat_GetInterleaveID(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetAll(uint in_uSampleRate, AkChannelConfig in_channelConfig, uint in_uBitsPerSample, uint in_uBlockAlign, uint in_uTypeID, uint in_uInterleaveID)
    {
        AkChannelConfig val_1 = in_channelConfig;
        if(val_1 != null)
        {
                val_1 = in_channelConfig.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkAudioFormat_SetAll(jarg1:  this.swigCPtr, jarg2:  in_uSampleRate, jarg3:  val_1, jarg4:  in_uBitsPerSample, jarg5:  in_uBlockAlign, jarg6:  in_uTypeID, jarg7:  in_uInterleaveID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsChannelConfigSupported()
    {
        return AkSoundEnginePINVOKE.CSharp_AkAudioFormat_IsChannelConfigSupported(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkAudioFormat()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkAudioFormat();
    }

}
