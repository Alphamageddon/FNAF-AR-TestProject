using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkExternalSourceInfoArray : AkBaseArray<AkExternalSourceInfo>
{
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override int StructureSize { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkExternalSourceInfoArray(int count)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override int get_StructureSize()
    {
        return AkSoundEnginePINVOKE.CSharp_AkExternalSourceInfo_GetSizeOf();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void DefaultConstructAtIntPtr(IntPtr address)
    {
        AkSoundEnginePINVOKE.CSharp_AkExternalSourceInfo_Clear(jarg1:  address);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void ReleaseAllocatedMemoryFromReferenceAtIntPtr(IntPtr address)
    {
        AkSoundEnginePINVOKE.CSharp_AkExternalSourceInfo_szFile_set(jarg1:  address, jarg2:  0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override AkExternalSourceInfo CreateNewReferenceFromIntPtr(IntPtr address)
    {
        .swigCMemOwn = false;
        .swigCPtr = address;
        return (AkExternalSourceInfo)new AkExternalSourceInfo();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkExternalSourceInfo other)
    {
        AkExternalSourceInfo val_1 = other;
        if(val_1 != null)
        {
                val_1 = other.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkExternalSourceInfo_Clone(jarg1:  address, jarg2:  val_1);
    }

}
