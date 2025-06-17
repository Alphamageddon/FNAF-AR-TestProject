using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_PolarCoords : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Rho;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Phi;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            null = null;
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  this.Rho, y:  this.Phi);
            UnityEngine.Vector2 val_2 = Dest.Math.Mathfex.PolarToCartesian(polarCoordinates:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            UnityEngine.Vector2 val_3 = Dest.Math.Mathfex.CartesianToPolar(cartesianCoordinates:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            this.FiguresColor();
            this.DrawCircle(circle: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = 0f, y = 0f}, Radius = 0f});
            this.ResultsColor();
            this.DrawSegment(p0:  new UnityEngine.Vector2() {x = Dest.Math.Vector2ex.Zero, y = Dest.Math.Vector2ex.Zero.__il2cppRuntimeField_4}, p1:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            this.DrawPoint(position:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            this.LogInfo(value:  "Cartesian: "("Cartesian: ") + Dest.Math.Vector2ex.ToStringEx(vector:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y})(Dest.Math.Vector2ex.ToStringEx(vector:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y})) + "    Polar: "("    Polar: ") + Dest.Math.Vector2ex.ToStringEx(vector:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y})(Dest.Math.Vector2ex.ToStringEx(vector:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y})));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_PolarCoords()
        {
        
        }
    
    }

}
