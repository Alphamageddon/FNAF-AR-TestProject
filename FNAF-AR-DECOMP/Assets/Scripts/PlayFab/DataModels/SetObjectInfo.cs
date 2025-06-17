using UnityEngine;

namespace PlayFab.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class SetObjectInfo : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ObjectName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string OperationReason;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.DataModels.OperationTypes> SetResult;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SetObjectInfo()
        {
        
        }
    
    }

}
