using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkDiffractionPathInfo : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const uint kMaxNodes = 8;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkTransform virtualPos { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint nodeCount { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float diffraction { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float totLength { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float obstructionValue { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkDiffractionPathInfo(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkDiffractionPathInfo obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkDiffractionPathInfo(jarg1:  this.swigCPtr);
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
    public void set_virtualPos(AkTransform value)
    {
        AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_virtualPos_set(jarg1:  this.swigCPtr, jarg2:  AkTransform.getCPtr(obj:  value));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkTransform get_virtualPos()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_virtualPos_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkTransform)val_4;
        }
        
        AkTransform val_3 = null;
        val_4 = val_3;
        val_3 = new AkTransform(cPtr:  val_1, cMemoryOwn:  false);
        return (AkTransform)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_nodeCount(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_nodeCount_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_nodeCount()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_nodeCount_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_diffraction(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_diffraction_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_diffraction()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_diffraction_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_totLength(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_totLength_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_totLength()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_totLength_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_obstructionValue(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_obstructionValue_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_obstructionValue()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_obstructionValue_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static int GetSizeOf()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_GetSizeOf();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkVector GetNodes(uint idx)
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_GetNodes(jarg1:  this.swigCPtr, jarg2:  idx);
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
    public float GetAngles(uint idx)
    {
        return AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_GetAngles(jarg1:  this.swigCPtr, jarg2:  idx);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ulong GetPortals(uint idx)
    {
        return AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_GetPortals(jarg1:  this.swigCPtr, jarg2:  idx);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ulong GetRooms(uint idx)
    {
        return AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_GetRooms(jarg1:  this.swigCPtr, jarg2:  idx);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Clone(AkDiffractionPathInfo other)
    {
        AkDiffractionPathInfo val_1 = other;
        if(val_1 != null)
        {
                val_1 = other.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_Clone(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkDiffractionPathInfo()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkDiffractionPathInfo();
    }

}
