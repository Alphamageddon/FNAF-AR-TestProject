using UnityEngine;

namespace Ibuprogames.VideoGlitchesAsset
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class RangeVector3Attribute : PropertyAttribute
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly UnityEngine.Vector3 min;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly UnityEngine.Vector3 max;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly UnityEngine.Vector3 reset;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RangeVector3Attribute(float minMag, float maxMag)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RangeVector3Attribute(float minMag, float maxMag, float resetMag)
        {
            this.min = 0;
            mem[1152921520021290312] = 0;
            this.max = 0;
            mem[1152921520021290324] = 0;
            this.reset = 0;
            mem[1152921520021290336] = 0;
        }
    
    }

}
