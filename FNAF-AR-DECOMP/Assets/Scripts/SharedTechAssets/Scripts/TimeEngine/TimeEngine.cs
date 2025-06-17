using UnityEngine;

namespace SharedTechAssets.Scripts.TimeEngine
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TimeEngine : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TimeUpdateDispenser _dispenser;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool updatesEnabled;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(TimeUpdateDispenser dispenser)
        {
            this._dispenser = dispenser;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EnableUpdates()
        {
            this.updatesEnabled = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(this.updatesEnabled == false)
            {
                    return;
            }
            
            this._dispenser.SendTimeUpdateEvent();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            NativeARAdapter.add_SessionSetupCompletedEvent(value:  new NativeARAdapter.SessionSetupComplete(object:  this, method:  System.Void SharedTechAssets.Scripts.TimeEngine.TimeEngine::EnableUpdates()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TimeEngine()
        {
        
        }
    
    }

}
