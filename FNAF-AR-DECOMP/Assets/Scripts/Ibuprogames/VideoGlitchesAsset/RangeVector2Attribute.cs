using UnityEngine;

namespace Ibuprogames.VideoGlitchesAsset
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class RangeVector2Attribute : PropertyAttribute
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly UnityEngine.Vector2 min;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly UnityEngine.Vector2 max;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly UnityEngine.Vector2 reset;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RangeVector2Attribute(float minMag, float maxMag)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RangeVector2Attribute(float minMag, float maxMag, float resetMag)
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  minMag, y:  minMag);
            this.min = val_1.x;
            mem[1152921520021066308] = val_1.y;
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  maxMag, y:  maxMag);
            this.max = val_2.x;
            mem[1152921520021066316] = val_2.y;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  resetMag, y:  resetMag);
            this.reset = val_3.x;
            mem[1152921520021066324] = val_3.y;
        }
    
    }

}
