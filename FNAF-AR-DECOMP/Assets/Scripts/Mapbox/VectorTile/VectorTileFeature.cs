using UnityEngine;

namespace Mapbox.VectorTile
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class VectorTileFeature
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.VectorTile.VectorTileLayer _layer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private object _cachedGeometry;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<uint> _clipBuffer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<float> _scale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<float> _previousScale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ulong <Id>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.VectorTile.Geometry.GeomType <GeometryType>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<uint> <GeometryCommands>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<int> <Tags>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ulong Id { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.VectorTile.VectorTileLayer Layer { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.VectorTile.Geometry.GeomType GeometryType { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<uint> GeometryCommands { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<int> Tags { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VectorTileFeature(Mapbox.VectorTile.VectorTileLayer layer, System.Nullable<uint> clipBuffer, float scale = 1)
        {
            this._layer = layer;
            this._clipBuffer = clipBuffer.HasValue;
            this._scale = 0;
            this.<Tags>k__BackingField = new System.Collections.Generic.List<System.Int32>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ulong get_Id()
        {
            return (ulong)this.<Id>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Id(ulong value)
        {
            this.<Id>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.VectorTile.VectorTileLayer get_Layer()
        {
            return (Mapbox.VectorTile.VectorTileLayer)this._layer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.VectorTile.Geometry.GeomType get_GeometryType()
        {
            return (Mapbox.VectorTile.Geometry.GeomType)this.<GeometryType>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_GeometryType(Mapbox.VectorTile.Geometry.GeomType value)
        {
            this.<GeometryType>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<uint> get_GeometryCommands()
        {
            return (System.Collections.Generic.List<System.UInt32>)this.<GeometryCommands>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_GeometryCommands(System.Collections.Generic.List<uint> value)
        {
            this.<GeometryCommands>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<T>>> Geometry<T>(System.Nullable<uint> clipBuffer, System.Nullable<float> scale)
        {
            var val_23;
            System.Collections.Generic.List<System.UInt32> val_24;
            object val_25;
            float val_26;
            var val_27;
            System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>> val_28;
            val_23 = __RuntimeMethodHiddenParam;
            val_24 = 1152921517591262608;
            val_25 = this._cachedGeometry;
            if(val_25 != null)
            {
                    val_26 = this._scale.HasValue.distance;
                float val_2 = this._previousScale.distance;
                if(val_26 == val_2)
            {
                    if((8 & 1) == 0)
            {
                    return (System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<T>>>)val_25;
            }
            
            }
            
            }
            
            val_27 = 1152921517591263632;
            val_24 = this.GeometryCommands;
            val_28 = Mapbox.VectorTile.Geometry.DecodeGeometry.GetGeometry(extent:  this._layer.Extent, geomType:  this.GeometryType, geometryCommands:  val_24, scale:  val_2);
            if(((-1902910488) & 1) != 0)
            {
                    if((val_28.Count >= 2) && (this.GeometryType == 3))
            {
                    System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>> val_9 = new System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>>();
                val_24 = val_28.Count;
                if(val_24 >= 1)
            {
                    var val_23 = 0;
                do
            {
                System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>> val_11 = val_28.Item[0];
                System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>> val_12 = new System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>>();
                float val_13 = this.signedPolygonArea(vertices:  val_11);
                val_26 = val_13;
                if(val_26 >= 0f)
            {
                    val_11.Reverse();
            }
            
                val_12.Add(item:  val_11);
                System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>> val_16 = Mapbox.VectorTile.Geometry.UtilGeom.ClipGeometries(geoms:  val_12, geomType:  this.GeometryType, extent:  this._layer.Extent, bufferSize:  -1902910488, scale:  val_13);
                val_27 = val_27;
                if(val_16.Count != 0)
            {
                    if(val_26 >= 0f)
            {
                    val_16.Item[0].Reverse();
            }
            
                val_9.Add(item:  val_16.Item[0]);
            }
            
                val_23 = val_23 + 1;
            }
            while(val_24 != val_23);
            
                val_23 = val_23;
            }
            
                val_28 = val_9;
            }
            else
            {
                    val_24 = this._layer.Extent;
                val_28 = Mapbox.VectorTile.Geometry.UtilGeom.ClipGeometries(geoms:  val_28, geomType:  this.GeometryType, extent:  val_24, bufferSize:  -1902910488, scale:  val_2);
            }
            
            }
            
            val_25 = val_28;
            this._cachedGeometry = val_25;
            this._previousScale = this._scale.HasValue;
            return (System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<T>>>)val_25;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float signedPolygonArea(System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<long>> vertices)
        {
            float val_11;
            var val_12;
            var val_13;
            int val_1 = vertices.Count;
            val_11 = 0f;
            if((val_1 - 1) < 1)
            {
                    return (float)val_11;
            }
            
            var val_12 = 1;
            do
            {
                Mapbox.VectorTile.Geometry.Point2d<System.Int64> val_3 = vertices.Item[1];
                if(vertices != null)
            {
                    Mapbox.VectorTile.Geometry.Point2d<System.Int64> val_4 = vertices.Item[0];
                val_12 = val_4.Y;
                Mapbox.VectorTile.Geometry.Point2d<System.Int64> val_5 = vertices.Item[1];
                val_13 = val_12;
            }
            else
            {
                    Mapbox.VectorTile.Geometry.Point2d<System.Int64> val_6 = 0.Item[0];
                val_12 = val_6.Y;
                Mapbox.VectorTile.Geometry.Point2d<System.Int64> val_7 = 0.Item[1];
                val_13 = val_12;
            }
            
                Mapbox.VectorTile.Geometry.Point2d<System.Int64> val_8 = vertices.Item[0];
                long val_9 = val_3.Y - val_12;
                val_9 = (0 + val_13) * val_9;
                var val_11 = (val_9 < 0) ? (val_9 + 1) : (val_9);
                val_11 = val_11 >> 1;
                val_12 = val_12 + 1;
                val_11 = val_11 + (float)val_11;
            }
            while(val_1 != val_12);
            
            return (float)val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<int> get_Tags()
        {
            return (System.Collections.Generic.List<System.Int32>)this.<Tags>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Tags(System.Collections.Generic.List<int> value)
        {
            this.<Tags>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, object> GetProperties()
        {
            if(((this.<Tags>k__BackingField.Count) & 1) == 0)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
                int val_3 = this.<Tags>k__BackingField.Count;
                if(val_3 < 1)
            {
                    return val_2;
            }
            
                int val_10 = 0;
                do
            {
                val_10 = val_10 + 1;
                val_2.Add(key:  this._layer.<Keys>k__BackingField.Item[this.<Tags>k__BackingField.Item[0]], value:  this._layer.<Values>k__BackingField.Item[this.<Tags>k__BackingField.Item[val_10]]);
                val_10 = val_10 + 1;
            }
            while(val_10 < val_3);
            
                return val_2;
            }
            
            System.Exception val_9 = new System.Exception(message:  System.String.Format(format:  "Layer [{0}]: uneven number of feature tag ids", arg0:  this._layer.<Name>k__BackingField));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object GetValue(string key)
        {
            System.Collections.Generic.List<System.Int32> val_7;
            int val_1 = this._layer.<Keys>k__BackingField.IndexOf(item:  key);
            if(val_1 == 1)
            {
                goto label_3;
            }
            
            val_7 = this.<Tags>k__BackingField;
            int val_2 = val_7.Count;
            if(val_2 < 1)
            {
                    return 0;
            }
            
            label_8:
            if(val_1 == (this.<Tags>k__BackingField.Item[1 - 1]))
            {
                goto label_7;
            }
            
            val_7 = 1 + 1;
            if(1 < val_2)
            {
                goto label_8;
            }
            
            return 0;
            label_7:
            if((this._layer.<Values>k__BackingField) != null)
            {
                    return this._layer.<Values>k__BackingField.Item[this.<Tags>k__BackingField.Item[1]];
            }
            
            return this._layer.<Values>k__BackingField.Item[this.<Tags>k__BackingField.Item[1]];
            label_3:
            System.Exception val_7 = new System.Exception(message:  System.String.Format(format:  "Key [{0}] does not exist", arg0:  key));
        }
    
    }

}
