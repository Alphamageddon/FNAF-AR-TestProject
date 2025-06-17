using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class DynamicGrid : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int xSize;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int zSize;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float cellSize;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool centerGrid;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool showGizmos;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool autoGenerate;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Vector3[] vertices;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Color[] colors;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Mesh mesh;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 GetVectorForIndex(int x, int z)
    {
        if((((x & 2147483648) != 0) || ((z & 2147483648) != 0)) || (this.xSize < x))
        {
                return UnityEngine.Vector3.zero;
        }
        
        if(this.zSize < z)
        {
                return UnityEngine.Vector3.zero;
        }
        
        var val_2 = 12;
        val_2 = this.vertices + (((long)this.xzIndex(x:  x, z:  z)) * val_2);
        return new UnityEngine.Vector3() {x = ((long)(int)(val_1) * 12) + this.vertices + 32, y = ((long)(int)(val_1) * 12) + this.vertices + 32 + 4, z = ((long)(int)(val_1) * 12) + this.vertices + 40};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetHeightForIndex(int x, int z, float height)
    {
        if((x & 2147483648) != 0)
        {
                return;
        }
        
        if((z & 2147483648) != 0)
        {
                return;
        }
        
        if(this.xSize < x)
        {
                return;
        }
        
        if(this.zSize < z)
        {
                return;
        }
        
        var val_2 = 12;
        val_2 = this.vertices + (((long)this.xzIndex(x:  x, z:  z)) * val_2);
        mem2[0] = height;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetColorForIndex(int x, int z, UnityEngine.Color color)
    {
        if((x & 2147483648) != 0)
        {
                return;
        }
        
        if((z & 2147483648) != 0)
        {
                return;
        }
        
        if(this.xSize < x)
        {
                return;
        }
        
        if(this.zSize < z)
        {
                return;
        }
        
        this.colors[(long)this.xzIndex(x:  x, z:  z)] = color;
        this.colors[(long)this.xzIndex(x:  x, z:  z)] = color.g;
        this.colors[(long)this.xzIndex(x:  x, z:  z)] = color.b;
        this.colors[(long)this.xzIndex(x:  x, z:  z)] = color.a;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void RefreshVertices()
    {
        this.mesh.vertices = this.vertices;
        this.mesh.colors = this.colors;
        this.mesh.RecalculateNormals();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        if(this.autoGenerate == false)
        {
                return;
        }
        
        this.Generate();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDrawGizmos()
    {
        var val_2;
        if(this.vertices == null)
        {
                return;
        }
        
        if(this.showGizmos == false)
        {
                return;
        }
        
        UnityEngine.Color val_1 = UnityEngine.Color.black;
        UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        val_2 = 0;
        goto label_2;
        label_6:
        float val_2 = this.cellSize;
        val_2 = val_2 * 0.1f;
        UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 8.96831E-44f, y = 0f, z = 1.85775E-36f}, radius:  val_2);
        val_2 = 1;
        label_2:
        if(val_2 < this.vertices.Length)
        {
            goto label_6;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int xzIndex(int x, int z)
    {
        int val_6 = UnityEngine.Mathf.Max(a:  0, b:  UnityEngine.Mathf.Min(a:  z, b:  this.zSize + 1));
        int val_7 = this.xSize;
        val_7 = val_7 + 1;
        val_6 = (UnityEngine.Mathf.Max(a:  0, b:  UnityEngine.Mathf.Min(a:  x, b:  this.xSize + 1))) + (val_7 * val_6);
        return (int)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Vector3 xzVertice(int x, int z)
    {
        float val_4 = this.cellSize;
        if(this.centerGrid != false)
        {
                float val_1 = (float)x;
            float val_2 = (float)z;
            val_1 = val_4 * val_1;
            float val_3 = (float)this.xSize;
            val_2 = val_4 * val_2;
            val_3 = val_4 * val_3;
            val_4 = val_4 * (float)this.zSize;
            float val_5 = 0.5f;
            val_3 = val_3 * val_5;
            val_4 = val_4 * val_5;
            val_3 = val_1 - val_3;
            val_5 = val_2 - val_4;
        }
        else
        {
                float val_6 = (float)x;
            float val_7 = (float)z;
            val_6 = val_4 * val_6;
            val_7 = val_4 * val_7;
        }
        
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Generate()
    {
        UnityEngine.Vector2[] val_17;
        int val_18;
        var val_19;
        UnityEngine.Vector4 val_20;
        UnityEngine.Color[] val_21;
        int val_22;
        UnityEngine.Mesh val_2 = new UnityEngine.Mesh();
        this.mesh = val_2;
        this.GetComponent<UnityEngine.MeshFilter>().mesh = val_2;
        this.mesh.name = "Procedural Grid";
        int val_26 = this.xSize;
        int val_27 = this.zSize;
        val_26 = val_26 + 1;
        val_27 = val_27 + 1;
        int val_3 = val_27 * val_26;
        this.vertices = new UnityEngine.Vector3[0];
        int val_28 = this.xSize;
        int val_29 = this.zSize;
        val_28 = val_28 + 1;
        val_29 = val_29 + 1;
        int val_5 = val_29 * val_28;
        this.colors = new UnityEngine.Color[0];
        UnityEngine.Vector2[] val_7 = new UnityEngine.Vector2[0];
        val_17 = val_7;
        UnityEngine.Vector4[] val_8 = new UnityEngine.Vector4[0];
        val_18 = this.zSize;
        if((val_18 & 2147483648) == 0)
        {
                do
        {
            if((this.xSize & 2147483648) == 0)
        {
                var val_33 = 0;
            do
        {
            UnityEngine.Vector3 val_10 = this.xzVertice(x:  0, z:  0);
            val_19 = (long)0 + val_33;
            var val_30 = 12;
            val_30 = this.vertices + (val_19 * val_30);
            mem2[0] = val_10.x;
            mem2[0] = val_10.y;
            mem2[0] = val_10.z;
            this.colors[val_19] = 0;
            this.colors[val_19] = 0;
            this.colors[val_19] = 0;
            this.colors[val_19] = 0;
            float val_31 = (float)this.xSize;
            float val_32 = (float)this.zSize;
            val_31 = 0f / val_31;
            val_32 = 0f / val_32;
            UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  val_31, y:  val_32);
            UnityEngine.Vector2[] val_12 = val_17 + (((long)(int)((0 + 0))) << 3);
            mem2[0] = val_11.x;
            mem2[0] = val_11.y;
            val_20 = 0;
            val_8[((long)(int)((0 + 0))) << 4] = 0;
            val_8[((long)(int)((0 + 0))) << 4] = val_20;
            val_8[((long)(int)((0 + 0))) << 4] = 0;
            val_8[((long)(int)((0 + 0))) << 4] = 0;
            val_33 = val_33 + 1;
        }
        while(val_33 <= this.xSize);
        
            var val_34 = 0;
            val_18 = this.zSize;
            val_17 = val_17;
            val_34 = val_34 + val_33;
        }
        
            var val_35 = 0;
            val_35 = val_35 + 1;
        }
        while(val_35 <= val_18);
        
        }
        
        this.mesh.vertices = this.vertices;
        val_21 = this.colors;
        this.mesh.colors = val_21;
        this.mesh.uv = val_7;
        this.mesh.tangents = val_8;
        int val_36 = this.xSize;
        val_36 = val_36 * this.zSize;
        val_36 = val_36 + (val_36 << 1);
        int val_13 = val_36 << 1;
        int[] val_14 = new int[0];
        val_22 = this.zSize;
        if(val_22 >= 1)
        {
                int val_37 = 0;
            do
        {
            val_37 = val_37 + 1;
            if(this.xSize >= 1)
        {
                do
        {
            val_20 = 0;
            val_14[0] = this.xzIndex(x:  0, z:  0);
            int val_16 = this.xzIndex(x:  0, z:  val_37);
            var val_38 = (long)val_20 + 4;
            val_14[((long)(int)((val_20 + 4))) << 2] = val_16;
            var val_18 = val_20 + 1;
            val_38 = val_38 - 3;
            val_21 = 0 + 1;
            val_14[((long)(int)((val_20 + 1))) << 2] = val_16;
            int val_19 = this.xzIndex(x:  val_21, z:  0);
            var val_20 = val_20 + 3;
            val_38 = val_38 + 2;
            val_14[((long)(int)((val_20 + 3))) << 2] = val_19;
            var val_21 = val_20 + 2;
            val_38 = val_38 - 1;
            val_14[((long)(int)((val_20 + 2))) << 2] = val_19;
            val_38 = val_38 + 3;
            val_19 = (long)val_20 + 5;
            val_14[((long)(int)((val_20 + 5))) << 2] = this.xzIndex(x:  val_21, z:  val_37);
            var val_24 = val_38 + 1;
        }
        while(val_21 < this.xSize);
        
            val_22 = this.zSize;
            var val_25 = val_20 + 6;
        }
        
        }
        while(val_37 < val_22);
        
        }
        
        this.mesh.triangles = val_14;
        this.mesh.RecalculateNormals();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DynamicGrid()
    {
        this.cellSize = 1f;
        this.centerGrid = true;
        this.autoGenerate = true;
    }

}
