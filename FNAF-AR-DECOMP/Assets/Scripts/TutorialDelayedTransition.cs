using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class TutorialDelayedTransition : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private P7.CanvasFlow.CanvasController _canvasController;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float _delay;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string _transitionName;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Trigger()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.WaitAndTrigger());
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.IEnumerator WaitAndTrigger()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new TutorialDelayedTransition.<WaitAndTrigger>d__4();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TutorialDelayedTransition()
    {
    
    }

}
