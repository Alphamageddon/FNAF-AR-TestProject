using UnityEngine;

namespace Ionic.Zlib
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class WorkItem
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public byte[] buffer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public byte[] compressed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int crc;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int index;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ordinal;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int inputBytesAvailable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int compressedBytesAvailable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Ionic.Zlib.ZlibCodec compressor;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WorkItem(int size, Ionic.Zlib.CompressionLevel compressLevel, Ionic.Zlib.CompressionStrategy strategy, int ix)
        {
            var val_7 = 32767;
            this.buffer = new byte[0];
            val_7 = size + val_7;
            var val_2 = (size < 0) ? (val_7) : size;
            val_2 = val_2 >> 15;
            val_2 = size + (val_2 * 10);
            var val_3 = val_2 + 10;
            this.compressed = new byte[0];
            Ionic.Zlib.ZlibCodec val_5 = null;
            .CompressLevel = 15;
            val_5 = new Ionic.Zlib.ZlibCodec();
            this.compressor = val_5;
            .CompressLevel = compressLevel;
            int val_6 = val_5._InternalInitializeDeflate(wantRfc1950Header:  false);
            this.compressor.OutputBuffer = this.compressed;
            this.compressor.InputBuffer = this.buffer;
            this.index = ix;
        }
    
    }

}
