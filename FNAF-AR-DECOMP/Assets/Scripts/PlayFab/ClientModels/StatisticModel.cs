using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class StatisticModel : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Value;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Version;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StatisticModel()
        {
        
        }
    
    }

}
