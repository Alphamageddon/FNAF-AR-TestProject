using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class WwiseSwitchReference : WwiseGroupValueObjectReference
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly WwiseObjectType MyWwiseObjectType;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly WwiseObjectType MyGroupWwiseObjectType;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private WwiseSwitchGroupReference WwiseSwitchGroupReference;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override WwiseObjectType WwiseObjectType { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override WwiseObjectReference GroupObjectReference { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override WwiseObjectType GroupWwiseObjectType { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override WwiseObjectType get_WwiseObjectType()
    {
        null = null;
        return (WwiseObjectType)WwiseSwitchReference.MyWwiseObjectType;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override WwiseObjectReference get_GroupObjectReference()
    {
        return (WwiseObjectReference)this.WwiseSwitchGroupReference;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void set_GroupObjectReference(WwiseObjectReference value)
    {
        var val_2 = 0;
        this.WwiseSwitchGroupReference = ;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override WwiseObjectType get_GroupWwiseObjectType()
    {
        null = null;
        return (WwiseObjectType)WwiseSwitchReference.MyGroupWwiseObjectType;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WwiseSwitchReference()
    {
        val_1 = new UnityEngine.ScriptableObject();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static WwiseSwitchReference()
    {
        WwiseSwitchReference.MyWwiseObjectType = 10;
        WwiseSwitchReference.MyGroupWwiseObjectType = 11;
    }

}
