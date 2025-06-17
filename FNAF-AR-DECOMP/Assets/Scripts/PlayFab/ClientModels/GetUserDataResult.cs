using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetUserDataResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, PlayFab.ClientModels.UserDataRecord> Data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint DataVersion;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetUserDataResult()
        {
        
        }
    
    }

}
