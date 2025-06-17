using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ReplaceFeatureModifier : GameObjectModifier, IReplacementCriteria
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<string> _latLonToSpawn;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<ulong, UnityEngine.GameObject> _objects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<ulong, Mapbox.Utils.Vector2d> _objectPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _poolGameObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.SpawnPrefabOptions _options;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.GameObject> _prefabList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<string> _prefabLocations;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<string> _explicitlyBlockedFeatureIds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float _maxDistanceToBlockFeature_tilespace = 1000;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<System.Collections.Generic.List<string>> _featureId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _tempFeatureId;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> PrefabLocations { set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> BlockedIds { set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_SpawnPrefabOptions(Mapbox.Unity.Map.SpawnPrefabOptions value)
        {
            this._options = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_PrefabLocations(System.Collections.Generic.List<string> value)
        {
            this._prefabLocations = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_BlockedIds(System.Collections.Generic.List<string> value)
        {
            this._explicitlyBlockedFeatureIds = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Initialize()
        {
            var val_9;
            this._latLonToSpawn = new System.Collections.Generic.List<System.String>(collection:  this._prefabLocations);
            this._featureId = new System.Collections.Generic.List<System.Collections.Generic.List<System.String>>();
            val_9 = 0;
            goto label_1;
            label_4:
            this._featureId.Add(item:  new System.Collections.Generic.List<System.String>());
            val_9 = 1;
            label_1:
            if(val_9 < this._prefabLocations.Count)
            {
                goto label_4;
            }
            
            if(this._objects == null)
            {
                    this._objects = new System.Collections.Generic.Dictionary<System.UInt64, UnityEngine.GameObject>();
                this._objectPosition = new System.Collections.Generic.Dictionary<System.UInt64, Mapbox.Utils.Vector2d>();
                this._poolGameObject = new UnityEngine.GameObject(name:  "_inactive_prefabs_pool");
            }
            
            this._latLonToSpawn = new System.Collections.Generic.List<System.String>(collection:  this._prefabLocations);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetProperties(Mapbox.Unity.MeshGeneration.Modifiers.ModifierProperties properties)
        {
            Mapbox.Unity.MeshGeneration.Modifiers.ModifierProperties val_3 = properties;
            if(val_3 != null)
            {
                    val_3 = 0;
            }
            
            this._options = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void FeaturePreProcess(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature)
        {
            var val_3;
            System.Collections.Generic.List<System.String> val_20;
            System.Collections.Generic.List<System.String> val_21;
            string val_22;
            val_20 = feature;
            List.Enumerator<T> val_1 = this._prefabLocations.GetEnumerator();
            int val_20 = 0;
            label_39:
            val_20 = val_20 + 1;
            if(((-2075977888) & 1) == 0)
            {
                goto label_2;
            }
            
            Mapbox.Utils.Vector2d val_5 = Mapbox.Unity.Utilities.Conversions.StringToLatLon(s:  val_3.emailUIDataHandler);
            if(((val_20.ContainsLatLon(coord:  new Mapbox.Utils.Vector2d() {x = val_5.x, y = val_5.y})) == false) || (feature.Data.Id == 0))
            {
                goto label_39;
            }
            
            if(this._featureId.Item[val_20] != null)
            {
                    val_21 = this._featureId.Item[val_20];
            }
            else
            {
                    val_21 = null;
                val_21 = new System.Collections.Generic.List<System.String>();
            }
            
            this._featureId.set_Item(index:  val_20, value:  null);
            string val_12 = feature.Data.Id.ToString();
            this._tempFeatureId = val_12;
            val_22 = this._tempFeatureId;
            if(val_12.Length >= 4)
            {
                    val_22 = val_22.Substring(startIndex:  0, length:  val_22.Length - 3);
            }
            
            this._featureId.Item[val_20].Add(item:  val_22);
            goto label_39;
            label_2:
            long val_18 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519710738272});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShouldReplaceFeature(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature)
        {
            var val_3;
            var val_17;
            var val_34;
            long val_50;
            var val_51;
            string val_53;
            int val_55;
            var val_56;
            var val_59;
            val_50 = feature;
            val_51 = 1152921517654219136;
            List.Enumerator<T> val_1 = this._explicitlyBlockedFeatureIds.GetEnumerator();
            do
            {
                if(((-2075702128) & 1) == 0)
            {
                goto label_7;
            }
            
                val_53 = val_3.emailUIDataHandler;
            }
            while((System.String.op_Equality(a:  feature.Data.Id.ToString(), b:  val_53)) == false);
            
            long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519711014032});
            goto label_6;
            label_7:
            List.Enumerator<T> val_11 = this._prefabLocations.GetEnumerator();
            val_53 = 1152921519710683408;
            val_55 = 0;
            goto label_17;
            label_69:
            val_55 = W26 + 1;
            if(this._featureId.Item[val_55] == null)
            {
                goto label_17;
            }
            
            List.Enumerator<T> val_15 = this._featureId.Item[val_55].GetEnumerator();
            label_33:
            if(((-2075702160) & 1) == 0)
            {
                goto label_20;
            }
            
            Mapbox.Utils.Vector2d val_19 = Mapbox.Unity.Utilities.Conversions.StringToLatLon(s:  val_3.emailUIDataHandler);
            Mapbox.Utils.Vector2d val_20 = Mapbox.Unity.Utilities.Conversions.LatLonToMeters(lat:  val_19.x, lon:  val_19.y);
            UnityEngine.Vector3 val_22 = feature.Points.Item[0].Item[0];
            Mapbox.Utils.RectD val_24 = feature.Tile.Rect;
            Mapbox.Utils.Vector2d val_27 = val_3.Size;
            UnityEngine.Vector3 val_29 = feature.Points.Item[0].Item[0];
            Mapbox.Utils.RectD val_31 = feature.Tile.Rect;
            Mapbox.Utils.Vector2d val_36 = val_34.Size;
            double val_49 = (double)val_22.x / feature.Tile.TileScale;
            val_49 = val_27.x + val_49;
            val_36.y = val_36.y + ((double)val_29.z / feature.Tile.TileScale);
            Mapbox.Utils.Vector2d val_39 = new Mapbox.Utils.Vector2d(x:  val_49, y:  val_36.y);
            if((Mapbox.Utils.Vector2d.Distance(a:  new Mapbox.Utils.Vector2d() {x = val_20.x, y = val_20.y}, b:  new Mapbox.Utils.Vector2d() {x = val_39.x, y = val_39.y})) > 500)
            {
                goto label_30;
            }
            
            if((feature.Data.Id.ToString().StartsWith(value:  val_17.emailUIDataHandler, comparisonType:  0)) == false)
            {
                goto label_33;
            }
            
            goto label_34;
            label_20:
            val_56 = 408;
            goto label_35;
            label_30:
            label_34:
            val_56 = 447;
            label_35:
            val_51 = 0;
            long val_44 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519711014000});
            var val_45 = ( == 0) ? 408 : ();
            if(val_45 != 408)
            {
                    if(val_45 == 447)
            {
                goto label_59;
            }
            
            }
            
            val_55 = W26 + 1;
            label_17:
            if(((-2075702128) & 1) != 0)
            {
                goto label_69;
            }
            
            val_51 = ;
            val_50 = 445;
            goto label_71;
            label_59:
            val_50 = 447;
            label_71:
            long val_46 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519711014032});
            var val_47 = ( == 0) ? 445 : ();
            if(val_47 == 445)
            {
                goto label_79;
            }
            
            if(val_47 != 447)
            {
                goto label_77;
            }
            
            label_6:
            val_59 = 0;
            return (bool)val_59 & 1;
            label_77:
            label_79:
            val_59 = 0;
            return (bool)val_59 & 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorEntity ve, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            Mapbox.Utils.Vector2d val_1 = Mapbox.Utils.Vector2d.zero;
            if((this.ShouldSpawnFeature(feature:  ve.Feature, latLong: out  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y})) == false)
            {
                    return;
            }
            
            this.SpawnPrefab(ve:  ve, tile:  tile, latLong:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SpawnPrefab(Mapbox.Unity.MeshGeneration.Data.VectorEntity ve, Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Utils.Vector2d latLong)
        {
            UnityEngine.GameObject val_9;
            Mapbox.Unity.Map.SpawnPrefabOptions val_10;
            var val_11;
            ulong val_1 = ve.Feature.Data.Id;
            if((this._objects.ContainsKey(key:  val_1)) == false)
            {
                goto label_5;
            }
            
            val_9 = this._objects.Item[val_1];
            if(val_9 == null)
            {
                goto label_7;
            }
            
            val_9.SetActive(value:  true);
            goto label_8;
            label_5:
            val_10 = this;
            val_9 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._options.prefab);
            this._prefabList.Add(item:  val_9);
            this._objects.Add(key:  val_1, value:  val_9);
            this._objectPosition.Add(key:  val_1, value:  new Mapbox.Utils.Vector2d() {x = latLong.x, y = latLong.y});
            val_11 = val_9.transform;
            val_11.SetParent(parent:  ve.GameObject.transform, worldPositionStays:  false);
            goto label_18;
            label_7:
            val_9.SetActive(value:  true);
            label_8:
            val_11 = val_9.transform;
            val_11.SetParent(parent:  ve.GameObject.transform, worldPositionStays:  false);
            val_10 = this._options;
            label_18:
            this.PositionScaleRectTransform(ve:  ve, tile:  tile, go:  val_9, latLong:  new Mapbox.Utils.Vector2d() {x = latLong.x, y = latLong.y});
            if(this._options.AllPrefabsInstatiated == null)
            {
                    return;
            }
            
            mem[this._options] + 32.Invoke(obj:  this._prefabList);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PositionScaleRectTransform(Mapbox.Unity.MeshGeneration.Data.VectorEntity ve, Mapbox.Unity.MeshGeneration.Data.UnityTile tile, UnityEngine.GameObject go, Mapbox.Utils.Vector2d latLong)
        {
            var val_7;
            double val_32;
            float val_36;
            float val_37;
            float val_38;
            var val_39;
            var val_40;
            float val_41;
            int val_42;
            var val_43;
            float val_44;
            float val_45;
            float val_46;
            Mapbox.Unity.Map.SpawnPrefabOptions val_48;
            val_32 = latLong.y;
            UnityEngine.Vector3 val_3 = this._options.prefab.transform.localScale;
            go.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            List.Enumerator<T> val_5 = ve.Feature.Points.Item[0].GetEnumerator();
            val_36 = 0f;
            val_37 = 0f;
            val_38 = 0f;
            goto label_10;
            label_13:
            UnityEngine.Vector3 val_8 = val_7.position;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_38, y = val_37, z = val_36}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            val_36 = val_9.z;
            val_37 = val_9.y;
            val_38 = val_9.x;
            label_10:
            if(((-2074952432) & 1) != 0)
            {
                goto label_13;
            }
            
            val_39 = 0;
            val_40 = 1;
            long val_10 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519711763728});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_38, y = val_37, z = val_36}, d:  (float)ve.Feature.Points.Item[0].Count);
            val_41 = val_13.z;
            if(tile != null)
            {
                    val_42 = tile.CurrentZoom;
            }
            else
            {
                    val_42 = 0.CurrentZoom;
            }
            
            UnityEngine.Vector2 val_17 = Mapbox.Unity.Utilities.Conversions.LatitudeLongitudeToUnityTilePosition(coordinate:  new Mapbox.Utils.Vector2d() {x = latLong.x, y = val_32}, tileZoom:  val_42, tileScale:  tile.TileScale, layerExtent:  4096);
            UnityEngine.Vector3 val_18 = Mapbox.Unity.Utilities.VectorExtensions.ToVector3xz(v:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
            string val_20 = ve.Feature.Data.Id.ToString();
            if(go != null)
            {
                    go.name = val_20;
            }
            else
            {
                    0.name = val_20;
            }
            
            UnityEngine.RectTransform val_21 = go.GetComponent<UnityEngine.RectTransform>();
            val_43 = 0;
            if(val_21 != 0)
            {
                goto label_33;
            }
            
            val_44 = val_13.x;
            val_45 = val_13.y;
            val_46 = val_41;
            go.transform.localPosition = new UnityEngine.Vector3() {x = val_44, y = val_45, z = val_46};
            if(go != null)
            {
                goto label_39;
            }
            
            goto label_37;
            label_33:
            val_44 = val_13.x;
            val_45 = val_13.y;
            val_46 = val_41;
            val_21.anchoredPosition3D = new UnityEngine.Vector3() {x = val_44, y = val_45, z = val_46};
            if(go != null)
            {
                goto label_39;
            }
            
            label_37:
            label_39:
            Mapbox.Unity.MeshGeneration.Interfaces.IFeaturePropertySettable val_24 = go.GetComponent<Mapbox.Unity.MeshGeneration.Interfaces.IFeaturePropertySettable>();
            if(val_24 != null)
            {
                    var val_32 = 0;
                val_32 = val_32 + 1;
                val_43 = 0;
                val_24.Set(props:  ve.Feature.Properties);
            }
            
            val_48 = this._options;
            if(this._options.scaleDownWithWorld == false)
            {
                    return;
            }
            
            if(go != null)
            {
                    val_48 = go.transform;
            }
            else
            {
                    val_48 = 0.transform;
            }
            
            UnityEngine.Vector3 val_29 = go.transform.localScale;
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, d:  tile.TileScale);
            val_32 = val_31.x;
            val_41 = val_31.z;
            val_48.localScale = new UnityEngine.Vector3() {x = val_32, y = val_31.y, z = val_41};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldSpawnFeature(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature, out Mapbox.Utils.Vector2d latLong)
        {
            var val_14;
            ulong val_15;
            ulong val_16;
            var val_17;
            val_14 = 1152921519712068336;
            val_15 = this;
            Mapbox.Utils.Vector2d val_1 = Mapbox.Utils.Vector2d.zero;
            latLong.x = val_1.x;
            latLong.y = val_1.y;
            if(feature != null)
            {
                    val_16 = feature.Data.Id;
                if((this._objects.ContainsKey(key:  val_16)) != false)
            {
                    val_15 = feature.Data.Id;
                bool val_5 = this._objectPosition.TryGetValue(key:  val_15, value: out  new Mapbox.Utils.Vector2d() {x = latLong.x, y = latLong.y});
                val_17 = 1;
                return (bool)val_17;
            }
            
                List.Enumerator<T> val_6 = this._latLonToSpawn.GetEnumerator();
                val_16 = 1152921517654220160;
                do
            {
                if(((-2074696024) & 1) == 0)
            {
                goto label_18;
            }
            
                GameUI.EmailUIDataHandler val_7 = 0.emailUIDataHandler;
                Mapbox.Utils.Vector2d val_8 = Mapbox.Unity.Utilities.Conversions.StringToLatLon(s:  val_7);
            }
            while((feature.ContainsLatLon(coord:  new Mapbox.Utils.Vector2d() {x = val_8.x, y = val_8.y})) == false);
            
                bool val_10 = this._latLonToSpawn.Remove(item:  val_7);
                latLong.x = val_8.x;
                latLong.y = val_8.y;
                long val_11 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519712020136});
                val_17 = 1;
                return (bool)val_17;
            }
            
            label_18:
            val_17 = 0;
            return (bool)val_17;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnPoolItem(Mapbox.Unity.MeshGeneration.Data.VectorEntity vectorEntity)
        {
            ulong val_1 = vectorEntity.Feature.Data.Id;
            if((this._objects.ContainsKey(key:  val_1)) == false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_3 = this._objects.Item[val_1];
            if(val_3 == 0)
            {
                    return;
            }
            
            if(this._poolGameObject == 0)
            {
                    return;
            }
            
            if(val_3 != null)
            {
                    val_3.SetActive(value:  false);
            }
            else
            {
                    val_3.SetActive(value:  false);
            }
            
            val_3.transform.SetParent(parent:  this._poolGameObject.transform, worldPositionStays:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ReplaceFeatureModifier()
        {
            this._prefabList = new System.Collections.Generic.List<UnityEngine.GameObject>();
            mem[1152921519712383176] = 1;
            this = new UnityEngine.ScriptableObject();
        }
    
    }

}
