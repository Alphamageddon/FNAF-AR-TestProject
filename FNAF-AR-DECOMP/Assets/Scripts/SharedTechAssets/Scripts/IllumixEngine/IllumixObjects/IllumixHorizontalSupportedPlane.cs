using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixObjects
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IllumixHorizontalSupportedPlane : IllumixHorizontalBoundedPlane
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.HashSet<UnityEngine.Vector2> ProjectedPoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.HashSet<UnityEngine.Vector2> Tiles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector2Int> TileKeyToDiscretizedCoords;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector2 DiscretizedCenter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float TileLength;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IllumixHorizontalSupportedPlane(System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 initialCenter, UnityEngine.Vector2 discretizedCenter, int updateKey, float tileLength)
        {
            this.DiscretizedCenter = discretizedCenter;
            mem[1152921523142071340] = discretizedCenter.y;
            this.TileKeyToDiscretizedCoords = new System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector2Int>();
            this.ProjectedPoints = new System.Collections.Generic.HashSet<UnityEngine.Vector2>();
            this.Tiles = new System.Collections.Generic.HashSet<UnityEngine.Vector2>();
            this.TileLength = tileLength;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdatePoints(System.Collections.Generic.List<UnityEngine.Vector2> newPoints)
        {
            goto label_1;
            label_5:
            UnityEngine.Vector2 val_1 = newPoints.Item[0];
            bool val_2 = this.ProjectedPoints.Add(item:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            0 = 1;
            label_1:
            if(0 < newPoints.Count)
            {
                goto label_5;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddTile(UnityEngine.Vector2 tile)
        {
            bool val_1 = this.Tiles.Add(item:  new UnityEngine.Vector2() {x = tile.x, y = tile.y});
            UnityEngine.Vector2Int val_2 = this.GetTileKey(tile:  new UnityEngine.Vector2() {x = tile.x, y = tile.y});
            this.TileKeyToDiscretizedCoords.set_Item(key:  new UnityEngine.Vector2() {x = tile.x, y = tile.y}, value:  new UnityEngine.Vector2Int() {m_X = val_2.m_X, m_Y = val_2.m_Y});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector2Int GetTileKey(UnityEngine.Vector2 tile)
        {
            float val_1;
            double val_8;
            float val_9;
            double val_10;
            float val_12;
            double val_13;
            UnityEngine.Vector2 val_8 = this.DiscretizedCenter;
            tile.x = tile.x - val_8;
            val_8 = tile.x / this.TileLength;
            if(val_8 >= 0f)
            {
                goto label_3;
            }
            
            val_8 = -0.5;
            if((double)val_8 != val_8)
            {
                goto label_4;
            }
            
            val_9 = val_1;
            val_10 = -1;
            goto label_5;
            label_3:
            val_8 = 0.5;
            if((double)val_8 != val_8)
            {
                goto label_6;
            }
            
            val_9 = val_1;
            val_10 = 1;
            label_5:
            val_8 = val_9 + val_10;
            var val_2 = (((long)val_9 & 1) != 0) ? (val_9) : (val_8);
            goto label_8;
            label_4:
            double val_3 = (double)val_8 + val_8;
            goto label_8;
            label_6:
            double val_4 = (double)val_8 + val_8;
            label_8:
            val_4 = tile.y - val_4;
            val_8 = val_4 / this.TileLength;
            if(val_8 >= 0f)
            {
                goto label_9;
            }
            
            if((double)val_8 != (-0.5))
            {
                goto label_10;
            }
            
            val_12 = val_1;
            val_13 = -1;
            goto label_11;
            label_9:
            if((double)val_8 != 0.5)
            {
                goto label_12;
            }
            
            val_12 = val_1;
            val_13 = 1;
            label_11:
            val_13 = val_12 + val_13;
            val_12 = (((long)val_12 & 1) != 0) ? (val_12) : (val_13);
            goto label_14;
            label_10:
            double val_5 = (double)val_8 + (-0.5);
            goto label_14;
            label_12:
            label_14:
            GameSparks.RT.Proto.Key val_7 = new GameSparks.RT.Proto.Key(field:  (int)(double)val_8, wireType:  (int)(double)val_8 + 0.5);
            return new UnityEngine.Vector2Int() {m_X = val_7.<Field>k__BackingField, m_Y = val_7.<Field>k__BackingField};
        }
    
    }

}
