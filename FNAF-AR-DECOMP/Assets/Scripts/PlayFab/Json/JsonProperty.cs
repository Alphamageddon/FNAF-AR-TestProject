using UnityEngine;

namespace PlayFab.Json
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class JsonProperty : Attribute
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PropertyName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.Json.NullValueHandling NullValueHandling;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public JsonProperty()
        {
        
        }
    
    }

}
