using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class TitleMultiplayerServersQuotas : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.MultiplayerModels.CoreCapacity> CoreCapacities;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TitleMultiplayerServersQuotas()
        {
        
        }
    
    }

}
