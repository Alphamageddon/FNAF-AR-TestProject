using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GenericServiceId : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ServiceName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string UserId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GenericServiceId()
        {
        
        }
    
    }

}
