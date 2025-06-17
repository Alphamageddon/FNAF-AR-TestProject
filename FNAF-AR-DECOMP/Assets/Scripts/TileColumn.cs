using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private class TSDFMinusPlanesManager.TileColumn
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector2 xzCenter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector2 minCoords;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector2 maxCoords;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.Dictionary<float, SharedTechAssets.Scripts.TSDFMinusPlanes.TSDFMinusPlanesManager.Tile> tiles;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TSDFMinusPlanesManager.TileColumn(UnityEngine.Vector2 center)
    {
        var val_4;
        this.xzCenter = center;
        mem[1152921523040587380] = center.y;
        this.tiles = new System.Collections.Generic.Dictionary<System.Single, Tile>();
        val_4 = null;
        val_4 = null;
        float val_5 = TSDFMinusPlanesManager.Tile.resolution;
        float val_4 = (float)TSDFMinusPlanesManager.Tile.tileLength;
        val_4 = val_4 + (-0.5f);
        val_5 = val_5 * val_4;
        val_4 = center.x - val_5;
        val_5 = center.y - val_5;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.minCoords = val_2;
        mem[1152921523040587388] = val_2.y;
        float val_7 = TSDFMinusPlanesManager.Tile.resolution;
        float val_6 = (float)TSDFMinusPlanesManager.Tile.tileLength;
        val_6 = val_6 + (-0.5f);
        val_7 = val_7 * val_6;
        val_6 = center.x + val_7;
        val_7 = center.y + val_7;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.maxCoords = val_3;
        mem[1152921523040587396] = val_3.y;
    }

}
