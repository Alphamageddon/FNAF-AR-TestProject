using UnityEngine;

namespace PlayFab.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class DeleteFilesResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.DataModels.EntityKey Entity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ProfileVersion;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DeleteFilesResponse()
        {
        
        }
    
    }

}
