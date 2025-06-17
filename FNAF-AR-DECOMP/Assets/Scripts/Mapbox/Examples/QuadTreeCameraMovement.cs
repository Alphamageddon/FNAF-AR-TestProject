using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class QuadTreeCameraMovement : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float _rotateSpeed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _zoomSpeed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Camera _referenceCamera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.AbstractMap _mapManager;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float minZoom;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float maxZoom;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 _origin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 _touchPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 _prevTouchPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isInitialized;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isDragging;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            if(0 == this._referenceCamera)
            {
                    UnityEngine.Camera val_2 = this.GetComponent<UnityEngine.Camera>();
                this._referenceCamera = val_2;
                if(0 == val_2)
            {
                    object[] val_4 = new object[1];
                val_4[0] = this.GetType();
                UnityEngine.Debug.LogErrorFormat(format:  "{0}: reference camera not set", args:  val_4);
            }
            
            }
            
            this._mapManager.add_OnInitialized(value:  new System.Action(object:  this, method:  System.Void Mapbox.Examples.QuadTreeCameraMovement::<Awake>b__11_0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LateUpdate()
        {
            if(this._isInitialized == false)
            {
                    return;
            }
            
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
        private void HandleMouseAndKeyBoard()
        {
            this.ZoomMapUsingTouchOrMouse(zoomFactor:  UnityEngine.Input.GetAxis(axisName:  "Mouse ScrollWheel"));
            this.RotateMapFromKeyboardMouse();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleTouch()
        {
            int val_1 = UnityEngine.Input.touchCount;
            if(val_1 == 2)
            {
                goto label_1;
            }
            
            if(val_1 == 1)
            {
                goto label_2;
            }
            
            if(val_1 != 0)
            {
                    return;
            }
            
            this._isDragging = false;
            this._prevTouchPosition = this._origin;
            mem[1152921519860609628] = ???;
            return;
            label_1:
            UnityEngine.Touch val_2 = UnityEngine.Input.GetTouch(index:  0);
            UnityEngine.Touch val_3 = UnityEngine.Input.GetTouch(index:  1);
            UnityEngine.Vector2 val_4 = position;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            UnityEngine.Vector2 val_6 = position;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, b:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, b:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, b:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
            val_9.x = val_9.x - val_8.x;
            val_9.x = val_9.x * 0.01f;
            this.ZoomMapUsingTouchOrMouse(zoomFactor:  val_9.x);
            return;
            label_2:
            UnityEngine.Touch val_10 = UnityEngine.Input.GetTouch(index:  0);
            this._touchPosition = new UnityEngine.Vector2();
            mem[1152921519860609620] = ???;
            this.RotateMap();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ZoomMapUsingTouchOrMouse(float zoomFactor)
        {
            var val_8;
            var val_9;
            float val_2 = this._zoomSpeed * zoomFactor;
            val_2 = this._mapManager.Zoom + val_2;
            float val_5 = this._mapManager.Zoom;
            val_5 = (UnityEngine.Mathf.Max(a:  this.minZoom, b:  UnityEngine.Mathf.Min(a:  val_2, b:  this.maxZoom))) - val_5;
            if(val_5 == 0f)
            {
                    return;
            }
            
            if(val_5 > _TYPE_MAX_)
            {
                    return;
            }
            
            if(this._mapManager != null)
            {
                    Mapbox.Utils.Vector2d val_6 = this._mapManager.CenterLatitudeLongitude;
                val_8 = val_6.x;
                val_9 = val_6.y;
            }
            else
            {
                    Mapbox.Utils.Vector2d val_7 = 0.CenterLatitudeLongitude;
                val_8 = val_7.x;
                val_9 = val_7.y;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RotateMapFromKeyboardMouse()
        {
            if((UnityEngine.Input.GetMouseButton(button:  0)) != false)
            {
                    UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
                UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
                this._touchPosition = val_3;
                mem[1152921519860895204] = val_3.y;
                this.RotateMap();
                return;
            }
            
            this._isDragging = false;
            this._prevTouchPosition = this._origin;
            mem[1152921519860895212] = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RotateMap()
        {
            if(this._isDragging != true)
            {
                    this._isDragging = true;
                this._prevTouchPosition = this._touchPosition;
                mem[1152921519861027692] = ???;
            }
            
            if(UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject() == true)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_4 = this._mapManager.transform.localEulerAngles;
            float val_7 = val_4.y;
            val_7 = val_7 - this.GetDragAngle();
            this._mapManager.transform.localEulerAngles = new UnityEngine.Vector3() {x = val_4.x, y = val_7, z = val_4.z};
            this._prevTouchPosition = this._touchPosition;
            mem[1152921519861027692] = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float GetDragAngle()
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this._origin, y = V9.16B}, b:  new UnityEngine.Vector2() {x = this._prevTouchPosition, y = V8.16B});
            UnityEngine.Vector2 val_2 = val_1.x.normalized;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this._origin, y = V4.16B}, b:  new UnityEngine.Vector2() {x = this._touchPosition, y = V8.16B});
            UnityEngine.Vector2 val_4 = val_3.x.normalized;
            float val_5 = UnityEngine.Vector2.SignedAngle(from:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, to:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            val_5 = val_5 * this._rotateSpeed;
            return (float)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartDragging()
        {
            this._isDragging = true;
            this._prevTouchPosition = this._touchPosition;
            mem[1152921519861272172] = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StopDragging()
        {
            this._isDragging = false;
            this._prevTouchPosition = this._origin;
            mem[1152921519861384172] = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public QuadTreeCameraMovement()
        {
            this._rotateSpeed = 0.1f;
            this._zoomSpeed = 0.25f;
            this.minZoom = 11.8f;
            this.maxZoom = 16f;
            int val_1 = UnityEngine.Screen.width;
            int val_2 = UnityEngine.Screen.height;
            var val_3 = (val_1 < 0) ? (val_1 + 1) : (val_1);
            val_3 = val_3 >> 1;
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  (float)val_3, y:  (float)((val_2 < 0) ? (val_2 + 1) : (val_2)) >> 1);
            this._origin = val_6.x;
            mem[1152921519861496156] = val_6.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <Awake>b__11_0()
        {
            this._isInitialized = true;
        }
    
    }

}
