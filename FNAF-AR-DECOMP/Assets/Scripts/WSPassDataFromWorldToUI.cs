using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class WSPassDataFromWorldToUI : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WSCube cube;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnStoryboardWillPerformTransition(P7.CanvasFlow.StoryboardTransition transition)
    {
        if(transition.direction != 0)
        {
                return;
        }
        
        if((transition.DestinationCanvasController<WSControlPanelBaseCanvasController>()) == 0)
        {
                return;
        }
        
        this = this.cube;
        val_1.cube = this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WSPassDataFromWorldToUI()
    {
    
    }

}
