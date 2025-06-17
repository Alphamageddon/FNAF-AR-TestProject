using UnityEngine;

namespace PlayFab.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class SetObjectsRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.DataModels.EntityKey Entity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> ExpectedProfileVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.DataModels.SetObject> Objects;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SetObjectsRequest()
        {
        
        }
    
    }

}
