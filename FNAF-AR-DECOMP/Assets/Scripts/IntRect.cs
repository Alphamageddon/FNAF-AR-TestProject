using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public struct InternalClipper.IntRect
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public long left;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public long top;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public long right;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public long bottom;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public InternalClipper.IntRect(long l, long t, long r, long b)
    {
        this.right = l;
        this.bottom = t;
        mem[1152921519896940064] = r;
        mem[1152921519896940072] = b;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public InternalClipper.IntRect(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntRect ir)
    {
        this.right = ir.left;
        this.bottom = ir.top;
        mem[1152921519897056112] = ir.right;
        mem[1152921519897056120] = ir.bottom;
    }

}
