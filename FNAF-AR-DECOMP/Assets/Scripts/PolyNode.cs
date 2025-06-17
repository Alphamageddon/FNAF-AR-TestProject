using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class InternalClipper.PolyNode
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyNode m_Parent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint> m_polygon;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal int m_Index;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.JoinType m_jointype;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.EndType m_endtype;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyNode> m_Childs;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool <IsOpen>k__BackingField;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int ChildCount { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint> Contour { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyNode> Childs { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyNode Parent { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsHole { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsOpen { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool IsHoleNode()
    {
        do
        {
        
        }
        while(this.m_Parent != null);
        
        return true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_ChildCount()
    {
        if(this.m_Childs != null)
        {
                return this.m_Childs.Count;
        }
        
        return this.m_Childs.Count;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint> get_Contour()
    {
        return (System.Collections.Generic.List<IntPoint>)this.m_polygon;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void AddChild(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyNode Child)
    {
        this.m_Childs.Add(item:  Child);
        if(Child != null)
        {
                Child.m_Parent = this;
        }
        else
        {
                mem[16] = this;
        }
        
        Child.m_Index = this.m_Childs.Count;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyNode GetNext()
    {
        if(this.m_Childs.Count < 1)
        {
                return this.GetNextSiblingUp();
        }
        
        if(this.m_Childs != null)
        {
                return this.m_Childs.Item[0];
        }
        
        return this.m_Childs.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyNode GetNextSiblingUp()
    {
        System.Collections.Generic.List<PolyNode> val_5;
        var val_6;
        val_5 = 38079;
        label_4:
        if(this.m_Parent == null)
        {
            goto label_1;
        }
        
        if(this.m_Index == (this.m_Parent.m_Childs.Count - 1))
        {
            goto label_4;
        }
        
        val_5 = this.m_Parent.m_Childs;
        PolyNode val_4 = val_5.Item[this.m_Index + 1];
        return (PolyNode)val_6;
        label_1:
        val_6 = 0;
        return (PolyNode)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyNode> get_Childs()
    {
        return (System.Collections.Generic.List<PolyNode>)this.m_Childs;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyNode get_Parent()
    {
        return (PolyNode)this.m_Parent;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_IsHole()
    {
        do
        {
        
        }
        while(this.m_Parent != null);
        
        return true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_IsOpen()
    {
        return (bool)this.<IsOpen>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_IsOpen(bool value)
    {
        this.<IsOpen>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public InternalClipper.PolyNode()
    {
        this.m_polygon = new System.Collections.Generic.List<IntPoint>();
        this.m_Childs = new System.Collections.Generic.List<PolyNode>();
    }

}
