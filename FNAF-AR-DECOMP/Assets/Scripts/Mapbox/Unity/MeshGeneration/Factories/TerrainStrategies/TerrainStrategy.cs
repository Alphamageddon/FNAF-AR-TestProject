using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Factories.TerrainStrategies
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TerrainStrategy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Mapbox.Unity.Map.ElevationLayerProperties _elevationOptions;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void Initialize(Mapbox.Unity.Map.ElevationLayerProperties elOptions)
        {
            this._elevationOptions = elOptions;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void RegisterTile(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void PostProcessTile(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void UnregisterTile(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void DataErrorOccurred(Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Map.TileErrorEventArgs e)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TerrainStrategy()
        {
            this._elevationOptions = new Mapbox.Unity.Map.ElevationLayerProperties();
        }
    
    }

}
