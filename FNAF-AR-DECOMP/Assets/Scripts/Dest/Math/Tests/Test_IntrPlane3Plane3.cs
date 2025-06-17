using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrPlane3Plane3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Plane0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Plane1;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            Dest.Math.Plane3 val_1 = 48338.CreatePlane3(plane:  this.Plane0);
            Dest.Math.Plane3 val_2 = val_1.Normal.x.CreatePlane3(plane:  this.Plane1);
            bool val_4 = Dest.Math.Intersection.TestPlane3Plane3(plane0: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = ???, y = ???, z = ???}, Constant = ???}, plane1: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = ???, y = ???, z = ???}, Constant = ???});
            bool val_5 = Dest.Math.Intersection.FindPlane3Plane3(plane0: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = ???, y = ???, z = ???}, Constant = ???}, plane1: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = ???, y = ???, z = ???}, Constant = ???}, info: out  new Dest.Math.Plane3Plane3Intr() {Line = new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_4}}});
            val_5.FiguresColor();
            val_5.DrawPlane(plane: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = ???, y = ???, z = ???}, Constant = ???}, Plane:  this.Plane0);
            val_5.DrawPlane(plane: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = ???, y = ???, z = ???}, Constant = ???}, Plane:  this.Plane1);
            if((val_5 != false) && (0 == 4))
            {
                    val_5.ResultsColor();
                val_5.DrawLine(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}});
            }
            
            object[] val_6 = new object[4];
            val_6[0] = "test: ";
            val_6[1] = val_4.ToString();
            val_6[2] = " find: ";
            val_6[3] = 0;
            string val_8 = +val_6;
            val_8.LogInfo(value:  val_8);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrPlane3Plane3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
