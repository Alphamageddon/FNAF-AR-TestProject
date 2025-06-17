using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class WwiseAuxBusReference : WwiseObjectReference
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
        return (WwiseObjectType)WwiseAuxBusReference.MyWwiseObjectType;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WwiseAuxBusReference()
    {
        val_1 = new UnityEngine.ScriptableObject();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static WwiseAuxBusReference()
    {
        WwiseAuxBusReference.MyWwiseObjectType = 1;
    }

}
