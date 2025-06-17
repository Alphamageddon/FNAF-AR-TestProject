using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class BeamRotate : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float Speed;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.RectTransform rTransform;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Vector3 uiRotation;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this.rTransform = this.transform.GetComponent<UnityEngine.RectTransform>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.back;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  this.Speed * UnityEngine.Time.deltaTime);
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.uiRotation, y = V8.16B, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        this.uiRotation = val_5;
        mem[1152921518894386716] = val_5.y;
        mem[1152921518894386720] = val_5.z;
        this.rTransform.eulerAngles = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public BeamRotate()
    {
        this.Speed = 1f;
    }

}
