using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrLine2Line2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Line0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Line1;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            Dest.Math.IntersectionTypes val_3 = 0;
            Dest.Math.Line2 val_1 = 48324.CreateLine2(line:  this.Line0);
            Dest.Math.Line2 val_2 = val_1.Center.x.CreateLine2(line:  this.Line1);
            bool val_5 = Dest.Math.Intersection.FindLine2Line2(line0: ref  new Dest.Math.Line2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, line1: ref  new Dest.Math.Line2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, info: out  new Dest.Math.Line2Line2Intr() {Point = new UnityEngine.Vector2() {x = 0f, y = 0f}});
            val_5.FiguresColor();
            val_5.DrawLine(line: ref  new Dest.Math.Line2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}});
            val_5.DrawLine(line: ref  new Dest.Math.Line2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}});
            if(val_5 != false)
            {
                    val_5.ResultsColor();
                if(0 == 1)
            {
                    val_5.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            }
            
            }
            
            val_3.LogInfo(value:  val_3);
            if(((Dest.Math.Intersection.TestLine2Line2(line0: ref  new Dest.Math.Line2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, line1: ref  new Dest.Math.Line2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, intersectionType: out  val_3)) ^ val_5) != false)
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
        public Test_IntrLine2Line2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
