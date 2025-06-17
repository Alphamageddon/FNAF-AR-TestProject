using UnityEngine;

namespace PlayFab.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class InitiateFileUploadMetadata : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FileName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string UploadUrl;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InitiateFileUploadMetadata()
        {
        
        }
    
    }

}
