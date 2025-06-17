using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class WSCube : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.MeshRenderer meshRenderer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.MaterialPropertyBlock propertyBlock;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float moveSpeed;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 maximumMovement;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float minimumPosition;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float maximumPosition;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float minimumHeight;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float maximumHeight;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        UnityEngine.MaterialPropertyBlock val_1 = new UnityEngine.MaterialPropertyBlock();
        this.propertyBlock = val_1;
        this.meshRenderer.GetPropertyBlock(properties:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetLeftColor(UnityEngine.Color color)
    {
        this.propertyBlock.SetColor(name:  "_Light0Color", value:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a});
        this.meshRenderer.SetPropertyBlock(properties:  this.propertyBlock);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetRightColor(UnityEngine.Color color)
    {
        this.propertyBlock.SetColor(name:  "_Light1Color", value:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a});
        this.meshRenderer.SetPropertyBlock(properties:  this.propertyBlock);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetPosition01(float minimumPosition01)
    {
        UnityEngine.Vector3 val_2 = this.transform.position;
        this.transform.position = new UnityEngine.Vector3() {x = UnityEngine.Mathf.Lerp(a:  this.minimumPosition, b:  this.maximumPosition, t:  minimumPosition01), y = val_2.y, z = val_2.z};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetHeight01(float height)
    {
        UnityEngine.Vector3 val_2 = this.transform.localScale;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = UnityEngine.Mathf.Lerp(a:  this.minimumHeight, b:  this.maximumHeight, t:  height), z = val_2.z};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WSCube()
    {
    
    }

}
