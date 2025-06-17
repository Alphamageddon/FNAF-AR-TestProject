using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_Plane3Sides : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Plane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Point;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform AABMin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform AABMax;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Sphere;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_4;
            float val_5;
            float val_7;
            float val_8;
            float val_9;
            float val_10;
            Dest.Math.Plane3 val_1 = this.CreatePlane3(plane:  this.Plane);
            UnityEngine.Vector3 val_2 = this.Point.position;
            Dest.Math.AAB3 val_3 = this.CreateAAB3(point0:  this.AABMin, point1:  this.AABMax);
            Dest.Math.Box3 val_6 = this.CreateBox3(box:  this.Box);
            Dest.Math.Sphere3 val_11 = this.CreateSphere3(sphere:  this.Sphere);
            this.FiguresColor();
            this.DrawPlane(plane: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = 0f, y = ???, z = ???}, Constant = ???}, Plane:  this.Plane);
            this.SetColor(side:  2107094960);
            this.DrawPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            this.SetColor(side:  2107094960);
            this.DrawAAB(box: ref  new Dest.Math.AAB3() {Min = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, Max = new UnityEngine.Vector3() {x = val_5, y = val_4, z = val_4}});
            this.SetColor(side:  2107094960);
            this.DrawBox(box: ref  new Dest.Math.Box3() {Center = new UnityEngine.Vector3() {x = val_9, y = val_9, z = val_9}, Axis0 = new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_10}, Axis1 = new UnityEngine.Vector3() {x = val_10, y = val_10, z = val_8}, Axis2 = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_8}, Extents = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_7}});
            this.SetColor(side:  2107094960);
            this.DrawSphere(sphere: ref  new Dest.Math.Sphere3() {Center = new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9}, Radius = val_10});
            object[] val_12 = new object[18];
            val_12[0] = "PointSignedDistance: ";
            val_12[1] = val_2.x;
            val_12[2] = " PointNeg: ";
            val_12[3] = 0.ToString();
            val_12[4] = " PointPos: ";
            val_12[5] = 0.ToString();
            val_12[6] = "     AABNeg: ";
            val_12[7] = 0.ToString();
            val_12[8] = " AABPos: ";
            val_12[9] = 0.ToString();
            val_12[10] = "     BoxNeg: ";
            val_12[11] = 0.ToString();
            val_12[12] = " BoxPos: ";
            val_12[13] = 0.ToString();
            val_12[14] = "     SphereNeg: ";
            val_12[15] = 0.ToString();
            val_12[16] = " SpherePos: ";
            val_12[17] = 0.ToString();
            this.LogInfo(value:  +val_12);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetColor(int side)
        {
            if((side & 2147483648) != 0)
            {
                goto label_0;
            }
            
            if(side == 0)
            {
                goto label_1;
            }
            
            UnityEngine.Color val_1 = UnityEngine.Color.red;
            goto label_2;
            label_0:
            UnityEngine.Color val_2 = UnityEngine.Color.blue;
            label_2:
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
            return;
            label_1:
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_Plane3Sides()
        {
        
        }
    
    }

}
