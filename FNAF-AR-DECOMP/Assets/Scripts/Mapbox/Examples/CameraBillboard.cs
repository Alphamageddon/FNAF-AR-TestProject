using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CameraBillboard : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Camera _camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Initialized;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Start()
        {
            if(this._camera == 0)
            {
                    return;
            }
            
            this.Initialized = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(this.Initialized == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = this.transform.position;
            UnityEngine.Quaternion val_5 = this._camera.transform.rotation;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_7 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}, point:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Quaternion val_10 = this._camera.transform.rotation;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_12 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w}, point:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            this.transform.LookAt(worldPosition:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, worldUp:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CameraBillboard()
        {
        
        }
    
    }

}
