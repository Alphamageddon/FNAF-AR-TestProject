using UnityEngine;

namespace VLB_Samples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FreeCameraController : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float cameraSensitivity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float speedNormal;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float speedFactorSlow;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float speedFactorFast;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float speedClimb;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float rotationH;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float rotationV;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool m_UseMouseView;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool useMouseView { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool get_useMouseView()
        {
            return (bool)this.m_UseMouseView;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_useMouseView(bool value)
        {
            bool val_1 = value;
            this.m_UseMouseView = val_1;
            UnityEngine.Cursor.lockState = val_1;
            UnityEngine.Cursor.visible = (~value) & 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.m_UseMouseView = true;
            UnityEngine.Cursor.lockState = 1;
            UnityEngine.Cursor.visible = false;
            UnityEngine.Quaternion val_2 = this.transform.rotation;
            float val_3 = -360f;
            val_3 = val_2.x + val_3;
            val_2.x = (val_2.x > 180f) ? (val_3) : val_2.x;
            this.rotationH = val_2.y;
            this.rotationV = val_2.x;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            var val_61;
            float val_62;
            float val_63;
            float val_64;
            float val_65;
            float val_66;
            float val_67;
            float val_68;
            float val_69;
            float val_70;
            float val_71;
            if(this.m_UseMouseView != false)
            {
                    float val_2 = UnityEngine.Time.deltaTime;
                val_2 = ((UnityEngine.Input.GetAxis(axisName:  "Mouse X")) * this.cameraSensitivity) * val_2;
                val_2 = this.rotationH + val_2;
                val_61 = this;
                this.rotationH = val_2;
                float val_5 = UnityEngine.Time.deltaTime;
                val_5 = ((UnityEngine.Input.GetAxis(axisName:  "Mouse Y")) * this.cameraSensitivity) * val_5;
                val_62 = this.rotationV - val_5;
                this.rotationV = val_62;
            }
            else
            {
                    val_61 = this;
                val_62 = this.rotationV;
            }
            
            this.rotationV = UnityEngine.Mathf.Clamp(value:  val_62, min:  -90f, max:  90f);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.up;
            UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.AngleAxis(angle:  this.rotationH, axis:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            this.transform.rotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w};
            UnityEngine.Transform val_11 = this.transform;
            UnityEngine.Quaternion val_12 = val_11.rotation;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.right;
            UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.AngleAxis(angle:  this.rotationV, axis:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            UnityEngine.Quaternion val_15 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w}, rhs:  new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w});
            val_63 = val_15.x;
            val_11.rotation = new UnityEngine.Quaternion() {x = val_63, y = val_15.y, z = val_15.z, w = val_15.w};
            val_64 = this.speedNormal;
            if((UnityEngine.Input.GetKey(key:  48)) != true)
            {
                    if((UnityEngine.Input.GetKey(key:  47)) == false)
            {
                goto label_13;
            }
            
            }
            
            val_65 = this.speedFactorFast;
            goto label_14;
            label_13:
            if((UnityEngine.Input.GetKey(key:  50)) != true)
            {
                    if((UnityEngine.Input.GetKey(key:  49)) == false)
            {
                goto label_16;
            }
            
            }
            
            val_65 = this.speedFactorSlow;
            label_14:
            val_63 = mem[this.speedFactorSlow];
            val_63 = val_65;
            val_64 = val_64 * val_63;
            label_16:
            UnityEngine.Transform val_20 = this.transform;
            UnityEngine.Vector3 val_21 = val_20.position;
            UnityEngine.Vector3 val_23 = this.transform.forward;
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, d:  val_64);
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, d:  UnityEngine.Input.GetAxis(axisName:  "Vertical"));
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, d:  UnityEngine.Time.deltaTime);
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
            val_20.position = new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z};
            UnityEngine.Transform val_30 = this.transform;
            UnityEngine.Vector3 val_31 = val_30.position;
            UnityEngine.Vector3 val_33 = this.transform.right;
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, d:  val_64);
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, d:  UnityEngine.Input.GetAxis(axisName:  "Horizontal"));
            val_66 = val_36.y;
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_36.x, y = val_66, z = val_36.z}, d:  UnityEngine.Time.deltaTime);
            UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, b:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z});
            val_67 = val_39.x;
            val_68 = val_39.z;
            val_69 = val_67;
            val_70 = val_39.y;
            val_71 = val_68;
            val_30.position = new UnityEngine.Vector3() {x = val_69, y = val_70, z = val_71};
            if((UnityEngine.Input.GetKey(key:  113)) != false)
            {
                    UnityEngine.Transform val_41 = this.transform;
                UnityEngine.Vector3 val_42 = val_41.position;
                UnityEngine.Vector3 val_43 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_44 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z}, d:  this.speedClimb);
                val_66 = val_44.y;
                UnityEngine.Vector3 val_46 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_44.x, y = val_66, z = val_44.z}, d:  UnityEngine.Time.deltaTime);
                UnityEngine.Vector3 val_47 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z}, b:  new UnityEngine.Vector3() {x = val_46.x, y = val_46.y, z = val_46.z});
                val_67 = val_47.x;
                val_68 = val_47.z;
                val_69 = val_67;
                val_70 = val_47.y;
                val_71 = val_68;
                val_41.position = new UnityEngine.Vector3() {x = val_69, y = val_70, z = val_71};
            }
            
            if((UnityEngine.Input.GetKey(key:  101)) != false)
            {
                    UnityEngine.Transform val_49 = this.transform;
                UnityEngine.Vector3 val_50 = val_49.position;
                UnityEngine.Vector3 val_51 = UnityEngine.Vector3.down;
                UnityEngine.Vector3 val_52 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_51.z}, d:  this.speedClimb);
                val_66 = val_52.y;
                UnityEngine.Vector3 val_54 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_52.x, y = val_66, z = val_52.z}, d:  UnityEngine.Time.deltaTime);
                UnityEngine.Vector3 val_55 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_50.x, y = val_50.y, z = val_50.z}, b:  new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z});
                val_67 = val_55.x;
                val_68 = val_55.z;
                val_49.position = new UnityEngine.Vector3() {x = val_67, y = val_55.y, z = val_68};
            }
            
            if((UnityEngine.Input.GetMouseButtonDown(button:  0)) != true)
            {
                    if((UnityEngine.Input.GetMouseButtonDown(button:  1)) != true)
            {
                    if((UnityEngine.Input.GetMouseButtonDown(button:  2)) == false)
            {
                goto label_37;
            }
            
            }
            
            }
            
            bool val_59 = (this.m_UseMouseView == false) ? 1 : 0;
            this.m_UseMouseView = val_59;
            UnityEngine.Cursor.lockState = val_59;
            UnityEngine.Cursor.visible = this.m_UseMouseView;
            label_37:
            if((UnityEngine.Input.GetKeyDown(key:  27)) == false)
            {
                    return;
            }
            
            this.m_UseMouseView = false;
            UnityEngine.Cursor.lockState = 0;
            UnityEngine.Cursor.visible = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FreeCameraController()
        {
            this.speedClimb = 4f;
            this.cameraSensitivity = ;
            this.speedNormal = ;
            this.speedFactorSlow = 0.25f;
            this.speedFactorFast = 3f;
            this.m_UseMouseView = true;
        }
    
    }

}
