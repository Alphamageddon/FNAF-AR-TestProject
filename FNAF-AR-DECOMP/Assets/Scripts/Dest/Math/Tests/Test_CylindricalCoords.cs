using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_CylindricalCoords : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Rho;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Phi;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Height;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            null = null;
            UnityEngine.Vector3 val_1 = Dest.Math.Mathfex.CylindricalToCartesian(cylindricalCoordinates:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_2 = Dest.Math.Mathfex.CartesianToCylindrical(cartesianCoordinates:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            0.FiguresColor();
            0.DrawCircle(circle: ref  new Dest.Math.Circle3() {Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Axis0 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Axis1 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Radius = 0f}, count:  20);
            0.ResultsColor();
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, radius:  0.11f);
            string val_5 = "Cartesian: "("Cartesian: ") + Dest.Math.Vector3ex.ToStringEx(vector:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})(Dest.Math.Vector3ex.ToStringEx(vector:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) + "   Cylindrical: "("   Cylindrical: ") + Dest.Math.Vector3ex.ToStringEx(vector:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z})(Dest.Math.Vector3ex.ToStringEx(vector:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}));
            val_5.LogInfo(value:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_CylindricalCoords()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
