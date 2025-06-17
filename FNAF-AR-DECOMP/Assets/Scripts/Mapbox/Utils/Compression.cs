using UnityEngine;

namespace Mapbox.Utils
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class Compression
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static byte[] Decompress(byte[] buffer)
        {
            System.Byte[] val_9;
            var val_10;
            System.IO.MemoryStream val_11;
            var val_12;
            var val_13;
            val_9 = buffer;
            if(((buffer.Length < 2) || (val_9[0] != 31)) || (val_9[0] != 139))
            {
                goto label_40;
            }
            
            Mapbox.IO.Compression.GZipStream val_2 = new Mapbox.IO.Compression.GZipStream(stream:  new System.IO.MemoryStream(buffer:  val_9), mode:  0);
            byte[] val_3 = new byte[4096];
            new System.IO.MemoryStream() = new System.IO.MemoryStream();
            label_9:
            if(val_2 < 1)
            {
                goto label_7;
            }
            
            if(new System.IO.MemoryStream() != null)
            {
                goto label_9;
            }
            
            goto label_9;
            label_7:
            val_10 = 0;
            val_11 = 0;
            val_12 = 0;
            val_13 = 127;
            val_9 = new System.IO.MemoryStream();
            var val_11 = 0;
            val_11 = val_11 + 1;
            new System.IO.MemoryStream().Dispose();
            var val_6 = ( == 129) ? 1 : 0;
            if( != 0)
            {
                    val_6 = val_6 ^ (( != 127) ? 1 : 0);
                if(val_6 != 0)
            {
                    val_11 = 0;
                val_12 = 0;
            }
            
            }
            
            if(val_2 == null)
            {
                
            }
            else
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_2.Dispose();
            }
            
            if( != 127)
            {
                    if( == 129)
            {
                    return (System.Byte[])val_10;
            }
            
            }
            
            label_40:
            val_10 = val_9;
            return (System.Byte[])val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static byte[] Compress(byte[] raw, Mapbox.IO.Compression.CompressionLevel compressionLevel)
        {
            var val_5;
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            new Mapbox.IO.Compression.GZipStream() = new Mapbox.IO.Compression.GZipStream(stream:  val_1, compressionLevel:  compressionLevel);
            val_5 = 0;
            var val_5 = 0;
            val_5 = val_5 + 1;
            new Mapbox.IO.Compression.GZipStream().Dispose();
            if(37 != 37)
            {
                goto label_7;
            }
            
            if(val_1 != null)
            {
                goto label_16;
            }
            
            goto label_9;
            label_7:
            if(null != null)
            {
                    val_5 = 0;
            }
            
            if(val_1 != null)
            {
                goto label_16;
            }
            
            label_9:
            label_16:
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_1.Dispose();
            if(val_5 == 0)
            {
                    return (System.Byte[])val_1;
            }
            
            if(56 == 0)
            {
                    return (System.Byte[])val_1;
            }
            
            if(56 == 56)
            {
                    return (System.Byte[])val_1;
            }
            
            return (System.Byte[])val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static byte[] CompressModeCompress(byte[] raw)
        {
            var val_5;
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            new Mapbox.IO.Compression.GZipStream() = new Mapbox.IO.Compression.GZipStream(stream:  val_1, mode:  1, leaveOpen:  true);
            val_5 = 0;
            var val_5 = 0;
            val_5 = val_5 + 1;
            new Mapbox.IO.Compression.GZipStream().Dispose();
            if(38 != 38)
            {
                goto label_7;
            }
            
            if(val_1 != null)
            {
                goto label_16;
            }
            
            goto label_9;
            label_7:
            if(null != null)
            {
                    val_5 = 0;
            }
            
            if(val_1 != null)
            {
                goto label_16;
            }
            
            label_9:
            label_16:
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_1.Dispose();
            if(val_5 == 0)
            {
                    return (System.Byte[])val_1;
            }
            
            if(57 == 0)
            {
                    return (System.Byte[])val_1;
            }
            
            if(57 == 57)
            {
                    return (System.Byte[])val_1;
            }
            
            return (System.Byte[])val_1;
        }
    
    }

}
