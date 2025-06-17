using UnityEngine;

namespace PlayFab.SharedModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayFabResultCommon : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.SharedModels.PlayFabRequestCommon Request;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object CustomData;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabResultCommon()
        {
            val_1 = new System.Object();
        }
    
    }

}
