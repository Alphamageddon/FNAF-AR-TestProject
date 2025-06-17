using UnityEngine;

namespace Ionic.Zlib
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static class InternalConstants
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly int MAX_BITS;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly int BL_CODES;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly int D_CODES;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly int LITERALS;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly int LENGTH_CODES;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly int L_CODES;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly int MAX_BL_BITS;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly int REP_3_6;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly int REPZ_3_10;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly int REPZ_11_138;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static InternalConstants()
        {
            Ionic.Zlib.InternalConstants.MAX_BITS = 15;
            Ionic.Zlib.InternalConstants.BL_CODES = 19;
            Ionic.Zlib.InternalConstants.D_CODES = 30;
            Ionic.Zlib.InternalConstants.LITERALS = 256;
            Ionic.Zlib.InternalConstants.LENGTH_CODES = 29;
            Ionic.Zlib.InternalConstants.L_CODES = 286;
            Ionic.Zlib.InternalConstants.MAX_BL_BITS = 7;
            Ionic.Zlib.InternalConstants.REP_3_6 = 16;
            Ionic.Zlib.InternalConstants.REPZ_3_10 = 17;
            Ionic.Zlib.InternalConstants.REPZ_11_138 = 18;
        }
    
    }

}
