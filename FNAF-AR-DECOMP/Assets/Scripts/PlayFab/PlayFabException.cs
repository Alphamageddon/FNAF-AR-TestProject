using UnityEngine;

namespace PlayFab
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayFabException : Exception
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly PlayFab.PlayFabExceptionCode Code;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabException(PlayFab.PlayFabExceptionCode code, string message)
        {
            this.Code = code;
        }
    
    }

}
