using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CoreCapacity : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Available;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Region;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Total;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.MultiplayerModels.AzureVmFamily> VmFamily;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CoreCapacity()
        {
        
        }
    
    }

}
