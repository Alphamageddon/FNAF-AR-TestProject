using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Interfaces
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class LayerVisualizerBase : ScriptableObject
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Active;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string Key { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string get_Key(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_Key(string value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Create(Mapbox.VectorTile.VectorTileLayer layer, Mapbox.Unity.MeshGeneration.Data.UnityTile tile, System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase> callback); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void Initialize()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UnregisterTile(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            goto typeof(Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase).__il2cppRuntimeField_1A8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void OnUnregisterTile(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected LayerVisualizerBase()
        {
            this.Active = true;
        }
    
    }

}
