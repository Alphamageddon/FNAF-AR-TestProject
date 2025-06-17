using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Factories
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TerrainFactoryBase : AbstractTileFactory
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Factories.TerrainStrategies.TerrainStrategy Strategy;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Mapbox.Unity.Map.ElevationLayerProperties _elevationOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected TerrainDataFetcher DataFetcher;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            object val_7;
            System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RawPngRasterTile> val_8;
            val_7 = this;
            if(this.DataFetcher == 0)
            {
                    return;
            }
            
            val_8 = System.Delegate.Remove(source:  this.DataFetcher.DataRecieved, value:  new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RawPngRasterTile>(object:  this, method:  System.Void Mapbox.Unity.MeshGeneration.Factories.TerrainFactoryBase::OnTerrainRecieved(Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Map.RawPngRasterTile pngRasterTile)));
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
            val_7 = System.Delegate.Remove(source:  this.DataFetcher.FetchingError, value:  new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RawPngRasterTile, Mapbox.Map.TileErrorEventArgs>(object:  this, method:  System.Void Mapbox.Unity.MeshGeneration.Factories.TerrainFactoryBase::OnDataError(Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Map.RawPngRasterTile rawTile, Mapbox.Map.TileErrorEventArgs e)));
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
        protected override void OnInitialized()
        {
            System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RawPngRasterTile> val_7;
            System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RawPngRasterTile, Mapbox.Map.TileErrorEventArgs> val_8;
            TerrainDataFetcher val_1 = UnityEngine.ScriptableObject.CreateInstance<TerrainDataFetcher>();
            this.DataFetcher = val_1;
            val_7 = System.Delegate.Combine(a:  val_1.DataRecieved, b:  new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RawPngRasterTile>(object:  this, method:  System.Void Mapbox.Unity.MeshGeneration.Factories.TerrainFactoryBase::OnTerrainRecieved(Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Map.RawPngRasterTile pngRasterTile)));
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(val_7 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_7 == null)
            {
                goto label_7;
            }
            
            label_4:
            if(null != null)
            {
                    val_7 = 0;
            }
            
            label_7:
            val_1.DataRecieved = val_7;
            val_8 = System.Delegate.Combine(a:  this.DataFetcher.FetchingError, b:  new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RawPngRasterTile, Mapbox.Map.TileErrorEventArgs>(object:  this, method:  System.Void Mapbox.Unity.MeshGeneration.Factories.TerrainFactoryBase::OnDataError(Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Map.RawPngRasterTile rawTile, Mapbox.Map.TileErrorEventArgs e)));
            if(this.DataFetcher == null)
            {
                goto label_9;
            }
            
            if(val_8 != null)
            {
                goto label_10;
            }
            
            goto label_13;
            label_9:
            if(val_8 == null)
            {
                goto label_13;
            }
            
            label_10:
            if(null != null)
            {
                    val_8 = 0;
            }
            
            label_13:
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
            
            this._elevationOptions = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnRegistered(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            TerrainDataFetcher val_2;
            if(this.Strategy == null)
            {
                goto label_1;
            }
            
            if(tile == null)
            {
                goto label_2;
            }
            
            tile.HeightDataState = 2;
            val_2 = this.DataFetcher;
            goto label_3;
            label_1:
            tile.HeightDataState = 3;
            return;
            label_2:
            0.HeightDataState = 2;
            val_2 = this.DataFetcher;
            label_3:
            val_2.FetchTerrain(canonicalTileId:  new Mapbox.Map.CanonicalTileId() {Z = tile.<CanonicalTileId>k__BackingField, X = tile.<CanonicalTileId>k__BackingField, Y = -2043397968}, mapid:  this._elevationOptions.sourceOptions.Id, tile:  tile);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnUnregistered(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            if((Contains(item:  tile)) != false)
            {
                    public System.Boolean System.Collections.Generic.HashSet<Mapbox.Unity.MeshGeneration.Data.UnityTile>::Contains(Mapbox.Unity.MeshGeneration.Data.UnityTile item) = public System.Boolean System.Collections.Generic.HashSet<Mapbox.Unity.MeshGeneration.Data.UnityTile>::Remove(Mapbox.Unity.MeshGeneration.Data.UnityTile item);
                bool val_2 = Remove(item:  tile);
            }
            
            if(this.Strategy == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnPostProcess(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            if(this.Strategy == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnTerrainRecieved(Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Map.RawPngRasterTile pngRasterTile)
        {
            System.Byte[] val_9;
            UnityEngine.Object val_10;
            val_9 = pngRasterTile;
            val_10 = tile;
            if(val_10 == 0)
            {
                    return;
            }
            
            bool val_2 = Remove(item:  val_10);
            if(tile._heightDataState == 0)
            {
                    return;
            }
            
            val_9 = val_9.Data;
            val_10.SetHeightData(data:  val_9, heightMultiplier:  this._elevationOptions.requiredOptions.exaggerationFactor, useRelative:  (this._elevationOptions.modificationOptions.useRelativeHeight == true) ? 1 : 0, addCollider:  this._elevationOptions.requiredOptions.addCollider);
            val_10 = val_10.gameObject;
            val_10.name = val_10.name + UnityEngine.Time.frameCount;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDataError(Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Map.RawPngRasterTile rawTile, Mapbox.Map.TileErrorEventArgs e)
        {
            if(tile == 0)
            {
                    return;
            }
            
            bool val_2 = Remove(item:  tile);
            if(tile._heightDataState == 0)
            {
                    return;
            }
            
            tile.HeightDataState = 4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TerrainFactoryBase()
        {
            this._elevationOptions = new Mapbox.Unity.Map.ElevationLayerProperties();
            this = new UnityEngine.ScriptableObject();
        }
    
    }

}
