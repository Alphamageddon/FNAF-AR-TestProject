using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkTriangleArray : AkBaseArray<AkTriangle>
{
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override int StructureSize { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkTriangleArray(int count)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override int get_StructureSize()
    {
        return AkSoundEnginePINVOKE.CSharp_AkTriangle_GetSizeOf();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void DefaultConstructAtIntPtr(IntPtr address)
    {
        AkSoundEnginePINVOKE.CSharp_AkTriangle_Clear(jarg1:  address);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override AkTriangle CreateNewReferenceFromIntPtr(IntPtr address)
    {
        .swigCMemOwn = false;
        .swigCPtr = address;
        return (AkTriangle)new AkTriangle();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkTriangle other)
    {
        AkTriangle val_1 = other;
        if(val_1 != null)
        {
                val_1 = other.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkTriangle_Clone(jarg1:  address, jarg2:  val_1);
    }

}
