using UnityEngine;

namespace TMPro.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CameraController : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform cameraTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform dummyTarget;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform CameraTarget;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float FollowDistance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MaxFollowDistance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MinFollowDistance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ElevationAngle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MaxElevationAngle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MinElevationAngle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float OrbitalAngle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.Examples.CameraController.CameraModes CameraMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool MovementSmoothing;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool RotationSmoothing;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool previousSmoothing;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MovementSmoothingValue;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float RotationSmoothingValue;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MoveSensitivity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 currentVelocity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 desiredPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float mouseX;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float mouseY;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 moveVector;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float mouseWheel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string event_SmoothingValue = "Slider - Smoothing Value";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string event_FollowDistance = "Slider - Camera Zoom";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            var val_5;
            if(UnityEngine.QualitySettings.vSyncCount >= 1)
            {
                    val_5 = 60;
            }
            else
            {
                    val_5 = 0;
            }
            
            UnityEngine.Application.targetFrameRate = 0;
            if(UnityEngine.Application.platform != 8)
            {
                    if(UnityEngine.Application.platform != 11)
            {
                goto label_3;
            }
            
            }
            
            UnityEngine.Input.simulateMouseWithTouches = false;
            label_3:
            this.cameraTransform = this.transform;
            this.previousSmoothing = this.MovementSmoothing;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            if(this.CameraTarget != 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_3 = new UnityEngine.GameObject(name:  "Camera Target").transform;
            this.dummyTarget = val_3;
            this.CameraTarget = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LateUpdate()
        {
            UnityEngine.Transform val_21;
            float val_22;
            float val_23;
            float val_24;
            float val_26;
            float val_27;
            float val_28;
            float val_32;
            float val_33;
            float val_34;
            float val_35;
            val_21 = this;
            this.GetPlayerInput();
            if(this.CameraTarget == 0)
            {
                    return;
            }
            
            if(this.CameraMode == 0)
            {
                goto label_4;
            }
            
            if(this.CameraMode != 1)
            {
                goto label_5;
            }
            
            UnityEngine.Vector3 val_2 = this.CameraTarget.position;
            val_22 = val_2.x;
            val_23 = val_2.y;
            val_24 = val_2.z;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(x:  this.ElevationAngle, y:  this.OrbitalAngle, z:  0f);
            val_26 = val_3.x;
            val_27 = val_3.y;
            val_28 = val_3.z;
            UnityEngine.Vector3 val_4 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_26, y = val_27, z = val_28, w = val_3.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            goto label_9;
            label_4:
            UnityEngine.Vector3 val_5 = this.CameraTarget.position;
            val_22 = val_5.x;
            val_23 = val_5.y;
            val_24 = val_5.z;
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(x:  this.ElevationAngle, y:  this.OrbitalAngle, z:  0f);
            UnityEngine.Vector3 val_7 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_26 = val_7.x;
            val_27 = val_7.y;
            val_28 = val_7.z;
            UnityEngine.Vector3 val_8 = this.CameraTarget.TransformDirection(direction:  new UnityEngine.Vector3() {x = val_26, y = val_27, z = val_28});
            label_9:
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_22, y = val_23, z = val_24}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            this.desiredPosition = val_9;
            mem[1152921524657327216] = val_9.y;
            mem[1152921524657327220] = val_9.z;
            label_5:
            if(this.MovementSmoothing == false)
            {
                goto label_16;
            }
            
            UnityEngine.Vector3 val_10 = this.cameraTransform.position;
            val_33 = UnityEngine.Time.fixedDeltaTime;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.SmoothDamp(current:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, target:  new UnityEngine.Vector3() {x = this.desiredPosition, y = val_8.y, z = val_8.z}, currentVelocity: ref  new UnityEngine.Vector3() {x = this.currentVelocity, y = this.currentVelocity, z = this.currentVelocity}, smoothTime:  this.MovementSmoothingValue * val_33);
            val_34 = val_13.x;
            val_35 = val_13.z;
            if(this.cameraTransform != null)
            {
                goto label_31;
            }
            
            label_32:
            label_31:
            this.cameraTransform.position = new UnityEngine.Vector3() {x = val_34, y = val_13.y, z = val_35};
            if(this.RotationSmoothing == false)
            {
                goto label_21;
            }
            
            UnityEngine.Quaternion val_14 = this.cameraTransform.rotation;
            UnityEngine.Vector3 val_15 = this.CameraTarget.position;
            UnityEngine.Vector3 val_16 = this.cameraTransform.position;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            UnityEngine.Quaternion val_18 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            val_33 = this.RotationSmoothingValue;
            val_32 = val_18.z;
            float val_19 = UnityEngine.Time.deltaTime;
            val_19 = val_33 * val_19;
            UnityEngine.Quaternion val_20 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w}, b:  new UnityEngine.Quaternion() {x = val_18.x, y = val_18.y, z = val_32, w = val_18.w}, t:  val_19);
            val_34 = val_20.x;
            val_35 = val_20.z;
            this.cameraTransform.rotation = new UnityEngine.Quaternion() {x = val_34, y = val_20.y, z = val_35, w = val_20.w};
            return;
            label_16:
            if(this.cameraTransform != null)
            {
                goto label_31;
            }
            
            goto label_32;
            label_21:
            val_21 = this.CameraTarget;
            this.cameraTransform.LookAt(target:  val_21);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetPlayerInput()
        {
            float val_22;
            float val_23;
            UnityEngine.Object val_52;
            float val_56;
            float val_57;
            float val_58;
            float val_59;
            float val_60;
            float val_61;
            UnityEngine.Transform val_62;
            float val_65;
            val_52 = 0;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.moveVector = val_1;
            mem[1152921524657595236] = val_1.y;
            mem[1152921524657595240] = val_1.z;
            this.mouseWheel = UnityEngine.Input.GetAxis(axisName:  "Mouse ScrollWheel");
            int val_3 = UnityEngine.Input.touchCount;
            if((UnityEngine.Input.GetKey(key:  48)) == false)
            {
                goto label_3;
            }
            
            label_33:
            val_56 = 10f;
            val_57 = this.mouseWheel * val_56;
            this.mouseWheel = val_57;
            if((UnityEngine.Input.GetKeyDown(key:  105)) != false)
            {
                    this.CameraMode = 1;
            }
            
            if((UnityEngine.Input.GetKeyDown(key:  102)) != false)
            {
                    this.CameraMode = 0;
            }
            
            if((UnityEngine.Input.GetKeyDown(key:  115)) != false)
            {
                    bool val_50 = this.MovementSmoothing;
                val_50 = val_50 ^ 1;
                this.MovementSmoothing = val_50;
            }
            
            if((UnityEngine.Input.GetMouseButton(button:  1)) == false)
            {
                goto label_14;
            }
            
            this.mouseY = UnityEngine.Input.GetAxis(axisName:  "Mouse Y");
            val_56 = UnityEngine.Input.GetAxis(axisName:  "Mouse X");
            float val_51 = this.mouseY;
            this.mouseX = val_56;
            if(val_51 > 0.01f)
            {
                goto label_8;
            }
            
            val_58 = -0.01f;
            if(val_51 >= 0)
            {
                goto label_9;
            }
            
            label_8:
            val_59 = this.MaxElevationAngle;
            val_51 = val_51 * this.MoveSensitivity;
            float val_11 = this.ElevationAngle - val_51;
            this.ElevationAngle = val_11;
            val_60 = this.MinElevationAngle;
            val_58 = val_59;
            val_56 = this.mouseX;
            this.ElevationAngle = UnityEngine.Mathf.Clamp(value:  val_11, min:  val_60, max:  val_58);
            label_9:
            if(val_56 > 0.01f)
            {
                goto label_12;
            }
            
            val_57 = -0.01f;
            if(val_56 >= 0)
            {
                goto label_14;
            }
            
            label_12:
            val_61 = this.MoveSensitivity;
            val_57 = 360f;
            val_56 = val_56 * val_61;
            val_56 = this.OrbitalAngle + val_56;
            val_58 = val_56 + (-360f);
            val_56 = (val_56 > val_57) ? (val_58) : (val_56);
            this.OrbitalAngle = val_56;
            if(val_56 < 0)
            {
                    val_57 = val_56 + val_57;
                this.OrbitalAngle = val_57;
            }
            
            label_14:
            if(val_3 != 1)
            {
                goto label_23;
            }
            
            UnityEngine.Touch val_13 = UnityEngine.Input.GetTouch(index:  0);
            if(format != 1)
            {
                goto label_23;
            }
            
            UnityEngine.Touch val_15 = UnityEngine.Input.GetTouch(index:  0);
            UnityEngine.Vector2 val_16 = position;
            val_59 = val_16.x;
            if(val_16.y <= 0.01f)
            {
                    if(val_16.y >= 0)
            {
                goto label_18;
            }
            
            }
            
            float val_52 = -0.1f;
            val_52 = val_16.y * val_52;
            val_60 = this.ElevationAngle + val_52;
            this.ElevationAngle = val_60;
            val_56 = this.MinElevationAngle;
            val_58 = this.MaxElevationAngle;
            this.ElevationAngle = UnityEngine.Mathf.Clamp(value:  val_60, min:  val_56, max:  val_58);
            label_18:
            if(val_59 > 0.01f)
            {
                goto label_21;
            }
            
            val_57 = -0.01f;
            if(val_59 >= 0)
            {
                goto label_23;
            }
            
            label_21:
            float val_53 = 0.1f;
            float val_54 = this.OrbitalAngle;
            val_61 = -360f;
            val_57 = 360f;
            val_53 = val_59 * val_53;
            val_54 = val_53 + val_54;
            val_58 = val_54 + val_61;
            val_54 = (val_54 > val_57) ? (val_58) : (val_54);
            this.OrbitalAngle = val_54;
            if(val_54 < 0)
            {
                    val_57 = val_54 + val_57;
                this.OrbitalAngle = val_57;
            }
            
            label_23:
            if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
            {
                goto label_30;
            }
            
            val_62 = UnityEngine.Camera.main;
            UnityEngine.Vector3 val_20 = UnityEngine.Input.mousePosition;
            val_59 = val_20.x;
            val_60 = val_20.z;
            val_56 = val_20.y;
            val_58 = val_60;
            UnityEngine.Ray val_21 = val_62.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_59, y = val_56, z = val_58});
            val_57 = 300f;
            if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_23, y = val_23, z = val_23}, m_Direction = new UnityEngine.Vector3() {x = val_23, y = val_22, z = val_22}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  val_57, layerMask:  0)) == false)
            {
                goto label_30;
            }
            
            val_62 = this.CameraTarget;
            if(val_52 != val_62)
            {
                goto label_29;
            }
            
            this.OrbitalAngle = 0f;
            goto label_30;
            label_3:
            if(val_3 > 0)
            {
                goto label_33;
            }
            
            if((UnityEngine.Input.GetKey(key:  47)) == false)
            {
                goto label_34;
            }
            
            goto label_33;
            label_29:
            this.CameraTarget = val_52;
            this.OrbitalAngle = 0f;
            this.MovementSmoothing = this.previousSmoothing;
            label_30:
            if((UnityEngine.Input.GetMouseButton(button:  2)) == false)
            {
                goto label_34;
            }
            
            if(this.dummyTarget != 0)
            {
                goto label_37;
            }
            
            UnityEngine.Transform val_30 = new UnityEngine.GameObject(name:  "Camera Target").transform;
            this.dummyTarget = val_30;
            if(this.CameraTarget != null)
            {
                goto label_47;
            }
            
            label_48:
            label_47:
            UnityEngine.Vector3 val_31 = this.CameraTarget.position;
            val_30.position = new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z};
            UnityEngine.Quaternion val_32 = this.CameraTarget.rotation;
            val_65 = val_32.x;
            this.dummyTarget.rotation = new UnityEngine.Quaternion() {x = val_65, y = val_32.y, z = val_32.z, w = val_32.w};
            this.CameraTarget = this.dummyTarget;
            this.MovementSmoothing = false;
            this.previousSmoothing = this.MovementSmoothing;
            goto label_46;
            label_37:
            if(this.dummyTarget == this.CameraTarget)
            {
                goto label_46;
            }
            
            if(this.CameraTarget != null)
            {
                goto label_47;
            }
            
            goto label_48;
            label_46:
            this.mouseY = UnityEngine.Input.GetAxis(axisName:  "Mouse Y");
            float val_35 = UnityEngine.Input.GetAxis(axisName:  "Mouse X");
            this.mouseX = val_35;
            UnityEngine.Vector3 val_36 = this.cameraTransform.TransformDirection(x:  val_35, y:  this.mouseY, z:  0f);
            this.moveVector = val_36;
            mem[1152921524657595236] = val_36.y;
            mem[1152921524657595240] = val_36.z;
            val_62 = this.dummyTarget;
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z});
            val_59 = val_37.x;
            val_60 = val_37.z;
            val_52 = val_59;
            val_56 = val_37.y;
            val_62.Translate(translation:  new UnityEngine.Vector3() {x = val_52, y = val_56, z = val_60}, relativeTo:  0);
            label_34:
            if(val_3 == 2)
            {
                    UnityEngine.Touch val_38 = UnityEngine.Input.GetTouch(index:  0);
                UnityEngine.Touch val_39 = UnityEngine.Input.GetTouch(index:  1);
                UnityEngine.Vector2 val_40 = position;
                UnityEngine.Vector2 val_41 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_52, y = val_56}, b:  new UnityEngine.Vector2() {x = val_40.x, y = val_40.y});
                UnityEngine.Vector2 val_42 = position;
                UnityEngine.Vector2 val_43 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_41.x, y = val_41.y}, b:  new UnityEngine.Vector2() {x = val_42.x, y = val_42.y});
                UnityEngine.Vector2 val_44 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_41.x, y = val_41.y}, b:  new UnityEngine.Vector2() {x = val_43.x, y = val_43.y});
                val_59 = val_44.x;
                val_60 = val_44.y;
                UnityEngine.Vector2 val_45 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_44.x, y = val_60}, b:  new UnityEngine.Vector2() {x = val_44.x, y = val_44.y});
                val_45.x = val_59 - val_45.x;
                if(val_45.x <= 0.01f)
            {
                    if(val_45.x >= 0)
            {
                goto label_57;
            }
            
            }
            
                val_59 = this.MaxFollowDistance;
                val_45.x = val_45.x * 0.25f;
                float val_46 = val_45.x + this.FollowDistance;
                this.FollowDistance = val_46;
                val_60 = this.MinFollowDistance;
                this.FollowDistance = UnityEngine.Mathf.Clamp(value:  val_46, min:  val_60, max:  val_59);
            }
            
            label_57:
            float val_55 = this.mouseWheel;
            if(val_55 >= 0)
            {
                    if(val_55 <= 0.01f)
            {
                    return;
            }
            
            }
            
            val_59 = this.MaxFollowDistance;
            val_55 = val_55 * (-5f);
            float val_48 = this.FollowDistance + val_55;
            this.FollowDistance = val_48;
            val_60 = this.MinFollowDistance;
            this.FollowDistance = UnityEngine.Mathf.Clamp(value:  val_48, min:  val_60, max:  val_59);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CameraController()
        {
            this.MaxElevationAngle = 85f;
            this.MovementSmoothing = true;
            this.MovementSmoothingValue = 25f;
            this.RotationSmoothingValue = 5f;
            this.MoveSensitivity = 2f;
            this.FollowDistance = ;
            this.MaxFollowDistance = ;
            this.MinFollowDistance = 2f;
            this.ElevationAngle = 30f;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.currentVelocity = val_1;
            mem[1152921524657822052] = val_1.y;
            mem[1152921524657822056] = val_1.z;
        }
    
    }

}
