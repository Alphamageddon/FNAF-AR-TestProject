using UnityEngine;

namespace Ionic.Zlib
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static class InternalInflateConstants
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly int[] InflateMask;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static InternalInflateConstants()
        {
            Ionic.Zlib.InternalInflateConstants.InflateMask = new int[17] {0, 1, 3, 7, 15, 31, 63, 127, 255, 511, 1023, 2047, 4095, 8191, 16383, 32767, 65535};
        }
    
    }

}
