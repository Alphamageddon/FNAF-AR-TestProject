using UnityEngine;

namespace Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class EarcutLibrary
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.List<int> Earcut(System.Collections.Generic.List<float> data, System.Collections.Generic.List<int> holeIndices, int dim)
        {
            var val_25;
            int val_26;
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_27;
            float val_28;
            float val_29;
            float val_31;
            float val_32;
            float val_33;
            int val_1 = System.Math.Max(val1:  dim, val2:  2);
            val_25 = holeIndices.Count;
            if(val_25 > 0)
            {
                    val_26 = holeIndices.Item[0] * val_1;
            }
            else
            {
                    val_26 = data.Count;
            }
            
            val_27 = Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.linkedList(data:  data, start:  0, end:  val_26, dim:  val_1, clockwise:  true);
            System.Collections.Generic.List<System.Int32> val_6 = null;
            double val_24 = (double)val_5.i;
            val_24 = val_24 * 1.5;
            val_6 = new System.Collections.Generic.List<System.Int32>(capacity:  (int)val_24);
            if(val_27 == null)
            {
                    return val_6;
            }
            
            if(val_25 >= 1)
            {
                    val_27 = Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.EliminateHoles(data:  data, holeIndices:  holeIndices, outerNode:  val_27, dim:  val_1);
            }
            
            val_28 = 0f;
            val_29 = 0f;
            if(data.Count > ((val_1 + (val_1 << 2)) << 4))
            {
                    if(data != null)
            {
                    val_29 = data.Item[0];
            }
            else
            {
                    val_29 = 0.Item[0];
            }
            
                val_25 = 1152921518846917296;
                val_28 = data.Item[1];
                if(val_1 < val_26)
            {
                    int val_25 = val_1;
                do
            {
                if(data != null)
            {
                    val_31 = data.Item[val_25];
            }
            else
            {
                    val_31 = 0.Item[val_25];
            }
            
                float val_16 = data.Item[val_25 + 1];
                var val_17 = (val_31 < 0) ? (val_31) : (val_29);
                var val_18 = (val_16 < 0) ? (val_16) : (val_28);
                val_25 = val_25 + val_1;
                var val_19 = (val_31 > val_29) ? (val_31) : (val_29);
                var val_20 = (val_16 > val_28) ? (val_16) : (val_28);
            }
            while(val_25 < val_26);
            
            }
            else
            {
                    val_33 = val_28;
                val_32 = val_29;
            }
            
            }
            
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.earcutLinked(ear:  val_27, triangles:  val_6, dim:  val_1, minX:  val_29, minY:  val_28, size:  System.Math.Max(val1:  val_32 - val_29, val2:  val_33 - val_28), pass:  0);
            return val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void earcutLinked(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node ear, System.Collections.Generic.List<int> triangles, int dim, float minX, float minY, float size, int pass = 0)
        {
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_8;
            var val_9;
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_10;
            val_8 = ear;
            goto label_20;
            label_22:
            if((size > 0f) && (pass == 0))
            {
                    Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.indexCurve(start:  val_8, minX:  minX, minY:  minY, size:  size);
            }
            
            label_17:
            label_10:
            if(val_8 != null)
            {
                    val_9 = val_8;
                val_10 = ear.prev;
            }
            else
            {
                    val_10 = 64;
                val_9 = 32;
            }
            
            if(val_10 == ear.next)
            {
                    return;
            }
            
            if(size <= 0f)
            {
                goto label_6;
            }
            
            if((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.isEarHashed(ear:  val_8, minX:  minX, minY:  minY, size:  size)) == false)
            {
                goto label_7;
            }
            
            goto label_9;
            label_6:
            if((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.isEar(ear:  val_8)) == true)
            {
                goto label_9;
            }
            
            label_7:
            if(ear.next != val_8)
            {
                goto label_10;
            }
            
            goto label_11;
            label_9:
            triangles.Add(item:  0 / dim);
            triangles.Add(item:  ear.next.i / dim);
            triangles.Add(item:  ear.i / dim);
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.removeNode(p:  val_8);
            goto label_17;
            label_11:
            if(pass == 0)
            {
                goto label_18;
            }
            
            if(pass != 1)
            {
                goto label_19;
            }
            
            val_8 = Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.cureLocalIntersections(start:  val_8, triangles:  triangles, dim:  dim);
            goto label_20;
            label_18:
            val_8 = Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.FilterPoints(start:  val_8, end:  0);
            label_20:
            if(val_8 != null)
            {
                goto label_22;
            }
            
            return;
            label_19:
            if(pass != 2)
            {
                    return;
            }
            
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.splitEarcut(start:  val_8, triangles:  triangles, dim:  dim, minX:  minX, minY:  minY, size:  size);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool isEarHashed(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node ear, float minX, float minY, float size)
        {
            float val_16;
            float val_17;
            var val_18;
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_19;
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_20;
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            float val_26;
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_27;
            float val_28;
            var val_29;
            val_16 = size;
            val_17 = minX;
            if(ear != null)
            {
                    val_18 = ear;
                val_19 = ear.prev;
            }
            else
            {
                    val_18 = 32;
                val_19 = 64;
            }
            
            val_20 = val_19;
            val_21 = ear.next;
            if((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.area(p:  val_20, q:  ear, r:  val_21)) >= 0f)
            {
                goto label_49;
            }
            
            if(val_19 == 0)
            {
                    val_20 = 0;
            }
            
            if(0f >= 0)
            {
                goto label_4;
            }
            
            if(ear.next == null)
            {
                    val_20 = 0;
            }
            
            val_22 = ear.next;
            if(0f >= 0)
            {
                goto label_9;
            }
            
            val_22 = val_19;
            goto label_9;
            label_4:
            if(ear.next == null)
            {
                    val_20 = 0;
            }
            
            val_22 = ear.next;
            if(ear.x < 0)
            {
                    val_22 = ear;
            }
            
            label_9:
            if(0f >= 0)
            {
                goto label_10;
            }
            
            val_23 = ear.next;
            if(0f >= 0)
            {
                goto label_13;
            }
            
            val_23 = val_19;
            goto label_13;
            label_10:
            val_23 = ear.next;
            if(ear.y < 0)
            {
                    val_23 = ear;
            }
            
            label_13:
            if(0f <= ear.x)
            {
                goto label_14;
            }
            
            val_24 = ear.next;
            if(0f <= ear.next.x)
            {
                goto label_17;
            }
            
            val_24 = val_19;
            goto label_17;
            label_14:
            val_24 = ear.next;
            if(ear.x > ear.next.x)
            {
                    val_24 = ear;
            }
            
            label_17:
            if(0f <= ear.y)
            {
                goto label_18;
            }
            
            val_25 = ear.next;
            if(0f <= ear.next.y)
            {
                goto label_21;
            }
            
            val_25 = val_19;
            goto label_21;
            label_18:
            val_25 = ear.next;
            if(ear.y > ear.next.y)
            {
                    val_25 = ear;
            }
            
            label_21:
            val_26 = val_16;
            val_27 = ear.nextZ;
            if(val_27 == null)
            {
                goto label_23;
            }
            
            label_34:
            if(ear.nextZ.mZOrder > (Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.zOrder(x:  ear.x, y:  ear.y, minX:  val_17, minY:  minY, size:  val_26)))
            {
                goto label_23;
            }
            
            if((val_27 == val_18) || (val_27 == ear.next))
            {
                goto label_32;
            }
            
            if(val_19 != 0)
            {
                    val_16 = 0f;
            }
            else
            {
                    val_16 = 0f;
            }
            
            float val_16 = ear.next.x;
            float val_17 = ear.nextZ.x;
            val_26 = ear.nextZ.y;
            val_16 = val_16 - val_17;
            float val_4 = 0f - val_26;
            float val_5 = val_16 - val_17;
            float val_6 = ear.next.y - val_26;
            float val_7 = val_16 * val_4;
            val_7 = val_7 - (val_5 * val_6);
            if(val_7 < 0f)
            {
                goto label_32;
            }
            
            val_26 = ear.y - val_26;
            val_17 = ear.x - val_17;
            val_5 = val_5 * val_26;
            val_4 = val_17 * val_4;
            val_4 = val_5 - val_4;
            if(val_4 < 0f)
            {
                goto label_32;
            }
            
            val_6 = val_17 * val_6;
            val_16 = val_16 * val_26;
            val_16 = val_6 - val_16;
            if(val_16 < 0f)
            {
                goto label_32;
            }
            
            val_21 = ear.nextZ.next;
            if((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.area(p:  ear.nextZ.prev, q:  val_27, r:  val_21)) >= 0f)
            {
                goto label_49;
            }
            
            label_32:
            if(ear.nextZ.nextZ != null)
            {
                goto label_34;
            }
            
            label_23:
            val_27 = ear.prevZ;
            if(val_27 == null)
            {
                goto label_37;
            }
            
            label_50:
            if(ear.prevZ.mZOrder < (Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.zOrder(x:  ear.x, y:  ear.y, minX:  val_17, minY:  minY, size:  val_16)))
            {
                goto label_37;
            }
            
            if((val_27 != 64) && (val_27 != ear.next))
            {
                    if(val_19 != 0)
            {
                    val_16 = 0f;
            }
            else
            {
                    val_16 = 0f;
            }
            
                val_17 = ear.y;
                if(ear.next != null)
            {
                    val_28 = ear.next.x;
            }
            else
            {
                    val_28 = ear.next.x;
            }
            
                float val_20 = ear.prevZ.x;
                float val_19 = ear.prevZ.y;
                float val_18 = ear.next.y;
                float val_10 = val_28 - val_20;
                float val_11 = 0f - val_19;
                float val_12 = val_16 - val_20;
                val_18 = val_18 - val_19;
                float val_13 = val_10 * val_11;
                val_13 = val_13 - (val_12 * val_18);
                if(val_13 >= 0f)
            {
                    val_19 = val_17 - val_19;
                val_20 = ear.x - val_20;
                val_12 = val_12 * val_19;
                val_11 = val_20 * val_11;
                val_11 = val_12 - val_11;
                if(val_11 >= 0f)
            {
                    val_18 = val_20 * val_18;
                val_10 = val_10 * val_19;
                val_10 = val_18 - val_10;
                if(val_10 >= 0f)
            {
                    if((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.area(p:  ear.prevZ.prev, q:  val_27, r:  ear.prevZ.next)) >= 0f)
            {
                goto label_49;
            }
            
            }
            
            }
            
            }
            
            }
            
            val_27 = ear.prevZ.prevZ;
            if(val_27 != null)
            {
                goto label_50;
            }
            
            label_37:
            val_29 = 1;
            return (bool)val_29;
            label_49:
            val_29 = 0;
            return (bool)val_29;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int zOrder(float x, float y, float minX, float minY, float size)
        {
            x = x - minX;
            y = y - minY;
            x = x * 32767f;
            y = y * 32767f;
            x = x / size;
            y = y / size;
            int val_2 = (int)x;
            int val_3 = (int)y;
            val_2 = val_2 | (val_2 << 8);
            val_3 = val_3 | (val_3 << 8);
            val_2 = val_2 & 16711935;
            val_3 = val_3 & 16711935;
            int val_4 = (int)(float)val_2;
            int val_5 = (int)(float)val_3;
            val_4 = val_4 | (val_4 << 4);
            val_5 = val_5 | (val_5 << 4);
            val_4 = val_4 & 252645135;
            val_5 = val_5 & 252645135;
            int val_6 = (int)(float)val_4;
            int val_7 = (int)(float)val_5;
            val_6 = val_6 | (val_6 << 2);
            val_7 = val_7 | (val_7 << 2);
            val_6 = val_6 & 858993459;
            val_7 = val_7 & 858993459;
            int val_8 = (int)(float)val_6;
            int val_9 = (int)(float)val_7;
            val_8 = val_8 | (val_8 << 1);
            val_9 = val_9 | (val_9 << 1);
            val_8 = val_8 & 1431655765;
            val_9 = val_9 & 1431655765;
            return (int)(int)(float)val_8 | ((int)(float)val_9 << 1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void splitEarcut(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node start, System.Collections.Generic.List<int> triangles, int dim, float minX, float minY, float size)
        {
            label_7:
            label_5:
            if(start.next.next == start.prev)
            {
                goto label_2;
            }
            
            if((start.i == start.next.next.i) || ((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.isValidDiagonal(a:  start, b:  start.next.next)) == false))
            {
                goto label_5;
            }
            
            goto label_6;
            label_2:
            if(start.next != start)
            {
                goto label_7;
            }
            
            return;
            label_6:
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.earcutLinked(ear:  Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.FilterPoints(start:  start, end:  start.next), triangles:  triangles, dim:  dim, minX:  minX, minY:  minY, size:  size, pass:  0);
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.earcutLinked(ear:  Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.FilterPoints(start:  Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.SplitPolygon(a:  start, b:  start.next.next), end:  val_2.next), triangles:  triangles, dim:  dim, minX:  minX, minY:  minY, size:  size, pass:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool isValidDiagonal(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node a, Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node b)
        {
            int val_4 = b.i;
            if(a.next.i == val_4)
            {
                    return false;
            }
            
            if(a.prev == null)
            {
                    val_4 = b.i;
            }
            
            if(a.prev.i == val_4)
            {
                    return false;
            }
            
            if((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.intersectsPolygon(a:  a, b:  b)) == true)
            {
                    return false;
            }
            
            if((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.locallyInside(a:  a, b:  b)) == false)
            {
                    return false;
            }
            
            if((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.locallyInside(a:  b, b:  a)) == false)
            {
                    return false;
            }
            
            return Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.middleInside(a:  a, b:  b);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool middleInside(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node a, Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node b)
        {
            float val_6;
            float val_7;
            var val_8;
            float val_9;
            float val_10;
            float val_11;
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_12;
            float val_8 = a.x;
            if(b != null)
            {
                    val_6 = b.x;
                val_7 = a.y;
            }
            else
            {
                    val_6 = 1.401298E-45f;
                val_7 = a.y;
            }
            
            float val_7 = b.y;
            val_8 = 0;
            val_7 = val_7 + val_7;
            val_8 = (val_8 + val_6) * 0.5f;
            float val_2 = val_7 * 0.5f;
            label_12:
            if(a != null)
            {
                    val_9 = a;
                val_10 = a.y;
            }
            else
            {
                    val_10 = 2.105703E-38f;
                val_9 = 2.105703E-38f;
            }
            
            if((((val_10 > val_2) ? 1 : 0) == ((a.next.y > val_2) ? 1 : 0)) || (a.next.y == val_9))
            {
                goto label_11;
            }
            
            val_12 = a.next;
            if(a.next != null)
            {
                goto label_9;
            }
            
            val_12 = a.next;
            if(val_12 == null)
            {
                goto label_10;
            }
            
            val_11 = 2.105703E-38f;
            label_9:
            float val_9 = a.next.x;
            val_9 = val_9 - a.x;
            val_9 = val_9 * (val_2 - val_11);
            val_11 = a.next.y - val_11;
            val_11 = val_9 / val_11;
            val_11 = a.x + val_11;
            if(val_8 < 0)
            {
                    val_8 = val_8 ^ 1;
            }
            
            label_11:
            if(a.next != a)
            {
                goto label_12;
            }
            
            return (bool)val_8 & 1;
            label_10:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool intersectsPolygon(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node a, Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node b)
        {
            int val_2;
            int val_3;
            do
            {
                val_2 = a.i;
                if(a.i != val_2)
            {
                    if(a.next == null)
            {
                    val_2 = a.i;
            }
            
                if(a.next.i != val_2)
            {
                    val_3 = b.i;
                if(a.i != val_3)
            {
                    if(a.next == null)
            {
                    val_3 = b.i;
            }
            
                if(a.next.i != val_3)
            {
                    if((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.intersects(p1:  a, q1:  a.next, p2:  a, q2:  b)) == true)
            {
                    return false;
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            while(a.next != a);
            
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node cureLocalIntersections(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node start, System.Collections.Generic.List<int> triangles, int dim)
        {
            var val_8;
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_9;
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_10;
            val_8 = start;
            do
            {
                if(start != null)
            {
                    val_9 = start.prev;
            }
            else
            {
                    val_9 = 64;
            }
            
                val_10 = start.next.next;
                if(((((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.equals(p1:  val_9, p2:  val_10)) != true) && ((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.intersects(p1:  val_9, q1:  start, p2:  start.next, q2:  val_10)) != false)) && ((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.locallyInside(a:  val_9, b:  val_10)) != false)) && ((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.locallyInside(a:  val_10, b:  val_9)) != false))
            {
                    triangles.Add(item:  0 / dim);
                triangles.Add(item:  start.i / dim);
                triangles.Add(item:  start.next.next.i / dim);
                Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.removeNode(p:  start);
                Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.removeNode(p:  start.next);
                val_8 = val_10;
            }
            else
            {
                    val_10 = start;
            }
            
            }
            while(start.next != val_8);
            
            return (Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool intersects(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node p1, Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node q1, Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node p2, Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node q2)
        {
            var val_13;
            if((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.equals(p1:  p1, p2:  q1)) != false)
            {
                    if((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.equals(p1:  p2, p2:  q2)) == true)
            {
                goto label_1;
            }
            
            }
            
            if(((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.equals(p1:  p1, p2:  q2)) != false) && ((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.equals(p1:  p2, p2:  q1)) != false))
            {
                    label_1:
                val_13 = 1;
                return (bool)val_13;
            }
            
            if((((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.area(p:  p1, q:  q1, r:  p2)) > 0f) ? 1 : 0) != (((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.area(p:  p1, q:  q1, r:  q2)) > 0f) ? 1 : 0))
            {
                    val_13 = (((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.area(p:  p2, q:  q2, r:  p1)) > 0f) ? 1 : 0) ^ (((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.area(p:  p2, q:  q2, r:  q1)) > 0f) ? 1 : 0);
                return (bool)val_13;
            }
            
            val_13 = 0;
            return (bool)val_13;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool isEar(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node ear)
        {
            var val_10;
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_11;
            float val_12;
            float val_13;
            float val_14;
            var val_15;
            if(ear != null)
            {
                    val_10 = ear;
                val_11 = ear.prev;
            }
            else
            {
                    val_10 = 32;
                val_11 = 64;
            }
            
            if((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.area(p:  val_11, q:  ear, r:  ear.next)) < 0f)
            {
                    if(ear.next.next != val_10)
            {
                    do
            {
                if(val_11 != 0)
            {
                    val_12 = 0f;
            }
            else
            {
                    val_12 = 0f;
            }
            
                if(ear.next != null)
            {
                    val_13 = ear.next.x;
            }
            else
            {
                    val_13 = ear.next.x;
            }
            
                if(ear.next.next != null)
            {
                    val_14 = ear.next.next.x;
            }
            else
            {
                    val_14 = 1.401298E-45f;
            }
            
                float val_10 = ear.next.next.y;
                float val_2 = val_13 - val_14;
                float val_3 = val_12 - val_14;
                float val_4 = 0f - val_10;
                float val_5 = ear.next.y - val_10;
                float val_6 = val_2 * val_4;
                val_6 = val_6 - (val_3 * val_5);
                if(val_6 >= 0f)
            {
                    val_10 = ear.y - val_10;
                float val_8 = ear.x - val_14;
                val_3 = val_3 * val_10;
                val_4 = val_8 * val_4;
                val_4 = val_3 - val_4;
                if(val_4 >= 0f)
            {
                    val_5 = val_8 * val_5;
                val_2 = val_2 * val_10;
                val_2 = val_5 - val_2;
                if(val_2 >= 0f)
            {
                    if((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.area(p:  ear.next.next.prev, q:  ear.next.next, r:  ear.next.next.next)) >= 0f)
            {
                goto label_14;
            }
            
            }
            
            }
            
            }
            
            }
            while(ear.next.next.next != 64);
            
            }
            
                val_15 = 1;
                return (bool)val_15;
            }
            
            label_14:
            val_15 = 0;
            return (bool)val_15;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void indexCurve(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node start, float minX, float minY, float size)
        {
            do
            {
                if(start.mZOrder == 0)
            {
                    start.mZOrder = Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.zOrder(x:  start.x, y:  start.y, minX:  minX, minY:  minY, size:  size);
            }
            
                start.prevZ = start.prev;
                start.nextZ = start.next;
            }
            while(start.next != start);
            
            start.prevZ.nextZ = 0;
            start.prevZ = 0;
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_2 = Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.sortLinked(list:  start);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node sortLinked(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node list)
        {
            var val_1;
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_2;
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_3;
            var val_4;
            var val_5;
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_6;
            var val_7;
            label_21:
            if(list == null)
            {
                goto label_20;
            }
            
            val_1 = 0;
            val_2 = 0;
            var val_1 = 0;
            label_19:
            val_1 = val_1 + 1;
            if(1 < 1)
            {
                goto label_1;
            }
            
            label_3:
            val_3 = list.nextZ;
            val_4 = 1;
            if(val_3 == null)
            {
                goto label_4;
            }
            
            if(val_4 < 1)
            {
                goto label_3;
            }
            
            goto label_4;
            label_1:
            val_4 = 0;
            val_3 = list;
            label_4:
            val_5 = 1;
            goto label_5;
            label_18:
            if(val_4 == 0)
            {
                goto label_6;
            }
            
            label_16:
            if((val_5 == 0) || (val_3 == null))
            {
                goto label_8;
            }
            
            if(list.mZOrder <= list.mZOrder)
            {
                goto label_12;
            }
            
            goto label_14;
            label_8:
            label_12:
            val_6 = list;
            val_4 = -1;
            goto label_13;
            label_6:
            label_14:
            val_6 = val_3;
            val_5 = 0;
            val_3 = list.nextZ;
            label_13:
            val_7 = val_6;
            if(val_2 != 0)
            {
                    val_7 = val_1;
                mem[56] = val_6;
            }
            
            list.prevZ = val_2;
            val_2 = val_6;
            val_1 = val_7;
            label_5:
            if(val_4 > 0)
            {
                goto label_16;
            }
            
            if(val_5 >= 1)
            {
                    if(val_3 != null)
            {
                goto label_18;
            }
            
            }
            
            if(val_3 != null)
            {
                goto label_19;
            }
            
            if(val_2 == null)
            {
                goto label_20;
            }
            
            list.nextZ = 0;
            if(val_1 > 1)
            {
                goto label_21;
            }
            
            return (Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node)val_1;
            label_20:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node EliminateHoles(System.Collections.Generic.List<float> data, System.Collections.Generic.List<int> holeIndices, Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node outerNode, int dim)
        {
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_15;
            int val_16;
            var val_17;
            var val_19;
            val_15 = outerNode;
            int val_1 = holeIndices.Count;
            System.Collections.Generic.List<Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node> val_2 = new System.Collections.Generic.List<Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node>(capacity:  val_1);
            if()
            {
                    var val_15 = 0;
                do
            {
                if(val_15 < (val_1 - 1))
            {
                    val_16 = (holeIndices.Item[val_15 + 1]) * dim;
            }
            else
            {
                    val_16 = data.Count;
            }
            
                Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_9 = Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.linkedList(data:  data, start:  holeIndices.Item[0] * dim, end:  val_16, dim:  dim, clockwise:  false);
                if(val_9 == val_9.next)
            {
                    val_9.steiner = true;
            }
            
                val_2.Add(item:  Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.getLeftmost(start:  val_9));
                val_15 = val_15 + 1;
            }
            while(val_1 != val_15);
            
            }
            
            val_17 = null;
            val_17 = null;
            if((EarcutLibrary.<>c.<>9__13_0) == null)
            {
                goto label_14;
            }
            
            label_24:
            val_2.Sort(comparison:  EarcutLibrary.<>c.<>9__13_0);
            val_19 = 0;
            goto label_16;
            label_20:
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.EliminateHole(hole:  val_2.Item[0], outerNode:  val_15);
            val_15 = Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.FilterPoints(start:  val_15, end:  outerNode.next);
            val_19 = 1;
            label_16:
            if(val_19 < val_2.Count)
            {
                goto label_20;
            }
            
            return (Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node)val_15;
            label_14:
            EarcutLibrary.<>c.<>9__13_0 = new System.Comparison<Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node>(object:  EarcutLibrary.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 EarcutLibrary.<>c::<EliminateHoles>b__13_0(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node a, Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node b));
            if(val_2 != null)
            {
                goto label_24;
            }
            
            goto label_24;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void EliminateHole(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node hole, Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node outerNode)
        {
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_1 = Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.FindHoleBridge(hole:  hole, outerNode:  outerNode);
            if(val_1 == null)
            {
                    return;
            }
            
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_3 = Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.FilterPoints(start:  Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.SplitPolygon(a:  val_1, b:  hole), end:  val_2.next);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node FilterPoints(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node start, Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node end)
        {
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_4;
            var val_5;
            val_4 = start;
            if(val_4 == null)
            {
                goto label_0;
            }
            
            do
            {
                label_8:
                if(start.steiner != true)
            {
                    if(((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.equals(p1:  val_4, p2:  start.next)) == true) || ((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.area(p:  start.prev, q:  val_4, r:  start.next)) == 0f))
            {
                goto label_4;
            }
            
            }
            
                val_4 = start.next;
            }
            while(val_4 != ((end == 0) ? (val_4) : end));
            
            return (Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node)val_5;
            label_4:
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.removeNode(p:  val_4);
            val_4 = start.prev;
            if(val_4 != start.prev.next)
            {
                goto label_8;
            }
            
            label_0:
            val_5 = 0;
            return (Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node SplitPolygon(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node a, Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node b)
        {
            int val_3;
            float val_4;
            int val_5;
            float val_6;
            var val_7;
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_8;
            if(a != null)
            {
                    val_3 = a.i;
                val_4 = a.x;
            }
            else
            {
                    val_3 = 11993091;
                val_4 = 1.401298E-45f;
            }
            
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_1 = new Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node();
            .i = 11993091;
            .x = val_4;
            .y = a.y;
            mem[1152921526244582828] = 0;
            mem[1152921526244582812] = 0;
            .mZOrder = 0;
            .prev = null;
            if(b != null)
            {
                    val_5 = b.i;
                val_6 = b.x;
            }
            else
            {
                    val_5 = 11993091;
                val_6 = 1.401298E-45f;
            }
            
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_2 = new Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node();
            .i = 11993091;
            .x = val_6;
            .y = b.y;
            mem[1152921526244586924] = 0;
            mem[1152921526244586908] = 0;
            .mZOrder = 0;
            .prev = null;
            if(b != null)
            {
                    val_7 = b;
                val_8 = b.prev;
                a.next = b;
            }
            else
            {
                    val_7 = 32;
                val_8 = 64;
                a.next = 0;
            }
            
            mem[32] = a;
            .next = a.next;
            a.next.prev = val_1;
            .next = val_1;
            .prev = val_2;
            mem[104] = val_2;
            .prev = val_8;
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node FindHoleBridge(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node hole, Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node outerNode)
        {
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_14;
            float val_15;
            float val_16;
            var val_17;
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_18;
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_19;
            float val_20;
            float val_21;
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_22;
            float val_23;
            val_14 = outerNode;
            if(hole != null)
            {
                    val_15 = hole.x;
            }
            else
            {
                    val_15 = 1.401298E-45f;
            }
            
            val_16 = -3.402823E+38f;
            val_17 = 1152921504834961408;
            val_18 = 0;
            val_19 = val_14;
            label_24:
            if(val_19 != null)
            {
                    if(outerNode.next != null)
            {
                goto label_7;
            }
            
            }
            
            UnityEngine.Debug.Log(message:  "here");
            label_7:
            if((hole.y > outerNode.y) || (hole.y < outerNode.next.y))
            {
                goto label_16;
            }
            
            val_20 = outerNode.y;
            if(outerNode.next.y == val_20)
            {
                goto label_16;
            }
            
            float val_14 = outerNode.x;
            val_21 = val_14;
            val_22 = outerNode.next;
            if(outerNode.next != null)
            {
                goto label_13;
            }
            
            val_22 = outerNode.next;
            if(val_22 == null)
            {
                goto label_14;
            }
            
            val_21 = outerNode.x;
            label_13:
            float val_15 = outerNode.next.y;
            float val_1 = hole.y - val_20;
            val_21 = outerNode.next.x - val_21;
            val_21 = val_1 * val_21;
            float val_2 = val_15 - outerNode.y;
            val_21 = val_21 / val_2;
            val_14 = val_14 + val_21;
            if((val_14 > val_15) || (val_14 <= val_16))
            {
                goto label_16;
            }
            
            if(val_14 != val_15)
            {
                goto label_17;
            }
            
            if(hole.y == outerNode.y)
            {
                    return val_19;
            }
            
            if(hole.y == outerNode.next.y)
            {
                goto label_20;
            }
            
            label_17:
            if(outerNode.x < 0)
            {
                    val_18 = val_19;
            }
            else
            {
                    val_18 = outerNode.next;
            }
            
            val_16 = val_14;
            label_16:
            if(outerNode.next != val_14)
            {
                goto label_24;
            }
            
            if(val_18 == null)
            {
                goto label_25;
            }
            
            if(val_15 != val_16)
            {
                goto label_26;
            }
            
            val_19 = outerNode.next.prev;
            return val_19;
            label_25:
            val_19 = 0;
            return val_19;
            label_26:
            val_14 = outerNode.next.next;
            if(val_14 == val_18)
            {
                goto label_29;
            }
            
            val_20 = outerNode.next.x;
            val_19 = val_18;
            val_17 = 1152921504621436928;
            label_43:
            val_23 = outerNode.next.next.x;
            if(((val_15 >= val_23) && (val_23 >= val_20)) && (val_15 != val_23))
            {
                    float val_16 = outerNode.next.next.y;
                float val_5 = ((hole.y < 0) ? (val_16) : (val_15)) - val_23;
                val_2 = ((hole.y < 0) ? (val_15) : (val_16)) - val_23;
                float val_6 = hole.y - val_16;
                val_15 = val_5 * val_6;
                val_1 = val_2 * val_6;
                val_15 = val_15 - val_1;
                if(val_15 >= 0f)
            {
                    val_16 = outerNode.next.y - val_16;
                float val_7 = val_20 - val_23;
                float val_9 = val_7 * val_6;
                val_7 = (val_2 * val_16) - val_9;
                if(val_7 >= 0f)
            {
                    val_5 = val_5 * val_16;
                val_5 = val_9 - val_5;
                if(val_5 >= 0f)
            {
                    val_23 = outerNode.next.next.x;
                val_6 = System.Math.Abs(val_6) / (val_15 - val_23);
                if(val_6 >= 0)
            {
                    if((val_6 != (3.402823E+38f)) || (val_23 <= outerNode.next.x))
            {
                goto label_42;
            }
            
            }
            
                bool val_11 = Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.locallyInside(a:  val_14, b:  hole);
                var val_12 = (val_11 != true) ? (val_14) : (val_19);
                var val_13 = (val_11 != true) ? (val_6) : 3.402823E+38f;
            }
            
            }
            
            }
            
            }
            
            label_42:
            val_14 = outerNode.next.next.next;
            if(val_14 != val_18)
            {
                goto label_43;
            }
            
            return val_19;
            label_29:
            val_19 = val_18;
            return val_19;
            label_20:
            val_19 = outerNode.next;
            return val_19;
            label_14:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool locallyInside(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node a, Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node b)
        {
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_8;
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_9;
            var val_10;
            if(a != null)
            {
                    val_8 = a;
                val_9 = a.prev;
            }
            else
            {
                    val_8 = 32;
                val_9 = 64;
            }
            
            if((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.area(p:  val_9, q:  a, r:  a.next)) < 0)
            {
                goto label_3;
            }
            
            if((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.area(p:  a, q:  b, r:  val_8)) < 0)
            {
                goto label_4;
            }
            
            var val_4 = ((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.area(p:  a, q:  a.next, r:  b)) < 0) ? 1 : 0;
            return (bool)((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.area(p:  a, q:  64, r:  b)) >= 0f) ? 1 : 0;
            label_3:
            if((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.area(p:  a, q:  b, r:  a.next)) >= 0f)
            {
                    return (bool)((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.area(p:  a, q:  64, r:  b)) >= 0f) ? 1 : 0;
            }
            
            val_10 = 0;
            return (bool)((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.area(p:  a, q:  64, r:  b)) >= 0f) ? 1 : 0;
            label_4:
            val_10 = 1;
            return (bool)((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.area(p:  a, q:  64, r:  b)) >= 0f) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static float area(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node p, Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node q, Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node r)
        {
            float val_4;
            float val_5;
            float val_6;
            if(r != null)
            {
                    val_4 = r.x;
                val_5 = q.x;
                val_6 = p.x;
            }
            else
            {
                    val_4 = r.x;
                val_5 = q.x;
                val_6 = p.x;
            }
            
            float val_4 = r.y;
            float val_1 = q.y - p.y;
            val_1 = val_1 * (val_4 - val_5);
            val_4 = val_4 - q.y;
            val_4 = (val_5 - val_6) * val_4;
            val_4 = val_1 - val_4;
            return (float)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool pointInTriangle(float ax, float ay, float bx, float by, float cx, float cy, float px, float py)
        {
            cx = cx - px;
            ay = ay - py;
            float val_1 = ax - px;
            float val_2 = cy - py;
            float val_3 = cx * ay;
            val_3 = val_3 - (val_1 * val_2);
            if(val_3 < 0f)
            {
                    return false;
            }
            
            by = by - py;
            bx = bx - px;
            ay = bx * ay;
            ay = (val_1 * by) - ay;
            if(ay < 0f)
            {
                    return false;
            }
            
            val_2 = bx * val_2;
            val_2 = val_2 - (cx * by);
            return (bool)(val_2 >= 0f) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node getLeftmost(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node start)
        {
            do
            {
            
            }
            while(start.next != start);
            
            return (Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node)(start.x < 0) ? start : start;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node linkedList(System.Collections.Generic.List<float> data, int start, int end, int dim, bool clockwise)
        {
            int val_14;
            float val_15;
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_16;
            float val_17;
            val_14 = end;
            int val_14 = start;
            var val_2 = ((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.signedArea(data:  data, start:  val_14, end:  val_14, dim:  dim)) > 0f) ? 1 : 0;
            val_2 = val_2 ^ clockwise;
            if(val_2 == false)
            {
                goto label_1;
            }
            
            val_14 = val_14 - dim;
            if(val_14 < val_14)
            {
                goto label_7;
            }
            
            do
            {
                if(data != null)
            {
                    val_15 = data.Item[val_14];
            }
            else
            {
                    val_15 = 0.Item[val_14];
            }
            
                val_14 = val_14 - dim;
                val_16 = Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.insertNode(i:  val_14, x:  val_15, y:  data.Item[val_14 + 1], last:  0);
            }
            while(val_14 >= val_14);
            
            goto label_6;
            label_1:
            if(val_14 >= val_14)
            {
                goto label_7;
            }
            
            do
            {
                if(data != null)
            {
                    val_17 = data.Item[val_14];
            }
            else
            {
                    val_17 = 0.Item[val_14];
            }
            
                val_14 = val_14 + dim;
                val_16 = Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.insertNode(i:  val_14, x:  val_17, y:  data.Item[val_14 + 1], last:  0);
            }
            while(val_14 < val_14);
            
            label_6:
            if(val_16 == null)
            {
                    return (Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node)val_16;
            }
            
            if((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.equals(p1:  val_16, p2:  val_12.next)) == false)
            {
                    return (Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node)val_16;
            }
            
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.removeNode(p:  val_16);
            val_16 = val_12.next;
            return (Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node)val_16;
            label_7:
            val_16 = 0;
            return (Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node)val_16;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void removeNode(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node p)
        {
            var val_1;
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_2;
            if(p != null)
            {
                    val_1 = p;
                val_2 = p.next;
            }
            else
            {
                    val_1 = 40;
                val_2 = 69077560;
            }
            
            p.prev.next = 69077560;
            if(p.prevZ != null)
            {
                    p.prevZ.nextZ = p.nextZ;
            }
            
            if(p.nextZ == null)
            {
                    return;
            }
            
            p.nextZ.prevZ = p.prevZ;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool equals(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node p1, Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node p2)
        {
            var val_2;
            if(p1.x == p2.x)
            {
                    var val_1 = (p1.y == p2.y) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static float signedArea(System.Collections.Generic.List<float> data, int start, int end, int dim)
        {
            var val_13;
            int val_14;
            var val_15;
            float val_16;
            float val_17;
            float val_18;
            val_14 = start;
            val_15 = 0f;
            if(val_14 >= end)
            {
                    return (float)val_15;
            }
            
            int val_1 = end - dim;
            do
            {
                if(data != null)
            {
                    val_16 = data.Item[val_1];
                val_17 = data.Item[val_14];
                val_18 = data.Item[val_14 + 1];
            }
            else
            {
                    val_16 = 0.Item[val_1];
                val_17 = 0.Item[val_14];
                val_18 = 0.Item[val_14 + 1];
            }
            
                float val_11 = data.Item[val_1 + 1];
                val_11 = val_18 + val_11;
                val_13 = val_14;
                val_14 = val_14 + dim;
                val_11 = (val_16 - val_17) * val_11;
                val_15 = 0f + val_11;
            }
            while(val_14 < end);
            
            return (float)val_15;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node insertNode(int i, float x, float y, Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node last)
        {
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_2;
            Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node val_1 = new Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node();
            .i = i;
            .x = x;
            .y = y;
            mem[1152921526246083836] = 0;
            mem[1152921526246083820] = 0;
            .mZOrder = 0;
            .prev = null;
            if(last == null)
            {
                goto label_1;
            }
            
            val_2 = last;
            if(val_1 == null)
            {
                goto label_2;
            }
            
            .next = last.next;
            goto label_3;
            label_1:
            if(val_1 == null)
            {
                goto label_4;
            }
            
            .prev = val_1;
            goto label_5;
            label_2:
            mem[40] = last.next;
            label_3:
            .prev = last;
            last.next.prev = val_1;
            goto label_7;
            label_4:
            mem[32] = 0;
            label_5:
            val_2 = (Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node)[1152921526246083776].next;
            label_7:
            mem2[0] = val_1;
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Data Flatten(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>> data)
        {
            int val_14;
            var val_15;
            System.Collections.Generic.List<System.Single> val_16;
            val_14 = data.Count;
            if(val_14 >= 1)
            {
                    var val_16 = 0;
                var val_15 = 0;
                do
            {
                val_15 = val_15 + 1;
                val_16 = data.Item[0].Count + val_16;
            }
            while(val_14 != val_15);
            
                val_15 = val_16 << 1;
            }
            else
            {
                    val_15 = 0;
            }
            
            .Dim = 2;
            System.Collections.Generic.List<System.Single> val_5 = null;
            val_16 = val_5;
            val_5 = new System.Collections.Generic.List<System.Single>(capacity:  0);
            .Vertices = val_16;
            if(val_14 < 1)
            {
                    return (Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Data)new Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Data();
            }
            
            do
            {
                int val_7 = data.Item[0].Count;
                if(val_7 >= 1)
            {
                    var val_17 = 0;
                do
            {
                UnityEngine.Vector3 val_9 = data.Item[0].Item[0];
                (Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Data)[1152921526246262336].Vertices.Add(item:  val_9.x);
                UnityEngine.Vector3 val_11 = data.Item[0].Item[0];
                (Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Data)[1152921526246262336].Vertices.Add(item:  val_11.x);
                val_17 = val_17 + 1;
            }
            while(val_7 != val_17);
            
            }
            
                if(val_7 >= val_17)
            {
                    val_14 = val_14;
                int val_18 = 0;
                val_18 = (data.Item[0 - 1].Count) + val_18;
                (Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Data)[1152921526246262336].Holes.Add(item:  val_18);
            }
            else
            {
                    val_14 = val_14;
            }
            
                val_16 = 0 + 1;
            }
            while(val_16 != val_14);
            
            return (Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Data)new Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Data();
        }
    
    }

}
