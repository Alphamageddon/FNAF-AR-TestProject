using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkImageSourceSettings : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkImageSourceParams params_ { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkImageSourceSettings(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkImageSourceSettings obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkImageSourceSettings(jarg1:  this.swigCPtr);
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
    public AkImageSourceSettings()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkImageSourceSettings__SWIG_0();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkImageSourceSettings(AkVector in_sourcePosition, float in_fDistanceScalingFactor, float in_fLevel)
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkImageSourceSettings__SWIG_1(jarg1:  AkVector.getCPtr(obj:  in_sourcePosition), jarg2:  in_fDistanceScalingFactor, jarg3:  in_fLevel);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetOneTexture(uint in_texture)
    {
        AkSoundEnginePINVOKE.CSharp_AkImageSourceSettings_SetOneTexture(jarg1:  this.swigCPtr, jarg2:  in_texture);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetName(string in_pName)
    {
        AkSoundEnginePINVOKE.CSharp_AkImageSourceSettings_SetName(jarg1:  this.swigCPtr, jarg2:  in_pName);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_params_(AkImageSourceParams value)
    {
        AkImageSourceParams val_1 = value;
        if(val_1 != null)
        {
                val_1 = value.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkImageSourceSettings_params__set(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkImageSourceParams get_params_()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkImageSourceSettings_params__get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkImageSourceParams)val_4;
        }
        
        AkImageSourceParams val_3 = null;
        val_4 = val_3;
        val_3 = new AkImageSourceParams();
        .swigCMemOwn = false;
        .swigCPtr = val_1;
        return (AkImageSourceParams)val_4;
    }

}
