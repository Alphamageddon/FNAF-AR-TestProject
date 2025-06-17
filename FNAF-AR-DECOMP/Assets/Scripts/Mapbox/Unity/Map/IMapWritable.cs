using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IMapWritable
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetCenterMercator(Mapbox.Utils.Vector2d centerMercator); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetCenterLatitudeLongitude(Mapbox.Utils.Vector2d centerLatitudeLongitude); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetZoom(float zoom); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetWorldRelativeScale(float scale); // 0
    
    }

}
