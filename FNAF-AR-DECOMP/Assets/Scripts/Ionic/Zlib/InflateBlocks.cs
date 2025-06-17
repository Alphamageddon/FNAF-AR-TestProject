using UnityEngine;

namespace Ionic.Zlib
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal sealed class InflateBlocks
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int MANY = 1440;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly int[] border;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Ionic.Zlib.InflateBlocks.InflateBlockMode mode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int left;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int table;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int index;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int[] blens;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int[] bb;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int[] tb;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal Ionic.Zlib.InflateCodes codes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int last;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal Ionic.Zlib.ZlibCodec _codec;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int bitk;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int bitb;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int[] hufts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal byte[] window;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int end;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int readAt;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int writeAt;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal object checkfn;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal uint check;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal Ionic.Zlib.InfTree inftree;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal InflateBlocks(Ionic.Zlib.ZlibCodec codec, object checkfn, int w)
        {
            this.bb = new int[1];
            this.tb = new int[1];
            this.codes = new Ionic.Zlib.InflateCodes();
            this.inftree = new Ionic.Zlib.InfTree();
            val_5 = new System.Object();
            this._codec = codec;
            this.hufts = new int[4320];
            this.window = new byte[0];
            this.end = w;
            this.checkfn = val_5;
            this.mode = 0;
            uint val_8 = this.Reset();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal uint Reset()
        {
            this.mode = 0;
            this.bitk = 0;
            this.bitb = 0;
            this.readAt = 0;
            this.writeAt = 0;
            if(this.checkfn == null)
            {
                    return (uint)this.check;
            }
            
            this.check = 1;
            this._codec._Adler32 = 1;
            return (uint)this.check;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int Process(int r)
        {
            var val_75;
            Ionic.Zlib.ZlibCodec val_76;
            int val_77;
            int val_78;
            int val_79;
            int val_80;
            int val_81;
            Ionic.Zlib.ZlibCodec val_82;
            int val_83;
            Ionic.Zlib.InflateCodes val_85;
            var val_86;
            Ionic.Zlib.InflateCodes val_87;
            InflateBlockMode val_88;
            int val_89;
            int val_90;
            int val_91;
            var val_92;
            var val_93;
            int val_94;
            var val_95;
            int val_96;
            int val_97;
            int val_98;
            int val_99;
            var val_100;
            var val_101;
            var val_102;
            int val_103;
            var val_104;
            var val_105;
            var val_106;
            int val_107;
            int val_108;
            var val_109;
            System.Int32[] val_110;
            System.Int32[] val_111;
            var val_112;
            var val_113;
            var val_114;
            int val_115;
            int val_116;
            var val_117;
            int val_118;
            int val_119;
            int val_120;
            int val_121;
            var val_122;
            int val_123;
            int val_124;
            int val_125;
            System.Int32[] val_126;
            System.Int32[] val_127;
            Ionic.Zlib.ZlibCodec val_128;
            System.Int32[] val_129;
            Ionic.Zlib.ZlibCodec val_130;
            Ionic.Zlib.ZlibCodec val_131;
            Ionic.Zlib.ZlibCodec val_132;
            Ionic.Zlib.ZlibCodec val_133;
            Ionic.Zlib.ZlibCodec val_134;
            Ionic.Zlib.ZlibCodec val_135;
            Ionic.Zlib.ZlibCodec val_136;
            Ionic.Zlib.ZlibCodec val_137;
            Ionic.Zlib.ZlibCodec val_138;
            string val_139;
            Ionic.Zlib.ZlibCodec val_140;
            Ionic.Zlib.ZlibCodec val_141;
            val_75 = r;
            val_76 = this._codec;
            if(this._codec != null)
            {
                goto label_1;
            }
            
            val_76 = this._codec;
            if(val_76 == null)
            {
                goto label_218;
            }
            
            label_1:
            val_77 = this._codec.AvailableBytesIn;
            int val_68 = this.readAt;
            val_78 = this.writeAt;
            val_79 = this._codec.NextIn;
            val_80 = this.bitk;
            val_81 = this.bitb;
            if(val_68 <= val_78)
            {
                goto label_3;
            }
            
            val_68 = val_68 + (~val_78);
            goto label_72;
            label_3:
            int val_69 = this.end;
            val_69 = val_69 - val_78;
            goto label_72;
            label_171:
            val_82 = this._codec;
            if(this._codec != null)
            {
                goto label_6;
            }
            
            val_82 = this._codec;
            if(val_82 == null)
            {
                goto label_218;
            }
            
            label_6:
            val_77 = this._codec.AvailableBytesIn;
            val_78 = this.writeAt;
            val_79 = this._codec.NextIn;
            val_80 = this.bitk;
            val_81 = this.bitb;
            if(this.readAt > val_78)
            {
                    val_83 = this.readAt + (~val_78);
            }
            else
            {
                    val_83 = this.end - val_78;
            }
            
            if(this.last != 0)
            {
                goto label_10;
            }
            
            val_75 = 0;
            this.mode = 0;
            label_72:
            label_41:
            if(this.mode > 9)
            {
                goto label_17;
            }
            
            var val_71 = 52950596 + (this.mode) << 2;
            val_71 = val_71 + 52950596;
            goto (52950596 + (this.mode) << 2 + 52950596);
            label_24:
            if( == 0)
            {
                goto label_20;
            }
            
            val_77 =  - 1;
            val_79 =  + 1;
            byte val_72 = this._codec.InputBuffer[(long)];
            int val_6 = val_80 & 31;
            val_85 = val_80 + 8;
            val_72 = val_72 << val_6;
            val_81 = val_72 | val_81;
            if(val_80 <= 6)
            {
                goto label_24;
            }
            
            val_6 = val_81 & 1;
            this.last = val_6;
            if(((uint)(val_81 >> 1) & 3) == 1)
            {
                goto label_25;
            }
            
            if(((uint)(val_81 >> 1) & 3) == 2)
            {
                goto label_26;
            }
            
            if(((uint)(val_81 >> 1) & 3) == 3)
            {
                goto label_27;
            }
            
            int val_7 = val_85 - 3;
            int val_9 = val_7 & 7;
            val_81 = (val_81 >> 3) >> val_9;
            int val_10 = val_7 - val_9;
            val_88 = 1;
            goto label_40;
            label_25:
            int[] val_11 = new int[1];
            int[] val_12 = new int[1];
            System.Int32[][] val_13 = new System.Int32[][1];
            System.Int32[][] val_14 = new System.Int32[][1];
            int val_15 = Ionic.Zlib.InfTree.inflate_trees_fixed(bl:  val_11, bd:  val_12, tl:  val_13, td:  val_14, z:  null);
            this.codes.Init(bl:  val_11[0], bd:  val_12[0], tl:  val_13[0], tl_index:  0, td:  val_14[0], td_index:  0);
            val_81 = val_81 >> 3;
            int val_16 = val_85 - 3;
            val_88 = 6;
            goto label_40;
            label_26:
            val_81 = val_81 >> 3;
            int val_17 = val_85 - 3;
            val_88 = 3;
            label_40:
            this.mode = val_88;
            goto label_41;
            label_47:
            if(val_77 == 0)
            {
                goto label_103;
            }
            
            val_89 = val_77 - 1;
            int val_18 = val_79 + 1;
            byte val_77 = this._codec.InputBuffer[(long)val_79];
            val_77 = val_77 << (val_17 & 31);
            val_90 = val_17 + 8;
            val_91 = val_77 | val_81;
            if(val_17 <= 23)
            {
                goto label_47;
            }
            
            val_77 = val_91 >> 16;
            val_77 = val_77 ^ 65535;
            if(val_77 != val_91)
            {
                goto label_48;
            }
            
            this.left = val_77;
            if(val_77 == 0)
            {
                goto label_49;
            }
            
            val_92 = 2;
            goto label_50;
            label_63:
            if(val_89 == 0)
            {
                goto label_103;
            }
            
            val_93 = val_89 - 1;
            int val_22 = val_18 + 1;
            if(val_18 >= this._codec.InputBuffer.Length)
            {
                    val_94 = 0;
            }
            
            byte val_80 = this._codec.InputBuffer[(long)val_18];
            int val_23 = val_90 & 31;
            val_95 = 0;
            val_80 = val_80 << val_23;
            val_90 = val_90 + 8;
            val_91 = val_80 | val_91;
            val_96 = val_22;
            if(val_90 <= 5)
            {
                goto label_63;
            }
            
            val_80 = val_91 & 31;
            val_23 = val_91 & 16383;
            this.table = val_23;
            if((val_80 > 29) || (((uint)(val_91 >> 5) & 31) >= 30))
            {
                goto label_65;
            }
            
            val_80 = val_80 + ((uint)(val_91 >> 5) & 31);
            val_80 = val_80 + 258;
            if(this.blens != null)
            {
                    if(val_80 <= this.blens.Length)
            {
                goto label_67;
            }
            
            }
            
            this.blens = new int[0];
            goto label_68;
            label_49:
            label_50:
            this.mode = (this.last == 0) ? 0 : 7;
            goto label_72;
            label_67:
            val_94 = val_80;
            System.Array.Clear(array:  this.blens, index:  0, length:  val_94);
            label_68:
            val_97 = 0;
            val_101 = val_91 >> 14;
            val_102 = val_90 - 14;
            this.index = 0;
            this.mode = 4;
            int val_81 = this.table;
            val_81 = val_81 >> 10;
            val_81 = val_81 + 4;
            if(val_97 >= val_81)
            {
                goto label_73;
            }
            
            label_86:
            if(val_102 > 2)
            {
                goto label_74;
            }
            
            label_79:
            if(val_93 == 0)
            {
                goto label_103;
            }
            
            val_103 = val_93 - 1;
            val_22 = val_96 + 1;
            if(val_96 >= this._codec.InputBuffer.Length)
            {
                    val_94 = 0;
            }
            
            byte val_82 = this._codec.InputBuffer[(long)val_96];
            val_95 = 0;
            val_82 = val_82 << (val_102 & 31);
            val_104 = val_102 + 8;
            val_105 = val_82 | val_101;
            val_96 = val_22;
            if(val_102 <= 6)
            {
                goto label_79;
            }
            
            label_74:
            val_106 = null;
            val_106 = null;
            this.index = this.index + 1;
            if(this.index >= Ionic.Zlib.InflateBlocks.border.Length)
            {
                    val_94 = 0;
            }
            
            System.Int32[] val_28 = Ionic.Zlib.InflateBlocks.border + ((this.index) << 2);
            if(((Ionic.Zlib.InflateBlocks.border + (this.index) << 2) + 32) >= this.blens.Length)
            {
                    val_94 = 0;
            }
            
            this.blens[((Ionic.Zlib.InflateBlocks.border + (this.index) << 2) + 32) << 2] = val_105 & 7;
            int val_83 = this.table;
            val_97 = this.index;
            val_107 = val_105 >> 3;
            val_108 = val_104 - 3;
            val_83 = val_83 >> 10;
            val_83 = val_83 + 4;
            if(val_97 < val_83)
            {
                goto label_86;
            }
            
            label_73:
            if(val_97 <= 18)
            {
                    do
            {
                val_109 = null;
                val_97 = this.index;
                val_109 = null;
                this.index = val_97 + 1;
                if(val_97 >= Ionic.Zlib.InflateBlocks.border.Length)
            {
                    val_94 = 0;
            }
            
                System.Int32[] val_31 = Ionic.Zlib.InflateBlocks.border + (((long)(int)(this.index)) << 2);
                if(((Ionic.Zlib.InflateBlocks.border + ((long)(int)(this.index)) << 2) + 32) >= this.blens.Length)
            {
                    val_94 = 0;
            }
            
                this.blens[((Ionic.Zlib.InflateBlocks.border + ((long)(int)(this.index)) << 2) + 32) << 2] = 0;
            }
            while(this.index < 19);
            
            }
            
            if(this.bb.Length == 0)
            {
                    val_94 = 0;
            }
            
            this.bb[0] = 7;
            val_110 = this.blens;
            val_111 = this.bb;
            if(this.inftree == null)
            {
                    val_111 = val_111;
                val_110 = val_110;
            }
            
            int val_32 = this.inftree.inflate_trees_bits(c:  val_110, bb:  val_111, tb:  this.tb, hp:  this.hufts, z:  this._codec);
            if(val_32 != 0)
            {
                goto label_98;
            }
            
            this.index = 0;
            this.mode = 5;
            val_98 = 0;
            var val_84 = (uint)(this.table >> 5) & 31;
            val_84 = (this.table & 31) + val_84;
            val_84 = val_84 + 258;
            if(val_98 >= val_84)
            {
                goto label_99;
            }
            
            label_149:
            int val_85 = this.bb[0];
            if(val_108 >= val_85)
            {
                goto label_102;
            }
            
            label_107:
            if(val_103 == 0)
            {
                goto label_103;
            }
            
            val_103 = val_103 - 1;
            val_99 = val_96 + 1;
            byte val_86 = this._codec.InputBuffer[(long)val_96];
            val_112 = val_108 + 8;
            val_86 = val_86 << (val_108 & 31);
            val_100 = 0;
            val_113 = val_86 | val_107;
            if(val_112 < val_85)
            {
                goto label_107;
            }
            
            goto label_108;
            label_102:
            val_99 = val_96;
            val_100 = val_95;
            label_108:
            val_114 = null;
            val_114 = null;
            System.Int32[] val_35 = Ionic.Zlib.InternalInflateConstants.InflateMask + ((this.bb[0]) << 2);
            byte val_36 = ((Ionic.Zlib.InternalInflateConstants.InflateMask + (this.bb[0]) << 2) + 32) & val_107;
            val_36 = val_36 + this.tb[0];
            val_36 = val_36 + (val_36 << 1);
            val_36 = val_36 + 1;
            int val_88 = this.hufts[((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + (this.bb[0]) << 2) + 32 & (((this._codec.InputBuffer[(long)(int)(((((val_3 > val_2 ? this.last > 0 ? (this.last - 1) : this.writeAt : this.left >)) << 2];
            System.Int32[] val_37 = Ionic.Zlib.InternalInflateConstants.InflateMask + ((this.hufts[((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + (this.bb[0]) << 2) + 32 & (((this._codec.InputBuffer[(long)(int)(((((val_3 > val_2 ? this.last > 0 ? (this.last - 1) : this.writeAt : this.left >)) << 2][0]) << 2);
            byte val_38 = ((Ionic.Zlib.InternalInflateConstants.InflateMask + (this.hufts[((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + (this.bb[0]) << 2) + 32 & (((this._codec.InputBuffer[(long)(int)((((( + 32) & val_107;
            val_38 = val_38 + this.tb[0];
            val_38 = val_38 + (val_38 << 1);
            val_38 = val_38 + 2;
            val_115 = this.hufts[((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + (this.hufts[((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + (this.bb[0]) << 2) + 32 & (((this._codec.InputBuffer[(long)(int)()) << 2];
            if(val_115 <= 15)
            {
                goto label_123;
            }
            
            this.hufts[((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + (this.hufts[((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + (this.bb[0]) << 2) + 32 & (((this._codec.InputBuffer[(long)(int)()) << 2] = val_115 - 14;
            var val_39 = (val_115 == 18) ? 7 : (this.hufts[((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + (this.hufts[((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + (this.bb[0]) << 2) + 32 & (((this._codec.InputBuffer[(long)(int)()) << 2]);
            var val_40 = (val_115 == 18) ? 11 : 3;
            int val_41 = val_39 + val_88;
            if(val_108 >= val_41)
            {
                goto label_124;
            }
            
            label_129:
            if(val_103 == 0)
            {
                goto label_125;
            }
            
            val_103 = val_103 - 1;
            val_116 = val_99 + 1;
            byte val_90 = this._codec.InputBuffer[(long)val_99];
            val_112 = val_108 + 8;
            val_90 = val_90 << (val_108 & 31);
            val_117 = 0;
            val_113 = val_90 | val_107;
            if(val_112 < val_41)
            {
                goto label_129;
            }
            
            goto label_130;
            label_123:
            val_118 = val_88 & 31;
            this.index = this.index + 1;
            if(this.blens == null)
            {
                    val_118 = val_118;
                val_115 = val_115;
            }
            
            val_119 = val_107 >> val_118;
            val_120 = val_108 - val_88;
            if(this.index >= this.blens.Length)
            {
                    val_115 = val_115;
            }
            
            this.blens[(this.index) << 2] = val_115;
            val_121 = this.index;
            goto label_133;
            label_124:
            val_116 = val_99;
            val_117 = val_100;
            label_130:
            val_122 = null;
            val_123 = val_88;
            byte val_45 = val_107 >> ( & 31);
            System.Int32[] val_47 = Ionic.Zlib.InternalInflateConstants.InflateMask + (((long)(int)(val_115 == 18 ? 7 : (this.hufts[((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + (this.hufts[((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + (this.bb[0]) << 2) + 32 & (((this._codec)) << 2);
            val_119 = val_45 >> (val_39 & 31);
            byte val_50 = ((Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(val_115 == 18 ? 7 : (this.hufts[((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + (this.hufts[((long)(int)((((((Ionic. + 32) & val_45;
            int val_51 = (this.table & 31) + ((uint)(this.table >> 5) & 31);
            val_124 = val_118;
            val_51 = val_51 + 258;
            val_120 = (val_108 - ) - val_39;
            val_45 = val_50 + val_124;
            if((val_45 + this.index) > val_51)
            {
                goto label_141;
            }
            
            if(this.index <= 0)
            {
                    if(val_115 == 16)
            {
                goto label_141;
            }
            
            }
            
            if(val_115 == 16)
            {
                    int val_53 = this.index - 1;
                val_125 = this.blens[((long)(int)((this.index - 1))) << 2];
                val_124 = val_118;
            }
            else
            {
                    val_125 = 0;
            }
            
            var val_91 = -val_45;
            do
            {
                int val_55 = this.index + 1;
                val_91 = val_91 + 1;
                this.blens[((long)(int)(this.index)) << 2] = val_125;
            }
            while(val_91 != 0);
            
            val_100 = val_117;
            val_121 = (val_124 + this.index) + val_50;
            this.index = val_121;
            val_99 = val_116;
            label_133:
            var val_92 = (uint)(this.table >> 5) & 31;
            val_92 = (this.table & 31) + val_92;
            val_92 = val_92 + 258;
            if(val_121 < val_92)
            {
                goto label_149;
            }
            
            goto label_150;
            label_99:
            val_99 = val_96;
            val_100 = val_95;
            label_150:
            this.tb[0] = 0;
            int[] val_57 = new int[1];
            val_57[0] = 9;
            int[] val_58 = new int[1];
            val_58[0] = 6;
            int[] val_60 = new int[1];
            val_126 = this.blens;
            val_127 = this.hufts;
            val_128 = this._codec;
            val_129 = val_60;
            if(this.inftree == null)
            {
                    val_128 = val_128;
                val_127 = val_127;
                val_129 = val_129;
                val_126 = val_126;
            }
            
            int val_64 = this.inftree.inflate_trees_dynamic(nl:  (this.table & 31) + 257, nd:  ((uint)(this.table >> 5) & 31) + 1, c:  val_126, bl:  val_57, bd:  val_58, tl:  new int[1], td:  val_60, hp:  val_127, z:  val_128);
            if(val_64 != 0)
            {
                goto label_158;
            }
            
            val_85 = this.codes;
            val_85.Init(bl:  9, bd:  val_58[0], tl:  this.hufts, tl_index:  mem[1152921525557679760], td:  this.hufts, td_index:  mem[1152921525557683872]);
            this.mode = 6;
            val_78 = this.writeAt;
            this.bitk = val_108;
            this.bitb = val_107;
            this._codec.AvailableBytesIn = val_103;
            val_130 = this._codec;
            if(this._codec != null)
            {
                goto label_167;
            }
            
            val_130 = this._codec;
            if(val_130 == null)
            {
                goto label_218;
            }
            
            label_167:
            int val_94 = this._codec.NextIn;
            val_94 = val_99 - val_94;
            val_94 = this._codec.TotalBytesIn + (val_94 << );
            this._codec.TotalBytesIn = val_94;
            this._codec.NextIn = val_99;
            val_87 = this.codes;
            this.writeAt = val_78;
            val_86 = val_87.Process(blocks:  this, r:  0);
            if(val_86 == 1)
            {
                goto label_171;
            }
            
            return this.Flush(r:  -3);
            label_20:
            this.bitk = val_80;
            this.bitb = val_81;
            if(this._codec != null)
            {
                goto label_192;
            }
            
            label_193:
            label_192:
            this._codec.AvailableBytesIn = 0;
            label_224:
            val_131 = this._codec;
            if(this._codec != null)
            {
                goto label_174;
            }
            
            val_131 = this._codec;
            if(val_131 == null)
            {
                goto label_218;
            }
            
            label_174:
            int val_95 = this._codec.NextIn;
            val_95 =  - val_95;
            label_186:
            val_95 = this._codec.TotalBytesIn + (val_95 << );
            this._codec.TotalBytesIn = val_95;
            val_132 = this._codec;
            if(val_132 != null)
            {
                goto label_212;
            }
            
            goto label_218;
            label_27:
            val_81 = val_81 >> 3;
            this.mode = 9;
            this._codec.Message = "invalid block type";
            this.bitk = val_85 - 3;
            this.bitb = val_81;
            this._codec.AvailableBytesIn = val_77;
            label_222:
            val_133 = this._codec;
            if(this._codec != null)
            {
                goto label_180;
            }
            
            val_133 = this._codec;
            if(val_133 == null)
            {
                goto label_218;
            }
            
            label_180:
            int val_96 = this._codec.NextIn;
            val_96 = val_79 - val_96;
            val_96 = this._codec.TotalBytesIn + (val_96 << );
            this._codec.TotalBytesIn = val_96;
            val_132 = this._codec;
            if(val_132 == null)
            {
                goto label_218;
            }
            
            val_86 = -3;
            label_203:
            val_87 = val_79;
            label_212:
            this._codec.NextIn = val_87;
            this.writeAt = ;
            return this.Flush(r:  -3);
            label_103:
            this.bitk = val_17;
            this.bitb = val_81;
            this._codec.AvailableBytesIn = 0;
            val_134 = this._codec;
            if(this._codec != null)
            {
                goto label_184;
            }
            
            val_134 = this._codec;
            if(val_134 == null)
            {
                goto label_218;
            }
            
            label_184:
            int val_97 = this._codec.NextIn;
            label_219:
            val_97 = val_79 - val_97;
            goto label_186;
            label_17:
            this.bitk = val_80;
            this.bitb = val_81;
            this._codec.AvailableBytesIn = ;
            val_135 = this._codec;
            if(this._codec != null)
            {
                goto label_188;
            }
            
            val_135 = this._codec;
            if(val_135 == null)
            {
                goto label_218;
            }
            
            label_188:
            int val_98 = this._codec.NextIn;
            val_98 =  - val_98;
            val_98 = this._codec.TotalBytesIn + (val_98 << );
            this._codec.TotalBytesIn = val_98;
            if(this._codec == null)
            {
                goto label_218;
            }
            
            goto label_203;
            label_125:
            this.bitk = val_108;
            this.bitb = val_107;
            if(this._codec != null)
            {
                goto label_192;
            }
            
            goto label_193;
            label_10:
            this.mode = 7;
            this.writeAt = val_78;
            int val_67 = this.Flush(r:  0);
            if(this.readAt != this.writeAt)
            {
                goto label_194;
            }
            
            this.mode = 8;
            this.bitk = val_80;
            this.bitb = val_81;
            this._codec.AvailableBytesIn = val_77;
            val_136 = this._codec;
            if(this._codec != null)
            {
                goto label_196;
            }
            
            val_136 = this._codec;
            if(val_136 == null)
            {
                goto label_218;
            }
            
            label_196:
            int val_99 = this._codec.NextIn;
            val_99 = val_79 - val_99;
            val_99 = this._codec.TotalBytesIn + (val_99 << );
            this._codec.TotalBytesIn = val_99;
            if(this._codec == null)
            {
                goto label_218;
            }
            
            goto label_203;
            label_194:
            this.bitk = val_80;
            this.bitb = val_81;
            this._codec.AvailableBytesIn = val_77;
            val_137 = this._codec;
            if(this._codec != null)
            {
                goto label_201;
            }
            
            val_137 = this._codec;
            if(val_137 == null)
            {
                goto label_218;
            }
            
            label_201:
            int val_100 = this._codec.NextIn;
            val_100 = val_79 - val_100;
            val_100 = this._codec.TotalBytesIn + (val_100 << );
            this._codec.TotalBytesIn = val_100;
            if(this._codec != null)
            {
                goto label_203;
            }
            
            goto label_218;
            label_65:
            val_138 = this._codec;
            this.mode = 9;
            val_139 = "too many length or distance symbols";
            goto label_206;
            label_141:
            this.blens = 0;
            this.mode = 9;
            this._codec.Message = "invalid bit length repeat";
            this.bitk = val_120;
            this.bitb = val_119;
            this._codec.AvailableBytesIn = val_103;
            val_140 = this._codec;
            if(this._codec != null)
            {
                goto label_209;
            }
            
            val_140 = this._codec;
            if(val_140 == null)
            {
                goto label_218;
            }
            
            label_209:
            int val_101 = this._codec.NextIn;
            val_101 = this.hufts - val_101;
            val_101 = this._codec.TotalBytesIn + (val_101 << );
            this._codec.TotalBytesIn = val_101;
            if(this._codec == null)
            {
                goto label_218;
            }
            
            goto label_212;
            label_158:
            if(val_64 != 3)
            {
                goto label_213;
            }
            
            this.blens = 0;
            this.mode = 9;
            goto label_214;
            label_98:
            if(val_32 == 3)
            {
                    this.blens = 0;
                this.mode = 9;
            }
            
            this.bitk = val_108;
            this.bitb = val_107;
            this._codec.AvailableBytesIn = val_103;
            val_141 = this._codec;
            if(this._codec != null)
            {
                goto label_219;
            }
            
            val_141 = this._codec;
            if(val_141 == null)
            {
                goto label_218;
            }
            
            goto label_219;
            label_48:
            val_138 = this._codec;
            this.mode = 9;
            val_139 = "invalid stored block lengths";
            label_206:
            this._codec.Message = val_139;
            this.bitk = val_90;
            this.bitb = val_91;
            this._codec.AvailableBytesIn = val_89;
            goto label_222;
            label_213:
            label_214:
            this.bitk = val_108;
            this.bitb = val_107;
            this._codec.AvailableBytesIn = val_103;
            goto label_224;
            label_218:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void Free()
        {
            uint val_1 = this.Reset();
            this.hufts = 0;
            this.window = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void SetDictionary(byte[] d, int start, int n)
        {
            System.Array.Copy(sourceArray:  d, sourceIndex:  start, destinationArray:  this.window, destinationIndex:  0, length:  n);
            this.readAt = n;
            this.writeAt = n;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int SyncPoint()
        {
            return (int)(this.mode == 1) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int Flush(int r)
        {
            var val_8;
            int val_9;
            var val_10;
            int val_11;
            Ionic.Zlib.ZlibCodec val_12;
            int val_13;
            Ionic.Zlib.ZlibCodec val_14;
            long val_15;
            Ionic.Zlib.ZlibCodec val_16;
            Ionic.Zlib.ZlibCodec val_17;
            int val_18;
            var val_19;
            val_8 = r;
            var val_8 = 0;
            label_23:
            val_9 = this.writeAt;
            if(val_8 != 0)
            {
                goto label_1;
            }
            
            val_10 = mem[this.writeAt];
            val_10 = this.writeAt;
            val_9 = this.end;
            if(this.readAt <= val_10)
            {
                goto label_2;
            }
            
            label_1:
            val_10 = mem[this.end];
            val_10 = val_9;
            label_2:
            val_11 = val_10 - this.readAt;
            if(val_11 == 0)
            {
                    return (int)(val_8 == 5) ? 0 : (val_8);
            }
            
            if(val_11 > this._codec.AvailableBytesOut)
            {
                    val_11 = this._codec.AvailableBytesOut;
            }
            
            val_12 = this._codec;
            if(val_12 != null)
            {
                    val_13 = this._codec.AvailableBytesOut;
            }
            else
            {
                    val_13 = 3670080;
                val_12 = 52;
            }
            
            mem[52] = val_13 - val_11;
            val_14 = this._codec;
            if(val_14 != null)
            {
                    val_15 = this._codec.TotalBytesOut;
            }
            else
            {
                    val_15 = 4194311;
                val_14 = 56;
            }
            
            mem[56] = val_15 + (val_11 << );
            if(this.checkfn != null)
            {
                    uint val_4 = Ionic.Zlib.Adler.Adler32(adler:  this.check, buf:  this.window, index:  this.readAt, len:  val_11);
                this.check = val_4;
                this._codec._Adler32 = val_4;
            }
            
            val_16 = this._codec;
            if(this._codec != null)
            {
                goto label_15;
            }
            
            val_16 = this._codec;
            if(val_16 == null)
            {
                goto label_16;
            }
            
            label_15:
            System.Array.Copy(sourceArray:  this.window, sourceIndex:  this.readAt, destinationArray:  this._codec.OutputBuffer, destinationIndex:  this._codec.NextOut, length:  val_11);
            val_17 = this._codec;
            if(val_17 != null)
            {
                    val_18 = this._codec.NextOut;
            }
            else
            {
                    val_18 = 0;
                val_17 = 48;
            }
            
            mem[48] = val_18 + val_11;
            int val_7 = this.readAt;
            val_7 = val_7 + val_11;
            this.readAt = val_7;
            if((val_8 != 0) || (val_7 != this.end))
            {
                goto label_20;
            }
            
            this.readAt = 0;
            if(this.writeAt != val_7)
            {
                goto label_23;
            }
            
            mem2[0] = 0;
            goto label_23;
            label_20:
            val_8 = val_8 + 2;
            if(val_8 < 2)
            {
                goto label_23;
            }
            
            val_19 = (val_11 == 0) ? 0 : (val_8);
            return (int)(val_8 == 5) ? 0 : (val_8);
            label_16:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static InflateBlocks()
        {
            Ionic.Zlib.InflateBlocks.border = new int[19] {16, 17, 18, 0, 8, 7, 9, 6, 10, 5, 11, 4, 12, 3, 13, 2, 14, 1, 15};
        }
    
    }

}
