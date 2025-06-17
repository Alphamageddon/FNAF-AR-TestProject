using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_SphericalCoords : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Rho;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Theta;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Phi;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            null = null;
            UnityEngine.Vector3 val_1 = Dest.Math.Mathfex.SphericalToCartesian(sphericalCoordinates:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_2 = Dest.Math.Mathfex.CartesianToSpherical(cartesianCoordinates:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            this.FiguresColor();
            this.DrawSphere(sphere: ref  new Dest.Math.Sphere3() {Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Radius = 0f});
            this.ResultsColor();
            this.DrawSegment(p0:  new UnityEngine.Vector3() {x = Dest.Math.Vector3ex.Zero, y = Dest.Math.Vector3ex.Zero.__il2cppRuntimeField_4, z = Dest.Math.Vector3ex.Zero.__il2cppRuntimeField_8}, p1:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            this.DrawPoint(position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            this.LogInfo(value:  "Cartesian: "("Cartesian: ") + Dest.Math.Vector3ex.ToStringEx(vector:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})(Dest.Math.Vector3ex.ToStringEx(vector:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) + "   Spherical: "("   Spherical: ") + Dest.Math.Vector3ex.ToStringEx(vector:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z})(Dest.Math.Vector3ex.ToStringEx(vector:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z})));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_SphericalCoords()
        {
        
        }
    
    }

}
