using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GrantCharacterToUserResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CharacterId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CharacterType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Result;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GrantCharacterToUserResult()
        {
        
        }
    
    }

}
