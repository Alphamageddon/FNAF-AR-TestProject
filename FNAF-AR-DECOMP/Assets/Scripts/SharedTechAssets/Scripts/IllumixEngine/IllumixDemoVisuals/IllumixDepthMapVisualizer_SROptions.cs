using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IllumixDepthMapVisualizer_SROptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixDepthMapVisualizer _viz;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IllumixDepthMapVisualizer_SROptions(SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixDepthMapVisualizer viz)
        {
            this._viz = viz;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ToggleVisibility()
        {
            this._viz.ToggleImageVisibility();
        }
    
    }

}
