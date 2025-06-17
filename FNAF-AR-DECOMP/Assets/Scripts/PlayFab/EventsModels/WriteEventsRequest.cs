using UnityEngine;

namespace PlayFab.EventsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class WriteEventsRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.EventsModels.EventContents> Events;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WriteEventsRequest()
        {
        
        }
    
    }

}
