using UnityEngine;

namespace PlayFab.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class FinalizeFileUploadsRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.DataModels.EntityKey Entity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> FileNames;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FinalizeFileUploadsRequest()
        {
        
        }
    
    }

}
