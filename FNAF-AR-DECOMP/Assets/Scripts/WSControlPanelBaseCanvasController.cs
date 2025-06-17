using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class WSControlPanelBaseCanvasController : CanvasController
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected WSCube cube;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void InitWithCube(WSCube cube)
    {
        this.cube = cube;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WSControlPanelBaseCanvasController()
    {
    
    }

}
