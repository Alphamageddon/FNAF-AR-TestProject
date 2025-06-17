using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ListContainerImageTagsResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> Tags;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ListContainerImageTagsResponse()
        {
        
        }
    
    }

}
