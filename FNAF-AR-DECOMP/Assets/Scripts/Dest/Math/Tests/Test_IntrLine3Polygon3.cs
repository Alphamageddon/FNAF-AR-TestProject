using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrLine3Polygon3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Line;
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
            float val_8;
            float val_9;
            float val_10;
            var val_11;
            Dest.Math.Line3 val_1 = 48332.CreateLine3(line:  this.Line);
            Dest.Math.Plane3 val_4 = 48332.CreatePlane3(plane:  this.PolygonPlane);
            val_8 = val_3;
            val_9 = V2.16B;
            Dest.Math.Polygon3 val_5 = null;
            val_10 = V1.16B;
            val_5 = new Dest.Math.Polygon3(vertexCount:  this.PolygonPoints.Length, plane:  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = 0f, y = 0f}});
            val_11 = 0;
            goto label_2;
            label_8:
            UnityEngine.Vector3 val_6 = this.PolygonPoints[0].position;
            val_8 = val_6.x;
            val_9 = val_6.z;
            val_10 = val_6.y;
            val_5.SetVertexProjected(vertexIndex:  0, vertex:  new UnityEngine.Vector3() {x = val_8, y = val_10, z = val_9});
            val_11 = 1;
            label_2:
            if(val_11 < this.PolygonPoints.Length)
            {
                goto label_8;
            }
            
            val_5.UpdateEdges();
            bool val_7 = Dest.Math.Intersection.FindLine3Polygon3(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}}, polygon:  val_5, info: out  new Dest.Math.Line3Polygon3Intr() {Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_3}});
            val_7.FiguresColor();
            val_7.DrawPolygon(polygon:  val_5);
            val_7.DrawLine(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}});
            if(val_7 != false)
            {
                    val_7.ResultsColor();
                UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            }
            
            val_3 = 0;
            val_3.LogInfo(value:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrLine3Polygon3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
