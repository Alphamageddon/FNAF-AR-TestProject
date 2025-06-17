using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class QosServer : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Region;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ServerUrl;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public QosServer()
        {
        
        }
    
    }

}
