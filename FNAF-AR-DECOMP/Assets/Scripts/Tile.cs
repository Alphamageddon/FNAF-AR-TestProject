using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class SupportedPlane.Tile
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector2 center;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector2Int discretizedKey;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int count;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int _tileSize;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3[] vertices;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SupportedPlane.Tile(int tileSize)
    {
        this.vertices = new UnityEngine.Vector3[4];
        this._tileSize = tileSize;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool isFilled()
    {
        int val_2 = this._tileSize;
        val_2 = val_2 * val_2;
        return (bool)(this.count == val_2) ? 1 : 0;
    }

}
