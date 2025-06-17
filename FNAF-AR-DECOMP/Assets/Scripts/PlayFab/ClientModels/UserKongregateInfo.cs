using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UserKongregateInfo : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string KongregateId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string KongregateName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UserKongregateInfo()
        {
        
        }
    
    }

}
