using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class SharedGroupDataRecord : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime LastUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string LastUpdatedBy;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.ClientModels.UserDataPermission> Permission;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Value;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedGroupDataRecord()
        {
        
        }
    
    }

}
