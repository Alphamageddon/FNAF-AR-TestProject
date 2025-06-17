using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkObstructionOcclusionValuesArray : AkBaseArray<AkObstructionOcclusionValues>
{
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override int StructureSize { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkObstructionOcclusionValuesArray(int count)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override int get_StructureSize()
    {
        return AkSoundEnginePINVOKE.CSharp_AkObstructionOcclusionValues_GetSizeOf();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void DefaultConstructAtIntPtr(IntPtr address)
    {
        AkSoundEnginePINVOKE.CSharp_AkObstructionOcclusionValues_Clear(jarg1:  address);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override AkObstructionOcclusionValues CreateNewReferenceFromIntPtr(IntPtr address)
    {
        .swigCMemOwn = false;
        .swigCPtr = address;
        return (AkObstructionOcclusionValues)new AkObstructionOcclusionValues();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkObstructionOcclusionValues other)
    {
        AkObstructionOcclusionValues val_1 = other;
        if(val_1 != null)
        {
                val_1 = other.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkObstructionOcclusionValues_Clone(jarg1:  address, jarg2:  val_1);
    }

}
