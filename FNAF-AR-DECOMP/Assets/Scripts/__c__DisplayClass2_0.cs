using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class UiActionListenerProxy.<>c__DisplayClass2_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.AndroidJavaObject pendingAction;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UiActionListenerProxy.<>c__DisplayClass2_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <onUiAction>b__0()
    {
        this.pendingAction.Call(methodName:  "proceed", args:  System.Array.Empty<System.Object>());
    }

}
