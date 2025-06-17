using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class FCLoadingCanvasController.<LoadSceneRoutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string sceneName;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FCLoadingCanvasController <>4__this;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FCLoadingCanvasController.<LoadSceneRoutine>d__4(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.IDisposable.Dispose()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool MoveNext()
    {
        int val_8;
        if((this.<>1__state) == 2)
        {
            goto label_0;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        val_1.m_Handle = val_1.m_Handle & 4294967295;
        val_8 = 1;
        this.<>2__current = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(scene:  new UnityEngine.SceneManagement.Scene() {m_Handle = val_1.m_Handle});
        this.<>1__state = val_8;
        return (bool)val_8;
        label_0:
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_4;
        }
        
        UnityEngine.SceneManagement.Scene val_3 = UnityEngine.SceneManagement.SceneManager.GetSceneByName(name:  this.<>4__this.sceneToLoad);
        val_3.m_Handle = val_3.m_Handle & 4294967295;
        bool val_4 = UnityEngine.SceneManagement.SceneManager.SetActiveScene(scene:  new UnityEngine.SceneManagement.Scene() {m_Handle = val_3.m_Handle});
        goto label_5;
        label_1:
        this.<>1__state = 0;
        val_8 = 1;
        this.<>2__current = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName:  this.sceneName, mode:  1);
        this.<>1__state = 2;
        return (bool)val_8;
        label_4:
        UnityEngine.SceneManagement.Scene val_6 = UnityEngine.SceneManagement.SceneManager.GetSceneByName(name:  6486152);
        val_6.m_Handle = val_6.m_Handle & 4294967295;
        bool val_7 = UnityEngine.SceneManagement.SceneManager.SetActiveScene(scene:  new UnityEngine.SceneManagement.Scene() {m_Handle = val_6.m_Handle});
        label_5:
        this.<>4__this.DismissAllCanvasControllers(animated:  true, completion:  0);
        label_2:
        val_8 = 0;
        return (bool)val_8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
