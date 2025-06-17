using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private class PointsFilter.Data
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Vector3[] _points;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<int>[,,] _grid;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Vector3 _min;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Vector3 _max;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int _cellsX;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int _cellsY;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int _cellsZ;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float _cellSize;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float _radius;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Dest.Math.Rand _rand;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PointsFilter.Data(UnityEngine.Vector3[] points, float radius, Dest.Math.Rand rand, Dest.Math.AAB3 aab)
    {
        val_1 = new System.Object();
        this._min = aab.Min.x;
        mem[1152921519511797044] = aab.Min.y;
        mem[1152921519511797048] = aab.Min.z;
        this._max = aab.Max.x;
        mem[1152921519511797056] = aab.Max.y;
        mem[1152921519511797060] = aab.Max.z;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = aab.Max.x, y = aab.Max.y, z = aab.Max.z}, b:  new UnityEngine.Vector3() {x = aab.Min.x, y = aab.Min.y, z = aab.Min.z});
        this._radius = radius;
        float val_6 = 1.732051f;
        val_6 = radius / val_6;
        this._cellSize = val_6;
        val_6 = val_2.x / val_6;
        float val_7 = this._cellSize;
        this._cellsX = UnityEngine.Mathf.CeilToInt(f:  val_6);
        val_7 = val_2.y / val_7;
        float val_8 = this._cellSize;
        this._cellsY = UnityEngine.Mathf.CeilToInt(f:  val_7);
        val_8 = val_2.z / val_8;
        this._cellsZ = UnityEngine.Mathf.CeilToInt(f:  val_8);
        this._points = points;
        this._grid = null;
        this._rand = val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static int BinarySearch(System.Collections.Generic.List<int> array, int value)
    {
        var val_8;
        int val_9;
        val_8 = 0;
        int val_2 = array.Count - 1;
        if((val_2 & 2147483648) != 0)
        {
            goto label_6;
        }
        
        goto label_5;
        label_9:
        if(>=0)
        {
            goto label_4;
        }
        
        val_8 = value + 1;
        label_7:
        if(val_2 >= val_8)
        {
            goto label_5;
        }
        
        goto label_6;
        label_4:
        int val_3 = value - 1;
        goto label_7;
        label_5:
        val_9 = val_8 + ((val_2 - val_8) >> 1);
        if((float)array.Item[val_9] != (float)value)
        {
            goto label_9;
        }
        
        return (int)val_9;
        label_6:
        val_9 = val_8;
        return (int)val_9;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static int BinarySearch(int[] array, int length, int value)
    {
        var val_6;
        int val_1 = length - 1;
        val_6 = 0;
        if((val_1 & 2147483648) != 0)
        {
                return (int)val_6;
        }
        
        goto label_3;
        label_8:
        if(>=0)
        {
            goto label_2;
        }
        
        val_6 = W22 + 1;
        label_5:
        if(val_1 >= val_6)
        {
            goto label_3;
        }
        
        return (int)val_6;
        label_2:
        var val_2 = W22 - 1;
        goto label_5;
        label_3:
        if(((float)array[((long)(int)((val_6 + ((int)((length - 1) - val_6)) >> 1))) << 2]) != (float)value)
        {
            goto label_8;
        }
        
        val_6 = val_6 + ((val_1 - val_6) >> 1);
        return (int)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void CalcGridIndices(ref UnityEngine.Vector3 point, out int i, out int j, out int k)
    {
        float val_1 = point.x;
        val_1 = val_1 - this._min;
        val_1 = val_1 / this._cellSize;
        i = (int)val_1;
        float val_2 = point.y;
        val_2 = val_2 - this._min;
        val_2 = val_2 / this._cellSize;
        j = (int)val_2;
        float val_3 = point.z;
        val_3 = val_3 - this._min;
        val_3 = val_3 / this._cellSize;
        k = (int)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<int> Filter()
    {
        int val_50;
        var val_51;
        float val_52;
        int val_53;
        int val_55;
        int val_56;
        var val_57;
        var val_58;
        System.Collections.Generic.List<System.Int32> val_59;
        int val_61;
        System.Int32[] val_62;
        System.Int32[] val_63;
        System.Int32[][] val_64;
        System.Int32[][] val_65;
        System.Collections.Generic.List<T> val_66;
        System.Int32[][] val_67;
        int val_68;
        int val_70;
        int val_71;
        var val_72;
        var val_73;
        System.Int32[] val_74;
        float val_76;
        float val_77;
        var val_79;
        int val_80;
        System.Int32[][] val_81;
        float val_82;
        val_50 = this._points.Length & 4294967295;
        if(this._points.Length >= 1)
        {
                val_51 = 0;
            var val_53 = 0;
            do
        {
            UnityEngine.Vector3 val_50 = this._min;
            val_50 = this._points[val_51] - val_50;
            float val_1 = this._points[val_51] - S1;
            float val_2 = this._points[val_51] - S3;
            val_50 = val_50 / this._cellSize;
            val_52 = val_1 / this._cellSize;
            val_53 = (int)val_50;
            val_55 = (int)val_52;
            val_56 = (int)val_2 / this._cellSize;
            UnityEngine.Vector3 val_51 = this._points[val_51];
            val_57 = (long)val_53;
            val_58 = (long)val_55;
            if(val_56 >= val_51)
        {
                val_57 = val_57;
            val_58 = val_58;
            val_56 = val_56;
            val_55 = val_55;
            val_51 = val_51;
            val_53 = val_53;
        }
        
            var val_4 = val_58 + (X24 * val_57);
            val_4 = (long)val_56 + (val_51 * val_4);
            val_59 = this._grid[val_4];
            if(val_59 == null)
        {
                System.Collections.Generic.List<System.Int32> val_5 = null;
            val_59 = val_5;
            val_5 = new System.Collections.Generic.List<System.Int32>();
            var val_52 = val_57;
            val_52 = val_58 + ((public System.Void System.Collections.Generic.List<System.Int32>::Add(System.Int32 item)) * val_52);
            val_52 = (long)val_56 + ((public System.Void System.Collections.Generic.List<System.Int32>::Clear()) * val_52);
            this._grid[val_52] = val_59;
        }
        
            val_5.Add(item:  0);
            val_50 = val_50;
            val_53 = val_53 + 1;
            val_51 = val_51 + 12;
        }
        while(val_50 != val_53);
        
        }
        
        System.Collections.Generic.List<System.Int32> val_6 = null;
        val_61 = this._points.Length;
        val_6 = new System.Collections.Generic.List<System.Int32>(capacity:  val_61);
        int[] val_7 = new int[0];
        val_62 = val_7;
        if(val_61 >= 1)
        {
                do
        {
            mem2[0] = 0;
            val_61 = 0 + 1;
        }
        while(val_50 != val_61);
        
        }
        
        val_63 = new int[0];
        System.Int32[][] val_9 = new System.Int32[][2];
        val_64 = val_9;
        if(val_64 == null)
        {
            goto label_20;
        }
        
        if(val_62 != null)
        {
            goto label_21;
        }
        
        goto label_24;
        label_20:
        val_64 = val_64;
        if(val_62 == null)
        {
            goto label_24;
        }
        
        label_21:
        System.Int32[] val_54 = val_9[4];
        val_64 = val_64;
        if(val_62 == null)
        {
                val_64 = val_64;
        }
        
        label_24:
        val_65 = val_64;
        mem[1152921519513123632] = val_62;
        val_66 = val_6;
        if(val_63 != null)
        {
                System.Int32[] val_55 = val_9[4];
            val_65 = val_64;
            if(val_63 == null)
        {
                val_65 = val_64;
        }
        
        }
        
        mem[1152921519513123640] = val_63;
        if(this._points.Length < 1)
        {
                return (System.Collections.Generic.List<System.Int32>)val_66;
        }
        
        float val_10 = this._radius * this._radius;
        label_82:
        int val_11 = this._rand.NextInt(max:  this._points.Length);
        val_63 = val_62[((long)(int)(val_11)) << 2];
        val_6.Add(item:  val_63);
        val_67 = val_64;
        if(val_67 == 0)
        {
                val_67 = val_64;
        }
        
        System.Int32[][] val_56 = val_64;
        val_56 = val_56 + 0;
        if(val_11 >= 1)
        {
                System.Buffer.BlockCopy(src:  val_7, srcOffset:  0, dst:  (val_9 + 0) + 32, dstOffset:  0, count:  val_11 << 2);
        }
        
        int val_57 = this._points.Length;
        val_57 = val_57 - val_11;
        val_57 = val_57 - 1;
        if(val_57 >= 1)
        {
                int val_13 = val_11 << 2;
            System.Buffer.BlockCopy(src:  val_7, srcOffset:  val_13 + 4, dst:  (val_9 + 0) + 32, dstOffset:  val_13, count:  val_57 << 2);
        }
        
        int val_16 = this._points + (val_63 * 12);
        UnityEngine.Vector3 val_58 = this._min;
        val_58 = ((val_7[((long)(int)(val_11)) << 2][0] * 12) + this._points + 32) - val_58;
        val_1 = ((val_7[((long)(int)(val_11)) << 2][0] * 12) + this._points + 32 + 4) - val_1;
        val_2 = ((val_7[((long)(int)(val_11)) << 2][0] * 12) + this._points + 40) - val_2;
        val_58 = val_58 / this._cellSize;
        val_52 = val_1 / this._cellSize;
        val_68 = (int)val_58;
        val_70 = (int)val_52;
        val_71 = (int)val_2 / this._cellSize;
        val_72 = (long)val_70;
        val_73 = (long)val_71;
        if(val_71 >= ((val_7[((long)(int)(val_11)) << 2][0] * 12) + this._points + 32))
        {
                val_73 = val_73;
            val_72 = val_72;
            val_71 = val_71;
            val_70 = val_70;
            val_68 = val_68;
        }
        
        var val_18 = val_72 + (((val_7[((long)(int)(val_11)) << 2][0] * 12) + this._points + 16) * (long)val_68);
        val_18 = val_73 + (((val_7[((long)(int)(val_11)) << 2][0] * 12) + this._points + 32) * val_18);
        val_61 = this._grid[val_18];
        val_56 = (long)val_68;
        if(val_61 != null)
        {
                bool val_19 = val_61.Remove(item:  val_63);
        }
        else
        {
                bool val_20 = 0.Remove(item:  val_63);
        }
        
        val_74 = (val_9 + 0) + 32;
        int val_59 = this._points.Length;
        val_59 = val_59 - 1;
        if(val_61.Count == 0)
        {
                val_61 = this._grid;
            val_56 = mem[(this._points.Length - 1) + 32];
            val_56 = (this._points.Length - 1) + 32;
            var val_60 = val_72;
            val_60 = val_60 + (((this._points.Length - 1) + 16) * val_56);
            val_60 = val_73 + (val_56 * val_60);
            val_61[val_60] = 0;
            val_74 = (val_9 + 0) + 32;
        }
        
        float val_22 = val_68 + 2;
        float val_23 = val_68 - 2;
        float val_24 = val_70 + 2;
        float val_25 = val_71 + 2;
        float val_26 = val_23 & (~(val_23 >> 31));
        var val_27 = (val_22 > this._cellsX) ? this._cellsX : (val_22);
        var val_28 = (val_24 > this._cellsY) ? this._cellsY : (val_24);
        var val_29 = (val_25 > this._cellsZ) ? this._cellsZ : (val_25);
        if(val_26 >= val_27)
        {
            goto label_51;
        }
        
        float val_30 = val_70 - 2;
        float val_31 = val_71 - 2;
        val_76 = val_26;
        float val_32 = val_30 & (~(val_30 >> 31));
        float val_33 = val_31 & (~(val_31 >> 31));
        label_81:
        val_77 = val_32;
        if(val_32 >= val_28)
        {
            goto label_52;
        }
        
        label_80:
        float val_66 = val_33;
        if(val_33 >= val_29)
        {
            goto label_53;
        }
        
        label_79:
        val_61 = this._grid;
        float val_34 = val_77 + (((((((val_7[((long)(int)(val_11)) << 2][0] * 12) + this._points + 40 - (this._points[0x0][0] - S3)) / this._cellSize) - 2) & (~((int)((((val_7[((long)(int)(val_11)) << 2][0] * 12) + this._points + 40 - (this._points[0x0][0] - S3)) / this._cellSize) - 2)) >> 31)) + 16) * val_76);
        val_34 = val_66 + (((((((val_7[((long)(int)(val_11)) << 2][0] * 12) + this._points + 40 - (this._points[0x0][0] - S3)) / this._cellSize) - 2) & (~((int)((((val_7[((long)(int)(val_11)) << 2][0] * 12) + this._points + 40 - (this._points[0x0][0] - S3)) / this._cellSize) - 2)) >> 31)) + 32) * val_34);
        System.Collections.Generic.List<System.Int32> val_61 = val_61[val_34];
        if(val_61 == null)
        {
            goto label_78;
        }
        
        int val_65 = val_61.Count;
        val_79 = 0;
        goto label_67;
        label_72:
        val_80 = val_61.Item[val_65];
        if(val_80 == 1)
        {
            goto label_60;
        }
        
        var val_37 = this._points + ((long)val_80 * 12);
        val_61 = this._points;
        val_52 = mem[((long)(int)(val_36) * 12) + this._points + 40];
        val_52 = ((long)(int)(val_36) * 12) + this._points + 40;
        int val_38 = val_61 + (val_63 * 12);
        UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)(val_36) * 12) + this._points + 32, y = ((long)(int)(val_36) * 12) + this._points + 32 + 4, z = val_52}, b:  new UnityEngine.Vector3() {x = (val_7[((long)(int)(val_11)) << 2][0] * 12) + this._points + 32, y = (val_7[((long)(int)(val_11)) << 2][0] * 12) + this._points + 32 + 4, z = (val_7[((long)(int)(val_11)) << 2][0] * 12) + this._points + 40});
        val_39.x = val_39.x * val_39.x;
        val_39.y = val_39.y * val_39.y;
        val_39.x = val_39.x + val_39.y;
        val_39.x = (val_39.z * val_39.z) + val_39.x;
        if(val_39.x >= 0)
        {
            goto label_67;
        }
        
        val_80 = PointsFilter.Data.BinarySearch(array:  val_74, length:  val_59, value:  val_80);
        val_81 = val_64;
        if(val_81 == 0)
        {
                val_81 = val_64;
        }
        
        System.Int32[][] val_62 = val_64;
        val_62 = val_62 + 0;
        val_61 = mem[(val_9 + 0) + 32];
        val_61 = (val_9 + 0) + 32;
        if(val_80 >= 1)
        {
                System.Buffer.BlockCopy(src:  val_74, srcOffset:  0, dst:  val_61, dstOffset:  0, count:  val_80 << 2);
        }
        
        int val_63 = val_59;
        val_63 = val_63 - val_80;
        val_63 = val_63 - 1;
        if(val_63 >= 1)
        {
                int val_43 = val_80 << 2;
            System.Buffer.BlockCopy(src:  val_74, srcOffset:  val_43 + 4, dst:  val_61, dstOffset:  val_43, count:  val_63 << 2);
        }
        
        int val_64 = val_59;
        val_64 = val_64 - 1;
        val_61.set_Item(index:  val_65, value:  0);
        label_60:
        val_79 = 1;
        label_67:
        val_65 = val_65 - 1;
        if((val_65 & 2147483648) == 0)
        {
            goto label_72;
        }
        
        if(val_65 == val_79)
        {
                val_61 = this._grid;
            val_74 = val_61;
            val_76 = val_76;
            val_82 = val_77;
            float val_46 = val_82 + ((val_35 + 16) * val_76);
            val_46 = val_66 + ((val_35 + 32) * val_46);
            val_61[val_46] = 0;
        }
        else
        {
                val_74 = val_61;
            val_76 = val_76;
            val_82 = val_77;
        }
        
        label_78:
        val_66 = val_66 + 1;
        if(val_66 < (long)val_29)
        {
            goto label_79;
        }
        
        label_53:
        val_82 = val_82 + 1;
        if(val_82 < (long)val_28)
        {
            goto label_80;
        }
        
        label_52:
        val_56 = val_76 + 1;
        if(val_56 < (long)val_27)
        {
            goto label_81;
        }
        
        label_51:
        val_66 = val_6;
        val_62 = val_74;
        if(val_64 > 0)
        {
            goto label_82;
        }
        
        return (System.Collections.Generic.List<System.Int32>)val_66;
    }

}
