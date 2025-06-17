using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkPathParams : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkVector listenerPos { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkVector emitterPos { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint numValidPaths { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkPathParams(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkPathParams obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkPathParams(jarg1:  this.swigCPtr);
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
    public void set_listenerPos(AkVector value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPathParams_listenerPos_set(jarg1:  this.swigCPtr, jarg2:  AkVector.getCPtr(obj:  value));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkVector get_listenerPos()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkPathParams_listenerPos_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkVector)val_4;
        }
        
        AkVector val_3 = null;
        val_4 = val_3;
        val_3 = new AkVector(cPtr:  val_1, cMemoryOwn:  false);
        return (AkVector)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_emitterPos(AkVector value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPathParams_emitterPos_set(jarg1:  this.swigCPtr, jarg2:  AkVector.getCPtr(obj:  value));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkVector get_emitterPos()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkPathParams_emitterPos_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkVector)val_4;
        }
        
        AkVector val_3 = null;
        val_4 = val_3;
        val_3 = new AkVector(cPtr:  val_1, cMemoryOwn:  false);
        return (AkVector)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_numValidPaths(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkPathParams_numValidPaths_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_numValidPaths()
    {
        return AkSoundEnginePINVOKE.CSharp_AkPathParams_numValidPaths_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkPathParams()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkPathParams();
    }

}
