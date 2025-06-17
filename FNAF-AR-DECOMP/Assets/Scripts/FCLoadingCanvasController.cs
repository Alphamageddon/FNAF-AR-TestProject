using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class FCLoadingCanvasController : CanvasController
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string sceneToLoad;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_SceneToLoad(string value)
    {
        this.sceneToLoad = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void CanvasDidAppear()
    {
        if((System.String.IsNullOrEmpty(value:  this.sceneToLoad)) != false)
        {
                UnityEngine.Debug.LogError(message:  "No SceneToLoad has been set on FCLoadingCanvasController.");
            return;
        }
        
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.LoadSceneRoutine(sceneName:  this.sceneToLoad));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.IEnumerator LoadSceneRoutine(string sceneName)
    {
        FCLoadingCanvasController.<LoadSceneRoutine>d__4 val_1 = new FCLoadingCanvasController.<LoadSceneRoutine>d__4();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .sceneName = sceneName;
        return (System.Collections.IEnumerator)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FCLoadingCanvasController()
    {
    
    }

}
