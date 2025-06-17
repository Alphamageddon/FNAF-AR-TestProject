using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkMultiPosEvent
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool eventIsPlaying;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<AkAmbient> list;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void FinishedPlaying(object in_cookie, AkCallbackType in_type, object in_info)
    {
        this.eventIsPlaying = false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMultiPosEvent()
    {
        this.list = new System.Collections.Generic.List<AkAmbient>();
    }

}
