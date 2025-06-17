using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class VirtualMachineSummary : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string HealthStatus;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string State;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string VmId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VirtualMachineSummary()
        {
        
        }
    
    }

}
