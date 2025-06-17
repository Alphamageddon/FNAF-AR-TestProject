using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IMapReadable
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Mapbox.Utils.Vector2d CenterMercator { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float WorldRelativeScale { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Mapbox.Utils.Vector2d CenterLatitudeLongitude { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float Zoom { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int InitialZoom { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int AbsoluteZoom { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract UnityEngine.Transform Root { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float UnityTileSize { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract System.Collections.Generic.HashSet<Mapbox.Map.UnwrappedTileId> CurrentExtent { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Mapbox.Utils.Vector2d get_CenterMercator(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float get_WorldRelativeScale(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Mapbox.Utils.Vector2d get_CenterLatitudeLongitude(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float get_Zoom(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int get_InitialZoom(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int get_AbsoluteZoom(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract UnityEngine.Transform get_Root(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float get_UnityTileSize(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract System.Collections.Generic.HashSet<Mapbox.Map.UnwrappedTileId> get_CurrentExtent(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void add_OnInitialized(System.Action value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void remove_OnInitialized(System.Action value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void add_OnUpdated(System.Action value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void remove_OnUpdated(System.Action value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Mapbox.Utils.Vector2d WorldToGeoPosition(UnityEngine.Vector3 realworldPoint); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract UnityEngine.Vector3 GeoToWorldPosition(Mapbox.Utils.Vector2d latitudeLongitude, bool queryHeight = True); // 0
    
    }

}
