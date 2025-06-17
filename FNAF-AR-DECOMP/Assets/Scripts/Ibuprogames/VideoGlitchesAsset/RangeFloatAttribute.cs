using UnityEngine;

namespace Ibuprogames.VideoGlitchesAsset
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class RangeFloatAttribute : PropertyAttribute
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float min;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float max;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float reset;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RangeFloatAttribute(float min, float max)
        {
            this.min = min;
            this.max = max;
            this.reset = min;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RangeFloatAttribute(float min, float max, float reset)
        {
            this.min = min;
            this.max = max;
            this.reset = reset;
        }
    
    }

}
