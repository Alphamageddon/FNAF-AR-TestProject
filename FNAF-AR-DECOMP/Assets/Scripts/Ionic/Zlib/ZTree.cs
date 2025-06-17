using UnityEngine;

namespace Ionic.Zlib
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal sealed class ZTree
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly int HEAP_SIZE;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly int[] ExtraLengthBits;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly int[] ExtraDistanceBits;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly int[] extra_blbits;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly sbyte[] bl_order;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal const int Buf_size = 16;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly sbyte[] _dist_code;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly sbyte[] LengthCode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly int[] LengthBase;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly int[] DistanceBase;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal short[] dyn_tree;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int max_code;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal Ionic.Zlib.StaticTree staticTree;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static int DistanceCode(int dist)
        {
            var val_2;
            var val_3;
            var val_4;
            System.SByte[] val_5;
            var val_6;
            val_2 = dist;
            val_3 = null;
            if(val_2 >= 256)
            {
                    val_4 = null;
                val_2 = val_2 >> 7;
                val_5 = Ionic.Zlib.ZTree._dist_code;
                val_2 = val_2 + 256;
            }
            else
            {
                    val_6 = null;
                val_5 = Ionic.Zlib.ZTree._dist_code;
            }
            
            System.SByte[] val_1 = val_5 + (long)val_2;
            return (int)(Ionic.Zlib.ZTree._dist_code + (long)(int)(dist)) + 32;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void gen_bitlen(Ionic.Zlib.DeflateManager s)
        {
            Ionic.Zlib.StaticTree val_14;
            var val_15;
            System.Int16[] val_16;
            var val_17;
            System.Int16[] val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            System.Int32[] val_23;
            var val_24;
            var val_25;
            int val_26;
            var val_27;
            val_14 = this.staticTree;
            if(val_14 == null)
            {
                goto label_1;
            }
            
            goto label_2;
            label_1:
            if(this.staticTree == null)
            {
                goto label_3;
            }
            
            val_14 = this.staticTree;
            label_2:
            label_63:
            label_64:
            int val_27 = this.staticTree.maxLength;
            val_15 = 0;
            goto label_4;
            label_10:
            val_16 = s.bl_count;
            val_15 = 1;
            val_16[0] = 0;
            label_4:
            val_17 = null;
            val_17 = null;
            if(val_15 <= Ionic.Zlib.InternalConstants.MAX_BITS)
            {
                goto label_10;
            }
            
            int val_11 = s.heap[(s.heap_max) << 2];
            val_18 = 1;
            System.Int16[] val_12 = this.dyn_tree;
            val_19 = 0;
            val_12 = val_12 + 2;
            mem2[0] = 0;
            val_20 = s.heap_max + 1;
            goto label_16;
            label_34:
            val_18 = this.dyn_tree;
            int val_13 = s.heap[((long)(int)((s.heap_max + 1))) << 2];
            val_21 = mem[this.dyn_tree + 24];
            val_21 = this.dyn_tree + 24;
            if(1 >= val_21)
            {
                    val_21 = mem[this.dyn_tree + 24];
                val_21 = this.dyn_tree + 24;
            }
            
            val_16 = val_18 + 2;
            if(1 >= val_21)
            {
                    val_21 = mem[this.dyn_tree + 24];
                val_21 = this.dyn_tree + 24;
            }
            
            System.Int16[] val_1 = val_18 + 2;
            var val_2 = (val_27 <= ((this.dyn_tree + 2) + 32)) ? (val_19 + 1) : (val_19);
            var val_3 = (val_27 <= ((this.dyn_tree + 2) + 32)) ? (val_27) : (((this.dyn_tree + 2) + 32) + 1);
            mem2[0] = val_3;
            if(val_13 <= this.max_code)
            {
                    short val_14 = s.bl_count[(long)val_3];
                val_14 = val_14 + 1;
                int val_5 = val_13 - this.staticTree.extraBase;
                s.bl_count[(long)val_3] = val_14;
                if(val_3 < s.bl_count.Length)
            {
                    val_22 = 0;
            }
            else
            {
                    val_23 = this.staticTree.extraBits;
                if(val_23 == 0)
            {
                    val_23 = this.staticTree.extraBits;
            }
            
                System.Int32[] val_15 = this.staticTree.extraBits;
                val_15 = val_15 + (((long)(int)((s.heap[((long)(int)((s.heap_max + 1))) << 2][0] - this.staticTree.extraBase))) << 2);
                val_22 = mem[(this.staticTree.extraBits + ((long)(int)((s.heap[((long)(int)((s.heap_max + 1))) << 2][0] - this.staticTree.extraBase))) << 2) + 32];
                val_22 = (this.staticTree.extraBits + ((long)(int)((s.heap[((long)(int)((s.heap_max + 1))) << 2][0] - this.staticTree.extraBase))) << 2) + 32;
            }
            
                val_18 = (long)val_13 << 1;
                System.Int16[] val_16 = this.dyn_tree;
                val_16 = val_16 + (((long)(int)((s.heap[((long)(int)((s.heap_max + 1))) << 2][0] << 1))) << 1);
                val_16 = mem[(this.dyn_tree + ((long)(int)((s.heap[((long)(int)((s.heap_max + 1))) << 2][0] << 1))) << 1) + 32];
                val_16 = (this.dyn_tree + ((long)(int)((s.heap[((long)(int)((s.heap_max + 1))) << 2][0] << 1))) << 1) + 32;
                int val_6 = val_22 + val_3;
                val_6 = s.opt_len + (val_6 * val_16);
                s.opt_len = val_6;
                if(this.staticTree.treeCodes != 0)
            {
                    System.Int16[] val_17 = this.staticTree.treeCodes;
                val_17 = val_17 + 2;
                int val_18 = (this.staticTree.treeCodes + 2) + 32;
                val_18 = val_22 + val_18;
                val_18 = s.static_len + (val_18 * val_16);
                s.static_len = val_18;
            }
            
            }
            
            val_20 = val_20 + 1;
            label_16:
            val_24 = null;
            val_24 = null;
            if(val_20 < Ionic.Zlib.ZTree.Buf_size)
            {
                goto label_34;
            }
            
            if(val_2 == 0)
            {
                    return;
            }
            
            do
            {
                var val_19 = val_27;
                do
            {
                val_19 = val_19 - 1;
            }
            while(s.bl_count[(long)val_19] == 0);
            
                short val_21 = s.bl_count[(long)val_19];
                val_19 = val_19 + 1;
                val_21 = val_21 + 65535;
                s.bl_count[(long)val_19] = val_21;
                val_18 = s.bl_count[(long)val_19] + 2;
                mem2[0] = val_18;
                val_16 = s.bl_count;
                val_19 = val_2 - 2;
                short val_23 = val_16[(long)val_27];
                val_23 = val_23 + 65535;
                val_16[(long)val_27] = val_23;
            }
            while(val_19 > 0);
            
            if(val_27 == 0)
            {
                    return;
            }
            
            label_62:
            short val_24 = s.bl_count[(long)val_27];
            val_18 = this.dyn_tree;
            label_61:
            val_16 = val_20;
            label_53:
            if(val_24 == 0)
            {
                goto label_50;
            }
            
            val_20 = val_20 - 1;
            int val_25 = s.heap[((long)(int)((((s.heap_max + 1) + 1) - 1))) << 2];
            if(val_25 > this.max_code)
            {
                goto label_53;
            }
            
            System.Int16[] val_7 = val_18 + 2;
            if(val_27 != ((this.dyn_tree + 2) + 32))
            {
                    val_25 = mem[this.dyn_tree + 24];
                val_25 = this.dyn_tree + 24;
                val_26 = s.opt_len;
                if(1 < val_25)
            {
                    val_27 = ((this.dyn_tree + 2) + 32) & 65535;
            }
            else
            {
                    val_26 = val_26;
                val_27 = mem[(this.dyn_tree + 2) + 32];
                val_27 = (this.dyn_tree + 2) + 32;
                val_25 = mem[this.dyn_tree + 24];
                val_25 = this.dyn_tree + 24;
            }
            
                if((val_25 << 1) >= val_25)
            {
                    val_26 = val_26;
            }
            
                System.Int16[] val_9 = val_18 + (((long)(int)((s.heap[((long)(int)((((s.heap_max + 1) + 1) - 1))) << 2][0] << 1))) << 1);
                int val_26 = (this.dyn_tree + ((long)(int)((s.heap[((long)(int)((((s.heap_max + 1) + 1) - 1))) << 2][0] << 1))) << 1) + 32;
                val_26 = val_26 + ((val_27 - val_27) * val_26);
                s.opt_len = val_26;
                mem2[0] = val_27;
            }
            
            val_24 = val_24 - 1;
            goto label_61;
            label_50:
            val_27 = val_27 - 1;
            val_20 = val_16;
            if(val_27 != 0)
            {
                goto label_62;
            }
            
            return;
            label_3:
            if(this.staticTree != null)
            {
                goto label_63;
            }
            
            if(this.staticTree != null)
            {
                goto label_64;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void build_tree(Ionic.Zlib.DeflateManager s)
        {
            System.Int16[] val_24;
            Ionic.Zlib.StaticTree val_25;
            int val_26;
            var val_27;
            var val_28;
            System.Int32[] val_29;
            int val_30;
            val_24 = this.dyn_tree;
            val_25 = this.staticTree;
            if(this.staticTree != null)
            {
                goto label_1;
            }
            
            val_25 = this.staticTree;
            if(val_25 == null)
            {
                goto label_2;
            }
            
            label_1:
            val_26 = this.staticTree.elems;
            s.heap_len = 0;
            val_27 = null;
            val_27 = null;
            s.heap_max = Ionic.Zlib.ZTree.Buf_size;
            if(val_26 <= 0)
            {
                goto label_6;
            }
            
            var val_30 = 0;
            int val_29 = 0;
            var val_31 = 1;
            label_18:
            var val_1 = val_31 - 1;
            if(val_24[0] == 0)
            {
                goto label_9;
            }
            
            if(s == null)
            {
                goto label_10;
            }
            
            val_29 = s.heap;
            val_30 = s.heap_len;
            goto label_11;
            label_9:
            var val_28 = 4294967296;
            val_28 = val_30 + val_28;
            val_24[val_28 >> 32] = 0;
            goto label_13;
            label_10:
            val_29 = s.heap;
            val_30 = s.heap_len;
            label_11:
            val_30 = val_30 + 1;
            s.heap_len = val_30;
            val_29[((long)(int)((s.heap_len + 1))) << 2] = val_29;
            val_28 = val_24[24];
            System.SByte[] val_3 = s.depth + val_29;
            mem2[0] = 0;
            val_26 = val_26;
            val_24 = val_24;
            label_13:
            val_29 = val_29 + 1;
            val_30 = val_30 + 8589934592;
            val_31 = val_31 + 2;
            if(val_26 != val_29)
            {
                goto label_18;
            }
            
            goto label_27;
            label_6:
            goto label_27;
            label_30:
            s.heap_len = 1;
            int val_4 = (0 >= 2) ? 0 : (0 + 1);
            int val_5 = (0 < 2) ? (0 + 1) : 0;
            s.heap[4] = val_4;
            var val_6 = val_4 << 1;
            val_24[(long)val_6] = 1;
            System.SByte[] val_7 = s.depth + (long)val_4;
            mem2[0] = 0;
            int val_32 = s.opt_len;
            val_32 = val_32 - 1;
            s.opt_len = val_32;
            if(this.staticTree.treeCodes != null)
            {
                    val_6 = (long)val_6 | 1;
                short val_33 = this.staticTree.treeCodes[(long)val_6];
                val_33 = s.static_len - val_33;
                s.static_len = val_33;
            }
            
            label_27:
            if(s.heap_len < 2)
            {
                goto label_30;
            }
            
            this.max_code = val_5;
            int val_34 = s.heap_len;
            if(val_34 >= 2)
            {
                    val_34 = val_34 >> 1;
                int val_8 = val_34 + 1;
                do
            {
                val_8 = val_8 - 1;
                s.pqdownheap(tree:  val_24, k:  val_8);
            }
            while(val_8 > 1);
            
            }
            
            int val_9 = val_26 << 1;
            do
            {
                int val_35 = s.heap[0];
                s.heap_len = s.heap_len - 1;
                s.heap[0] = s.heap[(s.heap_len) << 2];
                s.pqdownheap(tree:  val_24, k:  1);
                int val_37 = s.heap[0];
                s.heap_max = s.heap_max - 1;
                s.heap[((long)(int)((s.heap_max - 1))) << 2] = val_35;
                s.heap_max = s.heap_max - 1;
                s.heap[((long)(int)((s.heap_max - 1))) << 2] = val_37;
                short val_38 = val_24[(long)val_35 << 1];
                System.Int16[] val_40 = val_24;
                var val_39 = val_24[24];
                val_40 = val_40 + (((long)(int)((s.heap[0] << 1))) << 1);
                val_38 = ((this.dyn_tree + ((long)(int)((s.heap[0] << 1))) << 1) + 32) + val_38;
                System.Int16[] val_41 = val_24;
                val_41 = val_41 + (((long)(int)((this.staticTree.elems << 1))) << 1);
                mem2[0] = val_38;
                System.SByte[] val_15 = s.depth + (long)val_35;
                System.SByte[] val_16 = s.depth + (long)val_37;
                byte val_42 = (s.depth + (long)(int)(s.heap[0])) + 32;
                val_42 = ((System.Math.Max(val1:  (s.depth + (long)(int)(s.heap[0])) + 32, val2:  val_42)) & 255) + 1;
                System.SByte[] val_19 = s.depth + (long)val_26;
                mem2[0] = val_42;
                var val_20 = ((long)val_37 << 1) | 1;
                System.Int16[] val_21 = val_24 + (((long)(int)(((long)(int)((s.heap[0] << 1)) | 1))) << 1);
                mem2[0] = val_26;
                var val_22 = ((long)val_35 << 1) | 1;
                System.Int16[] val_23 = val_24 + (((long)(int)(((long)(int)((s.heap[0] << 1)) | 1))) << 1);
                mem2[0] = val_26;
                int val_24 = val_26 + 1;
                s.heap[0] = val_26;
                s.pqdownheap(tree:  val_24, k:  1);
                val_9 = val_9 + 2;
            }
            while(s.heap_len > 1);
            
            s.heap_max = s.heap_max - 1;
            s.heap[((long)(int)((s.heap_max - 1))) << 2] = s.heap[0];
            this.gen_bitlen(s:  s);
            Ionic.Zlib.ZTree.gen_codes(tree:  val_24, max_code:  val_5, bl_count:  s.bl_count);
            return;
            label_2:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static void gen_codes(short[] tree, int max_code, short[] bl_count)
        {
            var val_8;
            var val_9;
            var val_10;
            short val_11;
            var val_12;
            val_8 = 1152921505284747264;
            val_9 = null;
            val_9 = null;
            int val_1 = Ionic.Zlib.InternalConstants.MAX_BITS + 1;
            short[] val_2 = new short[0];
            val_10 = 0;
            val_11 = 0;
            goto label_3;
            label_10:
            val_11 = bl_count[0] + val_11;
            var val_4 = (W26 - 1) + 1;
            val_11 = val_11 << 1;
            val_10 = 1;
            val_2[(long)(long)(int)(W26)] = val_11;
            label_3:
            val_12 = null;
            val_12 = null;
            if((val_10 + 1) <= Ionic.Zlib.InternalConstants.MAX_BITS)
            {
                goto label_10;
            }
            
            if((max_code & 2147483648) != 0)
            {
                    return;
            }
            
            val_8 = 1152921505285226496;
            var val_13 = 0;
            do
            {
                short val_10 = tree[1];
                if(val_10 != 0)
            {
                    short val_11 = val_2[(long)val_10];
                val_2[(long)val_10] = val_11 + 1;
                var val_12 = 0;
                short val_7 = val_10 + 1;
                do
            {
                val_7 = val_7 - 1;
                val_10 = (val_11 & 1) | val_12;
                val_11 = val_11 >> 1;
                val_12 = val_10 << 1;
            }
            while(val_7 > 1);
            
                val_11 = 0;
                tree[val_11] = val_10;
            }
            
                val_13 = val_13 + 1;
            }
            while(val_13 <= max_code);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static int bi_reverse(int code, int len)
        {
            var val_3 = 0;
            do
            {
                len = len - 1;
                val_3 = (code & 1) | val_3;
                code = code >> 1;
                val_3 = val_3 << 1;
            }
            while(len > 0);
            
            return (int)val_3 >> 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ZTree()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static ZTree()
        {
            null = null;
            Ionic.Zlib.ZTree.Buf_size = 1;
            Ionic.Zlib.ZTree.ExtraLengthBits = new int[29] {0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 0};
            Ionic.Zlib.ZTree.ExtraDistanceBits = new int[30] {0, 0, 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13};
            Ionic.Zlib.ZTree.extra_blbits = new int[19] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 3, 7};
            Ionic.Zlib.ZTree.bl_order = new sbyte[19] {16, 17, 18, 0, 8, 7, 9, 6, 10, 5, 11, 4, 12, 3, 13, 2, 14, 1, 15};
            Ionic.Zlib.ZTree._dist_code = new sbyte[512] {0, 1, 2, 3, 4, 4, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 8, 8, 8, 8, 9, 9, 9, 9, 9, 9, 9, 9, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 0, 0, 16, 17, 18, 18, 19, 19, 20, 20, 20, 20, 21, 21, 21, 21, 22, 22, 22, 22, 22, 22, 22, 22, 23, 23, 23, 23, 23, 23, 23, 23, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29};
            Ionic.Zlib.ZTree.LengthCode = new sbyte[256] {0, 1, 2, 3, 4, 5, 6, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 12, 12, 13, 13, 13, 13, 14, 14, 14, 14, 15, 15, 15, 15, 16, 16, 16, 16, 16, 16, 16, 16, 17, 17, 17, 17, 17, 17, 17, 17, 18, 18, 18, 18, 18, 18, 18, 18, 19, 19, 19, 19, 19, 19, 19, 19, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 21, 21, 21, 21, 21, 21, 21, 21, 21, 21, 21, 21, 21, 21, 21, 21, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 28};
            Ionic.Zlib.ZTree.LengthBase = new int[29] {0, 1, 2, 3, 4, 5, 6, 7, 8, 10, 12, 14, 16, 20, 24, 28, 32, 40, 48, 56, 64, 80, 96, 112, 128, 160, 192, 224, 0};
            Ionic.Zlib.ZTree.DistanceBase = new int[30] {0, 1, 2, 3, 4, 6, 8, 12, 16, 24, 32, 48, 64, 96, 128, 192, 256, 384, 512, 768, 1024, 1536, 2048, 3072, 4096, 6144, 8192, 12288, 16384, 24576};
        }
    
    }

}
