using UnityEngine;

namespace PlayFab.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetObjectsRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.DataModels.EntityKey Entity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> EscapeObject;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetObjectsRequest()
        {
        
        }
    
    }

}
