using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class WwiseBankReference : WwiseObjectReference
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
        return (WwiseObjectType)WwiseBankReference.MyWwiseObjectType;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WwiseBankReference()
    {
        val_1 = new UnityEngine.ScriptableObject();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static WwiseBankReference()
    {
        WwiseBankReference.MyWwiseObjectType = 7;
    }

}
