using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkTriangle : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ushort point0 { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ushort point1 { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ushort point2 { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ushort surface { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkTriangle(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkTriangle obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkTriangle(jarg1:  this.swigCPtr);
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
    public AkTriangle()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkTriangle__SWIG_0();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkTriangle(ushort in_pt0, ushort in_pt1, ushort in_pt2, ushort in_surfaceInfo)
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkTriangle__SWIG_1(jarg1:  in_pt0, jarg2:  in_pt1, jarg3:  in_pt2, jarg4:  in_surfaceInfo);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_point0(ushort value)
    {
        AkSoundEnginePINVOKE.CSharp_AkTriangle_point0_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ushort get_point0()
    {
        return AkSoundEnginePINVOKE.CSharp_AkTriangle_point0_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_point1(ushort value)
    {
        AkSoundEnginePINVOKE.CSharp_AkTriangle_point1_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ushort get_point1()
    {
        return AkSoundEnginePINVOKE.CSharp_AkTriangle_point1_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_point2(ushort value)
    {
        AkSoundEnginePINVOKE.CSharp_AkTriangle_point2_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ushort get_point2()
    {
        return AkSoundEnginePINVOKE.CSharp_AkTriangle_point2_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_surface(ushort value)
    {
        AkSoundEnginePINVOKE.CSharp_AkTriangle_surface_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ushort get_surface()
    {
        return AkSoundEnginePINVOKE.CSharp_AkTriangle_surface_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Clear()
    {
        AkSoundEnginePINVOKE.CSharp_AkTriangle_Clear(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static int GetSizeOf()
    {
        return AkSoundEnginePINVOKE.CSharp_AkTriangle_GetSizeOf();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Clone(AkTriangle other)
    {
        AkTriangle val_1 = other;
        if(val_1 != null)
        {
                val_1 = other.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkTriangle_Clone(jarg1:  this.swigCPtr, jarg2:  val_1);
    }

}
