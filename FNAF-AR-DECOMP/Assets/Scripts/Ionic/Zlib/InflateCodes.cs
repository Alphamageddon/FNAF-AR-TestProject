using UnityEngine;

namespace Ionic.Zlib
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal sealed class InflateCodes
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int START = 0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int LEN = 1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int LENEXT = 2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int DIST = 3;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int DISTEXT = 4;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int COPY = 5;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int LIT = 6;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int WASH = 7;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int END = 8;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int BADCODE = 9;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int mode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int len;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int[] tree;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int tree_index;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int need;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int lit;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int bitsToGet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int dist;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal byte lbits;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal byte dbits;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int[] ltree;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int ltree_index;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int[] dtree;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int dtree_index;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal InflateCodes()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void Init(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index)
        {
            this.mode = 0;
            this.lbits = bl;
            this.dbits = bd;
            this.ltree = tl;
            this.ltree_index = tl_index;
            this.dtree = td;
            this.dtree_index = td_index;
            this.tree = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int Process(Ionic.Zlib.InflateBlocks blocks, int r)
        {
            Ionic.Zlib.InflateBlocks val_52;
            Ionic.Zlib.InflateCodes val_53;
            var val_54;
            int val_55;
            int val_56;
            int val_57;
            int val_58;
            int val_59;
            int val_60;
            int val_61;
            int val_62;
            var val_63;
            int val_64;
            var val_65;
            var val_66;
            var val_67;
            int val_68;
            var val_70;
            int val_71;
            int val_72;
            var val_73;
            var val_74;
            var val_75;
            var val_76;
            var val_77;
            System.Int32[] val_78;
            int val_79;
            var val_80;
            var val_81;
            var val_82;
            var val_83;
            var val_84;
            var val_85;
            var val_86;
            var val_87;
            var val_96;
            var val_97;
            var val_98;
            var val_99;
            Ionic.Zlib.ZlibCodec val_100;
            Ionic.Zlib.InflateBlocks val_101;
            var val_102;
            var val_103;
            var val_104;
            var val_105;
            var val_110;
            var val_111;
            Ionic.Zlib.ZlibCodec val_114;
            var val_115;
            int val_116;
            val_52 = blocks;
            val_53 = this;
            if(blocks._codec != null)
            {
                    val_54 = blocks._codec;
            }
            else
            {
                    val_54 = 24;
            }
            
            val_55 = blocks._codec.AvailableBytesIn;
            val_57 = blocks.bitk;
            val_56 = blocks.bitb;
            if(blocks.writeAt >= blocks.readAt)
            {
                goto label_4;
            }
            
            val_58 = blocks.readAt + (~blocks.writeAt);
            val_59 = blocks.end;
            goto label_130;
            label_4:
            val_59 = val_52;
            val_58 = blocks.end - blocks.writeAt;
            goto label_130;
            label_137:
            var val_57 = 52949272 + ((blocks.end - blocks.writeAt)) << 2;
            val_57 = val_57 + 52949272;
            goto (52949272 + ((blocks.end - blocks.writeAt)) << 2 + 52949272);
            label_17:
            if( == 0)
            {
                goto label_102;
            }
            
            val_62 =  - 1;
            val_65 =  + 1;
            var val_1 = (blocks._codec + 16) + 15026800;
            var val_58 = (blocks._codec + 16 + 15026800) + 32;
            val_57 = val_57 + 8;
            val_58 = val_58 << (val_57 & 31);
            val_56 = val_58 | val_56;
            if(val_57 < )
            {
                goto label_17;
            }
            
            goto label_18;
            label_25:
            if( == 0)
            {
                goto label_102;
            }
            
            val_66 =  - 1;
            val_67 =  + 1;
            var val_3 = (blocks._codec + 16) + 15026800;
            var val_59 = (blocks._codec + 16 + 15026800) + 32;
            val_57 = val_57 + 8;
            val_59 = val_59 << (val_57 & 31);
            val_56 = val_59 | val_56;
            if(val_57 < )
            {
                goto label_25;
            }
            
            goto label_26;
            label_18:
            val_70 = null;
            val_70 = null;
            System.Int32[] val_5 = Ionic.Zlib.InternalInflateConstants.InflateMask + ((this.need + 44) << 2);
            int val_60 = (Ionic.Zlib.InternalInflateConstants.InflateMask + (this.need + 44) << 2) + 32;
            val_71 = val_57 - ;
            val_60 = mem[1152921525559737925];
            val_60 = val_60 & val_56;
            val_72 = val_56 >> ( & 31);
            val_60 = val_60 + mem[1152921525559737892];
            mem[1152921525559737904] = mem[1152921525559737952];
            this.need = val_60;
            mem[1152921525559737888] = 3;
            mem[1152921525559737892] = val_60;
            mem[1152921525559737896] = mem[1152921525559737944];
            val_73 = ;
            if(val_71 >= val_60)
            {
                goto label_35;
            }
            
            val_64 = r;
            val_63 = val_73;
            label_40:
            if( == 0)
            {
                goto label_36;
            }
            
            val_62 =  - 1;
            val_73 = val_63 + 1;
            var val_7 = (blocks._codec + 16) + 15026800;
            var val_61 = (blocks._codec + 16 + 15026800) + 32;
            val_74 = val_71 + 8;
            val_61 = val_61 << (val_71 & 31);
            val_75 = val_61 | val_72;
            if(val_74 < val_60)
            {
                goto label_40;
            }
            
            label_35:
            val_76 = null;
            val_76 = null;
            val_52 = val_52;
            System.Int32[] val_9 = Ionic.Zlib.InternalInflateConstants.InflateMask + (((long)(int)(mem[1152921525559737925])) << 2);
            var val_62 = (Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(mem[1152921525559737925])) << 2) + 32;
            val_62 = val_62 & val_75;
            val_62 = val_62 + mem[1152921525559737904];
            int val_10 = val_62 + (val_62 << 1);
            int val_11 = val_10 + 1;
            var val_12 = mem[1152921525559737896] + (((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(mem[1152921525559737925])) << 2) + 32 & (((blocks._codec + 16 + 15026800) + 32 << ((blocks.bitk - this.need + 44) & 31)) | (blocks.b)) << 2);
            var val_63 = (mem[1152921525559737944] + ((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(mem[1152921525559737925])) << 2) + 32 & (((blocks._codec + 16 + 15026800) + 32 << ((blocks. + 32;
            var val_13 = mem[1152921525559737896] + (((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(mem[1152921525559737925])) << 2) + 32 & (((blocks._codec + 16 + 15026800) + 32 << ((blocks.bitk - this.need + 44) & 31)) | (blocks.b)) << 2);
            val_63 = val_63 & 31;
            val_77 = val_10;
            var val_14 = mem[1152921525559737896] + (((long)(int)(((((Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(mem[1152921525559737925])) << 2) + 32 & (((blocks._codec + 16 + 15026800) + 32 << ((blocks.bitk - this.need + 44) & 31)) | (blocks.bi)) << 2);
            int val_64 = (mem[1152921525559737944] + ((long)(int)(((((Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(mem[1152921525559737925])) << 2) + 32 & (((blocks._codec + 16 + 15026800) + 32 << ((blocks.b + 32;
            val_56 = val_75 >> val_63;
            val_57 = val_74 - ((mem[1152921525559737944] + ((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(mem[1152921525559737925])) << 2) + 32 & (((blocks._codec + 16 + 15026800) + 32 << ((blocks. + 32);
            if((val_64 & 16) != 0)
            {
                goto label_51;
            }
            
            val_53 = val_53;
            if((val_64 & 64) != 0)
            {
                goto label_52;
            }
            
            val_78 = mem[1152921525559737896];
            this.need = val_64;
            val_79 = mem[mem[1152921525559737944] + 24];
            val_79 = mem[1152921525559737944] + 24;
            val_80 = val_77 + 2;
            goto label_54;
            label_51:
            val_53 = val_53;
            val_64 = val_64 & 15;
            mem[1152921525559737916] = val_64;
            int val_15 = val_77 + 2;
            var val_16 = mem[1152921525559737896] + (((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(mem[1152921525559737925])) << 2) + 32 & (((blocks._codec + 16 + 15026800) + 32 << ((blocks.bitk - this.need + 44) & 31)) | (blocks.b)) << 2);
            mem[1152921525559737888] = 4;
            mem[1152921525559737920] = (mem[1152921525559737944] + ((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(mem[1152921525559737925])) << 2) + 32 & (((blocks._codec + 16 + 15026800) + 32 << ((blocks. + 32;
            goto label_125;
            label_26:
            val_81 = null;
            val_81 = null;
            val_55 = ;
            val_52 = val_52;
            System.Int32[] val_17 = Ionic.Zlib.InternalInflateConstants.InflateMask + ((this.need + 44 + 36 + 44) << 2);
            var val_65 = (Ionic.Zlib.InternalInflateConstants.InflateMask + (this.need + 44 + 36 + 44) << 2) + 32;
            val_57 = val_57 - ;
            val_53 = val_53;
            val_65 = val_65 & val_56;
            val_56 = val_56 >> ( & 31);
            val_68 = val_65 + mem[1152921525559737920];
            mem[1152921525559737920] = val_68;
            mem[1152921525559737888] = 5;
            val_82 = blocks.writeAt - val_68;
            if((val_82 & 2147483648) != 0)
            {
                    do
            {
                val_82 = (blocks + 104) + val_82;
            }
            while((val_82 & 2147483648) != 0);
            
            }
            
            if(mem[1152921525559737892] != 0)
            {
                goto label_85;
            }
            
            goto label_66;
            label_79:
            val_83 = mem[blocks + 96];
            val_83 = blocks + 96;
            val_84 = mem[blocks + 96];
            val_84 = blocks + 96;
            if(val_84 != 0)
            {
                goto label_80;
            }
            
            goto label_68;
            label_85:
            if(val_58 != 0)
            {
                goto label_73;
            }
            
            if(blocks.writeAt != (blocks + 104))
            {
                goto label_72;
            }
            
            var val_66 = blocks + 108;
            if(val_66 == 0)
            {
                goto label_72;
            }
            
            val_66 = (val_66 > 0) ? (val_66 - 1) : blocks.writeAt;
            val_85 = 0;
            if(val_66 != 0)
            {
                goto label_73;
            }
            
            label_72:
            mem2[0] = val_85;
            var val_67 = blocks + 108;
            val_85 = mem[blocks + 108 + 4];
            val_85 = blocks + 108 + 4;
            if(val_85 < val_67)
            {
                    val_86 = mem[blocks + 104];
                val_86 = blocks + 104;
                val_87 = val_67 + (~val_85);
            }
            else
            {
                    val_86 = mem[blocks + 104];
                val_86 = blocks + 104;
                val_87 = val_86 - val_85;
            }
            
            if((val_85 == val_86) && (val_67 != 0))
            {
                    val_67 = (val_67 > 0) ? (val_67 - 1) : (val_85);
                val_85 = 0;
            }
            
            if(val_67 == 0)
            {
                goto label_78;
            }
            
            label_73:
            if(val_52 == 0)
            {
                goto label_79;
            }
            
            val_84 = mem[blocks + 96];
            val_84 = blocks + 96;
            val_83 = val_84;
            if(val_84 != 0)
            {
                goto label_80;
            }
            
            label_68:
            label_80:
            var val_22 = val_84 + (long)val_82;
            var val_23 = val_83 + 0;
            mem2[0] = (blocks + 96 + (long)(int)((blocks + 104 + (blocks.writeAt - (((Ionic.Zlib.InternalInflateConstants.InflateMask + (this.need + 44 + 36 + 44) << 2) + 32 & (((blocks._codec + 16 + 15026800) + 32 << (blo + 32;
            var val_68 = val_67;
            val_85 = val_85 + 1;
            val_82 = val_82 + 1;
            val_68 = val_68 - 1;
            val_53 = val_53;
            int val_24 = mem[1152921525559737892] - 1;
            var val_25 = (val_82 == (blocks + 104)) ? 0 : (val_82);
            mem[1152921525559737892] = val_24;
            if(val_24 != 0)
            {
                goto label_85;
            }
            
            label_66:
            mem[1152921525559737888] = 0;
            goto label_130;
            label_106:
            if( == 0)
            {
                goto label_102;
            }
            
            val_61 =  - 1;
            val_96 =  + 1;
            var val_31 = (blocks._codec + 16) + (long);
            var val_71 = (blocks._codec + 16 + (long)(int)((val_63 + 1))) + 32;
            val_97 = val_57 + 8;
            val_71 = val_71 << (val_57 & 31);
            val_98 = val_71 | val_56;
            if(val_97 < )
            {
                goto label_106;
            }
            
            val_99 = null;
            val_99 = null;
            val_52 = val_52;
            System.Int32[] val_33 = Ionic.Zlib.InternalInflateConstants.InflateMask + (((long)(int)(this.lbits)) << 2);
            var val_72 = (Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(this.lbits)) << 2) + 32;
            val_72 = val_72 & val_98;
            val_72 = val_72 + ;
            int val_34 = val_72 + (val_72 << 1);
            int val_35 = val_34 + 1;
            System.Int32[] val_36 =  + (((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(this.lbits)) << 2) + 32 & (((blocks._codec + 16 + (long)(int)((val_63 + 1))) + 32 << (blocks.bitk & 31)) | blocks.bitb)) + this.ltre)) << 2);
            var val_73 = mem[(this.ltree + ((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(this.lbits)) << 2) + 32 & (((blocks._codec + 16 + (long)(int)((val_63 + 1))) + 32 << (blocks.bitk & 31))  + 32];
            System.Int32[] val_37 =  + (((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(this.lbits)) << 2) + 32 & (((blocks._codec + 16 + (long)(int)((val_63 + 1))) + 32 << (blocks.bitk & 31)) | blocks.bitb)) + this.ltre)) << 2);
            val_73 = val_73 & 31;
            val_77 = val_34;
            System.Int32[] val_38 =  + (((long)(int)(((((Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(this.lbits)) << 2) + 32 & (((blocks._codec + 16 + (long)(int)((val_63 + 1))) + 32 << (blocks.bitk & 31)) | blocks.bitb)) + this.ltree)) << 2);
            int val_75 = mem[(this.ltree + ((long)(int)(((((Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(this.lbits)) << 2) + 32 & (((blocks._codec + 16 + (long)(int)((val_63 + 1))) + 32 << (blocks.bitk & 31)) | + 32];
            val_56 = val_98 >> val_73;
            val_57 = val_97 - (mem[(this.ltree + ((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(this.lbits)) << 2) + 32 & (((blocks._codec + 16 + (long)(int)((val_63 + 1))) + 32 << (blocks.bitk & 31))  + 32]);
            if(val_75 == 0)
            {
                goto label_117;
            }
            
            if((val_75 & 16) != 0)
            {
                goto label_118;
            }
            
            val_53 = val_53;
            if((val_75 & 64) != 0)
            {
                goto label_119;
            }
            
            val_78 = ;
            this.need = val_75;
            val_79 = mem[this.ltree + 24];
            val_79 = this.ltree.Length;
            val_80 = val_77 + 2;
            label_54:
            System.Int32[] val_39 = val_78 + (((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(this.lbits)) << 2) + 32 & (((blocks._codec + 16 + (long)(int)((val_63 + 1))) + 32 << (blocks.bitk & 31)) | blocks.bitb)) + this.ltre)) << 2);
            var val_74 = mem[(this.ltree + ((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(this.lbits)) << 2) + 32 & (((blocks._codec + 16 + (long)(int)((val_63 + 1))) + 32 << (blocks.bitk & 31))  + 32];
            val_74 = val_74 + 0;
            mem[1152921525559737904] = val_74;
            goto label_125;
            label_117:
            val_53 = val_53;
            int val_40 = val_77 + 2;
            System.Int32[] val_41 =  + (((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(this.lbits)) << 2) + 32 & (((blocks._codec + 16 + (long)(int)((val_63 + 1))) + 32 << (blocks.bitk & 31)) | blocks.bitb)) + this.ltre)) << 2);
            mem[1152921525559737888] = 6;
            mem[1152921525559737912] = mem[(this.ltree + ((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(this.lbits)) << 2) + 32 & (((blocks._codec + 16 + (long)(int)((val_63 + 1))) + 32 << (blocks.bitk & 31))  + 32];
            goto label_125;
            label_118:
            val_53 = val_53;
            val_75 = val_75 & 15;
            mem[1152921525559737916] = val_75;
            int val_42 = val_77 + 2;
            System.Int32[] val_43 =  + (((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(this.lbits)) << 2) + 32 & (((blocks._codec + 16 + (long)(int)((val_63 + 1))) + 32 << (blocks.bitk & 31)) | blocks.bitb)) + this.ltre)) << 2);
            mem[1152921525559737888] = 2;
            mem[1152921525559737892] = mem[(this.ltree + ((long)(int)((((((Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(this.lbits)) << 2) + 32 & (((blocks._codec + 16 + (long)(int)((val_63 + 1))) + 32 << (blocks.bitk & 31))  + 32];
            label_125:
            val_55 = val_61;
            goto label_130;
            label_119:
            if((val_75 & 32) == 0)
            {
                goto label_129;
            }
            
            mem[1152921525559737888] = 7;
            val_55 = val_61;
            label_130:
            if( <= 9)
            {
                goto label_137;
            }
            
            if(val_66 == 0)
            {
                goto label_138;
            }
            
            mem2[0] = val_56;
            goto label_139;
            label_102:
            val_100 = blocks._codec;
            val_101 = val_52;
            if(val_101 == 0)
            {
                goto label_140;
            }
            
            mem2[0] = val_56;
            goto label_141;
            label_36:
            val_101 = val_52;
            if(val_101 == 0)
            {
                goto label_142;
            }
            
            mem2[0] = val_72;
            goto label_143;
            label_140:
            mem2[0] = val_56;
            label_141:
            val_102 = val_54;
            goto label_144;
            label_78:
            mem2[0] = val_57;
            mem2[0] = val_56;
            if(blocks._codec == 0)
            {
                goto label_145;
            }
            
            mem2[0] = val_55;
            val_103 = val_54;
            var val_78 = ;
            val_78 = val_96 - val_78;
            val_78 = (blocks._codec + 32) + (val_78 << );
            mem2[0] = val_78;
            val_104 = val_96;
            goto label_146;
            label_142:
            mem2[0] = val_72;
            label_143:
            val_102 = val_54;
            val_100 = blocks._codec;
            label_144:
            mem2[0] = val_71;
            if(val_100 != 0)
            {
                    mem2[0] = 0;
                val_102 = val_63 - val_102;
                val_102 = (blocks._codec + 32) + (val_102 << );
                mem2[0] = val_102;
            }
            else
            {
                    mem2[0] = 0;
                val_100 = 32;
                val_105 = 64;
                val_60 = ;
                var val_47 = val_63 - val_60;
                val_47 = val_105 + (val_47 << );
                mem[32] = val_47;
            }
            
            mem[24] = val_63;
            label_173:
            mem2[0] = blocks.writeAt;
            return val_101.Flush(r:  val_64);
            label_145:
            mem2[0] = val_55;
            val_103 = val_54;
            var val_79 = val_96;
            var val_48 = val_79 - mem[24];
            val_48 = mem[32] + (val_48 << );
            mem[32] = val_48;
            val_104 = val_79;
            label_146:
            mem[24] = val_104;
            mem2[0] = val_85;
            return val_101.Flush(r:  val_64);
            label_138:
            mem2[0] = val_56;
            label_139:
            mem2[0] = val_57;
            if(blocks._codec != 0)
            {
                    mem2[0] = val_67;
                var val_81 = mem[24];
                val_110 = ;
                val_81 = val_110 - val_81;
                val_81 = (blocks._codec + 32) + (val_81 << );
                mem2[0] = val_81;
            }
            else
            {
                    mem2[0] = val_67;
                val_110 = ;
                var val_53 = val_110 - ;
                val_53 = mem[32] + (val_53 << );
                mem[32] = val_53;
            }
            
            mem[24] = val_110;
            goto label_173;
            label_52:
            mem[1152921525559737888] = 9;
            val_114 = blocks._codec;
            mem2[0] = "invalid distance code";
            val_115 = val_54;
            val_116 = val_61;
            if(val_52 == 0)
            {
                goto label_171;
            }
            
            label_177:
            mem2[0] = val_56;
            goto label_172;
            label_129:
            mem[1152921525559737888] = 9;
            val_114 = blocks._codec;
            val_116 = val_61;
            mem2[0] = "invalid literal/length code";
            val_115 = val_54;
            if(val_52 != 0)
            {
                goto label_177;
            }
            
            label_171:
            mem2[0] = val_56;
            label_172:
            mem2[0] = val_57;
            mem2[0] = val_116;
            val_115 =  - val_115;
            val_115 = (blocks._codec + 32) + (val_115 << );
            mem2[0] = val_115;
            mem[24] = ;
            if(val_52 != 0)
            {
                    mem2[0] = blocks.writeAt;
                return val_101.Flush(r:  val_64);
            }
            
            mem2[0] = blocks.writeAt;
            return val_101.Flush(r:  val_64);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int InflateFast(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, Ionic.Zlib.InflateBlocks s, Ionic.Zlib.ZlibCodec z)
        {
            int val_24;
            int val_78;
            int val_79;
            var val_80;
            var val_81;
            var val_82;
            var val_83;
            int val_84;
            var val_85;
            var val_86;
            var val_87;
            System.Int32[] val_88;
            var val_89;
            var val_90;
            int val_91;
            int val_92;
            System.Int32[] val_93;
            var val_94;
            var val_95;
            var val_96;
            System.Int32[] val_97;
            var val_98;
            var val_99;
            var val_100;
            int val_101;
            int val_102;
            var val_103;
            int val_104;
            Ionic.Zlib.InflateBlocks val_105;
            int val_106;
            int val_107;
            int val_108;
            int val_109;
            var val_110;
            var val_111;
            System.Array val_112;
            System.Array val_113;
            int val_114;
            var val_115;
            var val_116;
            Ionic.Zlib.InflateBlocks val_117;
            var val_118;
            System.Array val_119;
            System.Array val_120;
            Ionic.Zlib.ZlibCodec val_121;
            int val_122;
            int val_123;
            int val_124;
            var val_125;
            int val_126;
            var val_127;
            var val_128;
            int val_129;
            int val_130;
            var val_131;
            Ionic.Zlib.InflateBlocks val_132;
            var val_133;
            int val_134;
            var val_135;
            if(z != null)
            {
                    val_78 = z.NextIn;
            }
            else
            {
                    val_78 = 15026800;
            }
            
            if(s == 0)
            {
                goto label_3;
            }
            
            val_79 = mem[s + 84];
            val_79 = s + 84;
            val_80 = s + 84 + -4;
            val_81 = s + 84;
            val_82 = mem[s + 84 + 28];
            val_82 = s + 84 + 28;
            val_83 = mem[s + 84 + 24];
            val_83 = s + 84 + 24;
            if(val_82 < val_83)
            {
                goto label_4;
            }
            
            goto label_5;
            label_3:
            val_79 = 0;
            val_80 = 0;
            val_81 = 112;
            val_82 = 65536;
            if(65536 >= 0)
            {
                goto label_6;
            }
            
            val_83 = 0;
            val_81 = 112;
            label_4:
            val_84 = val_83 + val_82;
            goto label_7;
            label_6:
            label_5:
            val_84 = (s + 104) - val_82;
            label_7:
            var val_78 = val_82;
            val_85 = null;
            val_85 = null;
            System.Int32[] val_1 = Ionic.Zlib.InternalInflateConstants.InflateMask + (((long)(int)(bl)) << 2);
            System.Int32[] val_75 = Ionic.Zlib.InternalInflateConstants.InflateMask;
            System.Int32[] val_2 = val_75 + (((long)(int)(bd)) << 2);
            var val_79 = val_78;
            goto label_129;
            label_106:
            int val_3 = bd + 2;
            val_75 = val_75 & 15;
            val_86 = null;
            int val_76 = tl[((long)(int)((bd + 2))) << 2];
            val_86 = null;
            System.Int32[] val_4 = Ionic.Zlib.InternalInflateConstants.InflateMask + (((Ionic.Zlib.InternalInflateConstants.InflateMask & 15)) << 2);
            var val_77 = (Ionic.Zlib.InternalInflateConstants.InflateMask + ((Ionic.Zlib.InternalInflateConstants.InflateMask & 15)) << 2) + 32;
            val_87 = val_79 - val_75;
            val_88 = val_79 >> val_75;
            val_89 = val_77 & val_79;
            if(val_87 > 14)
            {
                    val_90 = val_78;
                val_91 = val_76;
                val_92 = td_index;
                val_93 = td;
            }
            else
            {
                    val_77 = val_77 - val_79;
                val_78 = val_77 >> 3;
                val_77 = val_77 & 4294967288;
                val_77 = val_79 + val_77;
                val_79 = val_77 + 8;
                System.Int32[] val_5 = (-65544) - val_75;
                do
            {
                var val_6 = (z + 16) + 15026800;
                var val_80 = (z + 16 + 15026800) + 32;
                val_80 = val_80 << (val_79 & 31);
                val_88 = val_80 | val_88;
            }
            while(val_5 < 7);
            
                int val_81 = z.AvailableBytesIn;
                val_93 = td;
                val_87 = val_79 - val_75;
                val_81 = val_81 - 1;
                val_81 = val_81 - val_78;
                val_90 = 15026801 + val_78;
                val_91 = val_76;
                val_92 = td_index;
                val_89 = val_89;
            }
            
            val_91 = val_89 + val_91;
            val_94 = val_88 & ((Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(bd)) << 2) + 32);
            if(val_93 != 0)
            {
                goto label_27;
            }
            
            goto label_27;
            label_37:
            if((val_5 & 64) != 0)
            {
                goto label_28;
            }
            
            val_93 = td;
            var val_8 = val_79 + 2;
            val_95 = null;
            System.Int32[] val_9 = val_93 + (((long)(int)((((val_82 + (((Ionic.Zlib.InternalInflateConstants.InflateMask + ((Ionic.Zlib.InternalInflateConstants.InflateMask & 15)) << 2) + 32 - val_82) & 4294967288)) + 8) + 2))) << 2);
            val_95 = null;
            val_94 = ((td + ((long)(int)((((val_82 + (((Ionic.Zlib.InternalInflateConstants.InflateMask + ((Ionic.Zlib.InternalInflateConstants.InflateMask & 15)) << 2) + 32 - val_82) & 4294967288)) + 8) + 2))) << 2) + 32) + val_94;
            System.Int32[] val_10 = Ionic.Zlib.InternalInflateConstants.InflateMask + (((-65544 - (Ionic.Zlib.InternalInflateConstants.InflateMask & 15))) << 2);
            var val_82 = (Ionic.Zlib.InternalInflateConstants.InflateMask + ((-65544 - (Ionic.Zlib.InternalInflateConstants.InflateMask & 15))) << 2) + 32;
            val_82 = val_82 & val_88;
            val_94 = val_94 + val_82;
            label_27:
            val_96 = mem[td + 24];
            val_96 = td + 24;
            System.Int32[] val_11 = val_94 + val_92;
            val_11 = val_11 + (val_11 << 1);
            if(val_11 >= val_96)
            {
                    val_96 = mem[td + 24];
                val_96 = td + 24;
            }
            
            System.Int32[] val_12 = val_93 + (((long)(int)((((((td + ((long)(int)((((val_82 + (((Ionic.Zlib.InternalInflateConstants.InflateMask + ((Ionic.Zlib.InternalInflateConstants.InflateMask & 15)) << 2) + 32 - val_82) & 4294967288)) + 8) + 2))) << 2) +)) << 2);
            var val_13 = (long)val_11 + 1;
            if(val_13 >= val_96)
            {
                    val_96 = mem[td + 24];
                val_96 = td + 24;
            }
            
            val_93 = val_93 + (((long)(int)(((long)(int)((((((td + ((long)(int)((((val_82 + (((Ionic.Zlib.InternalInflateConstants.InflateMask + ((Ionic.Zlib.InternalInflateConstants.InflateMask & 15)) << 2) + 32 - val_82) & 4294967288)) + 8) +)) << 2);
            val_97 = mem[(td + ((long)(int)(((long)(int)((((((td + ((long)(int)((((val_82 + (((Ionic.Zlib.InternalInflateConstants.InflateMask + ((Ionic.Zlib.InternalInflateConstants.InflateMask & 15)) << 2) + 32 - val_82) &  + 32];
            val_97 = (td + ((long)(int)(((long)(int)((((((td + ((long)(int)((((val_82 + (((Ionic.Zlib.InternalInflateConstants.InflateMask + ((Ionic.Zlib.InternalInflateConstants.InflateMask & 15)) << 2) + 32 - val_82) &  + 32;
            val_98 = val_88 >> (val_97 & 31);
            if((long)val_13 >= val_96)
            {
                    val_97 = mem[(td + ((long)(int)(((long)(int)((((((td + ((long)(int)((((val_82 + (((Ionic.Zlib.InternalInflateConstants.InflateMask + ((Ionic.Zlib.InternalInflateConstants.InflateMask & 15)) << 2) + 32 - val_82) &  + 32];
                val_97 = (td + ((long)(int)(((long)(int)((((((td + ((long)(int)((((val_82 + (((Ionic.Zlib.InternalInflateConstants.InflateMask + ((Ionic.Zlib.InternalInflateConstants.InflateMask & 15)) << 2) + 32 - val_82) &  + 32;
            }
            
            val_99 = val_87 - val_97;
            if((((td + ((long)(int)((((((td + ((long)(int)((((val_82 + (((Ionic.Zlib.InternalInflateConstants.InflateMask + ((Ionic.Zlib.InternalInflateConstants.InflateMask & 15)) << 2) + 32 - val_82) & 4294967288))  + 32) & 16) == 0)
            {
                goto label_37;
            }
            
            var val_15 = ((td + ((long)(int)((((((td + ((long)(int)((((val_82 + (((Ionic.Zlib.InternalInflateConstants.InflateMask + ((Ionic.Zlib.InternalInflateConstants.InflateMask & 15)) << 2) + 32 - val_82) & 4294967288))  + 32) & 15;
            if(val_99 < val_15)
            {
                    System.Int32[] val_16 = val_15 - 1;
                val_16 = val_16 - val_99;
                val_97 = val_16 >> 3;
                val_78 = (val_90 + (val_16 >> 3)) + 1;
                val_16 = val_16 & 4294967288;
                do
            {
                var val_18 = val_90 + 1;
                var val_19 = (z + 16) + (long)val_90;
                var val_83 = (z + 16 + (long)(int)((15026801 + (((Ionic.Zlib.InternalInflateConstants.InflateMask + ((Ionic.Zlib.InternalInflateConstants.InflateMask & 15)) << 2) + 32 - val_82) >> 3)))) + 32;
                val_83 = val_83 << (val_99 & 31);
                val_98 = val_83 | val_98;
            }
            while(val_99 < val_15);
            
                int val_84 = val_81;
                System.Int32[] val_85 = val_16;
                val_84 = val_84 - 1;
                val_85 = val_99 + val_85;
                val_84 = val_84 - val_97;
            }
            else
            {
                    val_78 = val_90;
            }
            
            var val_21 = (long)val_11 + 2;
            val_100 = null;
            System.Int32[] val_22 = td + (((long)(int)(((long)(int)((((((td + ((long)(int)((((val_82 + (((Ionic.Zlib.InternalInflateConstants.InflateMask + ((Ionic.Zlib.InternalInflateConstants.InflateMask & 15)) << 2) + 32 - val_82) & 4294967288)) + 8) +)) << 2);
            val_101 = val_91;
            System.Int32[] val_23 = Ionic.Zlib.InternalInflateConstants.InflateMask + ((((td + ((long)(int)((((((td + ((long)(int)((((val_82 + (((Ionic.Zlib.InternalInflateConstants.InflateMask + ((Ionic.Zlib.InternalInflateConstants.InflateMask & 15)) << 2) + 32 - val_82) & 4294967288))) << 2);
            var val_86 = (Ionic.Zlib.InternalInflateConstants.InflateMask + (((td + ((long)(int)((((((td + ((long)(int)((((val_82 + (((Ionic.Zlib.InternalInflateConstants.InflateMask + ((Ionic.Zlib.InternalInflateConstants.In + 32;
            int val_87 = val_84;
            val_102 = val_98 >> val_15;
            val_103 = val_99 - val_15;
            val_86 = val_86 & val_98;
            val_86 = val_86 + ((td + ((long)(int)(((long)(int)((((((td + ((long)(int)((((val_82 + (((Ionic.Zlib.InternalInflateConstants.InflateMask + ((Ionic.Zlib.InternalInflateConstants.InflateMask & 15)) << 2) + 32 - val_82) &  + 32);
            val_104 = val_24;
            val_87 = val_87 - ;
            System.Int32[] val_25 = val_104 - val_86;
            if(val_15 >= Ionic.Zlib.InternalInflateConstants.InflateMask.Length)
            {
                goto label_51;
            }
            
            val_105 = s;
            do
            {
                val_106 = (s + 104) + val_25;
            }
            while((val_106 & 2147483648) != 0);
            
            if( <= (-val_25))
            {
                goto label_54;
            }
            
            var val_88 = val_24;
            val_107 =  + val_25;
            val_88 = val_88 - val_106;
            if((val_88 < 1) || (val_88 >= (-val_25)))
            {
                goto label_56;
            }
            
            var val_89 = val_24;
            val_89 = val_89 + (s + 104);
            do
            {
                var val_27 = (s + 96) + ((long)(s + 104) + val_25);
                val_108 = val_24 + 1;
                if(val_24 >= (s + 96 + 24))
            {
                    val_24 = val_108;
                val_108 = val_24;
            }
            
                var val_28 = (s + 96) + (long)val_24;
                mem2[0] = (s + 96 + (long)(int)((s + 104 + (val_24 - (((Ionic.Zlib.InternalInflateConstants.InflateMask + (((td + ((long)(int)((((((td + ((long)(int)((((val_82 + (((Ionic.Zlib.InternalInflateConstants.InflateMa + 32;
                val_105 = s;
                val_24 = val_108;
            }
            while(val_25 != null);
            
            val_107 = val_107;
            val_109 = val_89 - val_106;
            val_106 = 0;
            goto label_73;
            label_51:
            val_105 = s;
            if(val_86 != 1)
            {
                goto label_62;
            }
            
            if(val_105 == 0)
            {
                goto label_63;
            }
            
            if((s + 96) != 0)
            {
                goto label_74;
            }
            
            label_75:
            label_74:
            var val_29 = (s + 96) + (long)val_25;
            var val_30 = (s + 96) + (long)val_24;
            mem2[0] = (s + 96 + (long)(int)((val_24 - (((Ionic.Zlib.InternalInflateConstants.InflateMask + (((td + ((long)(int)((((((td + ((long)(int)((((val_82 + (((Ionic.Zlib.InternalInflateConstants.InflateMask + ((Ioni + 32;
            if(val_105 == 0)
            {
                goto label_68;
            }
            
            val_110 = mem[s + 96];
            val_110 = s + 96;
            val_111 = val_110;
            goto label_69;
            label_54:
            val_109 = val_24;
            goto label_73;
            label_62:
            if(val_105 == 0)
            {
                goto label_71;
            }
            
            val_112 = mem[s + 96];
            val_112 = s + 96;
            val_113 = val_112;
            goto label_72;
            label_56:
            System.Array.Copy(sourceArray:  s + 96, sourceIndex:  val_106, destinationArray:  s + 96, destinationIndex:  val_24, length:  -val_25);
            val_106 = 0;
            val_109 = val_24 - val_25;
            goto label_73;
            label_63:
            if((s + 96) != 0)
            {
                goto label_74;
            }
            
            goto label_75;
            label_68:
            val_111 = mem[s + 96];
            val_111 = s + 96;
            val_110 = mem[s + 96];
            val_110 = s + 96;
            label_69:
            var val_31 = val_110 + (long)(long)val_24;
            var val_90 = val_24;
            val_90 = val_90 + 2;
            var val_33 = val_111 + ((long)val_90 + 1);
            mem2[0] = (s + 96 + (long)(int)((long)(int)((val_24 + 1)))) + 32;
            val_114 = val_107;
            val_109 = val_90;
            goto label_80;
            label_71:
            val_113 = mem[s + 96];
            val_113 = s + 96;
            val_112 = mem[s + 96];
            val_112 = s + 96;
            val_104 = val_24;
            label_72:
            System.Array.Copy(sourceArray:  val_113, sourceIndex:  val_25, destinationArray:  val_112, destinationIndex:  val_104, length:  2);
            val_105 = s;
            val_109 = val_104 + 2;
            label_80:
            val_107 =  - 2;
            label_73:
            val_86 = val_109 - val_25;
            if((val_86 < 1) || (val_107 <= val_86))
            {
                goto label_82;
            }
            
            var val_91 = val_107;
            val_24 = val_109;
            goto label_91;
            label_86:
            val_115 = mem[s + 96];
            val_115 = s + 96;
            val_116 = mem[s + 96];
            val_116 = s + 96;
            if(val_116 != 0)
            {
                goto label_87;
            }
            
            goto label_85;
            label_91:
            if(val_105 == 0)
            {
                goto label_86;
            }
            
            val_116 = mem[s + 96];
            val_116 = s + 96;
            val_115 = val_116;
            if(val_116 != 0)
            {
                goto label_87;
            }
            
            label_85:
            label_87:
            var val_34 = val_116 + (long)val_25;
            var val_35 = val_109 + 1;
            var val_36 = val_115 + (long)val_109;
            mem2[0] = (s + 96 + (long)(int)((val_24 - (((Ionic.Zlib.InternalInflateConstants.InflateMask + (((td + ((long)(int)((((((td + ((long)(int)((((val_82 + (((Ionic.Zlib.InternalInflateConstants.InflateMask + ((Ioni + 32;
            val_117 = s;
            val_91 = val_91 - 1;
            if(val_91 != 0)
            {
                goto label_91;
            }
            
            val_118 = val_24 + val_107;
            goto label_92;
            label_82:
            if(val_105 != 0)
            {
                    val_119 = mem[s + 96];
                val_119 = s + 96;
                val_120 = val_119;
            }
            else
            {
                    val_120 = mem[s + 96];
                val_120 = s + 96;
                val_119 = mem[s + 96];
                val_119 = s + 96;
            }
            
            System.Array.Copy(sourceArray:  val_120, sourceIndex:  val_25, destinationArray:  val_119, destinationIndex:  val_109, length:  val_107);
            val_117 = s;
            val_118 = val_109 + val_107;
            label_92:
            val_121 = z;
            val_122 = val_87;
            goto label_95;
            label_129:
            val_24 = val_79;
            if(val_80 <= 19)
            {
                    var val_37 = 19 - val_80;
                var val_92 = val_80;
                do
            {
                var val_42 = val_78 + 1;
                var val_43 = (z + 16) + 15026800;
                var val_93 = (z + 16 + 15026800) + 32;
                val_92 = val_92 + 8;
                val_93 = val_93 << (val_92 & 31);
                val_79 = val_93 | val_79;
            }
            while(val_92 < 12);
            
                int val_94 = val_84;
                val_80 = (val_80 + (val_37 & 4294967288)) + 8;
                val_78 = (val_78 + (val_37 >> 3)) + 1;
                val_94 = val_94 - 1;
                val_94 = val_94 - (val_37 >> 3);
            }
            
            var val_46 = val_79 & ((Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(bl)) << 2) + 32);
            int val_95 = tl_index;
            val_95 = val_46 + val_95;
            int val_47 = val_95 + (val_95 << 1);
            int val_96 = tl[((long)(int)(((((((z + 16 + 15026800) + 32 << (val_80 & 31)) | val_79) & (Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 15026800) + 32 << (val_80 & 31)) << 2];
            if(val_96 == 0)
            {
                goto label_103;
            }
            
            label_114:
            val_123 = tl.Length;
            int val_48 = val_47 + 1;
            if(val_48 >= val_123)
            {
                    val_123 = tl.Length;
            }
            
            val_124 = tl[((long)(int)((((((((z + 16 + 15026800) + 32 << (val_80 & 31)) | val_79) & (Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 15026800) + 32 << (val_80 & 3)) << 2];
            if((long)val_48 >= val_123)
            {
                    val_124 = mem[tl[((long)(int)((((((((z + 16 + 15026800) + 32 << (val_80 & 31)) | val_79) & (Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 15026800) + 32 << (val_80 & 3)) << 2] + 32];
                val_124 = tl[((long)(int)((((((((z + 16 + 15026800) + 32 << (val_80 & 31)) | val_79) & (Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 15026800) + 32 << (val_80 & 3)) << 2] + 32;
            }
            
            val_79 = val_79 >> (val_124 & 31);
            var val_50 = val_80 - val_124;
            if((val_96 & 16) != 0)
            {
                goto label_106;
            }
            
            if((val_96 & 64) != 0)
            {
                goto label_107;
            }
            
            int val_51 = val_47 + 2;
            val_125 = null;
            int val_97 = tl[((long)(int)((((((((z + 16 + 15026800) + 32 << (val_80 & 31)) | val_79) & (Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 15026800) + 32 << (val_80 & 3)) << 2];
            val_125 = null;
            val_97 = val_97 + val_46;
            System.Int32[] val_52 = Ionic.Zlib.InternalInflateConstants.InflateMask + (((long)(int)(tl[((long)(int)(((((((z + 16 + 15026800) + 32 << (val_80 & 31)) | val_79) & (Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 15026800) + 32 << (val_80 & 31)) << 2][0])) << 2);
            var val_98 = (Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(tl[((long)(int)(((((((z + 16 + 15026800) + 32 << (val_80 & 31)) | val_79) & (Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(i + 32;
            val_98 = val_98 & val_79;
            val_46 = val_97 + val_98;
            int val_99 = tl_index;
            val_99 = val_46 + val_99;
            int val_53 = val_99 + (val_99 << 1);
            if((tl[((long)(int)(((((tl[((long)(int)((((((((z + 16 + 15026800) + 32 << (val_80 & 31)) | val_79) & (Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 15026800))) << 2]) != 0)
            {
                goto label_114;
            }
            
            val_126 = tl.Length;
            int val_54 = val_53 + 1;
            if(val_54 >= val_126)
            {
                    val_126 = tl.Length;
            }
            
            int val_101 = tl[((long)(int)((((((tl[((long)(int)((((((((z + 16 + 15026800) + 32 << (val_80 & 31)) | val_79) & (Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 15026800)) << 2];
            val_127 = val_101;
            if((long)val_54 >= val_126)
            {
                    val_127 = mem[tl[((long)(int)((((((tl[((long)(int)((((((((z + 16 + 15026800) + 32 << (val_80 & 31)) | val_79) & (Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 15026800)) << 2] + 32];
                val_127 = tl[((long)(int)((((((tl[((long)(int)((((((((z + 16 + 15026800) + 32 << (val_80 & 31)) | val_79) & (Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 15026800)) << 2] + 32;
            }
            
            int val_56 = val_53 + 2;
            val_121 = z;
            val_102 = val_79 >> (val_101 & 31);
            val_103 = val_50 - val_127;
            val_128 = 65537;
            var val_57 = (s + 96) + 65536;
            mem2[0] = tl[((long)(int)((((((tl[((long)(int)((((((((z + 16 + 15026800) + 32 << (val_80 & 31)) | val_79) & (Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 15026800)) << 2];
            val_129 = val_87;
            val_117 = s;
            goto label_121;
            label_103:
            val_130 = tl.Length;
            int val_58 = val_47 + 1;
            if(val_58 >= val_130)
            {
                    val_130 = tl.Length;
            }
            
            int val_103 = tl[((long)(int)((((((((z + 16 + 15026800) + 32 << (val_80 & 31)) | val_79) & (Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 15026800) + 32 << (val_80 & 3)) << 2];
            val_131 = val_103;
            if((long)val_58 >= val_130)
            {
                    val_131 = mem[tl[((long)(int)((((((((z + 16 + 15026800) + 32 << (val_80 & 31)) | val_79) & (Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 15026800) + 32 << (val_80 & 3)) << 2] + 32];
                val_131 = tl[((long)(int)((((((((z + 16 + 15026800) + 32 << (val_80 & 31)) | val_79) & (Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 15026800) + 32 << (val_80 & 3)) << 2] + 32;
            }
            
            int val_60 = val_47 + 2;
            val_102 = val_79 >> (val_103 & 31);
            val_103 = val_80 - val_131;
            val_128 = 65537;
            var val_61 = (s + 96) + 65536;
            mem2[0] = tl[((long)(int)((((((((z + 16 + 15026800) + 32 << (val_80 & 31)) | val_79) & (Ionic.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 15026800) + 32 << (val_80 & 3)) << 2];
            val_129 = val_87;
            val_117 = s;
            val_121 = z;
            label_121:
            val_118 = val_128;
            val_122 = val_129 - 1;
            label_95:
            if(val_122 >= 258)
            {
                    if(val_94 > 9)
            {
                goto label_129;
            }
            
            }
            
            var val_105 = z + 28;
            var val_62 = val_103 >> 3;
            val_105 = val_105 - val_94;
            var val_63 = (val_62 < val_105) ? (val_62) : (val_105);
            var val_65 = val_78 - val_63;
            if(val_117 == 0)
            {
                goto label_131;
            }
            
            mem[84] = val_102;
            goto label_132;
            label_107:
            val_132 = s;
            if((val_96 & 32) != 0)
            {
                goto label_134;
            }
            
            mem2[0] = "invalid literal/length code";
            var val_106 = z + 28;
            var val_67 = val_50 >> 3;
            val_106 = val_106 - val_94;
            var val_68 = (val_67 < val_106) ? (val_67) : (val_106);
            val_124 = val_68 + val_94;
            var val_69 = val_78 - val_68;
            val_50 = val_50 - (val_68 << 3);
            if(val_132 == 0)
            {
                goto label_136;
            }
            
            mem[84] = val_79;
            goto label_137;
            label_28:
            if(z == 0)
            {
                goto label_138;
            }
            
            mem2[0] = "invalid distance code";
            goto label_139;
            label_134:
            var val_107 = z + 28;
            var val_70 = val_50 >> 3;
            val_107 = val_107 - val_94;
            var val_71 = (val_70 < val_107) ? (val_70) : (val_107);
            val_124 = val_71 + val_94;
            val_133 = val_78 - val_71;
            val_134 = val_50 - (val_71 << 3);
            if(val_132 == 0)
            {
                goto label_140;
            }
            
            mem[84] = val_79;
            goto label_141;
            label_138:
            mem[64] = "invalid distance code";
            label_139:
            var val_108 = z + 28;
            System.Int32[] val_72 = val_87 >> 3;
            val_132 = 84;
            val_108 = val_108 - val_94;
            var val_73 = (val_72 < val_108) ? (val_72) : (val_108);
            val_134 = val_73 + val_94;
            val_133 = val_90 - val_73;
            if(s != 0)
            {
                    mem[84] = val_88;
            }
            else
            {
                    mem[84] = val_88;
            }
            
            mem[80] = val_87 - (val_73 << 3);
            mem2[0] = val_134;
            var val_109 = 15026800;
            val_109 = val_133 - val_109;
            val_109 = (z + 32) + (val_109 << );
            mem2[0] = val_109;
            mem[24] = val_133;
            if(s != 0)
            {
                goto label_146;
            }
            
            label_147:
            label_146:
            val_135 = -3;
            goto label_145;
            label_136:
            mem[84] = val_79;
            label_137:
            mem[80] = val_50;
            mem2[0] = val_124;
            var val_110 = mem[24];
            val_110 = val_69 - val_110;
            val_110 = (z + 32) + (val_110 << );
            mem2[0] = val_110;
            mem[24] = val_69;
            if(val_132 != 0)
            {
                goto label_146;
            }
            
            goto label_147;
            label_140:
            mem[84] = val_79;
            label_141:
            mem[80] = val_134;
            mem2[0] = val_124;
            var val_111 = mem[24];
            val_111 = val_133 - val_111;
            val_111 = (z + 32) + (val_111 << );
            mem2[0] = val_111;
            mem[24] = val_133;
            val_135 = 1;
            label_145:
            label_150:
            mem[112] = val_24;
            return (int)val_135;
            label_131:
            mem[84] = val_102;
            label_132:
            mem[80] = val_103 - (val_63 << 3);
            mem2[0] = val_63 + val_94;
            var val_112 = mem[24];
            val_112 = val_65 - val_112;
            val_112 = (z + 32) + (val_112 << );
            mem2[0] = val_112;
            mem[24] = val_65;
            if(val_117 != 0)
            {
                goto label_150;
            }
            
            goto label_150;
        }
    
    }

}
