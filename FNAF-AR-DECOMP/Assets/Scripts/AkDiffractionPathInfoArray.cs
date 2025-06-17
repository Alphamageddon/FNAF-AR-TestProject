using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkDiffractionPathInfoArray : AkBaseArray<AkDiffractionPathInfo>
{
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override int StructureSize { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkDiffractionPathInfoArray(int count)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override int get_StructureSize()
    {
        return AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_GetSizeOf();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override AkDiffractionPathInfo CreateNewReferenceFromIntPtr(IntPtr address)
    {
        .swigCMemOwn = false;
        .swigCPtr = address;
        return (AkDiffractionPathInfo)new AkDiffractionPathInfo();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkDiffractionPathInfo other)
    {
        AkDiffractionPathInfo val_1 = other;
        if(val_1 != null)
        {
                val_1 = other.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_Clone(jarg1:  address, jarg2:  val_1);
    }

}
