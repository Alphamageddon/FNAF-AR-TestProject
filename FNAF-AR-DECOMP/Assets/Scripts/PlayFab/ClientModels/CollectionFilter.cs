using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CollectionFilter : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.Container_Dictionary_String_String> Excludes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.Container_Dictionary_String_String> Includes;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CollectionFilter()
        {
        
        }
    
    }

}
