using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkSourceSettingsArray : AkBaseArray<AkSourceSettings>
{
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override int StructureSize { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkSourceSettingsArray(int count)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override int get_StructureSize()
    {
        return AkSoundEnginePINVOKE.CSharp_AkSourceSettings_GetSizeOf();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void DefaultConstructAtIntPtr(IntPtr address)
    {
        AkSoundEnginePINVOKE.CSharp_AkSourceSettings_Clear(jarg1:  address);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override AkSourceSettings CreateNewReferenceFromIntPtr(IntPtr address)
    {
        .swigCMemOwn = false;
        .swigCPtr = address;
        return (AkSourceSettings)new AkSourceSettings();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkSourceSettings other)
    {
        AkSourceSettings val_1 = other;
        if(val_1 != null)
        {
                val_1 = other.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkSourceSettings_Clone(jarg1:  address, jarg2:  val_1);
    }

}
