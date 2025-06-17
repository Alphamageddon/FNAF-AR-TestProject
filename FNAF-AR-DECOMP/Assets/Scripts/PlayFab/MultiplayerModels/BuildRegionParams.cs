using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class BuildRegionParams : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MaxServers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Region;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int StandbyServers;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BuildRegionParams()
        {
        
        }
    
    }

}
