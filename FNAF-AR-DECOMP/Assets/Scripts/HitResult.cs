using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class DynamicOcclusion.HitResult
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 point;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 normal;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float distance;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Collider2D collider2D;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Collider collider3D;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool hasCollider { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DynamicOcclusion.HitResult(UnityEngine.RaycastHit hit3D)
    {
        this.point = new UnityEngine.Vector3();
        mem[1152921528916180564] = ???;
        mem[1152921528916180568] = ???;
        this.normal = new UnityEngine.Vector3();
        mem[1152921528916180576] = ???;
        mem[1152921528916180580] = ???;
        this.distance = hit3D.m_Point.x.targetValue;
        this.collider2D = 0;
        this.collider3D = 1152921528916212544;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DynamicOcclusion.HitResult(UnityEngine.RaycastHit2D hit2D)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B});
        this.point = val_1;
        mem[1152921528916300740] = val_1.y;
        mem[1152921528916300744] = val_1.z;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
        this.normal = val_2;
        mem[1152921528916300752] = val_2.y;
        mem[1152921528916300756] = val_2.z;
        this.distance = hit2D.m_Centroid.x.startValue;
        this.collider2D = 1152921528916332720;
        this.collider3D = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DynamicOcclusion.HitResult()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.point = val_1;
        mem[1152921528916416820] = val_1.y;
        mem[1152921528916416824] = val_1.z;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.normal = val_2;
        mem[1152921528916416832] = val_2.y;
        mem[1152921528916416836] = val_2.z;
        this.distance = 0f;
        this.collider2D = 0;
        this.collider3D = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_hasCollider()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.collider2D)) == false)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.collider3D);
        }
        
        return true;
    }

}
