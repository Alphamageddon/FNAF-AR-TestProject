using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkThreadProperties : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int nPriority { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uStackSize { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int uSchedPolicy { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint dwAffinityMask { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkThreadProperties(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkThreadProperties obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkThreadProperties(jarg1:  this.swigCPtr);
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
    public void set_nPriority(int value)
    {
        AkSoundEnginePINVOKE.CSharp_AkThreadProperties_nPriority_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_nPriority()
    {
        return AkSoundEnginePINVOKE.CSharp_AkThreadProperties_nPriority_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uStackSize(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkThreadProperties_uStackSize_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uStackSize()
    {
        return AkSoundEnginePINVOKE.CSharp_AkThreadProperties_uStackSize_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uSchedPolicy(int value)
    {
        AkSoundEnginePINVOKE.CSharp_AkThreadProperties_uSchedPolicy_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_uSchedPolicy()
    {
        return AkSoundEnginePINVOKE.CSharp_AkThreadProperties_uSchedPolicy_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_dwAffinityMask(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkThreadProperties_dwAffinityMask_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_dwAffinityMask()
    {
        return AkSoundEnginePINVOKE.CSharp_AkThreadProperties_dwAffinityMask_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkThreadProperties()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkThreadProperties();
    }

}
