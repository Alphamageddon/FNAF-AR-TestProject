using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public abstract class IllumixSurfaceObject
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 center;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string <id>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool <isActive>k__BackingField;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string id { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool isActive { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_id()
    {
        return (string)this.<id>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void set_id(string value)
    {
        this.<id>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_isActive()
    {
        return (bool)this.<isActive>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void set_isActive(bool value)
    {
        this.<isActive>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected IllumixSurfaceObject(UnityEngine.Vector3 center, string objectId)
    {
        this.center = center;
        mem[1152921518950111236] = center.y;
        mem[1152921518950111240] = center.z;
        this.<id>k__BackingField = objectId;
        this.<isActive>k__BackingField = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void TakeId(IllumixSurfaceObject obj)
    {
        this.<id>k__BackingField = obj.<id>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetActive(bool isActive)
    {
        this.<isActive>k__BackingField = isActive;
    }

}
