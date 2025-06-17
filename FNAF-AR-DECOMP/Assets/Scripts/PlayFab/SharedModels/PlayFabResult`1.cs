using UnityEngine;

namespace PlayFab.SharedModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayFabResult<TResult>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TResult Result;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object CustomData;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabResult<TResult>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
    
    }

}
