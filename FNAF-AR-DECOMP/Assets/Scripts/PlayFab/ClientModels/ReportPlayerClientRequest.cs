using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ReportPlayerClientRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Comment;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ReporteeId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ReportPlayerClientRequest()
        {
        
        }
    
    }

}
