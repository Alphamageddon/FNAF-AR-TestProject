using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UserGoogleInfo : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GoogleEmail;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GoogleGender;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GoogleId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GoogleLocale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GoogleName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UserGoogleInfo()
        {
        
        }
    
    }

}
