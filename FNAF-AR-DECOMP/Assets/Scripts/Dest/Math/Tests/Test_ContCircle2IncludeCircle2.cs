using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ContCircle2IncludeCircle2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Circle0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Circle1;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            Dest.Math.Circle2 val_1 = this.CreateCircle2(circle:  this.Circle0);
            Dest.Math.Circle2 val_2 = val_1.Center.x.CreateCircle2(circle:  this.Circle1);
            ???.Include(circle:  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = 0f, y = 0f}});
            ???.FiguresColor();
            ???.DrawCircle(circle: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Radius = ???});
            ???.DrawCircle(circle: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Radius = ???});
            ???.ResultsColor();
            ???.DrawCircle(circle: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Radius = ???});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ContCircle2IncludeCircle2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
