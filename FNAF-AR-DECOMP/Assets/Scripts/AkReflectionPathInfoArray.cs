using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkReflectionPathInfoArray : AkBaseArray<AkReflectionPathInfo>
{
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override int StructureSize { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkReflectionPathInfoArray(int count)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override int get_StructureSize()
    {
        return AkSoundEnginePINVOKE.CSharp_AkReflectionPathInfo_GetSizeOf();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override AkReflectionPathInfo CreateNewReferenceFromIntPtr(IntPtr address)
    {
        .swigCMemOwn = false;
        .swigCPtr = address;
        return (AkReflectionPathInfo)new AkReflectionPathInfo();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkReflectionPathInfo other)
    {
        AkReflectionPathInfo val_1 = other;
        if(val_1 != null)
        {
                val_1 = other.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkReflectionPathInfo_Clone(jarg1:  address, jarg2:  val_1);
    }

}
