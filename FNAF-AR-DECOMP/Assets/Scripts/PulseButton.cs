using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class PulseButton : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float offset;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float speed;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float min;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float max;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        float val_1 = UnityEngine.Time.time;
        val_1 = this.speed * val_1;
        val_1 = this.offset + val_1;
        float val_8 = UnityEngine.Mathf.PingPong(t:  val_1, length:  this.max - this.min);
        val_8 = this.min + val_8;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  val_8);
        this.transform.GetComponent<UnityEngine.RectTransform>().localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PulseButton()
    {
        this.speed = 1f;
        this.max = 1f;
    }

}
