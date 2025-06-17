using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class AppCenterInternal.<>c__DisplayClass9_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Microsoft.AppCenter.Unity.AppCenterTask<string> stringTask;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AppCenterInternal.<>c__DisplayClass9_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <GetInstallIdAsync>b__0(Microsoft.AppCenter.Unity.AppCenterTask<UnityEngine.AndroidJavaObject> t)
    {
        string val_5;
        if(t.Result != null)
        {
                val_5 = t.Result.Call<System.String>(methodName:  "toString", args:  System.Array.Empty<System.Object>());
        }
        else
        {
                val_5 = 0;
        }
        
        this.stringTask.SetResult(result:  val_5);
    }

}
