using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class WwiseAcousticTextureReference : WwiseObjectReference
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly WwiseObjectType MyWwiseObjectType;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override WwiseObjectType WwiseObjectType { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override WwiseObjectType get_WwiseObjectType()
    {
        null = null;
        return (WwiseObjectType)WwiseAcousticTextureReference.MyWwiseObjectType;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WwiseAcousticTextureReference()
    {
        val_1 = new UnityEngine.ScriptableObject();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static WwiseAcousticTextureReference()
    {
        WwiseAcousticTextureReference.MyWwiseObjectType = 15;
    }

}
