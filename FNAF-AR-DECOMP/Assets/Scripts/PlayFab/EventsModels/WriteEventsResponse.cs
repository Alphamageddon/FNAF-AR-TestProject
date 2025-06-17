using UnityEngine;

namespace PlayFab.EventsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class WriteEventsResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> AssignedEventIds;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WriteEventsResponse()
        {
        
        }
    
    }

}
