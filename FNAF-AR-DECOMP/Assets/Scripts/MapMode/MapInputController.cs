using UnityEngine;

namespace MapMode
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MapInputController : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float rotateDragSpeed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _zoomSpeed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Camera _referenceCamera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.AbstractMap _mapManager;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject PlayerObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 minCameraPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 maxCameraPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 minCameraRotation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 maxCameraRotation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float minPlayerScale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float maxPlayerScale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.LocationProviderFactory locationProviderFactory;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float RotationResetTimer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float RotationResetSpeed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float RotationCompassSpeed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject Map_Spotlight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float minLightRange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float maxLightRange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<MapMode.GeoPositionObject.MapAnimatronic> AnimatronicTapped;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _zoomLerp;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 _touchPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 _prevTouchPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _targetIsBeingOverridden;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _targetOverride;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isInitialized;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isDragging;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _rotationHeadingBuffer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _dragMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _blockInput;
        
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
            
            this._mapManager.add_OnInitialized(value:  new System.Action(object:  this, method:  System.Void MapMode.MapInputController::<Awake>b__29_0()));
            this.ZoomMap(zoomFactor:  0f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LateUpdate()
        {
            if(this._isInitialized == false)
            {
                    return;
            }
            
            if(this._targetIsBeingOverridden != false)
            {
                    if(this._targetOverride != 0)
            {
                    this.RotateMapFromOverrideTarget(deltaTime:  UnityEngine.Time.deltaTime);
                return;
            }
            
                this._targetIsBeingOverridden = false;
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
        public void SetOverrideTarget(UnityEngine.Transform target)
        {
            this._targetOverride = target;
            this._targetIsBeingOverridden = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.GeoPositionObject.MapAnimatronic GetSelectedMapAnimatronic(UnityEngine.Vector2 inputPosition)
        {
            float val_5;
            float val_6;
            float val_12;
            UnityEngine.Camera val_13;
            var val_14;
            val_12 = inputPosition.y;
            val_13 = this;
            val_14 = 0;
            if(this._blockInput == true)
            {
                    return (MapMode.GeoPositionObject.MapAnimatronic)val_13.GetComponent<MapMode.GeoPositionObject.MapAnimatronic>();
            }
            
            val_14 = 0;
            if(UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject() == true)
            {
                    return (MapMode.GeoPositionObject.MapAnimatronic)val_13.GetComponent<MapMode.GeoPositionObject.MapAnimatronic>();
            }
            
            val_13 = this._referenceCamera;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = inputPosition.x, y = val_12});
            val_12 = val_3.x;
            UnityEngine.Ray val_4 = val_13.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_12, y = val_3.y, z = val_3.z});
            val_14 = 0;
            if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, m_Direction = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}})) == false)
            {
                    return (MapMode.GeoPositionObject.MapAnimatronic)val_13.GetComponent<MapMode.GeoPositionObject.MapAnimatronic>();
            }
            
            val_13;
            val_14 = 0;
            if((0.CompareTag(tag:  "AnimatronicModel")) == false)
            {
                    return (MapMode.GeoPositionObject.MapAnimatronic)val_13.GetComponent<MapMode.GeoPositionObject.MapAnimatronic>();
            }
            
            val_13 = 0.gameObject;
            return (MapMode.GeoPositionObject.MapAnimatronic)val_13.GetComponent<MapMode.GeoPositionObject.MapAnimatronic>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleMouseAndKeyBoard()
        {
            float val_1 = UnityEngine.Input.GetAxis(axisName:  "Mouse ScrollWheel");
            if(val_1 != 0f)
            {
                    this.ZoomMap(zoomFactor:  val_1);
            }
            
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
            
            this.StopDragging();
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
            this.ZoomMap(zoomFactor:  val_9.x);
            return;
            label_2:
            UnityEngine.Touch val_10 = UnityEngine.Input.GetTouch(index:  0);
            this._touchPosition = new UnityEngine.Vector2();
            mem[1152921524614522424] = ???;
            MapMode.GeoPositionObject.MapAnimatronic val_11 = this.GetSelectedMapAnimatronic(inputPosition:  new UnityEngine.Vector2());
            if(val_11 != 0)
            {
                    this.AnimatronicPushed(animatronic:  val_11);
                return;
            }
            
            this.RotateMap();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartDragging()
        {
            if(this._isDragging != false)
            {
                    return;
            }
            
            this._isDragging = true;
            this._prevTouchPosition = this._touchPosition;
            mem[1152921524614675536] = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StopDragging()
        {
            if(this._isDragging != false)
            {
                    this._isDragging = false;
                UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
                this._prevTouchPosition = val_1;
                mem[1152921524614787536] = val_1.y;
            }
            
            this._blockInput = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AnimatronicPushed(MapMode.GeoPositionObject.MapAnimatronic animatronic)
        {
            if(animatronic.CanTap() == false)
            {
                    return;
            }
            
            if(this.AnimatronicTapped != null)
            {
                    this.AnimatronicTapped.Invoke(obj:  animatronic);
            }
            
            this._blockInput = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ZoomMap(float zoomFactor)
        {
            zoomFactor = this._zoomSpeed * zoomFactor;
            zoomFactor = this._zoomLerp + zoomFactor;
            float val_1 = UnityEngine.Mathf.Clamp(value:  zoomFactor, min:  0f, max:  1f);
            this._zoomLerp = val_1;
            this.SetZoomProportion(prop:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetZoomProportion(float prop)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.minCameraPosition, y = V12.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = this.maxCameraPosition, y = V10.16B, z = V8.16B}, t:  prop);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.minCameraRotation, y = val_1.y, z = prop}, b:  new UnityEngine.Vector3() {x = this.maxCameraRotation, y = V10.16B, z = V8.16B}, t:  prop);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  UnityEngine.Mathf.Lerp(a:  this.minPlayerScale, b:  this.maxPlayerScale, t:  prop));
            this.PlayerObject.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            this.Map_Spotlight.GetComponent<UnityEngine.Light>().range = UnityEngine.Mathf.Lerp(a:  this.minLightRange, b:  this.maxLightRange, t:  prop);
            this._referenceCamera.transform.localPosition = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            this._referenceCamera.transform.localEulerAngles = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RotateMapFromKeyboardMouse()
        {
            if((UnityEngine.Input.GetMouseButton(button:  0)) != false)
            {
                    UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
                UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
                this._touchPosition = val_3;
                mem[1152921524615322568] = val_3.y;
                MapMode.GeoPositionObject.MapAnimatronic val_4 = this.GetSelectedMapAnimatronic(inputPosition:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
                if(val_4 != 0)
            {
                    this.AnimatronicPushed(animatronic:  val_4);
            }
            
                this.RotateMap();
                return;
            }
            
            this.StopDragging();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RotateMapFromOverrideTarget(float deltaTime)
        {
            UnityEngine.Vector3 val_1 = this._targetOverride.localPosition;
            UnityEngine.Vector3 val_3 = this._mapManager.transform.forward;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.FromToRotation(fromDirection:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, toDirection:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Quaternion val_7 = this._mapManager.transform.localRotation;
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, b:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, t:  0.05f);
            this._mapManager.transform.localRotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RotateMap()
        {
            bool val_10 = this._isDragging;
            this._dragMode = true;
            if(val_10 != true)
            {
                    val_10 = this._touchPosition;
                this._isDragging = true;
                this._prevTouchPosition = val_10;
                mem[1152921524615620304] = ???;
            }
            
            if(UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject() == true)
            {
                    return;
            }
            
            UnityEngine.Transform val_3 = this._mapManager.transform;
            UnityEngine.Quaternion val_4 = val_3.localRotation;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  this.GetDragAngle());
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, rhs:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w});
            val_3.localRotation = new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w};
            this._prevTouchPosition = this._touchPosition;
            mem[1152921524615620304] = val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float GetDragAngle()
        {
            UnityEngine.Vector3 val_2 = this.PlayerObject.transform.position;
            UnityEngine.Vector3 val_3 = this._referenceCamera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, b:  new UnityEngine.Vector2() {x = this._prevTouchPosition});
            UnityEngine.Vector2 val_6 = val_5.x.normalized;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, b:  new UnityEngine.Vector2() {x = this._touchPosition});
            UnityEngine.Vector2 val_8 = val_7.x.normalized;
            float val_9 = UnityEngine.Vector2.SignedAngle(from:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, to:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
            val_9 = -(val_9 * this.rotateDragSpeed);
            return (float)val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LocationProviderSelected(Mapbox.Unity.Location.ILocationProvider provider)
        {
            IntPtr val_3;
            System.Action<Mapbox.Unity.Location.Location> val_1 = null;
            val_3 = public System.Void MapMode.MapInputController::UpdateMapLocation(Mapbox.Unity.Location.Location location);
            val_1 = new System.Action<Mapbox.Unity.Location.Location>(object:  this, method:  val_3);
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = 0;
            provider.add_OnLocationUpdated(value:  val_1);
            this._isInitialized = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateMapLocation(Mapbox.Unity.Location.Location location)
        {
            if(this._mapManager == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapInputController()
        {
            this.rotateDragSpeed = 0.1f;
            this._zoomSpeed = 0.25f;
            this.minPlayerScale = 1.5f;
            this.maxPlayerScale = 1f;
            this.RotationResetTimer = 3f;
            this.RotationResetSpeed = 200f;
            this.RotationCompassSpeed = 75f;
            this.minLightRange = 300f;
            this.maxLightRange = 328f;
            this._rotationHeadingBuffer = 5f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <Awake>b__29_0()
        {
            System.Action<Mapbox.Unity.Location.ILocationProvider> val_6;
            Mapbox.Unity.Location.ILocationProvider val_1 = this.locationProviderFactory.DefaultLocationProvider;
            if(this.locationProviderFactory == null)
            {
                goto label_2;
            }
            
            if(val_1 == null)
            {
                goto label_3;
            }
            
            label_4:
            this.LocationProviderSelected(provider:  this.locationProviderFactory.DefaultLocationProvider);
            return;
            label_2:
            if(val_1 != null)
            {
                goto label_4;
            }
            
            label_3:
            val_6 = System.Delegate.Combine(a:  this.locationProviderFactory.OnLocationProviderSelected, b:  new System.Action<Mapbox.Unity.Location.ILocationProvider>(object:  this, method:  public System.Void MapMode.MapInputController::LocationProviderSelected(Mapbox.Unity.Location.ILocationProvider provider)));
            if(this.locationProviderFactory == null)
            {
                goto label_5;
            }
            
            if(val_6 != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            if(val_6 == null)
            {
                goto label_9;
            }
            
            label_6:
            if(null != null)
            {
                    val_6 = 0;
            }
            
            label_9:
            this.locationProviderFactory.OnLocationProviderSelected = val_6;
        }
    
    }

}
