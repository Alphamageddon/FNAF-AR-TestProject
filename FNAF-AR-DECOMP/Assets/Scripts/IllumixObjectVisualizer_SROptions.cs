using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class IllumixObjectVisualizer_SROptions
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IllumixObjectVisualizer iov;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool HideMesh { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IllumixObjectVisualizer_SROptions(IllumixObjectVisualizer sop)
    {
        this.iov = sop;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void ToggleVisibility()
    {
        this.iov.ToggleVisibility();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void ClearObjects()
    {
        this.iov.ClearObjects();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_HideMesh()
    {
        if(this.iov != null)
        {
                return (bool)this.iov.hideMesh;
        }
        
        return (bool)this.iov.hideMesh;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_HideMesh(bool value)
    {
        this.iov.hideMesh = value;
    }

}
