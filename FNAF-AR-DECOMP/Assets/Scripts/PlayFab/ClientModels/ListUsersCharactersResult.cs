using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ListUsersCharactersResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.CharacterResult> Characters;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ListUsersCharactersResult()
        {
        
        }
    
    }

}
