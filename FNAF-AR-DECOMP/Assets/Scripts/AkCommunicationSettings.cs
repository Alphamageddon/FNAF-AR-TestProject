using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkCommunicationSettings : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uPoolSize { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ushort uDiscoveryBroadcastPort { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ushort uCommandPort { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ushort uNotificationPort { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool bInitSystemLib { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string szAppNetworkName { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkCommunicationSettings(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkCommunicationSettings obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkCommunicationSettings(jarg1:  this.swigCPtr);
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
    public AkCommunicationSettings()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkCommunicationSettings();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uPoolSize(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkCommunicationSettings_uPoolSize_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uPoolSize()
    {
        return AkSoundEnginePINVOKE.CSharp_AkCommunicationSettings_uPoolSize_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uDiscoveryBroadcastPort(ushort value)
    {
        AkSoundEnginePINVOKE.CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ushort get_uDiscoveryBroadcastPort()
    {
        return AkSoundEnginePINVOKE.CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uCommandPort(ushort value)
    {
        AkSoundEnginePINVOKE.CSharp_AkCommunicationSettings_uCommandPort_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ushort get_uCommandPort()
    {
        return AkSoundEnginePINVOKE.CSharp_AkCommunicationSettings_uCommandPort_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uNotificationPort(ushort value)
    {
        AkSoundEnginePINVOKE.CSharp_AkCommunicationSettings_uNotificationPort_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ushort get_uNotificationPort()
    {
        return AkSoundEnginePINVOKE.CSharp_AkCommunicationSettings_uNotificationPort_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_bInitSystemLib(bool value)
    {
        value = value;
        AkSoundEnginePINVOKE.CSharp_AkCommunicationSettings_bInitSystemLib_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_bInitSystemLib()
    {
        return AkSoundEnginePINVOKE.CSharp_AkCommunicationSettings_bInitSystemLib_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_szAppNetworkName(string value)
    {
        AkSoundEnginePINVOKE.CSharp_AkCommunicationSettings_szAppNetworkName_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_szAppNetworkName()
    {
        return AkSoundEngine.StringFromIntPtrString(ptr:  AkSoundEnginePINVOKE.CSharp_AkCommunicationSettings_szAppNetworkName_get(jarg1:  this.swigCPtr));
    }

}
