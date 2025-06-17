using UnityEngine;

namespace PlayFab.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetFilesRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.DataModels.EntityKey Entity;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetFilesRequest()
        {
        
        }
    
    }

}
