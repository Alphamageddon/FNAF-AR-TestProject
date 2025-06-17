using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CurrentServerStats : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Active;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Propping;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int StandingBy;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Total;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CurrentServerStats()
        {
        
        }
    
    }

}
