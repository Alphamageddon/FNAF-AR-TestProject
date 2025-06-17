using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class InternalClipper.PolyTree : InternalClipper.PolyNode
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyNode> m_AllPolys;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int Total { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Clear()
    {
        goto label_2;
        label_4:
        X22.set_Item(index:  0, value:  0);
        0 = 1;
        label_2:
        if(0 < this.m_AllPolys.Count)
        {
            goto label_4;
        }
        
        this.m_AllPolys.Clear();
        this.Clear();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyNode GetFirst()
    {
        var val_3;
        var val_4;
        val_3 = this;
        if(Count >= 1)
        {
                PolyNode val_2 = this.Item[0];
            return (PolyNode)val_4;
        }
        
        val_4 = 0;
        return (PolyNode)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_Total()
    {
        var val_5;
        var val_6;
        val_5 = this;
        int val_1 = this.m_AllPolys.Count;
        if(val_1 >= 1)
        {
                val_5 = X21.Item[0];
            val_6 = val_1 - ((val_5 != this.m_AllPolys.Item[0]) ? 1 : 0);
            return (int)val_6;
        }
        
        val_6 = val_1;
        return (int)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public InternalClipper.PolyTree()
    {
        this.m_AllPolys = new System.Collections.Generic.List<PolyNode>();
    }

}
