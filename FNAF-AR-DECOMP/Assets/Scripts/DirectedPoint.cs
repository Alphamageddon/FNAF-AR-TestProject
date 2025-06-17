using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class DirectedPoint : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.LineRenderer lineRenderer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float scale;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Vector3[] endpoints;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Initialize(UnityEngine.Vector3 point, UnityEngine.Vector3 direction)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = direction.x, y = direction.y, z = direction.z}, d:  this.scale);
        this.endpoints = new UnityEngine.Vector3[3];
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = direction.x, y = direction.y, z = direction.z}, rhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  2f);
        this.endpoints[0] = val_5;
        this.endpoints[0] = val_5.y;
        this.endpoints[0] = val_5.z;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        this.endpoints[1] = val_6;
        this.endpoints[1] = val_6.y;
        this.endpoints[1] = val_6.z;
        this.endpoints[2] = val_1;
        this.endpoints[2] = val_1.y;
        this.endpoints[2] = val_1.z;
        if(this.endpoints == null)
        {
            goto label_9;
        }
        
        label_13:
        this.lineRenderer.positionCount = this.endpoints.Length;
        this.lineRenderer.SetPositions(positions:  this.endpoints);
        return;
        label_9:
        if(this.lineRenderer != null)
        {
            goto label_13;
        }
        
        goto label_13;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void UpdateDirection(UnityEngine.Vector3 direction)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = direction.x, y = direction.y, z = direction.z}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  2f);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = direction.x, y = direction.y, z = direction.z}, d:  this.scale);
        this.endpoints[0] = val_3;
        this.endpoints[0] = val_3.y;
        this.endpoints[0] = val_3.z;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        this.endpoints[1] = val_5;
        this.endpoints[1] = val_5.y;
        this.endpoints[1] = val_5.z;
        this.endpoints[2] = val_4;
        this.endpoints[2] = val_4.y;
        this.endpoints[2] = val_4.z;
        if(this.endpoints == null)
        {
            goto label_9;
        }
        
        label_13:
        this.lineRenderer.positionCount = this.endpoints.Length;
        this.lineRenderer.SetPositions(positions:  this.endpoints);
        return;
        label_9:
        if(this.lineRenderer != null)
        {
            goto label_13;
        }
        
        goto label_13;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Clear()
    {
        this.lineRenderer.positionCount = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DirectedPoint()
    {
        this.scale = 5f;
    }

}
