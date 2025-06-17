using UnityEngine;

namespace Mapbox.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class TileResource : IResource
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string _query;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal TileResource(string query)
        {
            this._query = query;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Map.TileResource MakeRaster(Mapbox.Map.CanonicalTileId id, string styleUrl)
        {
            ._query = System.String.Format(format:  "{0}/{1}", arg0:  Mapbox.Map.MapUtils.NormalizeStaticStyleURL(url:  (styleUrl == null) ? "mapbox://styles/mapbox/satellite-v9" : styleUrl), arg1:  id);
            return (Mapbox.Map.TileResource)new Mapbox.Map.TileResource();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static Mapbox.Map.TileResource MakeRetinaRaster(Mapbox.Map.CanonicalTileId id, string styleUrl)
        {
            ._query = System.String.Format(format:  "{0}/{1}@2x", arg0:  Mapbox.Map.MapUtils.NormalizeStaticStyleURL(url:  (styleUrl == null) ? "mapbox://styles/mapbox/satellite-v9" : styleUrl), arg1:  id);
            return (Mapbox.Map.TileResource)new Mapbox.Map.TileResource();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Map.TileResource MakeClassicRaster(Mapbox.Map.CanonicalTileId id, string mapId)
        {
            ._query = System.String.Format(format:  "{0}/{1}.png", arg0:  Mapbox.Map.MapUtils.MapIdToUrl(id:  (mapId == null) ? "mapbox.satellite" : mapId), arg1:  id);
            return (Mapbox.Map.TileResource)new Mapbox.Map.TileResource();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static Mapbox.Map.TileResource MakeClassicRetinaRaster(Mapbox.Map.CanonicalTileId id, string mapId)
        {
            ._query = System.String.Format(format:  "{0}/{1}@2x.png", arg0:  Mapbox.Map.MapUtils.MapIdToUrl(id:  (mapId == null) ? "mapbox.satellite" : mapId), arg1:  id);
            return (Mapbox.Map.TileResource)new Mapbox.Map.TileResource();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Map.TileResource MakeRawPngRaster(Mapbox.Map.CanonicalTileId id, string mapId)
        {
            ._query = System.String.Format(format:  "{0}/{1}.pngraw", arg0:  Mapbox.Map.MapUtils.MapIdToUrl(id:  (mapId == null) ? "mapbox.terrain-rgb" : mapId), arg1:  id);
            return (Mapbox.Map.TileResource)new Mapbox.Map.TileResource();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Map.TileResource MakeVector(Mapbox.Map.CanonicalTileId id, string mapId)
        {
            ._query = System.String.Format(format:  "{0}/{1}.vector.pbf", arg0:  Mapbox.Map.MapUtils.MapIdToUrl(id:  (mapId == null) ? "mapbox.mapbox-streets-v7" : mapId), arg1:  id);
            return (Mapbox.Map.TileResource)new Mapbox.Map.TileResource();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static Mapbox.Map.TileResource MakeStyleOptimizedVector(Mapbox.Map.CanonicalTileId id, string mapId, string optimizedStyleId, string modifiedDate)
        {
            object[] val_1 = new object[4];
            string val_3 = Mapbox.Map.MapUtils.MapIdToUrl(id:  (mapId == null) ? "mapbox.mapbox-streets-v7" : mapId);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_3 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_3 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_3;
            val_1[1] = id;
            val_1[2] = optimizedStyleId;
            val_1[3] = modifiedDate;
            ._query = System.String.Format(format:  "{0}/{1}.vector.pbf?style={2}@{3}", args:  val_1);
            return (Mapbox.Map.TileResource)new Mapbox.Map.TileResource();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetUrl()
        {
            var val_9;
            var val_10;
            var val_11;
            System.UriBuilder val_1 = null;
            val_9 = val_1;
            val_1 = new System.UriBuilder(uri:  this._query);
            if(val_1.Query != null)
            {
                    if(val_1.Query.Length >= 2)
            {
                goto label_5;
            }
            
            }
            
            val_10 = null;
            val_10 = null;
            if(val_9 != null)
            {
                goto label_15;
            }
            
            label_16:
            label_15:
            val_1.Query = Mapbox.Unity.Telemetry.TelemetryFactory.EventQuery;
            System.Uri val_5 = val_1.Uri;
            val_9 = ???;
            goto typeof(System.Uri).__il2cppRuntimeField_158;
            label_5:
            val_11 = null;
            val_11 = null;
            string val_8 = val_9.Query.Substring(startIndex:  1)(val_9.Query.Substring(startIndex:  1)) + "&"("&") + Mapbox.Unity.Telemetry.TelemetryFactory.EventQuery;
            if(val_9 != 0)
            {
                goto label_15;
            }
            
            goto label_16;
        }
    
    }

}
