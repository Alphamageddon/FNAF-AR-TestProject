using UnityEngine;

namespace Mapbox.Unity.Utilities
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class VectorExtensions
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Vector3 ToVector3xz(UnityEngine.Vector2 v)
        {
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Vector3 ToVector3xz(Mapbox.Utils.Vector2d v)
        {
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Vector2 ToVector2xz(UnityEngine.Vector3 v)
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  v.x, y:  v.z);
            return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d ToVector2d(UnityEngine.Vector3 v)
        {
            return new Mapbox.Utils.Vector2d() {x = (double)v.x, y = (double)v.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void MoveToGeocoordinate(UnityEngine.Transform t, double lat, double lng, Mapbox.Utils.Vector2d refPoint, float scale = 1)
        {
            Mapbox.Utils.Vector2d val_1 = Mapbox.Unity.Utilities.Conversions.GeoToWorldPosition(lat:  lat, lon:  lng, refPoint:  new Mapbox.Utils.Vector2d() {x = refPoint.x, y = refPoint.y}, scale:  scale);
            UnityEngine.Vector3 val_2 = Mapbox.Unity.Utilities.VectorExtensions.ToVector3xz(v:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y});
            t.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void MoveToGeocoordinate(UnityEngine.Transform t, Mapbox.Utils.Vector2d latLon, Mapbox.Utils.Vector2d refPoint, float scale = 1)
        {
            Mapbox.Unity.Utilities.VectorExtensions.MoveToGeocoordinate(t:  t, lat:  latLon.x, lng:  latLon.y, refPoint:  new Mapbox.Utils.Vector2d() {x = refPoint.x, y = refPoint.y}, scale:  scale);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Vector3 AsUnityPosition(UnityEngine.Vector2 latLon, Mapbox.Utils.Vector2d refPoint, float scale = 1)
        {
            Mapbox.Utils.Vector2d val_1 = Mapbox.Unity.Utilities.Conversions.GeoToWorldPosition(lat:  (double)latLon.x, lon:  (double)latLon.y, refPoint:  new Mapbox.Utils.Vector2d() {x = refPoint.x, y = refPoint.y}, scale:  scale);
            return Mapbox.Unity.Utilities.VectorExtensions.ToVector3xz(v:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d GetGeoPosition(UnityEngine.Transform t, Mapbox.Utils.Vector2d refPoint, float scale = 1)
        {
            UnityEngine.Vector3 val_1 = t.position;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  scale);
            double val_3 = (double)val_2.x;
            double val_4 = (double)val_2.z;
            val_3 = refPoint.x + val_3;
            val_4 = refPoint.y + val_4;
            return Mapbox.Unity.Utilities.Conversions.MetersToLatLon(m:  new Mapbox.Utils.Vector2d() {x = val_3, y = val_4});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d GetGeoPosition(UnityEngine.Vector3 position, Mapbox.Utils.Vector2d refPoint, float scale = 1)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, d:  scale);
            double val_2 = (double)val_1.x;
            double val_3 = (double)val_1.z;
            val_2 = refPoint.x + val_2;
            val_3 = refPoint.y + val_3;
            return Mapbox.Unity.Utilities.Conversions.MetersToLatLon(m:  new Mapbox.Utils.Vector2d() {x = val_2, y = val_3});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d GetGeoPosition(UnityEngine.Vector2 position, Mapbox.Utils.Vector2d refPoint, float scale = 1)
        {
            Mapbox.Utils.Vector2d val_1 = Mapbox.Unity.Utilities.VectorExtensions.GetGeoPosition(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, refPoint:  new Mapbox.Utils.Vector2d() {x = refPoint.x, y = refPoint.y}, scale:  scale);
            return new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y};
        }
    
    }

}
