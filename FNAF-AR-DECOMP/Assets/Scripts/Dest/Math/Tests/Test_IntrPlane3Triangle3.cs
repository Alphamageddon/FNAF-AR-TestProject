using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrPlane3Triangle3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Plane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V2;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_3;
            float val_4;
            float val_5;
            Dest.Math.Plane3 val_1 = 48340.CreatePlane3(plane:  this.Plane);
            Dest.Math.Triangle3 val_2 = val_1.Normal.x.CreateTriangle3(v0:  this.V0, v1:  this.V1, v2:  this.V2);
            bool val_7 = Dest.Math.Intersection.TestPlane3Triangle3(plane: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = 0f, y = ???, z = ???}, Constant = ???}, triangle: ref  new Dest.Math.Triangle3() {V0 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, V1 = new UnityEngine.Vector3() {x = val_5, y = val_4, z = val_4}, V2 = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_3}});
            bool val_8 = Dest.Math.Intersection.FindPlane3Triangle3(plane: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = 0f, y = ???, z = ???}, Constant = ???}, triangle: ref  new Dest.Math.Triangle3() {V0 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, V1 = new UnityEngine.Vector3() {x = val_5, y = val_4, z = val_4}, V2 = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_3}}, info: out  new Dest.Math.Plane3Triangle3Intr() {Point0 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Point1 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Point2 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_7}});
            val_8.FiguresColor();
            val_8.DrawPlane(plane: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = 0f, y = ???, z = ???}, Constant = ???}, Plane:  this.Plane);
            val_8.DrawTriangle(triangle: ref  new Dest.Math.Triangle3() {V0 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, V1 = new UnityEngine.Vector3() {x = val_5, y = val_4, z = val_4}, V2 = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_3}});
            if(val_8 != false)
            {
                    val_8.ResultsColor();
                if(0 == 2)
            {
                    UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            }
            
            }
            
            object[] val_9 = new object[4];
            val_9[0] = "test: ";
            val_9[1] = val_7.ToString();
            val_9[2] = " find: ";
            val_5 = 0;
            val_9[3] = val_5;
            string val_11 = +val_9;
            val_11.LogInfo(value:  val_11);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrPlane3Triangle3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
