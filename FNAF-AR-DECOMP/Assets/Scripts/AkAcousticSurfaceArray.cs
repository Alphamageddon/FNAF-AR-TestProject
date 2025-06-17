using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkAcousticSurfaceArray : AkBaseArray<AkAcousticSurface>
{
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override int StructureSize { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkAcousticSurfaceArray(int count)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override int get_StructureSize()
    {
        return AkSoundEnginePINVOKE.CSharp_AkAcousticSurface_GetSizeOf();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void DefaultConstructAtIntPtr(IntPtr address)
    {
        AkSoundEnginePINVOKE.CSharp_AkAcousticSurface_Clear(jarg1:  address);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override AkAcousticSurface CreateNewReferenceFromIntPtr(IntPtr address)
    {
        .swigCMemOwn = false;
        .swigCPtr = address;
        return (AkAcousticSurface)new AkAcousticSurface();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkAcousticSurface other)
    {
        AkAcousticSurface val_1 = other;
        if(val_1 != null)
        {
                val_1 = other.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkAcousticSurface_Clone(jarg1:  address, jarg2:  val_1);
    }

}
