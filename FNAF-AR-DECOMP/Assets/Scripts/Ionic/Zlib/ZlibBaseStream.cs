using UnityEngine;

namespace Ionic.Zlib
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class ZlibBaseStream : Stream
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal Ionic.Zlib.ZlibCodec _z;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal Ionic.Zlib.ZlibBaseStream.StreamMode _streamMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal Ionic.Zlib.FlushType _flushMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal Ionic.Zlib.ZlibStreamFlavor _flavor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal Ionic.Zlib.CompressionMode _compressionMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal Ionic.Zlib.CompressionLevel _level;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal bool _leaveOpen;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal byte[] _workingBuffer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal int _bufferSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal byte[] _buf1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal System.IO.Stream _stream;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal Ionic.Zlib.CompressionStrategy Strategy;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Ionic.Crc.CRC32 crc;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal string _GzipFileName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal string _GzipComment;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal System.DateTime _GzipMtime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal int _gzipHeaderByteCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool nomoreinput;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int Crc32 { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal bool _wantCompress { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Ionic.Zlib.ZlibCodec z { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private byte[] workingBuffer { get; }
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
        internal int get_Crc32()
        {
            if(this.crc == null)
            {
                    return (int)this.crc;
            }
            
            return this.crc.Crc32Result;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ZlibBaseStream(System.IO.Stream stream, Ionic.Zlib.CompressionMode compressionMode, Ionic.Zlib.CompressionLevel level, Ionic.Zlib.ZlibStreamFlavor flavor, bool leaveOpen)
        {
            this._streamMode = 2;
            this._bufferSize = 16384;
            this._buf1 = new byte[1];
            this._stream = stream;
            this._flushMode = 0;
            this._flavor = flavor;
            this._leaveOpen = leaveOpen;
            this._compressionMode = compressionMode;
            this._level = level;
            if(flavor != 1952)
            {
                    return;
            }
            
            this.crc = new Ionic.Crc.CRC32();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal bool get__wantCompress()
        {
            return (bool)(this._compressionMode == 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Ionic.Zlib.ZlibCodec get_z()
        {
            if(this._z != null)
            {
                    return (Ionic.Zlib.ZlibCodec)this._z;
            }
            
            Ionic.Zlib.ZlibCodec val_1 = null;
            .CompressLevel = 15;
            val_1 = new Ionic.Zlib.ZlibCodec();
            this._z = val_1;
            if(this._compressionMode == 1)
            {
                    int val_3 = val_1.InitializeInflate(windowBits:  (Ionic.Zlib.ZlibCodec)[1152921525578013008].WindowBits, expectRfc1950Header:  (this._flavor == 1950) ? 1 : 0);
                return (Ionic.Zlib.ZlibCodec)this._z;
            }
            
            .Strategy = this.Strategy;
            this._z.CompressLevel = this._level;
            int val_5 = this._z._InternalInitializeDeflate(wantRfc1950Header:  (this._flavor == 1950) ? 1 : 0);
            return (Ionic.Zlib.ZlibCodec)this._z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private byte[] get_workingBuffer()
        {
            if(this._workingBuffer != null)
            {
                    return (System.Byte[])val_1;
            }
            
            byte[] val_1 = new byte[0];
            this._workingBuffer = val_1;
            return (System.Byte[])val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Write(byte[] buffer, int offset, int count)
        {
            int val_12;
            var val_13;
            var val_14;
            val_12 = offset;
            if(this.crc != null)
            {
                    this.crc.SlurpBlock(block:  buffer, offset:  val_12, count:  count);
            }
            
            if(this._streamMode == 0)
            {
                goto label_2;
            }
            
            if(this._streamMode != 2)
            {
                goto label_3;
            }
            
            this._streamMode = 0;
            label_2:
            if(count == 0)
            {
                    return;
            }
            
            Ionic.Zlib.ZlibCodec val_1 = this.z;
            val_1.InputBuffer = buffer;
            this._z.NextIn = val_12;
            this._z.AvailableBytesIn = count;
            label_31:
            this._z.OutputBuffer = this.workingBuffer;
            this._z.NextOut = 0;
            if(this._workingBuffer == null)
            {
                goto label_10;
            }
            
            label_16:
            this._z.AvailableBytesOut = this._workingBuffer.Length;
            if(this._z == null)
            {
                goto label_12;
            }
            
            if(this._compressionMode == 0)
            {
                goto label_13;
            }
            
            label_17:
            val_13 = this._z;
            int val_3 = val_13.Inflate(flush:  buffer);
            goto label_14;
            label_10:
            if(this._z != null)
            {
                goto label_16;
            }
            
            goto label_16;
            label_12:
            if(this._compressionMode != 0)
            {
                goto label_17;
            }
            
            label_13:
            val_13 = this._z;
            label_14:
            if((val_13.Deflate(flush:  this._flushMode)) >= 2)
            {
                goto label_18;
            }
            
            val_12 = this._stream;
            int val_5 = this._workingBuffer.Length - this._z.AvailableBytesOut;
            if(this._z.AvailableBytesIn != 0)
            {
                    val_14 = 0;
            }
            else
            {
                    var val_6 = (this._z.AvailableBytesOut != 0) ? 1 : 0;
            }
            
            if((this._flavor == 1952) && (this._compressionMode != 0))
            {
                    if(this._z.AvailableBytesIn != 8)
            {
                goto label_31;
            }
            
            }
            
            if(((this._z.AvailableBytesOut != 0) ? 1 : 0) == 0)
            {
                goto label_31;
            }
            
            return;
            label_18:
            Ionic.Zlib.ZlibException val_10 = new Ionic.Zlib.ZlibException(s:  (this._compressionMode == 0) ? "de" : "in"((this._compressionMode == 0) ? "de" : "in") + "flating: "("flating: ") + this._z.Message);
            label_32:
            label_3:
            Ionic.Zlib.ZlibException val_11 = new Ionic.Zlib.ZlibException(s:  "Cannot Write after Reading.");
            goto label_32;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void finish()
        {
            int val_32;
            Ionic.Zlib.ZlibCodec val_33;
            Ionic.Zlib.ZlibCodec val_34;
            var val_35;
            Ionic.Zlib.ZlibCodec val_36;
            var val_37;
            var val_38;
            int val_39;
            System.Array val_40;
            var val_41;
            string val_44;
            val_32 = this;
            val_33 = this._z;
            if(val_33 == null)
            {
                    return;
            }
            
            if(this._streamMode == 1)
            {
                goto label_2;
            }
            
            if(this._streamMode == 0)
            {
                goto label_3;
            }
            
            return;
            label_31:
            val_34 = this._z;
            label_3:
            this._z.OutputBuffer = this.workingBuffer;
            this._z.NextOut = 0;
            if(this._workingBuffer == null)
            {
                goto label_7;
            }
            
            label_13:
            this._z.AvailableBytesOut = this._workingBuffer.Length;
            if(this._z == null)
            {
                goto label_9;
            }
            
            if(this._compressionMode == 0)
            {
                goto label_10;
            }
            
            label_14:
            val_35 = this._z;
            int val_2 = val_35.Inflate(flush:  null);
            goto label_11;
            label_7:
            if(this._z != null)
            {
                goto label_13;
            }
            
            goto label_13;
            label_9:
            if(this._compressionMode != 0)
            {
                goto label_14;
            }
            
            label_10:
            val_35 = this._z;
            int val_3 = val_35.Deflate(flush:  4);
            label_11:
            if(val_3 >= 2)
            {
                goto label_15;
            }
            
            val_36 = this._z;
            int val_31 = this._z.AvailableBytesOut;
            val_31 = this._workingBuffer.Length - val_31;
            if(val_31 >= 1)
            {
                    val_36 = this._stream;
                int val_4 = this._workingBuffer.Length - this._z.AvailableBytesOut;
            }
            
            if(this._z.AvailableBytesIn != 0)
            {
                    val_37 = 0;
            }
            else
            {
                    var val_5 = (this._z.AvailableBytesOut != 0) ? 1 : 0;
            }
            
            if((this._flavor == 1952) && (this._compressionMode != 0))
            {
                    if(this._z.AvailableBytesIn != 8)
            {
                goto label_31;
            }
            
            }
            
            if(((this._z.AvailableBytesOut != 0) ? 1 : 0) == 0)
            {
                goto label_31;
            }
            
            if(this._flavor != 1952)
            {
                    return;
            }
            
            if(this._compressionMode != 0)
            {
                goto label_33;
            }
            
            System.Byte[] val_8 = System.BitConverter.GetBytes(value:  this.crc.Crc32Result);
            System.Byte[] val_10 = System.BitConverter.GetBytes(value:  this.crc.TotalBytesRead);
            val_32 = ???;
            val_36 = ???;
            val_38 = ???;
            goto typeof(System.IO.Stream).__il2cppRuntimeField_338;
            label_2:
            if((val_32 + 56) != 1952)
            {
                    return;
            }
            
            if((val_32 + 60) == 0)
            {
                goto label_41;
            }
            
            if((val_36 + 56) == 0)
            {
                    return;
            }
            
            byte[] val_11 = new byte[8];
            if((val_32 + 40) == 0)
            {
                goto label_43;
            }
            
            val_39 = mem[val_32 + 40 + 24];
            val_39 = val_32 + 40 + 24;
            val_40 = mem[val_32 + 40 + 16];
            val_40 = val_32 + 40 + 16;
            if((val_32 + 40 + 24 + 4) <= 7)
            {
                goto label_44;
            }
            
            label_50:
            System.Array.Copy(sourceArray:  val_40, sourceIndex:  val_39, destinationArray:  val_11, destinationIndex:  0, length:  val_11.Length);
            goto label_46;
            label_43:
            if((val_32 + 40) != 0)
            {
                    val_40 = mem[val_32 + 40 + 16];
                val_40 = val_32 + 40 + 16;
                val_39 = mem[val_32 + 40 + 24];
                val_39 = val_32 + 40 + 24;
            }
            else
            {
                    val_40 = mem[val_32 + 40 + 16];
                val_40 = val_32 + 40 + 16;
                val_39 = mem[val_32 + 40 + 24];
                val_39 = val_32 + 40 + 24;
            }
            
            if((val_32 + 40 + 28) > 7)
            {
                goto label_50;
            }
            
            label_44:
            System.Array.Copy(sourceArray:  val_40, sourceIndex:  val_39, destinationArray:  val_11, destinationIndex:  0, length:  val_32 + 40 + 28);
            val_41 = val_32 + 40;
            if((val_32 + 40) != 0)
            {
                goto label_52;
            }
            
            val_41 = mem[val_32 + 40];
            val_41 = val_32 + 40;
            if(val_41 == 0)
            {
                goto label_53;
            }
            
            label_52:
            val_38 = mem[val_32 + 40 + 28];
            val_38 = val_32 + 40 + 28;
            if((8 - (val_32 + 40 + 28)) != (val_32 + 96))
            {
                goto label_55;
            }
            
            label_46:
            val_36 = System.BitConverter.ToInt32(value:  val_11, startIndex:  0);
            val_32 = System.BitConverter.ToInt32(value:  val_11, startIndex:  4);
            if(((val_32 + 112.Crc32Result) != val_36) || (val_32 != (val_32 + 40 + 56)))
            {
                goto label_68;
            }
            
            return;
            label_15:
            string val_25 = (this._compressionMode == 0) ? "de" : "in"((this._compressionMode == 0) ? "de" : "in") + "flating";
            if(this._z.Message == null)
            {
                    label_68:
                string val_26 = System.String.Format(format:  "{0}: (rc = {1})", arg0:  val_25, arg1:  val_3);
            }
            
            label_69:
            Ionic.Zlib.ZlibException val_28 = new Ionic.Zlib.ZlibException(s:  val_25 + ": "(": ") + this._z.Message);
            label_66:
            label_33:
            val_44 = "Writing with decompression is not supported.";
            goto label_65;
            label_41:
            val_44 = "Reading with compression is not supported.";
            label_65:
            null = new Ionic.Zlib.ZlibException(s:  val_44);
            goto label_66;
            label_55:
            object val_32 = val_32 + 40 + 28;
            val_32 = val_32 + (val_32 + 96);
            string val_30 = System.String.Format(format:  "Missing or incomplete GZIP trailer. Expected 8 bytes, got {0}.", arg0:  val_32);
            goto label_69;
            label_53:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void end()
        {
            if(this.z == null)
            {
                    return;
            }
            
            if(this._z == null)
            {
                goto label_1;
            }
            
            if(this._compressionMode == 0)
            {
                goto label_2;
            }
            
            label_4:
            int val_2 = this._z.EndInflate();
            goto label_3;
            label_1:
            if(this._compressionMode != 0)
            {
                goto label_4;
            }
            
            label_2:
            int val_3 = this._z.EndDeflate();
            label_3:
            this._z = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Close()
        {
            var val_7;
            System.IO.Stream val_8;
            val_7 = this;
            if(this._stream == null)
            {
                    return;
            }
            
            this.finish();
            this.end();
            if(this._leaveOpen != true)
            {
                    val_8 = this._stream;
            }
            
            this._stream = 0;
            if(51 == 51)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_7 = ???;
            val_8 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Flush()
        {
            if(this._stream == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override long Seek(long offset, System.IO.SeekOrigin origin)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetLength(long value)
        {
            if(this._stream == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string ReadZeroTerminatedString()
        {
            var val_4;
            System.Text.Encoding val_5;
            System.Collections.Generic.List<System.Byte> val_1 = new System.Collections.Generic.List<System.Byte>();
            goto label_1;
            label_9:
            val_1.Add(item:  this._buf1[0]);
            label_1:
            if(this._stream != 1)
            {
                goto label_6;
            }
            
            if(this._buf1[0] != 0)
            {
                goto label_9;
            }
            
            val_4 = null;
            val_4 = null;
            val_5 = Ionic.Zlib.GZipStream.iso8859dash1;
            if(val_1.ToArray() == null)
            {
                goto label_13;
            }
            
            label_16:
            val_5 = ???;
            goto typeof(System.Text.Encoding).__il2cppRuntimeField_368;
            label_13:
            if(val_5 != 0)
            {
                goto label_16;
            }
            
            goto label_16;
            label_6:
            Ionic.Zlib.ZlibException val_3 = new Ionic.Zlib.ZlibException(s:  "Unexpected EOF reading GZIP header.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _ReadAndValidateGzipHeader()
        {
            var val_9;
            var val_10;
            var val_11;
            int val_12;
            string val_14;
            byte[] val_1 = new byte[10];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            label_19:
            val_9 = 0;
            if(this._stream == null)
            {
                    return (int)val_9;
            }
            
            if(this._stream != 10)
            {
                goto label_4;
            }
            
            if(((val_1[0] != 31) || (val_1[0] != 139)) || (val_1[0] != 8))
            {
                goto label_10;
            }
            
            val_10 = 1152921505283842048;
            val_11 = null;
            val_11 = null;
            System.DateTime val_3 = Ionic.Zlib.GZipStream._unixEpoch.AddSeconds(value:  (double)System.BitConverter.ToInt32(value:  val_1, startIndex:  4));
            this._GzipMtime = val_3;
            if((val_1[0] & 4) != 0)
            {
                goto label_16;
            }
            
            val_9 = 10;
            goto label_17;
            label_1:
            if(this._stream != null)
            {
                goto label_19;
            }
            
            goto label_19;
            label_16:
            val_12 = val_1.Length;
            if(val_12 == 0)
            {
                    val_12 = val_1.Length;
            }
            
            byte val_14 = val_1[0];
            val_10 = new byte[0];
            if(val_10 == null)
            {
                goto label_23;
            }
            
            label_33:
            if(this._stream != ((int)val_1[0] & 65535))
            {
                goto label_25;
            }
            
            val_9 = (this._stream + 10) + ((int)val_1[0] & 65535);
            label_17:
            if((val_1[0] & 8) != 0)
            {
                    this._GzipFileName = this.ReadZeroTerminatedString();
            }
            
            if((val_1[0] & 16) != 0)
            {
                    this._GzipComment = this.ReadZeroTerminatedString();
            }
            
            if((val_1[0] & 2) == 0)
            {
                    return (int)val_9;
            }
            
            return (int)val_9;
            label_23:
            if(this._stream != null)
            {
                goto label_33;
            }
            
            goto label_33;
            label_10:
            val_14 = "Bad GZIP header.";
            goto label_35;
            label_4:
            val_14 = "Not a valid GZIP stream.";
            goto label_35;
            label_25:
            val_14 = "Unexpected end-of-file reading GZIP header.";
            label_35:
            null = new Ionic.Zlib.ZlibException(s:  val_14);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int Read(byte[] buffer, int offset, int count)
        {
            Ionic.Zlib.ZlibCodec val_18;
            StreamMode val_19;
            Ionic.Zlib.FlushType val_20;
            var val_21;
            int val_22;
            var val_23;
            string val_24;
            object val_25;
            System.ArgumentOutOfRangeException val_26;
            string val_28;
            string val_30;
            val_19 = this._streamMode;
            if(val_19 != 2)
            {
                goto label_1;
            }
            
            if((this._stream & 1) == 0)
            {
                goto label_3;
            }
            
            this._streamMode = 1;
            val_18 = this.z;
            val_1.AvailableBytesIn = 0;
            if(this._flavor != 1952)
            {
                goto label_5;
            }
            
            int val_2 = this._ReadAndValidateGzipHeader();
            this._gzipHeaderByteCount = val_2;
            if(val_2 == 0)
            {
                goto label_10;
            }
            
            label_5:
            val_19 = this._streamMode;
            label_1:
            if(val_19 != 1)
            {
                goto label_7;
            }
            
            if(count == 0)
            {
                goto label_10;
            }
            
            if(this.nomoreinput != false)
            {
                    if(this._compressionMode == 0)
            {
                goto label_10;
            }
            
            }
            
            if(buffer == null)
            {
                goto label_11;
            }
            
            if((count & 2147483648) != 0)
            {
                goto label_14;
            }
            
            if((buffer.GetLowerBound(dimension:  0)) > offset)
            {
                goto label_13;
            }
            
            val_20 = 0;
            int val_5 = count + offset;
            if(val_5 > (buffer.GetLength(dimension:  0)))
            {
                goto label_14;
            }
            
            this._z.OutputBuffer = buffer;
            this._z.NextOut = offset;
            this._z.AvailableBytesOut = count;
            System.Byte[] val_6 = this.workingBuffer;
            this._z.InputBuffer = val_6;
            goto label_29;
            label_47:
            if(val_6 != 1)
            {
                    if(val_6 != null)
            {
                goto label_21;
            }
            
            }
            
            if(val_6 != 1)
            {
                    if(val_5 == 0)
            {
                goto label_23;
            }
            
            }
            
            if(this._z.AvailableBytesOut == count)
            {
                goto label_30;
            }
            
            label_23:
            if((this._z.AvailableBytesOut < 1) || (val_6 != null))
            {
                goto label_30;
            }
            
            if(this.nomoreinput == false)
            {
                goto label_29;
            }
            
            goto label_30;
            label_37:
            if(this._z != null)
            {
                goto label_32;
            }
            
            goto label_32;
            label_29:
            if((this._z.AvailableBytesIn != 0) || (this.nomoreinput == true))
            {
                goto label_41;
            }
            
            this._z.NextIn = 0;
            if(this._workingBuffer == null)
            {
                goto label_37;
            }
            
            label_32:
            val_20 = this._workingBuffer;
            this._z.AvailableBytesIn = this._stream;
            if(this._z.AvailableBytesIn == 0)
            {
                    this.nomoreinput = true;
            }
            
            label_41:
            if(this._z == null)
            {
                goto label_42;
            }
            
            if(this._compressionMode == 0)
            {
                goto label_43;
            }
            
            label_45:
            val_21 = this._z;
            int val_7 = val_21.Inflate(flush:  val_20);
            goto label_44;
            label_42:
            if(this._compressionMode != 0)
            {
                goto label_45;
            }
            
            label_43:
            val_21 = this._z;
            label_44:
            val_18 = val_21.Deflate(flush:  this._flushMode);
            if((val_18 != 5) || (this.nomoreinput == false))
            {
                goto label_47;
            }
            
            label_10:
            val_22 = 0;
            return val_22;
            label_30:
            if((this._z.AvailableBytesOut < 1) || ((this.nomoreinput == false) || (this._compressionMode != 0)))
            {
                goto label_54;
            }
            
            val_23 = this._z;
            if((val_23.Deflate(flush:  4)) >= 2)
            {
                goto label_56;
            }
            
            label_54:
            val_18 = this._z;
            val_22 = count - this._z.AvailableBytesOut;
            if(this.crc == null)
            {
                    return val_22;
            }
            
            this.crc.SlurpBlock(block:  buffer, offset:  offset, count:  val_22);
            return val_22;
            label_21:
            label_64:
            val_24 = System.String.Format(format:  "{0}flating:  rc={1}  msg={2}", arg0:  (this._compressionMode == 0) ? "de" : "in", arg1:  val_6, arg2:  this._z.Message);
            val_25 = 1152921525581371280;
            val_26 = new Ionic.Zlib.ZlibException(s:  val_24);
            goto label_59;
            label_7:
            val_28 = "Cannot Read after Writing.";
            goto label_60;
            label_14:
            val_30 = "count";
            goto label_61;
            label_3:
            Ionic.Zlib.ZlibException val_13 = null;
            val_28 = "The stream is not readable.";
            label_60:
            val_24 = val_13;
            val_13 = new Ionic.Zlib.ZlibException(s:  val_28);
            goto label_63;
            label_11:
            System.ArgumentNullException val_14 = null;
            val_24 = val_14;
            val_14 = new System.ArgumentNullException(paramName:  "buffer");
            goto label_63;
            label_13:
            System.ArgumentOutOfRangeException val_15 = null;
            val_30 = "offset";
            label_61:
            val_24 = val_15;
            val_15 = new System.ArgumentOutOfRangeException(paramName:  val_30);
            label_63:
            val_25 = 1152921525581371280;
            val_26 = val_24;
            label_59:
            label_56:
            string val_16 = System.String.Format(format:  "Deflating:  rc={0}  msg={1}", arg0:  val_26, arg1:  val_25);
            goto label_64;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool get_CanRead()
        {
            if(this._stream == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool get_CanSeek()
        {
            if(this._stream == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool get_CanWrite()
        {
            if(this._stream == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override long get_Length()
        {
            if(this._stream == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override long get_Position()
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void set_Position(long value)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void CompressString(string s, System.IO.Stream compressor)
        {
            System.IO.Stream val_8 = compressor;
            System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_8.Dispose();
            if(0 == 0)
            {
                    return;
            }
            
            if(37 == 37)
            {
                    return;
            }
            
            val_8 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void CompressBuffer(byte[] b, System.IO.Stream compressor)
        {
            System.IO.Stream val_7 = compressor;
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_7.Dispose();
            if(0 == 0)
            {
                    return;
            }
            
            if(25 == 25)
            {
                    return;
            }
            
            val_7 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string UncompressString(byte[] compressed, System.IO.Stream decompressor)
        {
            var val_7;
            var val_8;
            var val_10;
            var val_11;
            System.IO.MemoryStream val_3 = new System.IO.MemoryStream();
            label_5:
            if(decompressor == null)
            {
                goto label_3;
            }
            
            if(val_3 != null)
            {
                goto label_5;
            }
            
            goto label_5;
            label_3:
            val_7 = 0;
            val_8 = 65;
            if(decompressor == null)
            {
                
            }
            else
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                decompressor.Dispose();
            }
            
            if( != 65)
            {
                goto label_15;
            }
            
            if(val_3 != null)
            {
                goto label_19;
            }
            
            goto label_17;
            label_15:
            if(null != null)
            {
                    val_7 = 0;
            }
            
            if(val_3 != null)
            {
                goto label_19;
            }
            
            label_17:
            label_19:
            new System.IO.StreamReader() = new System.IO.StreamReader(stream:  val_3, encoding:  System.Text.Encoding.UTF8);
            val_10 = new System.IO.StreamReader();
            val_11 = 101;
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_3.Dispose();
            if(null == null)
            {
                    return (string);
            }
            
            if( == 0)
            {
                    return (string);
            }
            
            if( == 101)
            {
                    return (string);
            }
            
            return (string);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static byte[] UncompressBuffer(byte[] compressed, System.IO.Stream decompressor)
        {
            var val_5;
            var val_6;
            var val_8;
            var val_9;
            System.IO.MemoryStream val_2 = new System.IO.MemoryStream();
            label_5:
            if(decompressor == null)
            {
                goto label_3;
            }
            
            if(val_2 != null)
            {
                goto label_5;
            }
            
            goto label_5;
            label_3:
            val_5 = 0;
            val_6 = 57;
            if(decompressor == null)
            {
                
            }
            else
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                decompressor.Dispose();
            }
            
            if( != 57)
            {
                goto label_15;
            }
            
            if(val_2 != null)
            {
                goto label_19;
            }
            
            goto label_17;
            label_15:
            if(null != null)
            {
                    val_5 = 0;
            }
            
            if(val_2 != null)
            {
                goto label_19;
            }
            
            label_17:
            label_19:
            val_8 = val_2;
            val_9 = 77;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_2.Dispose();
            if(null == null)
            {
                    return (System.Byte[]);
            }
            
            if( == 0)
            {
                    return (System.Byte[]);
            }
            
            if( == 77)
            {
                    return (System.Byte[]);
            }
            
            return (System.Byte[]);
        }
    
    }

}
