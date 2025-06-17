using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class PlayFabClientInstanceAPI.<>c__DisplayClass24_0<TOut>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<PlayFab.ClientModels.ExecuteCloudScriptResult> resultCallback;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PlayFabClientInstanceAPI.<>c__DisplayClass24_0<TOut>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <ExecuteCloudScript>b__0(PlayFab.ClientModels.ExecuteCloudScriptResult wrappedResult)
    {
        PlayFab.ISerializerPlugin val_1 = PlayFab.PluginManager.GetPlugin<PlayFab.ISerializerPlugin>(contract:  0, instanceName:  "");
        var val_5 = 0;
        val_5 = val_5 + 1;
        public static PlayFab.ISerializerPlugin PlayFab.PluginManager::GetPlugin<PlayFab.ISerializerPlugin>(PlayFab.PluginContract contract, string instanceName) = 3;
        string val_3 = val_1.SerializeObject(obj:  wrappedResult.FunctionResult);
        var val_6 = 0;
        val_6 = val_6 + 1;
        wrappedResult.FunctionResult = val_1;
        this.Invoke(obj:  wrappedResult);
    }

}
