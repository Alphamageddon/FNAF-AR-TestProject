using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class FCShadow : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Transform target;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float visibleDistanceSquared;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        UnityEngine.Vector3 val_2 = this.target.transform.position;
        UnityEngine.Vector3 val_4 = this.transform.position;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        float val_14 = this.visibleDistanceSquared;
        float val_7 = UnityEngine.Mathf.Clamp(value:  UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}), min:  0f, max:  val_14);
        val_7 = val_7 / this.visibleDistanceSquared;
        val_14 = 1f - val_7;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  val_14);
        this.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        UnityEngine.Vector3 val_12 = this.transform.position;
        this.transform.position = new UnityEngine.Vector3() {x = val_2.x, y = val_12.y, z = val_2.z};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FCShadow()
    {
    
    }

}
