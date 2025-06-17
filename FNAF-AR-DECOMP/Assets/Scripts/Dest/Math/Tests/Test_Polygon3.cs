using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_Polygon3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Plane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform[] Points;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_4;
            float val_5;
            var val_6;
            Dest.Math.Plane3 val_1 = this.CreatePlane3(plane:  this.Plane);
            val_4 = V0.16B;
            val_5 = V2.16B;
            Dest.Math.Polygon3 val_2 = new Dest.Math.Polygon3(vertexCount:  this.Points.Length, plane:  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = 0f, y = 0f}});
            val_6 = 0;
            goto label_2;
            label_8:
            UnityEngine.Vector3 val_3 = this.Points[0].position;
            val_4 = val_3.x;
            val_5 = val_3.z;
            val_2.SetVertexProjected(vertexIndex:  0, vertex:  new UnityEngine.Vector3() {x = val_4, y = val_3.y, z = val_5});
            val_6 = 1;
            label_2:
            if(val_6 < this.Points.Length)
            {
                goto label_8;
            }
            
            val_2.UpdateEdges();
            this.DrawPolygon(polygon:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_Polygon3()
        {
        
        }
    
    }

}
