using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class OctreeTester : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject testObjectPrefab;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Bounds octreeBounds;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int octreeMaxObjectsPerNode;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float newObjectEveryNSeconds;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int maxObjects;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private StagPoint.SpatialDatabase.Octree octree;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float lastNewObjectTime;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int numObjects;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        StagPoint.SpatialDatabase.Octree val_1 = null;
        val_1 = new StagPoint.SpatialDatabase.Octree(bounds:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = this.octreeBounds, y = this.octreeBounds, z = this.octreeBounds}, m_Extents = new UnityEngine.Vector3() {x = this.octreeBounds, y = 1.401298E-45f, z = 0f}}, maxItemsPerNode:  this.octreeMaxObjectsPerNode);
        this.octree = val_1;
        this.lastNewObjectTime = UnityEngine.Time.time;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        float val_16;
        float val_17;
        if(this.numObjects >= this.maxObjects)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.time;
        float val_20 = this.lastNewObjectTime;
        val_20 = val_20 + this.newObjectEveryNSeconds;
        if(val_1 < val_20)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.testObjectPrefab);
        val_2.transform.SetParent(p:  this.transform);
        float val_6 = val_1 - val_1;
        float val_7 = val_1 + val_1;
        float val_8 = UnityEngine.Random.Range(min:  val_6, max:  val_7);
        val_7 = val_7 + val_7;
        float val_10 = UnityEngine.Random.Range(min:  val_7 - val_7, max:  val_7);
        float val_13 = UnityEngine.Random.Range(min:  val_6 - val_6, max:  val_6 + val_6);
        val_2.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Bounds val_15 = val_2.GetComponent<UnityEngine.Renderer>().bounds;
        StagPoint.SpatialDatabase.ISpatialToken val_18 = this.octree.AddItem(item:  val_2, bounds:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = val_17, y = val_17, z = val_17}, m_Extents = new UnityEngine.Vector3() {x = val_17, y = val_16, z = val_16}});
        int val_21 = this.numObjects;
        val_21 = val_21 + 1;
        this.numObjects = val_21;
        this.lastNewObjectTime = UnityEngine.Time.time;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public OctreeTester()
    {
        this.octreeMaxObjectsPerNode = 10;
        this.newObjectEveryNSeconds = 1f;
        this.maxObjects = 1000;
    }

}
