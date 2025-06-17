using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ConnectedPlayer : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayerId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ConnectedPlayer()
        {
        
        }
    
    }

}
