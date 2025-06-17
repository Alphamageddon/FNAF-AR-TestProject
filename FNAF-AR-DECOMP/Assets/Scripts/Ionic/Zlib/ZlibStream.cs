using UnityEngine;

namespace Ionic.Zlib
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ZlibStream : Stream
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal Ionic.Zlib.ZlibBaseStream _baseStream;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _disposed;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual Ionic.Zlib.FlushType FlushMode { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int BufferSize { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual long TotalIn { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual long TotalOut { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool CanRead { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool CanSeek { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool CanWrite { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override long Length { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override long Position { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ZlibStream(System.IO.Stream stream, Ionic.Zlib.CompressionMode mode)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ZlibStream(System.IO.Stream stream, Ionic.Zlib.CompressionMode mode, Ionic.Zlib.CompressionLevel level)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ZlibStream(System.IO.Stream stream, Ionic.Zlib.CompressionMode mode, bool leaveOpen)
        {
            bool val_1 = leaveOpen;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ZlibStream(System.IO.Stream stream, Ionic.Zlib.CompressionMode mode, Ionic.Zlib.CompressionLevel level, bool leaveOpen)
        {
            this._baseStream = new Ionic.Zlib.ZlibBaseStream(stream:  stream, compressionMode:  mode, level:  level, flavor:  158, leaveOpen:  leaveOpen);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual Ionic.Zlib.FlushType get_FlushMode()
        {
            if(this._baseStream != null)
            {
                    return (Ionic.Zlib.FlushType)this._baseStream._flushMode;
            }
            
            return (Ionic.Zlib.FlushType)this._baseStream._flushMode;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void set_FlushMode(Ionic.Zlib.FlushType value)
        {
            if(this._disposed != true)
            {
                    this._baseStream._flushMode = value;
                return;
            }
            
            System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "ZlibStream");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_BufferSize()
        {
            if(this._baseStream != null)
            {
                    return (int)this._baseStream._bufferSize;
            }
            
            return (int)this._baseStream._bufferSize;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_BufferSize(int value)
        {
            var val_5;
            var val_6;
            var val_7;
            if(this._disposed == true)
            {
                goto label_1;
            }
            
            if(this._baseStream._workingBuffer != null)
            {
                goto label_3;
            }
            
            if(value <= 1023)
            {
                goto label_4;
            }
            
            this._baseStream._bufferSize = value;
            return;
            label_1:
            System.ObjectDisposedException val_1 = null;
            val_5 = val_1;
            val_1 = new System.ObjectDisposedException(objectName:  "ZlibStream");
            goto label_6;
            label_3:
            Ionic.Zlib.ZlibException val_2 = null;
            val_5 = val_2;
            val_2 = new Ionic.Zlib.ZlibException(s:  "The working buffer is already set.");
            label_6:
            val_6 = 1152921525588152448;
            val_7 = val_5;
            goto label_7;
            label_4:
            val_6 = 1152921525588152448;
            val_7 = new Ionic.Zlib.ZlibException(s:  System.String.Format(format:  "Don\'t be silly. {0} bytes?? Use a bigger buffer, at least {1}.", arg0:  value, arg1:  1024));
            label_7:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual long get_TotalIn()
        {
            if(this._baseStream._z != null)
            {
                    return (long)this._baseStream._z.TotalBytesIn;
            }
            
            return (long)this._baseStream._z.TotalBytesIn;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual long get_TotalOut()
        {
            if(this._baseStream._z != null)
            {
                    return (long)this._baseStream._z.TotalBytesOut;
            }
            
            return (long)this._baseStream._z.TotalBytesOut;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Dispose(bool disposing)
        {
            if(this._disposed != true)
            {
                    this._disposed = true;
            }
            
            this.Dispose(disposing:  disposing);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool get_CanRead()
        {
            if(this._disposed != true)
            {
                    if(this._baseStream._stream != null)
            {
                goto typeof(System.IO.Stream).__il2cppRuntimeField_198;
            }
            
            }
            else
            {
                    System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "ZlibStream");
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool get_CanSeek()
        {
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool get_CanWrite()
        {
            if(this._disposed != true)
            {
                    if(this._baseStream._stream != null)
            {
                goto typeof(System.IO.Stream).__il2cppRuntimeField_1C8;
            }
            
            }
            else
            {
                    System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "ZlibStream");
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Flush()
        {
            if(this._disposed != true)
            {
                    if(this._baseStream != null)
            {
                goto typeof(Ionic.Zlib.ZlibBaseStream).__il2cppRuntimeField_278;
            }
            
            }
            else
            {
                    System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "ZlibStream");
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override long get_Length()
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override long get_Position()
        {
            Ionic.Zlib.ZlibCodec val_1;
            Ionic.Zlib.ZlibBaseStream val_2;
            long val_3;
            var val_4;
            val_1 = this;
            val_2 = this._baseStream;
            if(val_2 == null)
            {
                goto label_0;
            }
            
            if(this._baseStream._streamMode == 0)
            {
                goto label_1;
            }
            
            label_7:
            if(this._baseStream._streamMode != 1)
            {
                goto label_2;
            }
            
            val_1 = this._baseStream._z;
            val_3 = this._baseStream._z.TotalBytesIn;
            goto label_5;
            label_0:
            if(this._baseStream == null)
            {
                goto label_6;
            }
            
            val_2 = this._baseStream;
            if(this._baseStream._streamMode != 0)
            {
                goto label_7;
            }
            
            label_1:
            val_1 = this._baseStream._z;
            val_3 = this._baseStream._z.TotalBytesOut;
            label_5:
            val_4 = mem[this._baseStream._z.TotalBytesOut];
            val_4 = val_3;
            return (long)val_4;
            label_2:
            val_4 = 0;
            return (long)val_4;
            label_6:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void set_Position(long value)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int Read(byte[] buffer, int offset, int count)
        {
            if(this._disposed != true)
            {
                    if(this._baseStream != null)
            {
                goto typeof(Ionic.Zlib.ZlibBaseStream).__il2cppRuntimeField_318;
            }
            
            }
            else
            {
                    System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "ZlibStream");
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override long Seek(long offset, System.IO.SeekOrigin origin)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetLength(long value)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Write(byte[] buffer, int offset, int count)
        {
            if(this._disposed != true)
            {
                    if(this._baseStream != null)
            {
                goto typeof(Ionic.Zlib.ZlibBaseStream).__il2cppRuntimeField_338;
            }
            
            }
            else
            {
                    System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "ZlibStream");
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static byte[] CompressString(string s)
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            new Ionic.Zlib.ZlibStream() = new Ionic.Zlib.ZlibStream(stream:  val_1, mode:  0, level:  9, leaveOpen:  false);
            Ionic.Zlib.ZlibBaseStream.CompressString(s:  s, compressor:  new Ionic.Zlib.ZlibStream());
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_1.Dispose();
            if(0 == 0)
            {
                    return (System.Byte[])val_1;
            }
            
            if(42 == 42)
            {
                    return (System.Byte[])val_1;
            }
            
            return (System.Byte[])val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static byte[] CompressBuffer(byte[] b)
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            new Ionic.Zlib.ZlibStream() = new Ionic.Zlib.ZlibStream(stream:  val_1, mode:  0, level:  9, leaveOpen:  false);
            Ionic.Zlib.ZlibBaseStream.CompressBuffer(b:  b, compressor:  new Ionic.Zlib.ZlibStream());
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_1.Dispose();
            if(0 == 0)
            {
                    return (System.Byte[])val_1;
            }
            
            if(42 == 42)
            {
                    return (System.Byte[])val_1;
            }
            
            return (System.Byte[])val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string UncompressString(byte[] compressed)
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream(buffer:  compressed);
            new Ionic.Zlib.ZlibStream() = new Ionic.Zlib.ZlibStream(stream:  val_1, mode:  1, level:  6, leaveOpen:  false);
            if(val_1 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                val_1.Dispose();
            }
            
            if(35 == 35)
            {
                    return (string)Ionic.Zlib.ZlibBaseStream.UncompressString(compressed:  new Ionic.Zlib.ZlibStream(), decompressor:  new Ionic.Zlib.ZlibStream());
            }
            
            if(0 == 0)
            {
                    return (string)Ionic.Zlib.ZlibBaseStream.UncompressString(compressed:  new Ionic.Zlib.ZlibStream(), decompressor:  new Ionic.Zlib.ZlibStream());
            }
            
            return (string)Ionic.Zlib.ZlibBaseStream.UncompressString(compressed:  new Ionic.Zlib.ZlibStream(), decompressor:  new Ionic.Zlib.ZlibStream());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static byte[] UncompressBuffer(byte[] compressed)
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream(buffer:  compressed);
            new Ionic.Zlib.ZlibStream() = new Ionic.Zlib.ZlibStream(stream:  val_1, mode:  1, level:  6, leaveOpen:  false);
            if(val_1 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                val_1.Dispose();
            }
            
            if(35 == 35)
            {
                    return (System.Byte[])Ionic.Zlib.ZlibBaseStream.UncompressBuffer(compressed:  new Ionic.Zlib.ZlibStream(), decompressor:  new Ionic.Zlib.ZlibStream());
            }
            
            if(0 == 0)
            {
                    return (System.Byte[])Ionic.Zlib.ZlibBaseStream.UncompressBuffer(compressed:  new Ionic.Zlib.ZlibStream(), decompressor:  new Ionic.Zlib.ZlibStream());
            }
            
            return (System.Byte[])Ionic.Zlib.ZlibBaseStream.UncompressBuffer(compressed:  new Ionic.Zlib.ZlibStream(), decompressor:  new Ionic.Zlib.ZlibStream());
        }
    
    }

}
