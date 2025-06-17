using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CurrentGamesResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GameCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.GameInfo> Games;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int PlayerCount;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CurrentGamesResult()
        {
        
        }
    
    }

}
