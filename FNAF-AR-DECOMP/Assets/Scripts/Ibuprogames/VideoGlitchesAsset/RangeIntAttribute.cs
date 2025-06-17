using UnityEngine;

namespace Ibuprogames.VideoGlitchesAsset
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class RangeIntAttribute : PropertyAttribute
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int min;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int max;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int reset;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RangeIntAttribute(int min, int max)
        {
            this.min = min;
            this.max = max;
            this.reset = min;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RangeIntAttribute(int min, int max, int reset)
        {
            this.min = min;
            this.max = max;
            this.reset = reset;
        }
    
    }

}
