using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class FCGameCompleteCanvasController : CanvasController
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.RectTransform mainContent;
    
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
        
        mem2[0] = "FCMenuScene";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FCGameCompleteCanvasController()
    {
    
    }

}
