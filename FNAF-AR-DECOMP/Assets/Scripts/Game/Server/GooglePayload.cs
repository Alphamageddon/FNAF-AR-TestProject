using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GooglePayload
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string json;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string signature;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GooglePayload()
        {
        
        }
    
    }

}
