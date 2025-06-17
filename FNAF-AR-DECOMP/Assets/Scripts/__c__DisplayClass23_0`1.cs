using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class PlayFabHttp.<>c__DisplayClass23_0<TResult>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PlayFab.Internal.CallRequestContainer reqContainer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PlayFab.ISerializerPlugin serializer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<TResult> resultCallback;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PlayFabHttp.<>c__DisplayClass23_0<TResult>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <_MakeApiCall>b__0()
    {
        var val_2;
        var val_4 = X19;
        if((X19 + 286) == 0)
        {
            goto label_5;
        }
        
        var val_1 = X19 + 176;
        var val_2 = 0;
        val_1 = val_1 + 8;
        label_4:
        if(((X19 + 176 + 8) + -8) == (__RuntimeMethodHiddenParam + 24 + 192 + 24))
        {
            goto label_3;
        }
        
        val_2 = val_2 + 1;
        val_1 = val_1 + 16;
        if(val_2 < (X19 + 286))
        {
            goto label_4;
        }
        
        goto label_5;
        label_3:
        var val_3 = val_1;
        val_3 = val_3 + (__RuntimeMethodHiddenParam + 24 + 192 + 72);
        val_4 = val_4 + val_3;
        val_2 = val_4 + 296;
        label_5:
        mem2[0] = X19;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <_MakeApiCall>b__1()
    {
        if(X19 == 0)
        {
                return;
        }
        
        if((X22 + 80) == 0)
        {
                return;
        }
        
        if((X22 + 80) != 0)
        {
                return;
        }
    
    }

}
