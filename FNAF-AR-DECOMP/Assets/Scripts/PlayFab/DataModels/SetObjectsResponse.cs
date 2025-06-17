using UnityEngine;

namespace PlayFab.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class SetObjectsResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ProfileVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.DataModels.SetObjectInfo> SetResults;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SetObjectsResponse()
        {
        
        }
    
    }

}
