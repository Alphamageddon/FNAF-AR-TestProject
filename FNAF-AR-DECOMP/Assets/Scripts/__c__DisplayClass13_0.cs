using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class AppCenterTask.<>c__DisplayClass13_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Threading.Tasks.TaskCompletionSource<bool> taskCompletionSource;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AppCenterTask.<>c__DisplayClass13_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <GetAwaiter>b__0(Microsoft.AppCenter.Unity.AppCenterTask task)
    {
        this.taskCompletionSource.SetResult(result:  true);
    }

}
