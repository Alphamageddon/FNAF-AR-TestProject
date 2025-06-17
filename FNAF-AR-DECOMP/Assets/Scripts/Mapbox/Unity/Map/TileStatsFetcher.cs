using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TileStatsFetcher
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Mapbox.Unity.Map.TileStatsFetcher _instance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _filePath;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.Map.TileStatsFetcher Instance { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.Map.TileStatsFetcher get_Instance()
        {
            Mapbox.Unity.Map.TileStatsFetcher val_2;
            Mapbox.Unity.Map.TileStatsFetcher val_3 = Mapbox.Unity.Map.TileStatsFetcher._instance;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            Mapbox.Unity.Map.TileStatsFetcher val_1 = null;
            val_2 = val_1;
            val_1 = new Mapbox.Unity.Map.TileStatsFetcher();
            Mapbox.Unity.Map.TileStatsFetcher._instance = val_2;
            val_3 = Mapbox.Unity.Map.TileStatsFetcher._instance;
            return val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.TileStats GetTileStats(Mapbox.Unity.Map.VectorSourceType sourceType)
        {
            string val_3;
            var val_4;
            val_3 = sourceType;
            if(val_3 <= 1)
            {
                    System.IO.StreamReader val_1 = null;
                val_3 = val_1;
                val_1 = new System.IO.StreamReader(path:  this._filePath);
                val_4 = Mapbox.Json.JsonConvert.DeserializeObject<Mapbox.Unity.Map.TileStats>(value:  val_1);
                return (Mapbox.Unity.Map.TileStats)val_4;
            }
            
            val_4 = 0;
            return (Mapbox.Unity.Map.TileStats)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TileStatsFetcher()
        {
            this._filePath = "Assets/Mapbox/Unity/DataContainers/streets-v7-stats.json";
        }
    
    }

}
