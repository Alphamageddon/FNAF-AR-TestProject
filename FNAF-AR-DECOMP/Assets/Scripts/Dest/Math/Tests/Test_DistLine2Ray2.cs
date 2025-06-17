using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_DistLine2Ray2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Line;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Ray;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            Dest.Math.Line2 val_1 = 48273.CreateLine2(line:  this.Line);
            Dest.Math.Ray2 val_2 = val_1.Center.x.CreateRay2(ray:  this.Ray);
            float val_3 = Dest.Math.Distance.Line2Ray2(line: ref  new Dest.Math.Line2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, ray: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, closestPoint0: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, closestPoint1: out  new UnityEngine.Vector2() {x = 0f, y = 0f});
            ???.FiguresColor();
            ???.DrawLine(line: ref  new Dest.Math.Line2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}});
            ???.DrawRay(ray: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}});
            ???.ResultsColor();
            ???.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            ???.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            val_3.LogInfo(value:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_DistLine2Ray2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
