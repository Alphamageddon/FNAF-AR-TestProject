using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ContCreateScribeSphere3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V3;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            bool val_12;
            float val_13;
            float val_14;
            UnityEngine.Vector3 val_1 = this.V0.position;
            UnityEngine.Vector3 val_2 = this.V1.position;
            UnityEngine.Vector3 val_3 = this.V2.position;
            UnityEngine.Vector3 val_4 = this.V3.position;
            bool val_5 = Dest.Math.Sphere3.CreateCircumscribed(v0:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, v1:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, v2:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.z, z = val_4.x}, v3:  new UnityEngine.Vector3() {x = val_4.z, y = val_4.x, z = val_2.z}, sphere: out  new Dest.Math.Sphere3() {Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Radius = 0f});
            bool val_7 = Dest.Math.Sphere3.CreateInscribed(v0:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, v1:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, v2:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.z, z = val_4.x}, v3:  new UnityEngine.Vector3() {x = val_4.z, y = val_4.x, z = val_2.z}, sphere: out  new Dest.Math.Sphere3() {Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Radius = 0f});
            val_12 = val_7;
            val_7.FiguresColor();
            val_13 = val_1.y;
            val_14 = val_2.x;
            val_7.DrawTetrahedron(v0:  new UnityEngine.Vector3() {x = val_1.x, y = val_13, z = val_1.z}, v1:  new UnityEngine.Vector3() {x = val_14, y = val_2.y, z = val_2.z}, v2:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.z, z = val_4.x}, v3:  new UnityEngine.Vector3() {x = val_4.z, y = val_4.x, z = val_2.z});
            val_7.ResultsColor();
            if(val_5 != false)
            {
                    val_13 = 0f;
                val_14 = 0f;
                UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = 0f, y = val_13, z = 0f}, radius:  val_14);
                val_12 = val_12;
            }
            
            if(val_12 != false)
            {
                    UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0f);
            }
            
            string val_10 = "Circumscribed: "("Circumscribed: ") + val_5.ToString() + "   Inscribed: "("   Inscribed: ") + val_12.ToString();
            val_10.LogInfo(value:  val_10);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ContCreateScribeSphere3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
