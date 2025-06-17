using UnityEngine;

namespace Mapbox.VectorTile.Geometry
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public struct Point2d<T>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T X;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T Y;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Point2d<T>(T x, T y)
        {
            mem[1152921519891329296] = x;
            mem[1152921519891329304] = y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.VectorTile.Geometry.LatLng ToLngLat(ulong z, ulong x, ulong y, ulong extent, bool checkLatLngMax = False)
        {
            bool val_1 = checkLatLngMax;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
        
        }
    
    }

}
