using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class PlatformBase.<>c__DisplayClass52_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string message;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PlatformBase.<>c__DisplayClass52_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <DebugMsg>b__0()
    {
        if(GameSparksSettings.DebugBuild == false)
        {
                return;
        }
        
        if(this.message.Length <= 1499)
        {
                string val_3 = "GS: "("GS: ") + this.message;
        }
        
        UnityEngine.Debug.Log(message:  "GS: "("GS: ") + this.message.Substring(startIndex:  0, length:  220)(this.message.Substring(startIndex:  0, length:  220)) + "...");
    }

}
