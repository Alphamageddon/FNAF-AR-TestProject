using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrRay2Ray2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Ray0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Ray1;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            Dest.Math.IntersectionTypes val_3 = 0;
            Dest.Math.Ray2 val_1 = 48346.CreateRay2(ray:  this.Ray0);
            Dest.Math.Ray2 val_2 = val_1.Center.x.CreateRay2(ray:  this.Ray1);
            bool val_5 = Dest.Math.Intersection.FindRay2Ray2(ray0: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, ray1: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, info: out  new Dest.Math.Ray2Ray2Intr() {Point = new UnityEngine.Vector2() {x = 0f, y = 0f}});
            val_5.FiguresColor();
            val_5.DrawRay(ray: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}});
            val_5.DrawRay(ray: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}});
            if(val_5 != false)
            {
                    val_5.ResultsColor();
                val_5.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            }
            
            val_3.LogInfo(value:  val_3);
            if(((Dest.Math.Intersection.TestRay2Ray2(ray0: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, ray1: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, intersectionType: out  val_3)) ^ val_5) != false)
            {
                    val_3.LogError(value:  "test != find");
            }
            
            if(val_3 == 0)
            {
                    return;
            }
            
            val_3.LogError(value:  "intersectionType != info.IntersectionType");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrRay2Ray2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
