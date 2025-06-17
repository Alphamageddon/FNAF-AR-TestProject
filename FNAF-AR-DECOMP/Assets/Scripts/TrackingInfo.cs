using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private class Octree.TrackingInfo : ISpatialToken
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal StagPoint.SpatialDatabase.Octree tree;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal StagPoint.SpatialDatabase.Octree.Node node;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal object item;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal UnityEngine.Bounds bounds;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Bounds Bounds { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Bounds get_Bounds()
    {
        UnityEngine.Bounds val_0;
        val_0.m_Extents.y = ;
        val_0.m_Center.x = this.bounds;
        return val_0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Remove()
    {
        this.node.RemoveItem(item:  this);
        this.node = 0;
        this.item = 0;
        this.tree = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Update(UnityEngine.Bounds newBounds)
    {
        if(this.node != null)
        {
                if((UnityEngine.Bounds.op_Equality(lhs:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = this.bounds, y = this.bounds, z = this.bounds}, m_Extents = new UnityEngine.Vector3() {x = this.bounds, y = this.node, z = this.node}}, rhs:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = newBounds.m_Center.x}, m_Extents = new UnityEngine.Vector3() {y = newBounds.m_Extents.y}})) == true)
        {
                return;
        }
        
            mem2[0] = newBounds.m_Extents.y;
            mem2[0] = newBounds.m_Center.x;
            if(this.node.childNodes == null)
        {
                if((StagPoint.SpatialDatabase.IntersectionTests.GetIntersectionType(lhs: ref  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = this.node.bounds, y = this.node.bounds, z = this.node.bounds}, m_Extents = new UnityEngine.Vector3() {x = this.node.bounds, y = this.node.bounds, z = this.node.bounds}}, rhs: ref  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = this.bounds, y = this.bounds, z = this.bounds}, m_Extents = new UnityEngine.Vector3() {x = this.bounds, y = this.bounds, z = this.bounds}})) == 2)
        {
                return;
        }
        
        }
        
            this.node.RemoveItem(item:  this);
            this.tree.root.AddItem(item:  this, canAutoSplit:  true);
            return;
        }
        
        System.Exception val_3 = new System.Exception(message:  "Attempted to update the spatial tracking for an object that is not being tracked");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Octree.TrackingInfo()
    {
    
    }

}
