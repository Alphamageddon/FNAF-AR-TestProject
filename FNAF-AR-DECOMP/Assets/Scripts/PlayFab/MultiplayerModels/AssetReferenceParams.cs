using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class AssetReferenceParams : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FileName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string MountPath;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AssetReferenceParams()
        {
        
        }
    
    }

}
