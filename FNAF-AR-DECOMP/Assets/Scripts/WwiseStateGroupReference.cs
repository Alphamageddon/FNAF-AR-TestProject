using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class WwiseStateGroupReference : WwiseObjectReference
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
        return (WwiseObjectType)WwiseStateGroupReference.MyWwiseObjectType;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WwiseStateGroupReference()
    {
        val_1 = new UnityEngine.ScriptableObject();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static WwiseStateGroupReference()
    {
        WwiseStateGroupReference.MyWwiseObjectType = 9;
    }

}
