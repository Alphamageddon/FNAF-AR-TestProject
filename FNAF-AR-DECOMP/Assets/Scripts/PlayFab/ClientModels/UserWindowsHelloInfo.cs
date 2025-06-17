using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UserWindowsHelloInfo : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string WindowsHelloDeviceName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string WindowsHelloPublicKeyHash;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UserWindowsHelloInfo()
        {
        
        }
    
    }

}
