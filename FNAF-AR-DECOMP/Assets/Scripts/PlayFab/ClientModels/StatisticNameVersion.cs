using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class StatisticNameVersion : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string StatisticName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint Version;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StatisticNameVersion()
        {
        
        }
    
    }

}
