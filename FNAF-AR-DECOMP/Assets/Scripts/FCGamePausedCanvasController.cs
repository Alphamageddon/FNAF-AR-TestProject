using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class FCGamePausedCanvasController : CanvasController
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.RectTransform mainContent;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void CanvasWillAppear()
    {
        if(this.IsBeingPresented == false)
        {
                return;
        }
        
        UnityEngine.Time.timeScale = 0f;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void CanvasWillDisappear()
    {
        if(this.IsBeingDismissed == false)
        {
                return;
        }
        
        UnityEngine.Time.timeScale = 1f;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void PrepareForStoryboardTransition(P7.CanvasFlow.StoryboardTransition transition)
    {
        if(transition.DestinationCanvasController() == null)
        {
                return;
        }
        
        if(transition.direction != 0)
        {
                return;
        }
        
        mem2[0] = "FCMenuScene";
        UnityEngine.Time.timeScale = 1f;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FCGamePausedCanvasController()
    {
    
    }

}
