using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class WSColorControlCanvasController : WSControlPanelBaseCanvasController
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Color[] colors;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetLeftColor(int colorIndex)
    {
        if(69730304 == 0)
        {
                return;
        }
        
        this.SetLeftColor(color:  new UnityEngine.Color() {r = this.colors[(long)colorIndex], g = this.colors[(long)colorIndex], b = this.colors[(long)colorIndex], a = this.colors[(long)colorIndex]});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetRightColor(int colorIndex)
    {
        if(69730304 == 0)
        {
                return;
        }
        
        this.SetRightColor(color:  new UnityEngine.Color() {r = this.colors[(long)colorIndex], g = this.colors[(long)colorIndex], b = this.colors[(long)colorIndex], a = this.colors[(long)colorIndex]});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WSColorControlCanvasController()
    {
    
    }

}
