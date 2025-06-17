using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrSegment3Polygon3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform PolygonPlane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform[] PolygonPoints;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            float val_4;
            float val_5;
            float val_10;
            float val_11;
            float val_12;
            var val_13;
            Dest.Math.Segment3 val_1 = 48367.CreateSegment3(p0:  this.P0, p1:  this.P1);
            Dest.Math.Plane3 val_6 = 48367.CreatePlane3(plane:  this.PolygonPlane);
            val_10 = val_3;
            val_11 = val_5;
            Dest.Math.Polygon3 val_7 = null;
            val_12 = val_4;
            val_7 = new Dest.Math.Polygon3(vertexCount:  this.PolygonPoints.Length, plane:  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = 0f, y = 0f}});
            val_13 = 0;
            goto label_2;
            label_8:
            UnityEngine.Vector3 val_8 = this.PolygonPoints[0].position;
            val_10 = val_8.x;
            val_11 = val_8.z;
            val_12 = val_8.y;
            val_7.SetVertexProjected(vertexIndex:  0, vertex:  new UnityEngine.Vector3() {x = val_10, y = val_12, z = val_11});
            val_13 = 1;
            label_2:
            if(val_13 < this.PolygonPoints.Length)
            {
                goto label_8;
            }
            
            val_7.UpdateEdges();
            bool val_9 = Dest.Math.Intersection.FindSegment3Polygon3(segment: ref  new Dest.Math.Segment3() {P0 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, P1 = new UnityEngine.Vector3() {x = val_5, y = val_4, z = val_4}, Center = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Extent = val_2}, polygon:  val_7, info: out  new Dest.Math.Segment3Polygon3Intr() {Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_5}});
            val_9.FiguresColor();
            val_9.DrawPolygon(polygon:  val_7);
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, to:  new UnityEngine.Vector3() {x = val_5, y = val_4, z = val_4});
            if(val_9 != false)
            {
                    0.ResultsColor();
                UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            }
            
            val_5 = 0;
            val_5.LogInfo(value:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrSegment3Polygon3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
