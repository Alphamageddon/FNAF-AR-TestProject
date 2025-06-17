using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ITileProvider
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Mapbox.Unity.Map.ITileProviderOptions Options { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void add_ExtentChanged(System.EventHandler<Mapbox.Unity.Map.ExtentArgs> value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void remove_ExtentChanged(System.EventHandler<Mapbox.Unity.Map.ExtentArgs> value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Mapbox.Unity.Map.ITileProviderOptions get_Options(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Initialize(Mapbox.Unity.Map.IMap map); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetOptions(Mapbox.Unity.Map.ITileProviderOptions options); // 0
    
    }

}
