using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class CreateRenderTexture : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Material mat;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Camera cam;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.MeshRenderer mr;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        UnityEngine.Camera val_2 = this.transform.GetComponent<UnityEngine.Camera>();
        this.cam = val_2;
        float val_7 = val_2.fieldOfView;
        float val_6 = 0.01745329f;
        float val_5 = 0.5f;
        val_5 = val_7 * val_5;
        val_6 = val_5 * val_6;
        val_7 = val_6 * 26f;
        float val_4 = this.cam.aspect;
        val_4 = val_7 * val_4;
        this.CreateQuad(width:  val_4, height:  val_7, distance:  13f);
        this.SetupCameraRenderTexture();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SetupCameraRenderTexture()
    {
        this.cam = this.transform.GetComponent<UnityEngine.Camera>();
        int val_3 = UnityEngine.Screen.width;
        int val_4 = UnityEngine.Screen.height;
        UnityEngine.RenderTexture val_9 = new UnityEngine.RenderTexture(width:  ((val_3 < 0) ? (val_3 + 1) : (val_3)) >> 1, height:  ((val_4 < 0) ? (val_4 + 1) : (val_4)) >> 1, depth:  24);
        this.cam.targetTexture = val_9;
        UnityEngine.RenderTexture.active = val_9;
        this.mr.material.mainTexture = val_9;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void CreateQuad(float width, float height, float distance)
    {
        int val_34;
        float val_35 = height;
        float val_34 = width;
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject();
        val_1.transform.parent = this.transform.parent;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        val_1.transform.localEulerAngles = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  1.1f);
        val_1.transform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        int val_10 = UnityEngine.LayerMask.NameToLayer(layerName:  "Foreground");
        if(val_1 != null)
        {
                val_1.layer = val_10;
        }
        else
        {
                val_1.layer = val_10;
        }
        
        val_1.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        if(val_1 != null)
        {
                val_1.name = "Camera_Background_RenderTexture";
        }
        else
        {
                0.name = "Camera_Background_RenderTexture";
        }
        
        this.mr = val_1.AddComponent<UnityEngine.MeshRenderer>();
        this.mr.material = this.mat;
        this.mr.material.renderQueue = 9998;
        UnityEngine.Mesh val_15 = new UnityEngine.Mesh();
        val_1.AddComponent<UnityEngine.MeshFilter>().mesh = val_15;
        UnityEngine.Vector3[] val_16 = new UnityEngine.Vector3[4];
        float val_17 = val_34 * (-0.5f);
        float val_18 = val_35 * (-0.5f);
        val_34 = val_34 * 0.5f;
        val_16[0] = 0;
        val_16[0] = 0;
        val_16[1] = 0;
        val_35 = val_35 * 0.5f;
        val_16[1] = 0;
        val_16[2] = 0;
        val_16[2] = 0;
        val_16[3] = 0;
        val_16[3] = 0;
        val_16[4] = 0;
        val_16[4] = 0;
        val_16[5] = 0;
        val_16[5] = 0;
        val_15.vertices = val_16;
        int[] val_19 = new int[6];
        val_34 = val_19.Length;
        if(val_34 == 0)
        {
                val_34 = val_19.Length;
        }
        
        val_19[0] = 0;
        if(val_34 <= 1)
        {
                val_34 = val_19.Length;
        }
        
        val_19[0] = 2;
        if(val_34 <= 2)
        {
                val_34 = val_19.Length;
        }
        
        val_19[1] = 1;
        if(val_34 <= 3)
        {
                val_34 = val_19.Length;
        }
        
        val_19[1] = 2;
        if(val_34 <= 4)
        {
                val_34 = val_19.Length;
        }
        
        val_19[2] = 3;
        val_19[2] = 1;
        val_15.triangles = val_19;
        UnityEngine.Vector3[] val_20 = new UnityEngine.Vector3[4];
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
        val_20[0] = val_22;
        val_20[0] = val_22.y;
        val_20[1] = val_22.z;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
        val_20[1] = val_24;
        val_20[2] = val_24.y;
        val_20[2] = val_24.z;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
        val_20[3] = val_26;
        val_20[3] = val_26.y;
        val_20[4] = val_26.z;
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
        val_20[4] = val_28;
        val_20[5] = val_28.y;
        val_20[5] = val_28.z;
        val_15.normals = val_20;
        UnityEngine.Vector2[] val_29 = new UnityEngine.Vector2[4];
        UnityEngine.Vector2 val_30 = new UnityEngine.Vector2(x:  0f, y:  0f);
        val_29[0] = val_30.x;
        val_29[0] = val_30.y;
        UnityEngine.Vector2 val_31 = new UnityEngine.Vector2(x:  1f, y:  0f);
        val_29[1] = val_31.x;
        val_29[1] = val_31.y;
        UnityEngine.Vector2 val_32 = new UnityEngine.Vector2(x:  0f, y:  1f);
        UnityEngine.Vector2 val_33;
        val_29[2] = val_32.x;
        val_29[2] = val_32.y;
        val_33 = new UnityEngine.Vector2(x:  1f, y:  1f);
        val_29[3] = val_33.x;
        val_29[3] = val_33.y;
        val_15.uv = val_29;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CreateRenderTexture()
    {
    
    }

}
