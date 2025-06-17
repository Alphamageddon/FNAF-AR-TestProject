using UnityEngine;

namespace PlayFab.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class FinalizeFileUploadsResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.DataModels.EntityKey Entity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, PlayFab.DataModels.GetFileMetadata> Metadata;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ProfileVersion;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FinalizeFileUploadsResponse()
        {
        
        }
    
    }

}
