using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IUnifiedTileProvider
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void add_OnTileAdded(System.Action<Mapbox.Map.UnwrappedTileId> value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void remove_OnTileAdded(System.Action<Mapbox.Map.UnwrappedTileId> value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void add_OnTileRemoved(System.Action<Mapbox.Map.UnwrappedTileId> value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void remove_OnTileRemoved(System.Action<Mapbox.Map.UnwrappedTileId> value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Initialize(Mapbox.Unity.Map.IUnifiedMap map); // 0
    
    }

}
