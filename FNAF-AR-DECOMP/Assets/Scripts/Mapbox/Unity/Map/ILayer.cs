using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ILayer
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Mapbox.Unity.Map.MapLayerType LayerType { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsLayerActive { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string LayerSource { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Mapbox.Unity.Map.MapLayerType get_LayerType(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_IsLayerActive(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string get_LayerSource(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetLayerSource(string source); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Initialize(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Initialize(Mapbox.Unity.Map.LayerProperties properties); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Update(Mapbox.Unity.Map.LayerProperties properties); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Remove(); // 0
    
    }

}
