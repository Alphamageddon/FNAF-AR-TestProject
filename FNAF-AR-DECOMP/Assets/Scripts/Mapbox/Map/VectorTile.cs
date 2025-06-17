using UnityEngine;

namespace Mapbox.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class VectorTile : Tile, IDisposable
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.VectorTile.VectorTile data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isStyleOptimized;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _optimizedStyleId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _modifiedDate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool isDisposed;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.VectorTile.VectorTile Data { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GeoJson { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.VectorTile.VectorTile get_Data()
        {
            return (Mapbox.VectorTile.VectorTile)this.data;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VectorTile()
        {
            this._isStyleOptimized = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VectorTile(string styleId, string modifiedDate)
        {
            if((System.String.IsNullOrEmpty(value:  styleId)) != true)
            {
                    if((System.String.IsNullOrEmpty(value:  modifiedDate)) == false)
            {
                goto label_2;
            }
            
            }
            
            UnityEngine.Debug.LogWarning(message:  "Style Id or Modified Time cannot be empty for style optimized tilesets. Switching to regular tilesets!");
            this._isStyleOptimized = false;
            return;
            label_2:
            this._isStyleOptimized = true;
            this._optimizedStyleId = styleId;
            this._modifiedDate = modifiedDate;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Dispose()
        {
            if((this.isDisposed != true) && (this.data != null))
            {
                    this.data = 0;
            }
            
            System.GC.SuppressFinalize(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Dispose(bool disposeManagedResources)
        {
            if(this.isDisposed == true)
            {
                    return;
            }
            
            if(disposeManagedResources == false)
            {
                    return;
            }
            
            if(this.data == null)
            {
                    return;
            }
            
            this.data = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_GeoJson()
        {
            return (string)Mapbox.VectorTile.ExtensionMethods.VectorTileExtensions.ToGeoJson(tile:  this.data, zoom:  (long)(long)(int)(W21), tileColumn:  X21 >> 32, tileRow:  this, clipBuffer:  new System.Nullable<System.UInt32>() {HasValue = false});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.ObjectModel.ReadOnlyCollection<string> LayerNames()
        {
            if(this.data != null)
            {
                    return this.data.LayerNames();
            }
            
            return this.data.LayerNames();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.VectorTile.VectorTileLayer GetLayer(string layerName)
        {
            if(this.data != null)
            {
                    return this.data.GetLayer(layerName:  layerName);
            }
            
            return this.data.GetLayer(layerName:  layerName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override Mapbox.Map.TileResource MakeTileResource(string mapId)
        {
            if(this._isStyleOptimized == false)
            {
                    return Mapbox.Map.TileResource.MakeVector(id:  new Mapbox.Map.CanonicalTileId() {Z = -1793184592, X = 268435459, Y = X9}, mapId:  mapId);
            }
            
            return Mapbox.Map.TileResource.MakeStyleOptimizedVector(id:  new Mapbox.Map.CanonicalTileId() {Z = -1793184592, X = 268435459, Y = X9}, mapId:  mapId, optimizedStyleId:  this._optimizedStyleId, modifiedDate:  this._modifiedDate);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override bool ParseTileData(byte[] data)
        {
            new Mapbox.VectorTile.VectorTile() = new Mapbox.VectorTile.VectorTile(data:  Mapbox.Utils.Compression.Decompress(buffer:  data), validate:  true);
            this.data = new Mapbox.VectorTile.VectorTile();
            return true;
        }
    
    }

}
