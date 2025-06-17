using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GameCertificateReference : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GsdkAlias;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameCertificateReference()
        {
        
        }
    
    }

}
