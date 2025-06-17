using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class Certificate : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Base64EncodedValue;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Password;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Certificate()
        {
        
        }
    
    }

}
