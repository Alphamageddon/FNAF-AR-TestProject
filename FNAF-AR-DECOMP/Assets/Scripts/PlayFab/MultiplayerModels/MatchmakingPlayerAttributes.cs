using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class MatchmakingPlayerAttributes : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object DataObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EscapedDataObject;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MatchmakingPlayerAttributes()
        {
        
        }
    
    }

}
