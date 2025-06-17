using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxMeshBlockTracker_SROptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxMeshBlockTracker _tracker;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxMeshBlockTracker_SROptions(SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxMeshBlockTracker tracker)
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
