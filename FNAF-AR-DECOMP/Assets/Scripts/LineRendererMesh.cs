using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class LightningBolt.LineRendererMesh
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject <GameObject>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <Tag>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Action<DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo> <CustomTransform>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Transform <Transform>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const int defaultListCapacity = 2048;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly UnityEngine.Vector2 uv1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly UnityEngine.Vector2 uv2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly UnityEngine.Vector2 uv3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly UnityEngine.Vector2 uv4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly System.Collections.Generic.List<int> indices;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly System.Collections.Generic.List<UnityEngine.Vector3> vertices;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly System.Collections.Generic.List<UnityEngine.Vector4> lineDirs;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly System.Collections.Generic.List<UnityEngine.Color32> colors;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly System.Collections.Generic.List<UnityEngine.Vector3> ends;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly System.Collections.Generic.List<UnityEngine.Vector4> texCoordsAndGlowModifiers;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly System.Collections.Generic.List<UnityEngine.Vector4> fadeLifetimes;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const int boundsPadder = 1000000000;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int currentBoundsMinX;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int currentBoundsMinY;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int currentBoundsMinZ;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int currentBoundsMaxX;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int currentBoundsMaxY;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int currentBoundsMaxZ;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Mesh mesh;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.MeshFilter meshFilter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.MeshRenderer meshRenderer;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject GameObject { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Material Material { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.MeshRenderer MeshRenderer { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int Tag { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo> CustomTransform { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Transform Transform { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Empty { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject get_GameObject()
    {
        return (UnityEngine.GameObject)this.<GameObject>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void set_GameObject(UnityEngine.GameObject value)
    {
        this.<GameObject>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Material get_Material()
    {
        if(this.meshRenderer != null)
        {
                return this.meshRenderer.sharedMaterial;
        }
        
        return this.meshRenderer.sharedMaterial;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Material(UnityEngine.Material value)
    {
        this.meshRenderer.sharedMaterial = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.MeshRenderer get_MeshRenderer()
    {
        return (UnityEngine.MeshRenderer)this.meshRenderer;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_Tag()
    {
        return (int)this.<Tag>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Tag(int value)
    {
        this.<Tag>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo> get_CustomTransform()
    {
        return (System.Action<DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo>)this.<CustomTransform>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CustomTransform(System.Action<DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo> value)
    {
        this.<CustomTransform>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Transform get_Transform()
    {
        return (UnityEngine.Transform)this.<Transform>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void set_Transform(UnityEngine.Transform value)
    {
        this.<Transform>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_Empty()
    {
        return (bool)(this.vertices.Count == 0) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public LightningBolt.LineRendererMesh()
    {
        this.indices = new System.Collections.Generic.List<System.Int32>(capacity:  2048);
        this.vertices = new System.Collections.Generic.List<UnityEngine.Vector3>(capacity:  2048);
        this.lineDirs = new System.Collections.Generic.List<UnityEngine.Vector4>(capacity:  2048);
        this.colors = new System.Collections.Generic.List<UnityEngine.Color32>(capacity:  2048);
        this.ends = new System.Collections.Generic.List<UnityEngine.Vector3>(capacity:  2048);
        this.texCoordsAndGlowModifiers = new System.Collections.Generic.List<UnityEngine.Vector4>(capacity:  2048);
        this.fadeLifetimes = new System.Collections.Generic.List<UnityEngine.Vector4>(capacity:  2048);
        this.currentBoundsMinX = ;
        this.currentBoundsMinY = ;
        this.currentBoundsMinZ = 13518339334002259455;
        this.currentBoundsMaxX = 3147483648;
        this.currentBoundsMaxY = -1147483648;
        this.currentBoundsMaxZ = 51712;
        UnityEngine.GameObject val_8 = new UnityEngine.GameObject(name:  "LightningBoltMeshRenderer");
        this.<GameObject>k__BackingField = val_8;
        val_8.SetActive(value:  false);
        UnityEngine.Mesh val_9 = new UnityEngine.Mesh();
        val_9.name = "ProceduralLightningMesh";
        this.mesh = val_9;
        val_9.MarkDynamic();
        UnityEngine.MeshFilter val_10 = this.<GameObject>k__BackingField.AddComponent<UnityEngine.MeshFilter>();
        this.meshFilter = val_10;
        val_10.sharedMesh = this.mesh;
        UnityEngine.MeshRenderer val_11 = this.<GameObject>k__BackingField.AddComponent<UnityEngine.MeshRenderer>();
        this.meshRenderer = val_11;
        val_11.shadowCastingMode = 0;
        this.meshRenderer.reflectionProbeUsage = 0;
        this.meshRenderer.lightProbeUsage = 0;
        this.meshRenderer.receiveShadows = false;
        this.<Transform>k__BackingField = this.<GameObject>k__BackingField.GetComponent<UnityEngine.Transform>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void PopulateMesh()
    {
        if(this.vertices.Count != 0)
        {
                this.PopulateMeshInternal();
            return;
        }
        
        this.mesh.Clear();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool PrepareForLines(int lineCount)
    {
        int val_4 = lineCount;
        val_4 = val_4 << 2;
        return (bool)((this.vertices.Count + val_4) < 65000) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void BeginLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, float radius, UnityEngine.Color32 color, float colorIntensity, UnityEngine.Vector4 fadeLifeTime, float glowWidthModifier, float glowIntensity)
    {
        float val_1;
        float val_2;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z}, b:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z});
        UnityEngine.Vector4 val_4 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        this.AppendLineInternal(start: ref  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z}, end: ref  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z}, dir: ref  new UnityEngine.Vector4() {x = val_4.x, y = val_4.y, z = val_4.z, w = radius}, dirPrev1: ref  new UnityEngine.Vector4() {x = val_4.x, y = val_4.y, z = val_4.z, w = radius}, dirPrev2: ref  new UnityEngine.Vector4() {x = val_4.x, y = val_4.y, z = val_4.z, w = radius}, color:  new UnityEngine.Color32() {r = color.r & 4294967295, g = color.r & 4294967295, b = color.r & 4294967295, a = color.r & 4294967295}, colorIntensity:  colorIntensity, fadeLifeTime: ref  new UnityEngine.Vector4() {x = fadeLifeTime.x, y = val_2, z = fadeLifeTime.y, w = val_1}, glowWidthModifier:  fadeLifeTime.z, glowIntensity:  fadeLifeTime.w);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void AppendLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, float radius, UnityEngine.Color32 color, float colorIntensity, UnityEngine.Vector4 fadeLifeTime, float glowWidthModifier, float glowIntensity)
    {
        float val_1;
        float val_2;
        var val_14;
        var val_15;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z}, b:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z});
        UnityEngine.Vector4 val_4 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        if(this.lineDirs != null)
        {
                val_14 = this.lineDirs.Count;
        }
        else
        {
                val_14 = 0.Count;
        }
        
        UnityEngine.Vector4 val_8 = this.lineDirs.Item[val_14 - 3];
        if(this.lineDirs != null)
        {
                val_15 = this.lineDirs.Count;
        }
        else
        {
                val_15 = 0.Count;
        }
        
        UnityEngine.Vector4 val_12 = this.lineDirs.Item[val_15 - 1];
        this.AppendLineInternal(start: ref  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z}, end: ref  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z}, dir: ref  new UnityEngine.Vector4() {x = val_4.x, y = val_4.y, z = val_4.z, w = radius}, dirPrev1: ref  new UnityEngine.Vector4() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w}, dirPrev2: ref  new UnityEngine.Vector4() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w}, color:  new UnityEngine.Color32() {r = color.r & 4294967295, g = color.r & 4294967295, b = color.r & 4294967295, a = color.r & 4294967295}, colorIntensity:  colorIntensity, fadeLifeTime: ref  new UnityEngine.Vector4() {x = fadeLifeTime.x, y = val_2, z = fadeLifeTime.y, w = val_1}, glowWidthModifier:  fadeLifeTime.z, glowIntensity:  fadeLifeTime.w);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Reset()
    {
        int val_1 = this.<Tag>k__BackingField;
        this.<CustomTransform>k__BackingField = 0;
        val_1 = val_1 + 1;
        this.<Tag>k__BackingField = val_1;
        this.<GameObject>k__BackingField.SetActive(value:  false);
        this.mesh.Clear();
        this.indices.Clear();
        this.vertices.Clear();
        this.colors.Clear();
        this.lineDirs.Clear();
        this.ends.Clear();
        this.texCoordsAndGlowModifiers.Clear();
        this.fadeLifetimes.Clear();
        this.currentBoundsMaxY = -1147483648;
        this.currentBoundsMaxZ = 51712;
        this.currentBoundsMinX = ;
        this.currentBoundsMinY = ;
        this.currentBoundsMinZ = 13518339334002259455;
        this.currentBoundsMaxX = 3147483648;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void PopulateMeshInternal()
    {
        this.<GameObject>k__BackingField.SetActive(value:  true);
        this.mesh.SetVertices(inVertices:  this.vertices);
        this.mesh.SetTangents(inTangents:  this.lineDirs);
        this.mesh.SetColors(inColors:  this.colors);
        this.mesh.SetUVs(channel:  0, uvs:  this.texCoordsAndGlowModifiers);
        this.mesh.SetUVs(channel:  1, uvs:  this.fadeLifetimes);
        this.mesh.SetNormals(inNormals:  this.ends);
        this.mesh.SetTriangles(triangles:  this.indices, submesh:  0);
        int val_5 = this.currentBoundsMinX;
        int val_6 = this.currentBoundsMinY;
        int val_7 = this.currentBoundsMinZ;
        val_5 = val_5 - 2;
        val_6 = val_6 - 2;
        val_7 = val_7 - 2;
        int val_8 = this.currentBoundsMaxX;
        int val_9 = this.currentBoundsMaxY;
        int val_10 = this.currentBoundsMaxZ;
        val_8 = val_8 + 2;
        val_9 = val_9 + 2;
        val_10 = val_10 + 2;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  0.5f);
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  1.2f);
        this.mesh.bounds = new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Extents = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void UpdateBounds(ref UnityEngine.Vector3 point1, ref UnityEngine.Vector3 point2)
    {
        int val_7 = this.currentBoundsMaxX;
        int val_6 = this.currentBoundsMinX;
        int val_5 = (int)point1.x;
        int val_4 = (int)point2.x;
        float val_1 = val_5 - val_4;
        val_1 = val_1 & (val_1 >> 31);
        val_4 = val_1 + val_4;
        val_5 = val_1 - val_5;
        val_6 = val_6 - val_4;
        val_5 = val_5 + val_7;
        val_6 = val_6 & (val_6 >> 31);
        val_5 = val_5 & (val_5 >> 31);
        val_4 = val_6 + val_4;
        val_7 = val_7 - val_5;
        this.currentBoundsMinX = val_4;
        this.currentBoundsMaxX = val_7;
        int val_9 = (int)point1.y;
        int val_8 = (int)point2.y;
        float val_2 = val_9 - val_8;
        val_2 = val_2 & (val_2 >> 31);
        val_8 = val_2 + val_8;
        val_9 = val_2 - val_9;
        val_2 = this.currentBoundsMinY - val_8;
        val_2 = val_2 & (val_2 >> 31);
        val_8 = val_2 + val_8;
        this.currentBoundsMinY = val_8;
        val_9 = val_9 + this.currentBoundsMaxY;
        val_9 = val_9 & (val_9 >> 31);
        val_9 = this.currentBoundsMaxY - val_9;
        this.currentBoundsMaxY = val_9;
        int val_12 = this.currentBoundsMinZ;
        int val_11 = (int)point1.z;
        int val_10 = (int)point2.z;
        float val_3 = val_11 - val_10;
        val_3 = val_3 & (val_3 >> 31);
        val_10 = val_3 + val_10;
        val_11 = val_3 - val_11;
        val_12 = val_12 - val_10;
        val_11 = val_11 + this.currentBoundsMaxZ;
        val_12 = val_12 & (val_12 >> 31);
        val_11 = val_11 & (val_11 >> 31);
        val_12 = val_12 + val_10;
        val_11 = this.currentBoundsMaxZ - val_11;
        this.currentBoundsMinZ = val_12;
        this.currentBoundsMaxZ = val_11;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void AddIndices()
    {
        int val_4 = this.vertices.Count;
        int val_2 = val_4 + 1;
        this.indices.Add(item:  val_4);
        int val_3 = val_4 + 2;
        this.indices.Add(item:  val_2);
        this.indices.Add(item:  val_3);
        this.indices.Add(item:  val_3);
        this.indices.Add(item:  val_2);
        val_4 = val_4 + 3;
        this.indices.Add(item:  val_4);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void AppendLineInternal(ref UnityEngine.Vector3 start, ref UnityEngine.Vector3 end, ref UnityEngine.Vector4 dir, ref UnityEngine.Vector4 dirPrev1, ref UnityEngine.Vector4 dirPrev2, UnityEngine.Color32 color, float colorIntensity, ref UnityEngine.Vector4 fadeLifeTime, float glowWidthModifier, float glowIntensity)
    {
        var val_8;
        byte val_9 = color.r;
        this.AddIndices();
        val_8 = null;
        val_8 = null;
        int val_8 = (int)UnityEngine.Mathf.Lerp(a:  0f, b:  255f, t:  colorIntensity * 0.1f);
        this.vertices.Add(item:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z});
        this.lineDirs.Add(item:  new UnityEngine.Vector4() {x = dirPrev1.x, y = dirPrev1.y, z = dirPrev1.z, w = dirPrev1.w});
        val_8 = val_8 << 24;
        val_9 = val_8 | (val_9 & 16777215);
        this.colors.Add(item:  new UnityEngine.Color32() {r = val_9, g = val_9, b = val_9, a = val_9});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = dir.x, y = dir.y, z = dir.z, w = dir.w});
        this.ends.Add(item:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        this.vertices.Add(item:  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z});
        this.lineDirs.Add(item:  new UnityEngine.Vector4() {x = dir.x, y = dir.y, z = dir.z, w = dir.w});
        this.colors.Add(item:  new UnityEngine.Color32() {r = val_9, g = val_9, b = val_9, a = val_9});
        UnityEngine.Vector3 val_5 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = dir.x, y = dir.y, z = dir.z, w = dir.w});
        this.ends.Add(item:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        dir.w = -dir.w;
        this.vertices.Add(item:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z});
        this.lineDirs.Add(item:  new UnityEngine.Vector4() {x = dirPrev2.x, y = dirPrev2.x + 4, z = dirPrev2.x + 8, w = dirPrev2.x + 8 + 4});
        this.colors.Add(item:  new UnityEngine.Color32() {r = val_9, g = val_9, b = val_9, a = val_9});
        UnityEngine.Vector3 val_6 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = dir.x, y = dir.y, z = dir.z, w = dir.w});
        this.ends.Add(item:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        this.vertices.Add(item:  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z});
        this.lineDirs.Add(item:  new UnityEngine.Vector4() {x = dir.x, y = dir.y, z = dir.z, w = dir.w});
        this.colors.Add(item:  new UnityEngine.Color32() {r = val_9, g = val_9, b = val_9, a = val_9});
        UnityEngine.Vector3 val_7 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = dir.x, y = dir.y, z = dir.z, w = dir.w});
        this.ends.Add(item:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        this.texCoordsAndGlowModifiers.Add(item:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.texCoordsAndGlowModifiers.Add(item:  new UnityEngine.Vector4() {x = LightningBolt.LineRendererMesh.uv2, y = LightningBolt.LineRendererMesh.boundsPadder.__il2cppRuntimeField_C, z = 0f, w = 0f});
        this.texCoordsAndGlowModifiers.Add(item:  new UnityEngine.Vector4() {x = LightningBolt.LineRendererMesh.uv3, y = LightningBolt.LineRendererMesh.boundsPadder.__il2cppRuntimeField_14, z = 0f, w = 0f});
        this.texCoordsAndGlowModifiers.Add(item:  new UnityEngine.Vector4() {x = LightningBolt.LineRendererMesh.uv4, y = LightningBolt.LineRendererMesh.boundsPadder.__il2cppRuntimeField_1C, z = 0f, w = 0f});
        this.fadeLifetimes.Add(item:  new UnityEngine.Vector4() {x = fadeLifeTime.x, y = fadeLifeTime.y, z = fadeLifeTime.z, w = fadeLifeTime.w});
        this.fadeLifetimes.Add(item:  new UnityEngine.Vector4() {x = fadeLifeTime.x, y = fadeLifeTime.y, z = fadeLifeTime.z, w = fadeLifeTime.w});
        this.fadeLifetimes.Add(item:  new UnityEngine.Vector4() {x = fadeLifeTime.x, y = fadeLifeTime.y, z = fadeLifeTime.z, w = fadeLifeTime.w});
        this.fadeLifetimes.Add(item:  new UnityEngine.Vector4() {x = fadeLifeTime.x, y = fadeLifeTime.y, z = fadeLifeTime.z, w = fadeLifeTime.w});
        this.UpdateBounds(point1: ref  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z}, point2: ref  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static LightningBolt.LineRendererMesh()
    {
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  0f, y:  0f);
        LightningBolt.LineRendererMesh.boundsPadder = val_1.x;
        LightningBolt.LineRendererMesh.boundsPadder.__il2cppRuntimeField_4 = val_1.y;
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  1f, y:  0f);
        LightningBolt.LineRendererMesh.uv2 = val_2.x;
        LightningBolt.LineRendererMesh.boundsPadder.__il2cppRuntimeField_C = val_2.y;
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  0f, y:  1f);
        UnityEngine.Vector2 val_4;
        LightningBolt.LineRendererMesh.uv3 = val_3.x;
        LightningBolt.LineRendererMesh.boundsPadder.__il2cppRuntimeField_14 = val_3.y;
        val_4 = new UnityEngine.Vector2(x:  1f, y:  1f);
        LightningBolt.LineRendererMesh.uv4 = val_4.x;
        LightningBolt.LineRendererMesh.boundsPadder.__il2cppRuntimeField_1C = val_4.y;
    }

}
