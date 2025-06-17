using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CharacterLeaderboardEntry : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CharacterId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CharacterName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CharacterType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DisplayName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayFabId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Position;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int StatValue;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CharacterLeaderboardEntry()
        {
        
        }
    
    }

}
