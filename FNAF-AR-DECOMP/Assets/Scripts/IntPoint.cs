using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public struct InternalClipper.IntPoint
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public long X;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public long Y;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public InternalClipper.IntPoint(long X, long Y)
    {
        mem[1152921519896147856] = X;
        mem[1152921519896147864] = Y;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public InternalClipper.IntPoint(double x, double y)
    {
        mem[1152921519896259856] = (long)x;
        mem[1152921519896259864] = (long)y;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public InternalClipper.IntPoint(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt)
    {
        mem[1152921519896371856] = pt.X;
        mem[1152921519896371864] = pt.Y;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool op_Equality(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint a, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint b)
    {
        a.X = ((a.X == b.X) ? 1 : 0) & ((a.Y == b.Y) ? 1 : 0);
        return (bool)a.X;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool op_Inequality(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint a, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint b)
    {
        a.X = ((a.Y != b.Y) ? 1 : 0) | ((a.X != b.X) ? 1 : 0);
        return (bool)a.X;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object obj)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
    
    }

}
