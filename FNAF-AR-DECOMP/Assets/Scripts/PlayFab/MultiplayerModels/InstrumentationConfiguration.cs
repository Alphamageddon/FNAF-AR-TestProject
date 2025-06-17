using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class InstrumentationConfiguration : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> ProcessesToMonitor;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InstrumentationConfiguration()
        {
        
        }
    
    }

}
