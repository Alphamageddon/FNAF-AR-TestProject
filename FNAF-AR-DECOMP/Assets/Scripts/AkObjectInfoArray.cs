using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkObjectInfoArray : AkBaseArray<AkObjectInfo>
{
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override int StructureSize { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkObjectInfoArray(int count)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override int get_StructureSize()
    {
        return AkSoundEnginePINVOKE.CSharp_AkObjectInfo_GetSizeOf();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void DefaultConstructAtIntPtr(IntPtr address)
    {
        AkSoundEnginePINVOKE.CSharp_AkObjectInfo_Clear(jarg1:  address);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override AkObjectInfo CreateNewReferenceFromIntPtr(IntPtr address)
    {
        .swigCMemOwn = false;
        .swigCPtr = address;
        return (AkObjectInfo)new AkObjectInfo();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkObjectInfo other)
    {
        AkObjectInfo val_1 = other;
        if(val_1 != null)
        {
                val_1 = other.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkObjectInfo_Clone(jarg1:  address, jarg2:  val_1);
    }

}
