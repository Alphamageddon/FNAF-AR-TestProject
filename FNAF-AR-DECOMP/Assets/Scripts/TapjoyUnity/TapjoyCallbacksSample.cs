using UnityEngine;

namespace TapjoyUnity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TapjoyCallbacksSample : TapjoyRuntimeCallbacks
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string GetFyberUserId()
        {
            return "";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TapjoyCallbacksSample()
        {
        
        }
    
    }

}
