using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CameraMovement : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.AbstractMap _map;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _panSpeed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _zoomSpeed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _referenceCamera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Quaternion _originalRotation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _origin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _delta;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _shouldDrag;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleTouch()
        {
            int val_1 = UnityEngine.Input.touchCount;
            if(val_1 != 2)
            {
                    if(val_1 != 1)
            {
                    return;
            }
            
                this.HandleMouseAndKeyBoard();
                return;
            }
            
            UnityEngine.Touch val_2 = UnityEngine.Input.GetTouch(index:  0);
            UnityEngine.Touch val_3 = UnityEngine.Input.GetTouch(index:  1);
            UnityEngine.Vector2 val_4 = position;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            UnityEngine.Vector2 val_6 = position;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, b:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, b:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, b:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
            val_9.x = val_9.x - val_8.x;
            val_9.x = val_9.x * 0.05f;
            this.ZoomMapUsingTouchOrMouse(zoomFactor:  val_9.x);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ZoomMapUsingTouchOrMouse(float zoomFactor)
        {
            float val_7 = zoomFactor;
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Vector3 val_2 = val_1.localPosition;
            val_7 = this._zoomSpeed * val_7;
            UnityEngine.Vector3 val_4 = this.transform.forward;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  val_7);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            val_1.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleMouseAndKeyBoard()
        {
            if((UnityEngine.Input.GetMouseButton(button:  0)) != false)
            {
                    if(UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject() == false)
            {
                goto label_5;
            }
            
            }
            
            this._shouldDrag = false;
            label_27:
            if(UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject() == true)
            {
                    return;
            }
            
            float val_30 = this._zoomSpeed;
            UnityEngine.Transform val_9 = this.transform;
            UnityEngine.Vector3 val_10 = val_9.localPosition;
            val_30 = (UnityEngine.Input.GetAxis(axisName:  "Mouse ScrollWheel")) * val_30;
            UnityEngine.Vector3 val_12 = this.transform.forward;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  val_30);
            float val_31 = UnityEngine.Input.GetAxis(axisName:  "Horizontal");
            val_31 = val_31 * this._panSpeed;
            float val_14 = (UnityEngine.Input.GetAxis(axisName:  "Vertical")) * this._panSpeed;
            UnityEngine.Vector3 val_15 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = this._originalRotation, y = val_12.x, z = val_12.z, w = val_12.y}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            val_9.localPosition = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
            this = this._map;
            return;
            label_5:
            UnityEngine.Vector3 val_18 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector3 val_20 = this._referenceCamera.transform.localPosition;
            UnityEngine.Vector3 val_21 = this._referenceCamera.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_20.y});
            UnityEngine.Vector3 val_23 = this._referenceCamera.transform.localPosition;
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
            this._delta = val_24;
            mem[1152921519848221572] = val_24.z;
            mem[1152921519848221568] = 0;
            if(this._shouldDrag == true)
            {
                goto label_25;
            }
            
            this._shouldDrag = true;
            UnityEngine.Vector3 val_25 = this._referenceCamera.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_20.y});
            this._origin = val_25;
            mem[1152921519848221556] = val_25.y;
            mem[1152921519848221560] = val_25.z;
            if(this._shouldDrag == false)
            {
                goto label_27;
            }
            
            label_25:
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this._origin, y = val_21.y, z = val_21.x}, b:  new UnityEngine.Vector3() {x = this._delta, y = val_20.y, z = val_23.z});
            UnityEngine.Vector3 val_28 = this.transform.localPosition;
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_26.x, y = val_28.y, z = val_26.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            UnityEngine.Vector3 val_2 = this.transform.eulerAngles;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(x:  0f, y:  val_2.y, z:  0f);
            this._originalRotation = val_3;
            mem[1152921519848404356] = val_3.y;
            mem[1152921519848404360] = val_3.z;
            mem[1152921519848404364] = val_3.w;
            if(this._referenceCamera != 0)
            {
                    return;
            }
            
            UnityEngine.Camera val_5 = this.GetComponent<UnityEngine.Camera>();
            this._referenceCamera = val_5;
            if(val_5 != 0)
            {
                    return;
            }
            
            System.Exception val_7 = new System.Exception(message:  "You must have a reference camera assigned!");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LateUpdate()
        {
            if(UnityEngine.Input.touchSupported != false)
            {
                    if(UnityEngine.Input.touchCount >= 1)
            {
                    this.HandleTouch();
                return;
            }
            
            }
            
            this.HandleMouseAndKeyBoard();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CameraMovement()
        {
            this._panSpeed = 20f;
            this._zoomSpeed = 50f;
        }
    
    }

}
