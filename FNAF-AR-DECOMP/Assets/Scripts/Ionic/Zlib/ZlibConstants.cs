using UnityEngine;

namespace Ionic.Zlib
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class ZlibConstants
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int WindowBitsMax = 15;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int WindowBitsDefault = 15;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int Z_OK = 0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int Z_STREAM_END = 1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int Z_NEED_DICT = 2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int Z_STREAM_ERROR = -2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int Z_DATA_ERROR = -3;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int Z_BUF_ERROR = -5;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int WorkingBufferSizeDefault = 16384;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int WorkingBufferSizeMin = 1024;
        
    
    }

}
