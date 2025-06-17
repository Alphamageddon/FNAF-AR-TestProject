using UnityEngine;

namespace Ionic.Zlib
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal sealed class InflateManager
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int PRESET_DICT = 32;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int Z_DEFLATED = 8;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Ionic.Zlib.InflateManager.InflateManagerMode mode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal Ionic.Zlib.ZlibCodec _codec;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int method;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal uint computedCheck;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal uint expectedCheck;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int marker;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _handleRfc1950HeaderBytes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int wbits;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal Ionic.Zlib.InflateBlocks blocks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly byte[] mark;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal bool HandleRfc1950HeaderBytes { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal bool get_HandleRfc1950HeaderBytes()
        {
            return (bool)this._handleRfc1950HeaderBytes;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void set_HandleRfc1950HeaderBytes(bool value)
        {
            this._handleRfc1950HeaderBytes = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InflateManager()
        {
            this._handleRfc1950HeaderBytes = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InflateManager(bool expectRfc1950HeaderBytes)
        {
            this._handleRfc1950HeaderBytes = true;
            this._handleRfc1950HeaderBytes = expectRfc1950HeaderBytes;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int Reset()
        {
            if(this._codec != null)
            {
                    this._codec.TotalBytesOut = 0;
            }
            else
            {
                    mem[56] = 0;
            }
            
            this._codec.TotalBytesIn = 0;
            this._codec.Message = 0;
            this.mode = (this._handleRfc1950HeaderBytes == true) ? 0 : 7;
            uint val_2 = this.blocks.Reset();
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int End()
        {
            if(this.blocks != null)
            {
                    this.blocks.Free();
            }
            
            this.blocks = 0;
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int Initialize(Ionic.Zlib.ZlibCodec codec, int w)
        {
            this._codec = codec;
            codec.Message = 0;
            this.blocks = 0;
            if((w & 4294967288) == 8)
            {
                    this.wbits = w;
                Ionic.Zlib.InflateBlocks val_5 = new Ionic.Zlib.InflateBlocks(codec:  codec, checkfn:  (this._handleRfc1950HeaderBytes == true) ? (this) : 0, w:  1 << (w & 31));
                this.blocks = val_5;
                int val_6 = this.Reset();
                return 0;
            }
            
            int val_7 = this.End();
            Ionic.Zlib.ZlibException val_8 = new Ionic.Zlib.ZlibException(s:  "Bad window size.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int Inflate(Ionic.Zlib.FlushType flush)
        {
            var val_27;
            int val_28;
            InflateManagerMode val_35;
            string val_84;
            var val_85;
            var val_86;
            if(this._codec.InputBuffer == null)
            {
                goto label_2;
            }
            
            val_27 = -5;
            val_28 = 28;
            val_35 = this.mode;
            if(val_35 > 13)
            {
                goto label_59;
            }
            
            var val_29 = 52949312 + (this.mode) << 2;
            val_29 = val_29 + 52949312;
            goto (52949312 + (this.mode) << 2 + 52949312);
            label_59:
            val_84 = "Stream error.";
            goto label_156;
            label_2:
            Ionic.Zlib.ZlibException val_26 = null;
            val_84 = "InputBuffer is null. ";
            label_156:
            val_26 = new Ionic.Zlib.ZlibException(s:  val_84);
            val_85 = 1152921525561862080;
            val_86 = val_26;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int SetDictionary(byte[] dictionary)
        {
            Ionic.Zlib.InflateBlocks val_6;
            int val_7;
            int val_8;
            int val_9;
            var val_10;
            if(this.mode != 6)
            {
                goto label_2;
            }
            
            val_6 = 1152921505284853760;
            val_7 = dictionary.Length;
            val_8 = val_7;
            if((Ionic.Zlib.Adler.Adler32(adler:  1, buf:  dictionary, index:  0, len:  null)) != this._codec._Adler32)
            {
                goto label_7;
            }
            
            this._codec._Adler32 = Ionic.Zlib.Adler.Adler32(adler:  0, buf:  0, index:  0, len:  0);
            int val_4 = this.wbits;
            val_4 = val_4 & 31;
            val_4 = 1 << val_4;
            if(val_4 <= val_7)
            {
                goto label_11;
            }
            
            val_9 = 0;
            goto label_12;
            label_7:
            val_10 = -3;
            return (int)val_10;
            label_11:
            val_7 = val_4 - 1;
            val_9 = dictionary.Length - val_7;
            label_12:
            val_6 = this.blocks;
            val_6.SetDictionary(d:  dictionary, start:  val_9, n:  val_7);
            val_10 = 0;
            this.mode = 7;
            return (int)val_10;
            label_2:
            Ionic.Zlib.ZlibException val_3 = new Ionic.Zlib.ZlibException(s:  "Stream error.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int Sync()
        {
            Ionic.Zlib.ZlibCodec val_7;
            int val_8;
            int val_9;
            int val_11;
            var val_12;
            var val_13;
            Ionic.Zlib.ZlibCodec val_14;
            Ionic.Zlib.ZlibCodec val_15;
            Ionic.Zlib.ZlibCodec val_16;
            if(this.mode != 13)
            {
                    this.mode = 13;
                this.marker = 0;
            }
            
            if(this._codec.AvailableBytesIn == 0)
            {
                goto label_3;
            }
            
            val_7 = this._codec;
            if(this._codec == null)
            {
                    val_7 = this._codec;
            }
            
            val_8 = this.marker;
            val_9 = this._codec.NextIn;
            var val_1 = (val_7 == 0) ? 1 : 0;
            if(val_8 <= 3)
            {
                goto label_5;
            }
            
            val_11 = this._codec.AvailableBytesIn;
            goto label_20;
            label_3:
            val_12 = -5;
            return (int)val_12;
            label_5:
            label_21:
            val_13 = null;
            val_13 = null;
            System.Byte[] val_2 = Ionic.Zlib.InflateManager.mark + (long)val_8;
            if(this._codec.InputBuffer[(long)val_9] == ((Ionic.Zlib.InflateManager.mark + (long)(int)(this.marker)) + 32))
            {
                    val_8 = val_8 + 1;
            }
            else
            {
                    val_8 = (this._codec.InputBuffer[(long)val_9] == 0) ? (4 - val_8) : 0;
            }
            
            val_7 = this._codec;
            val_9 = val_9 + 1;
            val_11 = this._codec.AvailableBytesIn - 1;
            if(val_8 <= 3)
            {
                    if(this._codec.AvailableBytesIn != 1)
            {
                goto label_21;
            }
            
            }
            
            label_20:
            val_14 = val_7;
            if(((val_7 == 0) ? 1 : 0) != 0)
            {
                    val_14 = this._codec;
            }
            
            int val_8 = this._codec.NextIn;
            val_8 = val_9 - val_8;
            val_8 = this._codec.TotalBytesIn + (val_8 << );
            this._codec.TotalBytesIn = val_8;
            this._codec.NextIn = val_9;
            val_15 = this._codec;
            this._codec.AvailableBytesIn = val_11;
            this.marker = val_8;
            if(val_8 != 4)
            {
                goto label_26;
            }
            
            val_16 = this._codec;
            if(this._codec != null)
            {
                goto label_27;
            }
            
            val_16 = this._codec;
            if(val_16 == null)
            {
                goto label_28;
            }
            
            label_27:
            int val_5 = this.Reset();
            this._codec.TotalBytesIn = this._codec.TotalBytesIn;
            val_15 = this._codec;
            val_12 = 0;
            this._codec.TotalBytesOut = this._codec.TotalBytesOut;
            this.mode = 7;
            return (int)val_12;
            label_26:
            val_12 = -3;
            return (int)val_12;
            label_28:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int SyncPoint(Ionic.Zlib.ZlibCodec z)
        {
            if(this.blocks != null)
            {
                    return this.blocks.SyncPoint();
            }
            
            return this.blocks.SyncPoint();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static InflateManager()
        {
            int val_2;
            byte[] val_1 = new byte[4];
            val_2 = val_1.Length;
            if(val_2 <= 2)
            {
                    val_2 = val_1.Length;
            }
            
            val_1[0] = 255;
            val_1[0] = 255;
            Ionic.Zlib.InflateManager.mark = val_1;
        }
    
    }

}
