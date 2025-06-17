using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class BuildRegion : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.MultiplayerModels.CurrentServerStats CurrentServerStats;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MaxServers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Region;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int StandbyServers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Status;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BuildRegion()
        {
        
        }
    
    }

}
