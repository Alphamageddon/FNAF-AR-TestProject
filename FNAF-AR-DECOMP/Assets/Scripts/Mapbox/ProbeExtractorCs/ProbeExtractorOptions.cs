using UnityEngine;

namespace Mapbox.ProbeExtractorCs
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ProbeExtractorOptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double MinTimeBetweenProbes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double MaxDistanceRatioJump;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double MaxDurationRatioJump;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double MaxAcceleration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double MaxDeceleration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MinProbes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool OutputBadProbes;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProbeExtractorOptions()
        {
            this.MaxDistanceRatioJump = ;
            this.MaxAcceleration = ;
            this.MinProbes = 2;
        }
    
    }

}
