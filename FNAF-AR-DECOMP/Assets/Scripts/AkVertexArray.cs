using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkVertexArray : AkBaseArray<AkVertex>
{
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override int StructureSize { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkVertexArray(int count)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override int get_StructureSize()
    {
        return AkSoundEnginePINVOKE.CSharp_AkVertex_GetSizeOf();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void DefaultConstructAtIntPtr(IntPtr address)
    {
        AkSoundEnginePINVOKE.CSharp_AkVertex_Clear(jarg1:  address);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override AkVertex CreateNewReferenceFromIntPtr(IntPtr address)
    {
        .swigCMemOwn = false;
        .swigCPtr = address;
        return (AkVertex)new AkVertex();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkVertex other)
    {
        AkVertex val_1 = other;
        if(val_1 != null)
        {
                val_1 = other.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkVertex_Clone(jarg1:  address, jarg2:  val_1);
    }

}
