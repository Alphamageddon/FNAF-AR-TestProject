using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ReportPlayerClientResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int SubmissionsRemaining;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ReportPlayerClientResult()
        {
        
        }
    
    }

}
