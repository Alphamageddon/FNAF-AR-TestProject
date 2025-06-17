using UnityEngine;

namespace Ionic.Zlib
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class ZlibCodec
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public byte[] InputBuffer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NextIn;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int AvailableBytesIn;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long TotalBytesIn;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public byte[] OutputBuffer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NextOut;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int AvailableBytesOut;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long TotalBytesOut;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Message;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal Ionic.Zlib.DeflateManager dstate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal Ionic.Zlib.InflateManager istate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal uint _Adler32;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Ionic.Zlib.CompressionLevel CompressLevel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int WindowBits;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Ionic.Zlib.CompressionStrategy Strategy;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Adler32 { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Adler32()
        {
            return (int)this._Adler32;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ZlibCodec()
        {
            this.CompressLevel = 15;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ZlibCodec(Ionic.Zlib.CompressionMode mode)
        {
            string val_5;
            this.CompressLevel = 15;
            if(mode == 1)
            {
                goto label_1;
            }
            
            if(mode != 0)
            {
                goto label_2;
            }
            
            if((this._InternalInitializeDeflate(wantRfc1950Header:  true)) != 0)
            {
                goto label_3;
            }
            
            return;
            label_1:
            int val_2 = this.InitializeInflate(windowBits:  this.WindowBits, expectRfc1950Header:  true);
            return;
            label_2:
            val_5 = "Invalid ZlibStreamFlavor.";
            goto label_4;
            label_3:
            val_5 = "Cannot initialize for deflate.";
            label_4:
            null = new Ionic.Zlib.ZlibException(s:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int InitializeInflate()
        {
            int val_1 = this.InitializeInflate(windowBits:  this.WindowBits, expectRfc1950Header:  true);
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int InitializeInflate(bool expectRfc1950Header)
        {
            int val_2 = this.InitializeInflate(windowBits:  this.WindowBits, expectRfc1950Header:  expectRfc1950Header);
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int InitializeInflate(int windowBits)
        {
            this.WindowBits = windowBits;
            int val_1 = this.InitializeInflate(windowBits:  windowBits, expectRfc1950Header:  true);
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int InitializeInflate(int windowBits, bool expectRfc1950Header)
        {
            this.WindowBits = windowBits;
            if(this.dstate == null)
            {
                    Ionic.Zlib.InflateManager val_1 = null;
                ._handleRfc1950HeaderBytes = true;
                val_1 = new Ionic.Zlib.InflateManager();
                ._handleRfc1950HeaderBytes = expectRfc1950Header;
                this.istate = val_1;
                int val_3 = val_1.Initialize(codec:  this, w:  windowBits);
                return 0;
            }
            
            Ionic.Zlib.ZlibException val_4 = new Ionic.Zlib.ZlibException(s:  "You may not call InitializeInflate() after calling InitializeDeflate().");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Inflate(Ionic.Zlib.FlushType flush)
        {
            if(this.istate != null)
            {
                    return this.istate.Inflate(flush:  flush);
            }
            
            Ionic.Zlib.ZlibException val_1 = new Ionic.Zlib.ZlibException(s:  "No Inflate State!");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int EndInflate()
        {
            if(this.istate != null)
            {
                    if(this.istate.blocks != null)
            {
                    this.istate.blocks.Free();
            }
            
                this.istate.blocks = 0;
                this.istate = 0;
                return 0;
            }
            
            Ionic.Zlib.ZlibException val_1 = new Ionic.Zlib.ZlibException(s:  "No Inflate State!");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int SyncInflate()
        {
            if(this.istate != null)
            {
                    return this.istate.Sync();
            }
            
            Ionic.Zlib.ZlibException val_1 = new Ionic.Zlib.ZlibException(s:  "No Inflate State!");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int InitializeDeflate()
        {
            return this._InternalInitializeDeflate(wantRfc1950Header:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int InitializeDeflate(Ionic.Zlib.CompressionLevel level)
        {
            this.CompressLevel = level;
            return this._InternalInitializeDeflate(wantRfc1950Header:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int InitializeDeflate(Ionic.Zlib.CompressionLevel level, bool wantRfc1950Header)
        {
            this.CompressLevel = level;
            return this._InternalInitializeDeflate(wantRfc1950Header:  wantRfc1950Header);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int InitializeDeflate(Ionic.Zlib.CompressionLevel level, int bits)
        {
            this.CompressLevel = level;
            this.WindowBits = bits;
            return this._InternalInitializeDeflate(wantRfc1950Header:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int InitializeDeflate(Ionic.Zlib.CompressionLevel level, int bits, bool wantRfc1950Header)
        {
            this.CompressLevel = level;
            this.WindowBits = bits;
            return this._InternalInitializeDeflate(wantRfc1950Header:  wantRfc1950Header);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _InternalInitializeDeflate(bool wantRfc1950Header)
        {
            if(this.istate == null)
            {
                    Ionic.Zlib.DeflateManager val_1 = new Ionic.Zlib.DeflateManager();
                this.dstate = val_1;
                val_1.WantRfc1950HeaderBytes = wantRfc1950Header;
                if(this.dstate != null)
            {
                    return this.dstate.Initialize(codec:  this, level:  this.CompressLevel, bits:  this.WindowBits, compressionStrategy:  this.Strategy);
            }
            
                return this.dstate.Initialize(codec:  this, level:  this.CompressLevel, bits:  this.WindowBits, compressionStrategy:  this.Strategy);
            }
            
            Ionic.Zlib.ZlibException val_3 = new Ionic.Zlib.ZlibException(s:  "You may not call InitializeDeflate() after calling InitializeInflate().");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Deflate(Ionic.Zlib.FlushType flush)
        {
            if(this.dstate != null)
            {
                    return this.dstate.Deflate(flush:  flush);
            }
            
            Ionic.Zlib.ZlibException val_1 = new Ionic.Zlib.ZlibException(s:  "No Deflate State!");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int EndDeflate()
        {
            if(this.dstate != null)
            {
                    this.dstate = 0;
                return 0;
            }
            
            Ionic.Zlib.ZlibException val_1 = new Ionic.Zlib.ZlibException(s:  "No Deflate State!");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ResetDeflate()
        {
            if(this.dstate != null)
            {
                    this.dstate.Reset();
                return;
            }
            
            Ionic.Zlib.ZlibException val_1 = new Ionic.Zlib.ZlibException(s:  "No Deflate State!");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int SetDeflateParams(Ionic.Zlib.CompressionLevel level, Ionic.Zlib.CompressionStrategy strategy)
        {
            if(this.dstate != null)
            {
                    return this.dstate.SetParams(level:  level, strategy:  strategy);
            }
            
            Ionic.Zlib.ZlibException val_1 = new Ionic.Zlib.ZlibException(s:  "No Deflate State!");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int SetDictionary(byte[] dictionary)
        {
            if(this.istate != null)
            {
                    return this.istate.SetDictionary(dictionary:  dictionary);
            }
            
            if(this.dstate != null)
            {
                    return this.dstate.SetDictionary(dictionary:  dictionary);
            }
            
            Ionic.Zlib.ZlibException val_1 = new Ionic.Zlib.ZlibException(s:  "No Inflate or Deflate state!");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void flush_pending()
        {
            Ionic.Zlib.DeflateManager val_6;
            Ionic.Zlib.DeflateManager val_7;
            Ionic.Zlib.DeflateManager val_8;
            int val_9;
            Ionic.Zlib.DeflateManager val_10;
            int val_11;
            val_6 = this;
            int val_1 = (this.dstate.pendingCount > this.AvailableBytesOut) ? this.AvailableBytesOut : this.dstate.pendingCount;
            if(val_1 == 0)
            {
                    return;
            }
            
            if((this.dstate.nextPending >= this.dstate.pending.Length) || (this.NextOut >= this.OutputBuffer.Length))
            {
                goto label_14;
            }
            
            int val_6 = this.dstate.nextPending;
            val_6 = val_6 + val_1;
            if(val_6 > this.dstate.pending.Length)
            {
                goto label_14;
            }
            
            int val_7 = this.NextOut;
            val_7 = val_7 + val_1;
            if(val_7 > this.OutputBuffer.Length)
            {
                goto label_14;
            }
            
            val_7 = this.dstate;
            if(this.dstate != null)
            {
                goto label_15;
            }
            
            val_7 = this.dstate;
            if(val_7 == null)
            {
                goto label_16;
            }
            
            label_15:
            System.Array.Copy(sourceArray:  this.dstate.pending, sourceIndex:  this.dstate.nextPending, destinationArray:  this.OutputBuffer, destinationIndex:  this.NextOut, length:  val_1);
            int val_8 = this.NextOut;
            val_8 = this.dstate;
            val_8 = val_8 + val_1;
            this.NextOut = val_8;
            if(val_8 != null)
            {
                    val_9 = this.dstate.nextPending;
            }
            else
            {
                    val_8 = 48;
                val_9 = 0;
            }
            
            mem[48] = val_9 + val_1;
            long val_9 = this.TotalBytesOut;
            int val_10 = this.AvailableBytesOut;
            val_10 = this.dstate;
            val_9 = val_9 + (val_1 << );
            val_10 = val_10 - val_1;
            this.TotalBytesOut = val_9;
            this.AvailableBytesOut = val_10;
            if(val_10 != null)
            {
                    val_11 = this.dstate.pendingCount;
            }
            else
            {
                    val_10 = 52;
                val_11 = 3670080;
            }
            
            mem[52] = val_11 - val_1;
            if(this.dstate.pendingCount != 0)
            {
                    return;
            }
            
            val_6 = this.dstate;
            this.dstate.nextPending = 0;
            return;
            label_14:
            Ionic.Zlib.ZlibException val_5 = new Ionic.Zlib.ZlibException(s:  System.String.Format(format:  "Invalid State. (pending.Length={0}, pendingCount={1})", arg0:  this.dstate.pending.Length, arg1:  this.dstate.pendingCount));
            label_16:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int read_buf(byte[] buf, int start, int size)
        {
            Ionic.Zlib.DeflateManager val_4;
            int val_4 = this.AvailableBytesIn;
            int val_1 = (val_4 > size) ? size : (val_4);
            if(val_1 == 0)
            {
                    return val_1;
            }
            
            val_4 = this.dstate;
            val_4 = val_4 - val_1;
            this.AvailableBytesIn = val_4;
            if(val_4.WantRfc1950HeaderBytes != false)
            {
                    val_4 = this.InputBuffer;
                this._Adler32 = Ionic.Zlib.Adler.Adler32(adler:  this._Adler32, buf:  val_4, index:  this.NextIn, len:  val_1);
            }
            
            System.Array.Copy(sourceArray:  this.InputBuffer, sourceIndex:  this.NextIn, destinationArray:  buf, destinationIndex:  start, length:  val_1);
            int val_5 = this.NextIn;
            long val_6 = this.TotalBytesIn;
            val_5 = val_5 + val_1;
            val_6 = val_6 + (val_1 << );
            this.NextIn = val_5;
            this.TotalBytesIn = val_6;
            return val_1;
        }
    
    }

}
