using UnityEngine;

namespace SRDebugger.Profiler
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ProfilerLateUpdateListener : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action OnLateUpdate;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LateUpdate()
        {
            if(this.OnLateUpdate == null)
            {
                    return;
            }
            
            this.OnLateUpdate.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProfilerLateUpdateListener()
        {
        
        }
    
    }

}
