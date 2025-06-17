using UnityEngine;

namespace PlayFab.Internal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ApiProcessingEventArgs
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ApiEndpoint;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.Internal.ApiProcessingEventType EventType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.SharedModels.PlayFabRequestCommon Request;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.SharedModels.PlayFabResultCommon Result;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TRequest GetRequest<TRequest>()
        {
            var val_2;
            if(this.Request != null)
            {
                    val_2 = this.Request;
                if(val_2 != null)
            {
                    return (object)val_2;
            }
            
            }
            
            val_2 = 0;
            return (object)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ApiProcessingEventArgs()
        {
        
        }
    
    }

}
