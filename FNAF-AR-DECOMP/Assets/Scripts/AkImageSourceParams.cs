using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkImageSourceParams : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkVector sourcePosition { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fDistanceScalingFactor { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fLevel { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fDiffraction { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte uDiffractionEmitterSide { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte uDiffractionListenerSide { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkImageSourceParams(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkImageSourceParams obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkImageSourceParams(jarg1:  this.swigCPtr);
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
    public AkImageSourceParams()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkImageSourceParams__SWIG_0();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkImageSourceParams(AkVector in_sourcePosition, float in_fDistanceScalingFactor, float in_fLevel)
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkImageSourceParams__SWIG_1(jarg1:  AkVector.getCPtr(obj:  in_sourcePosition), jarg2:  in_fDistanceScalingFactor, jarg3:  in_fLevel);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_sourcePosition(AkVector value)
    {
        AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_sourcePosition_set(jarg1:  this.swigCPtr, jarg2:  AkVector.getCPtr(obj:  value));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkVector get_sourcePosition()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_sourcePosition_get(jarg1:  this.swigCPtr);
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
    public void set_fDistanceScalingFactor(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_fDistanceScalingFactor_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fDistanceScalingFactor()
    {
        return AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_fDistanceScalingFactor_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_fLevel(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_fLevel_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fLevel()
    {
        return AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_fLevel_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_fDiffraction(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_fDiffraction_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_fDiffraction()
    {
        return AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_fDiffraction_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uDiffractionEmitterSide(byte value)
    {
        AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_uDiffractionEmitterSide_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_uDiffractionEmitterSide()
    {
        return AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_uDiffractionEmitterSide_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uDiffractionListenerSide(byte value)
    {
        AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_uDiffractionListenerSide_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte get_uDiffractionListenerSide()
    {
        return AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_uDiffractionListenerSide_get(jarg1:  this.swigCPtr);
    }

}
