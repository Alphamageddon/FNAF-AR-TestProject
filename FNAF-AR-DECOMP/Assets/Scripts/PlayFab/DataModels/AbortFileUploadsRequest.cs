using UnityEngine;

namespace PlayFab.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class AbortFileUploadsRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.DataModels.EntityKey Entity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> FileNames;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> ProfileVersion;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AbortFileUploadsRequest()
        {
        
        }
    
    }

}
