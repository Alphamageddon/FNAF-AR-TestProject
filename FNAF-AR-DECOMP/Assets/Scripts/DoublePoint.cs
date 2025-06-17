using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public struct InternalClipper.DoublePoint
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double X;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Y;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public InternalClipper.DoublePoint(double x = 0, double y = 0)
    {
        mem[1152921519892096144] = x;
        mem[1152921519892096152] = y;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public InternalClipper.DoublePoint(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.DoublePoint dp)
    {
        mem[1152921519892208144] = dp.X;
        mem[1152921519892208152] = dp.Y;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public InternalClipper.DoublePoint(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint ip)
    {
        mem[1152921519892320144] = (double)ip.X;
        mem[1152921519892320152] = (double)ip.Y;
    }

}
