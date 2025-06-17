using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class ScanRingsEffect : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float speed;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float maxSize;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.MeshRenderer mr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Material ScanMaterial;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float timer;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        UnityEngine.MeshRenderer val_2 = this.transform.GetComponent<UnityEngine.MeshRenderer>();
        this.mr = val_2;
        this.ScanMaterial = val_2.material;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.speed * val_1;
        val_1 = this.timer + val_1;
        this.timer = val_1;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  UnityEngine.Mathf.Lerp(a:  0f, b:  this.maxSize, t:  this.timer));
        this.transform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        UnityEngine.Color val_6 = this.ScanMaterial.color;
        float val_7 = UnityEngine.Mathf.Lerp(a:  1f, b:  0f, t:  this.timer);
        this.ScanMaterial.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        if(this.timer <= 1f)
        {
                return;
        }
        
        this.timer = 0f;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ScanRingsEffect()
    {
        this.speed = 1f;
        this.maxSize = 0f;
    }

}
