using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkAuxSendValue : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ulong listenerID { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint auxBusID { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fControlValue { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkAuxSendValue(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkAuxSendValue obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkAuxSendValue(jarg1:  this.swigCPtr);
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
    public void set_listenerID(ulong value)
    {
        AkSoundEnginePINVOKE.CSharp_AkAuxSendValue_listenerID_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ulong get_listenerID()
    {
        return AkSoundEnginePINVOKE.CSharp_AkAuxSendValue_listenerID_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_auxBusID(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkAuxSendValue_auxBusID_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_auxBusID()
    {
        return AkSoundEnginePINVOKE.CSharp_AkAuxSendValue_auxBusID_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_fControlValue(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkAuxSendValue_fControlValue_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fControlValue()
    {
        return AkSoundEnginePINVOKE.CSharp_AkAuxSendValue_fControlValue_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Set(UnityEngine.GameObject listener, uint id, float value)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  listener);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  listener, id:  val_1);
        AkSoundEnginePINVOKE.CSharp_AkAuxSendValue_Set(jarg1:  this.swigCPtr, jarg2:  val_1, jarg3:  id, jarg4:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsSame(UnityEngine.GameObject listener, uint id)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  listener);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  listener, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_AkAuxSendValue_IsSame(jarg1:  this.swigCPtr, jarg2:  val_1, jarg3:  id);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static int GetSizeOf()
    {
        return AkSoundEnginePINVOKE.CSharp_AkAuxSendValue_GetSizeOf();
    }

}
