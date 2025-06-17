using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkTransform : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkTransform(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkTransform obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkTransform(jarg1:  this.swigCPtr);
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
    public AkVector Position()
    {
        .swigCMemOwn = false;
        .swigCPtr = AkSoundEnginePINVOKE.CSharp_AkTransform_Position(jarg1:  this.swigCPtr);
        return (AkVector)new AkVector();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkVector OrientationFront()
    {
        .swigCMemOwn = false;
        .swigCPtr = AkSoundEnginePINVOKE.CSharp_AkTransform_OrientationFront(jarg1:  this.swigCPtr);
        return (AkVector)new AkVector();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkVector OrientationTop()
    {
        .swigCMemOwn = false;
        .swigCPtr = AkSoundEnginePINVOKE.CSharp_AkTransform_OrientationTop(jarg1:  this.swigCPtr);
        return (AkVector)new AkVector();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Set(AkVector in_position, AkVector in_orientationFront, AkVector in_orientationTop)
    {
        IntPtr val_1;
        IntPtr val_2;
        IntPtr val_3;
        val_1 = in_orientationTop;
        val_2 = in_orientationFront;
        val_3 = in_position;
        if(val_3 != null)
        {
                val_3 = in_position.swigCPtr;
        }
        
        if(val_2 != null)
        {
                val_2 = in_orientationFront.swigCPtr;
        }
        
        if(val_1 != null)
        {
                val_1 = in_orientationTop.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkTransform_Set__SWIG_0(jarg1:  this.swigCPtr, jarg2:  val_3, jarg3:  val_2, jarg4:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Set(float in_positionX, float in_positionY, float in_positionZ, float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ)
    {
        float val_1;
        float val_2;
        float val_3;
        float val_4;
        float val_5;
        val_1 = in_orientTopZ;
        val_2 = in_orientTopX;
        val_3 = in_orientFrontY;
        val_4 = in_positionZ;
        val_5 = in_positionX;
        val_1 = val_1;
        val_2 = val_2;
        val_3 = val_3;
        val_4 = val_4;
        val_5 = val_5;
        val_1 = val_1;
        AkSoundEnginePINVOKE.CSharp_AkTransform_Set__SWIG_1(jarg1:  this.swigCPtr, jarg2:  val_5, jarg3:  in_positionY, jarg4:  val_4, jarg5:  in_orientFrontX, jarg6:  val_3, jarg7:  in_orientFrontZ, jarg8:  val_2, jarg9:  in_orientTopY, jarg10:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetPosition(AkVector in_position)
    {
        AkVector val_1 = in_position;
        if(val_1 != null)
        {
                val_1 = in_position.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkTransform_SetPosition__SWIG_0(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetPosition(float in_x, float in_y, float in_z)
    {
        AkSoundEnginePINVOKE.CSharp_AkTransform_SetPosition__SWIG_1(jarg1:  this.swigCPtr, jarg2:  in_x, jarg3:  in_y, jarg4:  in_z);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetOrientation(AkVector in_orientationFront, AkVector in_orientationTop)
    {
        IntPtr val_1;
        IntPtr val_2;
        val_1 = in_orientationTop;
        val_2 = in_orientationFront;
        if(val_2 != null)
        {
                val_2 = in_orientationFront.swigCPtr;
        }
        
        if(val_1 != null)
        {
                val_1 = in_orientationTop.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkTransform_SetOrientation__SWIG_0(jarg1:  this.swigCPtr, jarg2:  val_2, jarg3:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetOrientation(float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ)
    {
        AkSoundEnginePINVOKE.CSharp_AkTransform_SetOrientation__SWIG_1(jarg1:  this.swigCPtr, jarg2:  in_orientFrontX, jarg3:  in_orientFrontY, jarg4:  in_orientFrontZ, jarg5:  in_orientTopX, jarg6:  in_orientTopY, jarg7:  in_orientTopZ);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkTransform()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkTransform();
    }

}
