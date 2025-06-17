using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class CameraShakeClamp : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float val;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float shakeOffset;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float maxZRotation;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        UnityEngine.Vector3 val_2 = this.transform.eulerAngles;
        float val_3 = this.ClampAngle(angle:  val_2.z, min:  -45f, max:  45f);
        UnityEngine.Vector3 val_6 = this.transform.localPosition;
        float val_7 = (val_6.x > this.shakeOffset) ? this.shakeOffset : val_6.x;
        float val_8 = (val_7 < 0) ? (-this.shakeOffset) : (val_7);
        float val_9 = (val_6.y > this.shakeOffset) ? this.shakeOffset : val_6.y;
        float val_10 = (val_9 < 0) ? (-this.shakeOffset) : (val_9);
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.zero;
        UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_8, y:  val_10);
        float val_14 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, b:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
        float val_15 = (((val_3 < 0) ? (-val_3) : (val_3)) / this.maxZRotation) + 1f;
        float val_16 = UnityEngine.Mathf.Lerp(a:  0f, b:  1f, t:  val_14);
        this.val = val_16;
        this.transform.localPosition = new UnityEngine.Vector3() {x = val_8, y = val_10, z = 0f};
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, d:  UnityEngine.Mathf.Lerp(a:  0f, b:  val_14, t:  val_16));
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
        this.transform.localScale = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = 1f};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected float ClampAngle(float angle, float min, float max)
    {
        float val_3;
        float val_4;
        float val_5;
        var val_6;
        var val_7;
        var val_8;
        val_3 = max;
        val_4 = min;
        val_5 = angle;
        float val_3 = 360f;
        if(val_5 <= val_3)
        {
            goto label_3;
        }
        
        do
        {
            val_5 = val_5 + (-360f);
        }
        while(val_5 > val_3);
        
        goto label_3;
        label_4:
        val_5 = val_5 + val_3;
        label_3:
        if(val_5 < 0)
        {
            goto label_4;
        }
        
        if(val_5 > 180f)
        {
                val_6 = val_5 + (-360f);
        }
        else
        {
                val_5 = (val_5 < 0) ? (val_5 + val_3) : (val_5);
        }
        
        if(val_4 <= val_3)
        {
            goto label_9;
        }
        
        do
        {
            val_4 = val_4 + (-360f);
        }
        while(val_4 > val_3);
        
        goto label_9;
        label_10:
        val_4 = val_4 + val_3;
        label_9:
        if(val_4 < 0)
        {
            goto label_10;
        }
        
        if(val_4 > 180f)
        {
                val_7 = val_4 + (-360f);
        }
        else
        {
                val_4 = (val_4 < 0) ? (val_4 + val_3) : (val_4);
        }
        
        if(val_3 <= val_3)
        {
            goto label_15;
        }
        
        do
        {
            val_3 = val_3 + (-360f);
        }
        while(val_3 > val_3);
        
        goto label_15;
        label_16:
        val_3 = val_3 + val_3;
        label_15:
        if(val_3 < 0)
        {
            goto label_16;
        }
        
        if(val_3 > 180f)
        {
                val_8 = val_3 + (-360f);
            return UnityEngine.Mathf.Clamp(value:  val_5, min:  val_4, max:  val_3 = (val_3 < 0) ? (val_3) : (val_3));
        }
        
        val_3 = val_3 + val_3;
        return UnityEngine.Mathf.Clamp(value:  val_5, min:  val_4, max:  val_3);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected float NormalizeAngle(float angle)
    {
        float val_1;
        if(angle <= 360f)
        {
            goto label_2;
        }
        
        do
        {
            val_1 = angle + (-360f);
        }
        while(val_1 > 360f);
        
        goto label_2;
        label_3:
        val_1 = val_1 + 360f;
        label_2:
        if(val_1 < 0)
        {
            goto label_3;
        }
        
        return val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CameraShakeClamp()
    {
        this.shakeOffset = 0.3f;
        this.maxZRotation = 45f;
    }

}
