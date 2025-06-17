using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class VectorFeatureUnity
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.VectorTile.VectorTileFeature Data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, object> Properties;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>> Points;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Data.UnityTile Tile;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double _rectSizex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double _rectSizey;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _geomCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _pointCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.Vector3> _newPoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<float>>> _geom;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VectorFeatureUnity()
        {
            this.Points = new System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>>();
            this._newPoints = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this.Points = new System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VectorFeatureUnity(Mapbox.VectorTile.VectorTileFeature feature, Mapbox.Unity.MeshGeneration.Data.UnityTile tile, float layerExtent, bool buildingsWithUniqueIds = False)
        {
            System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>> val_16;
            var val_17;
            var val_18;
            System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Single>>> val_19;
            System.Collections.Generic.List<UnityEngine.Vector3> val_20;
            float val_21;
            double val_22;
            float val_23;
            this.Points = new System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>>();
            this._newPoints = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this.Data = feature;
            val_16 = this.Points;
            this.Properties = feature.GetProperties();
            val_16.Clear();
            this.Tile = tile;
            if(buildingsWithUniqueIds != false)
            {
                    val_17 = 1152921519726776208;
                val_18 = 0;
            }
            else
            {
                    val_18 = 0;
                val_17 = 1152921519726776208;
            }
            
            this._geom = feature.Geometry<System.Single>(clipBuffer:  new System.Nullable<System.UInt32>() {HasValue = false}, scale:  new System.Nullable<System.Single>() {HasValue = false});
            Mapbox.Utils.Vector2d val_5 = tile.<Rect>k__BackingField.Max;
            this._rectSizex = val_5.x;
            Mapbox.Utils.Vector2d val_6 = tile.<Rect>k__BackingField.<Min>k__BackingField.Max;
            val_19 = this._geom;
            this._rectSizey = val_6.y;
            int val_7 = val_19.Count;
            this._geomCount = val_7;
            if(val_7 < 1)
            {
                    return;
            }
            
            do
            {
                int val_9 = this._geom.Item[0].Count;
                this._pointCount = val_9;
                System.Collections.Generic.List<UnityEngine.Vector3> val_10 = null;
                val_20 = val_10;
                val_10 = new System.Collections.Generic.List<UnityEngine.Vector3>(capacity:  val_9);
                this._newPoints = val_20;
                if(this._pointCount >= 1)
            {
                    var val_20 = 0;
                do
            {
                Mapbox.VectorTile.Geometry.Point2d<System.Single> val_12 = this._geom.Item[0].Item[0];
                if(tile != null)
            {
                    val_21 = tile.<TileScale>k__BackingField;
                val_22 = this._rectSizey;
                val_23 = val_21;
            }
            else
            {
                    val_23 = tile.<TileScale>k__BackingField;
                val_22 = this._rectSizey;
                val_21 = tile.<TileScale>k__BackingField;
            }
            
                val_12.Y = val_12.Y / layerExtent;
                float val_13 = layerExtent - val_6.y;
                double val_16 = (double)val_12.Y;
                val_13 = val_13 / layerExtent;
                val_16 = this._rectSizex * val_16;
                double val_17 = (double)val_13;
                val_16 = val_16 - (this._rectSizex * 0.5);
                double val_15 = val_22 * 0.5;
                val_17 = val_22 * val_17;
                val_15 = val_17 - val_15;
                float val_18 = (float)val_16;
                float val_19 = (float)val_15;
                val_18 = val_23 * val_18;
                val_19 = val_21 * val_19;
                this._newPoints.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_20 = val_20 + 1;
            }
            while(val_20 < this._pointCount);
            
                val_20 = this._newPoints;
            }
            
                val_16 = this.Points;
                val_16.Add(item:  val_20);
                val_19 = 0 + 1;
            }
            while(val_19 < this._geomCount);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VectorFeatureUnity(Mapbox.VectorTile.VectorTileFeature feature, System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<float>>> geom, Mapbox.Unity.MeshGeneration.Data.UnityTile tile, float layerExtent, bool buildingsWithUniqueIds = False)
        {
            System.Collections.Generic.List<UnityEngine.Vector3> val_16;
            System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Single>>> val_17;
            System.Collections.Generic.List<UnityEngine.Vector3> val_18;
            float val_19;
            double val_20;
            float val_21;
            this.Points = new System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>>();
            System.Collections.Generic.List<UnityEngine.Vector3> val_2 = null;
            val_16 = val_2;
            val_2 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this._newPoints = val_16;
            val_3 = new System.Object();
            this.Data = feature;
            this.Properties = feature.GetProperties();
            this.Points.Clear();
            this.Tile = tile;
            this._geom = val_3;
            Mapbox.Utils.Vector2d val_5 = tile.<Rect>k__BackingField.Max;
            this._rectSizex = val_5.x;
            Mapbox.Utils.Vector2d val_6 = tile.<Rect>k__BackingField.<Min>k__BackingField.Max;
            val_17 = this._geom;
            this._rectSizey = val_6.y;
            int val_7 = val_17.Count;
            this._geomCount = val_7;
            if(val_7 < 1)
            {
                    return;
            }
            
            do
            {
                int val_9 = this._geom.Item[0].Count;
                this._pointCount = val_9;
                System.Collections.Generic.List<UnityEngine.Vector3> val_10 = null;
                val_18 = val_10;
                val_10 = new System.Collections.Generic.List<UnityEngine.Vector3>(capacity:  val_9);
                this._newPoints = val_18;
                if(this._pointCount >= 1)
            {
                    var val_20 = 0;
                do
            {
                Mapbox.VectorTile.Geometry.Point2d<System.Single> val_12 = this._geom.Item[0].Item[0];
                if(tile != null)
            {
                    val_19 = tile.<TileScale>k__BackingField;
                val_20 = this._rectSizey;
                val_21 = val_19;
            }
            else
            {
                    val_21 = tile.<TileScale>k__BackingField;
                val_20 = this._rectSizey;
                val_19 = tile.<TileScale>k__BackingField;
            }
            
                val_12.Y = val_12.Y / layerExtent;
                float val_13 = layerExtent - val_6.y;
                double val_16 = (double)val_12.Y;
                val_13 = val_13 / layerExtent;
                val_16 = this._rectSizex * val_16;
                double val_17 = (double)val_13;
                val_16 = val_16 - (this._rectSizex * 0.5);
                double val_15 = val_20 * 0.5;
                val_17 = val_20 * val_17;
                val_15 = val_17 - val_15;
                float val_18 = (float)val_16;
                float val_19 = (float)val_15;
                val_18 = val_21 * val_18;
                val_19 = val_19 * val_19;
                this._newPoints.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_20 = val_20 + 1;
            }
            while(val_20 < this._pointCount);
            
                val_18 = this._newPoints;
            }
            
                val_16 = this.Points;
                val_16.Add(item:  val_18);
                val_17 = 0 + 1;
            }
            while(val_17 < this._geomCount);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ContainsLatLon(Mapbox.Utils.Vector2d coord)
        {
            float val_17;
            float val_18;
            System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Single>>> val_19;
            Mapbox.Map.UnwrappedTileId val_1 = Mapbox.Unity.Utilities.Conversions.LatitudeLongitudeToTileId(latitude:  coord.x, longitude:  coord.y, zoom:  this.Tile.<CurrentZoom>k__BackingField);
            if(this.Points.Count < 1)
            {
                goto label_3;
            }
            
            Mapbox.Utils.Vector2d val_3 = Mapbox.Unity.Utilities.Conversions.LatLonToMeters(lat:  coord.x, lon:  coord.y);
            UnityEngine.Vector3 val_5 = this.Points.Item[0].Item[0];
            if(this.Tile != null)
            {
                    val_17 = this.Tile.<TileScale>k__BackingField;
            }
            else
            {
                    val_17 = this.Tile.<TileScale>k__BackingField;
                if(this.Tile != null)
            {
                
            }
            
            }
            
            Mapbox.Utils.Vector2d val_6 = Size;
            UnityEngine.Vector3 val_8 = this.Points.Item[0].Item[0];
            if(this.Tile != null)
            {
                    val_18 = this.Tile.<TileScale>k__BackingField;
            }
            else
            {
                    val_18 = this.Tile.<TileScale>k__BackingField;
                if(this.Tile != null)
            {
                
            }
            
            }
            
            Mapbox.Utils.Vector2d val_9 = Size;
            val_8.z = val_8.z / val_18;
            double val_17 = (double)val_5.x / val_17;
            val_17 = val_6.x + val_17;
            val_9.y = val_9.y + (double)val_8.z;
            Mapbox.Utils.Vector2d val_11 = new Mapbox.Utils.Vector2d(x:  val_17, y:  val_9.y);
            if((Mapbox.Utils.Mathd.Abs(d:  Mapbox.Utils.Vector2d.Distance(a:  new Mapbox.Utils.Vector2d() {x = val_3.x, y = val_3.y}, b:  new Mapbox.Utils.Vector2d() {x = val_11.x, y = val_11.y}))) < 0)
            {
                goto label_16;
            }
            
            label_3:
            if(((-2016648496) & 1) == 0)
            {
                goto label_18;
            }
            
            UnityEngine.Vector2 val_14 = Mapbox.Unity.Utilities.Conversions.LatitudeLongitudeToVectorTilePosition(coordinate:  new Mapbox.Utils.Vector2d() {x = coord.x, y = coord.y}, tileZoom:  this.Tile.<CurrentZoom>k__BackingField, layerExtent:  4096);
            UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  val_14.x, y:  val_14.y);
            val_19 = this._geom;
            bool val_16 = Mapbox.Utils.PolygonUtils.PointInPolygon(coord:  new Mapbox.VectorTile.Geometry.Point2d<System.Single>() {Y = val_15.x}, poly:  val_19);
            goto label_21;
            label_18:
            val_19 = 0;
            goto label_21;
            label_16:
            val_19 = 1;
            label_21:
            val_19 = val_19 & 1;
            return (bool)val_19;
        }
    
    }

}
