using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class GetSocialFactory.<>c__DisplayClass5_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Type type;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GetSocialSdk.Core.GetSocialFactory.AvailableRuntimes currentRuntime;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GetSocialFactory.<>c__DisplayClass5_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal bool <FindBridgeImplementation>b__1(System.Type p)
    {
        var val_3;
        if((this.type & 1) != 0)
        {
                val_3 = p.IsAbstract ^ 1;
            return (bool)val_3 & 1;
        }
        
        val_3 = 0;
        return (bool)val_3 & 1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal bool <FindBridgeImplementation>b__3(GetSocialSdk.Core.IGetSocialNativeBridge impl)
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        return System.Linq.Enumerable.Contains<AvailableRuntimes>(source:  impl.RuntimeImplementation, value:  this.currentRuntime);
    }

}
