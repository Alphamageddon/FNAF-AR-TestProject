using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ContainerImageReference : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ImageName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Tag;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ContainerImageReference()
        {
        
        }
    
    }

}
