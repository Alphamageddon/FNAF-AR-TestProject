using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkEventCallbackData : ScriptableObject
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<int> callbackFlags;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<string> callbackFunc;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<UnityEngine.GameObject> callbackGameObj;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int uFlags;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkEventCallbackData()
    {
        this.callbackFlags = new System.Collections.Generic.List<System.Int32>();
        this.callbackFunc = new System.Collections.Generic.List<System.String>();
        this.callbackGameObj = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }

}
