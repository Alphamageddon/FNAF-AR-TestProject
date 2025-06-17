using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_Base : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float _pointRadius = 0.11;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float _lineLength = 100;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void LogInfo(object value)
        {
            Dest.Math.Logger.LogInfo(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void LogWarning(object value)
        {
            Dest.Math.Logger.LogWarning(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void LogError(object value)
        {
            Dest.Math.Logger.LogError(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void SetColor(UnityEngine.Color color)
        {
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void FiguresColor()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.gray;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void ResultsColor()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.blue;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Dest.Math.AAB2 CreateAAB2(UnityEngine.Transform point0, UnityEngine.Transform point1)
        {
            UnityEngine.Vector3 val_1 = point0.position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = point1.position;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            return Dest.Math.AAB2.CreateFromTwoPoints(point0:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, point1:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Dest.Math.AAB3 CreateAAB3(UnityEngine.Transform point0, UnityEngine.Transform point1)
        {
            UnityEngine.Vector3 val_1 = point0.position;
            UnityEngine.Vector3 val_2 = point1.position;
            return Dest.Math.AAB3.CreateFromTwoPoints(point0:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, point1:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Dest.Math.Box2 CreateBox2(UnityEngine.Transform box)
        {
            UnityEngine.Vector3 val_1 = box.position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = box.right;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector3 val_5 = box.up;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_7 = box.localScale;
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            val_0.Axis1.x = 0f;
            val_0.Axis1.y = 0f;
            val_0.Extents.x = 0f;
            val_0.Extents.y = 0f;
            val_0.Center.x = 0f;
            val_0.Center.y = 0f;
            val_0.Axis0.x = 0f;
            val_0.Axis0.y = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Dest.Math.Box3 CreateBox3(UnityEngine.Transform box)
        {
            Dest.Math.Box3 val_0;
            UnityEngine.Vector3 val_1 = box.position;
            UnityEngine.Vector3 val_2 = box.right;
            UnityEngine.Vector3 val_3 = box.up;
            UnityEngine.Vector3 val_4 = box.forward;
            UnityEngine.Vector3 val_5 = box.localScale;
            val_0.Extents.z = 0f;
            val_0.Axis2.y = 0f;
            val_0.Axis2.z = 0f;
            val_0.Extents.x = 0f;
            val_0.Extents.y = 0f;
            val_0.Axis1.x = 0f;
            val_0.Axis1.y = 0f;
            val_0.Axis1.z = 0f;
            val_0.Axis2.x = 0f;
            val_0.Center.z = 0f;
            val_0.Axis0.x = 0f;
            val_0.Axis0.y = 0f;
            val_0.Axis0.z = 0f;
            val_0.Center.x = 0f;
            val_0.Center.y = 0f;
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Dest.Math.Rectangle3 CreateRectangle3(UnityEngine.Transform rectangle)
        {
            Dest.Math.Rectangle3 val_0;
            UnityEngine.Vector3 val_1 = rectangle.position;
            UnityEngine.Vector3 val_2 = rectangle.right;
            UnityEngine.Vector3 val_3 = rectangle.forward;
            UnityEngine.Vector3 val_4 = rectangle.localScale;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_0.Normal.y = 0f;
            val_0.Normal.z = 0f;
            val_0.Extents.x = 0f;
            val_0.Extents.y = 0f;
            val_0.Axis1.x = 0f;
            val_0.Axis1.y = 0f;
            val_0.Axis1.z = 0f;
            val_0.Normal.x = 0f;
            val_0.Center.z = 0f;
            val_0.Axis0.x = 0f;
            val_0.Axis0.y = 0f;
            val_0.Axis0.z = 0f;
            val_0.Center.x = 0f;
            val_0.Center.y = 0f;
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Dest.Math.Circle2 CreateCircle2(UnityEngine.Transform circle)
        {
            UnityEngine.Vector3 val_1 = circle.position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = circle.localScale;
            return new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = 2.969109E+37f, y = 2.524356E-29f}, Radius = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Dest.Math.Circle3 CreateCircle3(UnityEngine.Transform circle)
        {
            Dest.Math.Circle3 val_0;
            UnityEngine.Vector3 val_1 = circle.position;
            UnityEngine.Vector3 val_2 = circle.right;
            UnityEngine.Vector3 val_3 = circle.forward;
            UnityEngine.Vector3 val_4 = circle.localScale;
            val_0.Radius = 0f;
            val_0.Axis1.z = 0f;
            val_0.Normal.x = 0f;
            val_0.Normal.y = 0f;
            val_0.Normal.z = 0f;
            val_0.Axis0.y = 0f;
            val_0.Axis0.z = 0f;
            val_0.Axis1.x = 0f;
            val_0.Axis1.y = 0f;
            val_0.Center.x = 0f;
            val_0.Center.y = 0f;
            val_0.Center.z = 0f;
            val_0.Axis0.x = 0f;
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Dest.Math.Sphere3 CreateSphere3(UnityEngine.Transform sphere)
        {
            UnityEngine.Vector3 val_1 = sphere.position;
            UnityEngine.Vector3 val_2 = sphere.localScale;
            return new Dest.Math.Sphere3() {Center = new UnityEngine.Vector3() {x = 3.032086E+37f, y = 2.524356E-29f, z = 0f}, Radius = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Dest.Math.Line2 CreateLine2(UnityEngine.Transform line)
        {
            UnityEngine.Vector3 val_1 = line.position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = line.right;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            return new Dest.Math.Line2() {Center = new UnityEngine.Vector2() {x = 3.062555E+37f, y = 2.524356E-29f}, Direction = new UnityEngine.Vector2() {x = 0f, y = 0f}};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Dest.Math.Line3 CreateLine3(UnityEngine.Transform line)
        {
            UnityEngine.Vector3 val_1 = line.position;
            UnityEngine.Vector3 val_2 = line.right;
            val_0.Center.z = 0f;
            val_0.Direction.x = 0f;
            val_0.Direction.y = 0f;
            val_0.Direction.z = 0f;
            val_0.Center.x = 0f;
            val_0.Center.y = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Dest.Math.Ray2 CreateRay2(UnityEngine.Transform ray)
        {
            UnityEngine.Vector3 val_1 = ray.position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = ray.right;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            return new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = 3.125527E+37f, y = 2.524356E-29f}, Direction = new UnityEngine.Vector2() {x = 0f, y = 0f}};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Dest.Math.Ray3 CreateRay3(UnityEngine.Transform ray)
        {
            UnityEngine.Vector3 val_1 = ray.position;
            UnityEngine.Vector3 val_2 = ray.right;
            val_0.Center.z = 0f;
            val_0.Direction.x = 0f;
            val_0.Direction.y = 0f;
            val_0.Direction.z = 0f;
            val_0.Center.x = 0f;
            val_0.Center.y = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Dest.Math.Segment2 CreateSegment2(UnityEngine.Transform p0, UnityEngine.Transform p1)
        {
            UnityEngine.Vector3 val_1 = p0.position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = p1.position;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            val_0.Extent = 0f;
            val_0.Center.x = 0f;
            val_0.Center.y = 0f;
            val_0.Direction.x = 0f;
            val_0.Direction.y = 0f;
            val_0.P0.x = 0f;
            val_0.P0.y = 0f;
            val_0.P1.x = 0f;
            val_0.P1.y = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Dest.Math.Segment3 CreateSegment3(UnityEngine.Transform p0, UnityEngine.Transform p1)
        {
            UnityEngine.Vector3 val_1 = p0.position;
            UnityEngine.Vector3 val_2 = p1.position;
            val_0.Extent = 0f;
            val_0.Center.z = 0f;
            val_0.Direction.x = 0f;
            val_0.Direction.y = 0f;
            val_0.Direction.z = 0f;
            val_0.P1.y = 0f;
            val_0.P1.z = 0f;
            val_0.Center.x = 0f;
            val_0.Center.y = 0f;
            val_0.P0.x = 0f;
            val_0.P0.y = 0f;
            val_0.P0.z = 0f;
            val_0.P1.x = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Dest.Math.Triangle2 CreateTriangle2(UnityEngine.Transform v0, UnityEngine.Transform v1, UnityEngine.Transform v2)
        {
            UnityEngine.Vector3 val_1 = v0.position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = v1.position;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector3 val_5 = v2.position;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            val_0.V1.x = 0f;
            val_0.V1.y = 0f;
            val_0.V2.x = 0f;
            val_0.V2.y = 0f;
            val_0.V0.x = 0f;
            val_0.V0.y = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Dest.Math.Triangle3 CreateTriangle3(UnityEngine.Transform v0, UnityEngine.Transform v1, UnityEngine.Transform v2)
        {
            Dest.Math.Triangle3 val_0;
            UnityEngine.Vector3 val_1 = v0.position;
            UnityEngine.Vector3 val_2 = v1.position;
            UnityEngine.Vector3 val_3 = v2.position;
            val_0.V2.z = 0f;
            val_0.V1.y = 0f;
            val_0.V1.z = 0f;
            val_0.V2.x = 0f;
            val_0.V2.y = 0f;
            val_0.V0.x = 0f;
            val_0.V0.y = 0f;
            val_0.V0.z = 0f;
            val_0.V1.x = 0f;
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Dest.Math.Plane3 CreatePlane3(UnityEngine.Transform plane)
        {
            UnityEngine.Vector3 val_1 = plane.up;
            UnityEngine.Vector3 val_2 = plane.position;
            return new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = 3.330968E+37f, y = 2.524356E-29f, z = 0f}, Constant = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Dest.Math.Polygon2 CreatePolygon2(UnityEngine.Transform[] polygon)
        {
            Dest.Math.Polygon2 val_1 = new Dest.Math.Polygon2(vertexCount:  polygon.Length);
            if(polygon.Length >= 1)
            {
                    do
            {
                UnityEngine.Vector3 val_2 = polygon[0].position;
                UnityEngine.Vector2 val_3 = Dest.Math.Vector3ex.ToVector2XY(vector:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
                val_1.set_Item(vertexIndex:  0, value:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            }
            while((0 + 1) < polygon.Length);
            
            }
            
            val_1.UpdateEdges();
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Dest.Math.Capsule3 CreateCapsule3(UnityEngine.Transform p0, UnityEngine.Transform p1, float radius)
        {
            Dest.Math.Capsule3 val_0;
            UnityEngine.Vector3 val_1 = p0.position;
            UnityEngine.Vector3 val_2 = p1.position;
            val_0.Segment.P1.y = 0f;
            val_0.Segment.P1.z = 0f;
            val_0.Segment.Center.x = 0f;
            val_0.Segment.Center.y = 0f;
            val_0.Segment.Center.z = 0f;
            val_0.Segment.Direction.x = 0f;
            val_0.Segment.Direction.y = 0f;
            val_0.Segment.Direction.z = 0f;
            val_0.Segment.P0.x = 0f;
            val_0.Segment.P0.y = 0f;
            val_0.Segment.P0.z = 0f;
            val_0.Segment.P1.x = 0f;
            val_0.Segment.Extent = 0f;
            val_0.Radius = 0f;
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.Vector2[] GenerateRandomSet2D(float setRadius, int countMin, int countMax, float coeffX = 1, float coeffY = 1)
        {
            string val_16;
            UnityEngine.Transform val_1 = this.transform;
            val_16 = 1152921504851574784;
            goto label_1;
            label_7:
            UnityEngine.Object.DestroyImmediate(obj:  val_1.GetChild(index:  0).gameObject);
            label_1:
            if(val_1.childCount != 0)
            {
                goto label_7;
            }
            
            int val_5 = UnityEngine.Random.Range(min:  countMin, max:  countMax);
            UnityEngine.Vector2[] val_6 = new UnityEngine.Vector2[0];
            if(val_5 < 1)
            {
                    return val_6;
            }
            
            do
            {
                val_16 = "Point" + 0.ToString();
                UnityEngine.Transform val_10 = new UnityEngine.GameObject(name:  val_16).transform;
                val_10.parent = val_1;
                UnityEngine.Vector2 val_11 = UnityEngine.Random.insideUnitCircle;
                UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, d:  setRadius);
                float val_13 = val_12.x * coeffX;
                float val_14 = val_12.y * coeffY;
                UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_13, y = val_14});
                val_10.position = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
                val_6[0] = val_13;
                val_6[0] = val_14;
            }
            while(1 < val_5);
            
            return val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.Vector3[] GenerateRandomSet3D(float setRadius, int countMin, int countMax, float coeffX = 1, float coeffY = 1, float coeffZ = 1)
        {
            string val_16;
            UnityEngine.Transform val_1 = this.transform;
            val_16 = 1152921504851574784;
            goto label_1;
            label_7:
            UnityEngine.Object.DestroyImmediate(obj:  val_1.GetChild(index:  0).gameObject);
            label_1:
            if(val_1.childCount != 0)
            {
                goto label_7;
            }
            
            int val_5 = UnityEngine.Random.Range(min:  countMin, max:  countMax);
            UnityEngine.Vector3[] val_6 = new UnityEngine.Vector3[0];
            if(val_5 < 1)
            {
                    return val_6;
            }
            
            do
            {
                val_16 = "Point" + 0.ToString();
                UnityEngine.Transform val_10 = new UnityEngine.GameObject(name:  val_16).transform;
                val_10.parent = val_1;
                UnityEngine.Vector3 val_11 = UnityEngine.Random.insideUnitSphere;
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  setRadius);
                val_10.position = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
                var val_16 = val_6 + (0 * 12);
                mem2[0] = val_12.x * coeffX;
                mem2[0] = val_12.y * coeffY;
                mem2[0] = val_12.z * coeffZ;
            }
            while(1 < val_5);
            
            return val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.Vector2[] GenerateMemoryRandomSet2D(float setRadius, int countMin, int countMax, float coeffX = 1, float coeffY = 1)
        {
            var val_6;
            int val_1 = UnityEngine.Random.Range(min:  countMin, max:  countMax);
            UnityEngine.Vector2[] val_2 = new UnityEngine.Vector2[0];
            if(val_1 < 1)
            {
                    return val_2;
            }
            
            do
            {
                UnityEngine.Vector3 val_3 = UnityEngine.Random.insideUnitSphere;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  setRadius);
                UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
                float val_6 = val_5.x;
                float val_7 = val_5.y;
                val_6 = val_6 * coeffX;
                val_7 = val_7 * coeffY;
                val_6 = 0 + 1;
                mem2[0] = val_6;
                mem2[0] = val_7;
            }
            while(val_1 != val_6);
            
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.Vector3[] GenerateMemoryRandomSet3D(float setRadius, int countMin, int countMax, float coeffX = 1, float coeffY = 1, float coeffZ = 1)
        {
            var val_7;
            int val_1 = UnityEngine.Random.Range(min:  countMin, max:  countMax);
            UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[0];
            if(val_1 < 1)
            {
                    return val_2;
            }
            
            do
            {
                UnityEngine.Vector3 val_3 = UnityEngine.Random.insideUnitSphere;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  setRadius);
                float val_7 = val_4.z;
                val_7 = val_7 * coeffZ;
                val_7 = 0 + 1;
                mem2[0] = val_4.x * coeffX;
                mem2[0] = val_4.y * coeffY;
                mem2[0] = val_7;
            }
            while(val_1 != val_7);
            
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.Vector2[] CreatePoints2(UnityEngine.Transform[] points)
        {
            UnityEngine.Vector2[] val_1 = new UnityEngine.Vector2[0];
            if(points.Length < 1)
            {
                    return val_1;
            }
            
            do
            {
                UnityEngine.Vector3 val_3 = points[0].transform.position;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
                val_1[0] = val_4;
                val_1[0] = val_4.y;
            }
            while((0 + 1) < points.Length);
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.Vector3[] CreatePoints3(UnityEngine.Transform[] points)
        {
            UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[0];
            if(points.Length < 1)
            {
                    return val_1;
            }
            
            do
            {
                UnityEngine.Vector3 val_3 = points[0].transform.position;
                var val_4 = val_1 + (0 * 12);
                mem2[0] = val_3.x;
                mem2[0] = val_3.y;
                mem2[0] = val_3.z;
            }
            while((0 + 1) < points.Length);
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.Vector3[] CreateFromChildren3(UnityEngine.Transform parent)
        {
            var val_5;
            int val_1 = parent.childCount;
            val_5 = 0;
            goto label_2;
            label_7:
            UnityEngine.Vector3 val_4 = parent.GetChild(index:  0).position;
            val_5 = 1;
            mem[1152921519603570352] = val_4.x;
            mem[1152921519603570356] = val_4.y;
            mem[1152921519603570360] = val_4.z;
            label_2:
            if(val_5 < val_2.Length)
            {
                goto label_7;
            }
            
            return (UnityEngine.Vector3[])new UnityEngine.Vector3[0];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawPoint(UnityEngine.Vector2 position)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = position.x, y = position.y});
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, radius:  0.11f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawPoint(UnityEngine.Vector3 position)
        {
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, radius:  0.11f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawPoints(System.Collections.Generic.IEnumerable<UnityEngine.Vector2> points, float size = 0.11)
        {
            float val_15;
            var val_17;
            var val_20;
            var val_21;
            val_15 = size;
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_17 = points.GetEnumerator();
            label_19:
            var val_19 = 0;
            val_19 = val_19 + 1;
            if(val_17.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            T val_6 = val_17.Current;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = size, y = V1.16B});
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, radius:  val_15);
            goto label_19;
            label_11:
            val_20 = 0;
            val_21 = 46;
            if(val_17 == null)
            {
                
            }
            else
            {
                    var val_21 = 0;
                val_21 = val_21 + 1;
                val_17.Dispose();
            }
            
            if( == 46)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_17 = ???;
            val_21 = ???;
            val_15 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawPoints(System.Collections.Generic.IEnumerable<UnityEngine.Vector3> points, float size = 0.11)
        {
            var val_12;
            var val_15;
            var val_16;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_12 = points.GetEnumerator();
            label_17:
            var val_15 = 0;
            val_15 = val_15 + 1;
            if(val_12.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            T val_6 = val_12.Current;
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = size}, radius:  size);
            goto label_17;
            label_11:
            val_15 = 0;
            val_16 = 41;
            if(val_12 == null)
            {
                
            }
            else
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_12.Dispose();
            }
            
            if( == 41)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_12 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawWirePoints(System.Collections.Generic.IList<UnityEngine.Vector3> points, float size = 0.05)
        {
            var val_3;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_3 = 0;
            int val_2 = points.Count;
            if(val_2 < 1)
            {
                    return;
            }
            
            var val_7 = 0;
            do
            {
                var val_6 = 0;
                val_6 = val_6 + 1;
                val_3 = 0;
                T val_4 = points.Item[0];
                UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = size}, radius:  size);
                val_7 = val_7 + 1;
            }
            while(val_7 != val_2);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawSegments(UnityEngine.Vector2[] points)
        {
            goto label_0;
            label_4:
            this.DrawSegment(p0:  new UnityEngine.Vector2() {x = points[(long)(long)(int)(W21)], y = points[(long)(long)(int)(W21)]}, p1:  new UnityEngine.Vector2() {x = points[1], y = points[1]});
            1 = 2;
            label_0:
            if(1 < (points.Length - 1))
            {
                goto label_4;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawPointsWithSegments(UnityEngine.Vector2[] points)
        {
            var val_4;
            int val_5;
            int val_6;
            val_4 = 1;
            goto label_0;
            label_5:
            if(W21 >= (points.Length - 1))
            {
                goto label_1;
            }
            
            label_6:
            this.DrawPoint(position:  new UnityEngine.Vector2() {x = points[(long)(long)(int)(W21)], y = points[(long)(int)(W21)] + 32 + 4});
            val_5 = points.Length;
            if(W21 >= val_5)
            {
                    val_5 = points.Length;
            }
            
            this.DrawSegment(p0:  new UnityEngine.Vector2() {x = points[(long)(int)(W21)] + 32, y = points[(long)(int)(W21)] + 32 + 4}, p1:  new UnityEngine.Vector2() {x = points[1], y = points[1]});
            val_4 = 2;
            label_0:
            if(points == null)
            {
                goto label_5;
            }
            
            val_6 = points.Length;
            if(1 < (val_6 - 1))
            {
                goto label_6;
            }
            
            goto label_7;
            label_1:
            val_6 = points.Length;
            label_7:
            var val_7 = -4294967296;
            val_7 = val_7 + ((points.Length) << 32);
            this.DrawPoint(position:  new UnityEngine.Vector2() {x = points[val_7 >> 32], y = points[val_7 >> 32]});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawSegment(UnityEngine.Vector2 p0, UnityEngine.Vector2 p1)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = p0.x, y = p0.y});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = p1.x, y = p1.y});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, to:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawSegment(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1)
        {
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = p0.x, y = p0.y, z = p0.z}, to:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawAAB(ref Dest.Math.AAB2 box)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, to:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, to:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, to:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, to:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawAAB(ref Dest.Math.AAB3 box)
        {
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawBox(ref Dest.Math.Box2 box)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, to:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, to:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, to:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, to:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawBox(ref Dest.Math.Box3 box)
        {
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawRectangle(ref Dest.Math.Rectangle3 rectangle)
        {
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawCircle(ref Dest.Math.Circle2 circle)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = V1.16B});
            var val_4 = 1;
            do
            {
                float val_3 = 1f;
                val_3 = val_3 * 0.1570796f;
                UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3, y = val_1.y});
                UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, to:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
                val_4 = val_4 + 1;
            }
            while(val_4 != 41);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawCircle(UnityEngine.Vector2 center, float radius)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = center.y});
            var val_4 = 1;
            do
            {
                float val_3 = 1f;
                val_3 = val_3 * 0.1570796f;
                UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3, y = val_1.y});
                UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, to:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
                val_4 = val_4 + 1;
            }
            while(val_4 != 41);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawCircle(ref Dest.Math.Circle3 circle, int count = 20)
        {
            float val_2;
            float val_3;
            val_2 = 0f;
            val_3 = V1.16B;
            if(count < 1)
            {
                    return;
            }
            
            var val_3 = 1;
            do
            {
                float val_2 = 1f;
                val_2 = (6.283185f / (float)count) * val_2;
                UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = V2.16B}, to:  new UnityEngine.Vector3() {x = val_2, y = (float)count, z = V2.16B});
                val_3 = val_3 + 1;
                val_3 = (float)count;
                val_2 = val_2;
            }
            while(val_3 <= count);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawSphere(ref Dest.Math.Sphere3 sphere)
        {
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = sphere.Center.x, y = sphere.Center.y, z = sphere.Center.z}, radius:  sphere.Radius);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawLine(ref Dest.Math.Line2 line)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = line.Direction.x, y = line.Direction.y}, d:  100f);
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = line.Center.x, y = line.Center.y}, b:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = line.Direction.x, y = line.Direction.y}, d:  100f);
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = line.Center.x, y = line.Center.y}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, to:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawLine(ref Dest.Math.Line3 line)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = line.Direction.x, y = line.Direction.y, z = line.Direction.z}, d:  100f);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = line.Center.x, y = line.Center.y, z = line.Center.z}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = line.Direction.x, y = line.Direction.y, z = line.Direction.z}, d:  100f);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = line.Center.x, y = line.Center.y, z = line.Center.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, to:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawRay(ref Dest.Math.Ray2 ray)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = ray.Center.x, y = ray.Center.y});
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = ray.Direction.x, y = ray.Direction.y}, d:  100f);
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = ray.Center.x, y = ray.Center.y}, b:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, to:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawRay(ref Dest.Math.Ray3 ray)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = ray.Direction.x, y = ray.Direction.y, z = ray.Direction.z}, d:  100f);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ray.Center.x, y = ray.Center.y, z = ray.Center.z}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = ray.Center.x, y = ray.Center.y, z = ray.Center.z}, to:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawSegment(ref Dest.Math.Segment2 segment)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = segment.P0.x, y = segment.P0.y});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = segment.P1.x, y = segment.P1.y});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, to:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawSegment(ref Dest.Math.Segment3 segment)
        {
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = segment.P0.x, y = segment.P0.y, z = segment.P0.z}, to:  new UnityEngine.Vector3() {x = segment.P1.x, y = segment.P1.y, z = segment.P1.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawTriangle(ref Dest.Math.Triangle2 triangle)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = triangle.V0.x, y = triangle.V0.y});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = triangle.V1.x, y = triangle.V1.y});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, to:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = triangle.V1.x, y = triangle.V1.y});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = triangle.V2.x, y = triangle.V2.y});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, to:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = triangle.V2.x, y = triangle.V2.y});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = triangle.V0.x, y = triangle.V0.y});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, to:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawTriangle(ref Dest.Math.Triangle3 triangle)
        {
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = triangle.V0.x, y = triangle.V0.y, z = triangle.V0.z}, to:  new UnityEngine.Vector3() {x = triangle.V1.x, y = triangle.V1.y, z = triangle.V1.z});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = triangle.V1.x, y = triangle.V1.y, z = triangle.V1.z}, to:  new UnityEngine.Vector3() {x = triangle.V2.x, y = triangle.V2.y, z = triangle.V2.z});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = triangle.V2.x, y = triangle.V2.y, z = triangle.V2.z}, to:  new UnityEngine.Vector3() {x = triangle.V0.x, y = triangle.V0.y, z = triangle.V0.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawPlane(ref Dest.Math.Plane3 plane, UnityEngine.Transform Plane)
        {
            float val_8;
            float val_9;
            float val_10;
            float val_11;
            UnityEngine.Vector4 val_1 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector4 val_2 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector4 val_3 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_4 = Plane.position;
            UnityEngine.Vector4 val_5 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Gizmos.matrix = new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f};
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            UnityEngine.Gizmos.DrawCube(center:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, size:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Matrix4x4 val_7 = UnityEngine.Matrix4x4.identity;
            UnityEngine.Gizmos.matrix = new UnityEngine.Matrix4x4() {m00 = val_10, m10 = val_10, m20 = val_10, m30 = val_10, m01 = val_11, m11 = val_11, m21 = val_11, m31 = val_11, m02 = val_8, m12 = val_8, m22 = val_8, m32 = val_8, m03 = val_9, m13 = val_9, m23 = val_9, m33 = val_9};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawPolygon(Dest.Math.Polygon2 polygon)
        {
            var val_8;
            int val_9;
            val_8 = 0;
            val_9 = polygon.VertexCount - 1;
            goto label_2;
            label_8:
            UnityEngine.Vector2 val_2 = polygon.Item[0];
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            UnityEngine.Vector2 val_4 = polygon.Item[val_9];
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, to:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            val_9 = val_8;
            val_8 = 1;
            label_2:
            if(val_8 < polygon.VertexCount)
            {
                goto label_8;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawPolygon(Dest.Math.Polygon3 polygon)
        {
            goto label_1;
            label_5:
            UnityEngine.Vector3 val_3 = polygon.Item[0];
            UnityEngine.Vector3 val_4 = polygon.Item[polygon.VertexCount - 1];
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, to:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            0 = 1;
            label_1:
            if(0 < polygon.VertexCount)
            {
                goto label_5;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawFunc(System.Func<float, float> func, float from, float to, int count = 100)
        {
            float val_10 = to;
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  from, y:  func.Invoke(arg:  from));
            if(count < 1)
            {
                    return;
            }
            
            var val_11 = 1;
            do
            {
                float val_9 = 1f;
                val_9 = ((val_10 - from) / (float)count) * val_9;
                val_10 = val_9 + from;
                UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_10, y:  func.Invoke(arg:  val_10));
                UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
                UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
                UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, to:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
                val_11 = val_11 + 1;
            }
            while(val_11 <= count);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawTetrahedron(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, UnityEngine.Vector3 v3)
        {
            var val_1;
            float val_2;
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = v0.x, y = v0.y, z = v0.z}, to:  new UnityEngine.Vector3() {x = v1.x, y = v1.y, z = v1.z});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = v0.x, y = v0.y, z = v0.z}, to:  new UnityEngine.Vector3() {x = v2.x, y = val_2, z = v2.y});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = v0.x, y = v0.y, z = v0.z}, to:  new UnityEngine.Vector3() {x = v2.z, y = val_1, z = v3.x});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = v1.x, y = v1.y, z = v1.z}, to:  new UnityEngine.Vector3() {x = v2.x, y = val_2, z = v2.y});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = v1.x, y = v1.y, z = v1.z}, to:  new UnityEngine.Vector3() {x = v2.z, y = val_1, z = v3.x});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = v2.x, y = val_2, z = v2.y}, to:  new UnityEngine.Vector3() {x = v2.z, y = val_1, z = v3.x});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawCapsule(ref Dest.Math.Capsule3 capsule)
        {
            var val_14;
            UnityEngine.Vector3 val_15;
            var val_16;
            var val_17;
            val_14 = null;
            if((Dest.Math.Vector3ex.GetProjectionPlane(vector:  new UnityEngine.Vector3() {x = capsule.Segment.Direction.x, y = capsule.Segment.Direction.y, z = capsule.Segment.Direction.z})) == 2)
            {
                    val_14 = null;
                val_15 = 1152921504977616944;
                val_16 = 1152921504977616948;
                val_17 = 1152921504977616952;
            }
            else
            {
                    val_14 = null;
                val_15 = 1152921504977616920;
                val_16 = 1152921504977616924;
                val_17 = 1152921504977616928;
            }
            
            UnityEngine.Vector3 val_2 = Dest.Math.Vector3ex.Cross(vector:  new UnityEngine.Vector3() {x = capsule.Segment.Direction.x, y = capsule.Segment.Direction.y, z = capsule.Segment.Direction.z}, value: ref  new UnityEngine.Vector3() {x = val_15, y = mem[1152921504977616924], z = mem[1152921504977616928]});
            UnityEngine.Vector3 val_3 = Dest.Math.Vector3ex.Cross(vector:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, value: ref  new UnityEngine.Vector3() {x = capsule.Segment.Direction.x, y = capsule.Segment.Direction.y, z = capsule.Segment.Direction.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  capsule.Radius);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = capsule.Segment.P0.x, y = capsule.Segment.P0.y, z = capsule.Segment.P0.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = capsule.Segment.P1.x, y = capsule.Segment.P1.y, z = capsule.Segment.P1.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, to:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = capsule.Segment.P0.x, y = capsule.Segment.P0.y, z = capsule.Segment.P0.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = capsule.Segment.P1.x, y = capsule.Segment.P1.y, z = capsule.Segment.P1.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, to:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  capsule.Radius);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = capsule.Segment.P0.x, y = capsule.Segment.P0.y, z = capsule.Segment.P0.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = capsule.Segment.P1.x, y = capsule.Segment.P1.y, z = capsule.Segment.P1.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, to:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = capsule.Segment.P0.x, y = capsule.Segment.P0.y, z = capsule.Segment.P0.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = capsule.Segment.P1.x, y = capsule.Segment.P1.y, z = capsule.Segment.P1.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, to:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = capsule.Segment.P0.x, y = capsule.Segment.P0.y, z = capsule.Segment.P0.z}, radius:  capsule.Radius);
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = capsule.Segment.P1.x, y = capsule.Segment.P1.y, z = capsule.Segment.P1.z}, radius:  capsule.Radius);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_Base()
        {
        
        }
    
    }

}
