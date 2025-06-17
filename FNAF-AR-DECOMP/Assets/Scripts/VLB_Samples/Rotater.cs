using UnityEngine;

namespace VLB_Samples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Rotater : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 EulerSpeed;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            UnityEngine.Quaternion val_2 = this.transform.rotation;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.EulerSpeed, y = V12.16B, z = V13.16B}, d:  UnityEngine.Time.deltaTime);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            this.transform.rotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Rotater()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.EulerSpeed = val_1;
            mem[1152921528938169180] = val_1.y;
            mem[1152921528938169184] = val_1.z;
        }
    
    }

}
