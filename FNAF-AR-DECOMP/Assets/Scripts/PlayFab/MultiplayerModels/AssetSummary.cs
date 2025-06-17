using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class AssetSummary : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FileName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> Metadata;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AssetSummary()
        {
        
        }
    
    }

}
