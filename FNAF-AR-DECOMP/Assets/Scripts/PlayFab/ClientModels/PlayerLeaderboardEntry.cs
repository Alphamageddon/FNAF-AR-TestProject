using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class PlayerLeaderboardEntry : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DisplayName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayFabId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Position;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.PlayerProfileModel Profile;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int StatValue;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayerLeaderboardEntry()
        {
        
        }
    
    }

}
