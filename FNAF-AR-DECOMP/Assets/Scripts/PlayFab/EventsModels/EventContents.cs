using UnityEngine;

namespace PlayFab.EventsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class EventContents : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.EventsModels.EntityKey Entity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EventNamespace;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string OriginalId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> OriginalTimestamp;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object Payload;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PayloadJSON;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EventContents()
        {
        
        }
    
    }

}
