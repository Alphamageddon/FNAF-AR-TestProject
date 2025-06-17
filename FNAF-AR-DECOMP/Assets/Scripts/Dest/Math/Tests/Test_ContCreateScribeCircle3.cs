using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ContCreateScribeCircle3 : Test_Base
    {
        // Fields
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
            float val_5;
            float val_6;
            float val_7;
            bool val_15;
            UnityEngine.Vector3 val_1 = this.V0.position;
            UnityEngine.Vector3 val_2 = this.V1.position;
            UnityEngine.Vector3 val_3 = this.V2.position;
            Dest.Math.Triangle3 val_4 = this.V2.CreateTriangle3(v0:  this.V0, v1:  this.V1, v2:  this.V2);
            bool val_8 = Dest.Math.Circle3.CreateCircumscribed(v0:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, v1:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, v2:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.z, z = val_2.z}, circle: out  new Dest.Math.Circle3() {Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Axis0 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Axis1 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Radius = 0f});
            bool val_10 = Dest.Math.Circle3.CreateInscribed(v0:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, v1:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, v2:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.z, z = val_2.z}, circle: out  new Dest.Math.Circle3() {Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Axis0 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Axis1 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Radius = 0f});
            val_15 = val_10;
            val_10.FiguresColor();
            val_10.DrawTriangle(triangle: ref  new Dest.Math.Triangle3() {V0 = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, V1 = new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_7}, V2 = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_5}});
            val_10.ResultsColor();
            if(val_8 != false)
            {
                    val_10.DrawCircle(circle: ref  new Dest.Math.Circle3() {Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Axis0 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Axis1 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Radius = 0f}, count:  20);
                val_15 = val_15;
            }
            
            if(val_15 != false)
            {
                    val_10.DrawCircle(circle: ref  new Dest.Math.Circle3() {Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Axis0 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Axis1 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Radius = 0f}, count:  20);
            }
            
            string val_13 = "Circumscribed: "("Circumscribed: ") + val_8.ToString() + "   Inscribed: "("   Inscribed: ") + val_15.ToString();
            val_13.LogInfo(value:  val_13);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ContCreateScribeCircle3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
