using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class StatisticUpdate : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string StatisticName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Value;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<uint> Version;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StatisticUpdate()
        {
        
        }
    
    }

}
