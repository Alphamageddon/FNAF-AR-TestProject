using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkVertex : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float X { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float Y { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float Z { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkVertex(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkVertex obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkVertex(jarg1:  this.swigCPtr);
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
    public AkVertex()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkVertex__SWIG_0();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkVertex(float in_X, float in_Y, float in_Z)
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkVertex__SWIG_1(jarg1:  in_X, jarg2:  in_Y, jarg3:  in_Z);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_X(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkVertex_X_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_X()
    {
        return AkSoundEnginePINVOKE.CSharp_AkVertex_X_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Y(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkVertex_Y_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_Y()
    {
        return AkSoundEnginePINVOKE.CSharp_AkVertex_Y_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Z(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkVertex_Z_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_Z()
    {
        return AkSoundEnginePINVOKE.CSharp_AkVertex_Z_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Clear()
    {
        AkSoundEnginePINVOKE.CSharp_AkVertex_Clear(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static int GetSizeOf()
    {
        return AkSoundEnginePINVOKE.CSharp_AkVertex_GetSizeOf();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Clone(AkVertex other)
    {
        AkVertex val_1 = other;
        if(val_1 != null)
        {
                val_1 = other.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkVertex_Clone(jarg1:  this.swigCPtr, jarg2:  val_1);
    }

}
