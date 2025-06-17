using UnityEngine;

namespace Mapbox.Unity.Utilities
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class Conversions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int TileSize = 256;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int EarthRadius = 6378137;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const double InitialResolution = 156543.033928041;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const double OriginShift = 20037508.3427892;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d LatLonToMeters(Mapbox.Utils.Vector2d v)
        {
            return Mapbox.Unity.Utilities.Conversions.LatLonToMeters(lat:  v.x, lon:  v.y);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d StringToLatLon(string s)
        {
            var val_12;
            var val_13;
            object val_14;
            string val_15;
            char[] val_1 = new char[1];
            val_1[0] = ',';
            System.String[] val_2 = s.Split(separator:  val_1);
            if(val_2.Length != 2)
            {
                goto label_5;
            }
            
            double val_7 = 0;
            if((System.Double.TryParse(s:  val_2[0], style:  511, provider:  System.Globalization.NumberFormatInfo.InvariantInfo, result: out  double val_4 = 1.28823406266783E-231)) == false)
            {
                goto label_8;
            }
            
            if((System.Double.TryParse(s:  val_2[1], style:  511, provider:  System.Globalization.NumberFormatInfo.InvariantInfo, result: out  val_7)) == false)
            {
                goto label_12;
            }
            
            return new Mapbox.Utils.Vector2d() {y = val_7};
            label_5:
            val_12 = 1152921519670037360;
            val_13 = new System.ArgumentException(message:  "Wrong number of arguments");
            goto label_13;
            label_8:
            val_14 = val_2;
            val_15 = "Could not convert latitude to double: {0}";
            goto label_14;
            label_12:
            val_14 = val_2;
            val_15 = "Could not convert longitude to double: {0}";
            label_14:
            val_12 = 1152921519670037360;
            val_13 = new System.Exception(message:  System.String.Format(format:  val_15, arg0:  val_14));
            label_13:
            mem[1152921519670172544] = ???;
            mem[1152921519670172552] = ???;
            return new Mapbox.Utils.Vector2d();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d LatLonToMeters(double lat, double lon)
        {
            double val_3 = 90;
            val_3 = lat + val_3;
            val_3 = val_3 * 3.14159265358979;
            val_3 = val_3 / 360;
            double val_4 = 0.0174532925199433;
            val_3 = val_3 / val_4;
            val_3 = val_3 * 20037508.3427892;
            val_4 = val_3 / 180;
            return new Mapbox.Utils.Vector2d() {x = (lon * 20037508.3427892) / 180, y = val_4};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d GeoToWorldPosition(double lat, double lon, Mapbox.Utils.Vector2d refPoint, float scale = 1)
        {
            double val_3 = 90;
            val_3 = lat + val_3;
            val_3 = val_3 * 3.14159265358979;
            val_3 = val_3 / 360;
            double val_4 = 20037508.3427892;
            val_3 = val_3 / 0.0174532925199433;
            double val_5 = 180;
            val_3 = val_3 * val_4;
            val_4 = (lon * val_4) / val_5;
            val_5 = val_3 / val_5;
            double val_2 = val_4 - refPoint.x;
            val_5 = val_5 - refPoint.y;
            val_2 = val_2 * (double)scale;
            val_5 = val_5 * (double)scale;
            return new Mapbox.Utils.Vector2d() {x = val_2, y = val_5};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d GeoToWorldPosition(Mapbox.Utils.Vector2d latLong, Mapbox.Utils.Vector2d refPoint, float scale = 1)
        {
            return Mapbox.Unity.Utilities.Conversions.GeoToWorldPosition(lat:  latLong.x, lon:  latLong.y, refPoint:  new Mapbox.Utils.Vector2d() {x = refPoint.x, y = refPoint.y}, scale:  scale);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Vector3 GeoToWorldGlobePosition(double lat, double lon, float radius)
        {
            double val_4 = lon;
            double val_3 = lat;
            val_3 = val_3 * 0.0174532923847437;
            val_4 = val_4 * 0.0174532923847437;
            val_4 = (val_3 * (double)radius) * val_4;
            float val_5 = val_3;
            val_5 = val_5 * (double)radius;
            radius = (val_3 * (double)radius) * val_4;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Vector3 GeoToWorldGlobePosition(Mapbox.Utils.Vector2d latLong, float radius)
        {
            return Mapbox.Unity.Utilities.Conversions.GeoToWorldGlobePosition(lat:  latLong.x, lon:  latLong.y, radius:  radius);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d GeoFromGlobePosition(UnityEngine.Vector3 point, float radius)
        {
            float val_3 = 57.29578f;
            val_3 = point.z * val_3;
            return new Mapbox.Utils.Vector2d() {x = (double)(point.y / radius) * val_3, y = (double)val_3};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d MetersToLatLon(Mapbox.Utils.Vector2d m)
        {
            double val_4 = m.y;
            double val_3 = m.x;
            double val_2 = 20037508.3427892;
            val_2 = val_4 / val_2;
            val_3 = (val_3 / val_2) * 180;
            val_4 = val_2 * 180;
            double val_5 = 3.14159265358979;
            val_5 = val_4 * val_5;
            val_5 = val_5 / 180;
            val_5 = val_5 + val_5;
            val_5 = val_5 + (-1.5707963267949);
            val_5 = val_5 * 57.2957795130823;
            return new Mapbox.Utils.Vector2d() {x = val_5, y = val_3};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Vector2 MetersToTile(Mapbox.Utils.Vector2d m, int zoom)
        {
            double val_1 = Mapbox.Unity.Utilities.Conversions.Resolution(zoom:  zoom);
            double val_3 = 20037508.3427892;
            double val_2 = m.x + val_3;
            val_3 = val_3 - m.y;
            val_2 = val_2 / val_1;
            val_3 = val_3 / val_1;
            return Mapbox.Unity.Utilities.Conversions.PixelsToTile(p:  new Mapbox.Utils.Vector2d() {x = val_2, y = val_3});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.RectD TileBounds(UnityEngine.Vector2 tileCoordinate, int zoom)
        {
            tileCoordinate.x = tileCoordinate.x * 256f;
            tileCoordinate.y = tileCoordinate.y * 256f;
            double val_10 = (double)tileCoordinate.y;
            double val_1 = Mapbox.Unity.Utilities.Conversions.Resolution(zoom:  zoom);
            float val_9 = 1f;
            val_1 = val_1 * val_10;
            float val_3 = tileCoordinate.x + val_9;
            val_9 = tileCoordinate.y + val_9;
            val_3 = val_3 * 256f;
            val_9 = val_9 * 256f;
            val_10 = val_1 + (-20037508.3427892);
            double val_5 = Mapbox.Unity.Utilities.Conversions.Resolution(zoom:  zoom);
            double val_6 = val_5 * (double)val_3;
            val_5 = val_5 * (double)val_9;
            val_0.<Center>k__BackingField.x = 0;
            val_0.<Center>k__BackingField.y = 0;
            val_0.<Size>k__BackingField.x = 0;
            val_0.<Size>k__BackingField.y = 0;
            val_0.<Max>k__BackingField.x = 0;
            val_0.<Max>k__BackingField.y = 0;
            val_6 = val_6 + (-20037508.3427892);
            val_5 = val_5 + (-20037508.3427892);
            val_0.<Min>k__BackingField.x = 0;
            val_0.<Min>k__BackingField.y = 0;
            double val_7 = val_6 - ((val_1 * (double)tileCoordinate.x) + (-20037508.3427892));
            double val_8 = val_10 - val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.RectD TileBounds(Mapbox.Map.UnwrappedTileId unwrappedTileId)
        {
            int val_2 = unwrappedTileId.Y << 8;
            int val_3 = (unwrappedTileId.Z >> 32) << 8;
            double val_13 = (double)val_3;
            double val_4 = Mapbox.Unity.Utilities.Conversions.Resolution(zoom:  unwrappedTileId.Z);
            val_4 = val_4 * (double)val_2;
            val_13 = (val_4 * val_13) + (-20037508.3427892);
            double val_9 = Mapbox.Unity.Utilities.Conversions.Resolution(zoom:  unwrappedTileId.Z);
            double val_10 = val_9 * ((double)val_3 + 256);
            val_9 = val_9 * ((double)val_2 + 256);
            val_0.<Center>k__BackingField.x = 0;
            val_0.<Center>k__BackingField.y = 0;
            val_0.<Size>k__BackingField.x = 0;
            val_0.<Size>k__BackingField.y = 0;
            val_0.<Max>k__BackingField.x = 0;
            val_0.<Max>k__BackingField.y = 0;
            val_10 = val_10 + (-20037508.3427892);
            val_9 = val_9 + (-20037508.3427892);
            val_0.<Min>k__BackingField.x = 0;
            val_0.<Min>k__BackingField.y = 0;
            double val_11 = val_10 - val_13;
            double val_12 = (val_4 + (-20037508.3427892)) - val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Map.UnwrappedTileId LatitudeLongitudeToTileId(double latitude, double longitude, int zoom)
        {
            double val_5 = 1;
            double val_7 = 180;
            double val_4 = 360;
            val_4 = (longitude + val_7) / val_4;
            val_5 = val_4 * val_5;
            double val_3 = (latitude * 3.14159265358979) / val_7;
            float val_6 = val_3;
            val_6 = 1 / val_6;
            val_6 = val_3 + val_6;
            double val_8 = 1;
            val_7 = val_6 / 3.14159265358979;
            val_7 = 1 - val_7;
            val_7 = val_7 * 0.5;
            val_8 = val_8 * val_7;
            return new Mapbox.Map.UnwrappedTileId();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Vector2 LatitudeLongitudeToVectorTilePosition(Mapbox.Utils.Vector2d coordinate, int tileZoom, ulong layerExtent = 4096)
        {
            float val_4;
            float val_5;
            float val_6;
            float val_7;
            Mapbox.Map.UnwrappedTileId val_1 = Mapbox.Unity.Utilities.Conversions.LatitudeLongitudeToTileId(latitude:  coordinate.x, longitude:  coordinate.y, zoom:  tileZoom);
            Mapbox.Utils.Vector2d val_2 = Mapbox.Unity.Utilities.Conversions.LatLonToMeters(lat:  coordinate.x, lon:  coordinate.y);
            val_1.Y = val_1.Y & 4294967295;
            Mapbox.Utils.RectD val_3 = Mapbox.Unity.Utilities.Conversions.TileBounds(unwrappedTileId:  new Mapbox.Map.UnwrappedTileId() {Z = val_1.Z, X = val_1.X, Y = val_1.Y});
            float val_9 = val_4;
            float val_10 = val_6;
            val_9 = val_2.y - val_9;
            val_10 = val_2.x - val_10;
            val_9 = val_9 / val_7;
            val_10 = val_10 / val_5;
            val_9 = val_9 * (double)layerExtent;
            float val_11 = (float)val_10;
            val_9 = (double)layerExtent - val_9;
            val_11 = (float)(double)layerExtent * val_11;
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_11, y:  (float)val_9);
            return new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Vector2 LatitudeLongitudeToUnityTilePosition(Mapbox.Utils.Vector2d coordinate, Mapbox.Unity.MeshGeneration.Data.UnityTile tile, ulong layerExtent = 4096)
        {
            int val_4;
            if(tile != null)
            {
                    val_4 = tile.CurrentZoom;
                return Mapbox.Unity.Utilities.Conversions.LatitudeLongitudeToUnityTilePosition(coordinate:  new Mapbox.Utils.Vector2d() {x = coordinate.x, y = coordinate.y}, tileZoom:  val_4 = 0.CurrentZoom, tileScale:  tile.TileScale, layerExtent:  layerExtent);
            }
            
            return Mapbox.Unity.Utilities.Conversions.LatitudeLongitudeToUnityTilePosition(coordinate:  new Mapbox.Utils.Vector2d() {x = coordinate.x, y = coordinate.y}, tileZoom:  val_4, tileScale:  tile.TileScale, layerExtent:  layerExtent);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Vector2 LatitudeLongitudeToUnityTilePosition(Mapbox.Utils.Vector2d coordinate, int tileZoom, float tileScale, ulong layerExtent = 4096)
        {
            float val_3;
            float val_4;
            Mapbox.Map.UnwrappedTileId val_1 = Mapbox.Unity.Utilities.Conversions.LatitudeLongitudeToTileId(latitude:  coordinate.x, longitude:  coordinate.y, zoom:  tileZoom);
            val_1.Y = val_1.Y & 4294967295;
            Mapbox.Utils.RectD val_2 = Mapbox.Unity.Utilities.Conversions.TileBounds(unwrappedTileId:  new Mapbox.Map.UnwrappedTileId() {Z = val_1.Z, X = val_1.X, Y = val_1.Y});
            UnityEngine.Vector2 val_5 = Mapbox.Unity.Utilities.Conversions.LatitudeLongitudeToVectorTilePosition(coordinate:  new Mapbox.Utils.Vector2d() {x = coordinate.x, y = coordinate.y}, tileZoom:  tileZoom, layerExtent:  layerExtent);
            val_5.y = (float)(double)layerExtent - val_5.y;
            val_5.x = val_5.x / (float)(double)layerExtent;
            val_5.y = val_5.y / (float)(double)layerExtent;
            double val_8 = 0.5;
            double val_9 = (double)val_5.x;
            double val_10 = (double)val_5.y;
            val_8 = val_4 * val_8;
            val_9 = val_3 * val_9;
            val_10 = val_4 * val_10;
            val_9 = val_9 - (val_3 * val_8);
            val_10 = val_10 - val_8;
            float val_11 = (float)val_9;
            float val_12 = (float)val_10;
            val_11 = val_11 * tileScale;
            val_12 = val_12 * tileScale;
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_11, y:  val_12);
            return new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double TileXToNWLongitude(int x, int zoom)
        {
            double val_1 = 1;
            val_1 = (double)x / val_1;
            val_1 = val_1 * 360;
            val_1 = val_1 + (-180);
            return (double)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double TileYToNWLatitude(int y, int zoom)
        {
            double val_2 = 1;
            val_2 = ((double)y << 1) / val_2;
            val_2 = 1 - val_2;
            val_2 = val_2 * 3.14159265358979;
            val_2 = val_2 * 180;
            val_2 = val_2 / 3.14159265358979;
            return (double)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2dBounds TileIdToBounds(int x, int y, int zoom)
        {
            Mapbox.Utils.Vector2dBounds val_0;
            double val_1 = Mapbox.Unity.Utilities.Conversions.TileYToNWLatitude(y:  y, zoom:  zoom);
            double val_3 = Mapbox.Unity.Utilities.Conversions.TileXToNWLongitude(x:  x + 1, zoom:  zoom);
            double val_5 = Mapbox.Unity.Utilities.Conversions.TileYToNWLatitude(y:  y + 1, zoom:  zoom);
            double val_6 = Mapbox.Unity.Utilities.Conversions.TileXToNWLongitude(x:  x, zoom:  zoom);
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d TileIdToCenterLatitudeLongitude(int x, int y, int zoom)
        {
            Mapbox.Utils.Vector2dBounds val_1 = Mapbox.Unity.Utilities.Conversions.TileIdToBounds(x:  x, y:  y, zoom:  zoom);
            double val_2 = D1 + D3;
            double val_3 = D0 + D2;
            val_2 = val_2 * 0.5;
            val_3 = val_3 * 0.5;
            return new Mapbox.Utils.Vector2d() {x = val_3, y = val_2};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d TileIdToCenterWebMercator(int x, int y, int zoom)
        {
            double val_3 = 1;
            double val_1 = (double)y;
            double val_2 = 0.5;
            val_1 = val_1 + val_2;
            val_2 = (double)x + val_2;
            val_1 = val_1 / val_3;
            val_1 = val_1 * (-2);
            val_3 = val_2 / val_3;
            val_3 = val_3 + val_3;
            val_1 = val_1 + 1;
            val_3 = val_3 + (-1);
            val_1 = val_1 * 20037508.3427892;
            val_3 = val_3 * 20037508.3427892;
            return new Mapbox.Utils.Vector2d() {x = val_3, y = val_1};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float GetTileScaleInMeters(float latitude, int zoom)
        {
            float val_2 = 0.01745329f;
            val_2 = latitude * val_2;
            int val_1 = zoom + 8;
            double val_4 = 1;
            double val_3 = 40075016.685578;
            val_3 = (double)val_2 * val_3;
            val_4 = val_3 / val_4;
            return (float)(float)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float GetTileScaleInDegrees(float latitude, int zoom)
        {
            int val_1 = zoom + 8;
            double val_2 = 1;
            val_2 = 360 / val_2;
            return (float)(float)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float GetRelativeHeightFromColor(UnityEngine.Color color, float relativeScale)
        {
            color.r = color.r * 255f;
            color.g = color.g * 255f;
            color.r = color.r * 256f;
            color.b = color.b * 255f;
            color.g = color.g * 256f;
            color.r = color.r * 256f;
            color.r = color.g + color.r;
            color.r = color.b + color.r;
            double val_1 = (double)color.r;
            val_1 = val_1 * 0.1;
            val_1 = val_1 + (-10000);
            float val_2 = (float)val_1;
            val_2 = val_2 * relativeScale;
            return (float)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float GetAbsoluteHeightFromColor(UnityEngine.Color color)
        {
            color.r = color.r * 255f;
            color.g = color.g * 255f;
            color.r = color.r * 256f;
            color.b = color.b * 255f;
            color.g = color.g * 256f;
            color.r = color.r * 256f;
            color.r = color.g + color.r;
            color.r = color.b + color.r;
            double val_1 = (double)color.r;
            val_1 = val_1 * 0.1;
            val_1 = val_1 + (-10000);
            return (float)(float)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float GetAbsoluteHeightFromColor32(UnityEngine.Color32 color)
        {
            double val_2 = 0.1;
            val_2 = ((double)color.r & 65280) * val_2;
            val_2 = val_2 + (-10000);
            return (float)(float)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float GetAbsoluteHeightFromColor(float r, float g, float b)
        {
            r = r * 256f;
            g = g * 256f;
            r = r * 256f;
            r = r + g;
            r = r + b;
            double val_1 = (double)r;
            val_1 = val_1 * 0.1;
            val_1 = val_1 + (-10000);
            return (float)(float)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static double Resolution(int zoom)
        {
            double val_1 = 1;
            val_1 = 156543.033928041 / val_1;
            return (double)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Mapbox.Utils.Vector2d PixelsToMeters(Mapbox.Utils.Vector2d p, int zoom)
        {
            double val_1 = Mapbox.Unity.Utilities.Conversions.Resolution(zoom:  zoom);
            double val_4 = -20037508.3427892;
            val_1 = (p.x * val_1) + val_4;
            val_4 = (p.y * val_1) + val_4;
            return new Mapbox.Utils.Vector2d() {x = val_1, y = -val_4};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Mapbox.Utils.Vector2d MetersToPixels(Mapbox.Utils.Vector2d m, int zoom)
        {
            double val_1 = Mapbox.Unity.Utilities.Conversions.Resolution(zoom:  zoom);
            double val_3 = 20037508.3427892;
            double val_2 = m.x + val_3;
            val_3 = val_3 - m.y;
            val_2 = val_2 / val_1;
            val_3 = val_3 / val_1;
            return new Mapbox.Utils.Vector2d() {x = val_2, y = val_3};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.Vector2 PixelsToTile(Mapbox.Utils.Vector2d p)
        {
            double val_4 = 0.00390625;
            double val_1 = p.x * val_4;
            val_4 = p.y * val_4;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  5.295309E+07f, y:  (float)W9 - 1);
            return new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        }
    
    }

}
