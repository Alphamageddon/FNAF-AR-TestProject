using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class AttributeInstallRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Adid;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Idfa;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AttributeInstallRequest()
        {
        
        }
    
    }

}
