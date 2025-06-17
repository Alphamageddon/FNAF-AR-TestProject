using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ContCreateScribeCircle2 : Test_Base
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
            float val_8;
            float val_9;
            bool val_17;
            UnityEngine.Vector3 val_1 = this.V0.position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = this.V1.position;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector3 val_5 = this.V2.position;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            Dest.Math.Triangle2 val_7 = 0.CreateTriangle2(v0:  this.V0, v1:  this.V1, v2:  this.V2);
            bool val_10 = Dest.Math.Circle2.CreateCircumscribed(v0:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, v1:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, v2:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, circle: out  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = 0f, y = 0f}, Radius = 0f});
            bool val_12 = Dest.Math.Circle2.CreateInscribed(v0:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, v1:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, v2:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, circle: out  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = 0f, y = 0f}, Radius = 0f});
            val_17 = val_12;
            val_12.FiguresColor();
            val_12.DrawTriangle(triangle: ref  new Dest.Math.Triangle2() {V0 = new UnityEngine.Vector2() {x = val_8, y = val_8}, V1 = new UnityEngine.Vector2() {x = val_8, y = val_8}, V2 = new UnityEngine.Vector2() {x = val_9, y = val_9}});
            val_12.ResultsColor();
            if(val_10 != false)
            {
                    val_12.DrawCircle(circle: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = 0f, y = 0f}, Radius = 0f});
                val_17 = val_17;
            }
            
            if(val_17 != false)
            {
                    val_12.DrawCircle(circle: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = 0f, y = 0f}, Radius = 0f});
            }
            
            string val_15 = "Circumscribed: "("Circumscribed: ") + val_10.ToString() + "   Inscribed: "("   Inscribed: ") + val_17.ToString();
            val_15.LogInfo(value:  val_15);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ContCreateScribeCircle2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
