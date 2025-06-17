using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class InternalClipper.MyIntersectNodeSort : IComparer<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntersectNode>
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int Compare(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntersectNode node1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntersectNode node2)
    {
        var val_3;
        IntersectNode val_1 = node2 - X8;
        if(val_1 <= 0)
        {
                return (int)(val_1 != 0) ? -1 : 0;
        }
        
        val_3 = 1;
        return (int)(val_1 != 0) ? -1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public InternalClipper.MyIntersectNodeSort()
    {
    
    }

}
