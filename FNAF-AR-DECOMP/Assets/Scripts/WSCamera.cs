using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class WSCamera : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Transform target;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Camera camera;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector2 angleSpread;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Quaternion defaultRotation;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        UnityEngine.Quaternion val_1 = this.target.rotation;
        this.defaultRotation = val_1;
        mem[1152921519067500596] = val_1.y;
        mem[1152921519067500600] = val_1.z;
        mem[1152921519067500604] = val_1.w;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
        float val_12 = (float)UnityEngine.Screen.width;
        float val_13 = (float)UnityEngine.Screen.height;
        val_12 = val_1.x / val_12;
        val_13 = val_1.y / val_13;
        float val_4 = UnityEngine.Mathf.Lerp(a:  -this.angleSpread, b:  this.angleSpread, t:  0f);
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.up;
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.AngleAxis(angle:  val_4, axis:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.right;
        UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.AngleAxis(angle:  UnityEngine.Mathf.Lerp(a:  val_4, b:  -val_4, t:  0f), axis:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = this.defaultRotation, y = val_9.y, z = val_9.z, w = val_8.y}, rhs:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w});
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w}, rhs:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w});
        this.target.rotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WSCamera()
    {
    
    }

}
