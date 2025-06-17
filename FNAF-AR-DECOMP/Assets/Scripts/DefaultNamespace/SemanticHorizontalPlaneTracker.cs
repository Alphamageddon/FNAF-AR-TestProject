using UnityEngine;

namespace DefaultNamespace
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SemanticHorizontalPlaneTracker : ISemanticHorizontalPlaneAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<int, DefaultNamespace.SemanticHorizontalPlaneTracker.SemanticHorizontalPlane> IdToPlane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<DefaultNamespace.SemanticHorizontalPlaneTracker.CandidateTileInfo> NewLabeledTiles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<DefaultNamespace.SemanticHorizontalPlaneTracker.CandidateTileInfo> AlreadyLabeledTiles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<int> CurrentObjectCollisions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<DefaultNamespace.SemanticHorizontalPlaneTracker.CandidateTileInfo> TilesToRemove;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DefaultNamespace.SemanticHorizontalPlaneTracker.SemanticHorizontalPlane defaultPlane;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SemanticHorizontalPlaneTracker()
        {
            this.NewLabeledTiles = new System.Collections.Generic.List<CandidateTileInfo>();
            this.AlreadyLabeledTiles = new System.Collections.Generic.List<CandidateTileInfo>();
            this.CurrentObjectCollisions = new System.Collections.Generic.List<System.Int32>();
            this.IdToPlane = new System.Collections.Generic.Dictionary<System.Int32, SemanticHorizontalPlane>();
            this.TilesToRemove = new System.Collections.Generic.List<CandidateTileInfo>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LabelNewPoints(int id, string label)
        {
            goto label_1;
            label_10:
            CandidateTileInfo val_1 = this.NewLabeledTiles.Item[0];
            int val_2 = val_1.planeId >> 32;
            SemanticHorizontalPlane val_3 = this.IdToPlane.Item[val_1.planeId];
            if((val_3.LabeledTiles.ContainsKey(key:  new UnityEngine.Vector2() {x = val_2, y = val_1.key.y})) != true)
            {
                    val_3.LabeledTiles.set_Item(key:  new UnityEngine.Vector2() {x = val_2, y = val_1.key.y}, value:  new TileSemanticInfo() {labelToObjId = new System.Collections.Generic.Dictionary<System.String, System.Int32>()});
            }
            
            TileSemanticInfo val_6 = val_3.LabeledTiles.Item[new UnityEngine.Vector2() {x = val_2, y = val_1.key.y}];
            val_6.labelToObjId.set_Item(key:  label, value:  id);
            0 = 1;
            label_1:
            if(0 < this.NewLabeledTiles.Count)
            {
                goto label_10;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RelabelPoints(int id, string label)
        {
            goto label_1;
            label_10:
            CandidateTileInfo val_1 = this.AlreadyLabeledTiles.Item[0];
            int val_2 = val_1.planeId >> 32;
            SemanticHorizontalPlane val_3 = this.IdToPlane.Item[val_1.planeId];
            if((val_3.LabeledTiles.ContainsKey(key:  new UnityEngine.Vector2() {x = val_2, y = val_1.key.y})) != true)
            {
                    val_3.LabeledTiles.set_Item(key:  new UnityEngine.Vector2() {x = val_2, y = val_1.key.y}, value:  new TileSemanticInfo() {labelToObjId = new System.Collections.Generic.Dictionary<System.String, System.Int32>()});
            }
            
            TileSemanticInfo val_6 = val_3.LabeledTiles.Item[new UnityEngine.Vector2() {x = val_2, y = val_1.key.y}];
            val_6.labelToObjId.set_Item(key:  label, value:  id);
            0 = 1;
            label_1:
            if(0 < this.AlreadyLabeledTiles.Count)
            {
                goto label_10;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RelabelTiles(System.Collections.Generic.HashSet<SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectTrackingManager.TileInfo> tiles, int id, string label)
        {
            HashSet.Enumerator<T> val_1 = tiles.GetEnumerator();
            label_6:
            if(((-1374973712) & 1) == 0)
            {
                    return;
            }
            
            SemanticHorizontalPlane val_4 = this.IdToPlane.Item[1287529776];
            TileSemanticInfo val_5 = val_4.LabeledTiles.Item[new UnityEngine.Vector2() {x = -3.173367E-11f, y = 2.524356E-29f}];
            val_5.labelToObjId.set_Item(key:  label = label, value:  id);
            goto label_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearInfo()
        {
            this.NewLabeledTiles.Clear();
            this.AlreadyLabeledTiles.Clear();
            this.CurrentObjectCollisions.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnLabelTile(int id, UnityEngine.Vector2 key, string label, int predId, float confidence)
        {
            string val_10;
            System.Collections.Generic.Dictionary<System.Int32, SemanticHorizontalPlane> val_11;
            System.Collections.Generic.List<CandidateTileInfo> val_12;
            val_10 = label;
            if((this.IdToPlane.ContainsKey(key:  id)) != true)
            {
                    val_11 = this.IdToPlane;
                val_11.set_Item(key:  id, value:  new SemanticHorizontalPlane() {LabeledTiles = new System.Collections.Generic.Dictionary<UnityEngine.Vector2, TileSemanticInfo>()});
            }
            
            SemanticHorizontalPlane val_3 = this.IdToPlane.Item[id];
            if((val_3.LabeledTiles.ContainsKey(key:  new UnityEngine.Vector2() {x = key.x, y = key.y})) == false)
            {
                goto label_9;
            }
            
            TileSemanticInfo val_5 = val_3.LabeledTiles.Item[new UnityEngine.Vector2() {x = key.x, y = key.y}];
            val_11 = val_5.labelToObjId;
            if((val_11.ContainsKey(key:  val_10)) == false)
            {
                goto label_9;
            }
            
            TileSemanticInfo val_7 = val_3.LabeledTiles.Item[new UnityEngine.Vector2() {x = key.x, y = key.y}];
            val_10 = val_7.labelToObjId.Item[val_10];
            if((this.CurrentObjectCollisions.Contains(item:  val_10)) != true)
            {
                    this.CurrentObjectCollisions.Add(item:  val_10);
            }
            
            val_12 = this.AlreadyLabeledTiles;
            goto label_15;
            label_9:
            val_12 = this.NewLabeledTiles;
            label_15:
            val_12.Add(item:  new CandidateTileInfo() {planeId = id, key = new UnityEngine.Vector2() {x = key.x, y = key.y}});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DefaultNamespace.SemanticHorizontalPlaneTracker.SemanticHorizontalPlane OnHorizontalSupportedPlaneRemove(int id)
        {
            SemanticHorizontalPlane val_4;
            if((this.IdToPlane.ContainsKey(key:  id)) != false)
            {
                    SemanticHorizontalPlane val_2 = this.IdToPlane.Item[id];
                val_4 = val_2.LabeledTiles;
                bool val_3 = this.IdToPlane.Remove(key:  id);
                return val_4;
            }
            
            val_4 = this.defaultPlane;
            return val_4;
        }
    
    }

}
