using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class GetAccessToData.<>c__DisplayClass43_0<T>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Game.MasterData.GetAccessToData.ReturnAnyData<T> dataCallback;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GetAccessToData.<>c__DisplayClass43_0<T>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <GetDataAsync>b__0(Google.Protobuf.IMessage t)
    {
        var val_2;
        if(t == null)
        {
            goto label_1;
        }
        
        val_2 = t;
        if(val_2 != null)
        {
            goto label_2;
        }
        
        label_1:
        val_2 = 0;
        label_2:
        if(this != null)
        {
                return;
        }
    
    }

}
