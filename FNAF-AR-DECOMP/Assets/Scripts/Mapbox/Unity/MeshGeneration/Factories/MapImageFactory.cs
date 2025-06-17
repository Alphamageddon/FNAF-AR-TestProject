using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Factories
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MapImageFactory : AbstractTileFactory
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.ImageryLayerProperties _properties;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected ImageDataFetcher DataFetcher;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string MapId { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_MapId()
        {
            if(this._properties.sourceOptions != null)
            {
                    return this._properties.sourceOptions.Id;
            }
            
            return this._properties.sourceOptions.Id;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_MapId(string value)
        {
            this._properties.sourceOptions.Id = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnDestroy()
        {
            object val_7;
            System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RasterTile> val_8;
            val_7 = this;
            if(this.DataFetcher == 0)
            {
                    return;
            }
            
            val_8 = System.Delegate.Remove(source:  this.DataFetcher.DataRecieved, value:  new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RasterTile>(object:  this, method:  System.Void Mapbox.Unity.MeshGeneration.Factories.MapImageFactory::OnImageRecieved(Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Map.RasterTile rasterTile)));
            if(this.DataFetcher == null)
            {
                goto label_5;
            }
            
            if(val_8 != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            if(val_8 == null)
            {
                goto label_9;
            }
            
            label_6:
            if(null != null)
            {
                    val_8 = 0;
            }
            
            label_9:
            this.DataFetcher.DataRecieved = val_8;
            val_7 = System.Delegate.Remove(source:  this.DataFetcher.FetchingError, value:  new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RasterTile, Mapbox.Map.TileErrorEventArgs>(object:  this, method:  typeof(Mapbox.Unity.MeshGeneration.Factories.MapImageFactory).__il2cppRuntimeField_220));
            if(this.DataFetcher == null)
            {
                goto label_11;
            }
            
            if(val_7 != null)
            {
                goto label_12;
            }
            
            goto label_15;
            label_11:
            if(val_7 == null)
            {
                goto label_15;
            }
            
            label_12:
            if(null != null)
            {
                    val_7 = 0;
            }
            
            label_15:
            this.DataFetcher.FetchingError = val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnImageRecieved(Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Map.RasterTile rasterTile)
        {
            if(tile == 0)
            {
                    return;
            }
            
            if(tile._rasterDataState == 0)
            {
                    return;
            }
            
            bool val_2 = Remove(item:  tile);
            tile.SetRasterData(data:  rasterTile.Data, useMipMap:  (this._properties.rasterOptions.useMipMap == true) ? 1 : 0, useCompression:  this._properties.rasterOptions.useCompression);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnDataError(Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Map.RasterTile rasterTile, Mapbox.Map.TileErrorEventArgs e)
        {
            var val_9;
            UnityEngine.Object val_10;
            val_9 = e;
            val_10 = tile;
            if(val_10 == 0)
            {
                    return;
            }
            
            if(tile._rasterDataState == 0)
            {
                    return;
            }
            
            val_10.RasterDataState = 4;
            bool val_2 = Remove(item:  val_10);
            val_9 = ???;
            val_10 = ???;
            goto typeof(Mapbox.Unity.MeshGeneration.Factories.MapImageFactory).__il2cppRuntimeField_1F8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnInitialized()
        {
            System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RasterTile> val_7;
            System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RasterTile, Mapbox.Map.TileErrorEventArgs> val_8;
            ImageDataFetcher val_1 = UnityEngine.ScriptableObject.CreateInstance<ImageDataFetcher>();
            this.DataFetcher = val_1;
            val_7 = System.Delegate.Combine(a:  val_1.DataRecieved, b:  new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RasterTile>(object:  this, method:  System.Void Mapbox.Unity.MeshGeneration.Factories.MapImageFactory::OnImageRecieved(Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Map.RasterTile rasterTile)));
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(val_7 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_7 == null)
            {
                goto label_6;
            }
            
            label_3:
            if(null != null)
            {
                    val_7 = 0;
            }
            
            label_6:
            val_1.DataRecieved = val_7;
            val_8 = System.Delegate.Combine(a:  this.DataFetcher.FetchingError, b:  new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RasterTile, Mapbox.Map.TileErrorEventArgs>(object:  this, method:  typeof(Mapbox.Unity.MeshGeneration.Factories.MapImageFactory).__il2cppRuntimeField_220));
            if(this.DataFetcher == null)
            {
                goto label_8;
            }
            
            if(val_8 != null)
            {
                goto label_9;
            }
            
            goto label_12;
            label_8:
            if(val_8 == null)
            {
                goto label_12;
            }
            
            label_9:
            if(null != null)
            {
                    val_8 = 0;
            }
            
            label_12:
            this.DataFetcher.FetchingError = val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetOptions(Mapbox.Unity.Map.LayerProperties options)
        {
            Mapbox.Unity.Map.LayerProperties val_3 = options;
            if(val_3 != null)
            {
                    val_3 = 0;
            }
            
            this._properties = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnRegistered(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            if(this._properties.sourceType == 7)
            {
                    tile.RasterDataState = 1;
                return;
            }
            
            tile.RasterDataState = 2;
            this.DataFetcher.FetchImage(canonicalTileId:  new Mapbox.Map.CanonicalTileId() {Z = tile.<CanonicalTileId>k__BackingField, X = tile.<CanonicalTileId>k__BackingField, Y = X22}, mapid:  this.MapId, tile:  tile, useRetina:  (this._properties.rasterOptions.useRetina == true) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnErrorOccurred(Mapbox.Map.TileErrorEventArgs e)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnUnregistered(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            if((Contains(item:  tile)) == false)
            {
                    return;
            }
            
            bool val_2 = this.Remove(item:  tile);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnPostProcess(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapImageFactory()
        {
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
