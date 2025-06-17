using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class FCMenuCanvasController : CanvasController
{
    // Methods
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
        
        mem2[0] = "FCGameScene";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FCMenuCanvasController()
    {
    
    }

}
