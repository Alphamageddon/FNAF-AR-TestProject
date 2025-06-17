using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class IllumixAdapter : ITileAccepter, IMeshBlockAccepter, IProcessedDirectedPointsAccepter, IBoundedPlaneAccepter, ISupportedHorizontalPlaneAccepter, ISupportedVerticalPlaneAccepter
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IllumixSurfaceManager accepter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DefaultNamespace.IIxHorizontalSupportedPlaneAccepter _horizontalSupportedPlaneAccepter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxVerticalSupportedPlaneAccepter _verticalSupportedPlaneAccepter;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Setup(IllumixSurfaceManager surfaceManager)
    {
        this.accepter = surfaceManager;
        if(surfaceManager != null)
        {
                this._horizontalSupportedPlaneAccepter = surfaceManager.HorizontalSupportedPlaneDeliverer;
        }
        else
        {
                this._horizontalSupportedPlaneAccepter = 0;
        }
        
        this._verticalSupportedPlaneAccepter = surfaceManager.VerticalSupportedPlaneDeliverer;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Teardown()
    {
        this.accepter = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnTileAddEvent(UnityEngine.Vector3 center, float length)
    {
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[4];
        float val_2 = length * 0.5f;
        float val_3 = center.x - val_2;
        float val_4 = center.z - val_2;
        float val_5 = center.x + val_2;
        val_1[0] = 0;
        val_1[0] = 0;
        val_1[1] = 0;
        float val_6 = center.z + val_2;
        val_1[1] = 0;
        val_1[2] = 0;
        val_1[2] = 0;
        val_1[3] = 0;
        val_1[3] = 0;
        val_1[4] = 0;
        val_1[4] = 0;
        val_1[5] = 0;
        val_1[5] = 0;
        this.accepter.OnTileAddEvent(tile:  new IllumixTile(center:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, vertices:  val_1, length:  length));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnTileRemoveEvent(UnityEngine.Vector3 center)
    {
        this.accepter.OnTileRemoveEvent(center:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnMeshBlockUpdatedEvent(UnityEngine.Vector3 key, UnityEngine.Vector3[] vertices, int[] triangles)
    {
        this.accepter.OnMeshBlockAddedEvent(meshBlock:  new IllumixMeshBlock(key:  new UnityEngine.Vector3() {x = key.x, y = key.y, z = key.z}, vertices:  vertices, triangles:  triangles));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnDirectedPointsUpdateEvent(UnityEngine.Vector3[] keys, DirectedPointsManager.DirectedPointData[] data, UnityEngine.Vector3 cameraPos)
    {
        int val_3;
        IllumixDirectedPoint[] val_1 = new IllumixDirectedPoint[0];
        if(data.Length < 1)
        {
            goto label_2;
        }
        
        var val_6 = 0;
        label_13:
        var val_2 = keys + (0 * 12);
        val_3 = data.Length;
        if(val_6 >= val_3)
        {
                val_3 = data.Length;
        }
        
        var val_3 = data + (0 * 28);
        var val_4 = data + (0 * 28);
        IllumixDirectedPoint val_5 = new IllumixDirectedPoint(key:  new UnityEngine.Vector3() {x = (0 * 12) + keys + 32, y = (0 * 12) + keys + 32 + 4, z = (0 * 12) + keys + 40}, position:  new UnityEngine.Vector3() {x = (0 * 28) + data + 32, y = (0 * 28) + data + 32 + 4, z = (0 * 28) + data + 40}, direction:  new UnityEngine.Vector3() {x = (0 * 28) + data + 44, y = (0 * 28) + data + 52, z = cameraPos.x}, cameraPos:  new UnityEngine.Vector3() {x = cameraPos.z, y = 8.391603E+12f, z = cameraPos.y});
        if(val_1 == null)
        {
            goto label_7;
        }
        
        if(val_5 != null)
        {
            goto label_8;
        }
        
        goto label_11;
        label_7:
        if(val_5 == null)
        {
            goto label_11;
        }
        
        label_8:
        label_11:
        val_1[0] = val_5;
        val_6 = val_6 + 1;
        if(val_6 < data.Length)
        {
            goto label_13;
        }
        
        label_2:
        mem[1152921518917040736].OnDirectedPointUpdate(points:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnHorizontalBoundedPlaneAdd(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center)
    {
        this.accepter.OnHorizontalBoundedPlaneAddEvent(plane:  new IllumixHorizontalBoundedPlane(boundary:  boundary, initialCenter:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, updateKey:  id));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnHorizontalBoundedPlaneUpdate(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, float height)
    {
        IllumixHorizontalBoundedPlane val_1 = this.accepter.GetHorizontalBoundedPlane(key:  id);
        val_1.<Boundary>k__BackingField = boundary;
        val_1.<Height>k__BackingField = height;
        this.accepter.OnHorizontalBoundedPlaneUpdateEvent(key:  id);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnHorizontalBoundedPlaneRemove(int id)
    {
        this.accepter.OnHorizontalBoundedPlaneRemoveEvent(key:  id);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnVerticalBoundedPlaneAdd(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center, UnityEngine.Vector3 normal)
    {
        this.accepter.OnVerticalBoundedPlaneAddEvent(plane:  new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalBoundedPlane(boundary:  boundary, initialCenter:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, normal:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z}, updateKey:  id));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnVerticalBoundedPlaneUpdate(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center, UnityEngine.Vector3 normal)
    {
        SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalBoundedPlane val_1 = this.accepter.GetVerticalBoundedPlane(key:  id);
        if(val_1 != null)
        {
                val_1.UpdatePlane(boundary:  boundary);
        }
        else
        {
                0.UpdatePlane(boundary:  boundary);
        }
        
        val_1.UpdateNormal(normal:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z});
        this.accepter.OnVerticalBoundedPlaneUpdateEvent(key:  id);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnVerticalBoundedPlaneRemove(int id)
    {
        this.accepter.OnVerticalBoundedPlaneRemoveEvent(key:  id);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnHorizontalSupportedPlaneAdd(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center, UnityEngine.Vector2 discretizedCenter, float tileLength)
    {
        int val_3;
        SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane val_1 = null;
        val_3 = id;
        val_1 = new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane(boundary:  boundary, initialCenter:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, discretizedCenter:  new UnityEngine.Vector2() {x = discretizedCenter.x, y = discretizedCenter.y}, updateKey:  val_3, tileLength:  tileLength);
        var val_3 = 0;
        val_3 = val_3 + 1;
        val_3 = 0;
        this._horizontalSupportedPlaneAccepter.OnPlaneAddEvent(plane:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnHorizontalSupportedPlaneAddPoints(int id, System.Collections.Generic.List<UnityEngine.Vector2> points)
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        this._horizontalSupportedPlaneAccepter.GetPlane(key:  id).UpdatePoints(newPoints:  points);
        var val_5 = 0;
        val_5 = val_5 + 1;
        this._horizontalSupportedPlaneAccepter.OnPointsUpdateEvent(key:  id, points:  points);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnHorizontalSupportedPlaneUpdateBoundary(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, float height)
    {
        var val_4;
        var val_4 = 0;
        val_4 = val_4 + 1;
        val_4 = public SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane DefaultNamespace.IIxHorizontalSupportedPlaneAccepter::GetPlane(int key);
        SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane val_2 = this._horizontalSupportedPlaneAccepter.GetPlane(key:  id);
        mem2[0] = boundary;
        mem2[0] = height;
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_4 = 1;
        this._horizontalSupportedPlaneAccepter.OnBoundaryUpdateEvent(key:  id);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnHorizontalSupportedPlaneSignificantUpdate(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, float height)
    {
        var val_4;
        var val_4 = 0;
        val_4 = val_4 + 1;
        val_4 = public SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane DefaultNamespace.IIxHorizontalSupportedPlaneAccepter::GetPlane(int key);
        SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane val_2 = this._horizontalSupportedPlaneAccepter.GetPlane(key:  id);
        mem2[0] = boundary;
        mem2[0] = height;
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_4 = 2;
        this._horizontalSupportedPlaneAccepter.OnSignificantUpdateEvent(key:  id);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnHorizontalSupportedPlaneAddTile(int id, UnityEngine.Vector2 center)
    {
        var val_4;
        var val_4 = 0;
        val_4 = val_4 + 1;
        val_4 = public SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane DefaultNamespace.IIxHorizontalSupportedPlaneAccepter::GetPlane(int key);
        this._horizontalSupportedPlaneAccepter.GetPlane(key:  id).AddTile(tile:  new UnityEngine.Vector2() {x = center.x, y = center.y});
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_4 = 4;
        this._horizontalSupportedPlaneAccepter.OnTileUpdateEvent(key:  id, tileCenters:  new UnityEngine.Vector2() {x = center.x, y = center.y});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnHorizontalSupportedPlaneRemove(int id)
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this._horizontalSupportedPlaneAccepter.OnPlaneRemoveEvent(key:  id);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnVerticalSupportedPlaneAdd(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 normal, UnityEngine.Vector3 center)
    {
        int val_3;
        SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane val_1 = null;
        val_3 = id;
        val_1 = new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane(boundary:  boundary, initialCenter:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, normal:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z}, updateKey:  val_3);
        var val_3 = 0;
        val_3 = val_3 + 1;
        val_3 = 0;
        this._verticalSupportedPlaneAccepter.OnPlaneAddEvent(plane:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnVerticalSupportedPlaneUpdatePoints(int id, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> points)
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        this._verticalSupportedPlaneAccepter.GetPlane(key:  id).UpdatePoints(newPoints:  points);
        var val_5 = 0;
        val_5 = val_5 + 1;
        this._verticalSupportedPlaneAccepter.OnPointsUpdateEvent(key:  id, points:  points);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnVerticalSupportedPlaneUpdateBoundary(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary)
    {
        var val_4;
        var val_4 = 0;
        val_4 = val_4 + 1;
        val_4 = 0;
        this._verticalSupportedPlaneAccepter.GetPlane(key:  id).UpdatePlane(boundary:  boundary);
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_4 = 1;
        this._verticalSupportedPlaneAccepter.OnBoundaryUpdateEvent(key:  id);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnVerticalSupportedPlaneSignificantUpdate(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 normal, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> reprojectedPoints, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3[]> reprojectedTileVertices)
    {
        var val_4;
        var val_4 = 0;
        val_4 = val_4 + 1;
        SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane val_2 = this._verticalSupportedPlaneAccepter.GetPlane(key:  id);
        if(val_2 != null)
        {
                val_2.UpdateNormal(normal:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z});
            val_2.UpdatePlane(boundary:  boundary);
            val_2.ReplacePoints(newPoints:  reprojectedPoints);
        }
        else
        {
                0.UpdateNormal(normal:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z});
            0.UpdatePlane(boundary:  boundary);
            0.ReplacePoints(newPoints:  reprojectedPoints);
        }
        
        val_4 = 0;
        val_2.ReplaceTileVertices(newVertices:  reprojectedTileVertices);
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_4 = 2;
        this._verticalSupportedPlaneAccepter.OnSignificantUpdateEvent(key:  id);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnVerticalSupportedPlaneAddTile(int id, UnityEngine.Vector2 key, UnityEngine.Vector2Int discretizedKey, UnityEngine.Vector3[] boundary)
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        this._verticalSupportedPlaneAccepter.GetPlane(key:  id).AddTile(key:  new UnityEngine.Vector2() {x = key.x, y = key.y}, discretizedKey:  new UnityEngine.Vector2Int() {m_X = discretizedKey.m_X, m_Y = discretizedKey.m_Y}, tile:  boundary);
        var val_5 = 0;
        val_5 = val_5 + 1;
        this._verticalSupportedPlaneAccepter.OnTileUpdateEvent(key:  id, planeSpaceCenter:  new UnityEngine.Vector2() {x = key.x, y = key.y}, tileCoords:  boundary);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnVerticalSupportedPlaneRemove(int id)
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this._verticalSupportedPlaneAccepter.OnRemoveEvent(key:  id);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IllumixAdapter()
    {
    
    }

}
