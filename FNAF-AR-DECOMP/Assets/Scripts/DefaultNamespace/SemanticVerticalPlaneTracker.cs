using UnityEngine;

namespace DefaultNamespace
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SemanticVerticalPlaneTracker : ISemanticVerticalPlaneAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<int, DefaultNamespace.SemanticVerticalPlaneTracker.SemanticVerticalPlane> IdToPlane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<DefaultNamespace.SemanticVerticalPlaneTracker.CandidateTileInfo> NewLabeledTiles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<DefaultNamespace.SemanticVerticalPlaneTracker.CandidateTileInfo> AlreadyLabeledTiles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<int> CurrentObjectCollisions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DefaultNamespace.SemanticVerticalPlaneTracker.SemanticVerticalPlane _defaultPlane;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SemanticVerticalPlaneTracker()
        {
            this.NewLabeledTiles = new System.Collections.Generic.List<CandidateTileInfo>();
            this.AlreadyLabeledTiles = new System.Collections.Generic.List<CandidateTileInfo>();
            this.CurrentObjectCollisions = new System.Collections.Generic.List<System.Int32>();
            this.IdToPlane = new System.Collections.Generic.Dictionary<System.Int32, SemanticVerticalPlane>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LabelNewPoints(int id, string label)
        {
            goto label_1;
            label_10:
            CandidateTileInfo val_1 = this.NewLabeledTiles.Item[0];
            int val_2 = val_1.planeId >> 32;
            SemanticVerticalPlane val_3 = this.IdToPlane.Item[val_1.planeId];
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
            SemanticVerticalPlane val_3 = this.IdToPlane.Item[val_1.planeId];
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
            if(((-1373796112) & 1) == 0)
            {
                    return;
            }
            
            SemanticVerticalPlane val_4 = this.IdToPlane.Item[1287529776];
            TileSemanticInfo val_5 = val_4.LabeledTiles.Item[new UnityEngine.Vector2() {x = -3.581929E-11f, y = 2.524356E-29f}];
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
            System.Collections.Generic.Dictionary<System.Int32, SemanticVerticalPlane> val_11;
            System.Collections.Generic.List<CandidateTileInfo> val_12;
            if((this.IdToPlane.ContainsKey(key:  id)) != true)
            {
                    val_11 = this.IdToPlane;
                val_11.set_Item(key:  id, value:  new SemanticVerticalPlane() {LabeledTiles = new System.Collections.Generic.Dictionary<UnityEngine.Vector2, TileSemanticInfo>()});
            }
            
            SemanticVerticalPlane val_3 = this.IdToPlane.Item[id];
            if((val_3.LabeledTiles.ContainsKey(key:  new UnityEngine.Vector2() {x = key.x, y = key.y})) == false)
            {
                goto label_9;
            }
            
            TileSemanticInfo val_5 = val_3.LabeledTiles.Item[new UnityEngine.Vector2() {x = key.x, y = key.y}];
            val_11 = val_5.labelToObjId;
            if((val_11.ContainsKey(key:  label)) == false)
            {
                goto label_9;
            }
            
            TileSemanticInfo val_7 = val_3.LabeledTiles.Item[new UnityEngine.Vector2() {x = key.x, y = key.y}];
            int val_8 = val_7.labelToObjId.Item[label];
            if((this.CurrentObjectCollisions.Contains(item:  val_8)) != true)
            {
                    this.CurrentObjectCollisions.Add(item:  val_8);
            }
            
            val_12 = this.AlreadyLabeledTiles;
            goto label_15;
            label_9:
            val_12 = this.NewLabeledTiles;
            label_15:
            float val_10 = key.y | (-4294967296);
            val_12.Add(item:  new CandidateTileInfo() {planeId = id, key = new UnityEngine.Vector2() {x = key.x, y = val_10}, collidedObjectId = val_10});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DefaultNamespace.SemanticVerticalPlaneTracker.SemanticVerticalPlane OnHorizontalSupportedPlaneRemove(int planeId)
        {
            SemanticVerticalPlane val_4;
            if((this.IdToPlane.ContainsKey(key:  planeId)) != false)
            {
                    SemanticVerticalPlane val_2 = this.IdToPlane.Item[planeId];
                val_4 = val_2.LabeledTiles;
                bool val_3 = this.IdToPlane.Remove(key:  planeId);
                return val_4;
            }
            
            val_4 = this._defaultPlane;
            return val_4;
        }
    
    }

}
