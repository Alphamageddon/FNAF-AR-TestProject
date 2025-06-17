using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkEnvironmentPortal : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MAX_ENVIRONMENTS_PER_PORTAL = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 axis;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkEnvironment[] environments;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float GetAuxSendValueForPosition(UnityEngine.Vector3 in_position, int index)
    {
        UnityEngine.Vector3 val_2 = this.GetComponent<UnityEngine.BoxCollider>().size;
        UnityEngine.Vector3 val_4 = this.transform.lossyScale;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Scale(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        float val_6 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, rhs:  new UnityEngine.Vector3() {x = this.axis, y = val_4.y, z = val_4.z});
        UnityEngine.Quaternion val_8 = this.transform.rotation;
        UnityEngine.Vector3 val_9 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w}, point:  new UnityEngine.Vector3() {x = this.axis, y = val_4.z, z = val_4.y});
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.Normalize(value:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        UnityEngine.Vector3 val_12 = this.transform.position;
        float val_19 = 0.5f;
        val_19 = val_6 * val_19;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(d:  val_19, a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = in_position.x, y = in_position.y, z = in_position.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        float val_16 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, rhs:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        val_15.y = val_16 * val_16;
        val_16 = val_6 - val_16;
        val_16 = val_16 * val_16;
        float val_17 = (index == 0) ? (val_16) : (val_15.y);
        val_17 = val_17 / (val_6 * val_6);
        return (float)val_17;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkEnvironmentPortal()
    {
        this.axis = 0;
        mem[1152921519434827936] = 0;
        this.environments = new AkEnvironment[2];
    }

}
