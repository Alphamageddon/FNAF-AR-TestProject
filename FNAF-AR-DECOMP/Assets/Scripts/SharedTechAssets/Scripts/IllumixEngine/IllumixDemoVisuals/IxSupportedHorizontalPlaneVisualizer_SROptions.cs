using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxSupportedHorizontalPlaneVisualizer_SROptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedHorizontalPlaneVisualizer _viz;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool TogglePlane { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool TogglePoints { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxSupportedHorizontalPlaneVisualizer_SROptions(SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedHorizontalPlaneVisualizer viz)
        {
            this._viz = viz;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_TogglePlane()
        {
            if(this._viz != null)
            {
                    return (bool)this._viz.showPlane;
            }
            
            return (bool)this._viz.showPlane;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_TogglePlane(bool value)
        {
            this._viz.showPlane = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_TogglePoints()
        {
            if(this._viz != null)
            {
                    return (bool)this._viz.showPoints;
            }
            
            return (bool)this._viz.showPoints;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_TogglePoints(bool value)
        {
            this._viz.showPoints = value;
        }
    
    }

}
