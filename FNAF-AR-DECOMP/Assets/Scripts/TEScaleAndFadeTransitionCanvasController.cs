using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class TEScaleAndFadeTransitionCanvasController : CanvasController
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.RectTransform mainContent;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnBackButtonPressed()
    {
        this.DismissCanvasController(animated:  true, completion:  0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TEScaleAndFadeTransitionCanvasController()
    {
    
    }

}
