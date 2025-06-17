using UnityEngine;

namespace SRF
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class SRFFloatExtensions
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float Sqr(float f)
        {
            f = f * f;
            return (float)f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float SqrRt(float f)
        {
            if(f <= _TYPE_MAX_)
            {
                    return (float)f;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ApproxZero(float f)
        {
            return UnityEngine.Mathf.Approximately(a:  0f, b:  f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool Approx(float f, float f2)
        {
            return UnityEngine.Mathf.Approximately(a:  f, b:  f2);
        }
    
    }

}
