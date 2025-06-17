using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class IllumixHorizontalBoundedPlane : IllumixSurfaceObject
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<UnityEngine.Vector3> <Boundary>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float <Height>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static int _objectCounter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly int <Key>k__BackingField;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<UnityEngine.Vector3> Boundary { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float Height { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int Key { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<UnityEngine.Vector3> get_Boundary()
    {
        return (System.Collections.Generic.List<UnityEngine.Vector3>)this.<Boundary>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void set_Boundary(System.Collections.Generic.List<UnityEngine.Vector3> value)
    {
        this.<Boundary>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_Height()
    {
        return (float)this.<Height>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void set_Height(float value)
    {
        this.<Height>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_Key()
    {
        return (int)this.<Key>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IllumixHorizontalBoundedPlane(System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 initialCenter, int updateKey)
    {
        null = null;
        IllumixHorizontalBoundedPlane._objectCounter = IllumixHorizontalBoundedPlane._objectCounter + 1;
        this = new System.Object();
        mem[1152921518948786272] = initialCenter.x;
        mem[1152921518948786276] = initialCenter.y;
        mem[1152921518948786280] = initialCenter.z;
        mem[1152921518948786288] = "HBP" + IllumixHorizontalBoundedPlane._objectCounter;
        this.<Boundary>k__BackingField = boundary;
        this.<Height>k__BackingField = initialCenter.y;
        mem[1152921518948786296] = 1;
        this.<Key>k__BackingField = updateKey;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void UpdatePlane(System.Collections.Generic.List<UnityEngine.Vector3> boundary, float weightedHeight)
    {
        this.<Boundary>k__BackingField = boundary;
        this.<Height>k__BackingField = weightedHeight;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static IllumixHorizontalBoundedPlane()
    {
    
    }

}
