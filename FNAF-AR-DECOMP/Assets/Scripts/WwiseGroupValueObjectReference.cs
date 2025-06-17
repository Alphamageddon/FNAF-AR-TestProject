using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public abstract class WwiseGroupValueObjectReference : WwiseObjectReference
{
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract WwiseObjectReference GroupObjectReference { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract WwiseObjectType GroupWwiseObjectType { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string DisplayName { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract WwiseObjectReference get_GroupObjectReference(); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void set_GroupObjectReference(WwiseObjectReference value); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract WwiseObjectType get_GroupWwiseObjectType(); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string get_DisplayName()
    {
        bool val_1 = UnityEngine.Object.op_Implicit(exists:  this);
        if(val_1 == false)
        {
                return (string)val_1;
        }
        
        if(this != null)
        {
                return 0 + " / "(" / ") + null;
        }
        
        return 0 + " / "(" / ") + null;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected WwiseGroupValueObjectReference()
    {
        val_1 = new UnityEngine.ScriptableObject();
    }

}
