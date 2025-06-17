using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetCharacterDataRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CharacterId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<uint> IfChangedFromDataVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> Keys;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayFabId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetCharacterDataRequest()
        {
        
        }
    
    }

}
