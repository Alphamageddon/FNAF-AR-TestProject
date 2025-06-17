using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrPlane3AAB3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Plane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box_Point0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box_Point1;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_3;
            float val_4;
            Dest.Math.Plane3 val_1 = 48336.CreatePlane3(plane:  this.Plane);
            Dest.Math.AAB3 val_2 = val_1.Normal.x.CreateAAB3(point0:  this.Box_Point0, point1:  this.Box_Point1);
            bool val_5 = Dest.Math.Intersection.TestPlane3AAB3(plane: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = ???, y = ???, z = ???}, Constant = ???}, box: ref  new Dest.Math.AAB3() {Min = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Max = new UnityEngine.Vector3() {x = val_4, y = val_3, z = val_3}});
            val_5.FiguresColor();
            val_5.DrawPlane(plane: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = ???, y = ???, z = ???}, Constant = ???}, Plane:  this.Plane);
            val_5.DrawAAB(box: ref  new Dest.Math.AAB3() {Min = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Max = new UnityEngine.Vector3() {x = val_4, y = val_3, z = val_3}});
            string val_8 = "Intersection: "("Intersection: ") + val_5.ToString();
            val_8.LogInfo(value:  val_8);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrPlane3AAB3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
