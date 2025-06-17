using UnityEngine;

namespace PlayFab.SharedModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayFabBaseModel
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ToJson()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            public static PlayFab.ISerializerPlugin PlayFab.PluginManager::GetPlugin<PlayFab.ISerializerPlugin>(PlayFab.PluginContract contract, string instanceName) = 3;
            return PlayFab.PluginManager.GetPlugin<PlayFab.ISerializerPlugin>(contract:  0, instanceName:  "").SerializeObject(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabBaseModel()
        {
        
        }
    
    }

}
