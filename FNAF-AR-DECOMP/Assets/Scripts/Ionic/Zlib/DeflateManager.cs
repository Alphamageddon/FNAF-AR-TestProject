using UnityEngine;

namespace Ionic.Zlib
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal sealed class DeflateManager
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly int MEM_LEVEL_MAX;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly int MEM_LEVEL_DEFAULT;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Ionic.Zlib.DeflateManager.CompressFunc DeflateFunction;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string[] _ErrorMessage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly int PRESET_DICT;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly int INIT_STATE;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly int BUSY_STATE;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly int FINISH_STATE;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly int Z_DEFLATED;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly int STORED_BLOCK;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly int STATIC_TREES;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly int DYN_TREES;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly int Z_BINARY;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly int Z_ASCII;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly int Z_UNKNOWN;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly int Buf_size;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly int MIN_MATCH;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly int MAX_MATCH;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly int MIN_LOOKAHEAD;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly int HEAP_SIZE;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly int END_BLOCK;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal Ionic.Zlib.ZlibCodec _codec;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int status;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal byte[] pending;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int nextPending;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int pendingCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal sbyte data_type;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int last_flush;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int w_size;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int w_bits;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int w_mask;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal byte[] window;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int window_size;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal short[] prev;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal short[] head;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int ins_h;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int hash_size;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int hash_bits;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int hash_mask;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int hash_shift;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int block_start;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Ionic.Zlib.DeflateManager.Config config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int match_length;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int prev_match;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int match_available;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int strstart;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int match_start;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int lookahead;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int prev_length;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal Ionic.Zlib.CompressionLevel compressionLevel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal Ionic.Zlib.CompressionStrategy compressionStrategy;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal short[] dyn_ltree;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal short[] dyn_dtree;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal short[] bl_tree;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal Ionic.Zlib.ZTree treeLiterals;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal Ionic.Zlib.ZTree treeDistances;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal Ionic.Zlib.ZTree treeBitLengths;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal short[] bl_count;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int[] heap;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int heap_len;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int heap_max;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal sbyte[] depth;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int _lengthOffset;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int lit_bufsize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int last_lit;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int _distanceOffset;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int opt_len;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int static_len;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int matches;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int last_eob_len;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal short bi_buf;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int bi_valid;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool Rfc1950BytesEmitted;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _WantRfc1950HeaderBytes;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal bool WantRfc1950HeaderBytes { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal DeflateManager()
        {
            var val_12;
            var val_13;
            this.treeLiterals = new Ionic.Zlib.ZTree();
            this.treeDistances = new Ionic.Zlib.ZTree();
            this.treeBitLengths = new Ionic.Zlib.ZTree();
            val_12 = null;
            val_12 = null;
            int val_4 = Ionic.Zlib.InternalConstants.MAX_BITS + 1;
            this.bl_count = new short[0];
            this.heap = new int[1];
            this.depth = new sbyte[1];
            this._WantRfc1950HeaderBytes = true;
            val_13 = null;
            val_13 = null;
            int val_8 = Ionic.Zlib.DeflateManager.HEAP_SIZE << 1;
            this.dyn_ltree = new short[0];
            this.dyn_dtree = new short[2];
            this.bl_tree = new short[2];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void _InitializeLazyMatch()
        {
            var val_2;
            int val_2 = this.w_size;
            val_2 = val_2 << 1;
            this.window_size = val_2;
            System.Array.Clear(array:  this.head, index:  0, length:  this.hash_size);
            this.config = DeflateManager.Config.Lookup(level:  this.compressionLevel);
            this.SetDeflater();
            this.strstart = 0;
            this.block_start = 0;
            this.lookahead = 0;
            val_2 = null;
            val_2 = null;
            int val_3 = Ionic.Zlib.DeflateManager.MIN_MATCH;
            this.match_available = 0;
            this.ins_h = 0;
            val_3 = val_3 - 1;
            this.prev_length = val_3;
            this.match_length = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void _InitializeTreeData()
        {
            var val_1;
            this.treeLiterals.dyn_tree = this.dyn_ltree;
            val_1 = null;
            val_1 = null;
            this.treeLiterals.staticTree = Ionic.Zlib.StaticTree.Literals;
            this.treeDistances.dyn_tree = this.dyn_dtree;
            this.treeDistances.staticTree = Ionic.Zlib.StaticTree.Distances;
            this.treeBitLengths.dyn_tree = this.bl_tree;
            this.treeBitLengths.staticTree = Ionic.Zlib.StaticTree.BitLengths;
            this.bi_buf = 0;
            this.bi_valid = 0;
            this.last_eob_len = 8;
            this._InitializeBlocks();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void _InitializeBlocks()
        {
            var val_2;
            System.Int16[] val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_2 = 0;
            goto label_1;
            label_6:
            val_3 = this.dyn_ltree;
            val_2 = 1;
            val_3[0] = 0;
            label_1:
            val_4 = null;
            val_4 = null;
            if(val_2 < Ionic.Zlib.InternalConstants.L_CODES)
            {
                goto label_6;
            }
            
            val_5 = 0;
            goto label_7;
            label_12:
            val_3 = this.dyn_dtree;
            val_3[0] = 0;
            val_4 = null;
            val_5 = 1;
            label_7:
            val_4 = null;
            if(val_5 < Ionic.Zlib.InternalConstants.D_CODES)
            {
                goto label_12;
            }
            
            val_6 = 0;
            goto label_13;
            label_18:
            val_3 = this.bl_tree;
            val_3[0] = 0;
            val_4 = null;
            val_6 = 1;
            label_13:
            val_4 = null;
            if(val_6 < Ionic.Zlib.InternalConstants.BL_CODES)
            {
                goto label_18;
            }
            
            val_7 = null;
            val_7 = null;
            this.dyn_ltree[(long)Ionic.Zlib.DeflateManager.END_BLOCK << 1] = 1;
            this.opt_len = 0;
            this.static_len = 0;
            this.matches = 0;
            this.last_lit = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void pqdownheap(short[] tree, int k)
        {
            int val_7;
            var val_8;
            var val_9;
            int val_10;
            val_7 = (long)k;
            int val_5 = this.heap[((long)(int)(k)) << 2];
            val_8 = k << 1;
            if(val_8 > this.heap_len)
            {
                goto label_16;
            }
            
            label_20:
            if(val_8 < this.heap_len)
            {
                    var val_3 = ((Ionic.Zlib.DeflateManager._IsSmaller(tree:  tree, n:  this.heap[((long)(int)(((k << 1) | 1))) << 2], m:  this.heap[((long)(int)((k << 1))) << 2], depth:  this.depth)) != true) ? ((long)val_8 | 1) : (val_8);
            }
            else
            {
                    val_9 = val_8;
            }
            
            val_8 = (long)val_9;
            val_7 = this.heap[((long)(int)((k << 1))) << 2];
            if((Ionic.Zlib.DeflateManager._IsSmaller(tree:  tree, n:  val_5, m:  val_7, depth:  this.depth)) == true)
            {
                goto label_16;
            }
            
            val_7 = this.heap;
            val_10 = this.heap.Length;
            if(val_9 >= val_10)
            {
                    val_10 = this.heap.Length;
            }
            
            val_7[((long)(int)(k)) << 2] = val_7[((long)(int)((k << 1))) << 2];
            val_8 = val_9 << 1;
            if(val_8 <= this.heap_len)
            {
                goto label_20;
            }
            
            goto label_21;
            label_16:
            val_9 = k;
            label_21:
            this.heap[((long)(int)(k)) << 2] = val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth)
        {
            sbyte val_4;
            int val_5;
            var val_6;
            int val_7;
            val_4 = n;
            val_5 = tree.Length;
            int val_1 = val_4 << 1;
            if(val_1 >= val_5)
            {
                    val_5 = tree.Length;
            }
            
            short val_4 = tree[(long)val_1];
            short val_5 = tree[(long)m << 1];
            if(val_4 < val_5)
            {
                    val_6 = 1;
                return (bool)val_6;
            }
            
            if(val_4 == val_5)
            {
                    val_7 = depth.Length;
                if(val_7 <= val_4)
            {
                    val_7 = depth.Length;
            }
            
                val_4 = depth[(long)val_4];
                var val_3 = (val_4 <= depth[(long)m]) ? 1 : 0;
                return (bool)val_6;
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void scan_tree(short[] tree, int max_code)
        {
            int val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            val_13 = tree.Length;
            if(val_13 <= 1)
            {
                    val_13 = tree.Length;
            }
            
            short val_14 = tree[1];
            int val_1 = max_code << 1;
            val_1 = val_1 + 3;
            var val_2 = (val_14 != 0) ? (3 + 1) : 3;
            var val_17 = 0;
            tree[(long)val_1] = 32767;
            label_27:
            var val_16 = 0;
            var val_4 = 0 + 3;
            label_7:
            if((val_17 + val_16) > max_code)
            {
                    return;
            }
            
            short val_15 = tree[(long)val_4];
            val_16 = val_16 + 1;
            if(val_16 >= ((val_14 == 0) ? 138 : 7))
            {
                goto label_6;
            }
            
            val_4 = val_4 + 2;
            if(val_14 == val_15)
            {
                goto label_7;
            }
            
            label_6:
            val_17 = val_17 + val_16;
            if(val_16 >= val_2)
            {
                goto label_8;
            }
            
            var val_18 = mem[1152921525530109128];
            val_14 = mem[mem[1152921525530109128] + 24];
            val_14 = mem[1152921525530109128] + 24;
            if(val_2 >= val_14)
            {
                    val_14 = mem[mem[1152921525530109128] + 24];
                val_14 = mem[1152921525530109128] + 24;
            }
            
            val_18 = val_18 + ((tree[1] != 0 ? (3 + 1) : 3) << 1);
            mem2[0] = ((mem[1152921525530109128] + (tree[1] != 0 ? (3 + 1) : 3) << 1) + 32) + val_16;
            goto label_12;
            label_8:
            if(val_14 == 0)
            {
                goto label_13;
            }
            
            if(val_14 != 0)
            {
                    var val_7 = mem[1152921525530109128] + ((tree[1] != 0 ? (3 + 1) : 3) << 1);
                var val_19 = (mem[1152921525530109128] + (tree[1] != 0 ? (3 + 1) : 3) << 1) + 32;
                val_19 = val_19 + 1;
                mem2[0] = val_19;
            }
            
            val_15 = null;
            val_15 = null;
            int val_8 = Ionic.Zlib.InternalConstants.REP_3_6 << 1;
            val_16 = mem[1152921525530109128] + (((long)(int)((Ionic.Zlib.InternalConstants.REP_3_6 << 1))) << 1);
            val_17 = mem[(mem[1152921525530109128] + ((long)(int)((Ionic.Zlib.InternalConstants.REP_3_6 << 1))) << 1) + 32];
            val_17 = (mem[1152921525530109128] + ((long)(int)((Ionic.Zlib.InternalConstants.REP_3_6 << 1))) << 1) + 32;
            goto label_21;
            label_13:
            val_18 = null;
            if((val_16 - 1) <= 9)
            {
                goto label_22;
            }
            
            val_19 = null;
            if(mem[1152921525530109128] != 0)
            {
                goto label_30;
            }
            
            label_31:
            label_30:
            int val_10 = Ionic.Zlib.InternalConstants.REPZ_11_138 << 1;
            val_16 = mem[1152921525530109128] + (((long)(int)((Ionic.Zlib.InternalConstants.REPZ_11_138 << 1))) << 1);
            val_17 = mem[(mem[1152921525530109128] + ((long)(int)((Ionic.Zlib.InternalConstants.REPZ_11_138 << 1))) << 1) + 32];
            val_17 = (mem[1152921525530109128] + ((long)(int)((Ionic.Zlib.InternalConstants.REPZ_11_138 << 1))) << 1) + 32;
            label_21:
            val_17 = val_17 + 1;
            mem2[0] = val_17;
            label_12:
            var val_12 = (val_14 != val_15) ? (3 + 1) : 3;
            var val_13 = (val_15 == 0) ? 138 : ((val_14 != val_15) ? (6 + 1) : 6);
            goto label_27;
            label_22:
            val_20 = null;
            if(mem[1152921525530109128] != 0)
            {
                goto label_30;
            }
            
            goto label_31;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int build_bl_tree()
        {
            var val_6;
            var val_7;
            this.scan_tree(tree:  this.dyn_ltree, max_code:  this.treeLiterals.max_code);
            this.scan_tree(tree:  this.dyn_dtree, max_code:  this.treeDistances.max_code);
            this.treeBitLengths.build_tree(s:  this);
            val_6 = null;
            val_6 = null;
            int val_6 = Ionic.Zlib.InternalConstants.BL_CODES;
            int val_2 = val_6 - 1;
            val_6 = (val_6 + (val_6 << 1)) + 14;
            label_13:
            if(val_2 <= 2)
            {
                goto label_6;
            }
            
            val_7 = null;
            val_7 = null;
            System.SByte[] val_3 = Ionic.Zlib.ZTree.bl_order + (long)val_2;
            int val_4 = val_6 - 3;
            int val_5 = val_2 - 1;
            if(this.bl_tree[1] == 0)
            {
                goto label_13;
            }
            
            label_6:
            int val_8 = this.opt_len;
            val_8 = val_8 + val_6;
            this.opt_len = val_8;
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void send_all_trees(int lcodes, int dcodes, int blcodes)
        {
            var val_3;
            var val_4;
            int val_3 = dcodes;
            lcodes = lcodes - 257;
            this.send_bits(value:  lcodes, length:  5);
            val_3 = val_3 - 1;
            this.send_bits(value:  val_3, length:  5);
            this.send_bits(value:  blcodes - 4, length:  4);
            if(blcodes >= 1)
            {
                    do
            {
                val_4 = null;
                val_4 = null;
                this.send_bits(value:  this.bl_tree[1], length:  3);
                val_3 = 0 + 1;
            }
            while(blcodes != val_3);
            
            }
            
            this.send_tree(tree:  this.dyn_ltree, max_code:  lcodes - 1);
            this.send_tree(tree:  this.dyn_dtree, max_code:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void send_tree(short[] tree, int max_code)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            int val_11;
            var val_12;
            short val_13 = tree[1];
            var val_16 = 0;
            label_15:
            var val_15 = 10;
            var val_3 = 0 + 3;
            label_7:
            var val_4 = val_16 + val_15;
            val_4 = val_4 + 11;
            var val_17 = 0;
            if(val_4 > max_code)
            {
                    return;
            }
            
            short val_14 = tree[(long)val_3];
            val_15 = val_15 + 1;
            if((val_15 + 12) >= ((val_13 == 0) ? 138 : 7))
            {
                goto label_6;
            }
            
            val_3 = val_3 + 2;
            var val_6 = val_17 - 1;
            if(val_13 == val_14)
            {
                goto label_7;
            }
            
            label_6:
            val_6 = val_15 + 11;
            val_16 = (val_16 + val_15) + 11;
            if(val_6 >= ((val_13 != 0) ? (3 + 1) : 3))
            {
                goto label_8;
            }
            
            do
            {
                this.send_code(c:  val_13, tree:  this.bl_tree);
                val_17 = val_17 + 1;
            }
            while(val_17 != 0);
            
            goto label_10;
            label_8:
            var val_8 = val_15 + 10;
            if(val_13 == 0)
            {
                goto label_11;
            }
            
            if(val_13 != 0)
            {
                    this.send_code(c:  val_13, tree:  this.bl_tree);
                val_6 = val_8;
            }
            
            val_7 = null;
            val_7 = null;
            this.send_code(c:  Ionic.Zlib.InternalConstants.REP_3_6, tree:  this.bl_tree);
            this.send_bits(value:  val_6 - 3, length:  2);
            label_10:
            label_22:
            var val_11 = (val_13 != val_14) ? (3 + 1) : 3;
            var val_12 = (val_14 == 0) ? 138 : ((val_13 != val_14) ? (6 + 1) : 6);
            goto label_15;
            label_11:
            val_8 = null;
            if(val_8 > 9)
            {
                    val_9 = null;
                this.send_code(c:  Ionic.Zlib.InternalConstants.REPZ_11_138, tree:  this.bl_tree);
                val_10 = 7;
                val_11 = val_15;
            }
            else
            {
                    val_12 = null;
                this.send_code(c:  Ionic.Zlib.InternalConstants.REPZ_3_10, tree:  this.bl_tree);
                val_11 = val_15 + 8;
                val_10 = 3;
            }
            
            this.send_bits(value:  val_11, length:  3);
            goto label_22;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void put_bytes(byte[] p, int start, int len)
        {
            System.Array.Copy(sourceArray:  p, sourceIndex:  start, destinationArray:  this.pending, destinationIndex:  this.pendingCount, length:  len);
            int val_1 = this.pendingCount;
            val_1 = val_1 + len;
            this.pendingCount = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void send_code(int c, short[] tree)
        {
            int val_3;
            int val_1 = c << 1;
            val_3 = tree.Length;
            if(val_1 >= val_3)
            {
                    val_3 = tree.Length;
            }
            
            this.send_bits(value:  tree[(long)val_1], length:  tree[(long)val_1 | 1]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void send_bits(int value, int length)
        {
            short val_6;
            var val_7;
            int val_8;
            int val_1 = this.bi_valid & 31;
            val_1 = value << val_1;
            int val_5 = Ionic.Zlib.DeflateManager.Buf_size;
            val_6 = val_1 | this.bi_buf;
            this.bi_buf = val_6;
            val_5 = val_5 - length;
            if(this.bi_valid > val_5)
            {
                    this.pendingCount = this.pendingCount + 1;
                this.pending[this.pendingCount] = val_6;
                val_6 = this.pendingCount;
                this.pendingCount = val_6 + 1;
                this.pending[val_6] = this.bi_buf >> 8;
                val_7 = null;
                val_7 = null;
                int val_7 = this.bi_valid;
                int val_6 = Ionic.Zlib.DeflateManager.Buf_size;
                val_6 = val_6 - val_7;
                val_6 = val_6 & 31;
                val_6 = value >> val_6;
                this.bi_buf = val_6;
                val_7 = val_7 + length;
                val_8 = val_7 - Ionic.Zlib.DeflateManager.Buf_size;
            }
            else
            {
                    val_8 = this.bi_valid + length;
            }
            
            this.bi_valid = val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void _tr_align()
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            val_3 = null;
            val_3 = null;
            this.send_bits(value:  Ionic.Zlib.DeflateManager.STATIC_TREES << 1, length:  3);
            val_4 = null;
            val_4 = null;
            this.send_code(c:  Ionic.Zlib.DeflateManager.END_BLOCK, tree:  Ionic.Zlib.StaticTree.lengthAndLiteralsTreeCodes);
            this.bi_flush();
            int val_3 = this.last_eob_len;
            val_3 = val_3 + 11;
            val_3 = val_3 - this.bi_valid;
            if(val_3 <= 8)
            {
                    val_5 = null;
                val_5 = null;
                this.send_bits(value:  Ionic.Zlib.DeflateManager.STATIC_TREES << 1, length:  3);
                val_6 = null;
                val_6 = null;
                this.send_code(c:  Ionic.Zlib.DeflateManager.END_BLOCK, tree:  Ionic.Zlib.StaticTree.lengthAndLiteralsTreeCodes);
                this.bi_flush();
            }
            
            this.last_eob_len = 7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal bool _tr_tally(int dist, int lc)
        {
            var val_18;
            var val_19;
            int val_20;
            var val_21;
            int val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            int val_18 = dist;
            this.pending[(long)this._distanceOffset + (this.last_lit << 1)] = val_18 >> 8;
            int val_3 = this._distanceOffset + (this.last_lit << 1);
            val_3 = val_3 + 1;
            this.pending[(long)val_3] = val_18;
            this.pending[(long)this.last_lit + this._lengthOffset] = lc;
            int val_16 = this.last_lit;
            val_16 = val_16 + 1;
            this.last_lit = val_16;
            if(val_18 == 0)
            {
                goto label_7;
            }
            
            int val_17 = this.matches;
            val_17 = val_17 + 1;
            this.matches = val_17;
            val_18 = null;
            val_18 = null;
            System.SByte[] val_5 = Ionic.Zlib.ZTree.LengthCode + (long)lc;
            val_19 = null;
            val_19 = null;
            val_18 = val_18 - 1;
            val_20 = Ionic.Zlib.InternalConstants.LITERALS;
            int val_6 = val_20 + ((Ionic.Zlib.ZTree.LengthCode + (long)(int)(lc)) + 32);
            val_6 = val_6 << 1;
            val_6 = val_6 + 2;
            short val_19 = this.dyn_ltree[(long)val_6];
            val_19 = val_19 + 1;
            this.dyn_ltree[(long)val_6] = val_19;
            val_21 = Ionic.Zlib.ZTree.DistanceCode(dist:  val_18);
            if(this.dyn_dtree != null)
            {
                goto label_33;
            }
            
            label_34:
            label_33:
            short val_20 = this.dyn_dtree[(long)val_21 << 1];
            val_20 = val_20 + 1;
            this.dyn_dtree[(long)val_21 << 1] = val_20;
            val_22 = this.last_lit;
            if(((val_22 & 8191) != 0) || (this.compressionLevel < 3))
            {
                goto label_31;
            }
            
            val_20 = 0;
            val_23 = 0;
            val_21 = val_22 << 3;
            goto label_20;
            label_29:
            val_24 = null;
            val_24 = null;
            var val_22 = Ionic.Zlib.ZTree.ExtraDistanceBits.Length + 32;
            val_23 = 1;
            val_20 = 2;
            val_22 = val_22 + 5;
            val_21 = val_21 + (val_22 * this.dyn_dtree[0]);
            label_20:
            val_25 = null;
            val_25 = null;
            if(val_23 < Ionic.Zlib.InternalConstants.D_CODES)
            {
                goto label_29;
            }
            
            val_22 = this.last_lit;
            if(this.matches < (((val_22 < 0) ? (val_22 + 1) : (val_22)) >> 1))
            {
                    int val_23 = this.strstart;
                val_23 = val_23 - this.block_start;
                if((val_21 >> 3) < (((val_23 < 0) ? (val_23 + 1) : (val_23)) >> 1))
            {
                    val_26 = 1;
                return (bool)val_26;
            }
            
            }
            
            label_31:
            val_26 = ((val_22 == this.lit_bufsize) ? 1 : 0) | ((val_22 == (this.lit_bufsize - 1)) ? 1 : 0);
            return (bool)val_26;
            label_7:
            if(this.dyn_ltree != null)
            {
                goto label_33;
            }
            
            goto label_34;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void send_compressed_block(short[] ltree, short[] dtree)
        {
            System.Byte[] val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            System.Int16[] val_22;
            if(this.last_lit == 0)
            {
                goto label_1;
            }
            
            var val_19 = 0;
            var val_21 = 1;
            label_32:
            val_16 = this.pending;
            byte val_16 = this.pending[(long)(val_21 + this._distanceOffset) - 1];
            byte val_17 = val_16[(long)val_21 + this._distanceOffset];
            byte val_18 = this.pending[(long)val_19 + this._lengthOffset];
            val_19 = val_19 + 1;
            if(val_17 == 0)
            {
                goto label_8;
            }
            
            val_17 = null;
            val_17 = null;
            val_18 = null;
            System.SByte[] val_5 = Ionic.Zlib.ZTree.LengthCode + val_18;
            val_18 = null;
            int val_20 = Ionic.Zlib.InternalConstants.LITERALS;
            val_20 = ((Ionic.Zlib.ZTree.LengthCode + this.pending[(long)(int)((0 + this._lengthOffset))][0]) + 32) + val_20;
            this.send_code(c:  val_20 + 1, tree:  ltree);
            System.Int32[] val_7 = Ionic.Zlib.ZTree.ExtraLengthBits + (((long)(int)((Ionic.Zlib.ZTree.LengthCode + this.pending[(long)(int)((0 + this._lengthOffset))][0]) + 32)) << 2);
            if(((Ionic.Zlib.ZTree.ExtraLengthBits + ((long)(int)((Ionic.Zlib.ZTree.LengthCode + this.pending[(long)(int)((0 + this._lengthOffset))][0]) + 32)) << 2) + 32) != 0)
            {
                    val_19 = null;
                val_19 = null;
                System.Int32[] val_8 = Ionic.Zlib.ZTree.LengthBase + (((long)(int)((Ionic.Zlib.ZTree.LengthCode + this.pending[(long)(int)((0 + this._lengthOffset))][0]) + 32)) << 2);
                this.send_bits(value:  val_18 - ((Ionic.Zlib.ZTree.LengthBase + ((long)(int)((Ionic.Zlib.ZTree.LengthCode + this.pending[(long)(int)((0 + this._lengthOffset))][0]) + 32)) << 2) + 32), length:  (Ionic.Zlib.ZTree.ExtraLengthBits + ((long)(int)((Ionic.Zlib.ZTree.LengthCode + this.pending[(long)(int)((0 + this._lengthOffset))][0]) + 32)) << 2) + 32);
            }
            
            byte val_10 = val_17 - 1;
            val_16 = Ionic.Zlib.ZTree.DistanceCode(dist:  val_10);
            this.send_code(c:  val_16, tree:  dtree);
            System.Int32[] val_12 = Ionic.Zlib.ZTree.ExtraDistanceBits + (((long)(int)(val_11)) << 2);
            if(((Ionic.Zlib.ZTree.ExtraDistanceBits + ((long)(int)(val_11)) << 2) + 32) == 0)
            {
                goto label_31;
            }
            
            val_20 = null;
            val_20 = null;
            System.Int32[] val_13 = Ionic.Zlib.ZTree.DistanceBase + (((long)(int)(val_11)) << 2);
            this.send_bits(value:  val_10 - ((Ionic.Zlib.ZTree.DistanceBase + ((long)(int)(val_11)) << 2) + 32), length:  (Ionic.Zlib.ZTree.ExtraDistanceBits + ((long)(int)(val_11)) << 2) + 32);
            goto label_31;
            label_8:
            this.send_code(c:  val_18, tree:  ltree);
            label_31:
            val_21 = val_21 + 2;
            if(val_19 < this.last_lit)
            {
                goto label_32;
            }
            
            label_1:
            val_21 = null;
            val_22 = ltree;
            this.send_code(c:  Ionic.Zlib.DeflateManager.END_BLOCK, tree:  null);
            System.Int16[] val_15 =  + 2;
            this.last_eob_len = (ltree + 2) + 32;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void set_data_type()
        {
            var val_1;
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            sbyte val_7;
            var val_8;
            var val_3 = 0;
            do
            {
                val_3 = val_3 + 2;
                val_1 = 0 + this.dyn_ltree[val_3];
            }
            while(val_3 != 14);
            
            var val_6 = 0;
            var val_5 = 30;
            do
            {
                var val_1 = val_5 - 16;
                val_5 = val_5 + 2;
                val_6 = val_6 + this.dyn_ltree[14];
            }
            while(val_5 != 272);
            
            val_6 = val_6 >> 2;
            val_2 = 128;
            val_3 = 256;
            goto label_7;
            label_12:
            val_2 = 129;
            val_3 = 258;
            val_1 = val_1 + this.dyn_ltree[256];
            label_7:
            val_4 = null;
            val_4 = null;
            if(val_2 < Ionic.Zlib.InternalConstants.LITERALS)
            {
                goto label_12;
            }
            
            val_5 = null;
            if(val_1 > val_6)
            {
                    val_6 = null;
                val_7 = 1152921505283633200;
            }
            else
            {
                    val_8 = null;
                val_7 = 1152921505283633204;
            }
            
            this.data_type = val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void bi_flush()
        {
            System.Byte[] val_6;
            int val_7;
            if(this.bi_valid == 16)
            {
                    this.pendingCount = this.pendingCount + 1;
                this.pending[this.pendingCount] = this.bi_buf;
                val_6 = this.pending;
                this.pendingCount = this.pendingCount + 1;
                val_7 = 0;
                val_6[this.pendingCount] = this.bi_buf >> 8;
                this.bi_buf = 0;
            }
            else
            {
                    if(this.bi_valid < 8)
            {
                    return;
            }
            
                val_6 = this.pending;
                this.pendingCount = this.pendingCount + 1;
                val_6[this.pendingCount] = this.bi_buf;
                short val_5 = this.bi_buf;
                val_5 = val_5 >> 8;
                this.bi_buf = val_5;
                val_7 = this.bi_valid - 8;
            }
            
            this.bi_valid = val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void bi_windup()
        {
            int val_4;
            System.Byte[] val_5;
            short val_6;
            if(this.bi_valid >= 9)
            {
                goto label_0;
            }
            
            if(this.bi_valid < 1)
            {
                goto label_1;
            }
            
            val_4 = this.pendingCount;
            val_5 = this.pending;
            val_6 = this.bi_buf;
            this.pendingCount = val_4 + 1;
            if(val_4 < this.pending.Length)
            {
                goto label_4;
            }
            
            goto label_4;
            label_0:
            this.pendingCount = this.pendingCount + 1;
            this.pending[this.pendingCount] = this.bi_buf;
            val_4 = this.pendingCount;
            val_5 = this.pending;
            this.pendingCount = val_4 + 1;
            val_6 = this.bi_buf >> 8;
            label_4:
            val_5[val_4] = val_6;
            label_1:
            this.bi_buf = 0;
            this.bi_valid = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void copy_block(int buf, int len, bool header)
        {
            this.bi_windup();
            this.last_eob_len = 8;
            if(header != false)
            {
                    this.pendingCount = this.pendingCount + 1;
                this.pending[this.pendingCount] = len;
                this.pendingCount = this.pendingCount + 1;
                this.pending[this.pendingCount] = len >> 8;
                this.pendingCount = this.pendingCount + 1;
                this.pending[this.pendingCount] = ~len;
                this.pendingCount = this.pendingCount + 1;
                this.pending[this.pendingCount] = (~len) >> 8;
            }
            
            System.Array.Copy(sourceArray:  this.window, sourceIndex:  buf, destinationArray:  this.pending, destinationIndex:  this.pendingCount, length:  len);
            int val_7 = this.pendingCount;
            val_7 = val_7 + len;
            this.pendingCount = val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void flush_block_only(bool eof)
        {
            this._tr_flush_block(buf:  (this.block_start >= 0) ? this.block_start : (!0), stored_len:  this.strstart - this.block_start, eof:  eof);
            this.block_start = this.strstart;
            this._codec.flush_pending();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal Ionic.Zlib.BlockState DeflateNone(Ionic.Zlib.FlushType flush)
        {
            var val_9;
            int val_10;
            int val_11;
            int val_12;
            Ionic.Zlib.ZlibCodec val_13;
            var val_14;
            var val_15;
            int val_7 = this.pending.Length;
            val_7 = val_7 - 5;
            if(val_7 > 65534)
            {
                    val_9 = 65535;
            }
            else
            {
                    val_9 = this.pending.Length - 5;
            }
            
            label_15:
            val_10 = this.lookahead;
            if(val_10 > 1)
            {
                goto label_5;
            }
            
            this._fillWindow();
            val_10 = this.lookahead;
            if(val_10 == 0)
            {
                goto label_6;
            }
            
            label_5:
            int val_8 = this.strstart;
            val_11 = this.block_start;
            this.lookahead = 0;
            val_12 = val_10 + val_8;
            int val_1 = val_11 + val_9;
            this.strstart = val_12;
            if(val_12 != 0)
            {
                    if(val_12 < val_1)
            {
                goto label_8;
            }
            
            }
            
            val_8 = val_12 - val_1;
            this.lookahead = val_8;
            this.strstart = val_1;
            this.flush_block_only(eof:  false);
            val_13 = this._codec;
            if(this._codec.AvailableBytesOut == 0)
            {
                goto label_17;
            }
            
            val_12 = this.strstart;
            val_11 = this.block_start;
            label_8:
            val_14 = null;
            val_14 = null;
            int val_9 = Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD;
            val_9 = this.w_size - val_9;
            if((val_12 - val_11) < val_9)
            {
                goto label_15;
            }
            
            this.flush_block_only(eof:  false);
            val_13 = this._codec;
            if(this._codec.AvailableBytesOut != 0)
            {
                goto label_15;
            }
            
            goto label_17;
            label_6:
            if(flush == 0)
            {
                goto label_17;
            }
            
            this.flush_block_only(eof:  (flush == 4) ? 1 : 0);
            if(this._codec.AvailableBytesOut == 0)
            {
                goto label_19;
            }
            
            var val_4 = (flush == 4) ? 3 : (0 + 1);
            return (Ionic.Zlib.BlockState)val_15;
            label_17:
            val_15 = 0;
            return (Ionic.Zlib.BlockState)val_15;
            label_19:
            var val_6 = ((flush == 4) ? 1 : 0) << 1;
            return (Ionic.Zlib.BlockState)val_15;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void _tr_stored_block(int buf, int stored_len, bool eof)
        {
            null = null;
            this.send_bits(value:  (Ionic.Zlib.DeflateManager.STORED_BLOCK << 1) | eof, length:  3);
            this.copy_block(buf:  buf, len:  stored_len, header:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void _tr_flush_block(int buf, int stored_len, bool eof)
        {
            int val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            System.Int16[] val_19;
            System.Int16[] val_20;
            var val_21;
            val_11 = stored_len;
            if(this.compressionLevel >= 1)
            {
                    val_12 = null;
                val_12 = null;
                if(Ionic.Zlib.DeflateManager.Z_UNKNOWN == this.data_type)
            {
                    this.set_data_type();
            }
            
                this.treeLiterals.build_tree(s:  this);
                this.treeDistances.build_tree(s:  this);
                val_13 = this.build_bl_tree() + 1;
                int val_2 = this.opt_len + 10;
                val_14 = (this.static_len + 10) >> 3;
                var val_5 = (val_14 > (val_2 >> 3)) ? (val_2 >> 3) : (val_14);
            }
            else
            {
                    val_14 = val_11 + 5;
                val_13 = 1;
                val_15 = val_14;
            }
            
            if((buf != 1) && ((val_11 + 4) <= val_15))
            {
                    eof = eof;
                this._tr_stored_block(buf:  buf, stored_len:  val_11, eof:  eof);
            }
            else
            {
                    val_16 = null;
                if(val_14 == val_15)
            {
                    val_17 = null;
                this.send_bits(value:  eof, length:  3);
                val_11 = 1152921505284800512;
                val_18 = null;
                val_18 = null;
                val_19 = Ionic.Zlib.StaticTree.lengthAndLiteralsTreeCodes;
                val_20 = Ionic.Zlib.StaticTree.distTreeCodes;
            }
            else
            {
                    val_21 = null;
                this.send_bits(value:  eof, length:  3);
                val_11 = this.treeLiterals.max_code;
                this.send_all_trees(lcodes:  val_11 + 1, dcodes:  this.treeDistances.max_code + 1, blcodes:  1);
                val_19 = this.dyn_ltree;
                val_20 = this.dyn_dtree;
            }
            
                this.send_compressed_block(ltree:  val_19, dtree:  val_20);
            }
            
            this._InitializeBlocks();
            if(eof == false)
            {
                    return;
            }
            
            this.bi_windup();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void _fillWindow()
        {
            int val_11;
            var val_12;
            int val_13;
            Ionic.Zlib.ZlibCodec val_14;
            var val_15;
            label_33:
            int val_10 = this.window_size;
            int val_11 = this.lookahead;
            val_10 = val_10 - val_11;
            val_11 = val_10 - this.strstart;
            if(val_11 == 1)
            {
                goto label_1;
            }
            
            if(val_11 != 0)
            {
                goto label_2;
            }
            
            val_11 = this.strstart | val_11;
            if(val_11 == 0)
            {
                goto label_3;
            }
            
            label_2:
            val_12 = null;
            val_12 = null;
            int val_12 = Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD;
            val_12 = (this.w_size << 1) - val_12;
            if(this.strstart < val_12)
            {
                goto label_18;
            }
            
            System.Array.Copy(sourceArray:  this.window, sourceIndex:  this.w_size, destinationArray:  this.window, destinationIndex:  0, length:  this.w_size);
            int val_14 = this.strstart;
            int val_13 = this.match_start;
            int val_15 = this.w_size;
            val_13 = val_13 - val_15;
            val_14 = val_14 - val_15;
            val_15 = this.block_start - val_15;
            int val_2 = this.hash_size - 1;
            this.strstart = val_14;
            this.match_start = val_13;
            this.block_start = val_15;
            do
            {
                short val_16 = this.head[(long)val_2];
                val_16 = (this.w_size > val_16) ? 0 : (val_16 - this.w_size);
                val_2 = val_2 - 1;
                this.head[(long)val_2] = val_16;
            }
            while(val_2 != 1);
            
            int val_4 = this.w_size - 1;
            do
            {
                short val_17 = this.prev[(long)val_4];
                val_17 = (this.w_size > val_17) ? 0 : (val_17 - this.w_size);
                val_4 = val_4 - 1;
                this.prev[(long)val_4] = val_17;
            }
            while(val_4 != 1);
            
            val_11 = this.w_size + val_11;
            goto label_18;
            label_1:
            val_11 = -2;
            goto label_18;
            label_3:
            val_11 = this.w_size;
            label_18:
            val_14 = this._codec;
            if(this._codec.AvailableBytesIn == 0)
            {
                    return;
            }
            
            val_14 = this._codec;
            val_13 = this.lookahead;
            val_11 = this.lookahead + (val_14.read_buf(buf:  this.window, start:  val_13 + this.strstart, size:  val_11));
            this.lookahead = val_11;
            val_15 = null;
            val_15 = null;
            if(val_11 >= Ionic.Zlib.DeflateManager.MIN_MATCH)
            {
                    val_14 = this.hash_shift;
                byte val_18 = this.window[this.strstart];
                this.ins_h = val_18;
                byte val_19 = this.window[(long)this.strstart + 1];
                int val_9 = val_14 & 31;
                val_9 = val_18 << val_9;
                val_19 = val_9 ^ val_19;
                val_19 = val_19 & this.hash_mask;
                this.ins_h = val_19;
                val_15 = null;
            }
            
            val_15 = null;
            if(this.lookahead >= Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD)
            {
                    return;
            }
            
            if(this._codec.AvailableBytesIn != 0)
            {
                goto label_33;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal Ionic.Zlib.BlockState DeflateFast(Ionic.Zlib.FlushType flush)
        {
            short val_21;
            int val_22;
            int val_23;
            int val_24;
            int val_25;
            var val_26;
            var val_27;
            int val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            val_21 = 0;
            goto label_60;
            label_72:
            val_22 = this.lookahead;
            if(val_22 != 0)
            {
                goto label_2;
            }
            
            goto label_3;
            label_68:
            val_22 = this.lookahead;
            label_2:
            val_23 = Ionic.Zlib.DeflateManager.MIN_MATCH;
            if(val_22 >= val_23)
            {
                    int val_21 = this.ins_h;
                int val_1 = this.strstart + val_23;
                val_1 = val_1 - 1;
                byte val_20 = this.window[(long)val_1];
                int val_2 = this.hash_shift & 31;
                val_2 = val_21 << val_2;
                val_20 = val_2 ^ val_20;
                val_21 = val_20 & this.hash_mask;
                this.ins_h = val_21;
                val_21 = this.head[(long)val_21];
                val_24 = this.ins_h;
                this.prev[(long)this.w_mask & this.strstart] = this.head[val_24];
                val_25 = this.ins_h;
                val_23 = this.strstart;
                this.head[val_25] = val_23;
            }
            
            if(val_21 != 0)
            {
                    val_26 = null;
                val_25 = this.w_size;
                val_26 = null;
                int val_4 = this.strstart - val_21;
                val_4 = val_4 & 65535;
                int val_23 = Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD;
                val_23 = val_25 - val_23;
                if((val_4 <= val_23) && (this.compressionStrategy != 2))
            {
                    this.match_length = this.longest_match(cur_match:  val_21);
            }
            
            }
            
            val_27 = null;
            val_27 = null;
            val_28 = Ionic.Zlib.DeflateManager.MIN_MATCH;
            if(this.match_length >= val_28)
            {
                goto label_26;
            }
            
            int val_25 = this.lookahead;
            int val_26 = this.strstart;
            val_25 = val_25 - 1;
            val_26 = val_26 + 1;
            this.lookahead = val_25;
            this.strstart = val_26;
            if((this._tr_tally(dist:  0, lc:  this.window[this.strstart])) == false)
            {
                goto label_60;
            }
            
            goto label_43;
            label_26:
            val_28 = Ionic.Zlib.DeflateManager.MIN_MATCH;
            bool val_9 = this._tr_tally(dist:  this.strstart - this.match_start, lc:  this.match_length - val_28);
            int val_27 = this.lookahead;
            val_27 = val_27 - this.match_length;
            this.lookahead = val_27;
            if(this.match_length > this.config.MaxLazy)
            {
                goto label_34;
            }
            
            val_29 = null;
            val_29 = null;
            if(this.lookahead >= Ionic.Zlib.DeflateManager.MIN_MATCH)
            {
                goto label_37;
            }
            
            label_34:
            this.match_length = 0;
            int val_10 = this.match_length + this.strstart;
            this.strstart = val_10;
            val_23 = this.hash_shift;
            byte val_28 = this.window[(long)val_10];
            this.ins_h = val_28;
            val_24 = (long)this.strstart + 1;
            byte val_29 = this.window[val_24];
            int val_12 = val_23 & 31;
            val_12 = val_28 << val_12;
            val_29 = val_12 ^ val_29;
            val_29 = val_29 & this.hash_mask;
            this.ins_h = val_29;
            if(val_9 == false)
            {
                goto label_60;
            }
            
            goto label_43;
            label_37:
            int val_30 = this.match_length;
            val_30 = val_30 - 1;
            this.match_length = val_30;
            goto label_44;
            label_57:
            val_29 = null;
            label_44:
            int val_32 = this.ins_h;
            this.strstart = this.strstart + 1;
            val_29 = null;
            byte val_31 = this.window[(long)Ionic.Zlib.DeflateManager.MIN_MATCH + this.strstart];
            int val_15 = this.hash_shift & 31;
            val_15 = val_32 << val_15;
            val_31 = val_15 ^ val_31;
            val_32 = val_31 & this.hash_mask;
            this.ins_h = val_32;
            val_21 = this.head[(long)val_32];
            val_24 = this.head[this.ins_h];
            this.prev[(long)this.w_mask & this.strstart] = val_24;
            val_23 = this.ins_h;
            this.head[val_23] = this.strstart;
            int val_33 = this.match_length;
            val_33 = val_33 - 1;
            this.match_length = val_33;
            if(val_33 != 0)
            {
                goto label_57;
            }
            
            int val_34 = this.strstart;
            val_34 = val_34 + 1;
            this.strstart = val_34;
            if(val_9 == false)
            {
                goto label_60;
            }
            
            label_43:
            this.flush_block_only(eof:  false);
            if(this._codec.AvailableBytesOut != 0)
            {
                goto label_60;
            }
            
            goto label_61;
            label_60:
            val_31 = null;
            val_31 = null;
            if(this.lookahead >= Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD)
            {
                goto label_68;
            }
            
            this._fillWindow();
            val_30 = null;
            if((flush != 0) || (this.lookahead >= Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD))
            {
                goto label_72;
            }
            
            label_61:
            val_32 = 0;
            return (Ionic.Zlib.BlockState)val_32;
            label_3:
            this.flush_block_only(eof:  (flush == 4) ? 1 : 0);
            if(this._codec.AvailableBytesOut != 0)
            {
                    var val_18 = (flush == 4) ? 3 : (0 + 1);
                return (Ionic.Zlib.BlockState)val_32;
            }
            
            val_32 = ((flush == 4) ? 1 : 0) << 1;
            return (Ionic.Zlib.BlockState)val_32;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal Ionic.Zlib.BlockState DeflateSlow(Ionic.Zlib.FlushType flush)
        {
            Ionic.Zlib.FlushType val_24;
            short val_25;
            int val_26;
            int val_27;
            int val_28;
            var val_29;
            int val_30;
            var val_31;
            Ionic.Zlib.ZlibCodec val_32;
            var val_33;
            int val_34;
            var val_35;
            int val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            val_24 = flush;
            val_25 = 0;
            goto label_82;
            label_77:
            int val_22 = this.strstart;
            int val_23 = this.lookahead;
            val_22 = val_22 + 1;
            val_23 = val_23 - 1;
            this.match_available = 1;
            this.strstart = val_22;
            this.lookahead = val_23;
            goto label_82;
            label_76:
            if((10 & 2) == 0)
            {
                    val_26 = this.strstart;
            }
            else
            {
                    val_26 = this.strstart;
                if(1489920 == 0)
            {
                    val_26 = this.strstart;
            }
            
            }
            
            val_26 = val_26 - 1;
            val_27 = (this.lookahead + this.strstart) - Ionic.Zlib.DeflateManager.MIN_MATCH;
            int val_24 = this.prev_length;
            val_28 = val_24 - 2;
            val_24 = (this.lookahead + 1) - val_24;
            this.lookahead = val_24;
            this.prev_length = val_28;
            do
            {
                int val_6 = this.strstart + 1;
                this.strstart = val_6;
                if(val_6 <= val_27)
            {
                    val_29 = null;
                val_29 = null;
                int val_26 = (long)Ionic.Zlib.DeflateManager.MIN_MATCH + this.strstart;
                byte val_25 = this.window[val_26];
                int val_8 = this.hash_shift & 31;
                val_8 = this.ins_h << val_8;
                val_25 = val_8 ^ val_25;
                val_26 = val_25 & this.hash_mask;
                this.ins_h = val_26;
                val_30 = this.strstart;
                val_25 = this.head[(long)val_26];
                this.prev[(long)this.w_mask & val_30] = this.head[this.ins_h];
                this.head[this.ins_h] = this.strstart;
                val_28 = this.prev_length;
            }
            
                val_28 = val_28 - 1;
                this.prev_length = val_28;
            }
            while(val_28 != 0);
            
            this.match_available = 0;
            val_31 = null;
            val_24 = val_24;
            int val_28 = this.strstart;
            int val_29 = Ionic.Zlib.DeflateManager.MIN_MATCH;
            val_28 = val_28 + 1;
            this.strstart = val_28;
            val_29 = val_29 - 1;
            this.match_length = val_29;
            if((this._tr_tally(dist:  val_26 - this.prev_match, lc:  this.prev_length - Ionic.Zlib.DeflateManager.MIN_MATCH)) == false)
            {
                goto label_82;
            }
            
            this.flush_block_only(eof:  false);
            val_32 = this._codec;
            if(val_32 != null)
            {
                goto label_81;
            }
            
            goto label_25;
            label_82:
            val_33 = null;
            val_33 = null;
            if(this.lookahead >= Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD)
            {
                goto label_28;
            }
            
            this._fillWindow();
            val_33 = null;
            val_32 = this.lookahead;
            if(val_24 == 0)
            {
                    if(val_32 < Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD)
            {
                goto label_32;
            }
            
            }
            
            val_34 = this.lookahead;
            if(val_34 != 0)
            {
                goto label_33;
            }
            
            goto label_34;
            label_28:
            val_34 = this.lookahead;
            label_33:
            val_33 = null;
            if(val_34 >= Ionic.Zlib.DeflateManager.MIN_MATCH)
            {
                    int val_10 = this.strstart + Ionic.Zlib.DeflateManager.MIN_MATCH;
                val_10 = val_10 - 1;
                int val_31 = (long)val_10;
                byte val_30 = this.window[val_31];
                int val_11 = this.hash_shift & 31;
                val_11 = this.ins_h << val_11;
                val_30 = val_11 ^ val_30;
                val_31 = val_30 & this.hash_mask;
                this.ins_h = val_31;
                val_27 = this.strstart;
                val_30 = this.head;
                val_25 = this.head[(long)val_31];
                this.prev[(long)this.w_mask & val_27] = val_30[this.ins_h];
                this.head[this.ins_h] = this.strstart;
                val_33 = null;
            }
            
            this.prev_length = this.match_length;
            this.prev_match = this.match_start;
            val_33 = null;
            int val_33 = Ionic.Zlib.DeflateManager.MIN_MATCH;
            val_33 = val_33 - 1;
            this.match_length = val_33;
            if((val_25 == 0) || (this.prev_length >= this.config.MaxLazy))
            {
                goto label_71;
            }
            
            val_35 = null;
            val_35 = null;
            int val_13 = this.strstart - val_25;
            val_13 = val_13 & 65535;
            int val_34 = Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD;
            val_34 = this.w_size - val_34;
            if(val_13 > val_34)
            {
                goto label_71;
            }
            
            if(this.compressionStrategy == 2)
            {
                    val_36 = this.match_length;
            }
            else
            {
                    val_36 = this.longest_match(cur_match:  val_25);
                this.match_length = val_36;
            }
            
            if(val_36 > 5)
            {
                goto label_71;
            }
            
            val_37 = null;
            if(this.compressionStrategy != 1)
            {
                goto label_65;
            }
            
            label_72:
            val_38 = null;
            int val_35 = Ionic.Zlib.DeflateManager.MIN_MATCH;
            val_35 = val_35 - 1;
            this.match_length = val_35;
            goto label_71;
            label_65:
            val_39 = null;
            if(val_36 != Ionic.Zlib.DeflateManager.MIN_MATCH)
            {
                goto label_71;
            }
            
            int val_36 = this.strstart;
            val_36 = val_36 - this.match_start;
            if(val_36 > 4096)
            {
                goto label_72;
            }
            
            label_71:
            val_40 = null;
            val_40 = null;
            if(this.prev_length >= Ionic.Zlib.DeflateManager.MIN_MATCH)
            {
                    if(this.match_length <= this.prev_length)
            {
                goto label_76;
            }
            
            }
            
            if(this.match_available == 0)
            {
                goto label_77;
            }
            
            if((this._tr_tally(dist:  0, lc:  this.window[(long)this.strstart - 1])) != false)
            {
                    this.flush_block_only(eof:  false);
            }
            
            int val_38 = this.strstart;
            int val_39 = this.lookahead;
            val_32 = this._codec;
            val_38 = val_38 + 1;
            val_39 = val_39 - 1;
            this.strstart = val_38;
            this.lookahead = val_39;
            if(val_32 != null)
            {
                goto label_81;
            }
            
            label_25:
            label_81:
            if(this._codec.AvailableBytesOut != 0)
            {
                goto label_82;
            }
            
            label_32:
            val_41 = 0;
            return (Ionic.Zlib.BlockState)val_41;
            label_34:
            if(this.match_available != 0)
            {
                    val_25 = this.window;
                bool val_18 = this._tr_tally(dist:  0, lc:  val_25[(long)this.strstart - 1]);
                this.match_available = 0;
            }
            
            this.flush_block_only(eof:  (val_24 == 4) ? 1 : 0);
            val_32 = this._codec;
            if(this._codec.AvailableBytesOut != 0)
            {
                    var val_20 = (val_24 == 4) ? 3 : (0 + 1);
                return (Ionic.Zlib.BlockState)val_41;
            }
            
            val_41 = ((val_24 == 4) ? 1 : 0) << 1;
            return (Ionic.Zlib.BlockState)val_41;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int longest_match(int cur_match)
        {
            int val_59;
            int val_60;
            var val_61;
            int val_62;
            var val_63;
            int val_64;
            var val_65;
            System.Int16[] val_66;
            var val_67;
            var val_68;
            val_59 = this.strstart;
            val_60 = this.prev_length;
            val_61 = null;
            val_61 = null;
            val_62 = Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD;
            if(val_59 > (this.w_size - val_62))
            {
                    val_61 = null;
                val_62 = Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD;
                val_63 = (this.strstart - this.w_size) + val_62;
            }
            else
            {
                    val_63 = 0;
            }
            
            if(this.config == null)
            {
                    val_61 = null;
            }
            
            val_61 = null;
            int val_3 = val_60 + val_59;
            byte val_51 = this.window[(long)val_3 - 1];
            val_64 = this.w_mask;
            byte val_52 = this.window[(long)val_3];
            int val_5 = Ionic.Zlib.DeflateManager.MAX_MATCH + this.strstart;
            var val_7 = (this.prev_length < this.config.GoodLength) ? this.config.MaxChainLength : (this.config.MaxChainLength >> 2);
            val_65 = val_63;
            goto label_17;
            label_95:
            val_7 = val_7 - 1;
            val_60 = Ionic.Zlib.DeflateManager.MAX_MATCH;
            if(val_7 != 0)
            {
                goto label_17;
            }
            
            return (int)(val_68 > this.lookahead) ? this.lookahead : (val_68);
            label_55:
            val_65 = this.config.MaxChainLength + 1;
            goto label_24;
            label_60:
            label_92:
            val_65 = this.config.MaxChainLength + 2;
            goto label_24;
            label_65:
            val_65 = this.config.MaxChainLength + 3;
            goto label_24;
            label_70:
            val_65 = this.config.MaxChainLength + 4;
            goto label_24;
            label_75:
            val_65 = this.config.MaxChainLength + 5;
            goto label_24;
            label_80:
            val_65 = this.config.MaxChainLength + 6;
            goto label_24;
            label_85:
            val_65 = this.config.MaxChainLength + 7;
            label_24:
            val_66 = 1152921505283629056;
            val_64 = this.w_mask;
            val_67 = null;
            val_67 = null;
            val_68 = Ionic.Zlib.DeflateManager.MAX_MATCH + (val_65 - val_5);
            val_59 = val_5 - Ionic.Zlib.DeflateManager.MAX_MATCH;
            if(val_68 > val_60)
            {
                    this.match_start = cur_match;
                if(val_68 >= ((this.config.NiceLength > this.lookahead) ? this.lookahead : this.config.NiceLength))
            {
                    return (int)(val_68 > this.lookahead) ? this.lookahead : (val_68);
            }
            
            }
            else
            {
                    val_68 = val_60;
            }
            
            val_65 = val_63;
            goto label_34;
            label_17:
            if((this.window[(long)cur_match + val_60]) != this.window[(long)val_65])
            {
                goto label_40;
            }
            
            if((this.window[(long)((long)cur_match + val_60) - 1]) != (this.window[(long)val_65 - 1]))
            {
                goto label_40;
            }
            
            if(this.window[(long)cur_match] != this.window[(long)val_59])
            {
                goto label_50;
            }
            
            if((this.window[(long)cur_match + 1]) != (this.window[(long)val_59 + 1]))
            {
                goto label_50;
            }
            
            var val_76 = 0;
            label_91:
            if((this.window[(long)(val_59 + val_76) + 3]) != (this.window[(long)(cur_match + val_76) + 3]))
            {
                goto label_55;
            }
            
            if((this.window[(long)(val_59 + val_76) + 4]) != (this.window[(long)(cur_match + val_76) + 4]))
            {
                goto label_60;
            }
            
            if((this.window[(long)(val_59 + val_76) + 5]) != (this.window[(long)(cur_match + val_76) + 5]))
            {
                goto label_65;
            }
            
            if((this.window[(long)(val_59 + val_76) + 6]) != (this.window[(long)(cur_match + val_76) + 6]))
            {
                goto label_70;
            }
            
            if((this.window[(long)(val_59 + val_76) + 7]) != (this.window[(long)(cur_match + val_76) + 7]))
            {
                goto label_75;
            }
            
            if((this.window[(long)(val_59 + val_76) + 8]) != (this.window[(long)(cur_match + val_76) + 8]))
            {
                goto label_80;
            }
            
            if((this.window[(long)(val_59 + val_76) + 9]) != (this.window[(long)(cur_match + val_76) + 9]))
            {
                goto label_85;
            }
            
            int val_45 = (val_59 + val_76) + 10;
            int val_78 = val_59 + 2;
            val_76 = val_76 + 8;
            if(val_45 >= val_5)
            {
                goto label_90;
            }
            
            val_78 = val_78 + 8;
            if(this.window[(long)val_45] == (this.window[(long)(cur_match + val_76) + 10]))
            {
                goto label_91;
            }
            
            label_90:
            int val_48 = val_59 + val_76;
            goto label_92;
            label_50:
            val_64 = this.w_mask;
            label_40:
            val_68 = val_60;
            label_34:
            val_66 = this.prev;
            if(0 < (val_66[(long)cur_match & val_64]))
            {
                goto label_95;
            }
            
            return (int)(val_68 > this.lookahead) ? this.lookahead : (val_68);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal bool get_WantRfc1950HeaderBytes()
        {
            return (bool)this._WantRfc1950HeaderBytes;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void set_WantRfc1950HeaderBytes(bool value)
        {
            this._WantRfc1950HeaderBytes = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int Initialize(Ionic.Zlib.ZlibCodec codec, Ionic.Zlib.CompressionLevel level)
        {
            int val_1 = this.Initialize(codec:  codec, level:  level, bits:  15);
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int Initialize(Ionic.Zlib.ZlibCodec codec, Ionic.Zlib.CompressionLevel level, int bits)
        {
            null = null;
            int val_1 = this.Initialize(codec:  codec, level:  level, windowBits:  bits, memLevel:  Ionic.Zlib.DeflateManager.MEM_LEVEL_DEFAULT, strategy:  0);
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int Initialize(Ionic.Zlib.ZlibCodec codec, Ionic.Zlib.CompressionLevel level, int bits, Ionic.Zlib.CompressionStrategy compressionStrategy)
        {
            null = null;
            int val_1 = this.Initialize(codec:  codec, level:  level, windowBits:  bits, memLevel:  Ionic.Zlib.DeflateManager.MEM_LEVEL_DEFAULT, strategy:  compressionStrategy);
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int Initialize(Ionic.Zlib.ZlibCodec codec, Ionic.Zlib.CompressionLevel level, int windowBits, int memLevel, Ionic.Zlib.CompressionStrategy strategy)
        {
            var val_17;
            var val_18;
            int val_19;
            var val_20;
            var val_21;
            var val_22;
            int val_17 = memLevel;
            this._codec = codec;
            codec.Message = 0;
            if((windowBits - 9) < 7)
            {
                    val_17 = null;
                if(val_17 >= 1)
            {
                    val_17 = null;
                if(Ionic.Zlib.DeflateManager.MEM_LEVEL_MAX >= val_17)
            {
                    if(this._codec == null)
            {
                    val_18 = null;
            }
            
                this._codec.dstate = this;
                val_19 = 1 << (windowBits & 31);
                int val_3 = val_17 + 7;
                this.w_mask = val_19 - 1;
                int val_5 = val_3 & 31;
                val_5 = 1 << val_5;
                this.hash_size = val_5;
                this.hash_bits = val_3;
                val_3 = val_5 - 1;
                this.w_size = val_19;
                this.w_bits = windowBits;
                this.hash_mask = val_3;
                val_18 = null;
                val_19 = this.w_size;
                val_17 = val_17 + 6;
                int val_6 = val_19 << 1;
                int val_18 = Ionic.Zlib.DeflateManager.MIN_MATCH;
                val_18 = (val_17 + val_18) / val_18;
                this.hash_shift = val_18;
                this.window = new byte[0];
                this.prev = new short[0];
                int val_11 = val_17 & 31;
                val_11 = 1 << val_11;
                this.head = new short[0];
                this.lit_bufsize = val_11;
                int val_12 = val_11 << 2;
                int val_19 = this.lit_bufsize;
                this.pending = new byte[0];
                this.compressionLevel = level;
                this.compressionStrategy = strategy;
                this._distanceOffset = val_19;
                val_19 = val_19 + (val_19 << 1);
                this._lengthOffset = val_19;
                this.Reset();
                return 0;
            }
            
            }
            
                val_20 = null;
                val_21 = 1152921525541473104;
                val_22 = new Ionic.Zlib.ZlibException(s:  System.String.Format(format:  "memLevel must be in the range 1.. {0}", arg0:  Ionic.Zlib.DeflateManager.MEM_LEVEL_MAX));
            }
            else
            {
                    val_21 = 1152921525541473104;
                val_22 = new Ionic.Zlib.ZlibException(s:  "windowBits must be in the range 9..15.");
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void Reset()
        {
            var val_1;
            var val_2;
            int val_3;
            var val_4;
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
            this.nextPending = 0;
            this.pendingCount = 0;
            this.Rfc1950BytesEmitted = false;
            val_1 = null;
            if(this._WantRfc1950HeaderBytes != false)
            {
                    val_2 = null;
                val_3 = 1152921505283633172;
            }
            else
            {
                    val_4 = null;
                val_3 = 1152921505283633176;
            }
            
            this.status = val_3;
            this._codec._Adler32 = 1;
            this.last_flush = 0;
            this._InitializeTreeData();
            this._InitializeLazyMatch();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int End()
        {
            var val_2 = null;
            if(this.status != Ionic.Zlib.DeflateManager.INIT_STATE)
            {
                    val_2 = null;
                if(this.status != Ionic.Zlib.DeflateManager.BUSY_STATE)
            {
                    val_2 = null;
                if(this.status != Ionic.Zlib.DeflateManager.FINISH_STATE)
            {
                    return (int)(this.status != Ionic.Zlib.DeflateManager.BUSY_STATE) ? 0 : -3;
            }
            
            }
            
            }
            
            this.pending = 0;
            this.window = 0;
            this.prev = 0;
            this.head = 0;
            val_2 = null;
            return (int)(this.status != Ionic.Zlib.DeflateManager.BUSY_STATE) ? 0 : -3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetDeflater()
        {
            var val_1;
            if(this.config.Flavor == 2)
            {
                goto label_2;
            }
            
            if(this.config.Flavor == 1)
            {
                goto label_3;
            }
            
            if(this.config.Flavor != 0)
            {
                    return;
            }
            
            val_1 = 1152921525541896288;
            goto label_6;
            label_2:
            val_1 = 1152921525541897312;
            goto label_6;
            label_3:
            val_1 = 1152921525541898336;
            label_6:
            mem[1152921525541967680] = this;
            mem[1152921525541967688] = val_1;
            mem[1152921525541967664] = Ionic.Zlib.BlockState Ionic.Zlib.DeflateManager::DeflateFast(Ionic.Zlib.FlushType flush);
            this.DeflateFunction = new DeflateManager.CompressFunc();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int SetParams(Ionic.Zlib.CompressionLevel level, Ionic.Zlib.CompressionStrategy strategy)
        {
            var val_3;
            if(this.compressionLevel == level)
            {
                    val_3 = 0;
            }
            else
            {
                    if((val_1.Flavor != this.config.Flavor) && (this._codec.TotalBytesIn != 0))
            {
                    val_3 = this._codec.Deflate(flush:  1);
            }
            else
            {
                    val_3 = 0;
            }
            
                this.compressionLevel = level;
                this.config = DeflateManager.Config.Lookup(level:  level);
                this.SetDeflater();
            }
            
            this.compressionStrategy = strategy;
            return (int)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int SetDictionary(byte[] dictionary)
        {
            System.Byte[] val_10;
            int val_11;
            var val_12;
            var val_13;
            int val_15;
            var val_16;
            System.Byte[] val_17;
            var val_18;
            val_10 = dictionary;
            if(val_10 == null)
            {
                goto label_1;
            }
            
            val_11 = dictionary.Length;
            val_12 = null;
            val_12 = null;
            if(this.status != Ionic.Zlib.DeflateManager.INIT_STATE)
            {
                goto label_4;
            }
            
            this._codec._Adler32 = Ionic.Zlib.Adler.Adler32(adler:  this._codec._Adler32, buf:  val_10, index:  0, len:  dictionary.Length);
            val_13 = null;
            val_13 = null;
            if(Ionic.Zlib.DeflateManager.MIN_MATCH > val_11)
            {
                    return 0;
            }
            
            val_13 = null;
            val_15 = Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD;
            if((this.w_size - val_15) < val_11)
            {
                    val_15 = Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD;
                val_11 = this.w_size - val_15;
                val_16 = dictionary.Length - val_11;
            }
            else
            {
                    val_16 = 0;
            }
            
            System.Array.Copy(sourceArray:  val_10, sourceIndex:  0, destinationArray:  this.window, destinationIndex:  0, length:  val_11);
            this.strstart = val_11;
            this.block_start = val_11;
            byte val_9 = this.window[0];
            val_17 = this.window;
            this.ins_h = val_9;
            byte val_10 = val_17[1];
            int val_3 = this.hash_shift & 31;
            val_3 = val_9 << val_3;
            val_10 = val_3 ^ val_10;
            val_10 = val_10 & this.hash_mask;
            val_10 = 0;
            this.ins_h = val_10;
            goto label_32;
            label_37:
            if((0 & 2) != 0)
            {
                    if(496 == 0)
            {
                goto label_23;
            }
            
            }
            
            if(this.window != null)
            {
                goto label_33;
            }
            
            label_34:
            label_33:
            var val_4 = W26 + val_10;
            val_4 = val_4 - 1;
            int val_12 = (long)val_4;
            byte val_11 = this.window[val_12];
            int val_5 = this.hash_shift & 31;
            val_5 = this.ins_h << val_5;
            val_11 = val_5 ^ val_11;
            val_12 = val_11 & this.hash_mask;
            this.ins_h = val_12;
            val_17 = this.head[(long)val_12];
            this.prev[(long)this.w_mask & val_10] = val_17;
            this.head[this.ins_h] = val_10;
            val_10 = 1;
            goto label_32;
            label_23:
            if(this.window != null)
            {
                goto label_33;
            }
            
            goto label_34;
            label_32:
            val_18 = null;
            val_18 = null;
            if(val_10 <= (val_11 - Ionic.Zlib.DeflateManager.MIN_MATCH))
            {
                goto label_37;
            }
            
            return 0;
            label_1:
            label_4:
            Ionic.Zlib.ZlibException val_8 = new Ionic.Zlib.ZlibException(s:  "Stream error.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int Deflate(Ionic.Zlib.FlushType flush)
        {
            var val_28;
            int val_29;
            var val_30;
            byte val_32;
            System.Byte[] val_33;
            Ionic.Zlib.ZlibCodec val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            string val_44;
            var val_45;
            if(this._codec.OutputBuffer == null)
            {
                goto label_10;
            }
            
            if(this._codec.InputBuffer == null)
            {
                    if(this._codec.AvailableBytesIn != 0)
            {
                goto label_10;
            }
            
            }
            
            val_28 = null;
            val_28 = null;
            if(flush != 4)
            {
                    if(this.status == Ionic.Zlib.DeflateManager.FINISH_STATE)
            {
                goto label_10;
            }
            
            }
            
            if(this._codec.AvailableBytesOut == 0)
            {
                goto label_12;
            }
            
            val_29 = this.last_flush;
            this.last_flush = flush;
            val_30 = null;
            val_30 = null;
            if(this.status == Ionic.Zlib.DeflateManager.INIT_STATE)
            {
                    val_30 = null;
                int val_27 = Ionic.Zlib.DeflateManager.Z_DEFLATED;
                val_27 = val_27 + (this.w_bits << 4);
                val_27 = val_27 << 8;
                val_27 = val_27 - 32768;
                var val_2 = (((uint)((this.compressionLevel + 255) >> 1) & 127) < 3) ? ((uint)((this.compressionLevel + 255) >> 1) & 127) : 3;
                val_32 = val_27 | (val_2 << 6);
                if(this.strstart != 0)
            {
                    val_30 = null;
                val_32 = Ionic.Zlib.DeflateManager.PRESET_DICT | val_32;
            }
            
                var val_28 = 0;
                val_28 = val_28 + val_32;
                val_2 = val_28 >> 4;
                val_28 = val_2 + (val_28 >> 31);
                val_2 = val_28 << 5;
                val_28 = val_2 - val_28;
                int val_3 = val_32 - val_28;
                val_30 = null;
                val_3 = 31 - val_3;
                this.pendingCount = this.pendingCount + 1;
                this.status = Ionic.Zlib.DeflateManager.BUSY_STATE;
                val_32 = val_3 + val_32;
                this.pending[this.pendingCount] = val_32 >> 8;
                val_33 = this.pending;
                this.pendingCount = this.pendingCount + 1;
                val_33[this.pendingCount] = val_32;
                if(this.strstart != 0)
            {
                    this.pendingCount = this.pendingCount + 1;
                this.pending[this.pendingCount] = this._codec._Adler32 >> 24;
                this.pendingCount = this.pendingCount + 1;
                this.pending[this.pendingCount] = this._codec._Adler32 >> 16;
                this.pendingCount = this.pendingCount + 1;
                this.pending[this.pendingCount] = this._codec._Adler32 >> 8;
                this.pendingCount = this.pendingCount + 1;
                val_33 = this._codec._Adler32;
                this.pending[this.pendingCount] = val_33;
            }
            
                this._codec._Adler32 = 1;
            }
            
            val_34 = this._codec;
            if(val_34 == null)
            {
                goto label_44;
            }
            
            if(this.pendingCount == 0)
            {
                goto label_45;
            }
            
            label_66:
            val_34.flush_pending();
            val_34 = this._codec;
            if(this._codec.AvailableBytesOut == 0)
            {
                goto label_85;
            }
            
            label_70:
            val_35 = null;
            val_35 = null;
            if(this.status == Ionic.Zlib.DeflateManager.FINISH_STATE)
            {
                    if(this._codec.AvailableBytesIn != 0)
            {
                goto label_52;
            }
            
            }
            
            if(this._codec.AvailableBytesIn == 0)
            {
                    if(this.lookahead == 0)
            {
                goto label_55;
            }
            
            }
            
            label_76:
            val_34 = this.DeflateFunction.Invoke(flush:  flush);
            if((val_34 & 4294967294) == 2)
            {
                    val_36 = null;
                val_36 = null;
                this.status = Ionic.Zlib.DeflateManager.FINISH_STATE;
            }
            
            if(val_34 == 2)
            {
                goto label_60;
            }
            
            if(val_34 == 1)
            {
                goto label_61;
            }
            
            if(val_34 != 0)
            {
                goto label_77;
            }
            
            label_60:
            if(this._codec.AvailableBytesOut != 0)
            {
                goto label_86;
            }
            
            goto label_85;
            label_44:
            if(this.pendingCount != 0)
            {
                goto label_66;
            }
            
            label_45:
            if((flush == 4) || (val_29 < flush))
            {
                goto label_70;
            }
            
            if(this._codec.AvailableBytesIn == 0)
            {
                goto label_86;
            }
            
            goto label_70;
            label_61:
            if(flush != 1)
            {
                goto label_71;
            }
            
            this._tr_align();
            goto label_79;
            label_55:
            if(flush == 0)
            {
                goto label_77;
            }
            
            val_37 = null;
            val_34 = this.status;
            val_37 = null;
            if(val_34 != Ionic.Zlib.DeflateManager.FINISH_STATE)
            {
                goto label_76;
            }
            
            goto label_77;
            label_71:
            this._tr_stored_block(buf:  0, stored_len:  0, eof:  false);
            if((flush == 3) && (this.hash_size >= 1))
            {
                    var val_29 = 0;
                do
            {
                val_29 = 0;
                this.head[val_29] = 0;
                val_29 = val_29 + 1;
            }
            while(val_29 < this.hash_size);
            
            }
            
            label_79:
            this._codec.flush_pending();
            val_34 = this._codec;
            if(this._codec.AvailableBytesOut == 0)
            {
                goto label_85;
            }
            
            label_77:
            if(flush == 4)
            {
                    if(this._WantRfc1950HeaderBytes != false)
            {
                    if(this.Rfc1950BytesEmitted == false)
            {
                goto label_88;
            }
            
            }
            
                val_38 = 1;
                return (int)val_38;
            }
            
            label_86:
            val_38 = 0;
            return (int)val_38;
            label_85:
            val_38 = 0;
            this.last_flush = 0;
            return (int)val_38;
            label_88:
            this.pendingCount = this.pendingCount + 1;
            this.pending[this.pendingCount] = this._codec._Adler32 >> 24;
            this.pendingCount = this.pendingCount + 1;
            this.pending[this.pendingCount] = this._codec._Adler32 >> 16;
            this.pendingCount = this.pendingCount + 1;
            this.pending[this.pendingCount] = this._codec._Adler32 >> 8;
            this.pendingCount = this.pendingCount + 1;
            this.pending[this.pendingCount] = this._codec._Adler32;
            this._codec.flush_pending();
            this.Rfc1950BytesEmitted = true;
            var val_23 = (this.pendingCount == 0) ? 1 : 0;
            return (int)val_38;
            label_10:
            val_39 = null;
            val_39 = null;
            this._codec.Message = Ionic.Zlib.DeflateManager._ErrorMessage;
            val_40 = 1152921525543535040;
            val_41 = new Ionic.Zlib.ZlibException(s:  System.String.Format(format:  "Something is fishy. [{0}]", arg0:  this._codec.Message));
            goto label_107;
            label_12:
            val_42 = null;
            val_42 = null;
            this._codec.Message = Ionic.Zlib.DeflateManager._ErrorMessage;
            val_44 = "OutputBuffer is full (AvailableBytesOut == 0)";
            goto label_110;
            label_52:
            val_45 = null;
            val_45 = null;
            this._codec.Message = Ionic.Zlib.DeflateManager._ErrorMessage;
            Ionic.Zlib.ZlibException val_26 = null;
            val_44 = "status == FINISH_STATE && _codec.AvailableBytesIn != 0";
            label_110:
            val_26 = new Ionic.Zlib.ZlibException(s:  val_44);
            val_40 = 1152921525543535040;
            val_41 = val_26;
            label_107:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static DeflateManager()
        {
            var val_2;
            var val_3;
            Ionic.Zlib.DeflateManager.MEM_LEVEL_MAX = 9;
            Ionic.Zlib.DeflateManager.MEM_LEVEL_DEFAULT = 8;
            string[] val_1 = new string[10];
            val_1[0] = "need dictionary";
            val_1[1] = "stream end";
            val_1[2] = "";
            val_1[3] = "file error";
            val_1[4] = "stream error";
            val_1[5] = "data error";
            val_1[6] = "insufficient memory";
            val_1[7] = "buffer error";
            val_1[8] = "incompatible version";
            val_1[9] = "";
            val_2 = null;
            Ionic.Zlib.DeflateManager._ErrorMessage = val_1;
            Ionic.Zlib.DeflateManager.PRESET_DICT = 32;
            Ionic.Zlib.DeflateManager.INIT_STATE = 42;
            Ionic.Zlib.DeflateManager.BUSY_STATE = 113;
            Ionic.Zlib.DeflateManager.FINISH_STATE = 666;
            Ionic.Zlib.DeflateManager.Z_DEFLATED = 8;
            Ionic.Zlib.DeflateManager.STORED_BLOCK = 0;
            Ionic.Zlib.DeflateManager.STATIC_TREES = 1;
            Ionic.Zlib.DeflateManager.DYN_TREES = 2;
            Ionic.Zlib.DeflateManager.Z_BINARY = 0;
            Ionic.Zlib.DeflateManager.Z_ASCII = 1;
            Ionic.Zlib.DeflateManager.Z_UNKNOWN = 2;
            Ionic.Zlib.DeflateManager.Buf_size = 16;
            Ionic.Zlib.DeflateManager.MIN_MATCH = 3;
            Ionic.Zlib.DeflateManager.MAX_MATCH = 258;
            Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD = 262;
            val_3 = null;
            val_3 = null;
            val_2 = null;
            Ionic.Zlib.DeflateManager.HEAP_SIZE = 1;
            Ionic.Zlib.DeflateManager.END_BLOCK = 256;
        }
    
    }

}
