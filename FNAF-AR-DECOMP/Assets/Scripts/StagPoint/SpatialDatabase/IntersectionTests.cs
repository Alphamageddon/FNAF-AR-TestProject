using UnityEngine;

namespace StagPoint.SpatialDatabase
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IntersectionTests
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool Intersects(ref UnityEngine.Ray ray, ref UnityEngine.Bounds bounds)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, d:  3.402823E+38f);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  0.5f);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            return (bool)StagPoint.SpatialDatabase.IntersectionTests.Intersects(start: ref  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, end: ref  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, bounds: ref  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = bounds.m_Center.x, y = bounds.m_Center.y, z = bounds.m_Center.z}, m_Extents = new UnityEngine.Vector3() {x = bounds.m_Extents.x, y = bounds.m_Extents.y, z = bounds.m_Extents.z}});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool Intersects(ref UnityEngine.Vector3 start, ref UnityEngine.Vector3 end, ref UnityEngine.Bounds bounds)
        {
            float val_16;
            float val_17;
            var val_18;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z}, b:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z}, b:  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_16 = System.Math.Abs(val_2.x);
            if(System.Math.Abs(val_5.x) <= (val_1.x + val_16))
            {
                    float val_18 = val_1.y;
                float val_16 = System.Math.Abs(val_2.y);
                val_18 = val_18 + val_16;
                if(System.Math.Abs(val_5.y) <= val_18)
            {
                    float val_21 = val_1.z;
                float val_20 = System.Math.Abs(val_2.z);
                val_21 = val_21 + val_20;
                if(System.Math.Abs(val_5.z) <= val_21)
            {
                    val_16 = val_16 + (1.401298E-45f);
                val_17 = val_20 + (1.401298E-45f);
                val_17 = val_17;
                float val_22 = val_2.z;
                float val_25 = val_1.z;
                float val_23 = val_2.y;
                float val_24 = val_1.y;
                val_22 = val_22 * val_5.y;
                val_23 = val_23 * val_5.z;
                val_24 = val_24 * val_17;
                val_25 = val_25 * val_16;
                val_22 = val_22 - val_23;
                if(System.Math.Abs(val_22) <= (val_24 + val_25))
            {
                    val_16 = val_16 + (1.401298E-45f);
                val_17 = val_17;
                float val_27 = val_2.z;
                float val_28 = val_1.z;
                float val_8 = val_2.x * val_5.z;
                val_27 = val_27 * val_5.x;
                val_28 = val_28 * val_16;
                val_8 = val_8 - val_27;
                if(System.Math.Abs(val_8) <= ((val_1.x * val_17) + val_28))
            {
                    float val_30 = val_2.y;
                float val_31 = val_1.y;
                val_30 = val_30 * val_5.x;
                val_31 = val_31 * val_16;
                val_30 = val_30 - (val_2.x * val_5.y);
                var val_14 = (System.Math.Abs(val_30) <= ((val_1.x * val_16) + val_31)) ? 1 : 0;
                return (bool)val_18;
            }
            
            }
            
            }
            
            }
            
            }
            
            val_18 = 0;
            return (bool)val_18;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool Intersects(ref UnityEngine.Bounds box, ref UnityEngine.Vector3 center, float radius)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.Max(lhs:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, rhs:  new UnityEngine.Vector3() {x = radius, y = V1.16B, z = V2.16B});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Min(lhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
            return (bool)(val_3.x <= (radius * radius)) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static StagPoint.SpatialDatabase.IntersectionType GetIntersectionType(ref UnityEngine.Bounds box, ref UnityEngine.Vector3 center, float radius)
        {
            float val_10;
            var val_11;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.Max(lhs:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, rhs:  new UnityEngine.Vector3() {x = radius, y = V1.16B, z = V2.16B});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Min(lhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            val_10 = val_2.y;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
            if(val_3.x > (radius * radius))
            {
                    val_11 = 0;
                return (StagPoint.SpatialDatabase.IntersectionType)((System.Math.Abs(val_10 = val_5.y)) <= (val_5.y - radius)) ? (1 + 1) : 1;
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_10, z = val_2.z}, b:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
            float val_11 = System.Math.Abs(val_5.x);
            float val_7 = val_5.x - radius;
            float val_12 = System.Math.Abs(val_5.z);
            float val_8 = val_5.z - radius;
            return (StagPoint.SpatialDatabase.IntersectionType)(System.Math.Abs(val_10) <= (val_5.y - radius)) ? (1 + 1) : 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static StagPoint.SpatialDatabase.IntersectionType GetIntersectionType(ref UnityEngine.Vector3 center, float radius, ref UnityEngine.Bounds box)
        {
            float val_8;
            var val_9;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.Max(lhs:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, rhs:  new UnityEngine.Vector3() {x = radius, y = V1.16B, z = V2.16B});
            val_8 = val_1.y;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Min(lhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_8, z = val_1.z}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
            float val_4 = radius * radius;
            if(val_3.x > val_4)
            {
                    val_9 = 0;
                return (StagPoint.SpatialDatabase.IntersectionType)(val_5.x <= val_6.x) ? 2 : (0 + 1);
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_4, z = val_3.z}, b:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
            val_8 = val_5.x;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            val_6.x = radius - val_6.x;
            return (StagPoint.SpatialDatabase.IntersectionType)(val_5.x <= val_6.x) ? 2 : (0 + 1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool Intersects(ref UnityEngine.Bounds lhs, ref UnityEngine.Bounds rhs)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            var val_3 = (System.Math.Abs(val_1.x) <= val_2.x) ? 1 : 0;
            val_3 = val_3 & ((System.Math.Abs(val_1.y) <= val_2.y) ? 1 : 0);
            return (bool)((System.Math.Abs(val_1.z) <= val_2.z) ? 1 : 0) & val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static StagPoint.SpatialDatabase.IntersectionType GetIntersectionType(ref UnityEngine.Bounds lhs, ref UnityEngine.Bounds rhs)
        {
            var val_5;
            var val_6;
            float val_7;
            float val_8;
            var val_9;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
            val_5 = val_1.y;
            val_6 = val_1.z;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            val_7 = val_2.x;
            val_8 = System.Math.Abs(val_6);
            if((val_8 <= val_2.z) && (System.Math.Abs(val_1.x) <= val_7))
            {
                    float val_6 = System.Math.Abs(val_5);
                if(val_6 <= val_2.y)
            {
                    val_7 = val_2.y;
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_2.z});
                val_5 = val_3.x;
                val_6 = val_3.z;
                var val_4 = (val_6 <= val_3.y) ? (1 + 1) : 1;
                return (StagPoint.SpatialDatabase.IntersectionType)val_9;
            }
            
            }
            
            val_9 = 0;
            return (StagPoint.SpatialDatabase.IntersectionType)val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static StagPoint.SpatialDatabase.IntersectionType GetIntersectionType(UnityEngine.Plane[] planes, ref UnityEngine.Bounds bounds)
        {
            var val_7;
            int val_8;
            var val_9;
            if(planes == null)
            {
                goto label_1;
            }
            
            if(planes.Length < 1)
            {
                goto label_2;
            }
            
            val_8 = planes.Length & 4294967295;
            val_7 = 0;
            var val_8 = 0;
            goto label_3;
            label_12:
            val_7 = 1;
            val_8 = val_8 | ((System.Math.Abs(S8) <= S9) ? 1 : 0);
            if(val_7 >= (long)val_8)
            {
                    return (StagPoint.SpatialDatabase.IntersectionType)((val_8 & 1) != 0) ? (1 + 1) : 1;
            }
            
            val_8 = planes.Length;
            label_3:
            float val_9 = System.Math.Abs(-6.327364E-29f);
            float val_10 = System.Math.Abs(V1.16B);
            val_9 = V0.16B * val_9;
            val_10 = V1.16B * val_10;
            val_9 = val_9 + val_10;
            float val_3 = (V2.16B * System.Math.Abs(V2.16B)) + val_9;
            float val_4 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = -6.327364E-29f, y = V1.16B, z = V2.16B}, rhs:  new UnityEngine.Vector3() {x = ???, y = ???, z = V2.16B});
            float val_12 = val_4;
            val_12 = val_12 + val_4;
            if(val_12 >= 0)
            {
                goto label_12;
            }
            
            val_9 = 0;
            return (StagPoint.SpatialDatabase.IntersectionType)((val_8 & 1) != 0) ? (1 + 1) : 1;
            label_2:
            val_9 = 2;
            return (StagPoint.SpatialDatabase.IntersectionType)((val_8 & 1) != 0) ? (1 + 1) : 1;
            label_1:
            System.ArgumentNullException val_6 = new System.ArgumentNullException(paramName:  "planes");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IntersectionTests()
        {
        
        }
    
    }

}
