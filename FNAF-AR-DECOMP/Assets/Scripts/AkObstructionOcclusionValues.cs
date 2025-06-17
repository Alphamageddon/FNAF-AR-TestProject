using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkObstructionOcclusionValues : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float occlusion { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float obstruction { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkObstructionOcclusionValues(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkObstructionOcclusionValues obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkObstructionOcclusionValues(jarg1:  this.swigCPtr);
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
    public void set_occlusion(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkObstructionOcclusionValues_occlusion_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_occlusion()
    {
        return AkSoundEnginePINVOKE.CSharp_AkObstructionOcclusionValues_occlusion_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_obstruction(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkObstructionOcclusionValues_obstruction_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_obstruction()
    {
        return AkSoundEnginePINVOKE.CSharp_AkObstructionOcclusionValues_obstruction_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Clear()
    {
        AkSoundEnginePINVOKE.CSharp_AkObstructionOcclusionValues_Clear(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static int GetSizeOf()
    {
        return AkSoundEnginePINVOKE.CSharp_AkObstructionOcclusionValues_GetSizeOf();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Clone(AkObstructionOcclusionValues other)
    {
        AkObstructionOcclusionValues val_1 = other;
        if(val_1 != null)
        {
                val_1 = other.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkObstructionOcclusionValues_Clone(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkObstructionOcclusionValues()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkObstructionOcclusionValues();
    }

}
