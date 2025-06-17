using UnityEngine;

namespace StagPoint.SpatialDatabase
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LineSegment
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<UnityEngine.Vector3> _center;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<UnityEngine.Vector3> _dir;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<float> _length;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _start;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _end;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 start { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 end { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float length { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 direction { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 center { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 get_start()
        {
            return new UnityEngine.Vector3() {x = this._start};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_start(UnityEngine.Vector3 value)
        {
            this._start = value;
            mem[1152921520153139004] = value.y;
            mem[1152921520153139008] = value.z;
            this._length = 0;
            this._center = 0;
            this._dir = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 get_end()
        {
            return new UnityEngine.Vector3() {x = this._end};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_end(UnityEngine.Vector3 value)
        {
            this._end = value;
            mem[1152921520153363016] = value.y;
            mem[1152921520153363020] = value.z;
            this._length = 0;
            this._center = 0;
            this._dir = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_length()
        {
            if((this._length & 1) != 0)
            {
                    return (float)UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this._start, y = V12.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = this._end, y = V10.16B, z = V8.16B});
            }
            
            mem2[0] = 0;
            return (float)UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this._start, y = V12.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = this._end, y = V10.16B, z = V8.16B});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 get_direction()
        {
            if((this._dir & 1) != 0)
            {
                    return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            }
            
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this._end, y = V12.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = this._start, y = V9.16B, z = V8.16B});
            this._dir = 0;
            mem[1152921520153586984] = 0;
            return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 get_center()
        {
            if((this._center & 1) != 0)
            {
                    return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            }
            
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this._end, y = V13.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = this._start, y = V9.16B, z = V8.16B});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  0.5f);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this._start, y = V9.16B, z = V8.16B}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            this._center = 0;
            mem[1152921520153698968] = 0;
            return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LineSegment(UnityEngine.Vector3 start, UnityEngine.Vector3 end)
        {
            this._start = start;
            mem[1152921520153811004] = start.y;
            mem[1152921520153811008] = start.z;
            this._end = end;
            mem[1152921520153811016] = end.y;
            mem[1152921520153811020] = end.z;
            this._length = 0;
            this._center = 0;
            this._dir = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StagPoint.SpatialDatabase.LineSegment Flip()
        {
            ._start = this._end;
            mem[1152921520153959100] = ???;
            mem[1152921520153959104] = ???;
            ._end = this._start;
            mem[1152921520153959112] = ???;
            mem[1152921520153959116] = 69738496;
            ._length = 0;
            ._center = 0;
            ._dir = 0;
            return (StagPoint.SpatialDatabase.LineSegment)new StagPoint.SpatialDatabase.LineSegment();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StagPoint.SpatialDatabase.LineSegment Shrink(float amount)
        {
            var val_15;
            float val_15 = amount;
            val_15 = val_15 * 0.5f;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this._end, y = V13.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = this._start, y = V10.16B, z = V9.16B});
            val_15 = null;
            val_15 = null;
            float val_2 = val_1.x * 0.5f;
            val_2 = val_2 - UnityEngine.Mathf.Epsilon;
            float val_3 = UnityEngine.Mathf.Min(a:  val_15, b:  val_2);
            UnityEngine.Vector3 val_4 = this.center;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = this._start, y = V10.16B, z = V9.16B});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Normalize(value:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  val_3);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this._start, y = V10.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector3 val_9 = this.center;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = this._end, y = val_7.y, z = val_7.z});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.Normalize(value:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  val_3);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this._end, y = V13.16B, z = this._end}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            ._start = val_8;
            mem[1152921520154079292] = val_8.y;
            mem[1152921520154079296] = val_8.z;
            ._end = val_13;
            mem[1152921520154079304] = val_13.y;
            mem[1152921520154079308] = val_13.z;
            ._length = 0;
            ._center = 0;
            ._dir = 0;
            return (StagPoint.SpatialDatabase.LineSegment)new StagPoint.SpatialDatabase.LineSegment();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Intersects2D(StagPoint.SpatialDatabase.LineSegment line, out UnityEngine.Vector3 intersectionPoint)
        {
            return StagPoint.SpatialDatabase.LineSegment.Intersects2D(lhs:  this, rhs:  line, intersectionPoint: out  new UnityEngine.Vector3() {x = intersectionPoint.x, y = intersectionPoint.y, z = intersectionPoint.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Intersects2D(StagPoint.SpatialDatabase.LineSegment line)
        {
            var val_7;
            val_7 = 0;
            if((StagPoint.SpatialDatabase.LineSegment.Intersects2D(lhs:  this, rhs:  line, intersectionPoint: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f})) == false)
            {
                    return (bool)val_7 & 1;
            }
            
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rhs:  new UnityEngine.Vector3() {x = this._start, y = V11.16B, z = V12.16B})) != true)
            {
                    if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rhs:  new UnityEngine.Vector3() {x = this._end, y = V11.16B, z = V12.16B})) != true)
            {
                    if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rhs:  new UnityEngine.Vector3() {x = line._start, y = V11.16B, z = V12.16B})) == false)
            {
                goto label_11;
            }
            
            }
            
            }
            
            val_7 = 0;
            return (bool)val_7 & 1;
            label_11:
            bool val_7 = (UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rhs:  new UnityEngine.Vector3() {x = line._end, y = V11.16B, z = V12.16B})) ^ 1;
            return (bool)val_7 & 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Intersects2D(UnityEngine.Vector3 start, UnityEngine.Vector3 end, out UnityEngine.Vector3 intersectionPoint)
        {
            ._start = start;
            mem[1152921520154456124] = start.y;
            mem[1152921520154456128] = start.z;
            ._end = end;
            mem[1152921520154456136] = end.y;
            mem[1152921520154456140] = end.z;
            ._length = 0;
            ._center = 0;
            ._dir = 0;
            return StagPoint.SpatialDatabase.LineSegment.Intersects2D(lhs:  this, rhs:  new StagPoint.SpatialDatabase.LineSegment(), intersectionPoint: out  new UnityEngine.Vector3() {x = intersectionPoint.x, y = intersectionPoint.y, z = intersectionPoint.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float DistanceFromLine(UnityEngine.Vector3 test)
        {
            float val_8;
            UnityEngine.Vector3 val_12;
            var val_13;
            var val_14;
            var val_15;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this._start, y = V15.16B, z = V14.16B}, b:  new UnityEngine.Vector3() {x = this._end, y = V13.16B, z = V11.16B});
            val_8 = test.z;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = test.x, y = test.y, z = val_8}, b:  new UnityEngine.Vector3() {x = this._end, y = V13.16B, z = V11.16B});
            float val_3 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            if(val_3 <= 0f)
            {
                goto label_3;
            }
            
            float val_4 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            if(val_4 <= val_3)
            {
                goto label_6;
            }
            
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(d:  val_3 / val_4, a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this._end, y = val_1.y, z = val_1.y}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_8 = test.z;
            val_12 = val_7.x;
            val_13 = val_7.y;
            val_14 = val_7.z;
            return UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = test.x, y = test.y, z = val_8}, b:  new UnityEngine.Vector3() {x = val_12, y = val_1.y, z = val_1.z});
            label_3:
            val_15 = null;
            val_12 = this._end;
            return UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = test.x, y = test.y, z = val_8}, b:  new UnityEngine.Vector3() {x = val_12, y = val_1.y, z = val_1.z});
            label_6:
            val_15 = null;
            val_12 = this._start;
            return UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = test.x, y = test.y, z = val_8}, b:  new UnityEngine.Vector3() {x = val_12, y = val_1.y, z = val_1.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float SideOfLine(UnityEngine.Vector3 test)
        {
            return (float)StagPoint.SpatialDatabase.LineSegment.SideOfLine(start:  new UnityEngine.Vector3() {x = this._start, y = V7.16B, z = V16.16B}, end:  new UnityEngine.Vector3() {x = this._end}, test:  new UnityEngine.Vector3() {x = test.x, y = test.z, z = ???});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 test, bool clamp)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = test.x, y = test.y, z = test.z}, b:  new UnityEngine.Vector3() {x = this._start, y = V11.16B, z = V12.16B});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this._end, y = val_1.y, z = V6.16B}, b:  new UnityEngine.Vector3() {x = this._start, y = V11.16B, z = V12.16B});
            float val_3 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            if(clamp != false)
            {
                    if(val_3 < 0)
            {
                    return new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            }
            
                if(val_3 > this.length)
            {
                    return new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            }
            
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  val_3);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this._start, y = val_5.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            return new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool Intersects2D(StagPoint.SpatialDatabase.LineSegment lhs, StagPoint.SpatialDatabase.LineSegment rhs, out UnityEngine.Vector3 intersectionPoint)
        {
            var val_14;
            var val_15;
            var val_16;
            float val_17;
            float val_18;
            float val_19;
            var val_20;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            intersectionPoint.x = val_1.x;
            intersectionPoint.y = val_1.y;
            intersectionPoint.z = val_1.z;
            if(rhs != null)
            {
                    val_14 = rhs;
                val_15 = rhs + 56;
                val_16 = mem[rhs + 56 + 8];
                val_16 = rhs + 56 + 8;
                val_17 = mem[rhs + 56 + 20];
                val_17 = rhs + 56 + 20;
                val_18 = (rhs + 56 + 12) - rhs._start;
                val_19 = lhs._start - rhs._start;
            }
            else
            {
                    val_15 = rhs;
                val_14 = rhs;
                val_18 = rhs._end - rhs._start;
                val_19 = lhs._start - (rhs + 56);
                val_17 = mem[rhs + 56 + 20];
                val_17 = rhs + 56 + 20;
            }
            
            UnityEngine.Vector3 val_10 = lhs._start;
            float val_2 = val_17 - val_1.z;
            float val_3 = S8 - S10;
            float val_4 = lhs._end - val_10;
            float val_5 = S3 - val_1.y;
            float val_6 = val_2 * val_4;
            float val_8 = val_3 * val_18;
            val_6 = val_6 - (val_18 * val_5);
            val_2 = val_19 * val_2;
            val_8 = val_8 - val_2;
            if(val_6 != 0f)
            {
                goto label_6;
            }
            
            if(val_8 != 0f)
            {
                goto label_7;
            }
            
            if(val_10 >= (rhs + 56))
            {
                    if(val_10 <= (rhs + 68))
            {
                goto label_9;
            }
            
            }
            
            val_20 = 0;
            if((rhs + 56) < val_10)
            {
                    return (bool)val_20;
            }
            
            if((rhs + 56) > lhs._end)
            {
                    return (bool)val_20;
            }
            
            intersectionPoint.x = rhs + 56;
            intersectionPoint.z = val_1.z;
            goto label_12;
            label_6:
            val_1.z = val_8 / val_6;
            val_20 = 0;
            if(val_1.z < 0)
            {
                    return (bool)val_20;
            }
            
            if(val_1.z > 1f)
            {
                    return (bool)val_20;
            }
            
            val_3 = val_3 * val_4;
            val_3 = val_3 - (val_19 * val_5);
            val_3 = val_3 / val_6;
            val_20 = 0;
            if(val_3 < 0)
            {
                    return (bool)val_20;
            }
            
            if(val_3 > 1f)
            {
                    return (bool)val_20;
            }
            
            val_4 = val_4 * val_1.z;
            val_1.z = val_5 * val_1.z;
            val_10 = val_4 + val_10;
            val_1.z = val_1.z + val_1.y;
            intersectionPoint.z = 0f;
            intersectionPoint.x = 0f;
            intersectionPoint.y = 0f;
            goto label_17;
            label_7:
            val_20 = 0;
            return (bool)val_20;
            label_9:
            intersectionPoint.x = val_10;
            intersectionPoint.z = val_1.y;
            label_12:
            intersectionPoint.y = UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished;
            label_17:
            val_20 = 1;
            return (bool)val_20;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float SideOfLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Vector3 test)
        {
            float val_4 = end.x;
            val_4 = val_4 - start.x;
            start.x = test.x - start.x;
            start.x = (end.z - start.z) * start.x;
            start.x = start.x - (val_4 * (test.y - start.z));
            return UnityEngine.Mathf.Sign(f:  start.x);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Vector3 ClosestPointOnSegment(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Vector3 test, bool clamp)
        {
            float val_1;
            float val_8;
            float val_9;
            float val_10;
            val_8 = start.z;
            val_9 = start.y;
            val_10 = start.x;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = test.x, y = val_1, z = test.y}, b:  new UnityEngine.Vector3() {x = val_10, y = val_9, z = val_8});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z}, b:  new UnityEngine.Vector3() {x = val_10, y = val_9, z = val_8});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z}, b:  new UnityEngine.Vector3() {x = val_10, y = val_9, z = val_8});
            float val_5 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            if(clamp != false)
            {
                    if(val_5 < 0)
            {
                    return new UnityEngine.Vector3() {x = val_10, y = val_9, z = val_8};
            }
            
                if(val_5 > val_4.x)
            {
                    return new UnityEngine.Vector3() {x = val_10, y = val_9, z = val_8};
            }
            
            }
            
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  val_5);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10, y = val_9, z = val_8}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_10 = val_7.x;
            val_9 = val_7.y;
            val_8 = val_7.z;
            return new UnityEngine.Vector3() {x = val_10, y = val_9, z = val_8};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float DistanceFromLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Vector3 test)
        {
            float val_1;
            float val_9;
            float val_10;
            float val_11;
            float val_12;
            float val_13;
            val_9 = end.z;
            val_10 = end.y;
            val_11 = end.x;
            val_12 = start.x;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12, y = start.y, z = start.z}, b:  new UnityEngine.Vector3() {x = val_11, y = val_10, z = val_9});
            val_13 = val_1;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = test.x, y = val_13, z = test.y}, b:  new UnityEngine.Vector3() {x = val_11, y = val_10, z = val_9});
            float val_4 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            if(val_4 > 0f)
            {
                    float val_5 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
                if(val_5 <= val_4)
            {
                    return UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = test.x, y = val_1, z = test.y}, b:  new UnityEngine.Vector3() {x = val_11, y = val_10, z = val_9});
            }
            
                val_12 = val_4 / val_5;
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(d:  val_12, a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
                val_13 = val_10;
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11, y = val_13, z = val_9}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
                val_11 = val_7.x;
                val_10 = val_7.y;
                val_9 = val_7.z;
            }
            
            return UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = test.x, y = val_1, z = test.y}, b:  new UnityEngine.Vector3() {x = val_11, y = val_10, z = val_9});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return (string)System.String.Format(format:  "{0}->{1}", arg0:  this._start, arg1:  this._end);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void resetNullableFields()
        {
            this._length = 0;
            this._center = 0;
            this._dir = 0;
        }
    
    }

}
