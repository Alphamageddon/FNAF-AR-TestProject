using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxHSupportedPlaneTracker_SROptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxHSupportedPlaneTracker _tracker;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxHSupportedPlaneTracker_SROptions(SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxHSupportedPlaneTracker tracker)
        {
            this._tracker = tracker;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PrintStats()
        {
            if(this._tracker != null)
            {
                    return;
            }
        
        }
    
    }

}
