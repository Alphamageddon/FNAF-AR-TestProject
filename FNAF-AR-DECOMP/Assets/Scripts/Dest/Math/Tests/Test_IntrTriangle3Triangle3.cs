using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrTriangle3Triangle3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P2;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            float val_4;
            float val_6;
            float val_7;
            float val_8;
            object val_11;
            float val_12;
            float val_13;
            float val_14;
            object val_15;
            float val_19;
            float val_20;
            float val_21;
            object val_23;
            float val_26;
            Dest.Math.Triangle3 val_1 = CreateTriangle3(v0:  this.V0, v1:  this.V1, v2:  this.V2);
            Dest.Math.Triangle3 val_5 = CreateTriangle3(v0:  this.P0, v1:  this.P1, v2:  this.P2);
            FiguresColor();
            DrawTriangle(triangle: ref  new Dest.Math.Triangle3() {V0 = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, V1 = new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_4}, V2 = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_2}});
            DrawTriangle(triangle: ref  new Dest.Math.Triangle3() {V0 = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_7}, V1 = new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_8}, V2 = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_6}});
            bool val_10 = Dest.Math.Intersection.FindTriangle3Triangle3(triangle0: ref  new Dest.Math.Triangle3() {V0 = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, V1 = new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_4}, V2 = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_2}}, triangle1: ref  new Dest.Math.Triangle3() {V0 = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_7}, V1 = new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_8}, V2 = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_6}}, info: out  new Dest.Math.Triangle3Triangle3Intr() {Touching = false, Point0 = new UnityEngine.Vector3(), Point1 = new UnityEngine.Vector3(), Point2 = new UnityEngine.Vector3(), Point3 = new UnityEngine.Vector3(), Point4 = new UnityEngine.Vector3(), Point5 = new UnityEngine.Vector3() {y = val_7, z = val_7}}, reportCoplanarIntersections:  true);
            if(val_10 == false)
            {
                goto label_10;
            }
            
            val_10.ResultsColor();
            if(val_11 == 6)
            {
                goto label_4;
            }
            
            if(val_11 == 2)
            {
                goto label_5;
            }
            
            if(val_11 != 1)
            {
                goto label_10;
            }
            
            goto label_7;
            label_4:
            if(val_15 < 1)
            {
                goto label_10;
            }
            
            val_26 = 0.11f;
            do
            {
                var val_16 = 0 + 1;
                var val_18 = val_16 - ((val_16 / val_15) * val_15);
                UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_7, y = val_8, z = V2.16B}, to:  new UnityEngine.Vector3() {x = val_7, y = val_8, z = V2.16B});
                UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_7, y = val_8, z = V2.16B}, radius:  val_26);
            }
            while(val_16 < val_15);
            
            goto label_10;
            label_5:
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14}, to:  new UnityEngine.Vector3() {x = val_19, y = val_20, z = val_21});
            val_26 = 0.11f;
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14}, radius:  val_26);
            label_7:
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_19, y = val_20, z = val_21}, radius:  val_26);
            label_10:
            object[] val_22 = new object[8];
            val_22[0] = "Type: ";
            val_3 = val_11;
            val_22[1] = val_3;
            val_22[2] = "      CoplanarType: ";
            val_7 = val_23;
            val_22[3] = val_7;
            val_22[4] = "      Touching: ";
            val_22[5] = ToString();
            val_22[6] = "      Quantity: ";
            val_22[7] = val_15;
            string val_25 = +val_22;
            val_25.LogInfo(value:  val_25);
            if(((Dest.Math.Intersection.TestTriangle3Triangle3(triangle0: ref  new Dest.Math.Triangle3() {V0 = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, V1 = new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_4}, V2 = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_2}}, triangle1: ref  new Dest.Math.Triangle3() {V0 = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_7}, V1 = new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_8}, V2 = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_6}})) ^ val_10) == false)
            {
                    return;
            }
            
            val_25.LogError(value:  "test != find");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrTriangle3Triangle3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
