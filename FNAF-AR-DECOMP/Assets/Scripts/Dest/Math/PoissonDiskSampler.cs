using UnityEngine;

namespace Dest.Math
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PoissonDiskSampler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly float one_div_sqrtTwo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Dest.Math.Rand _rand;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<int> _activeList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.Vector2> _points;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<int>[,] _grid;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _r;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _rSquared;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _rTwo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _rMin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 _min;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 _max;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 _size;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _cellSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _cellsX;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _cellsY;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Dest.Math.PoissonDiskSampler.PointDelegate DistanceFilter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int PointsPerStep;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <MaxPoints>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MaxPoints { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_MaxPoints()
        {
            return (int)this.<MaxPoints>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_MaxPoints(int value)
        {
            this.<MaxPoints>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PoissonDiskSampler()
        {
            Dest.Math.PoissonDiskSampler.one_div_sqrtTwo = 0.7071068f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PoissonDiskSampler(Dest.Math.Rand rand, UnityEngine.Vector2 minCorner, UnityEngine.Vector2 maxCorner, float minDistanceOuter, float minDistanceInner = 1)
        {
            UnityEngine.Vector2 val_13;
            var val_14;
            this.PointsPerStep = 30;
            UnityEngine.Vector2 val_1 = (minCorner.x < 0) ? minCorner.x : maxCorner.x;
            UnityEngine.Vector2 val_2 = (minCorner.x < 0) ? maxCorner.x : minCorner.x;
            float val_3 = (minCorner.y < 0) ? minCorner.y : maxCorner.y;
            float val_4 = (minCorner.y < 0) ? maxCorner.y : minCorner.y;
            this._min = val_1;
            mem[1152921519513904228] = val_3;
            this._max = val_2;
            mem[1152921519513904236] = val_4;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_2, y = val_4}, b:  new UnityEngine.Vector2() {x = val_1, y = val_3});
            val_13 = val_5.x;
            this._size = val_5;
            mem[1152921519513904244] = val_5.y;
            val_14 = null;
            val_14 = null;
            val_13 = this._size;
            float val_13 = Dest.Math.PoissonDiskSampler.one_div_sqrtTwo;
            float val_6 = val_13 * minDistanceOuter;
            this._cellSize = val_6;
            val_13 = val_13 / val_6;
            this._cellsX = UnityEngine.Mathf.CeilToInt(f:  val_13);
            val_13 = val_13 / this._cellSize;
            this._cellsY = UnityEngine.Mathf.CeilToInt(f:  val_13);
            this._rand = rand;
            this._activeList = new System.Collections.Generic.List<System.Int32>();
            this._points = new System.Collections.Generic.List<UnityEngine.Vector2>();
            this._grid = null;
            this._r = minDistanceOuter;
            this._rSquared = minDistanceOuter * minDistanceOuter;
            this._rTwo = minDistanceOuter + minDistanceOuter;
            this._rMin = minDistanceInner;
            this.<MaxPoints>k__BackingField = 2147483647;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CalcGridIndices(ref UnityEngine.Vector2 point, out int i, out int j)
        {
            float val_1 = point.x;
            val_1 = val_1 - this._min;
            val_1 = val_1 / this._cellSize;
            i = (int)val_1;
            float val_2 = point.y;
            val_2 = val_2 - this._min;
            val_2 = val_2 / this._cellSize;
            j = (int)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InsertIntoGrid(ref UnityEngine.Vector2 point, int index)
        {
            float val_4 = this._cellSize;
            float val_2 = point.x;
            float val_3 = point.y;
            val_2 = val_2 - this._min;
            val_3 = val_3 - S4;
            val_2 = val_2 / val_4;
            val_4 = val_3 / val_4;
            var val_1 = (long)(int)val_4 + ((public System.Void System.Nullable<System.Linq.Expressions.Interpreter.LocalDefinition>::.ctor(System.Linq.Expressions.Interpreter.LocalDefinition value)) * (long)(int)val_2);
            this._grid[((public System.Void System.Nullable<System.Linq.Expressions.Interpreter.LocalDefinition>::.ctor(System.Linq.Expressions.Interpreter.LocalDefinition value) * (long)(int)(((point.x - this._min) / this._cellSize))) + (long)(int)(((point.y - S4) / this._cellSize))) << 3] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool AddPoint(ref UnityEngine.Vector2 center)
        {
            Dest.Math.Rand val_18;
            float val_19;
            float val_22;
            float val_23;
            int val_24;
            int val_25;
            int val_26;
            System.Collections.Generic.List<UnityEngine.Vector2> val_27;
            val_18 = this._rand;
            val_19 = this._rTwo;
            UnityEngine.Vector2 val_1 = val_18.InCircle(radiusMin:  this._r, radiusMax:  val_19);
            val_22 = val_1.x + center.x;
            float val_18 = center.y;
            val_18 = val_1.y + val_18;
            if(this.DistanceFilter != null)
            {
                    val_19 = this._r;
                val_22 = val_22;
                val_23 = (UnityEngine.Mathf.Lerp(a:  this._rMin, b:  val_19, t:  this.DistanceFilter.Invoke(point: ref  new UnityEngine.Vector2() {x = val_22, y = val_18}))) * (UnityEngine.Mathf.Lerp(a:  this._rMin, b:  val_19, t:  this.DistanceFilter.Invoke(point: ref  new UnityEngine.Vector2() {x = val_22, y = val_18})));
            }
            else
            {
                    val_23 = this._rSquared;
            }
            
            UnityEngine.Vector2 val_19 = this._min;
            if((((val_19 > val_22) || (val_22 > this._max)) || (this._max > val_18)) || (val_18 > S4))
            {
                    return false;
            }
            
            val_19 = val_22 - val_19;
            val_19 = val_19 / this._cellSize;
            val_24 = (int)val_19;
            float val_4 = val_18 - this._max;
            val_4 = val_4 / this._cellSize;
            val_25 = (int)val_4;
            int val_6 = UnityEngine.Mathf.Max(a:  0, b:  val_24 - 2);
            int val_8 = UnityEngine.Mathf.Min(a:  this._cellsX, b:  val_24 + 2);
            int val_10 = UnityEngine.Mathf.Max(a:  0, b:  val_25 - 2);
            val_26 = this._cellsY;
            int val_12 = UnityEngine.Mathf.Min(a:  val_26, b:  val_25 + 2);
            if(val_6 < val_8)
            {
                    val_27 = this._points;
                var val_23 = (long)val_6;
                do
            {
                if(val_10 < val_12)
            {
                    val_18 = (long)val_10;
                do
            {
                var val_13 = val_18 + (val_23 * ((long)(int)(val_8) + 16));
                System.Nullable<System.Int32> val_20 = this._grid[(((long)(int)(val_6) * (long)(int)(val_8) + 16) + (long)(int)(val_10)) << 3];
                if((2022688600 & 1) != 0)
            {
                    UnityEngine.Vector2 val_14 = this._points.SyncRoot.Item[2022688600];
                val_14.x = val_14.x - val_22;
                val_14.y = val_14.y - val_18;
                UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  val_14.x, y:  val_14.y);
                float val_21 = val_15.x;
                float val_22 = val_15.y;
                val_21 = val_21 * val_21;
                val_22 = val_22 * val_22;
                val_21 = val_21 + val_22;
                if(val_21 < 0)
            {
                    return false;
            }
            
            }
            
                val_18 = val_18 + 1;
            }
            while(val_18 < (long)val_12);
            
            }
            
                val_23 = val_23 + 1;
            }
            while(val_23 < (long)val_8);
            
                val_24 = val_24;
                val_25 = val_25;
            }
            else
            {
                    val_27 = this._points;
            }
            
            this._points.SyncRoot.Add(item:  new UnityEngine.Vector2() {x = val_22, y = val_18});
            object val_24 = this._points.SyncRoot;
            val_24 = val_24.Count - 1;
            this._activeList.Add(item:  val_24);
            var val_17 = (long)val_25 + ((public System.Void System.Nullable<System.Linq.Expressions.Interpreter.LocalDefinition>::.ctor(System.Linq.Expressions.Interpreter.LocalDefinition value)) * (long)val_24);
            this._grid[((public System.Void System.Nullable<System.Linq.Expressions.Interpreter.LocalDefinition>::.ctor(System.Linq.Expressions.Interpreter.LocalDefinition value) * (long)(int)((((val_1.x + center.x) - this._min) / this._cellSize))) + (long)(int)((((val_1.y + center.y) - this._max) / this._cellSize))) << 3] = 0;
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<UnityEngine.Vector2> Sample()
        {
            System.Collections.Generic.List<System.Int32> val_11;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  this._rand.NextFloat(min:  this._min, max:  this._max), y:  this._rand.NextFloat(min:  this._max, max:  V10.16B));
            this.InsertIntoGrid(point: ref  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, index:  0);
            this._points.Add(item:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            this._activeList.Add(item:  0);
            goto label_12;
            label_17:
            int val_5 = this._rand.NextInt(max:  this._activeList.Count);
            UnityEngine.Vector2 val_7 = this._points.Item[this._activeList.Item[val_5]];
            if(this.PointsPerStep < 1)
            {
                goto label_10;
            }
            
            var val_11 = 0;
            do
            {
                val_11 = val_11 + 1;
                val_11 = 0 | (this.AddPoint(center: ref  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}));
            }
            while(val_11 < this.PointsPerStep);
            
            if(val_11 == true)
            {
                goto label_12;
            }
            
            label_10:
            val_11 = this._activeList;
            val_11.RemoveAt(index:  val_5);
            label_12:
            if(this._activeList.Count == 0)
            {
                    return (System.Collections.Generic.List<UnityEngine.Vector2>)this._points;
            }
            
            if(this._points.Count < (this.<MaxPoints>k__BackingField))
            {
                goto label_17;
            }
            
            return (System.Collections.Generic.List<UnityEngine.Vector2>)this._points;
        }
    
    }

}
