using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class IllumixObjectVisualizer : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject tilePrefab;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject meshPrefab;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject directedPointPrefab;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject planePrefab;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject supportedPlanePrefab;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.Dictionary<UnityEngine.Vector3, UnityEngine.GameObject> tileObjects;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.Dictionary<UnityEngine.Vector3, UnityEngine.GameObject> tileAnnotations;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.Dictionary<UnityEngine.Vector3, UnityEngine.GameObject> meshObjects;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.Dictionary<UnityEngine.Vector3, UnityEngine.GameObject> directPointObjects;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.Dictionary<int, UnityEngine.GameObject> horizontalPlaneObjects;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.Dictionary<int, UnityEngine.GameObject> VerticalPlaneObjects;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool isVisible;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IllumixObjectVisualizer_SROptions debugOptions;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool hideMesh;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool showTileIds;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void AddTile(IllumixTile tile)
    {
        UnityEngine.GameObject val_1 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.tilePrefab);
        if(val_1 != null)
        {
                val_1.SetActive(value:  (this.isVisible == true) ? 1 : 0);
        }
        else
        {
                val_1.SetActive(value:  (this.isVisible == true) ? 1 : 0);
        }
        
        val_1.GetComponent<SimpleConvexMesh>().InitializeMesh(orderedConvexVertices:  tile.vertices);
        this.tileObjects.set_Item(key:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, value:  val_1);
        if(this.showTileIds == false)
        {
                return;
        }
        
        this.AddTileId(tile:  tile);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void AddTileId(IllumixTile tile)
    {
        var val_20;
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject();
        val_1.transform.position = new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B};
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        val_1.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        UnityEngine.GameObject val_5 = new UnityEngine.GameObject();
        if(val_5 != null)
        {
                val_20 = val_5.AddComponent<UnityEngine.TextMesh>();
        }
        else
        {
                val_20 = val_5.AddComponent<UnityEngine.TextMesh>();
        }
        
        UnityEngine.MeshRenderer val_8 = val_5.AddComponent<UnityEngine.MeshRenderer>();
        UnityEngine.Vector3 val_20 = tile.vertices[0];
        val_20 = val_20 - tile.vertices[1];
        float val_23 = System.Math.Abs(val_20);
        UnityEngine.Vector3 val_24 = tile.vertices[1];
        val_24 = tile.vertices[0] - val_24;
        float val_25 = System.Math.Abs(val_24);
        val_25 = val_25 * 0.5f;
        val_23 = val_23 + val_25;
        if(val_20 != null)
        {
                val_20.anchor = 4;
            val_20.fontSize = 64;
        }
        else
        {
                val_20.anchor = 4;
            val_20.fontSize = 64;
        }
        
        val_20.characterSize = val_23;
        val_20.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        if(val_20 != null)
        {
                val_20.alignment = 1;
            val_20.anchor = 4;
        }
        else
        {
                val_20.alignment = 1;
            val_20.anchor = 4;
        }
        
        val_20.text = tile.vertices;
        val_5.transform.parent = val_1.transform;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  5f);
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  64f);
        val_5.transform.localScale = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
        val_5.transform.localPosition = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, d:  90f);
        val_5.transform.localEulerAngles = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
        this.tileAnnotations.set_Item(key:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, value:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void RemoveTileId(UnityEngine.Vector3 center)
    {
        var val_20;
        var val_21;
        UnityEngine.GameObject val_1 = this.tileAnnotations.Item[new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}];
        if(val_1 != null)
        {
                val_1.SetActive(value:  false);
        }
        else
        {
                val_1.SetActive(value:  false);
        }
        
        System.Collections.IEnumerator val_3 = val_1.transform.GetEnumerator();
        goto label_26;
        label_33:
        var val_20 = 0;
        val_20 = val_20 + 1;
        object val_5 = val_3.Current;
        0.gameObject.SetActive(value:  false);
        if((0.gameObject.GetComponent<UnityEngine.TextMesh>().Equals(other:  0)) != true)
        {
                0.gameObject.GetComponent<UnityEngine.TextMesh>().text = "";
            UnityEngine.Object.Destroy(obj:  0.gameObject.GetComponent<UnityEngine.TextMesh>());
        }
        
        label_26:
        var val_21 = 0;
        val_21 = val_21 + 1;
        if(val_3.MoveNext() == true)
        {
            goto label_33;
        }
        
        val_20 = 0;
        val_21 = 141;
        if(val_3 != null)
        {
                var val_22 = 0;
            val_22 = val_22 + 1;
            val_3.Dispose();
        }
        
        UnityEngine.Object.Destroy(obj:  val_1);
        bool val_19 = this.tileAnnotations.Remove(key:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void RemoveTile(UnityEngine.Vector3 center)
    {
        if((this.tileObjects.ContainsKey(key:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z})) == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = this.tileObjects.Item[new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}];
        val_2.SetActive(value:  false);
        UnityEngine.Object.Destroy(obj:  val_2);
        bool val_3 = this.tileObjects.Remove(key:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
        if(this.showTileIds == false)
        {
                return;
        }
        
        this.RemoveTileId(center:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void UpdateTile(IllumixTile oldTile, IllumixTile newTile)
    {
        this.AddTile(tile:  newTile);
        this.RemoveTile(center:  new UnityEngine.Vector3());
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void AddMeshBlock(IllumixMeshBlock meshBlock)
    {
        UnityEngine.Object val_10;
        if(this.hideMesh != false)
        {
                return;
        }
        
        if((this.meshObjects.ContainsKey(key:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B})) == false)
        {
            goto label_4;
        }
        
        val_10 = this.meshObjects.Item[new UnityEngine.Vector3() {x = V10.16B, y = V9.16B, z = V8.16B}];
        SimpleMesh val_3 = val_10.GetComponent<SimpleMesh>();
        if(meshBlock.triangles.Length == 0)
        {
            goto label_8;
        }
        
        val_3.UpdateMesh(vertices:  meshBlock.vertices, triangles:  meshBlock.triangles);
        goto label_10;
        label_4:
        this.meshObjects.set_Item(key:  new UnityEngine.Vector3() {x = V10.16B, y = V9.16B, z = V8.16B}, value:  UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.meshPrefab));
        val_10 = this.meshObjects.Item[new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}];
        val_10.GetComponent<SimpleMesh>().InitializeMesh(vertices:  meshBlock.vertices, triangles:  meshBlock.triangles);
        label_10:
        val_10.SetActive(value:  (this.isVisible == true) ? 1 : 0);
        return;
        label_8:
        val_3.ClearMesh();
        bool val_8 = this.meshObjects.Remove(key:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B});
        UnityEngine.Object.Destroy(obj:  val_10);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void AddDirectedPoint(IllumixDirectedPoint dp)
    {
        object val_1 = UnityEngine.Object.Instantiate<System.Object>(original:  this.directedPointPrefab);
        val_1.transform.position = new UnityEngine.Vector3() {x = dp.position, y = V9.16B, z = V10.16B};
        val_1.GetComponent<DirectedPoint>().Initialize(point:  new UnityEngine.Vector3() {x = dp.position, y = V12.16B, z = V11.16B}, direction:  new UnityEngine.Vector3() {x = dp.direction, y = V9.16B, z = dp.position});
        this.directPointObjects.set_Item(key:  new UnityEngine.Vector3() {x = dp.position, y = V9.16B, z = dp.direction}, value:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void UpdateDirectedPoint(IllumixDirectedPoint old_dp, IllumixDirectedPoint new_dp)
    {
        this.directPointObjects.Item[new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}].transform.position = new UnityEngine.Vector3() {x = new_dp.position, y = V9.16B, z = V10.16B};
        this.directPointObjects.Item[new UnityEngine.Vector3() {x = new_dp.position, y = V9.16B, z = V10.16B}].GetComponent<DirectedPoint>().UpdateDirection(direction:  new UnityEngine.Vector3() {x = new_dp.direction, y = V9.16B, z = V10.16B});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void RemoveDirectedPoint(IllumixDirectedPoint dp)
    {
        UnityEngine.GameObject val_1 = this.directPointObjects.Item[new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}];
        if(val_1 != null)
        {
                val_1.SetActive(value:  false);
        }
        else
        {
                val_1.SetActive(value:  false);
        }
        
        val_1.GetComponent<DirectedPoint>().Clear();
        bool val_3 = this.directPointObjects.Remove(key:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B});
        UnityEngine.Object.Destroy(obj:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void ToggleVisibility()
    {
        var val_4;
        var val_15 = this;
        bool val_15 = this.isVisible;
        val_15 = val_15 ^ 1;
        this.isVisible = val_15;
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.tileObjects.Values.GetEnumerator();
        label_5:
        if((1452451072 & 1) == 0)
        {
            goto label_3;
        }
        
        val_4.emailUIDataHandler.SetActive(value:  (this.isVisible == true) ? 1 : 0);
        goto label_5;
        label_3:
        long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921518944199936});
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_10 = this.meshObjects.Values.GetEnumerator();
        label_14:
        if((1452451072 & 1) == 0)
        {
            goto label_12;
        }
        
        val_4.emailUIDataHandler.SetActive(value:  (this.isVisible == true) ? 1 : 0);
        goto label_14;
        label_12:
        long val_13 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921518944199936});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void ClearObjects()
    {
        var val_3;
        var val_16;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = this.tileObjects.Keys.GetEnumerator();
        label_10:
        if((1452647008 & 1) == 0)
        {
            goto label_3;
        }
        
        UnityEngine.Vector3 val_5 = val_3.position;
        UnityEngine.GameObject val_6 = this.tileObjects.Item[new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}];
        val_6.GetComponent<SimpleConvexMesh>().ClearMesh();
        val_6.SetActive(value:  false);
        this.RemoveTileId(center:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        UnityEngine.Object.Destroy(obj:  val_6);
        goto label_10;
        label_3:
        long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921518944395872});
        val_16 = 0;
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_11 = this.meshObjects.Values.GetEnumerator();
        label_27:
        if((1452646976 & 1) == 0)
        {
            goto label_21;
        }
        
        GameUI.EmailUIDataHandler val_12 = val_3.emailUIDataHandler;
        val_12.GetComponent<SimpleMesh>().ClearMesh();
        val_12.SetActive(value:  false);
        UnityEngine.Object.Destroy(obj:  val_12);
        goto label_27;
        label_21:
        long val_14 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921518944395840});
        this.tileObjects.Clear();
        this.meshObjects.Clear();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        .iov = this;
        this.debugOptions = new IllumixObjectVisualizer_SROptions();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this.tileObjects = new System.Collections.Generic.Dictionary<UnityEngine.Vector3, UnityEngine.GameObject>();
        this.meshObjects = new System.Collections.Generic.Dictionary<UnityEngine.Vector3, UnityEngine.GameObject>();
        this.tileAnnotations = new System.Collections.Generic.Dictionary<UnityEngine.Vector3, UnityEngine.GameObject>();
        this.directPointObjects = new System.Collections.Generic.Dictionary<UnityEngine.Vector3, UnityEngine.GameObject>();
        this.isVisible = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnEnable()
    {
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        if(val_1 != null)
        {
                var val_3 = 0;
            val_3 = val_3 + 1;
            val_1.AddOptionContainer(container:  this.debugOptions);
        }
        
        mem[1152921518944904080] = this;
        mem[1152921518944904088] = System.Void IllumixObjectVisualizer::AddMeshBlock(IllumixMeshBlock meshBlock);
        mem[1152921518944904064] = System.Void IllumixObjectVisualizer::AddMeshBlock(IllumixMeshBlock meshBlock);
        IllumixSurfaceManager.add_SurfaceMeshBlockUpdatedEvent(value:  new IllumixSurfaceManager.SurfaceMeshBlockUpdate());
        mem[1152921518944908176] = this;
        mem[1152921518944908184] = public System.Void IllumixObjectVisualizer::AddDirectedPoint(IllumixDirectedPoint dp);
        mem[1152921518944908160] = public System.Void IllumixObjectVisualizer::AddDirectedPoint(IllumixDirectedPoint dp);
        IllumixSurfaceManager.add_SurfaceDirectedPointAddedEvent(value:  new IllumixSurfaceManager.DirectedPointAdd());
        mem[1152921518944912272] = this;
        mem[1152921518944912280] = public System.Void IllumixObjectVisualizer::UpdateDirectedPoint(IllumixDirectedPoint old_dp, IllumixDirectedPoint new_dp);
        mem[1152921518944912256] = public System.Void IllumixObjectVisualizer::UpdateDirectedPoint(IllumixDirectedPoint old_dp, IllumixDirectedPoint new_dp);
        IllumixSurfaceManager.add_SurfaceDirectedPointUpdatedEvent(value:  new IllumixSurfaceManager.DirectedPointUpdate());
        mem[1152921518944916368] = this;
        mem[1152921518944916376] = public System.Void IllumixObjectVisualizer::RemoveDirectedPoint(IllumixDirectedPoint dp);
        mem[1152921518944916352] = public System.Void IllumixObjectVisualizer::RemoveDirectedPoint(IllumixDirectedPoint dp);
        IllumixSurfaceManager.add_SurfaceDirectedPointRemovedEvent(value:  new IllumixSurfaceManager.DirectedPointRemove());
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDisable()
    {
        mem[1152921518945057056] = this;
        mem[1152921518945057064] = public System.Void IllumixObjectVisualizer::RemoveDirectedPoint(IllumixDirectedPoint dp);
        mem[1152921518945057040] = public System.Void IllumixObjectVisualizer::RemoveDirectedPoint(IllumixDirectedPoint dp);
        IllumixSurfaceManager.remove_SurfaceDirectedPointRemovedEvent(value:  new IllumixSurfaceManager.DirectedPointRemove());
        mem[1152921518945061152] = this;
        mem[1152921518945061160] = public System.Void IllumixObjectVisualizer::UpdateDirectedPoint(IllumixDirectedPoint old_dp, IllumixDirectedPoint new_dp);
        mem[1152921518945061136] = public System.Void IllumixObjectVisualizer::UpdateDirectedPoint(IllumixDirectedPoint old_dp, IllumixDirectedPoint new_dp);
        IllumixSurfaceManager.remove_SurfaceDirectedPointUpdatedEvent(value:  new IllumixSurfaceManager.DirectedPointUpdate());
        mem[1152921518945065248] = this;
        mem[1152921518945065256] = public System.Void IllumixObjectVisualizer::AddDirectedPoint(IllumixDirectedPoint dp);
        mem[1152921518945065232] = public System.Void IllumixObjectVisualizer::AddDirectedPoint(IllumixDirectedPoint dp);
        IllumixSurfaceManager.remove_SurfaceDirectedPointAddedEvent(value:  new IllumixSurfaceManager.DirectedPointAdd());
        mem[1152921518945069344] = this;
        mem[1152921518945069352] = System.Void IllumixObjectVisualizer::AddMeshBlock(IllumixMeshBlock meshBlock);
        mem[1152921518945069328] = System.Void IllumixObjectVisualizer::AddMeshBlock(IllumixMeshBlock meshBlock);
        IllumixSurfaceManager.remove_SurfaceMeshBlockUpdatedEvent(value:  new IllumixSurfaceManager.SurfaceMeshBlockUpdate());
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        if(val_1 == null)
        {
                return;
        }
        
        var val_3 = 0;
        val_3 = val_3 + 1;
        val_1.RemoveOptionContainer(container:  this.debugOptions);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IllumixObjectVisualizer()
    {
    
    }

}
