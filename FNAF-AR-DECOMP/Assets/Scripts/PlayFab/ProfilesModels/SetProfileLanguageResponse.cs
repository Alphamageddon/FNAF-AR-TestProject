using UnityEngine;

namespace PlayFab.ProfilesModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class SetProfileLanguageResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.ProfilesModels.OperationTypes> OperationResult;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> VersionNumber;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SetProfileLanguageResponse()
        {
            val_1 = new System.Object();
        }
    
    }

}
