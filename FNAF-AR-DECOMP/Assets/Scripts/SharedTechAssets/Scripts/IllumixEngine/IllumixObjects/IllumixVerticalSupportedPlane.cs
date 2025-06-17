using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixObjects
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IllumixVerticalSupportedPlane : IllumixVerticalBoundedPlane
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> ProjectedPoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3[]> TileCoords;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector2Int> TileKeyToDiscretizedCoords;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IllumixVerticalSupportedPlane(System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 initialCenter, UnityEngine.Vector3 normal, int updateKey)
        {
            this.TileKeyToDiscretizedCoords = new System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector2Int>();
            this.ProjectedPoints = new System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3>();
            this.TileCoords = new System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3[]>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdatePoints(System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> newPoints)
        {
            float val_4;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = newPoints.Keys.GetEnumerator();
            label_6:
            if((1357065648 & 1) == 0)
            {
                goto label_3;
            }
            
            UnityEngine.Vector3 val_5 = newPoints.Item[new UnityEngine.Vector2() {x = val_4, y = V1.16B}];
            this.ProjectedPoints.set_Item(key:  new UnityEngine.Vector2() {x = val_4, y = V1.16B}, value:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            goto label_6;
            label_3:
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523143781808});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ReplacePoints(System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> newPoints)
        {
            this.ProjectedPoints = newPoints;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddTile(UnityEngine.Vector2 key, UnityEngine.Vector2Int discretizedKey, UnityEngine.Vector3[] tile)
        {
            this.TileCoords.set_Item(key:  new UnityEngine.Vector2() {x = key.x, y = key.y}, value:  tile);
            this.TileKeyToDiscretizedCoords.set_Item(key:  new UnityEngine.Vector2() {x = key.x, y = key.y}, value:  new UnityEngine.Vector2Int() {m_X = discretizedKey.m_X, m_Y = discretizedKey.m_Y});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ReplaceTileVertices(System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3[]> newVertices)
        {
            this.TileCoords = newVertices;
        }
    
    }

}
