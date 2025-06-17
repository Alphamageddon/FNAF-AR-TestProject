using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CharacterResult : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CharacterId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CharacterName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CharacterType;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CharacterResult()
        {
        
        }
    
    }

}
