using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ConsumeItemResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ItemInstanceId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int RemainingUses;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ConsumeItemResult()
        {
        
        }
    
    }

}
