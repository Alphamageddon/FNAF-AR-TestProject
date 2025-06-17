using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class WriteClientCharacterEventRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, object> Body;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CharacterId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EventName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> Timestamp;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WriteClientCharacterEventRequest()
        {
        
        }
    
    }

}
