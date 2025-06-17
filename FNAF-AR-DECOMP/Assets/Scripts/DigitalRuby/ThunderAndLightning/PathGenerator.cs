using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class PathGenerator
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int MinPointsForSpline = 4;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool Is2D;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float curveMultiplier = 3;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float splineMultiplier1 = -3;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float splineMultiplier2 = 3;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float splineMultiplier3 = 2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float splineDistanceClamp = 1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float splineEpsilon = 0.0001;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float SquareRoot(float x)
        {
            if(x <= _TYPE_MAX_)
            {
                    return (float)x;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static float Distance2D(ref UnityEngine.Vector3 point1, ref UnityEngine.Vector3 point2)
        {
            float val_1 = point2.x;
            val_1 = val_1 - point1.x;
            val_1 = val_1 * val_1;
            return DigitalRuby.ThunderAndLightning.PathGenerator.SquareRoot(x:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static float Distance3D(ref UnityEngine.Vector3 point1, ref UnityEngine.Vector3 point2)
        {
            float val_2 = point2.x;
            float val_1 = point2.y;
            val_1 = val_1 - point1.y;
            val_2 = val_2 - point1.x;
            val_2 = val_2 * val_2;
            val_1 = val_1 * val_1;
            val_2 = val_2 + val_1;
            val_2 = val_2 + val_1;
            return DigitalRuby.ThunderAndLightning.PathGenerator.SquareRoot(x:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void GetCurvePoint2D(ref UnityEngine.Vector3 start, ref UnityEngine.Vector3 end, ref UnityEngine.Vector3 ctr1, ref UnityEngine.Vector3 ctr2, float t, out UnityEngine.Vector3 point)
        {
            float val_10 = ctr1.x;
            float val_12 = ctr1.y;
            float val_16 = start.x;
            float val_9 = ctr2.x;
            float val_11 = ctr2.y;
            float val_14 = end.x;
            float val_15 = end.y;
            float val_13 = 3f;
            float val_1 = t * t;
            val_9 = val_9 - val_10;
            val_10 = val_10 - val_16;
            val_11 = val_11 - val_12;
            val_12 = val_12 - start.y;
            val_10 = val_10 * val_13;
            val_12 = val_12 * val_13;
            val_9 = val_9 * val_13;
            val_13 = val_11 * val_13;
            val_14 = val_14 - val_16;
            val_15 = val_15 - start.y;
            float val_2 = val_1 * t;
            val_9 = val_9 - val_10;
            val_13 = val_13 - val_12;
            val_14 = val_14 - val_10;
            val_15 = val_15 - val_12;
            val_10 = val_10 * t;
            t = val_12 * t;
            val_10 = val_16 + val_10;
            val_16 = val_1 * val_9;
            t = start.y + t;
            val_1 = val_1 * val_13;
            val_1 = t + val_1;
            float val_8 = (val_10 + val_16) + (val_2 * (val_14 - val_9));
            val_1 = val_1 + (val_2 * (val_15 - val_13));
            point.z = 0f;
            point.x = 0f;
            point.y = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void GetCurvePoint3D(ref UnityEngine.Vector3 start, ref UnityEngine.Vector3 end, ref UnityEngine.Vector3 ctr1, ref UnityEngine.Vector3 ctr2, float t, out UnityEngine.Vector3 point)
        {
            float val_16 = ctr1.x;
            float val_18 = ctr1.y;
            float val_25 = start.x;
            float val_26 = start.y;
            float val_20 = ctr1.z;
            float val_15 = ctr2.x;
            float val_17 = ctr2.y;
            float val_19 = ctr2.z;
            float val_22 = end.x;
            float val_23 = end.y;
            float val_24 = end.z;
            float val_21 = 3f;
            val_15 = val_15 - val_16;
            val_16 = val_16 - val_25;
            val_17 = val_17 - val_18;
            val_18 = val_18 - val_26;
            val_19 = val_19 - val_20;
            val_20 = val_20 - start.z;
            float val_1 = t * t;
            val_16 = val_16 * val_21;
            val_18 = val_18 * val_21;
            val_20 = val_20 * val_21;
            val_15 = val_15 * val_21;
            val_17 = val_17 * val_21;
            val_21 = val_19 * val_21;
            val_22 = val_22 - val_25;
            val_23 = val_23 - val_26;
            val_24 = val_24 - start.z;
            float val_2 = val_1 * t;
            val_15 = val_15 - val_16;
            val_17 = val_17 - val_18;
            val_21 = val_21 - val_20;
            val_22 = val_22 - val_16;
            val_23 = val_23 - val_18;
            val_24 = val_24 - val_20;
            val_16 = val_16 * t;
            val_18 = val_18 * t;
            t = val_20 * t;
            val_25 = val_25 + val_16;
            val_26 = val_26 + val_18;
            t = start.z + t;
            val_1 = val_1 * val_21;
            val_25 = val_25 + (val_1 * val_15);
            val_26 = val_26 + (val_1 * val_17);
            float val_12 = val_25 + (val_2 * (val_22 - val_15));
            float val_13 = val_26 + (val_2 * (val_23 - val_17));
            float val_14 = (t + val_1) + (val_2 * (val_24 - val_21));
            point.z = 0f;
            point.x = 0f;
            point.y = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void CalculateNonuniformCatmullRom(float p1, float p2, float p3, float p4, float distance1, float distance2, float distance3, out UnityEngine.Vector4 point)
        {
            p1 = p3 - p1;
            distance1 = (p2 - p1) / distance1;
            float val_3 = p4 - p2;
            p1 = p1 / (distance1 + distance2);
            p4 = p4 - p3;
            val_3 = val_3 / (distance2 + distance3);
            p4 = p4 / distance3;
            float val_6 = p3 + p3;
            val_6 = (p2 + p2) - val_6;
            float val_7 = p3 - p2;
            p1 = distance1 - p1;
            float val_12 = 3f;
            val_7 = val_7 / distance2;
            p3 = p3 * val_12;
            val_12 = p2 * val_12;
            val_3 = val_7 - val_3;
            p1 = val_7 + p1;
            p3 = p3 - val_12;
            p4 = p4 + val_3;
            float val_8 = p1 * distance2;
            float val_9 = p4 * distance2;
            distance2 = val_8 + val_9;
            val_9 = val_9 + (val_8 + val_8);
            p3 = p3 - val_9;
            float val_11 = val_6 + distance2;
            point.x = 0f;
            point.y = 0f;
            point.z = 0f;
            point.w = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static float CalculatePolynomial(ref UnityEngine.Vector4 point, float t)
        {
            float val_3 = point.w;
            float val_1 = t * t;
            val_3 = (val_1 * t) * val_3;
            val_1 = val_1 * point.z;
            val_1 = val_3 + val_1;
            t = point.y * t;
            t = val_1 + t;
            t = point.x + t;
            return (float)t;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void ClampSplineDistances(ref float distance1, ref float distance2, ref float distance3)
        {
            float val_1;
            if(distance2 < 0)
            {
                    val_1 = 1f;
                distance2 = val_1;
            }
            else
            {
                    val_1 = distance2;
            }
            
            if(distance1 < 0)
            {
                    distance1 = val_1;
            }
            
            if(distance3 >= 0)
            {
                    return;
            }
            
            distance3 = distance2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void GetSplinePoint2D(ref UnityEngine.Vector3 point1, ref UnityEngine.Vector3 point2, ref UnityEngine.Vector3 point3, ref UnityEngine.Vector3 point4, float t, out UnityEngine.Vector3 point)
        {
            float val_12 = point2.x;
            val_12 = val_12 - point1.x;
            val_12 = val_12 * val_12;
            float val_1 = DigitalRuby.ThunderAndLightning.PathGenerator.SquareRoot(x:  val_12);
            float val_13 = point3.x;
            val_13 = val_13 - point2.x;
            val_13 = val_13 * val_13;
            float val_2 = DigitalRuby.ThunderAndLightning.PathGenerator.SquareRoot(x:  val_13);
            float val_14 = point4.x;
            val_14 = val_14 - point3.x;
            val_14 = val_14 * val_14;
            float val_3 = DigitalRuby.ThunderAndLightning.PathGenerator.SquareRoot(x:  val_14);
            float val_4 = (val_2 < 0) ? 1f : (val_2);
            float val_5 = (val_1 < 0) ? (val_4) : (val_1);
            float val_6 = (val_3 < 0) ? (val_4) : (val_3);
            DigitalRuby.ThunderAndLightning.PathGenerator.CalculateNonuniformCatmullRom(p1:  point1.x, p2:  point2.x, p3:  point3.x, p4:  point4.x, distance1:  val_5, distance2:  val_4, distance3:  val_6, point: out  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            DigitalRuby.ThunderAndLightning.PathGenerator.CalculateNonuniformCatmullRom(p1:  point1.y, p2:  point2.y, p3:  point3.y, p4:  point4.y, distance1:  val_5, distance2:  val_4, distance3:  val_6, point: out  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            float val_17 = 0f;
            float val_15 = 0f;
            float val_16 = 0f;
            float val_7 = t * t;
            float val_8 = val_7 * t;
            float val_18 = 0f;
            val_15 = val_8 * val_15;
            val_16 = val_8 * val_16;
            float val_19 = 0f;
            val_17 = val_7 * val_17;
            val_7 = val_7 * 0f;
            val_18 = val_18 * t;
            val_19 = val_19 * t;
            val_15 = val_15 + val_17;
            val_7 = val_16 + val_7;
            val_15 = val_15 + val_18;
            float val_10 = 0f + val_15;
            float val_11 = 0f + (val_7 + val_19);
            point.z = 0f;
            point.x = 0f;
            point.y = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void GetSplinePoint3D(ref UnityEngine.Vector3 point1, ref UnityEngine.Vector3 point2, ref UnityEngine.Vector3 point3, ref UnityEngine.Vector3 point4, float t, out UnityEngine.Vector3 point)
        {
            float val_16 = point2.x;
            float val_15 = point2.y;
            val_15 = val_15 - point1.y;
            val_16 = val_16 - point1.x;
            val_16 = val_16 * val_16;
            val_15 = val_15 * val_15;
            val_16 = val_16 + val_15;
            val_16 = val_16 + val_15;
            float val_1 = DigitalRuby.ThunderAndLightning.PathGenerator.SquareRoot(x:  val_16);
            float val_18 = point3.x;
            float val_17 = point3.y;
            val_17 = val_17 - point2.y;
            val_18 = val_18 - point2.x;
            val_18 = val_18 * val_18;
            val_17 = val_17 * val_17;
            val_18 = val_18 + val_17;
            val_18 = val_18 + val_17;
            float val_2 = DigitalRuby.ThunderAndLightning.PathGenerator.SquareRoot(x:  val_18);
            float val_20 = point4.x;
            float val_19 = point4.y;
            val_19 = val_19 - point3.y;
            val_20 = val_20 - point3.x;
            val_20 = val_20 * val_20;
            val_19 = val_19 * val_19;
            val_20 = val_20 + val_19;
            val_20 = val_20 + val_19;
            float val_3 = DigitalRuby.ThunderAndLightning.PathGenerator.SquareRoot(x:  val_20);
            float val_4 = (val_2 < 0) ? 1f : (val_2);
            float val_5 = (val_1 < 0) ? (val_4) : (val_1);
            float val_6 = (val_3 < 0) ? (val_4) : (val_3);
            DigitalRuby.ThunderAndLightning.PathGenerator.CalculateNonuniformCatmullRom(p1:  point1.x, p2:  point2.x, p3:  point3.x, p4:  point4.x, distance1:  val_5, distance2:  val_4, distance3:  val_6, point: out  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            DigitalRuby.ThunderAndLightning.PathGenerator.CalculateNonuniformCatmullRom(p1:  point1.y, p2:  point2.y, p3:  point3.y, p4:  point4.y, distance1:  val_5, distance2:  val_4, distance3:  val_6, point: out  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            DigitalRuby.ThunderAndLightning.PathGenerator.CalculateNonuniformCatmullRom(p1:  point1.z, p2:  point2.z, p3:  point3.z, p4:  point4.z, distance1:  val_5, distance2:  val_4, distance3:  val_6, point: out  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            float val_24 = 0f;
            float val_21 = 0f;
            float val_25 = 0f;
            float val_22 = 0f;
            float val_23 = 0f;
            float val_7 = t * t;
            float val_8 = val_7 * t;
            float val_26 = 0f;
            float val_27 = 0f;
            val_21 = val_8 * val_21;
            val_22 = val_8 * val_22;
            val_23 = val_8 * val_23;
            val_24 = val_7 * val_24;
            val_25 = val_7 * val_25;
            val_7 = val_7 * 0f;
            val_21 = val_21 + val_24;
            val_22 = val_22 + val_25;
            val_7 = val_23 + val_7;
            val_26 = val_26 * t;
            val_27 = val_27 * t;
            val_21 = val_21 + val_26;
            float val_12 = 0f + val_21;
            float val_13 = 0f + (val_22 + val_27);
            float val_14 = 0f + (val_7 + (0f * t));
            point.z = 0f;
            point.x = 0f;
            point.y = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float CreateCurve(System.Collections.Generic.ICollection<UnityEngine.Vector3> path, UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Vector3 ctr1, UnityEngine.Vector3 ctr2, int numberOfSegments, float startT)
        {
            float val_1;
            float val_2;
            float val_9;
            float val_10;
            val_9 = ctr2.y;
            float val_6 = 1f / ((float)(System.Math.Min(val1:  1024, val2:  System.Math.Max(val1:  numberOfSegments, val2:  4))) + 1);
            if(DigitalRuby.ThunderAndLightning.PathGenerator.splineEpsilon == 0)
            {
                goto label_3;
            }
            
            if(val_9 > 1f)
            {
                goto label_12;
            }
            
            do
            {
                DigitalRuby.ThunderAndLightning.PathGenerator.GetCurvePoint2D(start: ref  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z}, end: ref  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z}, ctr1: ref  new UnityEngine.Vector3() {x = ctr1.x, y = val_2, z = ctr1.y}, ctr2: ref  new UnityEngine.Vector3() {x = ctr1.z, y = val_1, z = ctr2.x}, t:  val_9, point: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_10 = 0f;
                var val_9 = 0;
                val_9 = val_9 + 1;
                path.Add(item:  0);
                val_9 = val_6 + val_9;
            }
            while(val_9 <= 1f);
            
            goto label_12;
            label_3:
            if(val_9 <= 1f)
            {
                    do
            {
                DigitalRuby.ThunderAndLightning.PathGenerator.GetCurvePoint3D(start: ref  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z}, end: ref  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z}, ctr1: ref  new UnityEngine.Vector3() {x = ctr1.x, y = val_2, z = ctr1.y}, ctr2: ref  new UnityEngine.Vector3() {x = ctr1.z, y = val_1, z = ctr2.x}, t:  val_9, point: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_10 = 0f;
                var val_10 = 0;
                val_10 = val_10 + 1;
                path.Add(item:  0);
                val_9 = val_6 + val_9;
            }
            while(val_9 <= 1f);
            
            }
            
            label_12:
            float val_11 = -1f;
            val_11 = val_9 + val_11;
            return (float)val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool CreateSpline(System.Collections.Generic.ICollection<UnityEngine.Vector3> path, System.Collections.Generic.IList<UnityEngine.Vector3> points, int numberOfSegments, bool closePath)
        {
            var val_22;
            bool val_23;
            var val_25;
            var val_27;
            float val_28;
            var val_29;
            var val_32;
            var val_34;
            var val_36;
            float val_38;
            val_23 = closePath;
            var val_28 = 0;
            val_28 = val_28 + 1;
            if(points.Count >= 4)
            {
                    val_25 = 0;
                var val_29 = 0;
                val_29 = val_29 + 1;
                val_25 = 0;
            }
            else
            {
                    val_27 = 0;
                return (bool)val_27;
            }
            
            bool val_7 = val_23 ^ 1;
            bool val_8 = val_7;
            int val_9 = points.Count - val_8;
            val_8 = val_9 - 1;
            float val_30 = (float)System.Math.Min(val1:  1024, val2:  System.Math.Max(val1:  numberOfSegments, val2:  4));
            bool val_10 = val_23;
            val_30 = 1f / val_30;
            val_28 = 0f;
            val_10 = val_9 - val_10;
            float val_11 = val_30 * (float)val_9;
            label_54:
            val_22 = 1;
            var val_31 = 2;
            if(val_23 == false)
            {
                goto label_16;
            }
            
            val_29 = val_22 - ((0 >= val_8) ? (val_9) : 0);
            var val_14 = (val_31 <= val_8) ? 1 : 0;
            val_14 = val_14 | val_7;
            val_31 = val_31 - val_9;
            var val_16 = (val_14 != true) ? ((val_31 <= val_8) ? (val_31) : (val_9)) : (val_31);
            if(points != null)
            {
                goto label_19;
            }
            
            goto label_18;
            label_16:
            val_29 = val_22;
            if(points != null)
            {
                goto label_19;
            }
            
            label_18:
            label_19:
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_25 = 0;
            val_32 = public T System.Collections.Generic.IList<T>::get_Item(int index);
            T val_19 = points.Item[(0 == 0) ? (val_10) : -1];
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_32 = 0;
            val_34 = public T System.Collections.Generic.IList<T>::get_Item(int index);
            T val_21 = points.Item[0];
            var val_34 = 0;
            val_34 = val_34 + 1;
            val_34 = 0;
            val_36 = public T System.Collections.Generic.IList<T>::get_Item(int index);
            T val_23 = points.Item[1];
            val_23 = val_23;
            var val_35 = 0;
            val_35 = val_35 + 1;
            val_36 = 0;
            T val_25 = points.Item[(val_31 <= val_8) ? (val_31) : (val_9)];
            if(DigitalRuby.ThunderAndLightning.PathGenerator.splineEpsilon != 0)
            {
                goto label_39;
            }
            
            goto label_40;
            label_46:
            DigitalRuby.ThunderAndLightning.PathGenerator.GetSplinePoint2D(point1: ref  new UnityEngine.Vector3() {x = val_30, y = (float)val_9, z = ???}, point2: ref  new UnityEngine.Vector3() {x = val_30, y = (float)val_9, z = ???}, point3: ref  new UnityEngine.Vector3() {x = val_30, y = (float)val_9, z = ???}, point4: ref  new UnityEngine.Vector3() {x = val_30, y = (float)val_9, z = ???}, t:  val_28, point: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_38 = 0f;
            var val_36 = 0;
            val_36 = val_36 + 1;
            path.Add(item:  null);
            val_28 = val_11 + val_28;
            label_39:
            if(val_28 <= 1f)
            {
                goto label_46;
            }
            
            goto label_47;
            label_53:
            DigitalRuby.ThunderAndLightning.PathGenerator.GetSplinePoint3D(point1: ref  new UnityEngine.Vector3() {x = val_30, y = (float)val_9, z = ???}, point2: ref  new UnityEngine.Vector3() {x = val_30, y = (float)val_9, z = ???}, point3: ref  new UnityEngine.Vector3() {x = val_30, y = (float)val_9, z = ???}, point4: ref  new UnityEngine.Vector3() {x = val_30, y = (float)val_9, z = ???}, t:  val_28, point: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_38 = 0f;
            var val_37 = 0;
            val_37 = val_37 + 1;
            path.Add(item:  null);
            val_28 = val_11 + val_28;
            label_40:
            if(val_28 <= 1f)
            {
                goto label_53;
            }
            
            label_47:
            val_28 = val_28 + (-1f);
            if(val_22 != val_9)
            {
                goto label_54;
            }
            
            val_27 = 1;
            return (bool)val_27;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool CreateSplineWithSegmentDistance(System.Collections.Generic.ICollection<UnityEngine.Vector3> path, System.Collections.Generic.IList<UnityEngine.Vector3> points, float distancePerSegment, bool closePath)
        {
            var val_26;
            var val_27;
            var val_29;
            int val_31;
            var val_34;
            var val_36;
            var val_38;
            float val_40;
            float val_41;
            float val_43;
            bool val_36 = closePath;
            var val_34 = 0;
            val_34 = val_34 + 1;
            val_27 = 0;
            val_29 = 0;
            if(distancePerSegment <= 0f)
            {
                    return (bool)val_29;
            }
            
            if(points.Count < 4)
            {
                    return (bool)val_29;
            }
            
            var val_35 = 0;
            val_35 = val_35 + 1;
            val_27 = 0;
            bool val_5 = val_36 ^ 1;
            bool val_6 = val_5;
            int val_7 = points.Count - val_6;
            val_6 = val_7 - 1;
            bool val_8 = val_36;
            val_8 = val_7 - val_8;
            label_55:
            int val_10 = 0 + 1;
            var val_12 = 0 + 2;
            val_26 = val_36;
            if(val_36 == false)
            {
                goto label_14;
            }
            
            val_31 = val_10 - ((0 >= val_6) ? (val_7) : 0);
            var val_14 = (val_12 <= val_6) ? 1 : 0;
            val_14 = val_14 | val_5;
            val_12 = val_12 - val_7;
            val_36 = (val_14 != true) ? ((val_12 <= val_6) ? (val_12) : (val_7)) : (val_12);
            if(points != null)
            {
                goto label_17;
            }
            
            goto label_16;
            label_14:
            val_31 = val_10;
            val_36 = (val_12 <= val_6) ? (val_12) : (val_7);
            if(points != null)
            {
                goto label_17;
            }
            
            label_16:
            label_17:
            var val_37 = 0;
            val_37 = val_37 + 1;
            val_27 = 0;
            val_34 = public T System.Collections.Generic.IList<T>::get_Item(int index);
            T val_17 = points.Item[(0 == 0) ? (val_8) : (0 - 1)];
            var val_38 = 0;
            val_38 = val_38 + 1;
            val_34 = 0;
            val_36 = public T System.Collections.Generic.IList<T>::get_Item(int index);
            T val_19 = points.Item[0];
            var val_39 = 0;
            val_39 = val_39 + 1;
            val_36 = 0;
            val_38 = public T System.Collections.Generic.IList<T>::get_Item(int index);
            T val_21 = points.Item[val_31];
            float val_41 = V1.16B;
            var val_40 = 0;
            val_40 = val_40 + 1;
            val_38 = 0;
            T val_23 = points.Item[val_36];
            float val_24 = V1.16B - val_41;
            if(DigitalRuby.ThunderAndLightning.PathGenerator.splineEpsilon != 0)
            {
                    float val_25 = distancePerSegment - distancePerSegment;
                val_25 = val_25 * val_25;
                val_24 = val_24 * val_24;
                val_24 = val_25 + val_24;
                float val_26 = DigitalRuby.ThunderAndLightning.PathGenerator.SquareRoot(x:  val_24);
                val_26 = val_26 / distancePerSegment;
                val_41 = 1f / val_26;
                do
            {
                DigitalRuby.ThunderAndLightning.PathGenerator.GetSplinePoint2D(point1: ref  new UnityEngine.Vector3() {x = distancePerSegment, y = ???, z = ???}, point2: ref  new UnityEngine.Vector3() {x = distancePerSegment, y = V1.16B, z = V2.16B}, point3: ref  new UnityEngine.Vector3() {x = distancePerSegment, y = val_41, z = V2.16B}, point4: ref  new UnityEngine.Vector3() {x = distancePerSegment, y = ???, z = ???}, t:  0f, point: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_40 = 0f;
                val_41 = 0f;
                var val_42 = 0;
                val_42 = val_42 + 1;
                path.Add(item:  null);
                val_43 = (UnityEngine.Mathf.Clamp(value:  val_41, min:  0.00390625f, max:  1f)) + 0f;
            }
            while(val_43 <= 1f);
            
            }
            else
            {
                    float val_29 = distancePerSegment - distancePerSegment;
                float val_30 = V2.16B - V2.16B;
                val_24 = val_24 * val_24;
                val_29 = val_29 * val_29;
                val_24 = val_29 + val_24;
                val_30 = val_30 * val_30;
                val_24 = val_24 + val_30;
                float val_31 = DigitalRuby.ThunderAndLightning.PathGenerator.SquareRoot(x:  val_24);
                val_31 = val_31 / distancePerSegment;
                val_41 = 1f / val_31;
                do
            {
                DigitalRuby.ThunderAndLightning.PathGenerator.GetSplinePoint3D(point1: ref  new UnityEngine.Vector3() {x = distancePerSegment, y = ???, z = ???}, point2: ref  new UnityEngine.Vector3() {x = distancePerSegment, y = V1.16B, z = V2.16B}, point3: ref  new UnityEngine.Vector3() {x = distancePerSegment, y = val_41, z = V2.16B}, point4: ref  new UnityEngine.Vector3() {x = distancePerSegment, y = ???, z = ???}, t:  0f, point: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_40 = 0f;
                val_41 = 0f;
                var val_43 = 0;
                val_43 = val_43 + 1;
                path.Add(item:  null);
                val_43 = (UnityEngine.Mathf.Clamp(value:  val_41, min:  0.00390625f, max:  1f)) + 0f;
            }
            while(val_43 <= 1f);
            
            }
            
            if(val_10 != val_7)
            {
                goto label_55;
            }
            
            val_29 = 1;
            return (bool)val_29;
        }
    
    }

}
