using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class FCPassDataFromGameToUI : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FCPlayer player;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnGameStoryboardWillPresentInitialCanvasController(P7.CanvasFlow.StoryboardTransition transition)
    {
        transition.DestinationCanvasController<FCGameOverlayCanvasController>().ConfigureWithPlayer(_player:  this.player);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FCPassDataFromGameToUI()
    {
    
    }

}
