using UnityEngine;

namespace Mapbox.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class TileCover
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.HashSet<Mapbox.Map.CanonicalTileId> Get(Mapbox.Utils.Vector2dBounds bounds, int zoom)
        {
            double val_17;
            var val_18;
            System.Collections.Generic.HashSet<Mapbox.Map.CanonicalTileId> val_1 = new System.Collections.Generic.HashSet<Mapbox.Map.CanonicalTileId>();
            if(((-1798173888) & 1) != 0)
            {
                    return val_1;
            }
            
            val_17 = 85.0511;
            if((???.South) > val_17)
            {
                    return val_1;
            }
            
            if((???.South) < 0)
            {
                    return val_1;
            }
            
            double val_5 = System.Math.Max(val1:  ???.South, val2:  -85.0511);
            Mapbox.Utils.Vector2d val_6 = new Mapbox.Utils.Vector2d(x:  val_5, y:  val_5);
            Mapbox.Utils.Vector2d val_10 = new Mapbox.Utils.Vector2d(x:  System.Math.Min(val1:  ???.South, val2:  val_17), y:  ???.West);
            Mapbox.Utils.Vector2dBounds val_11 = Mapbox.Utils.Vector2dBounds.FromCoordinates(a:  new Mapbox.Utils.Vector2d() {x = val_6.x, y = val_6.y}, b:  new Mapbox.Utils.Vector2d() {x = val_10.x, y = val_10.y});
            val_17 = val_10.x;
            Mapbox.Map.UnwrappedTileId val_12 = Mapbox.Map.TileCover.CoordinateToTileId(coord:  new Mapbox.Utils.Vector2d() {x = val_6.x, y = val_6.y}, zoom:  -1798129728);
            Mapbox.Map.UnwrappedTileId val_13 = Mapbox.Map.TileCover.CoordinateToTileId(coord:  new Mapbox.Utils.Vector2d() {x = val_17, y = val_10.y}, zoom:  -1798129728);
            val_18 = val_12.Z >> 32;
            int val_14 = val_13.Z >> 32;
            if(val_18 > val_14)
            {
                    return val_1;
            }
            
            do
            {
                if(val_13.Y <= val_12.Y)
            {
                    int val_16 = val_13.Y;
                do
            {
                bool val_15 = val_1.Add(item:  new Mapbox.Map.CanonicalTileId());
                val_16 = val_16 + 1;
            }
            while(val_16 <= val_12.Y);
            
            }
            
                val_18 = val_18 + 1;
            }
            while(val_18 <= val_14);
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.HashSet<Mapbox.Map.UnwrappedTileId> GetWithWebMerc(Mapbox.Utils.Vector2dBounds bounds, int zoom)
        {
            var val_16;
            var val_17;
            int val_18;
            var val_19;
            val_16 = 1152921519988722864;
            System.Collections.Generic.HashSet<Mapbox.Map.UnwrappedTileId> val_1 = new System.Collections.Generic.HashSet<Mapbox.Map.UnwrappedTileId>();
            System.Collections.Generic.HashSet<Mapbox.Map.CanonicalTileId> val_2 = new System.Collections.Generic.HashSet<Mapbox.Map.CanonicalTileId>();
            if(((-1798037440) & 1) != 0)
            {
                    return val_1;
            }
            
            Mapbox.Utils.Vector2d val_5 = new Mapbox.Utils.Vector2d(x:  System.Math.Max(val1:  ???, val2:  -20037508.3427892), y:  System.Math.Max(val1:  ???, val2:  -20037508.3427892));
            Mapbox.Utils.Vector2d val_8 = new Mapbox.Utils.Vector2d(x:  System.Math.Min(val1:  ???, val2:  20037508.3427892), y:  System.Math.Min(val1:  ???, val2:  20037508.3427892));
            Mapbox.Map.UnwrappedTileId val_9 = Mapbox.Map.TileCover.WebMercatorToTileId(webMerc:  new Mapbox.Utils.Vector2d() {x = val_5.x, y = val_5.y}, zoom:  -1797993296);
            val_17 = val_9.Z;
            Mapbox.Map.UnwrappedTileId val_10 = Mapbox.Map.TileCover.WebMercatorToTileId(webMerc:  new Mapbox.Utils.Vector2d() {x = val_8.x, y = val_8.y}, zoom:  -1797993296);
            val_18 = val_17 >> 32;
            int val_11 = val_10.Z >> 32;
            if(val_18 > val_11)
            {
                    return val_1;
            }
            
            do
            {
                if(val_10.Y <= val_9.Y)
            {
                    do
            {
                val_19 = 0;
                if((val_2.Contains(item:  new Mapbox.Map.CanonicalTileId())) != true)
            {
                    bool val_13 = val_1.Add(item:  new Mapbox.Map.UnwrappedTileId() {Z = -1797993296, X = val_18, Y = val_10.Y});
                val_19 = 0;
                bool val_14 = val_2.Add(item:  new Mapbox.Map.CanonicalTileId());
            }
            
                val_17 = val_10.Y + 1;
            }
            while(val_17 <= val_9.Y);
            
            }
            
                val_18 = val_18 + 1;
            }
            while(val_18 <= val_11);
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Map.UnwrappedTileId CoordinateToTileId(Mapbox.Utils.Vector2d coord, int zoom)
        {
            double val_5 = 1;
            double val_7 = 180;
            double val_4 = 360;
            val_4 = (coord.y + val_7) / val_4;
            val_5 = val_4 * val_5;
            double val_3 = (coord.x * 3.14159265358979) / val_7;
            float val_6 = val_3;
            val_6 = 1 / val_6;
            val_6 = val_3 + val_6;
            double val_8 = 1;
            val_7 = val_6 / 3.14159265358979;
            val_7 = 1 - val_7;
            val_7 = val_7 * 0.5;
            val_8 = val_8 * val_7;
            return new Mapbox.Map.UnwrappedTileId() {Z = zoom, X = 69734400};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Map.UnwrappedTileId WebMercatorToTileId(Mapbox.Utils.Vector2d webMerc, int zoom)
        {
            double val_3 = 1;
            double val_2 = 20037508.3427892;
            double val_1 = webMerc.x / val_2;
            val_2 = webMerc.y / val_2;
            val_1 = val_1 + 1;
            val_2 = 1 - val_2;
            val_1 = val_1 * 0.5;
            val_2 = val_2 * 0.5;
            val_1 = val_1 * val_3;
            val_3 = val_2 * val_3;
            return new Mapbox.Map.UnwrappedTileId() {Z = zoom, X = 52948992};
        }
    
    }

}
