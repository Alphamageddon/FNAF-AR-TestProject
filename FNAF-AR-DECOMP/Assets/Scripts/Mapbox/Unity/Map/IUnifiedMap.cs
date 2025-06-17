using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IUnifiedMap
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void UpdateMap(Mapbox.Utils.Vector2d latLon, float zoom); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ResetMap(); // 0
    
    }

}
