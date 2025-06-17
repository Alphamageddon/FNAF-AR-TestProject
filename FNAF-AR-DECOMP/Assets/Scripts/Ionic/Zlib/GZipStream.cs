using UnityEngine;

namespace Ionic.Zlib
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GZipStream : Stream
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> LastModified;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _headerByteCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal Ionic.Zlib.ZlibBaseStream _baseStream;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _disposed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _firstReadDone;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _FileName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _Comment;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _Crc32;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly System.DateTime _unixEpoch;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly System.Text.Encoding iso8859dash1;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Comment { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FileName { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Crc32 { get; }
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
        public string get_Comment()
        {
            return (string)this._Comment;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Comment(string value)
        {
            if(this._disposed != true)
            {
                    this._Comment = value;
                return;
            }
            
            System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "GZipStream");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_FileName()
        {
            return (string)this._FileName;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_FileName(string value)
        {
            string val_8;
            var val_9;
            if(this._disposed == true)
            {
                goto label_1;
            }
            
            this._FileName = value;
            if(value == null)
            {
                    return;
            }
            
            val_8 = this._FileName;
            if((value.IndexOf(value:  "/")) != 1)
            {
                    val_8 = val_8.Replace(oldValue:  "/", newValue:  "\\");
                this._FileName = val_8;
            }
            
            if((val_8.EndsWith(value:  "\\")) == true)
            {
                goto label_6;
            }
            
            if((this._FileName.IndexOf(value:  "\\")) == 1)
            {
                    return;
            }
            
            this._FileName = System.IO.Path.GetFileName(path:  this._FileName);
            return;
            label_1:
            System.ObjectDisposedException val_6 = null;
            val_9 = val_6;
            val_6 = new System.ObjectDisposedException(objectName:  "GZipStream");
            goto label_11;
            label_6:
            System.Exception val_7 = null;
            val_9 = val_7;
            val_7 = new System.Exception(message:  "Illegal filename");
            label_11:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Crc32()
        {
            return (int)this._Crc32;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GZipStream(System.IO.Stream stream, Ionic.Zlib.CompressionMode mode)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GZipStream(System.IO.Stream stream, Ionic.Zlib.CompressionMode mode, Ionic.Zlib.CompressionLevel level)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GZipStream(System.IO.Stream stream, Ionic.Zlib.CompressionMode mode, bool leaveOpen)
        {
            bool val_1 = leaveOpen;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GZipStream(System.IO.Stream stream, Ionic.Zlib.CompressionMode mode, Ionic.Zlib.CompressionLevel level, bool leaveOpen)
        {
            this._baseStream = new Ionic.Zlib.ZlibBaseStream(stream:  stream, compressionMode:  mode, level:  level, flavor:  160, leaveOpen:  leaveOpen);
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
            
            System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "GZipStream");
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
            val_1 = new System.ObjectDisposedException(objectName:  "GZipStream");
            goto label_6;
            label_3:
            Ionic.Zlib.ZlibException val_2 = null;
            val_5 = val_2;
            val_2 = new Ionic.Zlib.ZlibException(s:  "The working buffer is already set.");
            label_6:
            val_6 = 1152921525551264992;
            val_7 = val_5;
            goto label_7;
            label_4:
            val_6 = 1152921525551264992;
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
                    if((disposing != false) && (this._baseStream != null))
            {
                    this._Crc32 = this._baseStream.Crc32;
            }
            
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
                    System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "GZipStream");
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
                    System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "GZipStream");
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
                    System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "GZipStream");
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override long get_Length()
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override long get_Position()
        {
            Ionic.Zlib.ZlibBaseStream val_2;
            Ionic.Zlib.ZlibBaseStream val_3;
            long val_4;
            int val_5;
            var val_6;
            val_2 = this;
            val_3 = this._baseStream;
            if(val_3 == null)
            {
                goto label_0;
            }
            
            if(this._baseStream._streamMode == 0)
            {
                goto label_1;
            }
            
            label_8:
            if(this._baseStream._streamMode != 1)
            {
                goto label_2;
            }
            
            val_2 = this._baseStream;
            val_4 = this._baseStream._z.TotalBytesIn;
            val_5 = this._baseStream._gzipHeaderByteCount;
            goto label_6;
            label_0:
            if(this._baseStream == null)
            {
                goto label_7;
            }
            
            val_3 = this._baseStream;
            if(this._baseStream._streamMode != 0)
            {
                goto label_8;
            }
            
            label_1:
            val_4 = this._baseStream._z.TotalBytesOut;
            val_5 = this._headerByteCount;
            label_6:
            val_6 = val_4 + val_5;
            return (long)val_6;
            label_2:
            val_6 = 0;
            return (long)val_6;
            label_7:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void set_Position(long value)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int Read(byte[] buffer, int offset, int count)
        {
            if(this._disposed != true)
            {
                    if(this._firstReadDone == true)
            {
                    return (int)this._baseStream;
            }
            
                this._firstReadDone = true;
                this.FileName = this._baseStream._GzipFileName;
                offset = this._baseStream;
                this.Comment = this._baseStream._GzipComment;
                return (int)this._baseStream;
            }
            
            System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "GZipStream");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override long Seek(long offset, System.IO.SeekOrigin origin)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetLength(long value)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Write(byte[] buffer, int offset, int count)
        {
            var val_5;
            if(this._disposed == true)
            {
                goto label_1;
            }
            
            if(this._baseStream._streamMode != 2)
            {
                goto label_3;
            }
            
            if(this._baseStream._wantCompress == false)
            {
                goto label_5;
            }
            
            this._headerByteCount = this.EmitHeader();
            label_3:
            if(this._baseStream != null)
            {
                goto typeof(Ionic.Zlib.ZlibBaseStream).__il2cppRuntimeField_338;
            }
            
            goto typeof(Ionic.Zlib.ZlibBaseStream).__il2cppRuntimeField_338;
            label_1:
            System.ObjectDisposedException val_3 = null;
            val_5 = val_3;
            val_3 = new System.ObjectDisposedException(objectName:  "GZipStream");
            goto label_7;
            label_5:
            System.InvalidOperationException val_4 = null;
            val_5 = val_4;
            val_4 = new System.InvalidOperationException();
            label_7:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int EmitHeader()
        {
            System.Array val_9;
            string val_10;
            var val_11;
            string val_12;
            System.Array val_13;
            string val_14;
            System.Array val_15;
            var val_16;
            var val_17;
            int val_18;
            ulong val_19;
            var val_20;
            int val_21;
            var val_22;
            val_9 = 24276;
            val_10 = this._Comment;
            if(val_10 != null)
            {
                    val_11 = null;
                val_11 = null;
                val_12 = this._Comment;
                val_9 = Ionic.Zlib.GZipStream.iso8859dash1;
                val_13 = val_9;
            }
            
            val_14 = this._FileName;
            if(val_14 != null)
            {
                    if((((Ionic.Zlib.GZipStream.iso8859dash1 + 295) & 2) != 0) && ((Ionic.Zlib.GZipStream.iso8859dash1 + 216) == 0))
            {
                    val_9 = null;
                val_14 = this._FileName;
            }
            
                val_15 = Ionic.Zlib.GZipStream.iso8859dash1;
            }
            else
            {
                    val_15 = 0;
            }
            
            if(this._Comment != null)
            {
                    if(val_13 != null)
            {
                goto label_12;
            }
            
            }
            else
            {
                    val_16 = 0;
            }
            
            label_12:
            if(this._FileName != null)
            {
                    val_17 = 15026800 + 1;
            }
            else
            {
                    val_17 = 0;
            }
            
            var val_2 = (val_16 + val_17) + 10;
            byte[] val_3 = new byte[0];
            val_18 = val_3.Length;
            if(val_18 == 0)
            {
                    val_18 = val_3.Length;
            }
            
            val_3[0] = 31;
            if(val_18 <= 1)
            {
                    val_18 = val_3.Length;
            }
            
            val_3[0] = 139;
            if(val_18 <= 2)
            {
                    val_18 = val_3.Length;
            }
            
            val_3[0] = 8;
            var val_4 = (this._Comment == null) ? 0 : 16;
            val_3[0] = (this._FileName == null) ? (val_4) : (val_4 | 8);
            if((this.LastModified & 1) == 0)
            {
                    System.DateTime val_7 = System.DateTime.Now;
                this.LastModified = 0;
                mem[1152921525553622432] = 0;
            }
            
            val_19 = this.LastModified;
            val_20 = null;
            val_20 = null;
            System.TimeSpan val_8 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_19}, d2:  new System.DateTime() {dateData = Ionic.Zlib.GZipStream._unixEpoch});
            System.Array.Copy(sourceArray:  System.BitConverter.GetBytes(value:  (int)val_8._ticks.TotalSeconds), sourceIndex:  0, destinationArray:  val_3, destinationIndex:  4, length:  4);
            val_21 = val_3.Length;
            if(val_21 <= 8)
            {
                    val_21 = val_3.Length;
            }
            
            val_3[1] = 0;
            val_3[1] = 255;
            if(val_17 == 0)
            {
                goto label_32;
            }
            
            System.Array.Copy(sourceArray:  val_15, sourceIndex:  0, destinationArray:  val_3, destinationIndex:  10, length:  val_17 - 1);
            val_22 = val_17 + 10;
            val_19 = (long)val_17 + 9;
            val_3[val_19] = 0;
            if(val_16 != 0)
            {
                goto label_34;
            }
            
            goto label_36;
            label_32:
            val_22 = 10;
            if(val_16 == 0)
            {
                goto label_36;
            }
            
            label_34:
            val_19 = val_16 - 1;
            System.Array.Copy(sourceArray:  val_13, sourceIndex:  0, destinationArray:  val_3, destinationIndex:  10, length:  val_19);
            val_3[(long)10 + val_19] = 0;
            label_36:
            if(this._baseStream._stream != null)
            {
                    return (int)val_3.Length;
            }
            
            return (int)val_3.Length;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static byte[] CompressString(string s)
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            new Ionic.Zlib.GZipStream() = new Ionic.Zlib.GZipStream(stream:  val_1, mode:  0, level:  9, leaveOpen:  false);
            Ionic.Zlib.ZlibBaseStream.CompressString(s:  s, compressor:  new Ionic.Zlib.GZipStream());
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
            new Ionic.Zlib.GZipStream() = new Ionic.Zlib.GZipStream(stream:  val_1, mode:  0, level:  9, leaveOpen:  false);
            Ionic.Zlib.ZlibBaseStream.CompressBuffer(b:  b, compressor:  new Ionic.Zlib.GZipStream());
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
            new Ionic.Zlib.GZipStream() = new Ionic.Zlib.GZipStream(stream:  val_1, mode:  1, level:  6, leaveOpen:  false);
            if(val_1 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                val_1.Dispose();
            }
            
            if(35 == 35)
            {
                    return (string)Ionic.Zlib.ZlibBaseStream.UncompressString(compressed:  compressed, decompressor:  new Ionic.Zlib.GZipStream());
            }
            
            if(0 == 0)
            {
                    return (string)Ionic.Zlib.ZlibBaseStream.UncompressString(compressed:  compressed, decompressor:  new Ionic.Zlib.GZipStream());
            }
            
            return (string)Ionic.Zlib.ZlibBaseStream.UncompressString(compressed:  compressed, decompressor:  new Ionic.Zlib.GZipStream());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static byte[] UncompressBuffer(byte[] compressed)
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream(buffer:  compressed);
            new Ionic.Zlib.GZipStream() = new Ionic.Zlib.GZipStream(stream:  val_1, mode:  1, level:  6, leaveOpen:  false);
            if(val_1 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                val_1.Dispose();
            }
            
            if(35 == 35)
            {
                    return (System.Byte[])Ionic.Zlib.ZlibBaseStream.UncompressBuffer(compressed:  compressed, decompressor:  new Ionic.Zlib.GZipStream());
            }
            
            if(0 == 0)
            {
                    return (System.Byte[])Ionic.Zlib.ZlibBaseStream.UncompressBuffer(compressed:  compressed, decompressor:  new Ionic.Zlib.GZipStream());
            }
            
            return (System.Byte[])Ionic.Zlib.ZlibBaseStream.UncompressBuffer(compressed:  compressed, decompressor:  new Ionic.Zlib.GZipStream());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GZipStream()
        {
            Ionic.Zlib.GZipStream._unixEpoch = 0;
            Ionic.Zlib.GZipStream.iso8859dash1 = System.Text.Encoding.GetEncoding(name:  "iso-8859-1");
        }
    
    }

}
