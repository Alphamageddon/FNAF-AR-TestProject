using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class TEDefaultTransitionCanvasController : CanvasController
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnBackButtonPressed()
    {
        this.DismissCanvasController(animated:  true, completion:  0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TEDefaultTransitionCanvasController()
    {
    
    }

}
