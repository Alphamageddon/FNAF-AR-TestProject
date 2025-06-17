using UnityEngine;

namespace Mapbox.Examples.Scripts.Utilities
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DragRotate : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _objectToRotate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _multiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _startTouchPosition;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if((UnityEngine.Input.GetMouseButtonDown(button:  0)) != false)
            {
                    UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
                this._startTouchPosition = val_2;
                mem[1152921519872471400] = val_2.y;
                mem[1152921519872471404] = val_2.z;
            }
            
            if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_4 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = this._startTouchPosition, y = V11.16B, z = V10.16B});
            float val_7 = this._multiplier;
            val_7 = -(val_5.x * val_7);
            UnityEngine.Vector3 val_6 = this._objectToRotate.position;
            this._objectToRotate.RotateAround(point:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, axis:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, angle:  this._multiplier);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DragRotate()
        {
        
        }
    
    }

}
