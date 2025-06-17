using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkReflectionPathInfo : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkVector imageSource { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint numPathPoints { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint numReflections { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float level { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool isOccluded { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkReflectionPathInfo(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkReflectionPathInfo obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkReflectionPathInfo(jarg1:  this.swigCPtr);
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
    public void set_imageSource(AkVector value)
    {
        AkSoundEnginePINVOKE.CSharp_AkReflectionPathInfo_imageSource_set(jarg1:  this.swigCPtr, jarg2:  AkVector.getCPtr(obj:  value));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkVector get_imageSource()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkReflectionPathInfo_imageSource_get(jarg1:  this.swigCPtr);
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
    public void set_numPathPoints(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkReflectionPathInfo_numPathPoints_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_numPathPoints()
    {
        return AkSoundEnginePINVOKE.CSharp_AkReflectionPathInfo_numPathPoints_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_numReflections(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkReflectionPathInfo_numReflections_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_numReflections()
    {
        return AkSoundEnginePINVOKE.CSharp_AkReflectionPathInfo_numReflections_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_level(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkReflectionPathInfo_level_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_level()
    {
        return AkSoundEnginePINVOKE.CSharp_AkReflectionPathInfo_level_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_isOccluded(bool value)
    {
        value = value;
        AkSoundEnginePINVOKE.CSharp_AkReflectionPathInfo_isOccluded_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_isOccluded()
    {
        return AkSoundEnginePINVOKE.CSharp_AkReflectionPathInfo_isOccluded_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static int GetSizeOf()
    {
        return AkSoundEnginePINVOKE.CSharp_AkReflectionPathInfo_GetSizeOf();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkVector GetPathPoint(uint idx)
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkReflectionPathInfo_GetPathPoint(jarg1:  this.swigCPtr, jarg2:  idx);
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
    public AkAcousticSurface GetAcousticSurface(uint idx)
    {
        return (AkAcousticSurface)new AkAcousticSurface(cPtr:  AkSoundEnginePINVOKE.CSharp_AkReflectionPathInfo_GetAcousticSurface(jarg1:  this.swigCPtr, jarg2:  idx), cMemoryOwn:  false);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float GetDiffraction(uint idx)
    {
        return AkSoundEnginePINVOKE.CSharp_AkReflectionPathInfo_GetDiffraction(jarg1:  this.swigCPtr, jarg2:  idx);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Clone(AkReflectionPathInfo other)
    {
        AkReflectionPathInfo val_1 = other;
        if(val_1 != null)
        {
                val_1 = other.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkReflectionPathInfo_Clone(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkReflectionPathInfo()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkReflectionPathInfo();
    }

}
