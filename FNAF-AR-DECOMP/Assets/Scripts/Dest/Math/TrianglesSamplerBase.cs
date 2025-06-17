using UnityEngine;

namespace Dest.Math
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TrianglesSamplerBase : WeightedSampler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.Vector3[] _vertices;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected TrianglesSamplerBase(Dest.Math.Rand rand)
        {
            val_1 = new System.Object();
            mem[1152921519516560192] = rand;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected float CalclTriangleArea(ref UnityEngine.Vector3 e0, ref UnityEngine.Vector3 e1)
        {
            float val_9;
            float val_11 = e0.x;
            float val_12 = e0.y;
            float val_10 = e1.z;
            float val_9 = e0.z;
            val_9 = val_9 * e1.x;
            val_10 = val_10 * val_11;
            val_11 = e1.y * val_11;
            val_12 = val_12 * e1.x;
            float val_6 = ((val_12 * val_10) - (val_9 * e1.y)) * ((val_12 * val_10) - (val_9 * e1.y));
            val_6 = val_6 + ((val_9 - val_10) * (val_9 - val_10));
            float val_8 = (val_11 - val_12) * (val_11 - val_12);
            val_8 = val_8 + val_6;
            if(val_6 >= _TYPE_MAX_)
            {
                    val_9 = val_8;
            }
            
            val_9 = val_9 * 0.5f;
            return (float)val_9;
        }
    
    }

}
