using UnityEngine;

namespace PlayFab.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class InitiateFileUploadsResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.DataModels.EntityKey Entity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ProfileVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.DataModels.InitiateFileUploadMetadata> UploadDetails;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InitiateFileUploadsResponse()
        {
        
        }
    
    }

}
