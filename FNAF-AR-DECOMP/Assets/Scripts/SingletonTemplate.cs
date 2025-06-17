using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class SingletonTemplate : Singleton<SingletonTemplate>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool logDebugDetails;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool showDebugVisuals;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool showingDebugVisuals;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static SingletonTemplate()
    {
        null = null;
        Singleton<T>.applicationIsQuitting = false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected SingletonTemplate()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void LogError(string functionName, string logString)
    {
        UnityEngine.Debug.LogError(message:  System.String.Format(format:  "[SingletonTemplate][{0}] {1}", arg0:  functionName, arg1:  logString));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void LogDebug(string functionName, string logString)
    {
        if(this.logDebugDetails == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "[SingletonTemplate][{0}] {1}", arg0:  functionName, arg1:  logString));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        bool val_1;
        if(this.showDebugVisuals != false)
        {
                val_1 = 1;
        }
        else
        {
                if(this.showingDebugVisuals == false)
        {
                return;
        }
        
            val_1 = false;
        }
        
        this.showingDebugVisuals = val_1;
    }

}
